﻿// <auto-generated />
using System;
using HA.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HA.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("HA.Domain.Enitites.PriceMultiplier", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Multiplier")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ThresholdFirstId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ThresholdSecondId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("PriceMultipliers");
                });

            modelBuilder.Entity("HA.Domain.Enitites.SurveyFirst", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Survey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SurveyFirst");

                    b.HasData(
                        new
                        {
                            Id = new Guid("094234be-b6c7-438a-ae17-5fa53324f5bb"),
                            Survey = "21"
                        },
                        new
                        {
                            Id = new Guid("80d8e42e-dd52-463e-823d-b9a0b887530b"),
                            Survey = "180"
                        },
                        new
                        {
                            Id = new Guid("cf680241-854c-48f2-925c-d15c49ed1af1"),
                            Survey = "87"
                        },
                        new
                        {
                            Id = new Guid("990b0236-b377-41f3-bb06-bdaec289be2d"),
                            Survey = "137"
                        },
                        new
                        {
                            Id = new Guid("b4682943-ded9-435b-a689-45d5103b6f33"),
                            Survey = "45"
                        },
                        new
                        {
                            Id = new Guid("79bfc186-7775-4c4f-83e1-6b5416d59a50"),
                            Survey = "56"
                        },
                        new
                        {
                            Id = new Guid("240d13e3-719a-487f-bb69-d807498c0302"),
                            Survey = "49"
                        },
                        new
                        {
                            Id = new Guid("2b2b48d9-ee31-48f4-a495-65af6c8f8859"),
                            Survey = "125"
                        });
                });

            modelBuilder.Entity("HA.Domain.Enitites.SurveySecond", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Survey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SurveySecond");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2b9b964f-85ef-4e24-8bd3-39cd8198aaf8"),
                            Survey = "62"
                        },
                        new
                        {
                            Id = new Guid("010067d6-43b2-4f19-ba0f-40a175bd8185"),
                            Survey = "250"
                        },
                        new
                        {
                            Id = new Guid("deddf733-ab67-4737-a7b6-ec17a6e4b3ad"),
                            Survey = "19"
                        },
                        new
                        {
                            Id = new Guid("cbe23efd-4dbb-4cd4-b83a-ae353db0d954"),
                            Survey = "300"
                        },
                        new
                        {
                            Id = new Guid("b2af4bb0-708e-4b90-8a90-e1c25a28e9fa"),
                            Survey = "1"
                        },
                        new
                        {
                            Id = new Guid("ed26e72b-1c72-48be-aea7-898c49b5952d"),
                            Survey = "26"
                        },
                        new
                        {
                            Id = new Guid("fd931c8b-df99-431e-9267-25f0ff4e37e4"),
                            Survey = "68"
                        },
                        new
                        {
                            Id = new Guid("65e416bf-15d7-44b2-9d00-7832b177496b"),
                            Survey = "15"
                        },
                        new
                        {
                            Id = new Guid("3ba78a8f-fe79-4ad9-b414-545ed0f51cbb"),
                            Survey = "157"
                        },
                        new
                        {
                            Id = new Guid("4f971182-3a72-4e28-8be2-118555b01606"),
                            Survey = "0"
                        });
                });

            modelBuilder.Entity("HA.Domain.Enitites.ThresholdFirst", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FirstThresholds");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5427565f-60be-4644-a617-590de1355544"),
                            Level = 60
                        },
                        new
                        {
                            Id = new Guid("792aaeda-61a5-44ea-b357-718b9da5ca10"),
                            Level = 100
                        },
                        new
                        {
                            Id = new Guid("d3346656-a7b2-43a9-a23e-6ac4e5bff879"),
                            Level = 140
                        },
                        new
                        {
                            Id = new Guid("2f04ee11-48ae-45e5-afcc-f32babeebe38"),
                            Level = 200
                        });
                });

            modelBuilder.Entity("HA.Domain.Enitites.ThresholdSecond", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SecondThresholds");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ada39846-4e68-4a4f-a219-ca6bcefda46c"),
                            Level = 36
                        },
                        new
                        {
                            Id = new Guid("45eb5a2c-f47a-47d7-8bbf-881ac5b58909"),
                            Level = 60
                        },
                        new
                        {
                            Id = new Guid("8b778ce7-9cda-4c45-b8d7-23c02ae6a4af"),
                            Level = 84
                        },
                        new
                        {
                            Id = new Guid("db814f80-0154-4e71-a787-625487ea2bbc"),
                            Level = 120
                        });
                });

            modelBuilder.Entity("HA.Domain.Enitites.Zone", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DefaultPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("SurveyFirstId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SurveySecondId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ZoneName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Zones");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f610e3de-a686-4987-8bcf-457c009fd47f"),
                            DefaultPrice = 3.50m,
                            SurveyFirstId = new Guid("094234be-b6c7-438a-ae17-5fa53324f5bb"),
                            SurveySecondId = new Guid("b4682943-ded9-435b-a689-45d5103b6f33"),
                            ZoneName = "S1"
                        },
                        new
                        {
                            Id = new Guid("19752857-ea39-4229-90f8-a14f0695b042"),
                            DefaultPrice = 3.50m,
                            SurveyFirstId = new Guid("2b9b964f-85ef-4e24-8bd3-39cd8198aaf8"),
                            SurveySecondId = new Guid("ed26e72b-1c72-48be-aea7-898c49b5952d"),
                            ZoneName = "S2"
                        },
                        new
                        {
                            Id = new Guid("0363c650-fc4f-4df4-b0a4-912dc7ca3151"),
                            DefaultPrice = 3.50m,
                            SurveyFirstId = new Guid("80d8e42e-dd52-463e-823d-b9a0b887530b"),
                            SurveySecondId = new Guid("79bfc186-7775-4c4f-83e1-6b5416d59a50"),
                            ZoneName = "S3"
                        },
                        new
                        {
                            Id = new Guid("043ce184-4089-4614-bac8-a1bd300c8a7c"),
                            DefaultPrice = 4.50m,
                            SurveyFirstId = new Guid("010067d6-43b2-4f19-ba0f-40a175bd8185"),
                            SurveySecondId = new Guid("fd931c8b-df99-431e-9267-25f0ff4e37e4"),
                            ZoneName = "S4"
                        },
                        new
                        {
                            Id = new Guid("68ef9410-3a7c-443d-ab0c-1e2b15939415"),
                            DefaultPrice = 4.50m,
                            SurveyFirstId = new Guid("cf680241-854c-48f2-925c-d15c49ed1af1"),
                            SurveySecondId = new Guid("240d13e3-719a-487f-bb69-d807498c0302"),
                            ZoneName = "S5"
                        },
                        new
                        {
                            Id = new Guid("7ee11209-89fc-4361-9d64-7941a21baa23"),
                            DefaultPrice = 4.50m,
                            SurveyFirstId = new Guid("deddf733-ab67-4737-a7b6-ec17a6e4b3ad"),
                            SurveySecondId = new Guid("65e416bf-15d7-44b2-9d00-7832b177496b"),
                            ZoneName = "S6"
                        },
                        new
                        {
                            Id = new Guid("8fd9ec8f-2bc3-4f36-9d70-0e6ad5b10b14"),
                            DefaultPrice = 6.00m,
                            SurveyFirstId = new Guid("990b0236-b377-41f3-bb06-bdaec289be2d"),
                            SurveySecondId = new Guid("2b2b48d9-ee31-48f4-a495-65af6c8f8859"),
                            ZoneName = "S7"
                        },
                        new
                        {
                            Id = new Guid("3529a503-c48f-47ad-ad43-9fdcb8744d89"),
                            DefaultPrice = 6.00m,
                            SurveyFirstId = new Guid("cbe23efd-4dbb-4cd4-b83a-ae353db0d954"),
                            SurveySecondId = new Guid("3ba78a8f-fe79-4ad9-b414-545ed0f51cbb"),
                            ZoneName = "S8"
                        },
                        new
                        {
                            Id = new Guid("cf169adb-cdcd-4f2e-9635-34b48235fba5"),
                            DefaultPrice = 6.00m,
                            SurveyFirstId = new Guid("b2af4bb0-708e-4b90-8a90-e1c25a28e9fa"),
                            SurveySecondId = new Guid("4f971182-3a72-4e28-8be2-118555b01606"),
                            ZoneName = "S9"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
