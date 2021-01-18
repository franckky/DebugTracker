﻿// <auto-generated />
using System;
using Icta.RequestTracker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DebugTracker.Data.Migrations
{
    [DbContext(typeof(DebugTrackerDbContext))]
    [Migration("20210118221431_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("DebugTracker.Data.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Label = "- Undefined -",
                            OrderBy = 0
                        },
                        new
                        {
                            Id = 2,
                            Label = "Global",
                            OrderBy = 1
                        });
                });

            modelBuilder.Entity("DebugTracker.Data.Entities.MacroSystem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FullLabel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MacroSytems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullLabel = "- Undefined -",
                            Label = "- Undefined -",
                            OrderBy = 0
                        },
                        new
                        {
                            Id = 2,
                            FullLabel = "Systems and Networks(SR)",
                            Label = "SR",
                            OrderBy = 1
                        },
                        new
                        {
                            Id = 3,
                            FullLabel = "Computerized developments (DI)",
                            Label = "DI",
                            OrderBy = 2
                        },
                        new
                        {
                            Id = 4,
                            FullLabel = "Biometrics (BI)",
                            Label = "BI",
                            OrderBy = 3
                        });
                });

            modelBuilder.Entity("DebugTracker.Data.Entities.MacroSystem_System", b =>
                {
                    b.Property<int>("MacroSystemId")
                        .HasColumnType("int");

                    b.Property<int>("SystemId")
                        .HasColumnType("int");

                    b.HasKey("MacroSystemId", "SystemId");

                    b.HasIndex("SystemId");

                    b.ToTable("MacroSystem_Systems");

                    b.HasData(
                        new
                        {
                            MacroSystemId = 1,
                            SystemId = 1
                        },
                        new
                        {
                            MacroSystemId = 2,
                            SystemId = 1
                        });
                });

            modelBuilder.Entity("DebugTracker.Data.Entities.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ActionComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ActionResponsibleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Impact")
                        .HasColumnType("int");

                    b.Property<string>("ImpactComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Issuer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("MacroSystemId")
                        .HasColumnType("int");

                    b.Property<int>("Nature")
                        .HasColumnType("int");

                    b.Property<string>("Reference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Release")
                        .HasColumnType("int");

                    b.Property<int>("Seriousness")
                        .HasColumnType("int");

                    b.Property<int>("Source")
                        .HasColumnType("int");

                    b.Property<int>("StudyId")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SystemId")
                        .HasColumnType("int");

                    b.Property<int>("ValidationResponsibleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("MacroSystemId");

                    b.HasIndex("SystemId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("DebugTracker.Data.Entities.RequestStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ActionResponsibleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RequestId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("ValidationResponsibleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RequestId");

                    b.ToTable("RequestStatus");
                });

            modelBuilder.Entity("DebugTracker.Data.Entities.SystemEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Systems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Label = "- Undefined -",
                            OrderBy = 0
                        },
                        new
                        {
                            Id = 2,
                            Label = "i-Cloud",
                            OrderBy = 1
                        });
                });

            modelBuilder.Entity("DebugTracker.Data.Entities.System_Location", b =>
                {
                    b.Property<int>("SystemId")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.HasKey("SystemId", "LocationId");

                    b.HasIndex("LocationId");

                    b.ToTable("System_Locations");

                    b.HasData(
                        new
                        {
                            SystemId = 1,
                            LocationId = 1
                        },
                        new
                        {
                            SystemId = 2,
                            LocationId = 1
                        });
                });

            modelBuilder.Entity("DebugTracker.Data.ViewsDb.VGlobalPersonnel", b =>
                {
                    b.Property<string>("Ensemble_lib")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PERSO_Responsable_Services")
                        .HasColumnType("int");

                    b.Property<string>("PERSO_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PERSO_ensemble")
                        .HasColumnType("int");

                    b.Property<string>("PERSO_fullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PERSO_loginNT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PERSO_num")
                        .HasColumnType("int");

                    b.Property<string>("PERSO_patronyme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PERSO_prenom")
                        .HasColumnType("nvarchar(max)");

                    b.ToView("vw_GLOBAL_PERSONNEL");
                });

            modelBuilder.Entity("DebugTracker.Data.ViewsDb.VStudy", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("ShortTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sponsor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusLabel")
                        .HasColumnType("nvarchar(max)");

                    b.ToView("vw_GLOBAL_Study");
                });

            modelBuilder.Entity("DebugTracker.Data.Entities.MacroSystem_System", b =>
                {
                    b.HasOne("DebugTracker.Data.Entities.MacroSystem", "MacroSystem")
                        .WithMany("MacroSystem_Systems")
                        .HasForeignKey("MacroSystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DebugTracker.Data.Entities.SystemEntity", "System")
                        .WithMany("MacroSystem_Systems")
                        .HasForeignKey("SystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MacroSystem");

                    b.Navigation("System");
                });

            modelBuilder.Entity("DebugTracker.Data.Entities.Request", b =>
                {
                    b.HasOne("DebugTracker.Data.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DebugTracker.Data.Entities.MacroSystem", "MacroSystem")
                        .WithMany()
                        .HasForeignKey("MacroSystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DebugTracker.Data.Entities.SystemEntity", "System")
                        .WithMany()
                        .HasForeignKey("SystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("MacroSystem");

                    b.Navigation("System");
                });

            modelBuilder.Entity("DebugTracker.Data.Entities.RequestStatus", b =>
                {
                    b.HasOne("DebugTracker.Data.Entities.Request", null)
                        .WithMany("RequestStatus")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DebugTracker.Data.Entities.System_Location", b =>
                {
                    b.HasOne("DebugTracker.Data.Entities.Location", "Location")
                        .WithMany("System_Locations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DebugTracker.Data.Entities.SystemEntity", "System")
                        .WithMany("System_Locations")
                        .HasForeignKey("SystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("System");
                });

            modelBuilder.Entity("DebugTracker.Data.Entities.Location", b =>
                {
                    b.Navigation("System_Locations");
                });

            modelBuilder.Entity("DebugTracker.Data.Entities.MacroSystem", b =>
                {
                    b.Navigation("MacroSystem_Systems");
                });

            modelBuilder.Entity("DebugTracker.Data.Entities.Request", b =>
                {
                    b.Navigation("RequestStatus");
                });

            modelBuilder.Entity("DebugTracker.Data.Entities.SystemEntity", b =>
                {
                    b.Navigation("MacroSystem_Systems");

                    b.Navigation("System_Locations");
                });
#pragma warning restore 612, 618
        }
    }
}