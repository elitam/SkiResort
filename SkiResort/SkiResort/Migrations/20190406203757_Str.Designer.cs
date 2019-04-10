﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkiResort.Data;

namespace SkiResort.Migrations
{
    [DbContext(typeof(SkiResortContext))]
    [Migration("20190406203757_Str")]
    partial class Str
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SkiResort.Data.Models.Hike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EndPoint")
                        .IsRequired();

                    b.Property<decimal>("Length");

                    b.Property<string>("Rate");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("StartPoint")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Hikes");
                });

            modelBuilder.Entity("SkiResort.Data.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.Property<double>("Size");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("SkiResort.Data.Models.Lift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Length");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<bool>("NightSkiing");

                    b.Property<decimal>("VerticalRise");

                    b.Property<string>("WorkingHours")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Lifts");
                });

            modelBuilder.Entity("SkiResort.Data.Models.LiftPass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("liftPasses");
                });

            modelBuilder.Entity("SkiResort.Data.Models.Trail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LiftId");

                    b.Property<string>("Mode")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Trails");
                });
#pragma warning restore 612, 618
        }
    }
}
