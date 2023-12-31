﻿// <auto-generated />
using System;
using Hospital.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hospital.DAL.Migrations
{
    [DbContext(typeof(HospitalContext))]
    partial class HospitalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("147ad45d-0b6d-4897-83c4-ddbf7998b243"),
                            Name = "Eslam",
                            PerformanceRate = 1,
                            Salary = 1000m,
                            Specialization = "aaa"
                        },
                        new
                        {
                            Id = new Guid("7f3519b7-d118-4667-870e-d5530b841967"),
                            Name = "Ahmed",
                            PerformanceRate = 2,
                            Salary = 2000m,
                            Specialization = "aaa"
                        },
                        new
                        {
                            Id = new Guid("8c3eead3-1691-4c32-b60d-016c797e1f3c"),
                            Name = "Ali",
                            PerformanceRate = 3,
                            Salary = 3000m,
                            Specialization = "aaa"
                        },
                        new
                        {
                            Id = new Guid("a3b3f9e7-210a-430b-b532-8cd0ec22c72f"),
                            Name = "Mostafa",
                            PerformanceRate = 4,
                            Salary = 4000m,
                            Specialization = "aaa"
                        },
                        new
                        {
                            Id = new Guid("8455eca6-3890-4426-af2a-ebd57e5070b4"),
                            Name = "Mohamed",
                            PerformanceRate = 5,
                            Salary = 5000m,
                            Specialization = "aaa"
                        },
                        new
                        {
                            Id = new Guid("a35ab2ad-3022-4509-a866-fc769d7b0fdd"),
                            Name = "Sally",
                            PerformanceRate = 6,
                            Salary = 6000m,
                            Specialization = "aaa"
                        });
                });

            modelBuilder.Entity("Hospital.DAL.Issue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Issues");
                });

            modelBuilder.Entity("Hospital.DAL.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("968c5fb6-43d4-4979-b79d-af221cc4a613"),
                            DoctorId = new Guid("b449274c-b096-47d5-a48f-6bfee60b5d06"),
                            Name = "Ahmed"
                        },
                        new
                        {
                            Id = new Guid("c6d53eab-0c67-4ab3-8587-a7ec89a05305"),
                            DoctorId = new Guid("15c9c9c8-b251-40b2-8c84-7f9ab5fa0f2a"),
                            Name = "Ali"
                        },
                        new
                        {
                            Id = new Guid("236b2eaa-7436-4fe9-a516-1fc4c453a784"),
                            DoctorId = new Guid("bff53872-8091-4979-8464-91fb0e9c820b"),
                            Name = "Kamal"
                        },
                        new
                        {
                            Id = new Guid("48671e8d-ddf4-401f-9eb6-59be9939dbbb"),
                            DoctorId = new Guid("bd6f419e-b227-4527-924a-b6bdf66a5247"),
                            Name = "Alaa"
                        },
                        new
                        {
                            Id = new Guid("ad5973c4-7350-4a88-a228-7ae3b4ddbff7"),
                            DoctorId = new Guid("b449274c-b096-47d5-a48f-6bfee60b5d06"),
                            Name = "Sara"
                        },
                        new
                        {
                            Id = new Guid("e0239963-b78a-4c6d-bb99-f194e9bc67c3"),
                            DoctorId = new Guid("b449274c-b096-47d5-a48f-6bfee60b5d06"),
                            Name = "Karma"
                        });
                });

            modelBuilder.Entity("IssuePatient", b =>
                {
                    b.Property<Guid>("IssuesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PatientsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IssuesId", "PatientsId");

                    b.HasIndex("PatientsId");

                    b.ToTable("IssuePatient");
                });

            modelBuilder.Entity("Hospital.DAL.Patient", b =>
                {
                    b.HasOne("Hospital.DAL.Doctor", "Doctor")
                        .WithMany("Patients")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("IssuePatient", b =>
                {
                    b.HasOne("Hospital.DAL.Issue", null)
                        .WithMany()
                        .HasForeignKey("IssuesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital.DAL.Patient", null)
                        .WithMany()
                        .HasForeignKey("PatientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hospital.DAL.Doctor", b =>
                {
                    b.Navigation("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}
