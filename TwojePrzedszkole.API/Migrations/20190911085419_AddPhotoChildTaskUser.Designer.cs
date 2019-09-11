﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TwojePrzedszkole.API.Data;

namespace TwojePrzedszkole.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190911085419_AddPhotoChildTaskUser")]
    partial class AddPhotoChildTaskUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("TwojePrzedszkole.API.Models.Child", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ChildGroupId");

                    b.Property<string>("City");

                    b.Property<DateTime>("Created");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Street");

                    b.Property<int>("StreetNo");

                    b.Property<int?>("TaskId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ChildGroupId");

                    b.HasIndex("TaskId");

                    b.HasIndex("UserId");

                    b.ToTable("Childs");
                });

            modelBuilder.Entity("TwojePrzedszkole.API.Models.ChildGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("ChildGroups");
                });

            modelBuilder.Entity("TwojePrzedszkole.API.Models.ChildGroupCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ChildGroupId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ChildGroupId");

                    b.ToTable("ChildGroupCategories");
                });

            modelBuilder.Entity("TwojePrzedszkole.API.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Description");

                    b.Property<int>("PhotoGalleryId");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("PhotoGalleryId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("TwojePrzedszkole.API.Models.PhotoGallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("PhotoGallerys");
                });

            modelBuilder.Entity("TwojePrzedszkole.API.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("TaskCost");

                    b.Property<DateTime>("TaskDate");

                    b.Property<string>("TaskName");

                    b.HasKey("Id");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("TwojePrzedszkole.API.Models.TaskCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("TaskId");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskCategories");
                });

            modelBuilder.Entity("TwojePrzedszkole.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<DateTime>("LastActive");

                    b.Property<string>("LastName");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Street");

                    b.Property<int>("StreetNo");

                    b.Property<int?>("TaskId");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TwojePrzedszkole.API.Models.UserGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserGroups");
                });

            modelBuilder.Entity("TwojePrzedszkole.API.Models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });

            modelBuilder.Entity("TwojePrzedszkole.API.Models.Child", b =>
                {
                    b.HasOne("TwojePrzedszkole.API.Models.ChildGroup")
                        .WithMany("AssignedChilds")
                        .HasForeignKey("ChildGroupId");

                    b.HasOne("TwojePrzedszkole.API.Models.Task")
                        .WithMany("AssignedChilds")
                        .HasForeignKey("TaskId");

                    b.HasOne("TwojePrzedszkole.API.Models.User", "User")
                        .WithMany("Children")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TwojePrzedszkole.API.Models.ChildGroupCategory", b =>
                {
                    b.HasOne("TwojePrzedszkole.API.Models.ChildGroup")
                        .WithMany("ChildGroupCategories")
                        .HasForeignKey("ChildGroupId");
                });

            modelBuilder.Entity("TwojePrzedszkole.API.Models.Photo", b =>
                {
                    b.HasOne("TwojePrzedszkole.API.Models.PhotoGallery", "PhotoGallery")
                        .WithMany("Photos")
                        .HasForeignKey("PhotoGalleryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TwojePrzedszkole.API.Models.TaskCategory", b =>
                {
                    b.HasOne("TwojePrzedszkole.API.Models.Task")
                        .WithMany("TaskCategories")
                        .HasForeignKey("TaskId");
                });

            modelBuilder.Entity("TwojePrzedszkole.API.Models.User", b =>
                {
                    b.HasOne("TwojePrzedszkole.API.Models.Task")
                        .WithMany("AssignedUsers")
                        .HasForeignKey("TaskId");
                });

            modelBuilder.Entity("TwojePrzedszkole.API.Models.UserGroup", b =>
                {
                    b.HasOne("TwojePrzedszkole.API.Models.User")
                        .WithMany("GroupName")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
