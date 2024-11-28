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
    [Migration("20241128001541_MigracionClientes")]
    partial class MigracionClientes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarrilloShop2.Models.Cliente", b =>
                {
                    b.Property<string>("CliCorreo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CliAntiguedad")
                        .HasColumnType("int");

                    b.Property<string>("CliApellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CliCelular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CliDir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CliFechReg")
                        .HasColumnType("datetime2");

                    b.Property<string>("CliNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CliTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CliCorreo");

                    b.ToTable("Clientes");
                });
#pragma warning restore 612, 618
        }
    }
}
