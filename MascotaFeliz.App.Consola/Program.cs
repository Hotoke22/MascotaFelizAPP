using System.Collections.Generic;
using System;
using MascotaFeliz.App.Dominio.Entidades;
using MascotaFeliz.App.Persistencia.AppRepositorios;

namespace MascotaFeliz.App.Consola
{
  class Program
  {
    private static IRepositorioCliente _repoCliente = new RepositorioCliente(new Persistencia.AppRepositorios.AppContextDV());
    private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppRepositorios.AppContextDV());
    private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppRepositorios.AppContextDV());
    private static IRepositorioVisita _repoVisita = new RepositorioVisita(new Persistencia.AppRepositorios.AppContextDV());
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World! Entity Framework David Velandia");
    //AddCliente();
    //AddVeterinario();
    //AddMascota();
    AddVisita();
    }
    private static void AddCliente()
    {
      var cliente = new Cliente
      {
        
        Nombre = "Sandra Marcela",
        Apellidos = "Reyes Ospina",
        NumeroTelefono = "3202411529",
        CorreoElectronico = "comercial@tmcsas.com"

      };
      _repoCliente.AddCliente(cliente);
    }
    private static void AddMascota()
    {
      var mascota = new Mascota
      {
        Nombre = "Negra",
        Color = "Negro",
        Raza = "Indeterminada",
        Genero = Genero.Macho,
        FechaNacimiento = new DateTime(2010, 08, 25)

      };
      _repoMascota.AddMascota(mascota);
    }
      
    private static void AddVeterinario()
    {
      var veterinario = new Veterinario
      {
        
        Nombre = "Jose Manuel",
        Apellidos = "Lopez ",
        NumeroTelefono = "3138699366",
        CorreoElectronico = "david.velandia.laverde@gmail.com",
        TarjetaProfesional = "1234567-890"

      };
      _repoVeterinario.AddVeterinario(veterinario);
    }
    private static void AddVisita()
    {
      var visita = new Visita
      {
        Veterinario = 1,
        FechaVisita = new DateTime(2022, 09, 01),
        Temperatura = 36.5F,
        Peso = 25,
        FrecuenciaCardiaca= 90,
        FrecuenciaRespiratoria = 30,
        EstadoAnimo = EstadoAnimo.Abatido,
        Recomendaciones = "Desparasitar",
        FormulaMedicamentos = "Purga Canina"
        
      };
      _repoVisita.AddVisita(visita);
      Console.WriteLine("Visita Adicionada:"+ visita.FechaVisita);
    }
      
  }
}