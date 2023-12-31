﻿// <auto-generated />
using System;
using Hospital.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hospital.DAL.Migrations
{
    [DbContext(typeof(HospitalContext))]
    [Migration("20230612004632_addingData")]
    partial class addingData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hospital.DAL.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PerformanceRate")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bff53872-8091-4979-8464-91fb0e9c820b"),
                            Name = "Eslam",
                            PerformanceRate = 1,
                            Salary = 1000m,
                            Specialization = "aaa"
                        },
                        new
                        {
                            Id = new Guid("15c9c9c8-b251-40b2-8c84-7f9ab5fa0f2a"),
                            Name = "Ahmed",
                            PerformanceRate = 2,
                            Salary = 2000m,
                            Specialization = "aaa"
                        },
                        new
                        {
                            Id = new Guid("75822bee-c0c3-412d-b378-d22d9f0279bc"),
                            Name = "Ali",
                            PerformanceRate = 3,
                            Salary = 3000m,
                            Specialization = "aaa"
                        },
                        new
                        {
                            Id = new Guid("b449274c-b096-47d5-a48f-6bfee60b5d06"),
                            Name = "Mostafa",
                            PerformanceRate = 4,
                            Salary = 4000m,
                            Specialization = "aaa"
                        },
                        new
                        {
                            Id = new Guid("bd6f419e-b227-4527-924a-b6bdf66a5247"),
                            Name = "Mohamed",
                            PerformanceRate = 5,
                            Salary = 5000m,
                            Specialization = "aaa"
                        },
                        new
                        {
                            Id = new Guid("f2281eaf-e5fe-470c-a0e1-3da8d1050081"),
                            Name = "Sally",
                            PerformanceRate = 6,
                            Salary = 6000m,
                            Specialization = "aaa"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
