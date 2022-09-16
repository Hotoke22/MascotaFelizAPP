using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MascotaFeliz.App.Dominio.Entidades;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
  public interface IRepositorioCliente
  {
    IEnumerable<Cliente> GetAllClientes();
    Cliente AddCliente(Cliente cliente);
    Cliente UpdateCliente(Cliente cliente);
    void DeleteCliente(int idCliente);
    Cliente GetAllCliente(int idCliente);
  }
}