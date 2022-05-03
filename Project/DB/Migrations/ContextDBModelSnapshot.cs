﻿// <auto-generated />
using System;
using DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DB.Migrations
{
    [DbContext(typeof(ContextDB))]
    partial class ContextDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DB.Entities.Models.Department", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Department");
                });

            modelBuilder.Entity("DB.Entities.Models.Employee", b =>
                {
                    b.Property<int?>("Code")
                        .HasColumnType("integer");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("IdDepartment")
                        .HasColumnType("integer");

                    b.Property<int>("IdPosition")
                        .HasColumnType("integer");

                    b.Property<int>("IdPremium")
                        .HasColumnType("integer");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Salary")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Code");

                    b.HasIndex("IdDepartment");

                    b.HasIndex("IdPosition");

                    b.HasIndex("IdPremium");

                    b.HasIndex("Phone")
                        .IsUnique();

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("DB.Entities.Models.Position", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Position");
                });

            modelBuilder.Entity("DB.Entities.Models.Premium", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)");

                    b.Property<decimal>("Value")
                        .HasPrecision(3)
                        .HasColumnType("numeric(3,0)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("Value")
                        .IsUnique();

                    b.ToTable("Premium");
                });

            modelBuilder.Entity("DB.Entities.Models.Employee", b =>
                {
                    b.HasOne("DB.Entities.Models.Department", "_Department")
                        .WithMany("_Employee")
                        .HasForeignKey("IdDepartment")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DB.Entities.Models.Position", "_Position")
                        .WithMany("_Employee")
                        .HasForeignKey("IdPosition")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DB.Entities.Models.Premium", "_Premium")
                        .WithMany("_Employee")
                        .HasForeignKey("IdPremium")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("_Department");

                    b.Navigation("_Position");

                    b.Navigation("_Premium");
                });

            modelBuilder.Entity("DB.Entities.Models.Department", b =>
                {
                    b.Navigation("_Employee");
                });

            modelBuilder.Entity("DB.Entities.Models.Position", b =>
                {
                    b.Navigation("_Employee");
                });

            modelBuilder.Entity("DB.Entities.Models.Premium", b =>
                {
                    b.Navigation("_Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
