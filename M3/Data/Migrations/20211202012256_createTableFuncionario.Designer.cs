﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Data.Migrations
{
    [DbContext(typeof(LabContext))]
    [Migration("20211202012256_createTableFuncionario")]
    partial class createTableFuncionario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Data.Models.SolicitacaoModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<decimal>("frete")
                        .HasColumnType("numeric");

                    b.Property<int>("nota")
                        .HasColumnType("integer");

                    b.Property<string>("ordemVenda")
                        .HasColumnType("text");

                    b.Property<DateTime>("prazoFim")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("prazoInicio")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("status")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("solicitacaos");
                });
#pragma warning restore 612, 618
        }
    }
}
