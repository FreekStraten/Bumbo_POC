﻿// <auto-generated />
using System;
using BumboPOC.Models.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BumboPOC.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20221014163447_Create")]
    partial class Create
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BumboPOC.Models.Departments", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<int>("Department")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

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

            modelBuilder.Entity("BumboPOC.Models.PlannedShift", b =>
                {
                    b.Property<int>("ShiftId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShiftId"), 1L, 1);

                    b.Property<int>("Department")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("PrognosisId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ShiftId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PrognosisId");

                    b.ToTable("PlannedShift");
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
                    b.Property<int>("DepartmentsEmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeesId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentsEmployeeId", "EmployeesId");

                    b.HasIndex("EmployeesId");

                    b.ToTable("DepartmentsEmployee");
                });

            modelBuilder.Entity("BumboPOC.Models.PlannedShift", b =>
                {
                    b.HasOne("BumboPOC.Models.Employee", "Employee")
                        .WithMany("PlannedShifts")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BumboPOC.Models.PrognosisDay", "PrognosisDay")
                        .WithMany("PlannedShifts")
                        .HasForeignKey("PrognosisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("PrognosisDay");
                });

            modelBuilder.Entity("DepartmentsEmployee", b =>
                {
                    b.HasOne("BumboPOC.Models.Departments", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BumboPOC.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BumboPOC.Models.Employee", b =>
                {
                    b.Navigation("PlannedShifts");
                });

            modelBuilder.Entity("BumboPOC.Models.PrognosisDay", b =>
                {
                    b.Navigation("PlannedShifts");
                });
#pragma warning restore 612, 618
        }
    }
}
