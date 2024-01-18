﻿// <auto-generated />
using System;
using DesafioRodonaves.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DesafioRodonaves.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DesafioRodonaves.Domain.Entities.Collaborator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("nome");

                    b.Property<int>("UnitId")
                        .HasColumnType("integer")
                        .HasColumnName("id_unidade");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("id_usuario");

                    b.HasKey("Id");

                    b.ToTable("colaboradores", (string)null);
                });

            modelBuilder.Entity("DesafioRodonaves.Domain.Entities.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool?>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("status");

                    b.Property<string>("UnitCode")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("codigo_da_unidade");

                    b.Property<string>("UnitName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("nome_da_unidade");

                    b.HasKey("Id");

                    b.HasIndex("UnitCode")
                        .IsUnique();

                    b.HasIndex("UnitName")
                        .IsUnique();

                    b.ToTable("unidades", (string)null);
                });

            modelBuilder.Entity("DesafioRodonaves.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("nome_do_usuario");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("senha");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("Login")
                        .IsUnique();

                    b.ToTable("usuarios", (string)null);
                });

            modelBuilder.Entity("DesafioRodonaves.Domain.Entities.Collaborator", b =>
                {
                    b.HasOne("DesafioRodonaves.Domain.Entities.Unit", "UnitNavigation")
                        .WithOne("CollaboratorNavigation")
                        .HasForeignKey("DesafioRodonaves.Domain.Entities.Collaborator", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DesafioRodonaves.Domain.Entities.User", "UserNavigation")
                        .WithOne("CollaboratorNavigation")
                        .HasForeignKey("DesafioRodonaves.Domain.Entities.Collaborator", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UnitNavigation");

                    b.Navigation("UserNavigation");
                });

            modelBuilder.Entity("DesafioRodonaves.Domain.Entities.Unit", b =>
                {
                    b.Navigation("CollaboratorNavigation")
                        .IsRequired();
                });

            modelBuilder.Entity("DesafioRodonaves.Domain.Entities.User", b =>
                {
                    b.Navigation("CollaboratorNavigation")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
