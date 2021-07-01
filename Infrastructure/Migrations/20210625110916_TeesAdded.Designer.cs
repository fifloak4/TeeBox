﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeeBox.Infrastructure;

namespace TeeBox.Infrastructure.Migrations
{
    [DbContext(typeof(GolfContext))]
    [Migration("20210625110916_TeesAdded")]
    partial class TeesAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TeeBox.Domain.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sobienie Królewskie G&C"
                        });
                });

            modelBuilder.Entity("TeeBox.Domain.Hole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short>("Hcp")
                        .HasColumnType("smallint");

                    b.Property<short>("Number")
                        .HasColumnType("smallint");

                    b.Property<short>("Par")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("Holes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Hcp = (short)8,
                            Number = (short)1,
                            Par = (short)4
                        },
                        new
                        {
                            Id = 2,
                            Hcp = (short)14,
                            Number = (short)2,
                            Par = (short)3
                        },
                        new
                        {
                            Id = 3,
                            Hcp = (short)13,
                            Number = (short)3,
                            Par = (short)5
                        },
                        new
                        {
                            Id = 4,
                            Hcp = (short)16,
                            Number = (short)4,
                            Par = (short)3
                        },
                        new
                        {
                            Id = 5,
                            Hcp = (short)17,
                            Number = (short)5,
                            Par = (short)4
                        },
                        new
                        {
                            Id = 6,
                            Hcp = (short)4,
                            Number = (short)6,
                            Par = (short)4
                        },
                        new
                        {
                            Id = 7,
                            Hcp = (short)2,
                            Number = (short)7,
                            Par = (short)4
                        },
                        new
                        {
                            Id = 8,
                            Hcp = (short)7,
                            Number = (short)8,
                            Par = (short)5
                        },
                        new
                        {
                            Id = 9,
                            Hcp = (short)6,
                            Number = (short)9,
                            Par = (short)3
                        },
                        new
                        {
                            Id = 10,
                            Hcp = (short)10,
                            Number = (short)10,
                            Par = (short)4
                        },
                        new
                        {
                            Id = 11,
                            Hcp = (short)9,
                            Number = (short)11,
                            Par = (short)4
                        },
                        new
                        {
                            Id = 12,
                            Hcp = (short)15,
                            Number = (short)12,
                            Par = (short)3
                        },
                        new
                        {
                            Id = 13,
                            Hcp = (short)3,
                            Number = (short)13,
                            Par = (short)4
                        },
                        new
                        {
                            Id = 14,
                            Hcp = (short)1,
                            Number = (short)14,
                            Par = (short)4
                        },
                        new
                        {
                            Id = 15,
                            Hcp = (short)5,
                            Number = (short)15,
                            Par = (short)5
                        },
                        new
                        {
                            Id = 16,
                            Hcp = (short)11,
                            Number = (short)16,
                            Par = (short)3
                        },
                        new
                        {
                            Id = 17,
                            Hcp = (short)18,
                            Number = (short)17,
                            Par = (short)4
                        },
                        new
                        {
                            Id = 18,
                            Hcp = (short)12,
                            Number = (short)18,
                            Par = (short)5
                        });
                });

            modelBuilder.Entity("TeeBox.Domain.Tee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Distance")
                        .HasColumnType("float");

                    b.Property<int>("HoleId")
                        .HasColumnType("int");

                    b.Property<int>("TeeColorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Distance = 356.0,
                            HoleId = 1,
                            TeeColorId = 1
                        },
                        new
                        {
                            Id = 2,
                            Distance = 333.0,
                            HoleId = 1,
                            TeeColorId = 2
                        },
                        new
                        {
                            Id = 3,
                            Distance = 312.0,
                            HoleId = 1,
                            TeeColorId = 3
                        },
                        new
                        {
                            Id = 4,
                            Distance = 293.0,
                            HoleId = 1,
                            TeeColorId = 4
                        },
                        new
                        {
                            Id = 5,
                            Distance = 138.0,
                            HoleId = 2,
                            TeeColorId = 1
                        },
                        new
                        {
                            Id = 6,
                            Distance = 131.0,
                            HoleId = 2,
                            TeeColorId = 2
                        },
                        new
                        {
                            Id = 7,
                            Distance = 129.0,
                            HoleId = 2,
                            TeeColorId = 3
                        },
                        new
                        {
                            Id = 8,
                            Distance = 119.0,
                            HoleId = 2,
                            TeeColorId = 4
                        },
                        new
                        {
                            Id = 9,
                            Distance = 460.0,
                            HoleId = 3,
                            TeeColorId = 1
                        },
                        new
                        {
                            Id = 10,
                            Distance = 453.0,
                            HoleId = 3,
                            TeeColorId = 2
                        },
                        new
                        {
                            Id = 11,
                            Distance = 434.0,
                            HoleId = 3,
                            TeeColorId = 3
                        },
                        new
                        {
                            Id = 12,
                            Distance = 398.0,
                            HoleId = 3,
                            TeeColorId = 4
                        },
                        new
                        {
                            Id = 13,
                            Distance = 183.0,
                            HoleId = 4,
                            TeeColorId = 1
                        },
                        new
                        {
                            Id = 14,
                            Distance = 171.0,
                            HoleId = 4,
                            TeeColorId = 2
                        },
                        new
                        {
                            Id = 15,
                            Distance = 160.0,
                            HoleId = 4,
                            TeeColorId = 3
                        },
                        new
                        {
                            Id = 16,
                            Distance = 101.0,
                            HoleId = 4,
                            TeeColorId = 4
                        },
                        new
                        {
                            Id = 17,
                            Distance = 313.0,
                            HoleId = 5,
                            TeeColorId = 1
                        },
                        new
                        {
                            Id = 18,
                            Distance = 304.0,
                            HoleId = 5,
                            TeeColorId = 2
                        },
                        new
                        {
                            Id = 19,
                            Distance = 289.0,
                            HoleId = 5,
                            TeeColorId = 3
                        },
                        new
                        {
                            Id = 20,
                            Distance = 275.0,
                            HoleId = 5,
                            TeeColorId = 4
                        },
                        new
                        {
                            Id = 21,
                            Distance = 316.0,
                            HoleId = 6,
                            TeeColorId = 1
                        },
                        new
                        {
                            Id = 22,
                            Distance = 294.0,
                            HoleId = 6,
                            TeeColorId = 2
                        },
                        new
                        {
                            Id = 23,
                            Distance = 255.0,
                            HoleId = 6,
                            TeeColorId = 3
                        },
                        new
                        {
                            Id = 24,
                            Distance = 247.0,
                            HoleId = 6,
                            TeeColorId = 4
                        },
                        new
                        {
                            Id = 25,
                            Distance = 433.0,
                            HoleId = 7,
                            TeeColorId = 1
                        },
                        new
                        {
                            Id = 26,
                            Distance = 414.0,
                            HoleId = 7,
                            TeeColorId = 2
                        },
                        new
                        {
                            Id = 27,
                            Distance = 387.0,
                            HoleId = 7,
                            TeeColorId = 3
                        },
                        new
                        {
                            Id = 28,
                            Distance = 347.0,
                            HoleId = 7,
                            TeeColorId = 4
                        },
                        new
                        {
                            Id = 29,
                            Distance = 496.0,
                            HoleId = 8,
                            TeeColorId = 1
                        },
                        new
                        {
                            Id = 30,
                            Distance = 473.0,
                            HoleId = 8,
                            TeeColorId = 2
                        },
                        new
                        {
                            Id = 31,
                            Distance = 440.0,
                            HoleId = 8,
                            TeeColorId = 3
                        },
                        new
                        {
                            Id = 32,
                            Distance = 398.0,
                            HoleId = 8,
                            TeeColorId = 4
                        },
                        new
                        {
                            Id = 33,
                            Distance = 165.0,
                            HoleId = 9,
                            TeeColorId = 1
                        },
                        new
                        {
                            Id = 34,
                            Distance = 156.0,
                            HoleId = 9,
                            TeeColorId = 2
                        },
                        new
                        {
                            Id = 35,
                            Distance = 145.0,
                            HoleId = 9,
                            TeeColorId = 3
                        },
                        new
                        {
                            Id = 36,
                            Distance = 134.0,
                            HoleId = 9,
                            TeeColorId = 4
                        },
                        new
                        {
                            Id = 37,
                            Distance = 371.0,
                            HoleId = 10,
                            TeeColorId = 1
                        },
                        new
                        {
                            Id = 38,
                            Distance = 350.0,
                            HoleId = 10,
                            TeeColorId = 2
                        },
                        new
                        {
                            Id = 39,
                            Distance = 327.0,
                            HoleId = 10,
                            TeeColorId = 3
                        },
                        new
                        {
                            Id = 40,
                            Distance = 278.0,
                            HoleId = 10,
                            TeeColorId = 4
                        },
                        new
                        {
                            Id = 41,
                            Distance = 368.0,
                            HoleId = 11,
                            TeeColorId = 1
                        },
                        new
                        {
                            Id = 42,
                            Distance = 347.0,
                            HoleId = 11,
                            TeeColorId = 2
                        },
                        new
                        {
                            Id = 43,
                            Distance = 324.0,
                            HoleId = 11,
                            TeeColorId = 3
                        },
                        new
                        {
                            Id = 44,
                            Distance = 305.0,
                            HoleId = 11,
                            TeeColorId = 4
                        },
                        new
                        {
                            Id = 45,
                            Distance = 174.0,
                            HoleId = 12,
                            TeeColorId = 1
                        },
                        new
                        {
                            Id = 46,
                            Distance = 161.0,
                            HoleId = 12,
                            TeeColorId = 2
                        },
                        new
                        {
                            Id = 47,
                            Distance = 150.0,
                            HoleId = 12,
                            TeeColorId = 3
                        },
                        new
                        {
                            Id = 48,
                            Distance = 142.0,
                            HoleId = 12,
                            TeeColorId = 4
                        },
                        new
                        {
                            Id = 49,
                            Distance = 349.0,
                            HoleId = 13,
                            TeeColorId = 1
                        },
                        new
                        {
                            Id = 50,
                            Distance = 337.0,
                            HoleId = 13,
                            TeeColorId = 2
                        },
                        new
                        {
                            Id = 51,
                            Distance = 333.0,
                            HoleId = 13,
                            TeeColorId = 3
                        },
                        new
                        {
                            Id = 52,
                            Distance = 331.0,
                            HoleId = 13,
                            TeeColorId = 4
                        },
                        new
                        {
                            Id = 53,
                            Distance = 418.0,
                            HoleId = 14,
                            TeeColorId = 1
                        },
                        new
                        {
                            Id = 54,
                            Distance = 408.0,
                            HoleId = 14,
                            TeeColorId = 2
                        },
                        new
                        {
                            Id = 55,
                            Distance = 382.0,
                            HoleId = 14,
                            TeeColorId = 3
                        },
                        new
                        {
                            Id = 56,
                            Distance = 351.0,
                            HoleId = 14,
                            TeeColorId = 4
                        },
                        new
                        {
                            Id = 57,
                            Distance = 522.0,
                            HoleId = 15,
                            TeeColorId = 1
                        },
                        new
                        {
                            Id = 58,
                            Distance = 495.0,
                            HoleId = 15,
                            TeeColorId = 2
                        },
                        new
                        {
                            Id = 59,
                            Distance = 458.0,
                            HoleId = 15,
                            TeeColorId = 3
                        },
                        new
                        {
                            Id = 60,
                            Distance = 416.0,
                            HoleId = 15,
                            TeeColorId = 4
                        },
                        new
                        {
                            Id = 61,
                            Distance = 178.0,
                            HoleId = 16,
                            TeeColorId = 1
                        },
                        new
                        {
                            Id = 62,
                            Distance = 168.0,
                            HoleId = 16,
                            TeeColorId = 2
                        },
                        new
                        {
                            Id = 63,
                            Distance = 136.0,
                            HoleId = 16,
                            TeeColorId = 3
                        },
                        new
                        {
                            Id = 64,
                            Distance = 108.0,
                            HoleId = 16,
                            TeeColorId = 4
                        },
                        new
                        {
                            Id = 65,
                            Distance = 304.0,
                            HoleId = 17,
                            TeeColorId = 1
                        },
                        new
                        {
                            Id = 66,
                            Distance = 276.0,
                            HoleId = 17,
                            TeeColorId = 2
                        },
                        new
                        {
                            Id = 67,
                            Distance = 260.0,
                            HoleId = 17,
                            TeeColorId = 3
                        },
                        new
                        {
                            Id = 68,
                            Distance = 240.0,
                            HoleId = 17,
                            TeeColorId = 4
                        },
                        new
                        {
                            Id = 69,
                            Distance = 481.0,
                            HoleId = 18,
                            TeeColorId = 1
                        },
                        new
                        {
                            Id = 70,
                            Distance = 460.0,
                            HoleId = 18,
                            TeeColorId = 2
                        },
                        new
                        {
                            Id = 71,
                            Distance = 446.0,
                            HoleId = 18,
                            TeeColorId = 3
                        },
                        new
                        {
                            Id = 72,
                            Distance = 379.0,
                            HoleId = 18,
                            TeeColorId = 4
                        });
                });

            modelBuilder.Entity("TeeBox.Domain.TeeColor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TeeColors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = 0,
                            CourseId = 1
                        },
                        new
                        {
                            Id = 2,
                            Color = 1,
                            CourseId = 1
                        },
                        new
                        {
                            Id = 3,
                            Color = 2,
                            CourseId = 1
                        },
                        new
                        {
                            Id = 4,
                            Color = 3,
                            CourseId = 1
                        });
                });

            modelBuilder.Entity("TeeBox.Domain.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
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
                    b.HasOne("TeeBox.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TeeBox.Domain.User", null)
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

                    b.HasOne("TeeBox.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TeeBox.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
