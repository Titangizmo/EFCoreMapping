﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model.Repositories;

namespace Model.Migrations
{
    [DbContext(typeof(EFCoreMappingContext))]
    [Migration("20210107124327_Toevoegen AssWerknemer")]
    partial class ToevoegenAssWerknemer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Model.Entities.ASSActiviteit", b =>
                {
                    b.Property<int>("ActiviteitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ActiviteitId");

                    b.ToTable("ASSActiviteiten");
                });

            modelBuilder.Entity("Model.Entities.ASSBoek", b =>
                {
                    b.Property<int>("BoekId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("IsbnNr")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Titel")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("BoekId");

                    b.HasIndex("IsbnNr")
                        .IsUnique();

                    b.ToTable("ASSBoeken");

                    b.HasData(
                        new
                        {
                            BoekId = 1,
                            IsbnNr = "0-0705918-0-6",
                            Titel = "C++ : For Scientists and Engineers"
                        },
                        new
                        {
                            BoekId = 2,
                            IsbnNr = "0-0788212-3-1",
                            Titel = "C++ : The Complete Reference"
                        },
                        new
                        {
                            BoekId = 3,
                            IsbnNr = "1-5659211-6-X",
                            Titel = "C++ : The Core Language"
                        },
                        new
                        {
                            BoekId = 4,
                            IsbnNr = "0-4448771-8-5",
                            Titel = "Relational Database Systems"
                        },
                        new
                        {
                            BoekId = 5,
                            IsbnNr = "1-5595851-1-0",
                            Titel = "Access from the Ground Up"
                        },
                        new
                        {
                            BoekId = 6,
                            IsbnNr = "0-0788212-2-3",
                            Titel = "Oracle : A Beginner''s Guide"
                        },
                        new
                        {
                            BoekId = 7,
                            IsbnNr = "0-0788209-7-9",
                            Titel = "Oracle : The Complete Reference"
                        });
                });

            modelBuilder.Entity("Model.Entities.ASSBoekCursus", b =>
                {
                    b.Property<int>("BoekId")
                        .HasColumnType("int");

                    b.Property<int>("CursusId")
                        .HasColumnType("int");

                    b.Property<int>("VolgNr")
                        .HasColumnType("int");

                    b.HasKey("BoekId", "CursusId");

                    b.HasIndex("CursusId");

                    b.ToTable("ASSBoekenCursussen");
                });

            modelBuilder.Entity("Model.Entities.ASSCampus", b =>
                {
                    b.Property<int>("CampusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CampusId");

                    b.ToTable("ASSCampussen");
                });

            modelBuilder.Entity("Model.Entities.ASSCursus", b =>
                {
                    b.Property<int>("CursusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CursusId");

                    b.ToTable("ASSCursussen");

                    b.HasData(
                        new
                        {
                            CursusId = 1,
                            Naam = "C++"
                        },
                        new
                        {
                            CursusId = 2,
                            Naam = "Access"
                        },
                        new
                        {
                            CursusId = 3,
                            Naam = "Oracle"
                        });
                });

            modelBuilder.Entity("Model.Entities.ASSDocent", b =>
                {
                    b.Property<int>("DocentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CampusId")
                        .HasColumnType("int");

                    b.Property<string>("Familienaam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("HeeftRijbewijs")
                        .HasColumnType("bit");

                    b.Property<DateTime>("InDienst")
                        .HasColumnType("date");

                    b.Property<string>("Voornaam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Wedde")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Maandwedde");

                    b.HasKey("DocentId");

                    b.HasIndex("CampusId");

                    b.ToTable("ASSDocenten");
                });

            modelBuilder.Entity("Model.Entities.ASSDocentActiviteit", b =>
                {
                    b.Property<int>("DocentId")
                        .HasColumnType("int");

                    b.Property<int>("ActiviteitId")
                        .HasColumnType("int");

                    b.Property<int>("AantalUren")
                        .HasColumnType("int");

                    b.HasKey("DocentId", "ActiviteitId");

                    b.HasIndex("ActiviteitId");

                    b.ToTable("ASSDocentenActiviteiten");
                });

            modelBuilder.Entity("Model.Entities.ASSWerknemer", b =>
                {
                    b.Property<int>("WerknemerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Familienaam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OversteWerknemerId")
                        .HasColumnType("int");

                    b.Property<string>("Voornaam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WerknemerId");

                    b.HasIndex("OversteWerknemerId");

                    b.ToTable("AssWerknemers");
                });

            modelBuilder.Entity("Model.Entities.Campus", b =>
                {
                    b.Property<int>("CampusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CampusNaam");

                    b.HasKey("CampusId");

                    b.ToTable("Campussen");
                });

            modelBuilder.Entity("Model.Entities.Docent", b =>
                {
                    b.Property<int>("DocentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CampusId")
                        .HasColumnType("int");

                    b.Property<string>("Familienaam")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool?>("HeeftRijbewijs")
                        .HasColumnType("bit");

                    b.Property<DateTime>("InDienst")
                        .HasColumnType("date");

                    b.Property<string>("LandCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("Wedde")
                        .HasColumnType("decimal(18,4)")
                        .HasColumnName("Maandwedde");

                    b.HasKey("DocentId");

                    b.HasIndex("CampusId");

                    b.ToTable("Docenten");
                });

            modelBuilder.Entity("Model.Entities.TPHCursus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CursusType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TPHCursussen");

                    b.HasDiscriminator<string>("CursusType").HasValue("TPHCursus");
                });

            modelBuilder.Entity("Model.Entities.TPHKlassikaleCursus", b =>
                {
                    b.HasBaseType("Model.Entities.TPHCursus");

                    b.Property<DateTime>("Tot")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Van")
                        .HasColumnType("datetime2");

                    b.ToTable("TPHCursussen");

                    b.HasDiscriminator().HasValue("K");
                });

            modelBuilder.Entity("Model.Entities.TPHZelfstudieCursus", b =>
                {
                    b.HasBaseType("Model.Entities.TPHCursus");

                    b.Property<int>("AantalDagen")
                        .HasColumnType("int");

                    b.ToTable("TPHCursussen");

                    b.HasDiscriminator().HasValue("Z");
                });

            modelBuilder.Entity("Model.Entities.ASSBoekCursus", b =>
                {
                    b.HasOne("Model.Entities.ASSBoek", "Boek")
                        .WithMany("BoekenCursussen")
                        .HasForeignKey("BoekId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.ASSCursus", "Cursus")
                        .WithMany("BoekenCursussen")
                        .HasForeignKey("CursusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Boek");

                    b.Navigation("Cursus");
                });

            modelBuilder.Entity("Model.Entities.ASSCampus", b =>
                {
                    b.OwnsOne("Model.Entities.Adres", "Adres", b1 =>
                        {
                            b1.Property<int>("ASSCampusCampusId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.Property<string>("Gemeente")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Gemeente");

                            b1.Property<string>("Huisnummer")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("HuisNr");

                            b1.Property<string>("Postcode")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("PostCd");

                            b1.Property<string>("Straat")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Straat");

                            b1.HasKey("ASSCampusCampusId");

                            b1.ToTable("ASSCampussen");

                            b1.WithOwner()
                                .HasForeignKey("ASSCampusCampusId");
                        });

                    b.Navigation("Adres");
                });

            modelBuilder.Entity("Model.Entities.ASSDocent", b =>
                {
                    b.HasOne("Model.Entities.ASSCampus", "ASSCampus")
                        .WithMany("ASSDocenten")
                        .HasForeignKey("CampusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Model.Entities.Adres", "Adres", b1 =>
                        {
                            b1.Property<int>("ASSDocentDocentId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.Property<string>("Gemeente")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Gemeente");

                            b1.Property<string>("Huisnummer")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("HuisNr");

                            b1.Property<string>("Postcode")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("PostCd");

                            b1.Property<string>("Straat")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Straat");

                            b1.HasKey("ASSDocentDocentId");

                            b1.ToTable("ASSDocenten");

                            b1.WithOwner()
                                .HasForeignKey("ASSDocentDocentId");
                        });

                    b.Navigation("Adres");

                    b.Navigation("ASSCampus");
                });

            modelBuilder.Entity("Model.Entities.ASSDocentActiviteit", b =>
                {
                    b.HasOne("Model.Entities.ASSActiviteit", "Activiteit")
                        .WithMany("DocentenActiviteiten")
                        .HasForeignKey("ActiviteitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.ASSDocent", "Docent")
                        .WithMany("DocentenActiviteiten")
                        .HasForeignKey("DocentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activiteit");

                    b.Navigation("Docent");
                });

            modelBuilder.Entity("Model.Entities.ASSWerknemer", b =>
                {
                    b.HasOne("Model.Entities.ASSWerknemer", "Overste")
                        .WithMany("Werknemers")
                        .HasForeignKey("OversteWerknemerId");

                    b.Navigation("Overste");
                });

            modelBuilder.Entity("Model.Entities.Campus", b =>
                {
                    b.OwnsOne("Model.Entities.Adres", "Adres", b1 =>
                        {
                            b1.Property<int>("CampusId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.Property<string>("Gemeente")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Gemeente");

                            b1.Property<string>("Huisnummer")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("HuisNr");

                            b1.Property<string>("Postcode")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("PostCd");

                            b1.Property<string>("Straat")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Straat");

                            b1.HasKey("CampusId");

                            b1.ToTable("Campussen");

                            b1.WithOwner()
                                .HasForeignKey("CampusId");
                        });

                    b.Navigation("Adres");
                });

            modelBuilder.Entity("Model.Entities.Docent", b =>
                {
                    b.HasOne("Model.Entities.Campus", "Campus")
                        .WithMany("Docenten")
                        .HasForeignKey("CampusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Model.Entities.Adres", "AdresThuis", b1 =>
                        {
                            b1.Property<int>("DocentId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.Property<string>("Gemeente")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("GemeenteThuis");

                            b1.Property<string>("Huisnummer")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("HuisNrThuis");

                            b1.Property<string>("Postcode")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("PostCdThuis");

                            b1.Property<string>("Straat")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("StraatThuis");

                            b1.HasKey("DocentId");

                            b1.ToTable("Docenten");

                            b1.WithOwner()
                                .HasForeignKey("DocentId");
                        });

                    b.OwnsOne("Model.Entities.Adres", "AdresWerk", b1 =>
                        {
                            b1.Property<int>("DocentId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.Property<string>("Gemeente")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("GemeenteWerk");

                            b1.Property<string>("Huisnummer")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("HuisNrWerk");

                            b1.Property<string>("Postcode")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("PostCdWerk");

                            b1.Property<string>("Straat")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("StraatWerk");

                            b1.HasKey("DocentId");

                            b1.ToTable("Docenten");

                            b1.WithOwner()
                                .HasForeignKey("DocentId");
                        });

                    b.Navigation("AdresThuis");

                    b.Navigation("AdresWerk");

                    b.Navigation("Campus");
                });

            modelBuilder.Entity("Model.Entities.ASSActiviteit", b =>
                {
                    b.Navigation("DocentenActiviteiten");
                });

            modelBuilder.Entity("Model.Entities.ASSBoek", b =>
                {
                    b.Navigation("BoekenCursussen");
                });

            modelBuilder.Entity("Model.Entities.ASSCampus", b =>
                {
                    b.Navigation("ASSDocenten");
                });

            modelBuilder.Entity("Model.Entities.ASSCursus", b =>
                {
                    b.Navigation("BoekenCursussen");
                });

            modelBuilder.Entity("Model.Entities.ASSDocent", b =>
                {
                    b.Navigation("DocentenActiviteiten");
                });

            modelBuilder.Entity("Model.Entities.ASSWerknemer", b =>
                {
                    b.Navigation("Werknemers");
                });

            modelBuilder.Entity("Model.Entities.Campus", b =>
                {
                    b.Navigation("Docenten");
                });
#pragma warning restore 612, 618
        }
    }
}
