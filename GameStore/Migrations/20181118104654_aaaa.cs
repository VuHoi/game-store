using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GameStore.Migrations
{
    public partial class aaaa : Migration
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
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
                    { new Guid("4d5822e8-3668-4aa0-ac55-a45377982529"), "FPS" },
                    { new Guid("f7901e36-a425-4654-9b04-a93a45481a44"), "Action" },
                    { new Guid("8e79e147-a90a-4b4b-a25b-98471bf255be"), "Adventure" },
                    { new Guid("e3a804da-1fa8-4d13-85c4-5dca8361af00"), "Puzzle" },
                    { new Guid("c1cac5d1-e881-4b71-8fc2-6d6560d3df4c"), "Open world" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Money", "Name", "Reliability" },
                values: new object[,]
                {
                    { new Guid("7f988aca-a46f-47b7-bd00-8baac5afc8dd"), 0, "King", 0 },
                    { new Guid("3ee7307c-18c6-4aa3-ab9e-5a7a6fe8cffb"), 0, "Rovio Entertainment Corporation", 0 },
                    { new Guid("8cddb4bd-b97f-4aff-b5f5-1141149c5853"), 0, "Outfit7 Limited", 0 },
                    { new Guid("50163a6f-6f38-4f90-9309-1c11e3831ee8"), 0, "AMANOTES", 0 },
                    { new Guid("26cc873b-9de0-4219-8206-16102f07f3ad"), 0, "Gameloft", 0 },
                    { new Guid("37296382-3e36-4f7a-9acb-a93acd467d57"), 0, "Mobigame S.A.R.L.", 0 },
                    { new Guid("67402a07-ec52-4e3b-86dc-fcb81c26c153"), 0, "Imangi Studios", 0 },
                    { new Guid("b2646315-83ec-490b-a398-984320a5d477"), 0, "NEKKI", 0 },
                    { new Guid("6442a861-7b72-44b9-8fc6-ef5d16998cda"), 0, "Kiloo", 0 },
                    { new Guid("9b0ec29a-c547-4ec6-a208-c9eb9444d32a"), 0, "ZeptoLab", 0 },
                    { new Guid("6a9fea85-758c-4c08-9a13-fbfe48f81ae5"), 0, "ELECTRONIC ARTS", 0 },
                    { new Guid("7daf8be0-7a53-42eb-a50c-ff873374fb54"), 0, "J-PARK", 0 }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("9695480b-e81e-4118-ba78-d41e90e39607"), "User", "Limited Permission", "User", "User" },
                    { new Guid("f9cb3368-1d78-47ab-8b95-80a0e70c8c5b"), "Admin", "Full Permission", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Hobbies", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("194a1235-8938-4313-8ecd-5b1c0d063433"), 0, "0137e4c0-b340-4eb9-a486-f26e90d009a0", "duykkxm92@gmail.com", false, "Nguyen Ngoc Duy", "Hobbies", false, null, null, null, "duykkxm92", "01638789455", false, null, false, "duykkxm92" },
                    { new Guid("9fe29caf-645a-4a5d-a83f-35025d40faad"), 0, "ce31e6fa-c405-4c08-b470-100e012cb0ae", "Email1@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509228098523", false, null, false, "UserName1" },
                    { new Guid("d8f04b8c-41d4-4acc-ad33-322a9fff5731"), 0, "91252ae8-e863-4760-b347-953ce8286853", "Email2@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098559238098523", false, null, false, "UserName2" },
                    { new Guid("da8f38a2-5c78-4805-9f23-541e1878d43b"), 0, "25e0f5f0-5f21-4913-9f93-5a2168de4b01", "Email3@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098609238098523", false, null, false, "UserName3" },
                    { new Guid("a1128b75-bd77-4aad-a5a3-768caf58891c"), 0, "b72583ac-282b-469c-9b12-42c5dc3cb1fe", "Email4@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509738098523", false, null, false, "UserName4" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Content", "Name", "Price", "PublisherId", "Rating", "ReleaseDate", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("ced9d8fd-c4cf-4ba0-8588-5cbfb890f415"), "DASH as fast as you can! DODGE the oncoming trains!Help Jake, Tricky & Fresh escape from the grumpy Inspector and his dog.  Grind trains with your cool crew!  Colorful and vivid HD graphics!  Hoverboard Surfing!  Paint powered jetpack!  Lightning fast swipe acrobatics!  Challenge and help your friends!", "Subway Surfers", 0f, new Guid("6442a861-7b72-44b9-8fc6-ef5d16998cda"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("1d305711-2756-49d9-93f1-1904df32fb93"), "The sequel to the famous Facebook smash hit with 40 million users Shadow Fight 2 is a nail-biting mix of RPG and classical Fighting. This game lets you equip your character with countless lethal weapons and rare armor sets, and features dozens of lifelike-animated Martial Arts techniques! Crush your enemies, humiliate demon bosses, and be the one to close the Gate of Shadows. Do you have what it takes to kick, punch, jump, and slash your way to victory? There’s only one way to find out", "Shadow Fight 2", 100000f, new Guid("b2646315-83ec-490b-a398-984320a5d477"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("e2012279-e9cc-42b2-9429-3c34406bf300"), "Strap on your running shoes and join the award-winning, fan-favorite runner, Minion Rush. Enter Gru's Lair, discover its many mysterious rooms, and take on manic missions around the world. Along the way, your Minions will jump, roll and dodge obstacles while unlocking a collection of cool Minion costumes.", "Minion Rush: Despicable Me Official Game", 100000f, new Guid("3ee7307c-18c6-4aa3-ab9e-5a7a6fe8cffb"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("b6d87cce-c554-4148-afe3-3a6b093bd253"), "Use the unique powers of the Angry Birds to destroy the greedy pigs' defenses! The survival of the Angry Birds is at stake. Dish out revenge on the greedy pigs who stole their eggs. Use the unique powers of each bird to destroy the pigs’ defenses. Angry Birds features challenging physics-based gameplay and hours of replay value. Each level requires logic, skill and force to solve.", "Angry Birds Classic", 100000f, new Guid("3ee7307c-18c6-4aa3-ab9e-5a7a6fe8cffb"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("2ad18998-8b31-42b7-bccc-a8ed04695c59"), "Is it a baby? Is it a puppy? No! It’s Talking Tom! The cutest kitten, the coolest cat, and the biggest superstar in the world! My Talking Tom is the best virtual pet game for children, and big kids of all ages.That’s right - even grandma and grandpa can join the fun!", "My Talking Tom", 100000f, new Guid("8cddb4bd-b97f-4aff-b5f5-1141149c5853"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("22b2bca5-a426-43e2-840b-585b2d9d6636"), "Dragon Mania Legends is for anyone that wants their very own pet dragon, which is obviously everyone… – Gamezebo", "Dragon Mania Legends", 100000f, new Guid("50163a6f-6f38-4f90-9309-1c11e3831ee8"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("f6ac9936-e7d4-4652-a7b5-eae2225aa3b0"), "Play the award-winning hit action-strategy adventure where you meet, greet, and defeat legions of hilarious zombies from the dawn of time, to the end of days. Amass an army of amazing plants, supercharge them with Plant Food, and devise the ultimate plan to protect your brain.", "Plants vs Zombies 2 Free", 0f, new Guid("50163a6f-6f38-4f90-9309-1c11e3831ee8"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("eea4051d-a50a-489c-be1e-b39a8e85c2df"), "Magic Tiles 3 ™ is one of the most loved piano games among thousands of free games in 2018 which has more than 80 million players around the world.", "Magic Tiles 3", 100000f, new Guid("50163a6f-6f38-4f90-9309-1c11e3831ee8"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("d24be851-36b1-4dbd-87e2-5d0ef265b304"), "Follow the adventure of Om Nom in the first part of the legendary Cut the Rope logic puzzles series. Get it now for free and start playing with millions of players around the world!", "Cut the Rope FULL FREE", 0f, new Guid("7f988aca-a46f-47b7-bd00-8baac5afc8dd"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("d3c60798-2d72-40e3-924a-3bf5513edff6"), "A strange group of enemies appeared in the city and have been using innocent people as experimental tools. Lots of people have turned into Zombie so that Hero and his friends should save the people and remove the enemies.", "Anger of stick 5 : zombie", 100000f, new Guid("7f988aca-a46f-47b7-bd00-8baac5afc8dd"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("993b2594-ecca-4219-874d-9453a9d6921e"), "Start playing Candy Crush Saga today – loved by millions of players around the world. With over a trillion levels played, this sweet match 3 puzzle game is one of the most popular mobile games of all time!", "Candy Crush Saga", 100000f, new Guid("7f988aca-a46f-47b7-bd00-8baac5afc8dd"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("5aba310d-e8aa-4987-9b37-c7e6fb1df3c7"), "The time to take action and strike back is now! We’re calling for the best sniper in the world to take aim at evil, wherever it hides.There’s no room for remorse, so shoot to kill…", "Sniper Fury: Top shooting game - FPS", 100000f, new Guid("7f988aca-a46f-47b7-bd00-8baac5afc8dd"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("aff3e1d1-c1f1-4d2f-a6da-1481db22424b"), "5 lớp nhân vật tùy biến có thể lên cấp cả trong chơi đơn lẫn chơi mạng. Kiếm và dùng Điểm Kĩ năng để kích hoạt kĩ năng riêng của từng lớp nhân vật. Đấu Đội trong các trận Chơi mạng. Bảng xếp hạng Cá nhân và Đội. Nói chuyện với người chơi khác trong mục Chat Toàn cầu và Đội. Nhiệm vụ tiết tấu nhanh với nhiều thử thách khác nhau từ Tokyo đến Venice.", "Modern Combat 5: eSports FPS", 100000f, new Guid("6a9fea85-758c-4c08-9a13-fbfe48f81ae5"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("3cd7dda2-994a-4e55-ac46-c40974573401"), "Help Swampy by guiding water to his broken shower. Each level is a challenging physics-based puzzle with amazing life-like mechanics. Cut through dirt and guide fresh water, dirty water, toxic water, steam, and ooze through increasingly challenging scenarios! Every drop count", "Where's My Water? Free", 0f, new Guid("6442a861-7b72-44b9-8fc6-ef5d16998cda"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("7aa80586-1c30-4633-8a31-14e4de96503e"), "The zombies are revolting ! Attack the city with a horde of zombies, change pedestrians into zombies and create the largest horde. Eat your friends, and challenge them to a crazy race by destroying everything in your path. Zombie Tsunami has proudly exceeded 200 million players around the world.", "Zombie Tsunami", 100000f, new Guid("37296382-3e36-4f7a-9acb-a93acd467d57"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("0d980763-ff96-4457-9d0d-38008cbeb755"), "N.O.V.A. Legacy brings you the best 3D sci-fi FPS experience based on the epic first episode of N.O.V.A., which received critical acclaim -- all in a compact version of the shooter. Kal Wardin, our hero, is a veteran N.O.V.A. marine, summoned once again to don his Mobile Armored Suit and strike against the enemies of the Colonial Administration forces. Helped by Yelena, his personal AI Agent, Kal must protect humanity's destiny by engaging in combat against alien invaders while uncovering the mystery behind their sudden assault.", "N.O.V.A. Legacy", 100000f, new Guid("37296382-3e36-4f7a-9acb-a93acd467d57"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("62d4bb55-c3f3-4dc4-b5a2-b0d12342124c"), "With over a zillion downloads, Temple Run redefined mobile gaming. Now get more of the exhilarating running, jumping, turning and sliding you love in Temple Run 2! Navigate perilous cliffs, zip lines, mines and forests as you try to escape with the cursed idol. How far can you run ? !", "Temple Run 2", 50000f, new Guid("67402a07-ec52-4e3b-86dc-fcb81c26c153"), 4.3f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("ce8484f4-a60b-417d-a16f-01ff9028cd81"), "In Asphalt 8, you’ll race in some of the hottest, most high-performance dream machines ever created, from cars to bikes, as you take them on a global tour of speed. From the blazing Nevada Desert to the tight turns of Tokyo, you’ll find a world of challenge, excitement and arcade fun on your road to the top!", "Asphalt 8: Airborne", 100000f, new Guid("37296382-3e36-4f7a-9acb-a93acd467d57"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("a7b2902d-ba0c-4f49-9c19-e068183e6e6f"), "Get ready to soil your plants as a mob of fun-loving zombies is about to invade your home. Use your arsenal of 49 zombie-zapping plants — peashooters, wall-nuts, cherry bombs and more — to mulchify 26 types of zombies before they break down your door.", "Plants vs. Zombies FREE", 100000f, new Guid("6a9fea85-758c-4c08-9a13-fbfe48f81ae5"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" }
                });

            migrationBuilder.InsertData(
                table: "ImagePublishers",
                columns: new[] { "Id", "PublisherId", "UrlLocal", "UrlOnline" },
                values: new object[,]
                {
                    { new Guid("eafc2002-79b7-4619-957a-6996ff777f98"), new Guid("37296382-3e36-4f7a-9acb-a93acd467d57"), null, "http://4.bp.blogspot.com/-jAUhK8EAuiA/VmnLpfRWLHI/AAAAAAAAAkI/Hp8mTQXl8xM/s1600/Zombie%2BTsunami%2B-%2BLogo%2BMobigame.jpg" },
                    { new Guid("c544d869-33e8-46f9-88c1-b6b54db456ec"), new Guid("26cc873b-9de0-4219-8206-16102f07f3ad"), null, "https://pbs.twimg.com/profile_images/1026435341312512001/u3D328AP_400x400.jpg" },
                    { new Guid("f25fc4b4-cf67-4d97-928d-63749744e068"), new Guid("50163a6f-6f38-4f90-9309-1c11e3831ee8"), null, "https://employer.jobsgo.vn/image.php?src=1187_logo_1187_20170209115933_1779.jpg&w=300&h=300" },
                    { new Guid("7fd2e891-b15c-49e5-a35e-de30cfe2c206"), new Guid("6a9fea85-758c-4c08-9a13-fbfe48f81ae5"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRbShsNR-wcUaPKBv2NxLSeE6arTMAMGZNs5L219VYdIxUapVJc" },
                    { new Guid("ff9c2b3b-613f-47b4-b961-26256c701f40"), new Guid("8cddb4bd-b97f-4aff-b5f5-1141149c5853"), null, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/O7_logo-red_cmyk.jpg/1200px-O7_logo-red_cmyk.jpg" },
                    { new Guid("51d0eb12-b890-4cef-9d1c-4d905a3869f7"), new Guid("67402a07-ec52-4e3b-86dc-fcb81c26c153"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS3aHsnIsbz6CxKRg5tmpq73iNWV6J65niLvsEs9tKf9feje5iv" },
                    { new Guid("9520b242-6ee2-45e7-aa82-7b149a4fd5f7"), new Guid("6442a861-7b72-44b9-8fc6-ef5d16998cda"), null, "https://www.kiloo.com/wp-content/uploads/2017/03/sharelogo-2.png" },
                    { new Guid("95ac31f2-ddd8-4fff-a886-37ede1ebf46c"), new Guid("3ee7307c-18c6-4aa3-ab9e-5a7a6fe8cffb"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdbIPf6EeERMGnyQoYkE4xUMuaU22OEtWLEfHWjAw6vxzGJ5oq" },
                    { new Guid("d10942a1-f291-47dd-8ff6-38f5290232bb"), new Guid("b2646315-83ec-490b-a398-984320a5d477"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQkyOmWOFhXD1lRsMIHkAJrLIvjwmImH1GBwlmqb3I5ysGUNY0-" },
                    { new Guid("9f8df801-0450-484d-a627-a1ef485ec79e"), new Guid("7daf8be0-7a53-42eb-a50c-ff873374fb54"), null, "https://upload.wikimedia.org/wikipedia/vi/thumb/2/2a/ZeptoLab.png/200px-ZeptoLab.png" },
                    { new Guid("8c783ebd-68d2-43b8-872f-57086297dc69"), new Guid("7f988aca-a46f-47b7-bd00-8baac5afc8dd"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSE0L-3DI9ruta232UcPOIlvnE3I3xV-8l1u_C3Grzx6tmXrDzs" },
                    { new Guid("984a6b53-f790-4269-9c51-4d9d2f86a24a"), new Guid("9b0ec29a-c547-4ec6-a208-c9eb9444d32a"), null, "https://upload.wikimedia.org/wikipedia/vi/thumb/2/2a/ZeptoLab.png/200px-ZeptoLab.png" }
                });

            migrationBuilder.InsertData(
                table: "CategoryGames",
                columns: new[] { "GameId", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("ced9d8fd-c4cf-4ba0-8588-5cbfb890f415"), new Guid("4d5822e8-3668-4aa0-ac55-a45377982529") },
                    { new Guid("62d4bb55-c3f3-4dc4-b5a2-b0d12342124c"), new Guid("8e79e147-a90a-4b4b-a25b-98471bf255be") },
                    { new Guid("993b2594-ecca-4219-874d-9453a9d6921e"), new Guid("c1cac5d1-e881-4b71-8fc2-6d6560d3df4c") },
                    { new Guid("a7b2902d-ba0c-4f49-9c19-e068183e6e6f"), new Guid("e3a804da-1fa8-4d13-85c4-5dca8361af00") },
                    { new Guid("7aa80586-1c30-4633-8a31-14e4de96503e"), new Guid("f7901e36-a425-4654-9b04-a93a45481a44") }
                });

            migrationBuilder.InsertData(
                table: "FreeCodes",
                columns: new[] { "Id", "Code", "GameId" },
                values: new object[,]
                {
                    { new Guid("cc3355f1-f128-474b-bdee-76b728b92082"), "5af6c395-6d0e-48ff-8389-d4484f271670", new Guid("62d4bb55-c3f3-4dc4-b5a2-b0d12342124c") },
                    { new Guid("8823b005-c86a-4d83-88fb-8e9ba4e0cc78"), "ae327751-2943-4009-b1b9-1bbeabc9b2fb", new Guid("a7b2902d-ba0c-4f49-9c19-e068183e6e6f") },
                    { new Guid("3fd2c343-101d-4bf2-944e-9e9e8bff5dba"), "3926e6db-8cdd-49ac-a6f5-f677c75dacf0", new Guid("993b2594-ecca-4219-874d-9453a9d6921e") },
                    { new Guid("05f559d7-df94-41fe-8159-49247a73e0f6"), "e4d3c2b8-9127-48be-a6cb-c0cfabb68206", new Guid("7aa80586-1c30-4633-8a31-14e4de96503e") },
                    { new Guid("664c5629-0dcd-41db-941e-20d0ded27499"), "4bd19c44-2d84-43fd-aecf-b977e192ad1c", new Guid("ced9d8fd-c4cf-4ba0-8588-5cbfb890f415") }
                });

            migrationBuilder.InsertData(
                table: "ImageGames",
                columns: new[] { "Id", "GameId", "UrlLocal", "UrlOnline" },
                values: new object[,]
                {
                    { new Guid("bd5e8d0d-828e-4b36-9426-bc824755c757"), new Guid("d24be851-36b1-4dbd-87e2-5d0ef265b304"), "", "https://lh3.googleusercontent.com/Qnm85mIcd32-R8IxmDXM1MPgCfpM2-duddE7P_iS55P0xFO6ZM9jo9dt6PThjWhZvw=w720-h310" },
                    { new Guid("f6c4b415-8525-48c6-9a87-7b3afd55031f"), new Guid("993b2594-ecca-4219-874d-9453a9d6921e"), "", "https://lh3.googleusercontent.com/ucBNG7Vj8Lqo8b14PUMyzB8h7f2YcZ9oKB6BuFaJTgCj4jEv3Zo1jFPg-FjdONrw8c7b=w720-h310" },
                    { new Guid("17fdf609-a284-498b-bb2f-3cabcafc5e52"), new Guid("eea4051d-a50a-489c-be1e-b39a8e85c2df"), "", "https://lh3.googleusercontent.com/Z_KPg-BqbZVMMLlH689YEwzPefUXW0l_7MfPS8-KUzDV4-y-VeSfnswbSXakPJfoJw8=w720-h310" },
                    { new Guid("64930dc3-d365-4af7-b1be-efdbf46d79f8"), new Guid("eea4051d-a50a-489c-be1e-b39a8e85c2df"), "", "https://lh3.googleusercontent.com/uJK2kFV81mdNGWE9nDO__wadnVhC8afhQourrne9WhOy0ip1UjlsElsw9xd0BV3NCG8=w720-h310" },
                    { new Guid("d2746f36-2983-4acf-b315-66fff997c610"), new Guid("5aba310d-e8aa-4987-9b37-c7e6fb1df3c7"), "", "https://lh3.googleusercontent.com/5W6OOrho0AFit_nm98QqpCsu52uHc-kw7RQPK4_PUdGEi6DjrmfZdPJIGYl2u_3Ibw=w720-h310" },
                    { new Guid("00cba1af-b5bb-4d53-9350-00f0826138d2"), new Guid("5aba310d-e8aa-4987-9b37-c7e6fb1df3c7"), "", "https://lh3.googleusercontent.com/5W6OOrho0AFit_nm98QqpCsu52uHc-kw7RQPK4_PUdGEi6DjrmfZdPJIGYl2u_3Ibw=w720-h310" },
                    { new Guid("aff46be4-e42f-4cd1-a1c7-b3bdafe7276a"), new Guid("5aba310d-e8aa-4987-9b37-c7e6fb1df3c7"), "", "https://lh3.googleusercontent.com/qSl0aQ-tQiBC_Ut0MC3n-I3HTgQsDQ52XUq_cnfu5rq9kyDSBs2vneGXZZ-PhVv8yb22=w720-h310" },
                    { new Guid("2b188b99-8c2e-4e23-802d-c642e7d282a1"), new Guid("5aba310d-e8aa-4987-9b37-c7e6fb1df3c7"), "", "https://lh3.googleusercontent.com/nNjmESXQm2dJupXjwYn9RvD6nhS6_5bAthB6GrjrHCdaoiftDAKABIEOBJd3paXCYg=w720-h310" },
                    { new Guid("90248d88-66cb-4728-a553-24b1739aa696"), new Guid("993b2594-ecca-4219-874d-9453a9d6921e"), "", "https://lh3.googleusercontent.com/EFv_aMUrdXQLXLesEfQAuFv9bNvQ5hwzYnuKZ1cr_OBDZU6cY6OZhIiDzfhx4eSuvtI=w720-h310" },
                    { new Guid("d45ba32f-cbf6-4c9d-8409-e8c3fe916945"), new Guid("d3c60798-2d72-40e3-924a-3bf5513edff6"), "", "https://lh3.googleusercontent.com/NdRmiugakoZ-CgyoqeEd7SC9xT_xFIfjY3LtjMifJ9_iKsUdzA5WgBrs2cgoAK3d_CNr=w720-h310" },
                    { new Guid("40515215-2114-410c-bbc8-bfd5a1d6b548"), new Guid("d24be851-36b1-4dbd-87e2-5d0ef265b304"), "", "https://lh3.googleusercontent.com/uFYADCilcHxlddeBXKAAu9HNzQG0Mx1VqwuwGQg3WiXBZAg41hooWQTAUilvZetyYhqy=w720-h310" },
                    { new Guid("2668e62b-6504-4d9b-a677-dc2fd6a723e0"), new Guid("d3c60798-2d72-40e3-924a-3bf5513edff6"), "", "https://lh3.googleusercontent.com/A4POGA0IPwbcaSj5dba5zrn6tUlCiyvu4ppse912kWUzr084-qqgvCT0m-E99RPi228=w720-h310" },
                    { new Guid("c3477652-7b6c-4677-a2c6-0b6a55cf6597"), new Guid("d3c60798-2d72-40e3-924a-3bf5513edff6"), "", "https://lh3.googleusercontent.com/PeX7REevxeIec-hxFckCJP0xyg88TEzwPh4zz2Prv08d-0UsspP6wcoaBXYJqWzkuQ=w720-h310" },
                    { new Guid("9f3ac306-5ed4-408f-997c-887850d089db"), new Guid("d24be851-36b1-4dbd-87e2-5d0ef265b304"), "", "https://lh3.googleusercontent.com/cOijr_HBBvrjn7t00qwPQiXJ2y53NMSMI4iF2YSH89RDlmpe_MbppoqJmXTyIUPCj7M=w720-h310" },
                    { new Guid("a2cd137e-3182-4ece-8220-6f64431477c8"), new Guid("d24be851-36b1-4dbd-87e2-5d0ef265b304"), "", "https://lh3.googleusercontent.com/Kri8NpWg8Nt5BmgNxbMCrW4vxk7LqzjpvibCYHb24_RJgS-l58n-gFR2f4RE_uGfuKI=w720-h310" },
                    { new Guid("b49a47d3-8942-4438-ace0-de1be1cb4ac9"), new Guid("d3c60798-2d72-40e3-924a-3bf5513edff6"), "", "https://lh3.googleusercontent.com/YL2_i-PixRM-qYfrZ6CpAqyNiXW_MrIx2KFyg2zZLkdjjosIK5qyPg1dfbyTAC-BdNg=w720-h310" },
                    { new Guid("fcbc2d5c-19d3-4fde-b1fc-e2c4a75ccdd8"), new Guid("eea4051d-a50a-489c-be1e-b39a8e85c2df"), "", "https://lh3.googleusercontent.com/CjrXpLQr5ixH5K9RjdL4CFLhmfgkVCJVAw0bhOuFuFI0v4IaQyt1zbXLVxKfGz2l246x=w720-h310" },
                    { new Guid("4fc8a1a3-f4b6-434e-958b-16aeda28aff1"), new Guid("f6ac9936-e7d4-4652-a7b5-eae2225aa3b0"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("b42d6854-b2b9-4dd4-97fe-6baa0d12695b"), new Guid("f6ac9936-e7d4-4652-a7b5-eae2225aa3b0"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("3b42ea70-e2be-43e9-a5f1-86c9f603264e"), new Guid("1d305711-2756-49d9-93f1-1904df32fb93"), "", "https://lh3.googleusercontent.com/zRs9fTN-tL-p4yNL3ccFr1w3wUH-hqN0ShgwAnbzcnH2FidymdlixdDN-lpqF3xck4I=w720-h310" },
                    { new Guid("1286dbf2-3d6d-4f41-9054-e1a712dc2516"), new Guid("1d305711-2756-49d9-93f1-1904df32fb93"), "", "https://lh3.googleusercontent.com/o0i5z7sG2EArHccVaOCYU516s3PzflywGTbzf3ylRoZwOizKm-jH2AKwXweh2_77Tw=w720-h310" },
                    { new Guid("c45efd61-0f0d-49ed-a5d5-4e09214bb71a"), new Guid("e2012279-e9cc-42b2-9429-3c34406bf300"), "", "https://lh3.googleusercontent.com/JMc16QhAhKFbnW2jusl-T6xu8xo31BDzv8h7APyDdU006PkYvtk3q3Ey76LU-G908M0=w720-h310" },
                    { new Guid("42559c79-defc-4be2-b7b1-0413191734c4"), new Guid("e2012279-e9cc-42b2-9429-3c34406bf300"), "", "https://lh3.googleusercontent.com/RdxHjaoI2WK-ku4--LmPMaZ6DkLVYt0q9IKiSrdqXnmMKlPo4hgZHf0VdN8Oee5pxg=w720-h310" },
                    { new Guid("d4d0dc56-c1e8-4f6c-9f31-07de147a4f07"), new Guid("e2012279-e9cc-42b2-9429-3c34406bf300"), "", "https://lh3.googleusercontent.com/YYz6o1qMBxop37bvU1rfACXRv1AS-gNHOCjUW9lp6eLDV7BQAZ7zUIkG3PF597svP4gP=w720-h310" },
                    { new Guid("d6a7c7e5-e3d5-4237-84d4-5a1b2a3866d1"), new Guid("e2012279-e9cc-42b2-9429-3c34406bf300"), "", "https://lh3.googleusercontent.com/Ziiu3YNdzaoJf7_rdy9tk7pbPiPlluFvA_JdU0FtzqlvZuLrfyuWNnfkRtMvxq4_lA=w720-h310" },
                    { new Guid("0d3d80ad-939b-4daf-8cca-6b11fc150a82"), new Guid("b6d87cce-c554-4148-afe3-3a6b093bd253"), "", "https://lh3.googleusercontent.com/ClxJrJjyrjj5uaAxZvSaQcjjRfeCta4_otNRCsGJacfFptfTtamCUJpQ0hcQWOd8u-Q=w720-h310" },
                    { new Guid("5d8235bd-8722-477b-a90f-3681a1c2b997"), new Guid("b6d87cce-c554-4148-afe3-3a6b093bd253"), "", "https://lh3.googleusercontent.com/JIvkWPFnKbYeVV5h3AxjMgR9ogQ2a0vMQgCp5B3JP4dEXU4zIR40H8ROTg8WkPrjcEA=w720-h310" },
                    { new Guid("d68e99f0-80cd-4fd9-a51c-6af55defe006"), new Guid("b6d87cce-c554-4148-afe3-3a6b093bd253"), "", "https://lh3.googleusercontent.com/d0jf4r7KjWBCzi2GELWFSf6MaJIHepkJIN8JYT8g0tSIThiH_W6FhUnHjBN_fYdl3Q=w720-h310" },
                    { new Guid("beeb154e-5118-431c-803f-d81c987ec5f9"), new Guid("eea4051d-a50a-489c-be1e-b39a8e85c2df"), "", "https://lh3.googleusercontent.com/HteHDUkzuMjCEHM1B-3jvLqlbBYtJZFWiHm-vf47YcE7QiInhXn2O-LkYPxvzPnPGA=w720-h310" },
                    { new Guid("46029b95-f3c5-41cf-93a7-a39a21b17ebb"), new Guid("b6d87cce-c554-4148-afe3-3a6b093bd253"), "", "https://lh3.googleusercontent.com/UbTWxlQujVdxOaYqy_FmC4LRBlm_wSUgQe0wIM0BSXeGUZ0Vzle9OTWNNs4wk8nOKI4=w720-h310" },
                    { new Guid("e172473c-71e9-45ef-942e-1ca3a17f26cf"), new Guid("2ad18998-8b31-42b7-bccc-a8ed04695c59"), "", "https://lh3.googleusercontent.com/jCNaOtE_9-Zcs9r5MFtGzaxO8xNz3UYEcB3XdPe1oLO3X6PH-hYEspWnR26lUZef_5A=w720-h310" },
                    { new Guid("d133af00-32a6-405b-bcfe-ab02e48f720f"), new Guid("2ad18998-8b31-42b7-bccc-a8ed04695c59"), "", "https://lh3.googleusercontent.com/d6CY2BSvBXFLK8J3WqJEdDr53_OZ43Aijr43CjG1QKUfHXt4E_zDNBZWoMqkxONzOQ=w720-h310" },
                    { new Guid("35c01390-e1bf-44f4-9251-1cfb3f009d84"), new Guid("2ad18998-8b31-42b7-bccc-a8ed04695c59"), "", "https://lh3.googleusercontent.com/L615QU2G2qxv68di7WqB4V40mDsOgko4iKmz-NB6SzwLejM8x4i2CbAqgkIxBqZ3A9M=w720-h310" },
                    { new Guid("ad8cec37-a1de-431e-8568-79a26c204220"), new Guid("22b2bca5-a426-43e2-840b-585b2d9d6636"), "", "https://lh3.googleusercontent.com/9lQV-3IWYXkSndN4GsVQTflvUCSKPMj-uSuH9tEd8FlHuBOslA52Q-Z7wEEKmhwuxJE=w720-h310" },
                    { new Guid("98f359f2-c302-4f57-baa4-d93bae667d14"), new Guid("22b2bca5-a426-43e2-840b-585b2d9d6636"), "", "https://lh3.googleusercontent.com/3HUpkFFcnCkLbgUosodwIrfzzq3VkebxVQkjfa_uDhapJyrz0ATxq6wRyYpyxKauyg=w720-h310" },
                    { new Guid("e22bf208-6c5d-45f7-9654-c5466641cbf7"), new Guid("22b2bca5-a426-43e2-840b-585b2d9d6636"), "", "https://lh3.googleusercontent.com/JJNpXkj5HNkscW_bmZ1yGu-GuakL4Q4zRwOPmACFaqbIT5C2HMaI4LwhjGNiIrup_Ew4=w720-h310" },
                    { new Guid("4b024344-d3e9-4ea2-9be5-7c30ae70d5c6"), new Guid("22b2bca5-a426-43e2-840b-585b2d9d6636"), "", "https://lh3.googleusercontent.com/aU5RuCIDy7JzNtp5ib2huaa1t33TVY_zdsES_ooMWSwY6K1JnHG0HC9RK0OgVuXqs9U=w720-h310" },
                    { new Guid("0185ff85-9239-44b9-8b77-42468d6633f0"), new Guid("f6ac9936-e7d4-4652-a7b5-eae2225aa3b0"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("a3ee05a1-0d69-43fa-8a9a-aebed6c89e61"), new Guid("f6ac9936-e7d4-4652-a7b5-eae2225aa3b0"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("71a48743-f02f-45d5-95f0-a73c70261b87"), new Guid("2ad18998-8b31-42b7-bccc-a8ed04695c59"), "", "https://lh3.googleusercontent.com/sCw3rT7aK1z589o_MBBn1JzVd7fYC1-fWkYV2Tz4eDfCDTi49dS9tOFBLqBrd_XwQCc=w720-h310" },
                    { new Guid("ed7f3c7e-cbc7-4e07-a52e-13b999a1c8e8"), new Guid("993b2594-ecca-4219-874d-9453a9d6921e"), "", "https://lh3.googleusercontent.com/xaL3b80wmBVOrpH-q_DX8F5kKsASHH8Fllf3u65TsS0zs9_y0J4DWKJj5T9QVAWuT3Rn=w720-h310" },
                    { new Guid("e04ecd28-1ee8-496f-8fc6-0b9e4e1632c1"), new Guid("aff3e1d1-c1f1-4d2f-a6da-1481db22424b"), "", "https://lh3.googleusercontent.com/Ibj-Kt-6Pc1IBDVj0yWf1sNjSpdGpRlapbTbjc5MuitmDkoKVMP45GF0LBlg6pnIbYE=w720-h310" },
                    { new Guid("3ebb8128-6898-4c7d-a4b6-3a248ea151b4"), new Guid("1d305711-2756-49d9-93f1-1904df32fb93"), "", "https://lh3.googleusercontent.com/AinG9y8hyEb_p2B6Rg8-iOVjYR7EcsGDmv_rThdnfzgkBjbukLIT4mWFOg5ObAO4RMq0=w720-h310" },
                    { new Guid("a77bd1e8-5f14-4b0b-80ae-eddbb8620782"), new Guid("ce8484f4-a60b-417d-a16f-01ff9028cd81"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("a9c1b08d-1619-4276-8401-450854c80847"), new Guid("ce8484f4-a60b-417d-a16f-01ff9028cd81"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("794a9097-5aa8-4211-90df-5123b1f98206"), new Guid("ce8484f4-a60b-417d-a16f-01ff9028cd81"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("712e7a3c-1e9a-458e-a35d-6de0ee253380"), new Guid("ce8484f4-a60b-417d-a16f-01ff9028cd81"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("438e7277-99a0-4a7e-a13f-6e53a44abbd2"), new Guid("7aa80586-1c30-4633-8a31-14e4de96503e"), "", "https://lh3.googleusercontent.com/UY9fte3alDnv-cZ94Jx27Lf4g9FUT2395jhXPScEllshpdCO4zfnuWrTNtO1FVRt3w=w720-h310" },
                    { new Guid("69f95584-11e4-4ec5-b085-174187b441e5"), new Guid("7aa80586-1c30-4633-8a31-14e4de96503e"), "", "https://lh3.googleusercontent.com/-BUT6NCVxZsPPjsUW8zdrVk4XLMRuE_oWSTwaXrAPYZbBsMKBfqXxOVI7OowXxoLwa8=w720-h310" },
                    { new Guid("c37fe9e6-826d-46ad-b847-bce717421e34"), new Guid("7aa80586-1c30-4633-8a31-14e4de96503e"), "", "https://lh3.googleusercontent.com/MwNuIIzmxxJgM8JeNi2aBhpE-kNnXBGOVPRb_gZoRE-gel5q9ZP7mrQfTT_9xzV8dz4=w720-h310" },
                    { new Guid("6f9ad561-b446-409c-94aa-2ab8c6dfb968"), new Guid("993b2594-ecca-4219-874d-9453a9d6921e"), "", "https://lh3.googleusercontent.com/gFZCgWFd8-oR8zu2ApqRWk6dgwIkDM8jex4MxbA-MdiYgfpHJlkAcPBCZX5czXgddA=w720-h310" },
                    { new Guid("5b74924f-2970-407d-b475-3e76cafcbc39"), new Guid("7aa80586-1c30-4633-8a31-14e4de96503e"), "", "https://lh3.googleusercontent.com/mfGdhejubeU1m1Pkj2vpWMLTlLMhnQz0f2Z8M79g6g0thY9cDyHggntmd_A7ckZPGVM=w720-h310" },
                    { new Guid("2cba93e7-b7ca-40bb-9d6a-254c9c338ffd"), new Guid("3cd7dda2-994a-4e55-ac46-c40974573401"), "", "https://lh3.ggpht.com/y7On3vVZhFWycuekTPLwARYJ3MwQyODIzKHRt4ofyeS_gmXRDF271NsFDfu_lLhlX2Rj=w720-h310" },
                    { new Guid("81313735-1359-4b5b-99eb-36ce27c2e720"), new Guid("3cd7dda2-994a-4e55-ac46-c40974573401"), "", "https://lh3.ggpht.com/y7On3vVZhFWycuekTPLwARYJ3MwQyODIzKHRt4ofyeS_gmXRDF271NsFDfu_lLhlX2Rj=w720-h310" },
                    { new Guid("d099d17e-3068-4ffa-9d33-4ce154978efc"), new Guid("3cd7dda2-994a-4e55-ac46-c40974573401"), "", "https://lh3.ggpht.com/y7On3vVZhFWycuekTPLwARYJ3MwQyODIzKHRt4ofyeS_gmXRDF271NsFDfu_lLhlX2Rj=w720-h310" },
                    { new Guid("88f96e39-46ce-4077-a4c8-29d826b0c755"), new Guid("ced9d8fd-c4cf-4ba0-8588-5cbfb890f415"), "", "https://lh3.googleusercontent.com/h4JQOfS4vmim_WhTHeC3RGxtY8eoFG0fgtgsWWk6VvVSrjnjtlgSFzR6sW0hzbncWA=w720-h310" },
                    { new Guid("2e5450c5-71b6-436c-ba4c-4584ba0b1887"), new Guid("ced9d8fd-c4cf-4ba0-8588-5cbfb890f415"), "", "https://lh3.googleusercontent.com/oMcH_a4lXShvowzyaiQpE0_MhYWZvdN9RkaYLtkdnw_rlDR_uHbHj9Eu2zbrvyOAXHQ=w720-h310" },
                    { new Guid("a1d66835-e274-40bb-98e6-8fadcd542343"), new Guid("ced9d8fd-c4cf-4ba0-8588-5cbfb890f415"), "", "https://lh3.googleusercontent.com/Ia1psbcXgeCV9FBZk1b08QnxC-uSHCgJ112VeJZB19_F2Q-m_w3Z7P_OjFStnYM3LaCC=w720-h310" },
                    { new Guid("39f1a7b3-beb1-4a92-958e-8e6811689818"), new Guid("ced9d8fd-c4cf-4ba0-8588-5cbfb890f415"), "", "https://lh3.googleusercontent.com/vInYRcyjzVjBFfY4HIGLLf-tSLK9S55HjUbmQuxmrbpVpItV3AfyuxVMFGASoDdMHc4=w720-h310" },
                    { new Guid("140d8479-d91c-47e4-a6a6-344719bb7b2a"), new Guid("3cd7dda2-994a-4e55-ac46-c40974573401"), "", "https://lh3.ggpht.com/y7On3vVZhFWycuekTPLwARYJ3MwQyODIzKHRt4ofyeS_gmXRDF271NsFDfu_lLhlX2Rj=w720-h310" },
                    { new Guid("4f6f6142-02bc-440f-81fe-7286153921a9"), new Guid("0d980763-ff96-4457-9d0d-38008cbeb755"), "", "https://lh3.googleusercontent.com/FMgP9XZNML3lieBG9KDgiJGnT2WlmHMG5lFGcAl0rk93GtGFjf9X2J6vxcCCElNPJDw=w720-h310" },
                    { new Guid("2619f92c-9298-4bce-931d-2ee7cda4ce07"), new Guid("0d980763-ff96-4457-9d0d-38008cbeb755"), "", "https://lh3.googleusercontent.com/DQppPRLU04SzwExhZTIKsYL1y3iZXzRsZbTBrmHJqJO1aTCsApHGdYxTKt3dvkN7ctRb=w720-h310" },
                    { new Guid("fbd65e00-f8c7-46c1-ba9f-e7d541bbbc38"), new Guid("0d980763-ff96-4457-9d0d-38008cbeb755"), "", "https://lh3.googleusercontent.com/-oRMqwODzaru2JCxLf3JtHVZXtpYfQ8Qo0IQRbRsZtssH6dUGr51WMfH0j3eMrfO5w=w720-h310" },
                    { new Guid("b2920b1b-7601-4439-ba9b-e8e65617f856"), new Guid("aff3e1d1-c1f1-4d2f-a6da-1481db22424b"), "", "https://lh3.googleusercontent.com/W_3i_ZHnSjan-N8egYQy9sQw87CppDDda9ITzTIQyTFHZpO2VJlhCzP_BORM3Hd-CDw=w720-h310" },
                    { new Guid("5bedf669-c93d-424a-8f07-4d8875dc7db9"), new Guid("aff3e1d1-c1f1-4d2f-a6da-1481db22424b"), "", "https://lh3.googleusercontent.com/RhBTJ2IEOhtPEbOpmMTxfMC9iU06JihtylD-lQxbTrIPfT2U-B0YLAjGELbj2Ppk1w8=w720-h310" },
                    { new Guid("0eb3e21e-43fc-4056-8379-7e450c76aeaa"), new Guid("aff3e1d1-c1f1-4d2f-a6da-1481db22424b"), "", "https://lh3.googleusercontent.com/nlXezemMS359X8dy6MxUJMgumyw6abz15NX0CjtnT8V57vni_uuS3saDllIMeyfQ6e-6=w720-h310" },
                    { new Guid("a9f99b09-e9ae-4d39-bb99-19f45b07eb8f"), new Guid("a7b2902d-ba0c-4f49-9c19-e068183e6e6f"), "", "https://lh3.googleusercontent.com/aosNkyZihAba_VF_HRKOUMGFuK5SxNcZMMvYIAXufiG8znXvrxJ_7jMgmP2E01CapoQ=w720-h310" },
                    { new Guid("8414ce12-8ef0-4804-adab-b010b35f3ddf"), new Guid("0d980763-ff96-4457-9d0d-38008cbeb755"), "", "https://lh3.googleusercontent.com/wzk-BPRwz5Lrh2YZ66uEJb8JjXkFE8oVm4RpZVTmWsCcx1e1nxP3XBhqr2q9Iff7Xica=w720-h310" },
                    { new Guid("3551c641-8633-4e9c-aa52-d2080d2968de"), new Guid("a7b2902d-ba0c-4f49-9c19-e068183e6e6f"), "", "https://lh3.googleusercontent.com/Km7Il6ij6xZBtWJPSpEacmz8dC2C9WACUuf37VdjIYaXWaPaC6WWWmx3T8aaNgNkJaBx=w720-h310" },
                    { new Guid("c2392471-32e0-4aeb-816e-1cd85ea08abb"), new Guid("a7b2902d-ba0c-4f49-9c19-e068183e6e6f"), "", "https://lh3.googleusercontent.com/tk_p7dIHQBEBeYiVkFaPcU_5bd3fOhE8HerKp4Ei0cTyxVoVDdd_QD0SLPJeJrSm4c4=w720-h310" },
                    { new Guid("0d2634f6-e061-4b95-b48f-f6056bd3ab96"), new Guid("a7b2902d-ba0c-4f49-9c19-e068183e6e6f"), "", "https://lh3.googleusercontent.com/Zsth8maheotaUA0he3vGtWmm11dWsEsLlffOsvzGX65Sp4nXNAuKSx-Z96f8as3twQ4=w720-h310" },
                    { new Guid("d79dd3bd-8bd1-449a-8d6b-9e0c1504153f"), new Guid("62d4bb55-c3f3-4dc4-b5a2-b0d12342124c"), "", "https://lh3.ggpht.com/GqnDETqoUP17xJg0cQ3pyEHsgO-KLjx-MbJ0Mcwg4Lvd2PnEO-JARZhYtfd8AYwjEew=w720-h310" },
                    { new Guid("514c2cde-3e63-4444-97ec-81ced350054c"), new Guid("62d4bb55-c3f3-4dc4-b5a2-b0d12342124c"), "", "https://lh3.ggpht.com/Vbi7XVMzoCMoAyHFhJlziKjldN5F-Mkp4EOf5YyiMOPsd-of4ckac2BzPAiKGIveSI4=w720-h310" },
                    { new Guid("7506f9c0-0628-415b-8935-c7f45579ae74"), new Guid("62d4bb55-c3f3-4dc4-b5a2-b0d12342124c"), "", "https://lh3.ggpht.com/AZ2OkTlsJuqUvCP8IQKwkCg7Fv56FRAb_CV8bXRsR15Ayre8fmWJrkr4RCIvx1wYoktm=w720-h310" },
                    { new Guid("041886f7-027c-4836-9bd3-58a41dbedc9d"), new Guid("62d4bb55-c3f3-4dc4-b5a2-b0d12342124c"), "", "https://lh3.ggpht.com/WRg7Mzp5FM-cSiKGb7TbzgeYBY8oMSV4Vgn35XYHDbejbNkWM7lNgqFeQjMlNAZoUX7Z=w720-h310" },
                    { new Guid("0cfa58ed-5a6c-4299-bd79-12826e2d832f"), new Guid("1d305711-2756-49d9-93f1-1904df32fb93"), "", "https://lh3.googleusercontent.com/WJIWdX6YPms3-diI1TPcCPtgv_YGH2QNMGqOXLK-ta5FLulrZps4KObsB1-frjU6syA=w720-h310" }
                });

            migrationBuilder.InsertData(
                table: "UserGames",
                columns: new[] { "UserId", "GameId", "PurchaseDate" },
                values: new object[,]
                {
                    { new Guid("9fe29caf-645a-4a5d-a83f-35025d40faad"), new Guid("7aa80586-1c30-4633-8a31-14e4de96503e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d8f04b8c-41d4-4acc-ad33-322a9fff5731"), new Guid("62d4bb55-c3f3-4dc4-b5a2-b0d12342124c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("da8f38a2-5c78-4805-9f23-541e1878d43b"), new Guid("a7b2902d-ba0c-4f49-9c19-e068183e6e6f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("194a1235-8938-4313-8ecd-5b1c0d063433"), new Guid("ced9d8fd-c4cf-4ba0-8588-5cbfb890f415"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a1128b75-bd77-4aad-a5a3-768caf58891c"), new Guid("993b2594-ecca-4219-874d-9453a9d6921e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "WishGame",
                columns: new[] { "UserId", "GameId" },
                values: new object[,]
                {
                    { new Guid("9fe29caf-645a-4a5d-a83f-35025d40faad"), new Guid("7aa80586-1c30-4633-8a31-14e4de96503e") },
                    { new Guid("da8f38a2-5c78-4805-9f23-541e1878d43b"), new Guid("a7b2902d-ba0c-4f49-9c19-e068183e6e6f") },
                    { new Guid("194a1235-8938-4313-8ecd-5b1c0d063433"), new Guid("ced9d8fd-c4cf-4ba0-8588-5cbfb890f415") },
                    { new Guid("a1128b75-bd77-4aad-a5a3-768caf58891c"), new Guid("993b2594-ecca-4219-874d-9453a9d6921e") },
                    { new Guid("d8f04b8c-41d4-4acc-ad33-322a9fff5731"), new Guid("62d4bb55-c3f3-4dc4-b5a2-b0d12342124c") }
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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "User",
                column: "NormalizedUserName",
                unique: true);

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
