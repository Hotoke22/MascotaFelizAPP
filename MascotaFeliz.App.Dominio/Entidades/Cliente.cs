using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MascotaFeliz.App.Dominio.Entidades
{
  public class Cliente : Persona
  {
    //Mascota o Mascotas pertenecientes a un Cliente
    public System.Collections.Generic.List<Mascota> Mascotas { get; set; }

  }
}