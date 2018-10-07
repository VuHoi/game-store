﻿// <auto-generated />
using System;
using GameStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GameStore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181006171135_seed-role-data")]
    partial class seedroledata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GameStore.Model.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Role");

                    b.HasData(
                        new { Id = new Guid("8345e32c-1313-475b-9e13-380bf2075461"), ConcurrencyStamp = "User", Description = "Limited Permission", Name = "User", NormalizedName = "User" },
                        new { Id = new Guid("e29d9e04-6d19-45d7-8953-59b18124ef68"), ConcurrencyStamp = "Admin", Description = "Full Permission", Name = "Admin", NormalizedName = "Admin" }
                    );
                });

            modelBuilder.Entity("GameStore.Model.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Image");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = new Guid("6840109d-2440-45bf-ac28-9fd544ec2172"), Image = "Url Image Here", Title = "Title here" },
                        new { Id = new Guid("b2d90441-d617-45b6-932b-a74e0be41b25"), Image = "Url Image Here", Title = "Title here" },
                        new { Id = new Guid("77da9e79-80af-4a35-b507-78acfbfc7007"), Image = "Url Image Here", Title = "Title here" },
                        new { Id = new Guid("e800efe7-88e7-4957-ae9b-73cf81b21308"), Image = "Url Image Here", Title = "Title here" },
                        new { Id = new Guid("6c481ca2-c3ab-417f-9118-71b5fd04ca96"), Image = "Url Image Here", Title = "Title here" }
                    );
                });

            modelBuilder.Entity("GameStore.Model.CategoryGame", b =>
                {
                    b.Property<Guid>("GameId");

                    b.Property<Guid>("CategoryId");

                    b.HasKey("GameId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryGames");

                    b.HasData(
                        new { GameId = new Guid("b040ff96-6537-4768-b8c5-729979993113"), CategoryId = new Guid("6840109d-2440-45bf-ac28-9fd544ec2172") },
                        new { GameId = new Guid("1eda8992-e858-4167-86e0-b32ee72667ff"), CategoryId = new Guid("b2d90441-d617-45b6-932b-a74e0be41b25") },
                        new { GameId = new Guid("df203216-f420-4ecf-8265-bf267cb65449"), CategoryId = new Guid("77da9e79-80af-4a35-b507-78acfbfc7007") },
                        new { GameId = new Guid("d3c6d9db-f60a-4a61-ba41-308c667f2a16"), CategoryId = new Guid("e800efe7-88e7-4957-ae9b-73cf81b21308") },
                        new { GameId = new Guid("4a0a0fae-60ac-4c8a-8307-ec26234ff60f"), CategoryId = new Guid("6c481ca2-c3ab-417f-9118-71b5fd04ca96") }
                    );
                });

            modelBuilder.Entity("GameStore.Model.CodeFree", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<Guid>("GameId");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("CodeFrees");

                    b.HasData(
                        new { Id = new Guid("d0fedc90-6956-41a3-9ed9-b566dc08f4d5"), Code = "6ff0f86a-563c-4c4d-ab44-e00a4cd62794", GameId = new Guid("b040ff96-6537-4768-b8c5-729979993113") },
                        new { Id = new Guid("6124c19a-1c94-4acf-a44c-fa77dc6494f2"), Code = "8dd80a6b-a401-4214-9243-a4d4a7d84587", GameId = new Guid("1eda8992-e858-4167-86e0-b32ee72667ff") },
                        new { Id = new Guid("77adce59-362a-491e-a769-d5702d6ee784"), Code = "5ea4ef9c-aca4-4aae-bd51-088e6f8ccd2f", GameId = new Guid("df203216-f420-4ecf-8265-bf267cb65449") },
                        new { Id = new Guid("1ef9dfc7-4c98-4f67-ab3a-f47dda122c24"), Code = "75db4e4a-b9be-43e4-b541-d836c7a297fa", GameId = new Guid("d3c6d9db-f60a-4a61-ba41-308c667f2a16") },
                        new { Id = new Guid("699cb3c4-9840-4977-8d87-6b6abc02db50"), Code = "b02ccb71-52f3-497b-950d-100048743a6b", GameId = new Guid("4a0a0fae-60ac-4c8a-8307-ec26234ff60f") }
                    );
                });

            modelBuilder.Entity("GameStore.Model.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<string>("Logo");

                    b.Property<string>("Name");

                    b.Property<float>("Price");

                    b.Property<Guid>("PublisherId");

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<float>("Rating");

                    b.Property<string>("VideoUrl");

                    b.HasKey("Id");

                    b.HasIndex("PublisherId");

                    b.ToTable("Games");

                    b.HasData(
                        new { Id = new Guid("b040ff96-6537-4768-b8c5-729979993113"), Content = "Good Game", Logo = "URL Logo here", Name = "Name Of Game", Price = 100000f, PublisherId = new Guid("18c5ad2f-b0df-496f-8f6c-8cb075db28f1"), PurchaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Rating = 4.5f, VideoUrl = "URL Video here" },
                        new { Id = new Guid("1eda8992-e858-4167-86e0-b32ee72667ff"), Content = "Good Game", Logo = "URL Logo here", Name = "Name Of Game", Price = 100000f, PublisherId = new Guid("cf44c3ca-6689-492e-8c99-96619ab3f215"), PurchaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Rating = 4.5f, VideoUrl = "URL Video here" },
                        new { Id = new Guid("df203216-f420-4ecf-8265-bf267cb65449"), Content = "Good Game", Logo = "URL Logo here", Name = "Name Of Game", Price = 100000f, PublisherId = new Guid("425d69de-43a5-4584-b509-b6ba55649b12"), PurchaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Rating = 4.5f, VideoUrl = "URL Video here" },
                        new { Id = new Guid("d3c6d9db-f60a-4a61-ba41-308c667f2a16"), Content = "Good Game", Logo = "URL Logo here", Name = "Name Of Game", Price = 100000f, PublisherId = new Guid("4c873a1a-8d45-4b9d-aee5-514d9c5562b4"), PurchaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Rating = 4.5f, VideoUrl = "URL Video here" },
                        new { Id = new Guid("4a0a0fae-60ac-4c8a-8307-ec26234ff60f"), Content = "Good Game", Logo = "URL Logo here", Name = "Name Of Game", Price = 100000f, PublisherId = new Guid("f8b0f5e0-bf11-4a1d-9413-5d9e5203e114"), PurchaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Rating = 4.5f, VideoUrl = "URL Video here" }
                    );
                });

            modelBuilder.Entity("GameStore.Model.Publisher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Money");

                    b.Property<string>("Name");

                    b.Property<int>("Reliability");

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new { Id = new Guid("18c5ad2f-b0df-496f-8f6c-8cb075db28f1"), Money = 10000000, Name = "Name here", Reliability = 5 },
                        new { Id = new Guid("cf44c3ca-6689-492e-8c99-96619ab3f215"), Money = 10000000, Name = "Name here", Reliability = 5 },
                        new { Id = new Guid("425d69de-43a5-4584-b509-b6ba55649b12"), Money = 10000000, Name = "Name here", Reliability = 5 },
                        new { Id = new Guid("4c873a1a-8d45-4b9d-aee5-514d9c5562b4"), Money = 10000000, Name = "Name here", Reliability = 5 },
                        new { Id = new Guid("f8b0f5e0-bf11-4a1d-9413-5d9e5203e114"), Money = 10000000, Name = "Name here", Reliability = 5 },
                        new { Id = new Guid("e1acce29-31b0-4a9b-8772-f82adc28cd2e"), Money = 10000000, Name = "Name here", Reliability = 5 }
                    );
                });

            modelBuilder.Entity("GameStore.Model.RefreshToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Expire");

                    b.Property<string>("Token");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("GameStore.Model.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

                    b.Property<string>("Hobbies");

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
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("User");

                    b.HasData(
                        new { Id = new Guid("0e388fb6-18ba-4582-b3e1-61545fe5c963"), AccessFailedCount = 0, ConcurrencyStamp = "3d03b718-1ea8-4fe0-9ae5-13f9438d6ab6", Email = "Email@gmail.com", EmailConfirmed = false, FullName = "Full Name", Hobbies = "Hobbies", LockoutEnabled = false, PasswordHash = "Thatvuhai_7595", PhoneNumber = "93098509238098523", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "UserName" },
                        new { Id = new Guid("f59f9dea-1a39-4a66-8ff8-7c6d9020dd92"), AccessFailedCount = 0, ConcurrencyStamp = "6a553f39-da7d-4c81-be80-6709b61c13f1", Email = "Email1@gmail.com", EmailConfirmed = false, FullName = "Full Name", Hobbies = "Hobbies", LockoutEnabled = false, PasswordHash = "Thatvuhai_7595", PhoneNumber = "93098509228098523", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "UserName1" },
                        new { Id = new Guid("32161737-43fd-4424-a5b6-ee05333e6eed"), AccessFailedCount = 0, ConcurrencyStamp = "17a09956-88ad-4b5a-85dc-d4cb2858c440", Email = "Email2@gmail.com", EmailConfirmed = false, FullName = "Full Name", Hobbies = "Hobbies", LockoutEnabled = false, PasswordHash = "Thatvuhai_7595", PhoneNumber = "93098559238098523", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "UserName2" },
                        new { Id = new Guid("49002caa-0090-46d7-8056-be15157b2298"), AccessFailedCount = 0, ConcurrencyStamp = "847bb3fe-e334-40f7-9dbd-7b29c9f59655", Email = "Email3@gmail.com", EmailConfirmed = false, FullName = "Full Name", Hobbies = "Hobbies", LockoutEnabled = false, PasswordHash = "Thatvuhai_7595", PhoneNumber = "93098609238098523", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "UserName3" },
                        new { Id = new Guid("b5175c1e-3f38-4322-8487-4b67b99c7855"), AccessFailedCount = 0, ConcurrencyStamp = "c0d32ca0-2f86-4229-8d92-e67fc6473c79", Email = "Email4@gmail.com", EmailConfirmed = false, FullName = "Full Name", Hobbies = "Hobbies", LockoutEnabled = false, PasswordHash = "Thatvuhai_7595", PhoneNumber = "93098509738098523", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "UserName4" }
                    );
                });

            modelBuilder.Entity("GameStore.Model.UserGame", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("GameId");

                    b.HasKey("UserId", "GameId");

                    b.HasIndex("GameId");

                    b.ToTable("UserGames");

                    b.HasData(
                        new { UserId = new Guid("0e388fb6-18ba-4582-b3e1-61545fe5c963"), GameId = new Guid("b040ff96-6537-4768-b8c5-729979993113") },
                        new { UserId = new Guid("f59f9dea-1a39-4a66-8ff8-7c6d9020dd92"), GameId = new Guid("1eda8992-e858-4167-86e0-b32ee72667ff") },
                        new { UserId = new Guid("32161737-43fd-4424-a5b6-ee05333e6eed"), GameId = new Guid("df203216-f420-4ecf-8265-bf267cb65449") },
                        new { UserId = new Guid("49002caa-0090-46d7-8056-be15157b2298"), GameId = new Guid("d3c6d9db-f60a-4a61-ba41-308c667f2a16") },
                        new { UserId = new Guid("b5175c1e-3f38-4322-8487-4b67b99c7855"), GameId = new Guid("4a0a0fae-60ac-4c8a-8307-ec26234ff60f") }
                    );
                });

            modelBuilder.Entity("GameStore.Model.WishGame", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("GameId");

                    b.HasKey("UserId", "GameId");

                    b.HasIndex("GameId");

                    b.ToTable("WishGame");

                    b.HasData(
                        new { UserId = new Guid("0e388fb6-18ba-4582-b3e1-61545fe5c963"), GameId = new Guid("b040ff96-6537-4768-b8c5-729979993113") },
                        new { UserId = new Guid("f59f9dea-1a39-4a66-8ff8-7c6d9020dd92"), GameId = new Guid("1eda8992-e858-4167-86e0-b32ee72667ff") },
                        new { UserId = new Guid("32161737-43fd-4424-a5b6-ee05333e6eed"), GameId = new Guid("df203216-f420-4ecf-8265-bf267cb65449") },
                        new { UserId = new Guid("49002caa-0090-46d7-8056-be15157b2298"), GameId = new Guid("d3c6d9db-f60a-4a61-ba41-308c667f2a16") },
                        new { UserId = new Guid("b5175c1e-3f38-4322-8487-4b67b99c7855"), GameId = new Guid("4a0a0fae-60ac-4c8a-8307-ec26234ff60f") }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<Guid>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogin");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GameStore.Model.CategoryGame", b =>
                {
                    b.HasOne("GameStore.Model.Category", "Category")
                        .WithMany("Games")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GameStore.Model.Game", "Game")
                        .WithMany("Categories")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GameStore.Model.CodeFree", b =>
                {
                    b.HasOne("GameStore.Model.Game", "Game")
                        .WithMany("FreeCodes")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GameStore.Model.Game", b =>
                {
                    b.HasOne("GameStore.Model.Publisher", "Publisher")
                        .WithMany("Games")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GameStore.Model.RefreshToken", b =>
                {
                    b.HasOne("GameStore.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GameStore.Model.UserGame", b =>
                {
                    b.HasOne("GameStore.Model.Game", "Game")
                        .WithMany("Members")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GameStore.Model.User", "User")
                        .WithMany("Games")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GameStore.Model.WishGame", b =>
                {
                    b.HasOne("GameStore.Model.Game", "Game")
                        .WithMany("FavoriteMembers")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GameStore.Model.User", "User")
                        .WithMany("WishGames")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("GameStore.Model.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("GameStore.Model.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("GameStore.Model.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("GameStore.Model.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GameStore.Model.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("GameStore.Model.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}