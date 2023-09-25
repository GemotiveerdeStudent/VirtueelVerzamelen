﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VirtueelVerzamelen.Data;

#nullable disable

namespace VirtueelVerzamelen.Migrations
{
    [DbContext(typeof(VirtueelVerzamelenDb))]
    [Migration("20230921232245_AddVirtueelVerzamelenToDatabase")]
    partial class AddVirtueelVerzamelenToDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VirtueelVerzamelen.Models.ClassModels.Collection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("UserUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserUserId");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("VirtueelVerzamelen.Models.ClassModels.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CollectionId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("CollectionId");

                    b.HasIndex("UserId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("VirtueelVerzamelen.Models.ClassModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("VirtueelVerzamelen.Models.ClassModels.Collection", b =>
                {
                    b.HasOne("VirtueelVerzamelen.Models.ClassModels.User", "UserUser")
                        .WithMany("Collections")
                        .HasForeignKey("UserUserId");

                    b.Navigation("UserUser");
                });

            modelBuilder.Entity("VirtueelVerzamelen.Models.ClassModels.Item", b =>
                {
                    b.HasOne("VirtueelVerzamelen.Models.ClassModels.Collection", "Collection")
                        .WithMany("Items")
                        .HasForeignKey("CollectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VirtueelVerzamelen.Models.ClassModels.User", "User")
                        .WithMany("Items")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collection");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VirtueelVerzamelen.Models.ClassModels.Collection", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("VirtueelVerzamelen.Models.ClassModels.User", b =>
                {
                    b.Navigation("Collections");

                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
