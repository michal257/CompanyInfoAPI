﻿// <auto-generated />
using System;
using CompanyInformation.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CompanyInformation.Migrations
{
    [DbContext(typeof(CompanyInformationContext))]
    partial class CompanyInformationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CompanyInformation.Entities.CompanyInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("krs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("registrationLegalDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("regon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("requestDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("requestId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("statusVat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("workingAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CompanyInfos");
                });
#pragma warning restore 612, 618
        }
    }
}
