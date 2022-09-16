using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio.Entidades;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
  public class RepositorioCliente : IRepositorioCliente
  {
    private readonly AppContextDV _appContextDV;
    public RepositorioCliente(AppContextDV appContextDV)
    {
      _appContextDV = appContextDV;
    }
    Cliente IRepositorioCliente.AddCliente(Cliente cliente)
    {
      Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<Cliente> clienteAdicionado = _appContextDV.Clientes.Add(cliente);
      _ = _appContextDV.SaveChanges();
      return clienteAdicionado.Entity;

    }

    void IRepositorioCliente.DeleteCliente(int idCliente)
    {
      var clienteEncontrado = _appContextDV.Clientes.FirstOrDefault(p => p.Id == idCliente);
      if (clienteEncontrado == null)
      {
        return;
      }

      _appContextDV.Clientes.Remove(clienteEncontrado);
      _ = _appContextDV.SaveChanges();
    }



    IEnumerable<Cliente> IRepositorioCliente.GetAllClientes()
    {
      return _appContextDV.Clientes;
    }

    Cliente IRepositorioCliente.GetAllCliente(int idCliente)
    {
      return _appContextDV.Clientes.FirstOrDefault(p => p.Id == idCliente);
    }
    Cliente IRepositorioCliente.UpdateCliente(Cliente cliente)
    {
      var clienteEncontrado = _appContextDV.Clientes.FirstOrDefault(p => p.Id == cliente.Id);
      if (clienteEncontrado != null)
      {
        clienteEncontrado.Id = cliente.Id;
        // mascotaEncontrado.Cliente = mascota.Cliente;
        clienteEncontrado.Nombre = cliente.Nombre;
        clienteEncontrado.Apellidos = cliente.Apellidos;
        clienteEncontrado.NumeroTelefono = cliente.NumeroTelefono;
        clienteEncontrado.CorreoElectronico = cliente.CorreoElectronico;

        _appContextDV.SaveChanges();
      }
      return clienteEncontrado;
    }
  }
}