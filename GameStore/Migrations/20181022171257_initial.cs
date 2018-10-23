using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStore.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UrlOnline = table.Column<string>(nullable: true),
                    UrlLocal = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    ImageId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Money = table.Column<int>(nullable: false),
                    Reliability = table.Column<int>(nullable: false),
                    ImageId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Publishers_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Hobbies = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    ImageId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PublisherId = table.Column<Guid>(nullable: false),
                    Rating = table.Column<float>(nullable: false),
                    VideoUrl = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Price = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Token = table.Column<string>(nullable: true),
                    Expire = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaim",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaim_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogin",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogin_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryGames",
                columns: table => new
                {
                    GameId = table.Column<Guid>(nullable: false),
                    CategoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryGames", x => new { x.GameId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_CategoryGames_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryGames_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FreeCodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    GameId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreeCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FreeCodes_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserGames",
                columns: table => new
                {
                    GameId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGames", x => new { x.UserId, x.GameId });
                    table.ForeignKey(
                        name: "FK_UserGames_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserGames_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WishGame",
                columns: table => new
                {
                    GameId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishGame", x => new { x.UserId, x.GameId });
                    table.ForeignKey(
                        name: "FK_WishGame_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WishGame_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImageId", "Title" },
                values: new object[,]
                {
                    { new Guid("e9c798f4-073b-4bc9-931c-4623906386ff"), new Guid("00000000-0000-0000-0000-000000000000"), "Title here" },
                    { new Guid("0fb54ba5-f2e7-4e28-9740-3336a5d9d494"), new Guid("00000000-0000-0000-0000-000000000000"), "Title here" },
                    { new Guid("d609ed22-d617-4e71-b3c4-f2906883c325"), new Guid("00000000-0000-0000-0000-000000000000"), "Title here" },
                    { new Guid("019fe3c6-25b8-4b00-8647-a8a84a61bbc8"), new Guid("00000000-0000-0000-0000-000000000000"), "Title here" },
                    { new Guid("6ae485f2-9d6e-4b62-8965-50e9a91ad58a"), new Guid("00000000-0000-0000-0000-000000000000"), "Title here" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "ImageId", "Money", "Name", "Reliability" },
                values: new object[,]
                {
                    { new Guid("aa06f8f8-14c5-410d-a874-96ace077b75a"), new Guid("00000000-0000-0000-0000-000000000000"), 10000000, "Name here", 5 },
                    { new Guid("ef41de36-fa8b-4b09-a376-3fedfca7545a"), new Guid("00000000-0000-0000-0000-000000000000"), 10000000, "Name here", 5 },
                    { new Guid("b77c0f4d-c284-42d9-a05c-43b63a5278ab"), new Guid("00000000-0000-0000-0000-000000000000"), 10000000, "Name here", 5 },
                    { new Guid("4a9c4886-aded-4545-a5cb-6d59efe16a64"), new Guid("00000000-0000-0000-0000-000000000000"), 10000000, "Name here", 5 },
                    { new Guid("0defb51f-87f6-4eac-95f1-8a9410955ed2"), new Guid("00000000-0000-0000-0000-000000000000"), 10000000, "Name here", 5 },
                    { new Guid("0ba75576-ddd6-4217-a365-d878393a0120"), new Guid("00000000-0000-0000-0000-000000000000"), 10000000, "Name here", 5 }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("5f752fa3-e38a-4120-8b1e-a71de657505f"), "User", "Limited Permission", "User", "User" },
                    { new Guid("17ff0c11-68f8-4fed-a7ab-bd67d056e487"), "Admin", "Full Permission", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Hobbies", "ImageId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("8de39424-3f86-4054-b4f5-018637b87f47"), 0, "a64672cd-263a-42f9-b834-d453fc09a674", "Email@gmail.com", false, "Full Name", "Hobbies", new Guid("00000000-0000-0000-0000-000000000000"), false, null, null, null, "Thatvuhai_7595", "93098509238098523", false, null, false, "UserName" },
                    { new Guid("b3c63488-14b3-4fa0-93a2-c1a5d5228075"), 0, "470b81fd-b3d2-4d55-9cd4-c9bdc2074113", "Email1@gmail.com", false, "Full Name", "Hobbies", new Guid("00000000-0000-0000-0000-000000000000"), false, null, null, null, "Thatvuhai_7595", "93098509228098523", false, null, false, "UserName1" },
                    { new Guid("3abe46b9-dc06-4a1a-8e9f-7cc69881c6a5"), 0, "fd4a2249-c57b-43f8-bab4-b39665fefb6a", "Email2@gmail.com", false, "Full Name", "Hobbies", new Guid("00000000-0000-0000-0000-000000000000"), false, null, null, null, "Thatvuhai_7595", "93098559238098523", false, null, false, "UserName2" },
                    { new Guid("16bb2e3b-68db-4d11-bad0-1106e14a3558"), 0, "5563374c-9d91-4bdc-be5e-b92fdb585cf0", "Email3@gmail.com", false, "Full Name", "Hobbies", new Guid("00000000-0000-0000-0000-000000000000"), false, null, null, null, "Thatvuhai_7595", "93098609238098523", false, null, false, "UserName3" },
                    { new Guid("5319c4c2-f186-4db7-8e48-57c4d624248e"), 0, "95a74df1-448b-4042-9222-1b9415951f32", "Email4@gmail.com", false, "Full Name", "Hobbies", new Guid("00000000-0000-0000-0000-000000000000"), false, null, null, null, "Thatvuhai_7595", "93098509738098523", false, null, false, "UserName4" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Content", "Name", "Price", "PublisherId", "Rating", "ReleaseDate", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("d6995fd6-da72-4c31-aa75-f72bf7e9a5eb"), "Good Game", "Name Of Game", 100000f, new Guid("b77c0f4d-c284-42d9-a05c-43b63a5278ab"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("ff6d2d5a-8621-46db-84fd-e40155c975a1"), "Good Game", "Name Of Game", 100000f, new Guid("aa06f8f8-14c5-410d-a874-96ace077b75a"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("00079ebc-97be-4649-a8b8-73833c949d6d"), "Good Game", "Name Of Game", 100000f, new Guid("0defb51f-87f6-4eac-95f1-8a9410955ed2"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("e4a83ca4-2859-419f-84c6-09e9fc293e89"), "Good Game", "Name Of Game", 100000f, new Guid("0ba75576-ddd6-4217-a365-d878393a0120"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("f27c9614-ee32-47cf-8c26-861d65e6a18c"), "Good Game", "Name Of Game", 100000f, new Guid("4a9c4886-aded-4545-a5cb-6d59efe16a64"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" }
                });

            migrationBuilder.InsertData(
                table: "CategoryGames",
                columns: new[] { "GameId", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("d6995fd6-da72-4c31-aa75-f72bf7e9a5eb"), new Guid("e9c798f4-073b-4bc9-931c-4623906386ff") },
                    { new Guid("f27c9614-ee32-47cf-8c26-861d65e6a18c"), new Guid("6ae485f2-9d6e-4b62-8965-50e9a91ad58a") },
                    { new Guid("ff6d2d5a-8621-46db-84fd-e40155c975a1"), new Guid("0fb54ba5-f2e7-4e28-9740-3336a5d9d494") },
                    { new Guid("e4a83ca4-2859-419f-84c6-09e9fc293e89"), new Guid("019fe3c6-25b8-4b00-8647-a8a84a61bbc8") },
                    { new Guid("00079ebc-97be-4649-a8b8-73833c949d6d"), new Guid("d609ed22-d617-4e71-b3c4-f2906883c325") }
                });

            migrationBuilder.InsertData(
                table: "FreeCodes",
                columns: new[] { "Id", "Code", "GameId" },
                values: new object[,]
                {
                    { new Guid("919bef97-6971-4636-8df6-ec7cbd45899a"), "03d24092-6329-477d-9af5-8ca0b1a6cc09", new Guid("f27c9614-ee32-47cf-8c26-861d65e6a18c") },
                    { new Guid("f50597f6-3e71-4b5c-b5bc-2c274919054d"), "61e8c0f6-0b95-4f71-958f-0757ab5e30c1", new Guid("e4a83ca4-2859-419f-84c6-09e9fc293e89") },
                    { new Guid("deb20e71-e8c2-4f8a-90ed-21c3a009634b"), "b8606f11-0081-430e-b189-3e3993db44f9", new Guid("00079ebc-97be-4649-a8b8-73833c949d6d") },
                    { new Guid("ea6afb1b-b8f2-458f-9bf9-79344f06f027"), "b34ffc7a-0ac2-4a7c-9e88-794f4b5d10f2", new Guid("ff6d2d5a-8621-46db-84fd-e40155c975a1") },
                    { new Guid("cee32ec3-0522-4a2c-bf65-c33e664c7e26"), "dba5e8ad-150e-4368-a2d3-537c67f89312", new Guid("d6995fd6-da72-4c31-aa75-f72bf7e9a5eb") }
                });

            migrationBuilder.InsertData(
                table: "UserGames",
                columns: new[] { "UserId", "GameId", "PurchaseDate" },
                values: new object[,]
                {
                    { new Guid("b3c63488-14b3-4fa0-93a2-c1a5d5228075"), new Guid("ff6d2d5a-8621-46db-84fd-e40155c975a1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5319c4c2-f186-4db7-8e48-57c4d624248e"), new Guid("f27c9614-ee32-47cf-8c26-861d65e6a18c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3abe46b9-dc06-4a1a-8e9f-7cc69881c6a5"), new Guid("00079ebc-97be-4649-a8b8-73833c949d6d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("16bb2e3b-68db-4d11-bad0-1106e14a3558"), new Guid("e4a83ca4-2859-419f-84c6-09e9fc293e89"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8de39424-3f86-4054-b4f5-018637b87f47"), new Guid("d6995fd6-da72-4c31-aa75-f72bf7e9a5eb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "WishGame",
                columns: new[] { "UserId", "GameId" },
                values: new object[,]
                {
                    { new Guid("3abe46b9-dc06-4a1a-8e9f-7cc69881c6a5"), new Guid("00079ebc-97be-4649-a8b8-73833c949d6d") },
                    { new Guid("8de39424-3f86-4054-b4f5-018637b87f47"), new Guid("d6995fd6-da72-4c31-aa75-f72bf7e9a5eb") },
                    { new Guid("16bb2e3b-68db-4d11-bad0-1106e14a3558"), new Guid("e4a83ca4-2859-419f-84c6-09e9fc293e89") },
                    { new Guid("b3c63488-14b3-4fa0-93a2-c1a5d5228075"), new Guid("ff6d2d5a-8621-46db-84fd-e40155c975a1") },
                    { new Guid("5319c4c2-f186-4db7-8e48-57c4d624248e"), new Guid("f27c9614-ee32-47cf-8c26-861d65e6a18c") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ImageId",
                table: "Categories",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryGames_CategoryId",
                table: "CategoryGames",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FreeCodes_GameId",
                table: "FreeCodes",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_PublisherId",
                table: "Games",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Publishers_ImageId",
                table: "Publishers",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Role",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_User_ImageId",
                table: "User",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "User",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaim_UserId",
                table: "UserClaim",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGames_GameId",
                table: "UserGames",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogin_UserId",
                table: "UserLogin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_WishGame_GameId",
                table: "WishGame",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CategoryGames");

            migrationBuilder.DropTable(
                name: "FreeCodes");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "UserClaim");

            migrationBuilder.DropTable(
                name: "UserGames");

            migrationBuilder.DropTable(
                name: "UserLogin");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "WishGame");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
