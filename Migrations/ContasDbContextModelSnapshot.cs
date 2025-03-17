﻿// <auto-generated />
using System;
using ContasMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContasMVC.Migrations
{
    [DbContext(typeof(ContasDbContext))]
    partial class ContasDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.3");

            modelBuilder.Entity("ContasMVC.Models.DespesaModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<string>("Frequencia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Despesas");
                });

            modelBuilder.Entity("ContasMVC.Models.ReceitaModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Receitas");
                });
#pragma warning restore 612, 618
        }
    }
}
