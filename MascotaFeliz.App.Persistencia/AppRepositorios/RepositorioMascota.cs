using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio.Entidades;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
  public class RepositorioMascota : IRepositorioMascota
  {
    private readonly AppContextDV _appContextDV;
    public RepositorioMascota(AppContextDV appContextDV)
    {
      _appContextDV = appContextDV;
    }
    Mascota IRepositorioMascota.AddMascota(Mascota mascota)
    {
      Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<Mascota> mascotaAdicionado = _appContextDV.Mascotas.Add(mascota);
      _ = _appContextDV.SaveChanges();
      return mascotaAdicionado.Entity;

    }

    void IRepositorioMascota.DeleteMascota(int idmascota)
    {
      var mascotaEncontrado = _appContextDV.Mascotas.FirstOrDefault(p => p.Id == idmascota);
      if (mascotaEncontrado == null)
      {
        return;
      }

      _appContextDV.Mascotas.Remove(mascotaEncontrado);
      _appContextDV.SaveChanges();
    }



    IEnumerable<Mascota> IRepositorioMascota.GetAllMascotas()
    {
      return _appContextDV.Mascotas;
    }

    Mascota IRepositorioMascota.GetAllMascota(int idMascota)
    {
      return _appContextDV.Mascotas.FirstOrDefault(p => p.Id == idMascota);
    }
    Mascota IRepositorioMascota.UpdateMascota(Mascota mascota)
    {
      var mascotaEncontrado = _appContextDV.Mascotas.FirstOrDefault(p => p.Id == mascota.Id);
      if (mascotaEncontrado != null)
      {
        mascotaEncontrado.Id = mascota.Id;
        // mascotaEncontrado.Cliente = mascota.Cliente;
        mascotaEncontrado.Nombre = mascota.Nombre;
        mascotaEncontrado.Color = mascota.Color;
        mascotaEncontrado.Raza = mascota.Raza;
        mascotaEncontrado.FechaNacimiento = mascota.FechaNacimiento;
        mascotaEncontrado.Veterinario = mascota.Veterinario;

        _appContextDV.SaveChanges();
      }
      return mascotaEncontrado;
    }
  }

}