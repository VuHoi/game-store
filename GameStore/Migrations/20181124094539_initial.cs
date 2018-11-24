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
                    Title = table.Column<string>(nullable: true)
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
                name: "ImagePublishers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UrlOnline = table.Column<string>(nullable: true),
                    UrlLocal = table.Column<string>(nullable: true),
                    PublisherId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagePublishers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImagePublishers_Publishers_PublisherId",
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
                name: "ImageUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UrlOnline = table.Column<string>(nullable: true),
                    UrlLocal = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageUsers_User_UserId",
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
                name: "ImageGames",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UrlOnline = table.Column<string>(nullable: true),
                    UrlLocal = table.Column<string>(nullable: true),
                    GameId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageGames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageGames_Games_GameId",
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
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("e0723af0-1015-4ce6-8569-8130c04ec7c5"), "FPS" },
                    { new Guid("d4f9ec3c-6f43-48ee-8a58-eafb0550d2cd"), "Action" },
                    { new Guid("993b3a4f-1d10-4e07-b099-182b3b0ff6ff"), "Adventure" },
                    { new Guid("dcea620a-f57c-42b0-9aaf-9fad293d435e"), "Puzzle" },
                    { new Guid("58d2f558-efff-4f53-a626-d958ad8f3416"), "Open world" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Money", "Name", "Reliability" },
                values: new object[,]
                {
                    { new Guid("5fd6ec77-2c71-4c21-86c6-c811b9795851"), 0, "King", 0 },
                    { new Guid("c70da539-9dee-4ed6-95d0-97cfa350121a"), 0, "Rovio Entertainment Corporation", 0 },
                    { new Guid("cb9ee8bc-8763-41bf-b4fa-c38dc21f0e48"), 0, "Outfit7 Limited", 0 },
                    { new Guid("dd8ca2c1-849b-4066-b8b4-e6272ac32d78"), 0, "AMANOTES", 0 },
                    { new Guid("d4a4742a-af87-44af-b615-509c40fe60c3"), 0, "Gameloft", 0 },
                    { new Guid("e6b7f996-4398-4791-8e3f-5722946e53e1"), 0, "Mobigame S.A.R.L.", 0 },
                    { new Guid("eb8f3913-d3c7-40d9-8e21-75f2389430ef"), 0, "Imangi Studios", 0 },
                    { new Guid("377cb4c7-a3d1-4956-bad5-186297537919"), 0, "NEKKI", 0 },
                    { new Guid("c15ff165-86b8-44d0-9feb-ee3f0bf6261e"), 0, "Kiloo", 0 },
                    { new Guid("543655cd-d8d1-4964-8212-1415808ecad7"), 0, "ZeptoLab", 0 },
                    { new Guid("b1c36243-fd85-45e9-a4f4-5d1cd7d05c7e"), 0, "ELECTRONIC ARTS", 0 },
                    { new Guid("b06b5b79-ce24-461f-9fc0-64ca09f30093"), 0, "J-PARK", 0 }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("93a84ba2-1d34-4936-9441-807618c7d506"), "User", "Limited Permission", "User", "User" },
                    { new Guid("3a7a25f0-38bc-40a1-815f-adfcf802ec45"), "Admin", "Full Permission", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Hobbies", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1c0a0c5e-9be2-4786-8d1b-da4b467bbf40"), 0, "8bfccb94-1bf3-4d02-b8f2-711cfb236921", "duykkxm92@gmail.com", false, "Nguyen Ngoc Duy", "Hobbies", false, null, null, null, "duykkxm92", "01638789455", false, null, false, "duykkxm92" },
                    { new Guid("efe214a4-0434-4a04-bc46-c9b1dab6bf3c"), 0, "526d68a4-569c-471c-8ac2-16dca1efb282", "Email1@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509228098523", false, null, false, "UserName1" },
                    { new Guid("0234b247-375e-4aff-a530-94d4bc0640bc"), 0, "0a7d94f8-fb02-4032-b7f6-40bec0b9d390", "Email2@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098559238098523", false, null, false, "UserName2" },
                    { new Guid("5372e35e-20e0-4264-aba6-75b0904da6e8"), 0, "66dd757a-611e-4462-9b74-6685c5b511f4", "Email3@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098609238098523", false, null, false, "UserName3" },
                    { new Guid("be92f81b-574d-453f-ac36-924c09813691"), 0, "f1c3db50-4efe-47a2-900e-63b505399b7f", "Email4@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509738098523", false, null, false, "UserName4" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Content", "Name", "Price", "PublisherId", "Rating", "ReleaseDate", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("7faf0a73-29de-4027-b8f4-4f5543775bb9"), "DASH as fast as you can! DODGE the oncoming trains!Help Jake, Tricky & Fresh escape from the grumpy Inspector and his dog.  Grind trains with your cool crew!  Colorful and vivid HD graphics!  Hoverboard Surfing!  Paint powered jetpack!  Lightning fast swipe acrobatics!  Challenge and help your friends!", "Subway Surfers", 0f, new Guid("c15ff165-86b8-44d0-9feb-ee3f0bf6261e"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("c5fe442b-748d-4745-87ec-9833afd09e2c"), "The sequel to the famous Facebook smash hit with 40 million users Shadow Fight 2 is a nail-biting mix of RPG and classical Fighting. This game lets you equip your character with countless lethal weapons and rare armor sets, and features dozens of lifelike-animated Martial Arts techniques! Crush your enemies, humiliate demon bosses, and be the one to close the Gate of Shadows. Do you have what it takes to kick, punch, jump, and slash your way to victory? There’s only one way to find out", "Shadow Fight 2", 100000f, new Guid("377cb4c7-a3d1-4956-bad5-186297537919"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("a20fb921-0ba4-4784-a442-63cc4a83b4b2"), "Strap on your running shoes and join the award-winning, fan-favorite runner, Minion Rush. Enter Gru's Lair, discover its many mysterious rooms, and take on manic missions around the world. Along the way, your Minions will jump, roll and dodge obstacles while unlocking a collection of cool Minion costumes.", "Minion Rush: Despicable Me Official Game", 100000f, new Guid("c70da539-9dee-4ed6-95d0-97cfa350121a"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("88d77c52-bb17-49d0-b72f-1ff65cda0282"), "Use the unique powers of the Angry Birds to destroy the greedy pigs' defenses! The survival of the Angry Birds is at stake. Dish out revenge on the greedy pigs who stole their eggs. Use the unique powers of each bird to destroy the pigs’ defenses. Angry Birds features challenging physics-based gameplay and hours of replay value. Each level requires logic, skill and force to solve.", "Angry Birds Classic", 100000f, new Guid("c70da539-9dee-4ed6-95d0-97cfa350121a"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("16cc680c-0c1f-4c07-a954-c07ac107adf0"), "Is it a baby? Is it a puppy? No! It’s Talking Tom! The cutest kitten, the coolest cat, and the biggest superstar in the world! My Talking Tom is the best virtual pet game for children, and big kids of all ages.That’s right - even grandma and grandpa can join the fun!", "My Talking Tom", 100000f, new Guid("cb9ee8bc-8763-41bf-b4fa-c38dc21f0e48"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("c6f05781-e23f-4ca0-8d36-0a401147f42c"), "Dragon Mania Legends is for anyone that wants their very own pet dragon, which is obviously everyone… – Gamezebo", "Dragon Mania Legends", 100000f, new Guid("dd8ca2c1-849b-4066-b8b4-e6272ac32d78"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("f3c8b8f1-247a-4b2d-974f-9b3178d46970"), "Play the award-winning hit action-strategy adventure where you meet, greet, and defeat legions of hilarious zombies from the dawn of time, to the end of days. Amass an army of amazing plants, supercharge them with Plant Food, and devise the ultimate plan to protect your brain.", "Plants vs Zombies 2 Free", 0f, new Guid("dd8ca2c1-849b-4066-b8b4-e6272ac32d78"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("f5ffa485-676b-43b3-a8a6-311d12adbcff"), "Magic Tiles 3 ™ is one of the most loved piano games among thousands of free games in 2018 which has more than 80 million players around the world.", "Magic Tiles 3", 100000f, new Guid("dd8ca2c1-849b-4066-b8b4-e6272ac32d78"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("d7834acd-25c8-4e02-9a1d-5f3c208ae443"), "Follow the adventure of Om Nom in the first part of the legendary Cut the Rope logic puzzles series. Get it now for free and start playing with millions of players around the world!", "Cut the Rope FULL FREE", 0f, new Guid("5fd6ec77-2c71-4c21-86c6-c811b9795851"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("4efd6013-e366-4a37-adf3-8f6fada7d49f"), "A strange group of enemies appeared in the city and have been using innocent people as experimental tools. Lots of people have turned into Zombie so that Hero and his friends should save the people and remove the enemies.", "Anger of stick 5 : zombie", 100000f, new Guid("5fd6ec77-2c71-4c21-86c6-c811b9795851"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("d57a8162-5ab1-4205-91a0-d533b0b3a323"), "Start playing Candy Crush Saga today – loved by millions of players around the world. With over a trillion levels played, this sweet match 3 puzzle game is one of the most popular mobile games of all time!", "Candy Crush Saga", 100000f, new Guid("5fd6ec77-2c71-4c21-86c6-c811b9795851"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("ce83a880-8a23-4281-a20c-89018ce1eca1"), "The time to take action and strike back is now! We’re calling for the best sniper in the world to take aim at evil, wherever it hides.There’s no room for remorse, so shoot to kill…", "Sniper Fury: Top shooting game - FPS", 100000f, new Guid("5fd6ec77-2c71-4c21-86c6-c811b9795851"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("5eaf0ab3-34ca-4b30-b05c-8f133bbe1be1"), "5 lớp nhân vật tùy biến có thể lên cấp cả trong chơi đơn lẫn chơi mạng. Kiếm và dùng Điểm Kĩ năng để kích hoạt kĩ năng riêng của từng lớp nhân vật. Đấu Đội trong các trận Chơi mạng. Bảng xếp hạng Cá nhân và Đội. Nói chuyện với người chơi khác trong mục Chat Toàn cầu và Đội. Nhiệm vụ tiết tấu nhanh với nhiều thử thách khác nhau từ Tokyo đến Venice.", "Modern Combat 5: eSports FPS", 100000f, new Guid("b1c36243-fd85-45e9-a4f4-5d1cd7d05c7e"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("30efa91e-7141-4687-8fa1-01751122aeba"), "Help Swampy by guiding water to his broken shower. Each level is a challenging physics-based puzzle with amazing life-like mechanics. Cut through dirt and guide fresh water, dirty water, toxic water, steam, and ooze through increasingly challenging scenarios! Every drop count", "Where's My Water? Free", 0f, new Guid("c15ff165-86b8-44d0-9feb-ee3f0bf6261e"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("5fb2ad07-3459-4bd2-9660-240aaadee9a9"), "The zombies are revolting ! Attack the city with a horde of zombies, change pedestrians into zombies and create the largest horde. Eat your friends, and challenge them to a crazy race by destroying everything in your path. Zombie Tsunami has proudly exceeded 200 million players around the world.", "Zombie Tsunami", 100000f, new Guid("e6b7f996-4398-4791-8e3f-5722946e53e1"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("85f06818-4759-48dc-be44-eb1d55f408bc"), "N.O.V.A. Legacy brings you the best 3D sci-fi FPS experience based on the epic first episode of N.O.V.A., which received critical acclaim -- all in a compact version of the shooter. Kal Wardin, our hero, is a veteran N.O.V.A. marine, summoned once again to don his Mobile Armored Suit and strike against the enemies of the Colonial Administration forces. Helped by Yelena, his personal AI Agent, Kal must protect humanity's destiny by engaging in combat against alien invaders while uncovering the mystery behind their sudden assault.", "N.O.V.A. Legacy", 100000f, new Guid("e6b7f996-4398-4791-8e3f-5722946e53e1"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("f7364ddb-9c12-4f61-9709-2021325198d6"), "With over a zillion downloads, Temple Run redefined mobile gaming. Now get more of the exhilarating running, jumping, turning and sliding you love in Temple Run 2! Navigate perilous cliffs, zip lines, mines and forests as you try to escape with the cursed idol. How far can you run ? !", "Temple Run 2", 50000f, new Guid("eb8f3913-d3c7-40d9-8e21-75f2389430ef"), 4.3f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("97e475fe-30a0-47f6-875b-57fed06177f5"), "In Asphalt 8, you’ll race in some of the hottest, most high-performance dream machines ever created, from cars to bikes, as you take them on a global tour of speed. From the blazing Nevada Desert to the tight turns of Tokyo, you’ll find a world of challenge, excitement and arcade fun on your road to the top!", "Asphalt 8: Airborne", 100000f, new Guid("e6b7f996-4398-4791-8e3f-5722946e53e1"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("ee5a11ea-318f-4be3-a1b6-fbd8aa52ae96"), "Get ready to soil your plants as a mob of fun-loving zombies is about to invade your home. Use your arsenal of 49 zombie-zapping plants — peashooters, wall-nuts, cherry bombs and more — to mulchify 26 types of zombies before they break down your door.", "Plants vs. Zombies FREE", 100000f, new Guid("b1c36243-fd85-45e9-a4f4-5d1cd7d05c7e"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" }
                });

            migrationBuilder.InsertData(
                table: "ImagePublishers",
                columns: new[] { "Id", "PublisherId", "UrlLocal", "UrlOnline" },
                values: new object[,]
                {
                    { new Guid("a13348e4-e93c-4b05-99fd-489e68dc6d7a"), new Guid("e6b7f996-4398-4791-8e3f-5722946e53e1"), null, "http://4.bp.blogspot.com/-jAUhK8EAuiA/VmnLpfRWLHI/AAAAAAAAAkI/Hp8mTQXl8xM/s1600/Zombie%2BTsunami%2B-%2BLogo%2BMobigame.jpg" },
                    { new Guid("9f78a9ff-6816-44bc-a369-b311772c8588"), new Guid("d4a4742a-af87-44af-b615-509c40fe60c3"), null, "https://pbs.twimg.com/profile_images/1026435341312512001/u3D328AP_400x400.jpg" },
                    { new Guid("fa1a8cdd-c5c3-4b46-930d-6dcf7903eb40"), new Guid("dd8ca2c1-849b-4066-b8b4-e6272ac32d78"), null, "https://employer.jobsgo.vn/image.php?src=1187_logo_1187_20170209115933_1779.jpg&w=300&h=300" },
                    { new Guid("ef384f18-163e-4590-94c0-7cf48d13ea30"), new Guid("b1c36243-fd85-45e9-a4f4-5d1cd7d05c7e"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRbShsNR-wcUaPKBv2NxLSeE6arTMAMGZNs5L219VYdIxUapVJc" },
                    { new Guid("41be7e88-6b04-44f1-8945-155dff4331b2"), new Guid("cb9ee8bc-8763-41bf-b4fa-c38dc21f0e48"), null, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/O7_logo-red_cmyk.jpg/1200px-O7_logo-red_cmyk.jpg" },
                    { new Guid("5cad33b7-1ece-485d-a9e2-dc825f417ea8"), new Guid("eb8f3913-d3c7-40d9-8e21-75f2389430ef"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS3aHsnIsbz6CxKRg5tmpq73iNWV6J65niLvsEs9tKf9feje5iv" },
                    { new Guid("fae4d252-5e9c-4cc4-a123-8eff801fbfb4"), new Guid("c15ff165-86b8-44d0-9feb-ee3f0bf6261e"), null, "https://www.kiloo.com/wp-content/uploads/2017/03/sharelogo-2.png" },
                    { new Guid("0e7470f5-2f9a-4297-b8be-c035f97b703c"), new Guid("c70da539-9dee-4ed6-95d0-97cfa350121a"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdbIPf6EeERMGnyQoYkE4xUMuaU22OEtWLEfHWjAw6vxzGJ5oq" },
                    { new Guid("6fbfae1a-c510-4383-aa51-9ea9b671aa5c"), new Guid("377cb4c7-a3d1-4956-bad5-186297537919"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQkyOmWOFhXD1lRsMIHkAJrLIvjwmImH1GBwlmqb3I5ysGUNY0-" },
                    { new Guid("8da5ebcc-3713-41f6-86f6-a9a42cb6d384"), new Guid("b06b5b79-ce24-461f-9fc0-64ca09f30093"), null, "https://upload.wikimedia.org/wikipedia/vi/thumb/2/2a/ZeptoLab.png/200px-ZeptoLab.png" },
                    { new Guid("f4b1d78a-9c19-4f3c-aa80-449603565b67"), new Guid("5fd6ec77-2c71-4c21-86c6-c811b9795851"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSE0L-3DI9ruta232UcPOIlvnE3I3xV-8l1u_C3Grzx6tmXrDzs" },
                    { new Guid("9cfeaae1-4cbf-4fdb-952b-22fea2b5a6a7"), new Guid("543655cd-d8d1-4964-8212-1415808ecad7"), null, "https://upload.wikimedia.org/wikipedia/vi/thumb/2/2a/ZeptoLab.png/200px-ZeptoLab.png" }
                });

            migrationBuilder.InsertData(
                table: "CategoryGames",
                columns: new[] { "GameId", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("7faf0a73-29de-4027-b8f4-4f5543775bb9"), new Guid("e0723af0-1015-4ce6-8569-8130c04ec7c5") },
                    { new Guid("f7364ddb-9c12-4f61-9709-2021325198d6"), new Guid("993b3a4f-1d10-4e07-b099-182b3b0ff6ff") },
                    { new Guid("d57a8162-5ab1-4205-91a0-d533b0b3a323"), new Guid("58d2f558-efff-4f53-a626-d958ad8f3416") },
                    { new Guid("ee5a11ea-318f-4be3-a1b6-fbd8aa52ae96"), new Guid("dcea620a-f57c-42b0-9aaf-9fad293d435e") },
                    { new Guid("5fb2ad07-3459-4bd2-9660-240aaadee9a9"), new Guid("d4f9ec3c-6f43-48ee-8a58-eafb0550d2cd") }
                });

            migrationBuilder.InsertData(
                table: "FreeCodes",
                columns: new[] { "Id", "Code", "GameId" },
                values: new object[,]
                {
                    { new Guid("59368904-7561-4ca8-b2ec-bbf63697a666"), "0a49060a-8d61-4d7a-b0cd-910689f11851", new Guid("f7364ddb-9c12-4f61-9709-2021325198d6") },
                    { new Guid("572a625e-0e86-44ae-bc72-df001234a697"), "7efd27e5-1cb8-4a39-ad2e-6188b5a66df5", new Guid("ee5a11ea-318f-4be3-a1b6-fbd8aa52ae96") },
                    { new Guid("46a9fc8e-0229-44c5-8548-941c5fa52baf"), "bf25207f-04de-44a4-9f95-1a95ebf4f7e8", new Guid("d57a8162-5ab1-4205-91a0-d533b0b3a323") },
                    { new Guid("d4b01f72-c2c9-4164-bb09-32fae0af68f0"), "e944b521-ca06-45a3-9aa7-3b120e2f33b8", new Guid("5fb2ad07-3459-4bd2-9660-240aaadee9a9") },
                    { new Guid("a5752964-32c7-4ca6-8ddb-9c2e9ec61985"), "1a430394-d9ae-42e5-b8e9-054423e24eba", new Guid("7faf0a73-29de-4027-b8f4-4f5543775bb9") }
                });

            migrationBuilder.InsertData(
                table: "ImageGames",
                columns: new[] { "Id", "GameId", "UrlLocal", "UrlOnline" },
                values: new object[,]
                {
                    { new Guid("e5d88bf5-94a9-449b-a7a8-ce59bf77ff30"), new Guid("d7834acd-25c8-4e02-9a1d-5f3c208ae443"), "", "https://lh3.googleusercontent.com/Qnm85mIcd32-R8IxmDXM1MPgCfpM2-duddE7P_iS55P0xFO6ZM9jo9dt6PThjWhZvw=w720-h310" },
                    { new Guid("958a7544-7811-4531-95bb-e5616b977d80"), new Guid("d57a8162-5ab1-4205-91a0-d533b0b3a323"), "", "https://lh3.googleusercontent.com/ucBNG7Vj8Lqo8b14PUMyzB8h7f2YcZ9oKB6BuFaJTgCj4jEv3Zo1jFPg-FjdONrw8c7b=w720-h310" },
                    { new Guid("5dcd091e-2d4d-48dc-94c6-a4596e515457"), new Guid("f5ffa485-676b-43b3-a8a6-311d12adbcff"), "", "https://lh3.googleusercontent.com/Z_KPg-BqbZVMMLlH689YEwzPefUXW0l_7MfPS8-KUzDV4-y-VeSfnswbSXakPJfoJw8=w720-h310" },
                    { new Guid("cb8ae217-4cbe-49a4-b5d3-ec86b85f1ac9"), new Guid("f5ffa485-676b-43b3-a8a6-311d12adbcff"), "", "https://lh3.googleusercontent.com/uJK2kFV81mdNGWE9nDO__wadnVhC8afhQourrne9WhOy0ip1UjlsElsw9xd0BV3NCG8=w720-h310" },
                    { new Guid("6da4cde4-ea2b-4692-a039-650244bc38d8"), new Guid("ce83a880-8a23-4281-a20c-89018ce1eca1"), "", "https://lh3.googleusercontent.com/5W6OOrho0AFit_nm98QqpCsu52uHc-kw7RQPK4_PUdGEi6DjrmfZdPJIGYl2u_3Ibw=w720-h310" },
                    { new Guid("e2a6d974-1b11-4540-85de-05effd0ae2a8"), new Guid("ce83a880-8a23-4281-a20c-89018ce1eca1"), "", "https://lh3.googleusercontent.com/5W6OOrho0AFit_nm98QqpCsu52uHc-kw7RQPK4_PUdGEi6DjrmfZdPJIGYl2u_3Ibw=w720-h310" },
                    { new Guid("61ef56ba-fa70-4371-a41e-dd249b1a9d75"), new Guid("ce83a880-8a23-4281-a20c-89018ce1eca1"), "", "https://lh3.googleusercontent.com/qSl0aQ-tQiBC_Ut0MC3n-I3HTgQsDQ52XUq_cnfu5rq9kyDSBs2vneGXZZ-PhVv8yb22=w720-h310" },
                    { new Guid("574fb1a2-eeba-48f4-b618-6342db07e213"), new Guid("ce83a880-8a23-4281-a20c-89018ce1eca1"), "", "https://lh3.googleusercontent.com/nNjmESXQm2dJupXjwYn9RvD6nhS6_5bAthB6GrjrHCdaoiftDAKABIEOBJd3paXCYg=w720-h310" },
                    { new Guid("802ec216-1ae8-448c-90a9-d91784c042c3"), new Guid("d57a8162-5ab1-4205-91a0-d533b0b3a323"), "", "https://lh3.googleusercontent.com/EFv_aMUrdXQLXLesEfQAuFv9bNvQ5hwzYnuKZ1cr_OBDZU6cY6OZhIiDzfhx4eSuvtI=w720-h310" },
                    { new Guid("3b8863a8-3e31-4cc4-ae72-97ba73330e24"), new Guid("4efd6013-e366-4a37-adf3-8f6fada7d49f"), "", "https://lh3.googleusercontent.com/NdRmiugakoZ-CgyoqeEd7SC9xT_xFIfjY3LtjMifJ9_iKsUdzA5WgBrs2cgoAK3d_CNr=w720-h310" },
                    { new Guid("210f9970-8f2a-40f4-9e16-2a548bb3f0d2"), new Guid("d7834acd-25c8-4e02-9a1d-5f3c208ae443"), "", "https://lh3.googleusercontent.com/uFYADCilcHxlddeBXKAAu9HNzQG0Mx1VqwuwGQg3WiXBZAg41hooWQTAUilvZetyYhqy=w720-h310" },
                    { new Guid("c4fff7f6-5f77-4090-b799-6b395992a69c"), new Guid("4efd6013-e366-4a37-adf3-8f6fada7d49f"), "", "https://lh3.googleusercontent.com/A4POGA0IPwbcaSj5dba5zrn6tUlCiyvu4ppse912kWUzr084-qqgvCT0m-E99RPi228=w720-h310" },
                    { new Guid("a1c8fc65-abe4-484a-be6c-4cdf22da23a8"), new Guid("4efd6013-e366-4a37-adf3-8f6fada7d49f"), "", "https://lh3.googleusercontent.com/PeX7REevxeIec-hxFckCJP0xyg88TEzwPh4zz2Prv08d-0UsspP6wcoaBXYJqWzkuQ=w720-h310" },
                    { new Guid("0ce72a22-5f1d-41db-9169-fd25ca292628"), new Guid("d7834acd-25c8-4e02-9a1d-5f3c208ae443"), "", "https://lh3.googleusercontent.com/cOijr_HBBvrjn7t00qwPQiXJ2y53NMSMI4iF2YSH89RDlmpe_MbppoqJmXTyIUPCj7M=w720-h310" },
                    { new Guid("d15a30d9-b610-44ce-be13-2b6f9600c8f6"), new Guid("d7834acd-25c8-4e02-9a1d-5f3c208ae443"), "", "https://lh3.googleusercontent.com/Kri8NpWg8Nt5BmgNxbMCrW4vxk7LqzjpvibCYHb24_RJgS-l58n-gFR2f4RE_uGfuKI=w720-h310" },
                    { new Guid("58f679a2-dbf4-4671-a4fc-42603d7332fb"), new Guid("4efd6013-e366-4a37-adf3-8f6fada7d49f"), "", "https://lh3.googleusercontent.com/YL2_i-PixRM-qYfrZ6CpAqyNiXW_MrIx2KFyg2zZLkdjjosIK5qyPg1dfbyTAC-BdNg=w720-h310" },
                    { new Guid("633d0be9-b516-4aff-93a8-99da9c3c9102"), new Guid("f5ffa485-676b-43b3-a8a6-311d12adbcff"), "", "https://lh3.googleusercontent.com/CjrXpLQr5ixH5K9RjdL4CFLhmfgkVCJVAw0bhOuFuFI0v4IaQyt1zbXLVxKfGz2l246x=w720-h310" },
                    { new Guid("0a320af3-cca6-4351-88da-49c8756c5490"), new Guid("f3c8b8f1-247a-4b2d-974f-9b3178d46970"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("66b69afb-059d-442f-b6a9-8aafde7611d0"), new Guid("f3c8b8f1-247a-4b2d-974f-9b3178d46970"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("e8de7348-429f-4146-850d-2d62b333ae8d"), new Guid("c5fe442b-748d-4745-87ec-9833afd09e2c"), "", "https://lh3.googleusercontent.com/zRs9fTN-tL-p4yNL3ccFr1w3wUH-hqN0ShgwAnbzcnH2FidymdlixdDN-lpqF3xck4I=w720-h310" },
                    { new Guid("be8f18fd-1d62-4ac9-b0d1-fa72ee819e72"), new Guid("c5fe442b-748d-4745-87ec-9833afd09e2c"), "", "https://lh3.googleusercontent.com/o0i5z7sG2EArHccVaOCYU516s3PzflywGTbzf3ylRoZwOizKm-jH2AKwXweh2_77Tw=w720-h310" },
                    { new Guid("8dedc428-a9fc-4fb9-9374-62cc6c251ff0"), new Guid("a20fb921-0ba4-4784-a442-63cc4a83b4b2"), "", "https://lh3.googleusercontent.com/JMc16QhAhKFbnW2jusl-T6xu8xo31BDzv8h7APyDdU006PkYvtk3q3Ey76LU-G908M0=w720-h310" },
                    { new Guid("b1e96380-2704-4936-b983-7aafc8620288"), new Guid("a20fb921-0ba4-4784-a442-63cc4a83b4b2"), "", "https://lh3.googleusercontent.com/RdxHjaoI2WK-ku4--LmPMaZ6DkLVYt0q9IKiSrdqXnmMKlPo4hgZHf0VdN8Oee5pxg=w720-h310" },
                    { new Guid("25598630-0337-4d68-893e-988b16deaf73"), new Guid("a20fb921-0ba4-4784-a442-63cc4a83b4b2"), "", "https://lh3.googleusercontent.com/YYz6o1qMBxop37bvU1rfACXRv1AS-gNHOCjUW9lp6eLDV7BQAZ7zUIkG3PF597svP4gP=w720-h310" },
                    { new Guid("1c861201-730b-451e-99eb-c2697e53d86b"), new Guid("a20fb921-0ba4-4784-a442-63cc4a83b4b2"), "", "https://lh3.googleusercontent.com/Ziiu3YNdzaoJf7_rdy9tk7pbPiPlluFvA_JdU0FtzqlvZuLrfyuWNnfkRtMvxq4_lA=w720-h310" },
                    { new Guid("1e5817e6-0bb2-47e2-a4c3-6e949576079b"), new Guid("88d77c52-bb17-49d0-b72f-1ff65cda0282"), "", "https://lh3.googleusercontent.com/ClxJrJjyrjj5uaAxZvSaQcjjRfeCta4_otNRCsGJacfFptfTtamCUJpQ0hcQWOd8u-Q=w720-h310" },
                    { new Guid("5a463ef2-9212-4785-ac3c-3042a0aa0126"), new Guid("88d77c52-bb17-49d0-b72f-1ff65cda0282"), "", "https://lh3.googleusercontent.com/JIvkWPFnKbYeVV5h3AxjMgR9ogQ2a0vMQgCp5B3JP4dEXU4zIR40H8ROTg8WkPrjcEA=w720-h310" },
                    { new Guid("6ef4a1e7-c72d-4560-9238-925c7f9d2319"), new Guid("88d77c52-bb17-49d0-b72f-1ff65cda0282"), "", "https://lh3.googleusercontent.com/d0jf4r7KjWBCzi2GELWFSf6MaJIHepkJIN8JYT8g0tSIThiH_W6FhUnHjBN_fYdl3Q=w720-h310" },
                    { new Guid("73d8e847-f7b9-4268-b20b-9f4ab8933e6e"), new Guid("f5ffa485-676b-43b3-a8a6-311d12adbcff"), "", "https://lh3.googleusercontent.com/HteHDUkzuMjCEHM1B-3jvLqlbBYtJZFWiHm-vf47YcE7QiInhXn2O-LkYPxvzPnPGA=w720-h310" },
                    { new Guid("832a9e3a-7af5-4968-a324-540eee644b19"), new Guid("88d77c52-bb17-49d0-b72f-1ff65cda0282"), "", "https://lh3.googleusercontent.com/UbTWxlQujVdxOaYqy_FmC4LRBlm_wSUgQe0wIM0BSXeGUZ0Vzle9OTWNNs4wk8nOKI4=w720-h310" },
                    { new Guid("d77dfb10-cf6d-4dd1-a7f6-259b580744df"), new Guid("16cc680c-0c1f-4c07-a954-c07ac107adf0"), "", "https://lh3.googleusercontent.com/jCNaOtE_9-Zcs9r5MFtGzaxO8xNz3UYEcB3XdPe1oLO3X6PH-hYEspWnR26lUZef_5A=w720-h310" },
                    { new Guid("ab9636e6-815b-46b5-825d-ec64979d1ef4"), new Guid("16cc680c-0c1f-4c07-a954-c07ac107adf0"), "", "https://lh3.googleusercontent.com/d6CY2BSvBXFLK8J3WqJEdDr53_OZ43Aijr43CjG1QKUfHXt4E_zDNBZWoMqkxONzOQ=w720-h310" },
                    { new Guid("e5c1c0b8-7a71-4d8e-9f98-a51b9665297d"), new Guid("16cc680c-0c1f-4c07-a954-c07ac107adf0"), "", "https://lh3.googleusercontent.com/L615QU2G2qxv68di7WqB4V40mDsOgko4iKmz-NB6SzwLejM8x4i2CbAqgkIxBqZ3A9M=w720-h310" },
                    { new Guid("d0f375f2-3eae-46d1-b0d4-482dacaa0a86"), new Guid("c6f05781-e23f-4ca0-8d36-0a401147f42c"), "", "https://lh3.googleusercontent.com/9lQV-3IWYXkSndN4GsVQTflvUCSKPMj-uSuH9tEd8FlHuBOslA52Q-Z7wEEKmhwuxJE=w720-h310" },
                    { new Guid("6d64eb67-e230-4c26-9e56-6ff6a24f871b"), new Guid("c6f05781-e23f-4ca0-8d36-0a401147f42c"), "", "https://lh3.googleusercontent.com/3HUpkFFcnCkLbgUosodwIrfzzq3VkebxVQkjfa_uDhapJyrz0ATxq6wRyYpyxKauyg=w720-h310" },
                    { new Guid("9c4e5d13-ecb3-4d8f-b42e-59e811a8cea0"), new Guid("c6f05781-e23f-4ca0-8d36-0a401147f42c"), "", "https://lh3.googleusercontent.com/JJNpXkj5HNkscW_bmZ1yGu-GuakL4Q4zRwOPmACFaqbIT5C2HMaI4LwhjGNiIrup_Ew4=w720-h310" },
                    { new Guid("6be808e1-9b35-4f15-b65a-3f89054c860c"), new Guid("c6f05781-e23f-4ca0-8d36-0a401147f42c"), "", "https://lh3.googleusercontent.com/aU5RuCIDy7JzNtp5ib2huaa1t33TVY_zdsES_ooMWSwY6K1JnHG0HC9RK0OgVuXqs9U=w720-h310" },
                    { new Guid("e68d77d5-5cdf-48e9-823b-a40fb7992c56"), new Guid("f3c8b8f1-247a-4b2d-974f-9b3178d46970"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("6ff29b47-e4fd-460a-9ece-c5d1bcd0226c"), new Guid("f3c8b8f1-247a-4b2d-974f-9b3178d46970"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("ee803862-a784-4af2-bd41-4e4436696c77"), new Guid("16cc680c-0c1f-4c07-a954-c07ac107adf0"), "", "https://lh3.googleusercontent.com/sCw3rT7aK1z589o_MBBn1JzVd7fYC1-fWkYV2Tz4eDfCDTi49dS9tOFBLqBrd_XwQCc=w720-h310" },
                    { new Guid("7500253a-fba8-45ff-9c3a-1be717f02dfa"), new Guid("d57a8162-5ab1-4205-91a0-d533b0b3a323"), "", "https://lh3.googleusercontent.com/xaL3b80wmBVOrpH-q_DX8F5kKsASHH8Fllf3u65TsS0zs9_y0J4DWKJj5T9QVAWuT3Rn=w720-h310" },
                    { new Guid("ffb5a903-b83f-4928-b862-de87451ebffb"), new Guid("5eaf0ab3-34ca-4b30-b05c-8f133bbe1be1"), "", "https://lh3.googleusercontent.com/Ibj-Kt-6Pc1IBDVj0yWf1sNjSpdGpRlapbTbjc5MuitmDkoKVMP45GF0LBlg6pnIbYE=w720-h310" },
                    { new Guid("4326af85-142f-4b83-b329-ea4854bc6428"), new Guid("c5fe442b-748d-4745-87ec-9833afd09e2c"), "", "https://lh3.googleusercontent.com/AinG9y8hyEb_p2B6Rg8-iOVjYR7EcsGDmv_rThdnfzgkBjbukLIT4mWFOg5ObAO4RMq0=w720-h310" },
                    { new Guid("5b399bf1-be21-4442-b7db-fc89e0ea80e2"), new Guid("97e475fe-30a0-47f6-875b-57fed06177f5"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("2fa53469-b275-4868-8a5c-026d459ac44d"), new Guid("97e475fe-30a0-47f6-875b-57fed06177f5"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("28524576-fd23-44da-8362-eff22b7124f2"), new Guid("97e475fe-30a0-47f6-875b-57fed06177f5"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("5568e77d-ee40-4d50-aed9-9f2c0ba25e24"), new Guid("97e475fe-30a0-47f6-875b-57fed06177f5"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("09ad60e0-9efb-4e2d-94f6-f81723a83726"), new Guid("5fb2ad07-3459-4bd2-9660-240aaadee9a9"), "", "https://lh3.googleusercontent.com/UY9fte3alDnv-cZ94Jx27Lf4g9FUT2395jhXPScEllshpdCO4zfnuWrTNtO1FVRt3w=w720-h310" },
                    { new Guid("cfd29400-6393-4a8a-9169-252e30ae27b7"), new Guid("5fb2ad07-3459-4bd2-9660-240aaadee9a9"), "", "https://lh3.googleusercontent.com/-BUT6NCVxZsPPjsUW8zdrVk4XLMRuE_oWSTwaXrAPYZbBsMKBfqXxOVI7OowXxoLwa8=w720-h310" },
                    { new Guid("9daaf758-761a-4b82-b343-57f7290c8b20"), new Guid("5fb2ad07-3459-4bd2-9660-240aaadee9a9"), "", "https://lh3.googleusercontent.com/MwNuIIzmxxJgM8JeNi2aBhpE-kNnXBGOVPRb_gZoRE-gel5q9ZP7mrQfTT_9xzV8dz4=w720-h310" },
                    { new Guid("56ec5b29-d5c2-4af1-8748-54f9b79395ec"), new Guid("d57a8162-5ab1-4205-91a0-d533b0b3a323"), "", "https://lh3.googleusercontent.com/gFZCgWFd8-oR8zu2ApqRWk6dgwIkDM8jex4MxbA-MdiYgfpHJlkAcPBCZX5czXgddA=w720-h310" },
                    { new Guid("a949b91b-e3c1-4aad-9ae5-70f6f1000078"), new Guid("5fb2ad07-3459-4bd2-9660-240aaadee9a9"), "", "https://lh3.googleusercontent.com/mfGdhejubeU1m1Pkj2vpWMLTlLMhnQz0f2Z8M79g6g0thY9cDyHggntmd_A7ckZPGVM=w720-h310" },
                    { new Guid("eb5dd408-022a-4f23-9983-587de1593d1d"), new Guid("30efa91e-7141-4687-8fa1-01751122aeba"), "", "https://lh3.ggpht.com/y7On3vVZhFWycuekTPLwARYJ3MwQyODIzKHRt4ofyeS_gmXRDF271NsFDfu_lLhlX2Rj=w720-h310" },
                    { new Guid("23450c6d-8391-4e6e-82c3-4b66897e14bc"), new Guid("30efa91e-7141-4687-8fa1-01751122aeba"), "", "https://lh3.ggpht.com/y7On3vVZhFWycuekTPLwARYJ3MwQyODIzKHRt4ofyeS_gmXRDF271NsFDfu_lLhlX2Rj=w720-h310" },
                    { new Guid("eba8286e-8e99-4c85-a0a2-55a1ec0aa128"), new Guid("30efa91e-7141-4687-8fa1-01751122aeba"), "", "https://lh3.ggpht.com/y7On3vVZhFWycuekTPLwARYJ3MwQyODIzKHRt4ofyeS_gmXRDF271NsFDfu_lLhlX2Rj=w720-h310" },
                    { new Guid("c2d5e433-655b-4fdc-8362-2b50fe228a05"), new Guid("7faf0a73-29de-4027-b8f4-4f5543775bb9"), "", "https://lh3.googleusercontent.com/h4JQOfS4vmim_WhTHeC3RGxtY8eoFG0fgtgsWWk6VvVSrjnjtlgSFzR6sW0hzbncWA=w720-h310" },
                    { new Guid("a4dac0b3-9053-454e-a4d0-4b9c0fa71ac0"), new Guid("7faf0a73-29de-4027-b8f4-4f5543775bb9"), "", "https://lh3.googleusercontent.com/oMcH_a4lXShvowzyaiQpE0_MhYWZvdN9RkaYLtkdnw_rlDR_uHbHj9Eu2zbrvyOAXHQ=w720-h310" },
                    { new Guid("c7f07529-e642-4e3f-9b98-0d4b8ca4659b"), new Guid("7faf0a73-29de-4027-b8f4-4f5543775bb9"), "", "https://lh3.googleusercontent.com/Ia1psbcXgeCV9FBZk1b08QnxC-uSHCgJ112VeJZB19_F2Q-m_w3Z7P_OjFStnYM3LaCC=w720-h310" },
                    { new Guid("716a10ea-5f6e-4dc2-9bf1-9461e89cd13b"), new Guid("7faf0a73-29de-4027-b8f4-4f5543775bb9"), "", "https://lh3.googleusercontent.com/vInYRcyjzVjBFfY4HIGLLf-tSLK9S55HjUbmQuxmrbpVpItV3AfyuxVMFGASoDdMHc4=w720-h310" },
                    { new Guid("fede24eb-c41f-4b9e-84eb-a7fe7a81d21f"), new Guid("30efa91e-7141-4687-8fa1-01751122aeba"), "", "https://lh3.ggpht.com/y7On3vVZhFWycuekTPLwARYJ3MwQyODIzKHRt4ofyeS_gmXRDF271NsFDfu_lLhlX2Rj=w720-h310" },
                    { new Guid("0cf5d8bd-f351-43f1-912b-fc0e130cae7a"), new Guid("85f06818-4759-48dc-be44-eb1d55f408bc"), "", "https://lh3.googleusercontent.com/FMgP9XZNML3lieBG9KDgiJGnT2WlmHMG5lFGcAl0rk93GtGFjf9X2J6vxcCCElNPJDw=w720-h310" },
                    { new Guid("7e7d116b-d18f-4af1-9332-38d8c0a2d8e0"), new Guid("85f06818-4759-48dc-be44-eb1d55f408bc"), "", "https://lh3.googleusercontent.com/DQppPRLU04SzwExhZTIKsYL1y3iZXzRsZbTBrmHJqJO1aTCsApHGdYxTKt3dvkN7ctRb=w720-h310" },
                    { new Guid("000dff08-741f-4c7d-98ff-7603a2003d65"), new Guid("85f06818-4759-48dc-be44-eb1d55f408bc"), "", "https://lh3.googleusercontent.com/-oRMqwODzaru2JCxLf3JtHVZXtpYfQ8Qo0IQRbRsZtssH6dUGr51WMfH0j3eMrfO5w=w720-h310" },
                    { new Guid("effd16d5-6727-4f0f-89b8-00bf8315fa34"), new Guid("5eaf0ab3-34ca-4b30-b05c-8f133bbe1be1"), "", "https://lh3.googleusercontent.com/W_3i_ZHnSjan-N8egYQy9sQw87CppDDda9ITzTIQyTFHZpO2VJlhCzP_BORM3Hd-CDw=w720-h310" },
                    { new Guid("cf4e11b6-d21e-4cca-95a1-52f01e41bc7e"), new Guid("5eaf0ab3-34ca-4b30-b05c-8f133bbe1be1"), "", "https://lh3.googleusercontent.com/RhBTJ2IEOhtPEbOpmMTxfMC9iU06JihtylD-lQxbTrIPfT2U-B0YLAjGELbj2Ppk1w8=w720-h310" },
                    { new Guid("1dc6e495-9627-4228-9e6f-ef80a7ea733f"), new Guid("5eaf0ab3-34ca-4b30-b05c-8f133bbe1be1"), "", "https://lh3.googleusercontent.com/nlXezemMS359X8dy6MxUJMgumyw6abz15NX0CjtnT8V57vni_uuS3saDllIMeyfQ6e-6=w720-h310" },
                    { new Guid("0db9a07f-109f-4119-b705-b131ff4fe86e"), new Guid("ee5a11ea-318f-4be3-a1b6-fbd8aa52ae96"), "", "https://lh3.googleusercontent.com/aosNkyZihAba_VF_HRKOUMGFuK5SxNcZMMvYIAXufiG8znXvrxJ_7jMgmP2E01CapoQ=w720-h310" },
                    { new Guid("c1bd0f95-eacd-45cb-893a-0ca771ec2455"), new Guid("85f06818-4759-48dc-be44-eb1d55f408bc"), "", "https://lh3.googleusercontent.com/wzk-BPRwz5Lrh2YZ66uEJb8JjXkFE8oVm4RpZVTmWsCcx1e1nxP3XBhqr2q9Iff7Xica=w720-h310" },
                    { new Guid("c378a445-b082-4960-8f08-a31f7b62c3b5"), new Guid("ee5a11ea-318f-4be3-a1b6-fbd8aa52ae96"), "", "https://lh3.googleusercontent.com/Km7Il6ij6xZBtWJPSpEacmz8dC2C9WACUuf37VdjIYaXWaPaC6WWWmx3T8aaNgNkJaBx=w720-h310" },
                    { new Guid("d061d1a4-f835-4ba6-bd20-c56fa413b154"), new Guid("ee5a11ea-318f-4be3-a1b6-fbd8aa52ae96"), "", "https://lh3.googleusercontent.com/tk_p7dIHQBEBeYiVkFaPcU_5bd3fOhE8HerKp4Ei0cTyxVoVDdd_QD0SLPJeJrSm4c4=w720-h310" },
                    { new Guid("57fe5c9b-c551-4072-8f3d-c1df7e522345"), new Guid("ee5a11ea-318f-4be3-a1b6-fbd8aa52ae96"), "", "https://lh3.googleusercontent.com/Zsth8maheotaUA0he3vGtWmm11dWsEsLlffOsvzGX65Sp4nXNAuKSx-Z96f8as3twQ4=w720-h310" },
                    { new Guid("d1edbc07-d297-42b1-ac23-a93e5bf7d212"), new Guid("f7364ddb-9c12-4f61-9709-2021325198d6"), "", "https://lh3.ggpht.com/GqnDETqoUP17xJg0cQ3pyEHsgO-KLjx-MbJ0Mcwg4Lvd2PnEO-JARZhYtfd8AYwjEew=w720-h310" },
                    { new Guid("7c7b9000-b8e4-422f-9071-12851de39d6d"), new Guid("f7364ddb-9c12-4f61-9709-2021325198d6"), "", "https://lh3.ggpht.com/Vbi7XVMzoCMoAyHFhJlziKjldN5F-Mkp4EOf5YyiMOPsd-of4ckac2BzPAiKGIveSI4=w720-h310" },
                    { new Guid("3358cf1f-6d3a-45e6-9ec8-e223cf978aa1"), new Guid("f7364ddb-9c12-4f61-9709-2021325198d6"), "", "https://lh3.ggpht.com/AZ2OkTlsJuqUvCP8IQKwkCg7Fv56FRAb_CV8bXRsR15Ayre8fmWJrkr4RCIvx1wYoktm=w720-h310" },
                    { new Guid("24f2e895-4560-4155-828d-63e4ec6aa97b"), new Guid("f7364ddb-9c12-4f61-9709-2021325198d6"), "", "https://lh3.ggpht.com/WRg7Mzp5FM-cSiKGb7TbzgeYBY8oMSV4Vgn35XYHDbejbNkWM7lNgqFeQjMlNAZoUX7Z=w720-h310" },
                    { new Guid("7b3f7c21-256d-4c42-a0c7-e47ceedc5635"), new Guid("c5fe442b-748d-4745-87ec-9833afd09e2c"), "", "https://lh3.googleusercontent.com/WJIWdX6YPms3-diI1TPcCPtgv_YGH2QNMGqOXLK-ta5FLulrZps4KObsB1-frjU6syA=w720-h310" }
                });

            migrationBuilder.InsertData(
                table: "UserGames",
                columns: new[] { "UserId", "GameId", "PurchaseDate" },
                values: new object[,]
                {
                    { new Guid("efe214a4-0434-4a04-bc46-c9b1dab6bf3c"), new Guid("5fb2ad07-3459-4bd2-9660-240aaadee9a9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0234b247-375e-4aff-a530-94d4bc0640bc"), new Guid("f7364ddb-9c12-4f61-9709-2021325198d6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5372e35e-20e0-4264-aba6-75b0904da6e8"), new Guid("ee5a11ea-318f-4be3-a1b6-fbd8aa52ae96"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1c0a0c5e-9be2-4786-8d1b-da4b467bbf40"), new Guid("7faf0a73-29de-4027-b8f4-4f5543775bb9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("be92f81b-574d-453f-ac36-924c09813691"), new Guid("d57a8162-5ab1-4205-91a0-d533b0b3a323"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "WishGame",
                columns: new[] { "UserId", "GameId" },
                values: new object[,]
                {
                    { new Guid("efe214a4-0434-4a04-bc46-c9b1dab6bf3c"), new Guid("5fb2ad07-3459-4bd2-9660-240aaadee9a9") },
                    { new Guid("5372e35e-20e0-4264-aba6-75b0904da6e8"), new Guid("ee5a11ea-318f-4be3-a1b6-fbd8aa52ae96") },
                    { new Guid("1c0a0c5e-9be2-4786-8d1b-da4b467bbf40"), new Guid("7faf0a73-29de-4027-b8f4-4f5543775bb9") },
                    { new Guid("be92f81b-574d-453f-ac36-924c09813691"), new Guid("d57a8162-5ab1-4205-91a0-d533b0b3a323") },
                    { new Guid("0234b247-375e-4aff-a530-94d4bc0640bc"), new Guid("f7364ddb-9c12-4f61-9709-2021325198d6") }
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
                name: "IX_FreeCodes_GameId",
                table: "FreeCodes",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_PublisherId",
                table: "Games",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageGames_GameId",
                table: "ImageGames",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_ImagePublishers_PublisherId",
                table: "ImagePublishers",
                column: "PublisherId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ImageUsers_UserId",
                table: "ImageUsers",
                column: "UserId",
                unique: true);

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
                name: "FreeCodes");

            migrationBuilder.DropTable(
                name: "ImageGames");

            migrationBuilder.DropTable(
                name: "ImagePublishers");

            migrationBuilder.DropTable(
                name: "ImageUsers");

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
