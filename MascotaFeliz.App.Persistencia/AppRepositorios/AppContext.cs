
using Microsoft.EntityFrameworkCore;
using MascotaFeliz.App.Dominio.Entidades;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
  public class AppContextDV : DbContext
  {
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Mascota> Mascotas { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Veterinario> Veterinarios { get; set; }
    public DbSet<Visita> Visitas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder
        .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MascotaFeliz_0");
      }
    }
  }
}
