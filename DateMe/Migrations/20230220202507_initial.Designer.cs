﻿// <auto-generated />
using System;
using DateMe.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DateMe.Migrations
{
    [DbContext(typeof(BigChillinContext))]
    [Migration("20230220202507_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("DateMe.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Adventure"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Animation"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Chick-flick"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Coming-of-Age"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Documentary"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryID = 9,
                            CategoryName = "Horror"
                        },
                        new
                        {
                            CategoryID = 10,
                            CategoryName = "Noir"
                        },
                        new
                        {
                            CategoryID = 11,
                            CategoryName = "Romance"
                        },
                        new
                        {
                            CategoryID = 12,
                            CategoryName = "Sci-fi"
                        },
                        new
                        {
                            CategoryID = 13,
                            CategoryName = "Silent"
                        },
                        new
                        {
                            CategoryID = 14,
                            CategoryName = "Thriller"
                        },
                        new
                        {
                            CategoryID = 15,
                            CategoryName = "Western"
                        });
                });

            modelBuilder.Entity("DateMe.Models.MovieSubmission", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool?>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Submissions");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            CategoryID = 12,
                            Director = "Christopher Nolan",
                            Edited = false,
                            LentTo = "",
                            Notes = "Masterpiece",
                            Rating = "PG-13",
                            Title = "Interstellar",
                            Year = 2014
                        },
                        new
                        {
                            MovieID = 2,
                            CategoryID = 6,
                            Director = "Mike Nichols",
                            Edited = false,
                            LentTo = "",
                            Notes = "Hello Darkness",
                            Rating = "PG",
                            Title = "The Graduate",
                            Year = 1967
                        },
                        new
                        {
                            MovieID = 3,
                            CategoryID = 3,
                            Director = "Joel Crawford",
                            Edited = false,
                            LentTo = "",
                            Notes = "The most epic tale we've seen since Homer's 'Odyssey'",
                            Rating = "PG",
                            Title = "Puss in Boots: The Last Wish",
                            Year = 2022
                        });
                });

            modelBuilder.Entity("DateMe.Models.MovieSubmission", b =>
                {
                    b.HasOne("DateMe.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}