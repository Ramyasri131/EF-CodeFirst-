﻿// <auto-generated />
using System;
using EmployeeDirectory.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeDirectory.DAL.Migrations
{
    [DbContext(typeof(RamyaEmployeeDirectoryDbContext))]
    partial class RamyaEmployeeDirectoryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeDirectory.DAL.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Description")
                        .IsUnique();

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EmployeeDirectory.DAL.Models.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<DateOnly>("DateOfJoin")
                        .HasColumnType("date");

                    b.Property<int>("Department")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobTitle")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Location")
                        .HasColumnType("int");

                    b.Property<int>("Manager")
                        .HasColumnType("int");

                    b.Property<long>("MobileNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("Project")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Department");

                    b.HasIndex("JobTitle");

                    b.HasIndex("Location");

                    b.HasIndex("Manager");

                    b.HasIndex("Project");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeeDirectory.DAL.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("EmployeeDirectory.DAL.Models.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("EmployeeDirectory.DAL.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("EmployeeDirectory.DAL.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Department")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Location")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Department");

                    b.HasIndex("Location");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("EmployeeDirectory.DAL.Models.Employee", b =>
                {
                    b.HasOne("EmployeeDirectory.DAL.Models.Department", "DepartmentNavigation")
                        .WithMany("Employees")
                        .HasForeignKey("Department")
                        .IsRequired();

                    b.HasOne("EmployeeDirectory.DAL.Models.Role", "JobTitleNavigation")
                        .WithMany("Employees")
                        .HasForeignKey("JobTitle")
                        .IsRequired();

                    b.HasOne("EmployeeDirectory.DAL.Models.Location", "LocationNavigation")
                        .WithMany("Employees")
                        .HasForeignKey("Location")
                        .IsRequired();

                    b.HasOne("EmployeeDirectory.DAL.Models.Manager", "ManagerNavigation")
                        .WithMany("Employees")
                        .HasForeignKey("Manager")
                        .IsRequired();

                    b.HasOne("EmployeeDirectory.DAL.Models.Project", "ProjectNavigation")
                        .WithMany("Employees")
                        .HasForeignKey("Project")
                        .IsRequired();

                    b.Navigation("DepartmentNavigation");

                    b.Navigation("JobTitleNavigation");

                    b.Navigation("LocationNavigation");

                    b.Navigation("ManagerNavigation");

                    b.Navigation("ProjectNavigation");
                });

            modelBuilder.Entity("EmployeeDirectory.DAL.Models.Role", b =>
                {
                    b.HasOne("EmployeeDirectory.DAL.Models.Department", "DepartmentNavigation")
                        .WithMany("Roles")
                        .HasForeignKey("Department")
                        .IsRequired();

                    b.HasOne("EmployeeDirectory.DAL.Models.Location", "LocationNavigation")
                        .WithMany("Roles")
                        .HasForeignKey("Location")
                        .IsRequired();

                    b.Navigation("DepartmentNavigation");

                    b.Navigation("LocationNavigation");
                });

            modelBuilder.Entity("EmployeeDirectory.DAL.Models.Department", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("EmployeeDirectory.DAL.Models.Location", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("EmployeeDirectory.DAL.Models.Manager", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("EmployeeDirectory.DAL.Models.Project", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("EmployeeDirectory.DAL.Models.Role", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
