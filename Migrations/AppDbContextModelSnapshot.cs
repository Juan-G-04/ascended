﻿// <auto-generated />
using System;
using AscendedGuild.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AscendedGuild.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AscendedGuild.Models.About.TextBlock", b =>
                {
                    b.Property<int>("TextBlockId")
                        .HasColumnType("int");

                    b.Property<string>("MarkdownContent")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4")
                        .HasMaxLength(3000);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("TextBlockId");

                    b.ToTable("TextBlocks");
                });

            modelBuilder.Entity("AscendedGuild.Models.Recruitement.PlayerClass", b =>
                {
                    b.Property<int>("PlayerClassId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("PlayerClassId");

                    b.ToTable("PlayerClasses");

                    b.HasData(
                        new
                        {
                            PlayerClassId = 1,
                            ImageUrl = "/images/class-icons/dk.png",
                            Name = "Death Knight"
                        },
                        new
                        {
                            PlayerClassId = 2,
                            ImageUrl = "/images/class-icons/mage.png",
                            Name = "Mage"
                        },
                        new
                        {
                            PlayerClassId = 3,
                            ImageUrl = "/images/class-icons/rogue.png",
                            Name = "Rogue"
                        },
                        new
                        {
                            PlayerClassId = 4,
                            ImageUrl = "/images/class-icons/dh.png",
                            Name = "Demon Hunter"
                        },
                        new
                        {
                            PlayerClassId = 5,
                            ImageUrl = "/images/class-icons/monk.png",
                            Name = "Monk"
                        },
                        new
                        {
                            PlayerClassId = 6,
                            ImageUrl = "/images/class-icons/shaman.png",
                            Name = "Shaman"
                        },
                        new
                        {
                            PlayerClassId = 7,
                            ImageUrl = "/images/class-icons/druid.png",
                            Name = "Druid"
                        },
                        new
                        {
                            PlayerClassId = 8,
                            ImageUrl = "/images/class-icons/paladin.png",
                            Name = "Paladin"
                        },
                        new
                        {
                            PlayerClassId = 9,
                            ImageUrl = "/images/class-icons/warlock.png",
                            Name = "Warlock"
                        },
                        new
                        {
                            PlayerClassId = 10,
                            ImageUrl = "/images/class-icons/hunter.png",
                            Name = "Hunter"
                        },
                        new
                        {
                            PlayerClassId = 11,
                            ImageUrl = "/images/class-icons/priest.png",
                            Name = "Priest"
                        },
                        new
                        {
                            PlayerClassId = 12,
                            ImageUrl = "/images/class-icons/warrior.png",
                            Name = "Warrior"
                        });
                });

            modelBuilder.Entity("AscendedGuild.Models.Recruitement.Spec", b =>
                {
                    b.Property<int>("SpecId")
                        .HasColumnType("int");

                    b.Property<int>("Demand")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<int>("PlayerClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("SpecId");

                    b.HasIndex("PlayerClassId");

                    b.ToTable("Specs");

                    b.HasData(
                        new
                        {
                            SpecId = 1,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/dk-blood.jpg",
                            Name = "Blood",
                            PlayerClassId = 1
                        },
                        new
                        {
                            SpecId = 2,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/dk-frost.jpg",
                            Name = "Frost",
                            PlayerClassId = 1
                        },
                        new
                        {
                            SpecId = 3,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/dk-unholy.jpg",
                            Name = "Unholy",
                            PlayerClassId = 1
                        },
                        new
                        {
                            SpecId = 4,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/mage-arcane.jpg",
                            Name = "Arcane",
                            PlayerClassId = 2
                        },
                        new
                        {
                            SpecId = 5,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/mage-fire.jpg",
                            Name = "Fire",
                            PlayerClassId = 2
                        },
                        new
                        {
                            SpecId = 6,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/mage-frost.jpg",
                            Name = "Frost",
                            PlayerClassId = 2
                        },
                        new
                        {
                            SpecId = 7,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/rogue-assassination.jpg",
                            Name = "Assassination",
                            PlayerClassId = 3
                        },
                        new
                        {
                            SpecId = 8,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/rogue-outlaw.jpg",
                            Name = "Outlaw",
                            PlayerClassId = 3
                        },
                        new
                        {
                            SpecId = 9,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/rogue-subtlety.jpg",
                            Name = "Subtlety",
                            PlayerClassId = 3
                        },
                        new
                        {
                            SpecId = 10,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/dh-havoc.jpg",
                            Name = "Havoc",
                            PlayerClassId = 4
                        },
                        new
                        {
                            SpecId = 11,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/dh-vengeance.jpg",
                            Name = "Vengeance",
                            PlayerClassId = 4
                        },
                        new
                        {
                            SpecId = 12,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/monk-brewmaster.jpg",
                            Name = "Brewmaster",
                            PlayerClassId = 5
                        },
                        new
                        {
                            SpecId = 13,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/monk-mistweaver.jpg",
                            Name = "Mistweaver",
                            PlayerClassId = 5
                        },
                        new
                        {
                            SpecId = 14,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/monk-windwalker.jpg",
                            Name = "Windwalker",
                            PlayerClassId = 5
                        },
                        new
                        {
                            SpecId = 15,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/shaman-elemental.jpg",
                            Name = "Elemental",
                            PlayerClassId = 6
                        },
                        new
                        {
                            SpecId = 16,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/shaman-enhancement.jpg",
                            Name = "Enhancement",
                            PlayerClassId = 6
                        },
                        new
                        {
                            SpecId = 17,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/shaman-restoration.jpg",
                            Name = "Restoration",
                            PlayerClassId = 6
                        },
                        new
                        {
                            SpecId = 18,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/druid-balance.jpg",
                            Name = "Balance",
                            PlayerClassId = 7
                        },
                        new
                        {
                            SpecId = 19,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/druid-feral.jpg",
                            Name = "Feral",
                            PlayerClassId = 7
                        },
                        new
                        {
                            SpecId = 20,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/druid-guardian.jpg",
                            Name = "Guardian",
                            PlayerClassId = 7
                        },
                        new
                        {
                            SpecId = 21,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/druid-restoration.jpg",
                            Name = "Restoration",
                            PlayerClassId = 7
                        },
                        new
                        {
                            SpecId = 22,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/paladin-holy.jpg",
                            Name = "Holy",
                            PlayerClassId = 8
                        },
                        new
                        {
                            SpecId = 23,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/paladin-protection.jpg",
                            Name = "Protection",
                            PlayerClassId = 8
                        },
                        new
                        {
                            SpecId = 24,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/paladin-retribution.jpg",
                            Name = "Retribution",
                            PlayerClassId = 8
                        },
                        new
                        {
                            SpecId = 25,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/warlock-affliction.jpg",
                            Name = "Affliction",
                            PlayerClassId = 9
                        },
                        new
                        {
                            SpecId = 26,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/warlock-demonology.jpg",
                            Name = "Demonology",
                            PlayerClassId = 9
                        },
                        new
                        {
                            SpecId = 27,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/warlock-destruction.jpg",
                            Name = "Destruction",
                            PlayerClassId = 9
                        },
                        new
                        {
                            SpecId = 28,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/hunter-bm.jpg",
                            Name = "Beast Mastery",
                            PlayerClassId = 10
                        },
                        new
                        {
                            SpecId = 29,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/hunter-marksmanship.jpg",
                            Name = "Marksmanship",
                            PlayerClassId = 10
                        },
                        new
                        {
                            SpecId = 30,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/hunter-survival.jpg",
                            Name = "Survival",
                            PlayerClassId = 10
                        },
                        new
                        {
                            SpecId = 31,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/priest-discipline.jpg",
                            Name = "Discipline",
                            PlayerClassId = 11
                        },
                        new
                        {
                            SpecId = 32,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/priest-holy.jpg",
                            Name = "Holy",
                            PlayerClassId = 11
                        },
                        new
                        {
                            SpecId = 33,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/priest-shadow.jpg",
                            Name = "Shadow",
                            PlayerClassId = 11
                        },
                        new
                        {
                            SpecId = 34,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/warrior-arms.jpg",
                            Name = "Arms",
                            PlayerClassId = 12
                        },
                        new
                        {
                            SpecId = 35,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/warrior-fury.jpg",
                            Name = "Fury",
                            PlayerClassId = 12
                        },
                        new
                        {
                            SpecId = 36,
                            Demand = 0,
                            ImageUrl = "/images/class-icons/warrior-protection.jpg",
                            Name = "Protection",
                            PlayerClassId = 12
                        });
                });

            modelBuilder.Entity("AscendedGuild.Models.Streams.TwitchStreamer", b =>
                {
                    b.Property<int>("TwitchStreamerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Channel")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("CharacterName")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<int>("GuildRank")
                        .HasColumnType("int");

                    b.Property<int>("PlayerClassId")
                        .HasColumnType("int");

                    b.Property<int>("SpecId")
                        .HasColumnType("int");

                    b.HasKey("TwitchStreamerId");

                    b.HasIndex("PlayerClassId");

                    b.HasIndex("SpecId");

                    b.ToTable("TwitchStreamers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AscendedGuild.Models.Recruitement.Spec", b =>
                {
                    b.HasOne("AscendedGuild.Models.Recruitement.PlayerClass", "PlayerClass")
                        .WithMany("Specs")
                        .HasForeignKey("PlayerClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AscendedGuild.Models.Streams.TwitchStreamer", b =>
                {
                    b.HasOne("AscendedGuild.Models.Recruitement.PlayerClass", "PlayerClass")
                        .WithMany()
                        .HasForeignKey("PlayerClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AscendedGuild.Models.Recruitement.Spec", "Spec")
                        .WithMany()
                        .HasForeignKey("SpecId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
