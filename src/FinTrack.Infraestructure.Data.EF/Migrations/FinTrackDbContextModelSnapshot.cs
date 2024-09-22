﻿// <auto-generated />
using System;
using FinTrack.Infraestructure.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinTrack.Infraestructure.Data.EF.Migrations
{
    [DbContext(typeof(FinTrackDbContext))]
    partial class FinTrackDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FinTrack.Domain.Entities.FinancialGoal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("GoalAmount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("IdealMonthlySaving")
                        .HasMaxLength(999999999)
                        .HasColumnType("decimal(65,30)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid?>("TransactionsId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("TransactionsId");

                    b.ToTable("FinancialGoal");
                });

            modelBuilder.Entity("FinTrack.Domain.Entities.FinancialGoalTransations", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("TransactionType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FinancialGoalTransations");
                });

            modelBuilder.Entity("FinTrack.Domain.Entities.FinancialGoal", b =>
                {
                    b.HasOne("FinTrack.Domain.Entities.FinancialGoalTransations", "Transactions")
                        .WithMany()
                        .HasForeignKey("TransactionsId");

                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
