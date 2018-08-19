﻿// <auto-generated />
using System;
using CrossSolar.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrossSolar.Migrations
{
    [DbContext(typeof(CrossSolarDbContext))]
    partial class CrossSolarDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CrossSolar.Domain.OneHourElectricity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.Property<long>("KiloWatt");

                    b.Property<int>("PanelId");

                    b.HasKey("Id");

                    b.ToTable("OneHourElectricitys");
                });

            modelBuilder.Entity("CrossSolar.Domain.Panel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("Serial")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Panels");
                });
#pragma warning restore 612, 618
        }
    }
}
