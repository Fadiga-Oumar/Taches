﻿// <auto-generated />
using ListeTache.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ListeTache.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240516010814_initialCreate")]
    partial class initialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ListeTache.Models.Tache", b =>
                {
                    b.Property<int>("TacheId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("TacheId"));

                    b.Property<bool>("TacheTerminee")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TacheId");

                    b.ToTable("Taches");
                });
#pragma warning restore 612, 618
        }
    }
}
