﻿// <auto-generated />
using System;
using KolokwiumPoprawa.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KolokwiumPoprawa.Migrations
{
    [DbContext(typeof(FireFightersDbContext))]
    [Migration("20200704184019_AddedModels")]
    partial class AddedModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KolokwiumPoprawa.Models.Action", b =>
                {
                    b.Property<int>("IdAction")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("EndTime");

                    b.Property<bool>("NeedSpecialEquipment");

                    b.Property<DateTime>("StartTime");

                    b.HasKey("IdAction");

                    b.ToTable("Action");
                });

            modelBuilder.Entity("KolokwiumPoprawa.Models.FireFighter", b =>
                {
                    b.Property<int>("IdFireFighter")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("IdFireFighter")
                        .HasName("FireFighter_pk");

                    b.ToTable("FireFighter");
                });

            modelBuilder.Entity("KolokwiumPoprawa.Models.FireFighter_Action", b =>
                {
                    b.Property<int>("IdAction");

                    b.Property<int>("IdFireFighter");

                    b.HasKey("IdAction", "IdFireFighter");

                    b.HasIndex("IdFireFighter");

                    b.ToTable("FireFighter_Action");
                });

            modelBuilder.Entity("KolokwiumPoprawa.Models.FireTruck", b =>
                {
                    b.Property<int>("IdFireTruck")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OperationNumber")
                        .HasMaxLength(10);

                    b.Property<bool>("SpecialEquipment")
                        .HasColumnType("bit");

                    b.HasKey("IdFireTruck")
                        .HasName("FireTruck_pk");

                    b.ToTable("FireTruck");
                });

            modelBuilder.Entity("KolokwiumPoprawa.Models.FireTruck_Action", b =>
                {
                    b.Property<int>("IdFireTruckAction")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AssignmentDate");

                    b.Property<int>("IdAction");

                    b.Property<int>("IdFireTruck");

                    b.HasKey("IdFireTruckAction");

                    b.ToTable("FireTruck_Action");
                });

            modelBuilder.Entity("KolokwiumPoprawa.Models.FireFighter_Action", b =>
                {
                    b.HasOne("KolokwiumPoprawa.Models.Action", "IdActionNavigation")
                        .WithMany()
                        .HasForeignKey("IdAction")
                        .HasConstraintName("IdAction")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KolokwiumPoprawa.Models.FireFighter", "IdFireFighterNavigation")
                        .WithMany()
                        .HasForeignKey("IdFireFighter")
                        .HasConstraintName("IdFireFighter")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
