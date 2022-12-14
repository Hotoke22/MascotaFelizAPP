// <auto-generated />
using System;
using MascotaFeliz.App.Persistencia.AppRepositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MascotaFeliz.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContextDV))]
    [Migration("20220908195420_Uno")]
    partial class Uno
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Entidades.Mascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Raza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VeterinarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("VeterinarioId");

                    b.ToTable("Mascotas");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Entidades.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorreoElectronico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Entidades.Visita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("EstadoAnimo")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaVisita")
                        .HasColumnType("datetime2");

                    b.Property<string>("FormulaMedicamentos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FrecuenciaCardiaca")
                        .HasColumnType("int");

                    b.Property<int>("FrecuenciaRespiratoria")
                        .HasColumnType("int");

                    b.Property<int?>("MascotaId")
                        .HasColumnType("int");

                    b.Property<float>("Peso")
                        .HasColumnType("real");

                    b.Property<string>("Recomendaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Temperatura")
                        .HasColumnType("real");

                    b.Property<int?>("VeterinarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("MascotaId");

                    b.HasIndex("VeterinarioId");

                    b.ToTable("Visitas");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Entidades.Cliente", b =>
                {
                    b.HasBaseType("MascotaFeliz.App.Dominio.Entidades.Persona");

                    b.Property<int>("IdMascota")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Entidades.Usuario", b =>
                {
                    b.HasBaseType("MascotaFeliz.App.Dominio.Entidades.Persona");

                    b.Property<string>("Clave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Usuario");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Entidades.Veterinario", b =>
                {
                    b.HasBaseType("MascotaFeliz.App.Dominio.Entidades.Persona");

                    b.Property<string>("TarjetaProfesional")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Veterinario");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Entidades.Mascota", b =>
                {
                    b.HasOne("MascotaFeliz.App.Dominio.Entidades.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("MascotaFeliz.App.Dominio.Entidades.Veterinario", "Veterinario")
                        .WithMany()
                        .HasForeignKey("VeterinarioId");

                    b.Navigation("Cliente");

                    b.Navigation("Veterinario");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Entidades.Visita", b =>
                {
                    b.HasOne("MascotaFeliz.App.Dominio.Entidades.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("MascotaFeliz.App.Dominio.Entidades.Mascota", "Mascota")
                        .WithMany()
                        .HasForeignKey("MascotaId");

                    b.HasOne("MascotaFeliz.App.Dominio.Entidades.Veterinario", "Veterinario")
                        .WithMany()
                        .HasForeignKey("VeterinarioId");

                    b.Navigation("Cliente");

                    b.Navigation("Mascota");

                    b.Navigation("Veterinario");
                });
#pragma warning restore 612, 618
        }
    }
}
