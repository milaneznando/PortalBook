﻿// <auto-generated />
using System;
using Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infra.Migrations
{
    [DbContext(typeof(BookContext))]
    [Migration("20240619173359_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.BookEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("ID_BOOK");

                    b.Property<string>("BookAuthor")
                        .HasColumnType("longtext")
                        .HasColumnName("BOOK_AUTHOR");

                    b.Property<string>("BookName")
                        .HasColumnType("longtext")
                        .HasColumnName("BOOK_NAME");

                    b.Property<string>("BookResume")
                        .HasColumnType("longtext")
                        .HasColumnName("BOOK_RESUME");

                    b.Property<DateTime?>("PublicationDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("PUBLICATION_DATE");

                    b.HasKey("Id");

                    b.ToTable("Book", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
