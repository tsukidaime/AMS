﻿// <auto-generated />
using System;
using System.Collections.Generic;
using AMS.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AMS.Core.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190314031744_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("AMS.Core.Models.Application", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ApplicantId");

                    b.HasKey("Id");

                    b.HasIndex("ApplicantId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("AMS.Core.Models.Certificate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CertificateFile");

                    b.Property<int>("CertificateType");

                    b.HasKey("Id");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("AMS.Core.Models.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BuildingNumber");

                    b.Property<string>("City");

                    b.Property<string>("District");

                    b.Property<string>("Region");

                    b.Property<string>("Street");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("AMS.Core.Models.Mark", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CertificateId");

                    b.Property<string>("Subject");

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.HasIndex("CertificateId");

                    b.ToTable("Marks");
                });

            modelBuilder.Entity("AMS.Core.Models.Rating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Academing");

                    b.Property<double>("Employeer");

                    b.Property<double>("Overall");

                    b.Property<double>("Teaching");

                    b.HasKey("Id");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("AMS.Core.Models.School", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("LocationId");

                    b.Property<string>("Name");

                    b.Property<bool>("Village");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("AMS.Core.Models.Specialty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ApplicationId");

                    b.Property<string>("Name");

                    b.Property<Guid?>("UniversityId");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("UniversityId");

                    b.ToTable("Specialties");
                });

            modelBuilder.Entity("AMS.Core.Models.University", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("LocationId");

                    b.Property<string>("Name");

                    b.Property<Guid?>("RatingId");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("RatingId");

                    b.ToTable("Universities");
                });

            modelBuilder.Entity("AMS.Core.Models.UNT", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ApplicationId");

                    b.Property<string>("PlaceOfExam");

                    b.Property<int>("Points");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.ToTable("Unts");
                });

            modelBuilder.Entity("AMS.Core.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecondName");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool?>("Sex");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AMS.Core.Models.Applicant", b =>
                {
                    b.HasBaseType("AMS.Core.Models.User");

                    b.Property<Guid?>("CertificateId");

                    b.Property<List<string>>("Diplomas");

                    b.Property<string>("IIN");

                    b.Property<string>("MilitaryDocument");

                    b.Property<string>("Residence");

                    b.Property<Guid?>("SchoolId");

                    b.Property<Guid?>("UNTId");

                    b.HasIndex("CertificateId");

                    b.HasIndex("SchoolId");

                    b.HasIndex("UNTId");

                    b.ToTable("Applicant");

                    b.HasDiscriminator().HasValue("Applicant");
                });

            modelBuilder.Entity("AMS.Core.Models.Employee", b =>
                {
                    b.HasBaseType("AMS.Core.Models.User");

                    b.Property<string>("Position");

                    b.Property<Guid?>("UniversityId");

                    b.HasIndex("UniversityId");

                    b.ToTable("Employee");

                    b.HasDiscriminator().HasValue("Employee");
                });

            modelBuilder.Entity("AMS.Core.Models.Application", b =>
                {
                    b.HasOne("AMS.Core.Models.Applicant", "Applicant")
                        .WithMany()
                        .HasForeignKey("ApplicantId");
                });

            modelBuilder.Entity("AMS.Core.Models.Mark", b =>
                {
                    b.HasOne("AMS.Core.Models.Certificate", "Certificate")
                        .WithMany()
                        .HasForeignKey("CertificateId");
                });

            modelBuilder.Entity("AMS.Core.Models.School", b =>
                {
                    b.HasOne("AMS.Core.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("AMS.Core.Models.Specialty", b =>
                {
                    b.HasOne("AMS.Core.Models.Application", "Application")
                        .WithMany()
                        .HasForeignKey("ApplicationId");

                    b.HasOne("AMS.Core.Models.University", "University")
                        .WithMany()
                        .HasForeignKey("UniversityId");
                });

            modelBuilder.Entity("AMS.Core.Models.University", b =>
                {
                    b.HasOne("AMS.Core.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.HasOne("AMS.Core.Models.Rating", "Rating")
                        .WithMany()
                        .HasForeignKey("RatingId");
                });

            modelBuilder.Entity("AMS.Core.Models.UNT", b =>
                {
                    b.HasOne("AMS.Core.Models.Application", "Application")
                        .WithMany()
                        .HasForeignKey("ApplicationId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AMS.Core.Models.Applicant", b =>
                {
                    b.HasOne("AMS.Core.Models.Certificate", "Certificate")
                        .WithMany()
                        .HasForeignKey("CertificateId");

                    b.HasOne("AMS.Core.Models.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolId");

                    b.HasOne("AMS.Core.Models.UNT", "UNT")
                        .WithMany()
                        .HasForeignKey("UNTId");
                });

            modelBuilder.Entity("AMS.Core.Models.Employee", b =>
                {
                    b.HasOne("AMS.Core.Models.University")
                        .WithMany("Employees")
                        .HasForeignKey("UniversityId");
                });
#pragma warning restore 612, 618
        }
    }
}