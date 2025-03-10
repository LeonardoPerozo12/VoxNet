﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VoxNet.Context;

#nullable disable

namespace VoxNet.Migrations
{
    [DbContext(typeof(VoxNetContext))]
    [Migration("20240628170332_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("VoxNet.Models.Categoria", b =>
                {
                    b.Property<int>("IdCategoriaProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdCategoriaProducto"));

                    b.Property<string>("CategoriaProducto")
                        .HasColumnType("longtext");

                    b.HasKey("IdCategoriaProducto");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("VoxNet.Models.Clientes", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdCliente"));

                    b.Property<string>("CedulaCliente")
                        .HasColumnType("longtext");

                    b.Property<string>("CorreoCliente")
                        .HasColumnType("longtext");

                    b.Property<string>("DireccionCliente")
                        .HasColumnType("longtext");

                    b.Property<string>("NombreCliente")
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordCliente")
                        .HasColumnType("longtext");

                    b.Property<string>("TelefonoCliente")
                        .HasColumnType("longtext");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("VoxNet.Models.Comprobante", b =>
                {
                    b.Property<int>("IdTipoComprobante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdTipoComprobante"));

                    b.Property<string>("tipoComprobante")
                        .HasColumnType("longtext");

                    b.HasKey("IdTipoComprobante");

                    b.ToTable("Comprobantes");
                });

            modelBuilder.Entity("VoxNet.Models.Contratos", b =>
                {
                    b.Property<int>("IdContrato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdContrato"));

                    b.Property<string>("DescripcionContrato")
                        .HasColumnType("longtext");

                    b.Property<int>("EstadoContrato")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFinContrato")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("FechaInicioContrato")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdServicio")
                        .HasColumnType("int");

                    b.HasKey("IdContrato");

                    b.ToTable("Contratos");
                });

            modelBuilder.Entity("VoxNet.Models.Empleados", b =>
                {
                    b.Property<int>("IdEmpleado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdEmpleado"));

                    b.Property<string>("ApellidoEmpleado")
                        .HasColumnType("longtext");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.Property<string>("NombreEmpleado")
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordEmpleado")
                        .HasColumnType("longtext");

                    b.HasKey("IdEmpleado");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("VoxNet.Models.Facturas", b =>
                {
                    b.Property<int>("IdFactura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdFactura"));

                    b.Property<int>("CantidadFactura")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFactura")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdEmpleado")
                        .HasColumnType("int");

                    b.Property<int>("IdSucursal")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoComprobante")
                        .HasColumnType("int");

                    b.Property<float>("ImpuestosFactura")
                        .HasColumnType("float");

                    b.Property<string>("MetodoPagoFactura")
                        .HasColumnType("longtext");

                    b.Property<float>("TotalFactura")
                        .HasColumnType("float");

                    b.HasKey("IdFactura");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("VoxNet.Models.Productos", b =>
                {
                    b.Property<int>("IdProductos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdProductos"));

                    b.Property<string>("DescripcionProducto")
                        .HasColumnType("longtext");

                    b.Property<int>("DisponibilidadProdcuto")
                        .HasColumnType("int");

                    b.Property<int>("IdCategoriaProducto")
                        .HasColumnType("int");

                    b.Property<string>("NombreProducto")
                        .HasColumnType("longtext");

                    b.Property<float>("PrecioProdcuto")
                        .HasColumnType("float");

                    b.HasKey("IdProductos");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("VoxNet.Models.ProductosFacturas", b =>
                {
                    b.Property<int>("IdFactura")
                        .HasColumnType("int");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.HasKey("IdFactura", "IdProducto");

                    b.ToTable("ProductosFacturas");
                });

            modelBuilder.Entity("VoxNet.Models.Roles", b =>
                {
                    b.Property<int>("IdRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdRol"));

                    b.Property<string>("NombreRol")
                        .HasColumnType("longtext");

                    b.HasKey("IdRol");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("VoxNet.Models.Servicios", b =>
                {
                    b.Property<int>("IdServicios")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdServicios"));

                    b.Property<string>("DescripcionServicios")
                        .HasColumnType("longtext");

                    b.Property<string>("NombreServicios")
                        .HasColumnType("longtext");

                    b.Property<float>("PrecioServicios")
                        .HasColumnType("float");

                    b.HasKey("IdServicios");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("VoxNet.Models.Sucursales", b =>
                {
                    b.Property<int>("IdSucursal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdSucursal"));

                    b.Property<string>("DireccionSucursal")
                        .HasColumnType("longtext");

                    b.Property<string>("NombreSucursal")
                        .HasColumnType("longtext");

                    b.Property<string>("TelefenoSucursal")
                        .HasColumnType("longtext");

                    b.HasKey("IdSucursal");

                    b.ToTable("Sucursales");
                });
#pragma warning restore 612, 618
        }
    }
}
