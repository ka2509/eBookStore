﻿// <auto-generated />
using System;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240617062427_Modify")]
    partial class Modify
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Assignment.Models.Author", b =>
                {
                    b.Property<int>("Author_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Author_id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Author_id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Assignment.Models.Book", b =>
                {
                    b.Property<int>("Book_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Book_id"), 1L, 1);

                    b.Property<decimal>("Advanced")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Pub_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Published_date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Royalty")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<long>("Ytd_sales")
                        .HasColumnType("bigint");

                    b.HasKey("Book_id");

                    b.HasIndex("Pub_id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Assignment.Models.BookAuthor", b =>
                {
                    b.Property<int?>("Book_id")
                        .HasColumnType("int");

                    b.Property<int?>("Author_id")
                        .HasColumnType("int");

                    b.Property<string>("Author_order")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Royality_percentage")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Book_id", "Author_id");

                    b.HasIndex("Author_id");

                    b.ToTable("BookAuthors");
                });

            modelBuilder.Entity("Assignment.Models.Publisher", b =>
                {
                    b.Property<int>("Pub_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Pub_id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Pub_id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("Assignment.Models.Book", b =>
                {
                    b.HasOne("Assignment.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("Pub_id");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("Assignment.Models.BookAuthor", b =>
                {
                    b.HasOne("Assignment.Models.Author", "Author")
                        .WithMany("BookAuthors")
                        .HasForeignKey("Author_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment.Models.Book", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("Book_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Assignment.Models.Author", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("Assignment.Models.Book", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("Assignment.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
