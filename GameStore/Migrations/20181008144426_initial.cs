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
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Money = table.Column<int>(nullable: false),
                    Reliability = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
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
                    FullName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PublisherId = table.Column<Guid>(nullable: false),
                    Rating = table.Column<float>(nullable: false),
                    Logo = table.Column<string>(nullable: true),
                    VideoUrl = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
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
                name: "CodeFrees",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    GameId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeFrees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CodeFrees_Games_GameId",
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
                    UserId = table.Column<Guid>(nullable: false)
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
                columns: new[] { "Id", "Image", "Title" },
                values: new object[,]
                {
                    { new Guid("a020afc5-9765-4ff7-aef0-fd63b0175ba8"), "Url Image Here", "Title here" },
                    { new Guid("ef79ece7-75d5-485c-9b39-a6f6a1dd30aa"), "Url Image Here", "Title here" },
                    { new Guid("e35502a2-c6d4-4b3c-9eba-ebe34b549dce"), "Url Image Here", "Title here" },
                    { new Guid("8b084066-1970-4667-8865-aac1347814a3"), "Url Image Here", "Title here" },
                    { new Guid("f8dd3cbe-14c9-4dc8-b1ef-ae9989e71c6e"), "Url Image Here", "Title here" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Money", "Name", "Reliability" },
                values: new object[,]
                {
                    { new Guid("7f2b73f4-e33a-46db-a766-7d5cf4fab972"), 10000000, "Name here", 5 },
                    { new Guid("6124322f-0b9a-4f6a-b87e-0ea9e262d8eb"), 10000000, "Name here", 5 },
                    { new Guid("ff641b0e-4ebf-4182-8147-cdd6846ef8f8"), 10000000, "Name here", 5 },
                    { new Guid("450aca89-dc99-4b4b-b951-cf2b3529cb4a"), 10000000, "Name here", 5 },
                    { new Guid("1a822a8c-f83e-4a28-9bb6-1dc65f8996f8"), 10000000, "Name here", 5 },
                    { new Guid("bc3427fe-0bed-4c93-8769-ee852f5f1f23"), 10000000, "Name here", 5 }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("9ac38f5a-8345-47f2-b856-348d7aed2d84"), "User", "Limited Permission", "User", "User" },
                    { new Guid("1afddfa2-9f74-4697-a03d-67fe99ba6425"), "Admin", "Full Permission", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Hobbies", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("5b5afad4-1dae-4e6c-b6e8-f64b7f846c8d"), 0, "7cb1f3b7-b680-48de-b90b-130d2a993d27", "Email@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509238098523", false, null, false, "UserName" },
                    { new Guid("498b7597-88c3-4fe4-9e1d-c3c30c9d4689"), 0, "658aa2aa-7f3f-4461-b283-6daab6aa0519", "Email1@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509228098523", false, null, false, "UserName1" },
                    { new Guid("092f75a5-a2d0-4e99-9547-5b000a6b0a36"), 0, "c593210b-b0a4-437b-8b86-4351c72b23fa", "Email2@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098559238098523", false, null, false, "UserName2" },
                    { new Guid("a9ae1345-0861-4dad-a310-5f671d73270b"), 0, "91d4e5f3-ce87-4ed6-a999-f4035788e9fe", "Email3@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098609238098523", false, null, false, "UserName3" },
                    { new Guid("f85ae91f-bc8c-4389-92b2-714b08047904"), 0, "b11d24b9-97e9-436b-ab7a-9560f168391e", "Email4@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509738098523", false, null, false, "UserName4" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Content", "Logo", "Name", "Price", "PublisherId", "PurchaseDate", "Rating", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("35348799-44c4-4a55-b534-5c2adb80c484"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("ff641b0e-4ebf-4182-8147-cdd6846ef8f8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("9b56717f-6d9f-4e10-83d0-dc399e6f1d21"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("7f2b73f4-e33a-46db-a766-7d5cf4fab972"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("40ee69d3-43aa-49d9-bcac-d4c0b59b53be"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("1a822a8c-f83e-4a28-9bb6-1dc65f8996f8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("294bc8df-fda4-4cef-8cd0-6cd7e4eebc17"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("bc3427fe-0bed-4c93-8769-ee852f5f1f23"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("50146cf1-a579-4494-a57a-245b3e3a2782"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("450aca89-dc99-4b4b-b951-cf2b3529cb4a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" }
                });

            migrationBuilder.InsertData(
                table: "CategoryGames",
                columns: new[] { "GameId", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("35348799-44c4-4a55-b534-5c2adb80c484"), new Guid("a020afc5-9765-4ff7-aef0-fd63b0175ba8") },
                    { new Guid("50146cf1-a579-4494-a57a-245b3e3a2782"), new Guid("f8dd3cbe-14c9-4dc8-b1ef-ae9989e71c6e") },
                    { new Guid("9b56717f-6d9f-4e10-83d0-dc399e6f1d21"), new Guid("ef79ece7-75d5-485c-9b39-a6f6a1dd30aa") },
                    { new Guid("294bc8df-fda4-4cef-8cd0-6cd7e4eebc17"), new Guid("8b084066-1970-4667-8865-aac1347814a3") },
                    { new Guid("40ee69d3-43aa-49d9-bcac-d4c0b59b53be"), new Guid("e35502a2-c6d4-4b3c-9eba-ebe34b549dce") }
                });

            migrationBuilder.InsertData(
                table: "CodeFrees",
                columns: new[] { "Id", "Code", "GameId" },
                values: new object[,]
                {
                    { new Guid("15a4ed7e-e0cb-4204-ae35-0fff010891a7"), "886eacb5-660f-4bd4-82c3-a360874d0f37", new Guid("50146cf1-a579-4494-a57a-245b3e3a2782") },
                    { new Guid("aaa6c3dc-d9b2-4494-b3b0-ebfdc10a1d25"), "4f1203a0-c4e5-4728-a2b0-4147790094d1", new Guid("294bc8df-fda4-4cef-8cd0-6cd7e4eebc17") },
                    { new Guid("cdf97371-476f-4662-a985-301baeee0271"), "c05418ce-9cc4-49c2-84bb-b718a8fa5597", new Guid("40ee69d3-43aa-49d9-bcac-d4c0b59b53be") },
                    { new Guid("23d01fb1-1f42-46f3-8d85-aabe02a22e53"), "b04dec80-2c25-4b55-9440-402287b3e185", new Guid("9b56717f-6d9f-4e10-83d0-dc399e6f1d21") },
                    { new Guid("faec35ac-1312-469c-bf57-f41b55c151e3"), "de1543d1-e13f-4d4a-b488-c11fcbebbc61", new Guid("35348799-44c4-4a55-b534-5c2adb80c484") }
                });

            migrationBuilder.InsertData(
                table: "UserGames",
                columns: new[] { "UserId", "GameId" },
                values: new object[,]
                {
                    { new Guid("498b7597-88c3-4fe4-9e1d-c3c30c9d4689"), new Guid("9b56717f-6d9f-4e10-83d0-dc399e6f1d21") },
                    { new Guid("f85ae91f-bc8c-4389-92b2-714b08047904"), new Guid("50146cf1-a579-4494-a57a-245b3e3a2782") },
                    { new Guid("092f75a5-a2d0-4e99-9547-5b000a6b0a36"), new Guid("40ee69d3-43aa-49d9-bcac-d4c0b59b53be") },
                    { new Guid("a9ae1345-0861-4dad-a310-5f671d73270b"), new Guid("294bc8df-fda4-4cef-8cd0-6cd7e4eebc17") },
                    { new Guid("5b5afad4-1dae-4e6c-b6e8-f64b7f846c8d"), new Guid("35348799-44c4-4a55-b534-5c2adb80c484") }
                });

            migrationBuilder.InsertData(
                table: "WishGame",
                columns: new[] { "UserId", "GameId" },
                values: new object[,]
                {
                    { new Guid("092f75a5-a2d0-4e99-9547-5b000a6b0a36"), new Guid("40ee69d3-43aa-49d9-bcac-d4c0b59b53be") },
                    { new Guid("5b5afad4-1dae-4e6c-b6e8-f64b7f846c8d"), new Guid("35348799-44c4-4a55-b534-5c2adb80c484") },
                    { new Guid("a9ae1345-0861-4dad-a310-5f671d73270b"), new Guid("294bc8df-fda4-4cef-8cd0-6cd7e4eebc17") },
                    { new Guid("498b7597-88c3-4fe4-9e1d-c3c30c9d4689"), new Guid("9b56717f-6d9f-4e10-83d0-dc399e6f1d21") },
                    { new Guid("f85ae91f-bc8c-4389-92b2-714b08047904"), new Guid("50146cf1-a579-4494-a57a-245b3e3a2782") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryGames_CategoryId",
                table: "CategoryGames",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CodeFrees_GameId",
                table: "CodeFrees",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_PublisherId",
                table: "Games",
                column: "PublisherId");

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
                name: "CodeFrees");

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
        }
    }
}
