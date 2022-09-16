using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MascotaFeliz.App.Dominio.Entidades
{
    public class Usuario : Persona
    {
        public string IdUsuario { get; set; }
        public string Clave { get; set; }
    }
}