using MascotaFeliz.App.Dominio.Entidades;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{


  public class RepositorioVisita : IRepositorioVisita

  {
    private readonly AppContextDV _appContextDV;
    public RepositorioVisita(AppContextDV appContextDV)
    {
      _appContextDV = appContextDV;
    }
    Visita IRepositorioVisita.AddVisita(Visita visita)
    {
      Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<Visita> VisitaAdicionado = _appContextDV.Visitas.Add(visita);
      _ = _appContextDV.SaveChanges();
      return VisitaAdicionado.Entity;
    }
  }
}