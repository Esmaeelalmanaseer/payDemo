﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using payDemo.Data;

namespace payDemo.Migrations
{
    [DbContext(typeof(payDataContext))]
    partial class payDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("payDemo.Models.Paydetals", b =>
                {
                    b.Property<int>("PayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("CardOwner")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ExpirPay")
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("securityCode")
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("PayId");

                    b.ToTable("paydetals");
                });
#pragma warning restore 612, 618
        }
    }
}
