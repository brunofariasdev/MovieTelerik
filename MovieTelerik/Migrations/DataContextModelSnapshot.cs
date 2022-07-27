﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieTelerik.Data;

#nullable disable

namespace MovieTelerik.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MovieTelerik.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .IsUnicode(true)
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Genres", (string)null);
                });

            modelBuilder.Entity("MovieTelerik.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .IsUnicode(true)
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME")
                        .HasColumnName("CreatedDate")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("GenreId")
                        .HasColumnType("INT")
                        .HasColumnName("GenreId");

                    b.Property<int>("MetaScore")
                        .HasColumnType("INT")
                        .HasColumnName("MetaScore");

                    b.Property<string>("Resume")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("NVARCHAR(250)")
                        .HasColumnName("Resume");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("NVARCHAR(40)")
                        .HasColumnName("Title");

                    b.Property<string>("UrlImg")
                        .IsRequired()
                        .HasMaxLength(110)
                        .HasColumnType("NVARCHAR(110)")
                        .HasColumnName("UrlImg");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Movies", (string)null);
                });

            modelBuilder.Entity("MovieTelerik.Models.Movie", b =>
                {
                    b.HasOne("MovieTelerik.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });
#pragma warning restore 612, 618
        }
    }
}
