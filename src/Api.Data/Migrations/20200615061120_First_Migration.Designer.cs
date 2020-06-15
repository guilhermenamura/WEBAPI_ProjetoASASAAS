﻿// <auto-generated />
using System;
using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Data.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20200615061120_First_Migration")]
    partial class First_Migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Api.Domain.Entities.ManagerEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Crm_START")
                        .HasColumnType("boolean");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("Faturamento_START")
                        .HasColumnType("boolean");

                    b.Property<string>("IPV4")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<int>("LICENSES")
                        .HasColumnType("integer")
                        .HasMaxLength(3);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(60)")
                        .HasMaxLength(60);

                    b.Property<int>("PORT")
                        .HasColumnType("integer")
                        .HasMaxLength(100);

                    b.Property<bool>("Site_START")
                        .HasColumnType("boolean");

                    b.Property<string>("TAG")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Vendas_START")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("Crm_START");

                    b.HasIndex("Email");

                    b.HasIndex("Faturamento_START");

                    b.HasIndex("IPV4");

                    b.HasIndex("LICENSES");

                    b.HasIndex("PORT");

                    b.HasIndex("Site_START");

                    b.HasIndex("TAG");

                    b.HasIndex("Vendas_START");

                    b.ToTable("Manager");
                });
#pragma warning restore 612, 618
        }
    }
}
