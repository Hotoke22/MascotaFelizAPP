using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MascotaFeliz.App.Dominio.Entidades;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVisita
    {
       Visita AddVisita(Visita visita);  
    }
}