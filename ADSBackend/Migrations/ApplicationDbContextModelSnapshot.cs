﻿// <auto-generated />
using System;
using ADSBackend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ADSBackend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ADSBackend.Models.ConfigurationItem", b =>
                {
                    b.Property<string>("Key")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Value");

                    b.HasKey("Key");

                    b.ToTable("ConfigurationItem");
                });

            modelBuilder.Entity("ADSBackend.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BlackPlayerId");

                    b.Property<bool>("Completed");

                    b.Property<int>("MatchId");

                    b.Property<int>("Result");

                    b.Property<int?>("WhitePlayerId");

                    b.HasKey("GameId");

                    b.HasIndex("BlackPlayerId");

                    b.HasIndex("MatchId");

                    b.HasIndex("WhitePlayerId");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("ADSBackend.Models.Identity.ApplicationRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("ADSBackend.Models.Identity.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<int>("SchoolId");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("SchoolId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ADSBackend.Models.Match", b =>
                {
                    b.Property<int>("MatchId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AwayPoints");

                    b.Property<int?>("AwaySchoolSchoolId");

                    b.Property<bool>("Completed");

                    b.Property<double>("HomePoints");

                    b.Property<int?>("HomeSchoolSchoolId");

                    b.Property<DateTime>("MatchDate");

                    b.HasKey("MatchId");

                    b.HasIndex("AwaySchoolSchoolId");

                    b.HasIndex("HomeSchoolSchoolId");

                    b.ToTable("Match");
                });

            modelBuilder.Entity("ADSBackend.Models.MessagesModels.Message", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("Description");

                    b.Property<string>("Link");

                    b.Property<DateTime>("PublishDate");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("ADSBackend.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("Rating");

                    b.Property<int>("SchoolId");

                    b.HasKey("PlayerId");

                    b.HasIndex("SchoolId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("ADSBackend.Models.School", b =>
                {
                    b.Property<int>("SchoolId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abbreviation")
                        .HasMaxLength(2);

                    b.Property<string>("AdvisorEmail");

                    b.Property<string>("AdvisorName");

                    b.Property<string>("AdvisorPhoneNumber");

                    b.Property<string>("Name");

                    b.Property<int>("SeasonId");

                    b.Property<string>("ShortName")
                        .HasMaxLength(12);

                    b.HasKey("SchoolId");

                    b.HasIndex("SeasonId");

                    b.ToTable("School");
                });

            modelBuilder.Entity("ADSBackend.Models.Season", b =>
                {
                    b.Property<int>("SeasonId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("SeasonId");

                    b.ToTable("Season");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ADSBackend.Models.Game", b =>
                {
                    b.HasOne("ADSBackend.Models.Player", "Black")
                        .WithMany()
                        .HasForeignKey("BlackPlayerId");

                    b.HasOne("ADSBackend.Models.Match", "Match")
                        .WithMany("Games")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ADSBackend.Models.Player", "White")
                        .WithMany()
                        .HasForeignKey("WhitePlayerId");
                });

            modelBuilder.Entity("ADSBackend.Models.Identity.ApplicationUser", b =>
                {
                    b.HasOne("ADSBackend.Models.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ADSBackend.Models.Match", b =>
                {
                    b.HasOne("ADSBackend.Models.School", "AwaySchool")
                        .WithMany()
                        .HasForeignKey("AwaySchoolSchoolId");

                    b.HasOne("ADSBackend.Models.School", "HomeSchool")
                        .WithMany()
                        .HasForeignKey("HomeSchoolSchoolId");
                });

            modelBuilder.Entity("ADSBackend.Models.Player", b =>
                {
                    b.HasOne("ADSBackend.Models.School", "PlayerSchool")
                        .WithMany("Players")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ADSBackend.Models.School", b =>
                {
                    b.HasOne("ADSBackend.Models.Season", "Season")
                        .WithMany("Schools")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("ADSBackend.Models.Identity.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("ADSBackend.Models.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("ADSBackend.Models.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("ADSBackend.Models.Identity.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ADSBackend.Models.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("ADSBackend.Models.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
