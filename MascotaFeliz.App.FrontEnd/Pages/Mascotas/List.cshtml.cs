using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MascotaFeliz.App.Dominio.Entidades;
using MascotaFeliz.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace MascotaFeliz.App.FrontEnd.Pages

{

  //[Authorize]
  public class ListModel : PageModel
  {
    private readonly IRepositorioMascota repositorioMascotas;

    public IEnumerable<Mascota> Mascotas { get; set; }


    public ListModel()
    {
      this.repositorioMascotas = new RepositorioMascota(new MascotaFeliz.App.Persistencia.AppRepositorios.AppContextDV());
    }

    public void OnGet(string filtroBusqueda)
    {
      Mascotas = repositorioMascotas.GetAllMascotas();

    }
  }
}

