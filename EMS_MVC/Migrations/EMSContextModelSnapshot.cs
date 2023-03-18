﻿// <auto-generated />
using System;
using EMS_MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EMS_MVC.Migrations
{
    [DbContext(typeof(EMSContext))]
    partial class EMSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EMS_MVC.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Departments", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Administration"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Security"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Accounting"
                        });
                });

            modelBuilder.Entity("EMS_MVC.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Employees", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DateOfBirth = new DateTime(2023, 3, 17, 18, 22, 18, 729, DateTimeKind.Local).AddTicks(1194),
                            DepartmentID = 1,
                            Email = "steve@mojang.com",
                            Name = "Minecraft Steve",
                            Phone = "09123456789"
                        },
                        new
                        {
                            ID = 2,
                            DateOfBirth = new DateTime(2023, 3, 17, 18, 22, 18, 729, DateTimeKind.Local).AddTicks(1210),
                            DepartmentID = 1,
                            Email = "bob@dpwh.gov.ph",
                            Name = "Bob Builder",
                            Phone = "09876543210"
                        },
                        new
                        {
                            ID = 3,
                            DateOfBirth = new DateTime(2023, 3, 17, 18, 22, 18, 729, DateTimeKind.Local).AddTicks(1212),
                            DepartmentID = 2,
                            Email = "magik@limbo.com",
                            Name = "Ilyana Rasputin",
                            Phone = "096161963"
                        },
                        new
                        {
                            ID = 4,
                            DateOfBirth = new DateTime(2023, 3, 17, 18, 22, 18, 729, DateTimeKind.Local).AddTicks(1214),
                            DepartmentID = 2,
                            Email = "sistergrimm@aol.com",
                            Name = "Nico Minoru",
                            Phone = "09666666666"
                        },
                        new
                        {
                            ID = 5,
                            DateOfBirth = new DateTime(2023, 3, 17, 18, 22, 18, 729, DateTimeKind.Local).AddTicks(1216),
                            DepartmentID = 3,
                            Email = "redhood@batman.com",
                            Name = "Jason Todd",
                            Phone = "09101010101"
                        });
                });

            modelBuilder.Entity("EMS_MVC.Models.Employee", b =>
                {
                    b.HasOne("EMS_MVC.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EMS_MVC.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
