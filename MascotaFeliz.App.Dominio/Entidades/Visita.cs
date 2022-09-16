using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MascotaFeliz.App.Dominio.Entidades
{
    public class Visita
    {
        public int Id { get; set; }
        public Veterinario Veterinario{ get; set; }
        public Cliente Cliente { get; set; }
        public Mascota Mascota { get; set; }
        public DateTime FechaVisita { get; set; }

        public float Temperatura { get; set; }

        public float Peso { get; set; }
        public int FrecuenciaCardiaca { get; set; }
        public int FrecuenciaRespiratoria { get; set; }

        public EstadoAnimo EstadoAnimo  { get; set; }
        public string Recomendaciones{ get; set; }
        public string FormulaMedicamentos { get; set; }
              
    }
}