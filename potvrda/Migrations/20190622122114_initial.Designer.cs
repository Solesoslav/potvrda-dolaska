﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using potvrda.Models;

namespace potvrda.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190622122114_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("potvrda.Models.OdgovoriRoditelja", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("ImeDeteta")
                        .IsRequired();

                    b.Property<string>("ImeRoditelja")
                        .IsRequired();

                    b.Property<bool?>("PotvrdaDolaska");

                    b.Property<string>("Telefon");

                    b.Property<bool?>("Viber");

                    b.HasKey("Id");

                    b.ToTable("Odgovori");
                });
#pragma warning restore 612, 618
        }
    }
}