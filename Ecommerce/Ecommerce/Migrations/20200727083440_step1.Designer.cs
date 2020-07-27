﻿// <auto-generated />
using System;
using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ecommerce.Migrations
{
    [DbContext(typeof(ApplicationDbcontext))]
    [Migration("20200727083440_step1")]
    partial class step1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ecommerce.Models.ApplicationProgram", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArabicName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnglishName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Program");
                });

            modelBuilder.Entity("Ecommerce.Models.Parameter", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArabicName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnglishName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReportID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ReportID");

                    b.ToTable("Parameters");
                });

            modelBuilder.Entity("Ecommerce.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Ecommerce.Models.Report", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ApplicationProgramID")
                        .HasColumnType("int");

                    b.Property<string>("ArabicName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnglishName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ApplicationProgramID");

                    b.ToTable("Rports");
                });

            modelBuilder.Entity("Ecommerce.Models.ViewapplicationData", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ReportID")
                        .HasColumnType("int");

                    b.Property<int>("paramID")
                        .HasColumnType("int");

                    b.Property<string>("parameterArabicName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("parameterEnglishName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("paramrepID")
                        .HasColumnType("int");

                    b.Property<int>("progID")
                        .HasColumnType("int");

                    b.Property<string>("progarmArabicName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("progarmEnglishName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("repID")
                        .HasColumnType("int");

                    b.Property<string>("reportArabicName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("reportEnglishName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("repprogID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("ViewapplicationData");
                });

            modelBuilder.Entity("Ecommerce.Models.Parameter", b =>
                {
                    b.HasOne("Ecommerce.Models.Report", null)
                        .WithMany("Reports")
                        .HasForeignKey("ReportID");
                });

            modelBuilder.Entity("Ecommerce.Models.Report", b =>
                {
                    b.HasOne("Ecommerce.Models.ApplicationProgram", null)
                        .WithMany("Reports")
                        .HasForeignKey("ApplicationProgramID");
                });
#pragma warning restore 612, 618
        }
    }
}
