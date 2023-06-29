﻿// <auto-generated />
using System;
using FileStorageDAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FileStorageDAL.Migrations
{
    [DbContext(typeof(FileStorageContext))]
    partial class FileStorageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FileStorageDAL.Models.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FileVersionId")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FileVersionId")
                        .IsUnique();

                    b.ToTable("Files");
                });

            modelBuilder.Entity("FileStorageDAL.Models.FileVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Changelog")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("VersionedFileId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VersionedFileId");

                    b.ToTable("FileVersions");
                });

            modelBuilder.Entity("FileStorageDAL.Models.Folder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FolderId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FolderId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Folders");
                });

            modelBuilder.Entity("FileStorageDAL.Models.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FileId")
                        .HasColumnType("int");

                    b.Property<string>("IpAddress")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("Operation")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FileId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("FileStorageDAL.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Basic"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("FileStorageDAL.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@test.com",
                            Password = "AQAAAAIAAYagAAAAEAZxgGx9vQr5qc+7ArajYsi4UYPk7ahQsbH+1/Q1mp9iQMAlf4pYW+gDe1Dk1ddvzg==",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("FileStorageDAL.Models.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id", "RoleId", "UserId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoleId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            RoleId = 2,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("FileStorageDAL.Models.VersionedFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<int>("FolderId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int?>("NewestVersionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FolderId");

                    b.HasIndex("NewestVersionId")
                        .IsUnique()
                        .HasFilter("[NewestVersionId] IS NOT NULL");

                    b.ToTable("VersionedFiles");
                });

            modelBuilder.Entity("FileStorageDAL.Models.VersionedFileUser", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("VersionedFileId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id", "VersionedFileId", "UserId");

                    b.HasIndex("UserId");

                    b.HasIndex("VersionedFileId");

                    b.ToTable("FileVersionsUsers");
                });

            modelBuilder.Entity("FileStorageDAL.Models.File", b =>
                {
                    b.HasOne("FileStorageDAL.Models.FileVersion", "FileVersion")
                        .WithOne("File")
                        .HasForeignKey("FileStorageDAL.Models.File", "FileVersionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FileVersion");
                });

            modelBuilder.Entity("FileStorageDAL.Models.FileVersion", b =>
                {
                    b.HasOne("FileStorageDAL.Models.VersionedFile", "VersionedFile")
                        .WithMany("FileVersions")
                        .HasForeignKey("VersionedFileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VersionedFile");
                });

            modelBuilder.Entity("FileStorageDAL.Models.Folder", b =>
                {
                    b.HasOne("FileStorageDAL.Models.Folder", null)
                        .WithMany("Folders")
                        .HasForeignKey("FolderId");

                    b.HasOne("FileStorageDAL.Models.User", "Owner")
                        .WithMany("Folders")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("FileStorageDAL.Models.Log", b =>
                {
                    b.HasOne("FileStorageDAL.Models.File", "File")
                        .WithOne()
                        .HasForeignKey("FileStorageDAL.Models.Log", "FileId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FileStorageDAL.Models.User", "User")
                        .WithOne()
                        .HasForeignKey("FileStorageDAL.Models.Log", "UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("File");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FileStorageDAL.Models.UserRole", b =>
                {
                    b.HasOne("FileStorageDAL.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FileStorageDAL.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FileStorageDAL.Models.VersionedFile", b =>
                {
                    b.HasOne("FileStorageDAL.Models.Folder", null)
                        .WithMany("VersionedFiles")
                        .HasForeignKey("FolderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FileStorageDAL.Models.FileVersion", "NewestVersion")
                        .WithOne()
                        .HasForeignKey("FileStorageDAL.Models.VersionedFile", "NewestVersionId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("NewestVersion");
                });

            modelBuilder.Entity("FileStorageDAL.Models.VersionedFileUser", b =>
                {
                    b.HasOne("FileStorageDAL.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FileStorageDAL.Models.VersionedFile", "VersionedFile")
                        .WithMany()
                        .HasForeignKey("VersionedFileId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("VersionedFile");
                });

            modelBuilder.Entity("FileStorageDAL.Models.FileVersion", b =>
                {
                    b.Navigation("File");
                });

            modelBuilder.Entity("FileStorageDAL.Models.Folder", b =>
                {
                    b.Navigation("Folders");

                    b.Navigation("VersionedFiles");
                });

            modelBuilder.Entity("FileStorageDAL.Models.User", b =>
                {
                    b.Navigation("Folders");
                });

            modelBuilder.Entity("FileStorageDAL.Models.VersionedFile", b =>
                {
                    b.Navigation("FileVersions");
                });
#pragma warning restore 612, 618
        }
    }
}
