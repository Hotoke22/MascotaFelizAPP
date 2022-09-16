using MascotaFeliz.App.Dominio.Entidades;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
  public class RepositorioVeterinario : IRepositorioVeterinario
  {
    private readonly AppContextDV _appContextDV;
    public RepositorioVeterinario(AppContextDV appContextDV)
    {
      _appContextDV = appContextDV;
    }
    Veterinario IRepositorioVeterinario.AddVeterinario(Veterinario veterinario)
    {
      Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<Veterinario> veterinarioAdicionado = _appContextDV.Veterinarios.Add(veterinario);
      _ = _appContextDV.SaveChanges();
      return veterinarioAdicionado.Entity;
    }
  }
}