﻿// <auto-generated />
using CORNWAY.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CORNWAY.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240427155407_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
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

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("PersonajeId")
                        .HasColumnType("int");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ArmaId");

                    b.HasIndex("PersonajeId");

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

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Recompenza")
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

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("FertiId");

                    b.ToTable("Fertilizante");
                });

            modelBuilder.Entity("CORNWAY.Model.Herramienta", b =>
                {
                    b.Property<int>("HerramientaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HerramientaId"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("PersonajeId")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("HerramientaId");

                    b.HasIndex("PersonajeId");

                    b.ToTable("Herramienta");
                });

            modelBuilder.Entity("CORNWAY.Model.Logro", b =>
                {
                    b.Property<int>("LogroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LogroId"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("LogroId");

                    b.ToTable("Logro");
                });

            modelBuilder.Entity("CORNWAY.Model.Mascota", b =>
                {
                    b.Property<int>("MascotaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MascotaId"));

                    b.Property<int>("Daño")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("PersonajeId")
                        .HasColumnType("int");

                    b.Property<int>("Vida")
                        .HasColumnType("int");

                    b.HasKey("MascotaId");

                    b.HasIndex("PersonajeId");

                    b.ToTable("Mascota");
                });

            modelBuilder.Entity("CORNWAY.Model.Personaje", b =>
                {
                    b.Property<int>("PersonajeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonajeId"));

                    b.Property<int>("Dinero")
                        .HasColumnType("int");

                    b.Property<int>("EnemigoId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Maiz")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Vida")
                        .HasColumnType("int");

                    b.HasKey("PersonajeId");

                    b.HasIndex("EnemigoId");

                    b.ToTable("Personaje");
                });

            modelBuilder.Entity("CORNWAY.Model.Semilla", b =>
                {
                    b.Property<int>("SemillaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SemillaId"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("PersonajeId")
                        .HasColumnType("int");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<int>("TiempoCrecimiento")
                        .HasColumnType("int");

                    b.HasKey("SemillaId");

                    b.HasIndex("PersonajeId");

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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TerrenoId")
                        .HasColumnType("int");

                    b.HasKey("SensorId");

                    b.HasIndex("TerrenoId");

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

                    b.Property<int>("Humedad")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("SemillaId")
                        .HasColumnType("int");

                    b.Property<int>("Temperatura")
                        .HasColumnType("int");

                    b.HasKey("TerrenoId");

                    b.HasIndex("FertiId");

                    b.HasIndex("SemillaId");

                    b.ToTable("Terreno");
                });

            modelBuilder.Entity("CORNWAY.Model.TipoUser", b =>
                {
                    b.Property<int>("TipoUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoUserId"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TipoUserId");

                    b.ToTable("TipoUser");
                });

            modelBuilder.Entity("CORNWAY.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("LogroId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PersonajeId")
                        .HasColumnType("int");

                    b.Property<int>("TipoUserId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.HasIndex("LogroId");

                    b.HasIndex("PersonajeId");

                    b.HasIndex("TipoUserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CORNWAY.Model.Arma", b =>
                {
                    b.HasOne("CORNWAY.Model.Personaje", "Personaje")
                        .WithMany()
                        .HasForeignKey("PersonajeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personaje");
                });

            modelBuilder.Entity("CORNWAY.Model.Herramienta", b =>
                {
                    b.HasOne("CORNWAY.Model.Personaje", "Personaje")
                        .WithMany()
                        .HasForeignKey("PersonajeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personaje");
                });

            modelBuilder.Entity("CORNWAY.Model.Mascota", b =>
                {
                    b.HasOne("CORNWAY.Model.Personaje", "Personaje")
                        .WithMany()
                        .HasForeignKey("PersonajeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personaje");
                });

            modelBuilder.Entity("CORNWAY.Model.Personaje", b =>
                {
                    b.HasOne("CORNWAY.Model.Enemigo", "Enemigo")
                        .WithMany()
                        .HasForeignKey("EnemigoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enemigo");
                });

            modelBuilder.Entity("CORNWAY.Model.Semilla", b =>
                {
                    b.HasOne("CORNWAY.Model.Personaje", "Personaje")
                        .WithMany()
                        .HasForeignKey("PersonajeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personaje");
                });

            modelBuilder.Entity("CORNWAY.Model.Sensor", b =>
                {
                    b.HasOne("CORNWAY.Model.Terreno", "Terreno")
                        .WithMany()
                        .HasForeignKey("TerrenoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Terreno");
                });

            modelBuilder.Entity("CORNWAY.Model.Terreno", b =>
                {
                    b.HasOne("CORNWAY.Model.Fertilizante", "Fertilizante")
                        .WithMany()
                        .HasForeignKey("FertiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CORNWAY.Model.Semilla", "Semilla")
                        .WithMany()
                        .HasForeignKey("SemillaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fertilizante");

                    b.Navigation("Semilla");
                });

            modelBuilder.Entity("CORNWAY.Model.User", b =>
                {
                    b.HasOne("CORNWAY.Model.Logro", "Logro")
                        .WithMany()
                        .HasForeignKey("LogroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CORNWAY.Model.Personaje", "Personaje")
                        .WithMany()
                        .HasForeignKey("PersonajeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CORNWAY.Model.TipoUser", "TipoUser")
                        .WithMany()
                        .HasForeignKey("TipoUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Logro");

                    b.Navigation("Personaje");

                    b.Navigation("TipoUser");
                });
#pragma warning restore 612, 618
        }
    }
}