﻿// <auto-generated />
using System;
using CarrilloShop2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarrilloShop2.Migrations
{
    [DbContext(typeof(AppDBcontext))]
    [Migration("20241129041932_Reisetodoooo")]
    partial class Reisetodoooo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarrilloShop2.Data.Models.Carrito", b =>
                {
                    b.Property<string>("CarritoID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CliID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CarritoID");

                    b.HasIndex("CliID")
                        .IsUnique()
                        .HasFilter("[CliID] IS NOT NULL");

                    b.ToTable("Carritos");
                });

            modelBuilder.Entity("CarrilloShop2.Data.Models.Cliente", b =>
                {
                    b.Property<string>("CliID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CliCelular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CliDir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CliEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CliFechReg")
                        .HasColumnType("datetime2");

                    b.Property<string>("CliNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CliPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CliID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("CarrilloShop2.Data.Models.Producto", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Descripccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("CarrilloShop2.Data.Models.Carrito", b =>
                {
                    b.HasOne("CarrilloShop2.Data.Models.Cliente", "Cliente")
                        .WithOne("Carrito")
                        .HasForeignKey("CarrilloShop2.Data.Models.Carrito", "CliID");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("CarrilloShop2.Data.Models.Cliente", b =>
                {
                    b.Navigation("Carrito");
                });
#pragma warning restore 612, 618
        }
    }
}
