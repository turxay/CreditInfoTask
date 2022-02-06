﻿// <auto-generated />
using System;
using CreditInfoTask.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CreditInfoTask.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220206103835_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CreditInfoTask.Domain.Entities.Contract", b =>
                {
                    b.Property<int>("ContractId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContractCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContractId");

                    b.ToTable("Contract", "dbo");
                });

            modelBuilder.Entity("CreditInfoTask.Domain.Entities.ContractData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ConractId")
                        .HasColumnType("int")
                        .HasColumnName("ContractId");

                    b.Property<DateTime?>("DateAccountOpened")
                        .HasColumnType("datetime2")
                        .HasColumnName("DateAccountOpened");

                    b.Property<DateTime?>("DateOfLastPayment")
                        .HasColumnType("datetime2")
                        .HasColumnName("DateOfLastPayment");

                    b.Property<DateTime?>("NextPaymentDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("NextPaymentDate");

                    b.Property<DateTime?>("RealEndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("RealEndDate");

                    b.HasKey("Id");

                    b.ToTable("ContractData", "dbo");
                });

            modelBuilder.Entity("CreditInfoTask.Domain.Entities.CurrentBalance", b =>
                {
                    b.Property<int>("ContractDataId")
                        .HasColumnType("int");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("CurrentBalances");
                });

            modelBuilder.Entity("CreditInfoTask.Domain.Entities.GuaranteeAmount", b =>
                {
                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectRoleId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("GuaranteeAmounts");
                });

            modelBuilder.Entity("CreditInfoTask.Domain.Entities.IdentificationNumbers", b =>
                {
                    b.Property<string>("NationalID")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("IdentificationNumbers");
                });

            modelBuilder.Entity("CreditInfoTask.Domain.Entities.Individual", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Individual");
                });

            modelBuilder.Entity("CreditInfoTask.Domain.Entities.InstallmentAmount", b =>
                {
                    b.Property<int>("ContractDataId")
                        .HasColumnType("int");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("InstallmentAmounts");
                });

            modelBuilder.Entity("CreditInfoTask.Domain.Entities.OriginalAmount", b =>
                {
                    b.Property<int>("ContractDataId")
                        .HasColumnType("int");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("OriginalAmount");
                });

            modelBuilder.Entity("CreditInfoTask.Domain.Entities.OverdueBalance", b =>
                {
                    b.Property<int>("ContractDataId")
                        .HasColumnType("int");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("OverdueBalances");
                });

            modelBuilder.Entity("CreditInfoTask.Domain.Entities.SubjectRole", b =>
                {
                    b.Property<int>("ContractId")
                        .HasColumnType("int")
                        .HasColumnName("ContractId");

                    b.Property<string>("CustomerCode")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CustomerCode");

                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<string>("RoleOfCustomer")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("RoleOfCustomer");

                    b.ToTable("SubjectRole", "dbo");
                });
#pragma warning restore 612, 618
        }
    }
}