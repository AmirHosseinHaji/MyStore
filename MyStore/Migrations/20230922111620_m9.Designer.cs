﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyStore.Data;

#nullable disable

namespace MyStore.Migrations
{
    [DbContext(typeof(MyDBShopContext))]
    [Migration("20230922111620_m9")]
    partial class m9
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyStore.Models.FactorForoosh", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Kala")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Namebuyer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("salmally")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FactorForooshes");
                });

            modelBuilder.Entity("MyStore.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("item");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 854.0m,
                            QuantityInStock = 5
                        },
                        new
                        {
                            Id = 2,
                            Price = 3302.0m,
                            QuantityInStock = 8
                        },
                        new
                        {
                            Id = 3,
                            Price = 2500m,
                            QuantityInStock = 3
                        });
                });

            modelBuilder.Entity("MyStore.Models.Kala", b =>
                {
                    b.Property<int>("KalaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KalaId"));

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameBuyer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("Typekala")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KalaId");

                    b.HasIndex("ItemId")
                        .IsUnique();

                    b.ToTable("Kala");
                });

            modelBuilder.Entity("MyStore.Models.NewKala", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int");

                    b.Property<string>("Typekala")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("UserKala");
                });

            modelBuilder.Entity("MyStore.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<bool>("IsFinally")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("MyStore.Models.OrderDetail", b =>
                {
                    b.Property<int>("DetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetailId"));

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("KalaId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("DetailId");

                    b.HasIndex("KalaId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("MyStore.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MyStore.Models.Kala", b =>
                {
                    b.HasOne("MyStore.Models.Item", "Item")
                        .WithOne("Kala")
                        .HasForeignKey("MyStore.Models.Kala", "ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("MyStore.Models.Order", b =>
                {
                    b.HasOne("MyStore.Models.User", "User")
                        .WithMany("order")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyStore.Models.OrderDetail", b =>
                {
                    b.HasOne("MyStore.Models.Kala", "kala")
                        .WithMany("orderDetail")
                        .HasForeignKey("KalaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyStore.Models.Order", "order")
                        .WithMany("orderDetail")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("kala");

                    b.Navigation("order");
                });

            modelBuilder.Entity("MyStore.Models.Item", b =>
                {
                    b.Navigation("Kala")
                        .IsRequired();
                });

            modelBuilder.Entity("MyStore.Models.Kala", b =>
                {
                    b.Navigation("orderDetail");
                });

            modelBuilder.Entity("MyStore.Models.Order", b =>
                {
                    b.Navigation("orderDetail");
                });

            modelBuilder.Entity("MyStore.Models.User", b =>
                {
                    b.Navigation("order");
                });
#pragma warning restore 612, 618
        }
    }
}
