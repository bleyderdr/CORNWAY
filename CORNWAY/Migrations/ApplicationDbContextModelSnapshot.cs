﻿// <auto-generated />
using CORNWAY.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CORNWAY.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CORNWAY.Model.Arma", b =>
                {
                    b.Property<int>("ArmaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArmaId"));

                    b.Property<int>("Daño")
                        .HasColumnType("int");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArmaId");

                    b.ToTable("Arma");
                });

            modelBuilder.Entity("CORNWAY.Model.Enemigo", b =>
                {
                    b.Property<int>("EnemigoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnemigoId"));

                    b.Property<int>("Daño")
                        .HasColumnType("int");

                    b.Property<int>("Recompensa")
                        .HasColumnType("int");

                    b.Property<int>("Vida")
                        .HasColumnType("int");

                    b.HasKey("EnemigoId");

                    b.ToTable("Enemigo");
                });

            modelBuilder.Entity("CORNWAY.Model.Fertilizante", b =>
                {
                    b.Property<int>("FertiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FertiId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FertiId");

                    b.ToTable("Fertilizante");
                });

            modelBuilder.Entity("CORNWAY.Model.Herramienta", b =>
                {
                    b.Property<int>("HerramientaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HerramientaId"));

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HerramientaId");

                    b.ToTable("Herramienta");
                });

            modelBuilder.Entity("CORNWAY.Model.Mascota", b =>
                {
                    b.Property<int>("MascotaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MascotaId"));

                    b.Property<int>("Daño")
                        .HasColumnType("int");

                    b.Property<int>("Vida")
                        .HasColumnType("int");

                    b.HasKey("MascotaId");

                    b.ToTable("Mascota");
                });

            modelBuilder.Entity("CORNWAY.Model.Personaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArmaId")
                        .HasColumnType("int");

                    b.Property<int>("Dinero")
                        .HasColumnType("int");

                    b.Property<int>("EnemigoId")
                        .HasColumnType("int");

                    b.Property<int>("FertiId")
                        .HasColumnType("int");

                    b.Property<int>("HerramientaId")
                        .HasColumnType("int");

                    b.Property<int>("Maiz")
                        .HasColumnType("int");

                    b.Property<int>("MascotaId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SemillaId")
                        .HasColumnType("int");

                    b.Property<int>("Vida")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArmaId");

                    b.HasIndex("EnemigoId");

                    b.HasIndex("FertiId");

                    b.HasIndex("HerramientaId");

                    b.HasIndex("MascotaId");

                    b.HasIndex("SemillaId");

                    b.ToTable("Personaje");
                });

            modelBuilder.Entity("CORNWAY.Model.Semilla", b =>
                {
                    b.Property<int>("SemillaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SemillaId"));

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<int>("TiempoCrecimiento")
                        .HasColumnType("int");

                    b.HasKey("SemillaId");

                    b.ToTable("Semilla");
                });

            modelBuilder.Entity("CORNWAY.Model.Sensor", b =>
                {
                    b.Property<int>("SensorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SensorId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SensorId");

                    b.ToTable("Sensor");
                });

            modelBuilder.Entity("CORNWAY.Model.Terreno", b =>
                {
                    b.Property<int>("TerrenoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TerrenoId"));

                    b.Property<int>("FertiId")
                        .HasColumnType("int");

                    b.Property<string>("Humedad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SensorId")
                        .HasColumnType("int");

                    b.Property<string>("Temperatura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TerrenoId");

                    b.HasIndex("FertiId");

                    b.HasIndex("SensorId");

                    b.ToTable("Terreno");
                });

            modelBuilder.Entity("CORNWAY.Model.Personaje", b =>
                {
                    b.HasOne("CORNWAY.Model.Arma", "Arma")
                        .WithMany()
                        .HasForeignKey("ArmaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CORNWAY.Model.Enemigo", "Enemigo")
                        .WithMany()
                        .HasForeignKey("EnemigoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CORNWAY.Model.Fertilizante", "Fertilizante")
                        .WithMany()
                        .HasForeignKey("FertiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CORNWAY.Model.Herramienta", "Herramienta")
                        .WithMany()
                        .HasForeignKey("HerramientaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CORNWAY.Model.Mascota", "Mascota")
                        .WithMany()
                        .HasForeignKey("MascotaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CORNWAY.Model.Semilla", "Semilla")
                        .WithMany()
                        .HasForeignKey("SemillaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Arma");

                    b.Navigation("Enemigo");

                    b.Navigation("Fertilizante");

                    b.Navigation("Herramienta");

                    b.Navigation("Mascota");

                    b.Navigation("Semilla");
                });

            modelBuilder.Entity("CORNWAY.Model.Terreno", b =>
                {
                    b.HasOne("CORNWAY.Model.Fertilizante", "Fertilizante")
                        .WithMany()
                        .HasForeignKey("FertiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CORNWAY.Model.Sensor", "Sensor")
                        .WithMany()
                        .HasForeignKey("SensorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fertilizante");

                    b.Navigation("Sensor");
                });
#pragma warning restore 612, 618
        }
    }
}
