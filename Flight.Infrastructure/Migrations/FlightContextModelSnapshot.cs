﻿// <auto-generated />
using System;
using Flight.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Flight.Infrastructure.Migrations
{
    [DbContext(typeof(FlightContext))]
    partial class FlightContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Flight.Domain.Entities.Airline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DeletedFlag")
                        .HasColumnType("int")
                        .HasColumnName("flag");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("activated");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("deleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("name");

                    b.Property<int>("Statut")
                        .HasColumnType("int")
                        .HasColumnName("state");

                    b.HasKey("Id");

                    b.ToTable("Airlines");
                });

            modelBuilder.Entity("Flight.Domain.Entities.Airport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DeletedFlag")
                        .HasColumnType("int")
                        .HasColumnName("flag");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("activated");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("deleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("name");

                    b.Property<int>("Statut")
                        .HasColumnType("int")
                        .HasColumnName("state");

                    b.HasKey("Id");

                    b.ToTable("Airports");
                });

            modelBuilder.Entity("Flight.Domain.Entities.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FlightId")
                        .HasColumnType("int")
                        .HasColumnName("flight_id");

                    b.Property<int>("FlightType")
                        .HasColumnType("int")
                        .HasColumnName("flight_type");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("activated");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("deleted");

                    b.Property<int>("state")
                        .HasColumnType("int")
                        .HasColumnName("state");

                    b.HasKey("Id");

                    b.HasIndex("FlightId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Flight.Domain.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int")
                        .HasColumnName("country_id");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("activated");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("deleted");

                    b.Property<decimal>("Lat")
                        .HasColumnType("decimal(7,4)")
                        .HasColumnName("lat");

                    b.Property<decimal>("Lon")
                        .HasColumnType("decimal(7,4)")
                        .HasColumnName("lon");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Flight.Domain.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ISO2")
                        .HasColumnType("longtext")
                        .HasColumnName("iso2");

                    b.Property<string>("ISO3")
                        .HasColumnType("longtext")
                        .HasColumnName("iso3");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("activated");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("deleted");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Flight.Domain.Entities.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("BusinessClassPrice")
                        .HasColumnType("float")
                        .HasColumnName("bus_price");

                    b.Property<int>("BusinessClassSlots")
                        .HasColumnType("int")
                        .HasColumnName("bus_slot");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("code");

                    b.Property<DateTime>("Departure")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("departure");

                    b.Property<float>("EconomyPrice")
                        .HasColumnType("float")
                        .HasColumnName("eco_price");

                    b.Property<int>("EconomySlots")
                        .HasColumnType("int")
                        .HasColumnName("eco_slot");

                    b.Property<DateTime>("EstimatedArrival")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("arrival");

                    b.Property<int>("From")
                        .HasColumnType("int")
                        .HasColumnName("flight_from");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("activated");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("deleted");

                    b.Property<int>("To")
                        .HasColumnType("int")
                        .HasColumnName("flight_to");

                    b.HasKey("Id");

                    b.HasIndex("From");

                    b.HasIndex("To");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("Flight.Domain.Entities.Passenger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("address");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("contact");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("activated");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("deleted");

                    b.Property<string>("LastName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("last_name");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("middle_name");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<int>("Sex")
                        .HasColumnType("int")
                        .HasColumnName("genre");

                    b.HasKey("Id");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("Flight.Domain.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("activated");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("deleted");

                    b.Property<string>("LicensePlate")
                        .HasColumnType("longtext")
                        .HasColumnName("license");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("longtext")
                        .HasColumnName("manufacturer");

                    b.Property<string>("Model")
                        .HasColumnType("longtext")
                        .HasColumnName("model");

                    b.Property<float>("Tariff")
                        .HasColumnType("float")
                        .HasColumnName("tariff");

                    b.Property<short>("Year")
                        .HasColumnType("smallint")
                        .HasColumnName("year");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Flight.Domain.Entities.Booking", b =>
                {
                    b.HasOne("Flight.Domain.Entities.Flight", "Plane")
                        .WithMany("Bookings")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plane");
                });

            modelBuilder.Entity("Flight.Domain.Entities.City", b =>
                {
                    b.HasOne("Flight.Domain.Entities.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Flight.Domain.Entities.Flight", b =>
                {
                    b.HasOne("Flight.Domain.Entities.Airport", "DepartureAirport")
                        .WithMany()
                        .HasForeignKey("From")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Flight.Domain.Entities.Airport", "DestinationAirport")
                        .WithMany()
                        .HasForeignKey("To")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DepartureAirport");

                    b.Navigation("DestinationAirport");
                });

            modelBuilder.Entity("Flight.Domain.Entities.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("Flight.Domain.Entities.Flight", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
