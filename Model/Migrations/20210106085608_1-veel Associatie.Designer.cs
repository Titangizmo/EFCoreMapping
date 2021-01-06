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
    [Migration("20210106085608_1-veel Associatie")]
    partial class _1veelAssociatie
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

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

            modelBuilder.Entity("Model.Entities.ASSCampus", b =>
                {
                    b.Navigation("ASSDocenten");
                });

            modelBuilder.Entity("Model.Entities.Campus", b =>
                {
                    b.Navigation("Docenten");
                });
#pragma warning restore 612, 618
        }
    }
}
