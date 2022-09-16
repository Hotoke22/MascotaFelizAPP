using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MascotaFeliz.App.Dominio.Entidades;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
  public interface IRepositorioMascota
  {
    IEnumerable<Mascota> GetAllMascotas();
    Mascota AddMascota(Mascota mascota);
    Mascota UpdateMascota(Mascota mascota);
    void DeleteMascota(int idMascota);
    Mascota GetAllMascota(int idMascota);
  }
}