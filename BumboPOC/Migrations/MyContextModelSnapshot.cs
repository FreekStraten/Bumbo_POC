﻿// <auto-generated />
using System;
using BumboPOC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BumboPOC.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BumboPOC.Models.Departments", b =>
                {
                    b.Property<int>("DepartmentsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentsId"), 1L, 1);

                    b.Property<int>("Department")
                        .HasColumnType("int");

                    b.HasKey("DepartmentsId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("BumboPOC.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("BankNumber")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("BumboPOC.Models.PrognosisDay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AmountOfCollies")
                        .HasColumnType("int");

                    b.Property<int>("AmountOfCustomers")
                        .HasColumnType("int");

                    b.Property<double?>("CassiereDepartment")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double?>("FreshDepartment")
                        .HasColumnType("float");

                    b.Property<double?>("StockersDepartment")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Date")
                        .IsUnique();

                    b.ToTable("Prognosis");
                });

            modelBuilder.Entity("DepartmentsEmployee", b =>
                {
                    b.Property<int>("DepartmentsId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeesId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentsId", "EmployeesId");

                    b.HasIndex("EmployeesId");

                    b.ToTable("DepartmentsEmployee");
                });

            modelBuilder.Entity("DepartmentsEmployee", b =>
                {
                    b.HasOne("BumboPOC.Models.Departments", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BumboPOC.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
