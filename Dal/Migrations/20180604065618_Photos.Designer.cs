﻿// <auto-generated />
using Dal.Context;
using Helpers.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Dal.Migrations
{
    [DbContext(typeof(MainDbContext))]
    [Migration("20180604065618_Photos")]
    partial class Photos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dal.Entities.PhotoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Path");

                    b.Property<DateTime>("UploadDate");

                    b.Property<int>("UserId");

                    b.Property<int>("Visibility");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("Dal.Entities.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthdate");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<DateTime>("JoinDate");

                    b.Property<string>("LastName");

                    b.Property<string>("Mail");

                    b.Property<string>("UserIdentificator");

                    b.HasKey("Id");

                    b.ToTable("User","dbo");
                });

            modelBuilder.Entity("Dal.Entities.PhotoEntity", b =>
                {
                    b.HasOne("Dal.Entities.UserEntity", "User")
                        .WithMany("Photos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}