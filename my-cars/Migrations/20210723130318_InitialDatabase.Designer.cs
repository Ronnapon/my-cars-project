﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using my_cars.Data;

namespace my_cars.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210723130318_InitialDatabase")]
    partial class InitialDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("my_cars.Data.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("FlagActive")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Fname")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Gender")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Lname")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("ModifyDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Tel")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("TitleId")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TitleId");

                    b.ToTable("admins");
                });

            modelBuilder.Entity("my_cars.Data.Models.AdminLogin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdminId")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("FlagActive")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime?>("ModifyDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("UserName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UserPass")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("adminLogins");
                });

            modelBuilder.Entity("my_cars.Data.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarId")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<int>("CustomerId")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlagActive")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("GarageId")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifyDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("GarageId");

                    b.ToTable("appointments");
                });

            modelBuilder.Entity("my_cars.Data.Models.AppointmentDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AppDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<DateTime>("AppTime")
                        .HasMaxLength(20)
                        .HasColumnType("datetime");

                    b.Property<int>("AppointmentId")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<DateTime>("CancelDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<DateTime>("ConfirmDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<DateTime>("CreatedDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<DateTime>("FinishDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("FlagActive")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("ModifyDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("Postpone")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ReasonDesc")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("ReasonId")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ReasonId");

                    b.ToTable("appointmentDetails");
                });

            modelBuilder.Entity("my_cars.Data.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarBrandId")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<int>("CarModelId")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<int>("CustomerId")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<string>("FlagActive")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("LicenseId")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifyDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("Province")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("CarBrandId");

                    b.HasIndex("CarModelId");

                    b.HasIndex("CustomerId");

                    b.ToTable("cars");
                });

            modelBuilder.Entity("my_cars.Data.Models.CarBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdminId")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("BrandCode")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("BrandName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("FlagActive")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("ModifyDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("carBrands");
                });

            modelBuilder.Entity("my_cars.Data.Models.CarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<string>("BrandCode")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("CarBrandId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("FlagActive")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("ModelCode")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("ModelName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ModelYear")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime?>("ModifyDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("SubModelName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("CarBrandId");

                    b.ToTable("carModels");
                });

            modelBuilder.Entity("my_cars.Data.Models.CustLogin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<int>("CustomerId")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<string>("ExpirePass")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FlagActive")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("ModifyDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("UserName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UserPass")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("custLogins");
                });

            modelBuilder.Entity("my_cars.Data.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FlagActive")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Fname")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Gender")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Lname")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("ModifyDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Tel")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("TitleId")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TitleId");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("my_cars.Data.Models.EmpLogin", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("CreatedDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<int>("EmployeeId")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<string>("ExpirePass")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("ExpiryDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("FlagActive")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime?>("ModifyDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("UserName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UserPass")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("empLogins");
                });

            modelBuilder.Entity("my_cars.Data.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("CreatedDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("FlagActive")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Fname")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("GarageId")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<string>("Lname")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("ModifyDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("Position")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Tel")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("TitleId")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GarageId");

                    b.HasIndex("TitleId");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("my_cars.Data.Models.Garage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("District")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FlagActive")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Mail")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("ModifyDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PackageCode")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PostCode")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Province")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Subdistrict")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Tel")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TimeAvaliable")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("garages");
                });

            modelBuilder.Entity("my_cars.Data.Models.Reason", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("FlagActive")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime?>("ModifyDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("ReasonDesc")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("reasons");
                });

            modelBuilder.Entity("my_cars.Data.Models.Title", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("FlagActive")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime?>("ModifyDate")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("TitleName")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("titles");
                });
#pragma warning restore 612, 618
        }
    }
}