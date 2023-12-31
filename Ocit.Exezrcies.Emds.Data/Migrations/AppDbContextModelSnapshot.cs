﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Ocit.Exezrcies.Emds.Data;

#nullable disable

namespace Ocit.Exezrcies.Emds.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Ocit.Exercies.Emds.Domain.Addresse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("IncomingDocumentId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IncomingDocumentId");

                    b.ToTable("Addresses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "FIO"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "FIO2"
                        });
                });

            modelBuilder.Entity("Ocit.Exercies.Emds.Domain.BasicDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("Discriminator")
                        .HasColumnType("uuid");

                    b.Property<int[]>("DocumentKind")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Subject")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("BasicDocuments", (string)null);

                    b.UseTptMappingStrategy();

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 8, 17, 12, 40, 22, 559, DateTimeKind.Utc).AddTicks(5420),
                            Discriminator = new Guid("d27975a9-4b07-4883-b236-f4361245975b"),
                            DocumentKind = new[] { 0 },
                            DocumentNumber = "Number1",
                            Name = "Name",
                            Subject = "subject"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 8, 17, 12, 40, 22, 559, DateTimeKind.Utc).AddTicks(5438),
                            Discriminator = new Guid("e4321c60-166c-4479-9eb7-b71768832fb3"),
                            DocumentKind = new[] { 0 },
                            DocumentNumber = "Number2",
                            Name = "Name2",
                            Subject = "subject2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 8, 17, 12, 40, 22, 559, DateTimeKind.Utc).AddTicks(5443),
                            Discriminator = new Guid("d27975a9-4b07-4883-b236-f4361245975b"),
                            DocumentKind = new[] { 0 },
                            DocumentNumber = "Number3",
                            Name = "Name3",
                            Subject = "subject3"
                        });
                });

            modelBuilder.Entity("Ocit.Exercies.Emds.Domain.CameFrom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("IncomingDocumentId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IncomingDocumentId");

                    b.ToTable("CameFroms", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "cameFrom1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "cameFrom2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "cameFrom3"
                        });
                });

            modelBuilder.Entity("Ocit.Exercies.Emds.Domain.CounterParty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("IncomingDocumentId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IncomingDocumentId");

                    b.ToTable("CounterParties", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "party1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "party2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "party3"
                        });
                });

            modelBuilder.Entity("Ocit.Exercies.Emds.Domain.DeliveryMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("IncomingDocumentId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IncomingDocumentId");

                    b.ToTable("DeliveryMethods", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "EMAIL"
                        },
                        new
                        {
                            Id = 2,
                            Name = "EDMS"
                        },
                        new
                        {
                            Id = 3,
                            Name = "MAIL"
                        });
                });

            modelBuilder.Entity("Ocit.Exercies.Emds.Domain.IncomingDocument", b =>
                {
                    b.HasBaseType("Ocit.Exercies.Emds.Domain.BasicDocument");

                    b.Property<List<int>>("AddresseIds")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<List<int>>("CameFromIds")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<List<int>>("CounterPartyIds")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<List<int>>("DeliveryMethodIds")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.ToTable("IncomingDocuments", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 8, 17, 12, 40, 22, 559, DateTimeKind.Utc).AddTicks(5493),
                            Discriminator = new Guid("d27975a9-4b07-4883-b236-f4361245975b"),
                            DocumentKind = new[] { 1 },
                            DocumentNumber = "docNumber1",
                            Name = "incomingName1",
                            Subject = "incomingSubject1",
                            AddresseIds = new List<int> { 1 },
                            CameFromIds = new List<int> { 1 },
                            CounterPartyIds = new List<int> { 1 },
                            DeliveryMethodIds = new List<int> { 1 }
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 8, 17, 12, 40, 22, 559, DateTimeKind.Utc).AddTicks(5505),
                            Discriminator = new Guid("e4321c60-166c-4479-9eb7-b71768832fb3"),
                            DocumentKind = new[] { 1 },
                            DocumentNumber = "docNumber2",
                            Name = "incomingName2",
                            Subject = "incomingSubject2",
                            AddresseIds = new List<int> { 2 },
                            CameFromIds = new List<int> { 2, 1 },
                            CounterPartyIds = new List<int> { 1, 1 },
                            DeliveryMethodIds = new List<int> { 1, 2 }
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2023, 8, 17, 12, 40, 22, 559, DateTimeKind.Utc).AddTicks(5516),
                            Discriminator = new Guid("d27975a9-4b07-4883-b236-f4361245975b"),
                            DocumentKind = new[] { 1 },
                            DocumentNumber = "docNumber3",
                            Name = "incomingName3",
                            Subject = "incomingSubject3",
                            AddresseIds = new List<int> { 2 },
                            CameFromIds = new List<int> { 3, 2 },
                            CounterPartyIds = new List<int> { 1, 3 },
                            DeliveryMethodIds = new List<int> { 3 }
                        });
                });

            modelBuilder.Entity("Ocit.Exercies.Emds.Domain.Addresse", b =>
                {
                    b.HasOne("Ocit.Exercies.Emds.Domain.IncomingDocument", null)
                        .WithMany("Addresse")
                        .HasForeignKey("IncomingDocumentId");
                });

            modelBuilder.Entity("Ocit.Exercies.Emds.Domain.CameFrom", b =>
                {
                    b.HasOne("Ocit.Exercies.Emds.Domain.IncomingDocument", null)
                        .WithMany("CameFrom")
                        .HasForeignKey("IncomingDocumentId");
                });

            modelBuilder.Entity("Ocit.Exercies.Emds.Domain.CounterParty", b =>
                {
                    b.HasOne("Ocit.Exercies.Emds.Domain.IncomingDocument", null)
                        .WithMany("CounterParty")
                        .HasForeignKey("IncomingDocumentId");
                });

            modelBuilder.Entity("Ocit.Exercies.Emds.Domain.DeliveryMethod", b =>
                {
                    b.HasOne("Ocit.Exercies.Emds.Domain.IncomingDocument", null)
                        .WithMany("DeliveryMethod")
                        .HasForeignKey("IncomingDocumentId");
                });

            modelBuilder.Entity("Ocit.Exercies.Emds.Domain.IncomingDocument", b =>
                {
                    b.HasOne("Ocit.Exercies.Emds.Domain.BasicDocument", null)
                        .WithOne()
                        .HasForeignKey("Ocit.Exercies.Emds.Domain.IncomingDocument", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ocit.Exercies.Emds.Domain.IncomingDocument", b =>
                {
                    b.Navigation("Addresse");

                    b.Navigation("CameFrom");

                    b.Navigation("CounterParty");

                    b.Navigation("DeliveryMethod");
                });
#pragma warning restore 612, 618
        }
    }
}
