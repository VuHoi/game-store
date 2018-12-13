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
                    Money = table.Column<float>(nullable: false),
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
                    FullName = table.Column<string>(nullable: true),
                    Money = table.Column<float>(nullable: false)
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
                    Sale = table.Column<float>(nullable: false),
                    StartDateSale = table.Column<DateTime>(nullable: false),
                    EndDateSale = table.Column<DateTime>(nullable: false),
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
                    { new Guid("379789b3-6683-4556-8561-83fdd95588a2"), "FPS" },
                    { new Guid("5312e272-af9b-451c-b6fe-30720828e6f0"), "Action" },
                    { new Guid("eaa9fe31-f37c-428c-9f73-31ccb62d61c9"), "Adventure" },
                    { new Guid("f749149d-1913-498b-bf64-5919ff83a3d7"), "Puzzle" },
                    { new Guid("659fe1d9-c8d0-40b9-ae1b-dab7175c1e9a"), "Open world" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Money", "Name", "Reliability" },
                values: new object[,]
                {
                    { new Guid("5fc4b001-02bb-4003-ae00-8569cad63b2c"), 0f, "King", 0 },
                    { new Guid("a88aedcb-3194-4134-ba33-87705b7d0e10"), 0f, "Rovio Entertainment Corporation", 0 },
                    { new Guid("eaf24398-c4db-4173-a4fb-069405a2237c"), 0f, "Outfit7 Limited", 0 },
                    { new Guid("c9600632-8c83-4825-b732-8bb9612b4e3f"), 0f, "AMANOTES", 0 },
                    { new Guid("5e92760d-4469-4b06-90e8-6eb71da6b919"), 0f, "Gameloft", 0 },
                    { new Guid("76ae0ee1-bc3a-40b5-b761-85a5cd564677"), 0f, "Mobigame S.A.R.L.", 0 },
                    { new Guid("1e30023a-785e-4174-8902-554d4219825e"), 0f, "Imangi Studios", 0 },
                    { new Guid("0978db77-feb9-44da-ba42-7b090bf1a2b3"), 0f, "NEKKI", 0 },
                    { new Guid("01acf015-02d1-4928-a744-2f367fb4467c"), 0f, "Kiloo", 0 },
                    { new Guid("7babea71-e324-4757-9b51-d670e95d2d83"), 0f, "ZeptoLab", 0 },
                    { new Guid("347d5d30-17fa-4c71-8679-a0032cdcee1d"), 0f, "ELECTRONIC ARTS", 0 },
                    { new Guid("fa7a84d5-6714-4c02-a862-bcdafb1215e3"), 0f, "J-PARK", 0 }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("189dcb05-392b-455f-bb63-bd1f4531d8cb"), "User", "Limited Permission", "User", "User" },
                    { new Guid("f12a6685-cd1b-4b80-889b-14949264995d"), "Admin", "Full Permission", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Hobbies", "LockoutEnabled", "LockoutEnd", "Money", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("5aa91776-8e20-4c3e-a5ff-72fb13ef03d5"), 0, "566bc328-67f7-41d2-aca2-7faaccf58eb0", "duykkxm92@gmail.com", false, "Nguyen Ngoc Duy", "Hobbies", false, null, 0f, null, null, "duykkxm92", "01638789455", false, null, false, "duykkxm92" },
                    { new Guid("a7200ea4-1d44-46ec-bdf2-6dc374f0a262"), 0, "f559b969-fcf1-4da2-bb6f-0a2b24bd861e", "Email1@gmail.com", false, "Full Name", "Hobbies", false, null, 0f, null, null, "Thatvuhai_7595", "93098509228098523", false, null, false, "UserName1" },
                    { new Guid("ddba090e-df80-4e6a-a801-8ce821ca5a7d"), 0, "8ed1a5a9-f609-4228-8fdd-6e32ab990174", "Email2@gmail.com", false, "Full Name", "Hobbies", false, null, 0f, null, null, "Thatvuhai_7595", "93098559238098523", false, null, false, "UserName2" },
                    { new Guid("7919440e-afd4-45d3-89b4-ce81f6c23b03"), 0, "6ff6478b-a879-4f90-b8b2-c024c8cd2e13", "Email3@gmail.com", false, "Full Name", "Hobbies", false, null, 0f, null, null, "Thatvuhai_7595", "93098609238098523", false, null, false, "UserName3" },
                    { new Guid("4b96e3db-1909-4e4c-a254-75051a5e0a49"), 0, "6e09815b-1f8e-447d-8068-daef093c03ba", "Email4@gmail.com", false, "Full Name", "Hobbies", false, null, 0f, null, null, "Thatvuhai_7595", "93098509738098523", false, null, false, "UserName4" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Content", "EndDateSale", "Name", "Price", "PublisherId", "Rating", "ReleaseDate", "Sale", "StartDateSale", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("49e0b07d-788f-4d98-b1b3-3b4f7b832d07"), "DASH as fast as you can! DODGE the oncoming trains!Help Jake, Tricky & Fresh escape from the grumpy Inspector and his dog.  Grind trains with your cool crew!  Colorful and vivid HD graphics!  Hoverboard Surfing!  Paint powered jetpack!  Lightning fast swipe acrobatics!  Challenge and help your friends!", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Subway Surfers", 0f, new Guid("01acf015-02d1-4928-a744-2f367fb4467c"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("0a9696ca-4487-4cef-ab9c-cc8541d9d5c3"), "The sequel to the famous Facebook smash hit with 40 million users Shadow Fight 2 is a nail-biting mix of RPG and classical Fighting. This game lets you equip your character with countless lethal weapons and rare armor sets, and features dozens of lifelike-animated Martial Arts techniques! Crush your enemies, humiliate demon bosses, and be the one to close the Gate of Shadows. Do you have what it takes to kick, punch, jump, and slash your way to victory? There’s only one way to find out", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shadow Fight 2", 100000f, new Guid("0978db77-feb9-44da-ba42-7b090bf1a2b3"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("a1f50b53-7e4d-4071-8896-d23b4d2590c9"), "Strap on your running shoes and join the award-winning, fan-favorite runner, Minion Rush. Enter Gru's Lair, discover its many mysterious rooms, and take on manic missions around the world. Along the way, your Minions will jump, roll and dodge obstacles while unlocking a collection of cool Minion costumes.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minion Rush: Despicable Me Official Game", 100000f, new Guid("a88aedcb-3194-4134-ba33-87705b7d0e10"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("1dd392d5-4956-401b-a59a-c48307f7e6f2"), "Use the unique powers of the Angry Birds to destroy the greedy pigs' defenses! The survival of the Angry Birds is at stake. Dish out revenge on the greedy pigs who stole their eggs. Use the unique powers of each bird to destroy the pigs’ defenses. Angry Birds features challenging physics-based gameplay and hours of replay value. Each level requires logic, skill and force to solve.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angry Birds Classic", 100000f, new Guid("a88aedcb-3194-4134-ba33-87705b7d0e10"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("852b4b74-05aa-4ba8-9a07-88f49c7d6e93"), "Is it a baby? Is it a puppy? No! It’s Talking Tom! The cutest kitten, the coolest cat, and the biggest superstar in the world! My Talking Tom is the best virtual pet game for children, and big kids of all ages.That’s right - even grandma and grandpa can join the fun!", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "My Talking Tom", 100000f, new Guid("eaf24398-c4db-4173-a4fb-069405a2237c"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("34855cdd-9412-47a0-8157-b3554c5e8457"), "Dragon Mania Legends is for anyone that wants their very own pet dragon, which is obviously everyone… – Gamezebo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dragon Mania Legends", 100000f, new Guid("c9600632-8c83-4825-b732-8bb9612b4e3f"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("c37f7425-6f2c-47ad-966d-1391396eb096"), "Play the award-winning hit action-strategy adventure where you meet, greet, and defeat legions of hilarious zombies from the dawn of time, to the end of days. Amass an army of amazing plants, supercharge them with Plant Food, and devise the ultimate plan to protect your brain.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plants vs Zombies 2 Free", 0f, new Guid("c9600632-8c83-4825-b732-8bb9612b4e3f"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("ce81f4be-fbaa-4699-b7b9-4a1cc1b3f1a5"), "Magic Tiles 3 ™ is one of the most loved piano games among thousands of free games in 2018 which has more than 80 million players around the world.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magic Tiles 3", 100000f, new Guid("c9600632-8c83-4825-b732-8bb9612b4e3f"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("7ca43f6f-2ba8-4d47-8b8e-ad1fe5b9f952"), "Follow the adventure of Om Nom in the first part of the legendary Cut the Rope logic puzzles series. Get it now for free and start playing with millions of players around the world!", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cut the Rope FULL FREE", 0f, new Guid("5fc4b001-02bb-4003-ae00-8569cad63b2c"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("e33aaab3-48c3-477e-beae-c939bfd213e5"), "A strange group of enemies appeared in the city and have been using innocent people as experimental tools. Lots of people have turned into Zombie so that Hero and his friends should save the people and remove the enemies.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anger of stick 5 : zombie", 100000f, new Guid("5fc4b001-02bb-4003-ae00-8569cad63b2c"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("af30a151-e176-4331-92c2-f1240b2d58e5"), "Start playing Candy Crush Saga today – loved by millions of players around the world. With over a trillion levels played, this sweet match 3 puzzle game is one of the most popular mobile games of all time!", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Candy Crush Saga", 100000f, new Guid("5fc4b001-02bb-4003-ae00-8569cad63b2c"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("3b9f0257-e181-4c29-bb03-6c8f76a46bb6"), "The time to take action and strike back is now! We’re calling for the best sniper in the world to take aim at evil, wherever it hides.There’s no room for remorse, so shoot to kill…", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sniper Fury: Top shooting game - FPS", 100000f, new Guid("5fc4b001-02bb-4003-ae00-8569cad63b2c"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("b09cd91d-bc47-4791-b541-dbbfd5082f67"), "5 lớp nhân vật tùy biến có thể lên cấp cả trong chơi đơn lẫn chơi mạng. Kiếm và dùng Điểm Kĩ năng để kích hoạt kĩ năng riêng của từng lớp nhân vật. Đấu Đội trong các trận Chơi mạng. Bảng xếp hạng Cá nhân và Đội. Nói chuyện với người chơi khác trong mục Chat Toàn cầu và Đội. Nhiệm vụ tiết tấu nhanh với nhiều thử thách khác nhau từ Tokyo đến Venice.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modern Combat 5: eSports FPS", 100000f, new Guid("347d5d30-17fa-4c71-8679-a0032cdcee1d"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("ac90d80a-1d99-44bb-88b2-be761df65c43"), "Help Swampy by guiding water to his broken shower. Each level is a challenging physics-based puzzle with amazing life-like mechanics. Cut through dirt and guide fresh water, dirty water, toxic water, steam, and ooze through increasingly challenging scenarios! Every drop count", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Where's My Water? Free", 0f, new Guid("01acf015-02d1-4928-a744-2f367fb4467c"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("edbd4af9-724b-4d7f-a9b8-025a35506759"), "The zombies are revolting ! Attack the city with a horde of zombies, change pedestrians into zombies and create the largest horde. Eat your friends, and challenge them to a crazy race by destroying everything in your path. Zombie Tsunami has proudly exceeded 200 million players around the world.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zombie Tsunami", 100000f, new Guid("76ae0ee1-bc3a-40b5-b761-85a5cd564677"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("dda245ad-8348-4b7d-b7ea-2bf0a803f54b"), "N.O.V.A. Legacy brings you the best 3D sci-fi FPS experience based on the epic first episode of N.O.V.A., which received critical acclaim -- all in a compact version of the shooter. Kal Wardin, our hero, is a veteran N.O.V.A. marine, summoned once again to don his Mobile Armored Suit and strike against the enemies of the Colonial Administration forces. Helped by Yelena, his personal AI Agent, Kal must protect humanity's destiny by engaging in combat against alien invaders while uncovering the mystery behind their sudden assault.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "N.O.V.A. Legacy", 100000f, new Guid("76ae0ee1-bc3a-40b5-b761-85a5cd564677"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("8855c982-5d2c-4ca3-ba42-878b5e1b5b46"), "With over a zillion downloads, Temple Run redefined mobile gaming. Now get more of the exhilarating running, jumping, turning and sliding you love in Temple Run 2! Navigate perilous cliffs, zip lines, mines and forests as you try to escape with the cursed idol. How far can you run ? !", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Temple Run 2", 50000f, new Guid("1e30023a-785e-4174-8902-554d4219825e"), 4.3f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("bce51996-00b6-4b1c-a6d1-d0f4a1fd4891"), "In Asphalt 8, you’ll race in some of the hottest, most high-performance dream machines ever created, from cars to bikes, as you take them on a global tour of speed. From the blazing Nevada Desert to the tight turns of Tokyo, you’ll find a world of challenge, excitement and arcade fun on your road to the top!", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asphalt 8: Airborne", 100000f, new Guid("76ae0ee1-bc3a-40b5-b761-85a5cd564677"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("e6b6afa3-f3b2-4f77-85bf-b48d3afb7610"), "Get ready to soil your plants as a mob of fun-loving zombies is about to invade your home. Use your arsenal of 49 zombie-zapping plants — peashooters, wall-nuts, cherry bombs and more — to mulchify 26 types of zombies before they break down your door.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plants vs. Zombies FREE", 100000f, new Guid("347d5d30-17fa-4c71-8679-a0032cdcee1d"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" }
                });

            migrationBuilder.InsertData(
                table: "ImagePublishers",
                columns: new[] { "Id", "PublisherId", "UrlLocal", "UrlOnline" },
                values: new object[,]
                {
                    { new Guid("cba42400-efcd-4651-a26a-2ac8f3161435"), new Guid("76ae0ee1-bc3a-40b5-b761-85a5cd564677"), null, "http://4.bp.blogspot.com/-jAUhK8EAuiA/VmnLpfRWLHI/AAAAAAAAAkI/Hp8mTQXl8xM/s1600/Zombie%2BTsunami%2B-%2BLogo%2BMobigame.jpg" },
                    { new Guid("c35c8bb5-df6f-4ffd-a076-245026123732"), new Guid("5e92760d-4469-4b06-90e8-6eb71da6b919"), null, "https://pbs.twimg.com/profile_images/1026435341312512001/u3D328AP_400x400.jpg" },
                    { new Guid("d56249e9-cb4a-4176-9815-1e2687035217"), new Guid("c9600632-8c83-4825-b732-8bb9612b4e3f"), null, "https://employer.jobsgo.vn/image.php?src=1187_logo_1187_20170209115933_1779.jpg&w=300&h=300" },
                    { new Guid("0aa53eb8-edb7-4832-9c5e-be9ab42fe0f1"), new Guid("347d5d30-17fa-4c71-8679-a0032cdcee1d"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRbShsNR-wcUaPKBv2NxLSeE6arTMAMGZNs5L219VYdIxUapVJc" },
                    { new Guid("d01107a8-1dcd-4e3a-a70e-537765bea81f"), new Guid("eaf24398-c4db-4173-a4fb-069405a2237c"), null, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/O7_logo-red_cmyk.jpg/1200px-O7_logo-red_cmyk.jpg" },
                    { new Guid("73c71ead-d984-49f3-8aaa-fff1c8b9aaf0"), new Guid("1e30023a-785e-4174-8902-554d4219825e"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS3aHsnIsbz6CxKRg5tmpq73iNWV6J65niLvsEs9tKf9feje5iv" },
                    { new Guid("0b049003-5645-49d6-ba03-90579133d733"), new Guid("01acf015-02d1-4928-a744-2f367fb4467c"), null, "https://www.kiloo.com/wp-content/uploads/2017/03/sharelogo-2.png" },
                    { new Guid("044780c6-4922-433d-8079-247db0906336"), new Guid("a88aedcb-3194-4134-ba33-87705b7d0e10"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdbIPf6EeERMGnyQoYkE4xUMuaU22OEtWLEfHWjAw6vxzGJ5oq" },
                    { new Guid("42c7a2d0-2c40-47e3-b82b-3ae361fa38de"), new Guid("0978db77-feb9-44da-ba42-7b090bf1a2b3"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQkyOmWOFhXD1lRsMIHkAJrLIvjwmImH1GBwlmqb3I5ysGUNY0-" },
                    { new Guid("26865156-3355-4f88-b366-d8e15de4f016"), new Guid("fa7a84d5-6714-4c02-a862-bcdafb1215e3"), null, "https://upload.wikimedia.org/wikipedia/vi/thumb/2/2a/ZeptoLab.png/200px-ZeptoLab.png" },
                    { new Guid("326b6683-bd4d-48a0-a820-4f2a32862e04"), new Guid("5fc4b001-02bb-4003-ae00-8569cad63b2c"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSE0L-3DI9ruta232UcPOIlvnE3I3xV-8l1u_C3Grzx6tmXrDzs" },
                    { new Guid("2732c7c3-4c0b-4091-ab8a-a825a2d870d1"), new Guid("7babea71-e324-4757-9b51-d670e95d2d83"), null, "https://upload.wikimedia.org/wikipedia/vi/thumb/2/2a/ZeptoLab.png/200px-ZeptoLab.png" }
                });

            migrationBuilder.InsertData(
                table: "CategoryGames",
                columns: new[] { "GameId", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("49e0b07d-788f-4d98-b1b3-3b4f7b832d07"), new Guid("379789b3-6683-4556-8561-83fdd95588a2") },
                    { new Guid("8855c982-5d2c-4ca3-ba42-878b5e1b5b46"), new Guid("eaa9fe31-f37c-428c-9f73-31ccb62d61c9") },
                    { new Guid("af30a151-e176-4331-92c2-f1240b2d58e5"), new Guid("659fe1d9-c8d0-40b9-ae1b-dab7175c1e9a") },
                    { new Guid("e6b6afa3-f3b2-4f77-85bf-b48d3afb7610"), new Guid("f749149d-1913-498b-bf64-5919ff83a3d7") },
                    { new Guid("edbd4af9-724b-4d7f-a9b8-025a35506759"), new Guid("5312e272-af9b-451c-b6fe-30720828e6f0") }
                });

            migrationBuilder.InsertData(
                table: "FreeCodes",
                columns: new[] { "Id", "Code", "GameId" },
                values: new object[,]
                {
                    { new Guid("6ff12af0-762d-4204-b9fd-749052b3d727"), "49a25d6d-9f6b-42cb-b80a-7cdb02e15b63", new Guid("8855c982-5d2c-4ca3-ba42-878b5e1b5b46") },
                    { new Guid("33c48cf7-4b72-4e47-b412-e7d3a74c121d"), "c0abd9bd-15cd-4fd6-ac11-100653513111", new Guid("e6b6afa3-f3b2-4f77-85bf-b48d3afb7610") },
                    { new Guid("6223cf58-4e9a-47ed-9684-fa8c3b208c63"), "9438dc3b-114b-4ae5-9ed5-ec1950c7e6f5", new Guid("af30a151-e176-4331-92c2-f1240b2d58e5") },
                    { new Guid("d95dfd8b-201a-4ead-8846-162bff122b03"), "5f30ab72-9181-455c-b789-f308e0d64191", new Guid("edbd4af9-724b-4d7f-a9b8-025a35506759") },
                    { new Guid("2ff9ff8b-f1fa-4c5d-919b-b3aa43163bcd"), "e6f1e576-ae52-4a1f-9d71-964d6f383f85", new Guid("49e0b07d-788f-4d98-b1b3-3b4f7b832d07") }
                });

            migrationBuilder.InsertData(
                table: "ImageGames",
                columns: new[] { "Id", "GameId", "UrlLocal", "UrlOnline" },
                values: new object[,]
                {
                    { new Guid("d2e98be4-7aae-404d-9caf-9b1db3ee2d6f"), new Guid("7ca43f6f-2ba8-4d47-8b8e-ad1fe5b9f952"), "", "https://lh3.googleusercontent.com/Qnm85mIcd32-R8IxmDXM1MPgCfpM2-duddE7P_iS55P0xFO6ZM9jo9dt6PThjWhZvw=w720-h310" },
                    { new Guid("5772d687-e5e1-47ca-90e5-9e2ebf050b6e"), new Guid("af30a151-e176-4331-92c2-f1240b2d58e5"), "", "https://lh3.googleusercontent.com/ucBNG7Vj8Lqo8b14PUMyzB8h7f2YcZ9oKB6BuFaJTgCj4jEv3Zo1jFPg-FjdONrw8c7b=w720-h310" },
                    { new Guid("731571a4-4a9a-46bf-a1ba-336172fd0753"), new Guid("ce81f4be-fbaa-4699-b7b9-4a1cc1b3f1a5"), "", "https://lh3.googleusercontent.com/Z_KPg-BqbZVMMLlH689YEwzPefUXW0l_7MfPS8-KUzDV4-y-VeSfnswbSXakPJfoJw8=w720-h310" },
                    { new Guid("b0f0590d-fb92-43e8-8f7c-ac38e696853d"), new Guid("ce81f4be-fbaa-4699-b7b9-4a1cc1b3f1a5"), "", "https://lh3.googleusercontent.com/uJK2kFV81mdNGWE9nDO__wadnVhC8afhQourrne9WhOy0ip1UjlsElsw9xd0BV3NCG8=w720-h310" },
                    { new Guid("e7946d18-3439-48c9-b6d5-a9ff9bc25b2a"), new Guid("3b9f0257-e181-4c29-bb03-6c8f76a46bb6"), "", "https://lh3.googleusercontent.com/5W6OOrho0AFit_nm98QqpCsu52uHc-kw7RQPK4_PUdGEi6DjrmfZdPJIGYl2u_3Ibw=w720-h310" },
                    { new Guid("9a851953-2bfd-4542-a982-648ed5cfaffa"), new Guid("3b9f0257-e181-4c29-bb03-6c8f76a46bb6"), "", "https://lh3.googleusercontent.com/5W6OOrho0AFit_nm98QqpCsu52uHc-kw7RQPK4_PUdGEi6DjrmfZdPJIGYl2u_3Ibw=w720-h310" },
                    { new Guid("ea6598e8-439d-4211-a2b8-9ee6b4d50acc"), new Guid("3b9f0257-e181-4c29-bb03-6c8f76a46bb6"), "", "https://lh3.googleusercontent.com/qSl0aQ-tQiBC_Ut0MC3n-I3HTgQsDQ52XUq_cnfu5rq9kyDSBs2vneGXZZ-PhVv8yb22=w720-h310" },
                    { new Guid("73fa3b48-8a97-4a69-987b-78210c883d9f"), new Guid("3b9f0257-e181-4c29-bb03-6c8f76a46bb6"), "", "https://lh3.googleusercontent.com/nNjmESXQm2dJupXjwYn9RvD6nhS6_5bAthB6GrjrHCdaoiftDAKABIEOBJd3paXCYg=w720-h310" },
                    { new Guid("1950a298-8bbf-419b-b117-09c07ea32786"), new Guid("af30a151-e176-4331-92c2-f1240b2d58e5"), "", "https://lh3.googleusercontent.com/EFv_aMUrdXQLXLesEfQAuFv9bNvQ5hwzYnuKZ1cr_OBDZU6cY6OZhIiDzfhx4eSuvtI=w720-h310" },
                    { new Guid("b75a7244-a830-4861-8a67-703ab9c41072"), new Guid("e33aaab3-48c3-477e-beae-c939bfd213e5"), "", "https://lh3.googleusercontent.com/NdRmiugakoZ-CgyoqeEd7SC9xT_xFIfjY3LtjMifJ9_iKsUdzA5WgBrs2cgoAK3d_CNr=w720-h310" },
                    { new Guid("2bc92faa-071b-442a-b6eb-6b5713baa839"), new Guid("7ca43f6f-2ba8-4d47-8b8e-ad1fe5b9f952"), "", "https://lh3.googleusercontent.com/uFYADCilcHxlddeBXKAAu9HNzQG0Mx1VqwuwGQg3WiXBZAg41hooWQTAUilvZetyYhqy=w720-h310" },
                    { new Guid("1c14fd0c-9a82-46ea-b228-1a3993cd6e49"), new Guid("e33aaab3-48c3-477e-beae-c939bfd213e5"), "", "https://lh3.googleusercontent.com/A4POGA0IPwbcaSj5dba5zrn6tUlCiyvu4ppse912kWUzr084-qqgvCT0m-E99RPi228=w720-h310" },
                    { new Guid("5f468c8a-92d1-4ae9-8536-884486cff21e"), new Guid("e33aaab3-48c3-477e-beae-c939bfd213e5"), "", "https://lh3.googleusercontent.com/PeX7REevxeIec-hxFckCJP0xyg88TEzwPh4zz2Prv08d-0UsspP6wcoaBXYJqWzkuQ=w720-h310" },
                    { new Guid("8736ce50-4758-4c07-b304-c701012725c1"), new Guid("7ca43f6f-2ba8-4d47-8b8e-ad1fe5b9f952"), "", "https://lh3.googleusercontent.com/cOijr_HBBvrjn7t00qwPQiXJ2y53NMSMI4iF2YSH89RDlmpe_MbppoqJmXTyIUPCj7M=w720-h310" },
                    { new Guid("751e2e0c-ee59-4ca6-a7d8-1ad628d4d797"), new Guid("7ca43f6f-2ba8-4d47-8b8e-ad1fe5b9f952"), "", "https://lh3.googleusercontent.com/Kri8NpWg8Nt5BmgNxbMCrW4vxk7LqzjpvibCYHb24_RJgS-l58n-gFR2f4RE_uGfuKI=w720-h310" },
                    { new Guid("74101653-8a52-44df-96b6-82bbc7062c34"), new Guid("e33aaab3-48c3-477e-beae-c939bfd213e5"), "", "https://lh3.googleusercontent.com/YL2_i-PixRM-qYfrZ6CpAqyNiXW_MrIx2KFyg2zZLkdjjosIK5qyPg1dfbyTAC-BdNg=w720-h310" },
                    { new Guid("d6f42464-1fab-4923-b93f-8a9db9992d83"), new Guid("ce81f4be-fbaa-4699-b7b9-4a1cc1b3f1a5"), "", "https://lh3.googleusercontent.com/CjrXpLQr5ixH5K9RjdL4CFLhmfgkVCJVAw0bhOuFuFI0v4IaQyt1zbXLVxKfGz2l246x=w720-h310" },
                    { new Guid("44ab8632-b9f4-4328-9612-cafae784e4e2"), new Guid("c37f7425-6f2c-47ad-966d-1391396eb096"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("b50c33ba-ec55-4914-a5fe-56899056c449"), new Guid("c37f7425-6f2c-47ad-966d-1391396eb096"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("d254c653-1dd8-4e2f-a8d6-5a6d501f81a9"), new Guid("0a9696ca-4487-4cef-ab9c-cc8541d9d5c3"), "", "https://lh3.googleusercontent.com/zRs9fTN-tL-p4yNL3ccFr1w3wUH-hqN0ShgwAnbzcnH2FidymdlixdDN-lpqF3xck4I=w720-h310" },
                    { new Guid("347ebc91-08fe-4f7a-91a1-c8bb7d95fad3"), new Guid("0a9696ca-4487-4cef-ab9c-cc8541d9d5c3"), "", "https://lh3.googleusercontent.com/o0i5z7sG2EArHccVaOCYU516s3PzflywGTbzf3ylRoZwOizKm-jH2AKwXweh2_77Tw=w720-h310" },
                    { new Guid("8a8aa0aa-a097-489a-82c5-8acf08134f7a"), new Guid("a1f50b53-7e4d-4071-8896-d23b4d2590c9"), "", "https://lh3.googleusercontent.com/JMc16QhAhKFbnW2jusl-T6xu8xo31BDzv8h7APyDdU006PkYvtk3q3Ey76LU-G908M0=w720-h310" },
                    { new Guid("86a9c585-1f65-4dc0-8015-54d3b10407d8"), new Guid("a1f50b53-7e4d-4071-8896-d23b4d2590c9"), "", "https://lh3.googleusercontent.com/RdxHjaoI2WK-ku4--LmPMaZ6DkLVYt0q9IKiSrdqXnmMKlPo4hgZHf0VdN8Oee5pxg=w720-h310" },
                    { new Guid("5783c361-c095-4c31-a041-343ae222ca5f"), new Guid("a1f50b53-7e4d-4071-8896-d23b4d2590c9"), "", "https://lh3.googleusercontent.com/YYz6o1qMBxop37bvU1rfACXRv1AS-gNHOCjUW9lp6eLDV7BQAZ7zUIkG3PF597svP4gP=w720-h310" },
                    { new Guid("28c48915-79cf-4415-ab63-4e75364c37c5"), new Guid("a1f50b53-7e4d-4071-8896-d23b4d2590c9"), "", "https://lh3.googleusercontent.com/Ziiu3YNdzaoJf7_rdy9tk7pbPiPlluFvA_JdU0FtzqlvZuLrfyuWNnfkRtMvxq4_lA=w720-h310" },
                    { new Guid("2a96fb6d-9ac3-482d-981e-e56e096f1262"), new Guid("1dd392d5-4956-401b-a59a-c48307f7e6f2"), "", "https://lh3.googleusercontent.com/ClxJrJjyrjj5uaAxZvSaQcjjRfeCta4_otNRCsGJacfFptfTtamCUJpQ0hcQWOd8u-Q=w720-h310" },
                    { new Guid("72319556-626b-48c8-8a64-5545335b1703"), new Guid("1dd392d5-4956-401b-a59a-c48307f7e6f2"), "", "https://lh3.googleusercontent.com/JIvkWPFnKbYeVV5h3AxjMgR9ogQ2a0vMQgCp5B3JP4dEXU4zIR40H8ROTg8WkPrjcEA=w720-h310" },
                    { new Guid("a6e63fc2-5e29-4547-8c41-59902fd83de5"), new Guid("1dd392d5-4956-401b-a59a-c48307f7e6f2"), "", "https://lh3.googleusercontent.com/d0jf4r7KjWBCzi2GELWFSf6MaJIHepkJIN8JYT8g0tSIThiH_W6FhUnHjBN_fYdl3Q=w720-h310" },
                    { new Guid("92af5c7a-fb64-4fcd-8f2d-5809c1902a0b"), new Guid("ce81f4be-fbaa-4699-b7b9-4a1cc1b3f1a5"), "", "https://lh3.googleusercontent.com/HteHDUkzuMjCEHM1B-3jvLqlbBYtJZFWiHm-vf47YcE7QiInhXn2O-LkYPxvzPnPGA=w720-h310" },
                    { new Guid("15b74d79-4647-41eb-949e-fc1a58ff201e"), new Guid("1dd392d5-4956-401b-a59a-c48307f7e6f2"), "", "https://lh3.googleusercontent.com/UbTWxlQujVdxOaYqy_FmC4LRBlm_wSUgQe0wIM0BSXeGUZ0Vzle9OTWNNs4wk8nOKI4=w720-h310" },
                    { new Guid("a201c8b2-2479-4945-b74d-2b568f22fb97"), new Guid("852b4b74-05aa-4ba8-9a07-88f49c7d6e93"), "", "https://lh3.googleusercontent.com/jCNaOtE_9-Zcs9r5MFtGzaxO8xNz3UYEcB3XdPe1oLO3X6PH-hYEspWnR26lUZef_5A=w720-h310" },
                    { new Guid("ec74ef60-5773-4a0f-9291-be6e127255f9"), new Guid("852b4b74-05aa-4ba8-9a07-88f49c7d6e93"), "", "https://lh3.googleusercontent.com/d6CY2BSvBXFLK8J3WqJEdDr53_OZ43Aijr43CjG1QKUfHXt4E_zDNBZWoMqkxONzOQ=w720-h310" },
                    { new Guid("2dc1e860-3235-40d2-8d09-c00c9c86ada6"), new Guid("852b4b74-05aa-4ba8-9a07-88f49c7d6e93"), "", "https://lh3.googleusercontent.com/L615QU2G2qxv68di7WqB4V40mDsOgko4iKmz-NB6SzwLejM8x4i2CbAqgkIxBqZ3A9M=w720-h310" },
                    { new Guid("24f01c03-8a3a-4685-87ad-230effa65750"), new Guid("34855cdd-9412-47a0-8157-b3554c5e8457"), "", "https://lh3.googleusercontent.com/9lQV-3IWYXkSndN4GsVQTflvUCSKPMj-uSuH9tEd8FlHuBOslA52Q-Z7wEEKmhwuxJE=w720-h310" },
                    { new Guid("0563c6b5-d372-48b0-8b0c-45a24db7e19d"), new Guid("34855cdd-9412-47a0-8157-b3554c5e8457"), "", "https://lh3.googleusercontent.com/3HUpkFFcnCkLbgUosodwIrfzzq3VkebxVQkjfa_uDhapJyrz0ATxq6wRyYpyxKauyg=w720-h310" },
                    { new Guid("c22719a3-769c-454d-bb61-9246fa89a72c"), new Guid("34855cdd-9412-47a0-8157-b3554c5e8457"), "", "https://lh3.googleusercontent.com/JJNpXkj5HNkscW_bmZ1yGu-GuakL4Q4zRwOPmACFaqbIT5C2HMaI4LwhjGNiIrup_Ew4=w720-h310" },
                    { new Guid("6028b7c2-e8c1-4cba-94c2-f360ac6d0e6c"), new Guid("34855cdd-9412-47a0-8157-b3554c5e8457"), "", "https://lh3.googleusercontent.com/aU5RuCIDy7JzNtp5ib2huaa1t33TVY_zdsES_ooMWSwY6K1JnHG0HC9RK0OgVuXqs9U=w720-h310" },
                    { new Guid("970d6554-70d0-48ee-a3c1-2faf9d881be6"), new Guid("c37f7425-6f2c-47ad-966d-1391396eb096"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("06783611-a213-425b-a8ab-3b54cac54033"), new Guid("c37f7425-6f2c-47ad-966d-1391396eb096"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("0e31fb59-2d1a-4866-aacf-d4d5d627d488"), new Guid("852b4b74-05aa-4ba8-9a07-88f49c7d6e93"), "", "https://lh3.googleusercontent.com/sCw3rT7aK1z589o_MBBn1JzVd7fYC1-fWkYV2Tz4eDfCDTi49dS9tOFBLqBrd_XwQCc=w720-h310" },
                    { new Guid("001cb13b-76c3-4451-907f-6444f65cdd01"), new Guid("af30a151-e176-4331-92c2-f1240b2d58e5"), "", "https://lh3.googleusercontent.com/xaL3b80wmBVOrpH-q_DX8F5kKsASHH8Fllf3u65TsS0zs9_y0J4DWKJj5T9QVAWuT3Rn=w720-h310" },
                    { new Guid("58ded9ec-0051-416b-92f3-c7dc0cc7c1f7"), new Guid("b09cd91d-bc47-4791-b541-dbbfd5082f67"), "", "https://lh3.googleusercontent.com/Ibj-Kt-6Pc1IBDVj0yWf1sNjSpdGpRlapbTbjc5MuitmDkoKVMP45GF0LBlg6pnIbYE=w720-h310" },
                    { new Guid("7a2af51f-d5e9-4d29-bf45-0039541f5edc"), new Guid("0a9696ca-4487-4cef-ab9c-cc8541d9d5c3"), "", "https://lh3.googleusercontent.com/AinG9y8hyEb_p2B6Rg8-iOVjYR7EcsGDmv_rThdnfzgkBjbukLIT4mWFOg5ObAO4RMq0=w720-h310" },
                    { new Guid("66f13ef2-8100-4005-947a-f1db6c56c99b"), new Guid("bce51996-00b6-4b1c-a6d1-d0f4a1fd4891"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("a4d6466e-5966-4c13-b7fc-1ba585d218d2"), new Guid("bce51996-00b6-4b1c-a6d1-d0f4a1fd4891"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("9847f69a-cb99-454d-a1cb-d47c8d93a897"), new Guid("bce51996-00b6-4b1c-a6d1-d0f4a1fd4891"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("1fc5821e-69e6-40f7-a3b1-7914245013bb"), new Guid("bce51996-00b6-4b1c-a6d1-d0f4a1fd4891"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("616e9873-bed7-46e7-8328-c36de6450537"), new Guid("edbd4af9-724b-4d7f-a9b8-025a35506759"), "", "https://lh3.googleusercontent.com/UY9fte3alDnv-cZ94Jx27Lf4g9FUT2395jhXPScEllshpdCO4zfnuWrTNtO1FVRt3w=w720-h310" },
                    { new Guid("39700eb2-c38f-4047-91a7-609a55f4ccc8"), new Guid("edbd4af9-724b-4d7f-a9b8-025a35506759"), "", "https://lh3.googleusercontent.com/-BUT6NCVxZsPPjsUW8zdrVk4XLMRuE_oWSTwaXrAPYZbBsMKBfqXxOVI7OowXxoLwa8=w720-h310" },
                    { new Guid("532a733f-8d5d-42aa-b1a6-017b06855d7d"), new Guid("edbd4af9-724b-4d7f-a9b8-025a35506759"), "", "https://lh3.googleusercontent.com/MwNuIIzmxxJgM8JeNi2aBhpE-kNnXBGOVPRb_gZoRE-gel5q9ZP7mrQfTT_9xzV8dz4=w720-h310" },
                    { new Guid("35b32b0b-5c12-448a-a08b-f323fed6b2d4"), new Guid("af30a151-e176-4331-92c2-f1240b2d58e5"), "", "https://lh3.googleusercontent.com/gFZCgWFd8-oR8zu2ApqRWk6dgwIkDM8jex4MxbA-MdiYgfpHJlkAcPBCZX5czXgddA=w720-h310" },
                    { new Guid("1a45206b-7444-48ec-8164-03a4c12f376a"), new Guid("edbd4af9-724b-4d7f-a9b8-025a35506759"), "", "https://lh3.googleusercontent.com/mfGdhejubeU1m1Pkj2vpWMLTlLMhnQz0f2Z8M79g6g0thY9cDyHggntmd_A7ckZPGVM=w720-h310" },
                    { new Guid("6fe16c65-a200-4f7d-b75e-1fb8170dc13b"), new Guid("ac90d80a-1d99-44bb-88b2-be761df65c43"), "", "https://lh3.ggpht.com/y7On3vVZhFWycuekTPLwARYJ3MwQyODIzKHRt4ofyeS_gmXRDF271NsFDfu_lLhlX2Rj=w720-h310" },
                    { new Guid("cdcddf2e-f859-4e35-9520-815ca2554394"), new Guid("ac90d80a-1d99-44bb-88b2-be761df65c43"), "", "https://lh3.ggpht.com/y7On3vVZhFWycuekTPLwARYJ3MwQyODIzKHRt4ofyeS_gmXRDF271NsFDfu_lLhlX2Rj=w720-h310" },
                    { new Guid("a757c5b6-440d-4725-8dd8-d56762442bd1"), new Guid("ac90d80a-1d99-44bb-88b2-be761df65c43"), "", "https://lh3.ggpht.com/y7On3vVZhFWycuekTPLwARYJ3MwQyODIzKHRt4ofyeS_gmXRDF271NsFDfu_lLhlX2Rj=w720-h310" },
                    { new Guid("762d4d77-88ae-4e05-b356-c97ee9699c4d"), new Guid("49e0b07d-788f-4d98-b1b3-3b4f7b832d07"), "", "https://lh3.googleusercontent.com/h4JQOfS4vmim_WhTHeC3RGxtY8eoFG0fgtgsWWk6VvVSrjnjtlgSFzR6sW0hzbncWA=w720-h310" },
                    { new Guid("ba34c5d3-aead-4807-a2bf-7affa82827d2"), new Guid("49e0b07d-788f-4d98-b1b3-3b4f7b832d07"), "", "https://lh3.googleusercontent.com/oMcH_a4lXShvowzyaiQpE0_MhYWZvdN9RkaYLtkdnw_rlDR_uHbHj9Eu2zbrvyOAXHQ=w720-h310" },
                    { new Guid("03cb5f3d-8302-40a2-a617-0ddad92466a4"), new Guid("49e0b07d-788f-4d98-b1b3-3b4f7b832d07"), "", "https://lh3.googleusercontent.com/Ia1psbcXgeCV9FBZk1b08QnxC-uSHCgJ112VeJZB19_F2Q-m_w3Z7P_OjFStnYM3LaCC=w720-h310" },
                    { new Guid("a41d4686-5fe0-49db-ab29-7cbd12c2945e"), new Guid("49e0b07d-788f-4d98-b1b3-3b4f7b832d07"), "", "https://lh3.googleusercontent.com/vInYRcyjzVjBFfY4HIGLLf-tSLK9S55HjUbmQuxmrbpVpItV3AfyuxVMFGASoDdMHc4=w720-h310" },
                    { new Guid("336e59f1-3a7f-4648-998d-77174c1aefb1"), new Guid("ac90d80a-1d99-44bb-88b2-be761df65c43"), "", "https://lh3.ggpht.com/y7On3vVZhFWycuekTPLwARYJ3MwQyODIzKHRt4ofyeS_gmXRDF271NsFDfu_lLhlX2Rj=w720-h310" },
                    { new Guid("14531490-c23b-4d52-98b9-f70061c4f424"), new Guid("dda245ad-8348-4b7d-b7ea-2bf0a803f54b"), "", "https://lh3.googleusercontent.com/FMgP9XZNML3lieBG9KDgiJGnT2WlmHMG5lFGcAl0rk93GtGFjf9X2J6vxcCCElNPJDw=w720-h310" },
                    { new Guid("f1fd6590-7fab-4374-89ed-3d9e8c9f0b12"), new Guid("dda245ad-8348-4b7d-b7ea-2bf0a803f54b"), "", "https://lh3.googleusercontent.com/DQppPRLU04SzwExhZTIKsYL1y3iZXzRsZbTBrmHJqJO1aTCsApHGdYxTKt3dvkN7ctRb=w720-h310" },
                    { new Guid("9fdf6066-e408-4ae5-84e1-a7bfa19b6973"), new Guid("dda245ad-8348-4b7d-b7ea-2bf0a803f54b"), "", "https://lh3.googleusercontent.com/-oRMqwODzaru2JCxLf3JtHVZXtpYfQ8Qo0IQRbRsZtssH6dUGr51WMfH0j3eMrfO5w=w720-h310" },
                    { new Guid("28040f53-13da-4087-892d-8cc97e9955cd"), new Guid("b09cd91d-bc47-4791-b541-dbbfd5082f67"), "", "https://lh3.googleusercontent.com/W_3i_ZHnSjan-N8egYQy9sQw87CppDDda9ITzTIQyTFHZpO2VJlhCzP_BORM3Hd-CDw=w720-h310" },
                    { new Guid("46041067-7cdb-461b-84df-c1123493666b"), new Guid("b09cd91d-bc47-4791-b541-dbbfd5082f67"), "", "https://lh3.googleusercontent.com/RhBTJ2IEOhtPEbOpmMTxfMC9iU06JihtylD-lQxbTrIPfT2U-B0YLAjGELbj2Ppk1w8=w720-h310" },
                    { new Guid("f334a747-8f44-4c5f-a49d-c5907decfec5"), new Guid("b09cd91d-bc47-4791-b541-dbbfd5082f67"), "", "https://lh3.googleusercontent.com/nlXezemMS359X8dy6MxUJMgumyw6abz15NX0CjtnT8V57vni_uuS3saDllIMeyfQ6e-6=w720-h310" },
                    { new Guid("be6e9831-4573-4e7d-abf2-60e673d900b6"), new Guid("e6b6afa3-f3b2-4f77-85bf-b48d3afb7610"), "", "https://lh3.googleusercontent.com/aosNkyZihAba_VF_HRKOUMGFuK5SxNcZMMvYIAXufiG8znXvrxJ_7jMgmP2E01CapoQ=w720-h310" },
                    { new Guid("09dd4b82-ccd2-40e2-aa5c-ebeeda90822c"), new Guid("dda245ad-8348-4b7d-b7ea-2bf0a803f54b"), "", "https://lh3.googleusercontent.com/wzk-BPRwz5Lrh2YZ66uEJb8JjXkFE8oVm4RpZVTmWsCcx1e1nxP3XBhqr2q9Iff7Xica=w720-h310" },
                    { new Guid("a5f50aa4-4563-4b7b-8ff6-daae8895601e"), new Guid("e6b6afa3-f3b2-4f77-85bf-b48d3afb7610"), "", "https://lh3.googleusercontent.com/Km7Il6ij6xZBtWJPSpEacmz8dC2C9WACUuf37VdjIYaXWaPaC6WWWmx3T8aaNgNkJaBx=w720-h310" },
                    { new Guid("a11c3c6d-eedc-48a4-a91d-5e72c2425b66"), new Guid("e6b6afa3-f3b2-4f77-85bf-b48d3afb7610"), "", "https://lh3.googleusercontent.com/tk_p7dIHQBEBeYiVkFaPcU_5bd3fOhE8HerKp4Ei0cTyxVoVDdd_QD0SLPJeJrSm4c4=w720-h310" },
                    { new Guid("90f3a0ae-8a95-48cb-aba2-9eda4585f7f0"), new Guid("e6b6afa3-f3b2-4f77-85bf-b48d3afb7610"), "", "https://lh3.googleusercontent.com/Zsth8maheotaUA0he3vGtWmm11dWsEsLlffOsvzGX65Sp4nXNAuKSx-Z96f8as3twQ4=w720-h310" },
                    { new Guid("9768d12b-0a45-4597-b0c5-897429ed8954"), new Guid("8855c982-5d2c-4ca3-ba42-878b5e1b5b46"), "", "https://lh3.ggpht.com/GqnDETqoUP17xJg0cQ3pyEHsgO-KLjx-MbJ0Mcwg4Lvd2PnEO-JARZhYtfd8AYwjEew=w720-h310" },
                    { new Guid("c8501585-ef56-4c3c-92cd-50d2ed79de14"), new Guid("8855c982-5d2c-4ca3-ba42-878b5e1b5b46"), "", "https://lh3.ggpht.com/Vbi7XVMzoCMoAyHFhJlziKjldN5F-Mkp4EOf5YyiMOPsd-of4ckac2BzPAiKGIveSI4=w720-h310" },
                    { new Guid("3c30b9c2-f5e0-412d-96b9-a0cc0310010e"), new Guid("8855c982-5d2c-4ca3-ba42-878b5e1b5b46"), "", "https://lh3.ggpht.com/AZ2OkTlsJuqUvCP8IQKwkCg7Fv56FRAb_CV8bXRsR15Ayre8fmWJrkr4RCIvx1wYoktm=w720-h310" },
                    { new Guid("36711703-beb7-4b76-b492-a578ed6cfa05"), new Guid("8855c982-5d2c-4ca3-ba42-878b5e1b5b46"), "", "https://lh3.ggpht.com/WRg7Mzp5FM-cSiKGb7TbzgeYBY8oMSV4Vgn35XYHDbejbNkWM7lNgqFeQjMlNAZoUX7Z=w720-h310" },
                    { new Guid("dacfc91f-8bd9-429c-ba3f-71b426ba0b11"), new Guid("0a9696ca-4487-4cef-ab9c-cc8541d9d5c3"), "", "https://lh3.googleusercontent.com/WJIWdX6YPms3-diI1TPcCPtgv_YGH2QNMGqOXLK-ta5FLulrZps4KObsB1-frjU6syA=w720-h310" }
                });

            migrationBuilder.InsertData(
                table: "UserGames",
                columns: new[] { "UserId", "GameId", "PurchaseDate" },
                values: new object[,]
                {
                    { new Guid("a7200ea4-1d44-46ec-bdf2-6dc374f0a262"), new Guid("edbd4af9-724b-4d7f-a9b8-025a35506759"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ddba090e-df80-4e6a-a801-8ce821ca5a7d"), new Guid("8855c982-5d2c-4ca3-ba42-878b5e1b5b46"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7919440e-afd4-45d3-89b4-ce81f6c23b03"), new Guid("e6b6afa3-f3b2-4f77-85bf-b48d3afb7610"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5aa91776-8e20-4c3e-a5ff-72fb13ef03d5"), new Guid("49e0b07d-788f-4d98-b1b3-3b4f7b832d07"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b96e3db-1909-4e4c-a254-75051a5e0a49"), new Guid("af30a151-e176-4331-92c2-f1240b2d58e5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "WishGame",
                columns: new[] { "UserId", "GameId" },
                values: new object[,]
                {
                    { new Guid("a7200ea4-1d44-46ec-bdf2-6dc374f0a262"), new Guid("edbd4af9-724b-4d7f-a9b8-025a35506759") },
                    { new Guid("7919440e-afd4-45d3-89b4-ce81f6c23b03"), new Guid("e6b6afa3-f3b2-4f77-85bf-b48d3afb7610") },
                    { new Guid("5aa91776-8e20-4c3e-a5ff-72fb13ef03d5"), new Guid("49e0b07d-788f-4d98-b1b3-3b4f7b832d07") },
                    { new Guid("4b96e3db-1909-4e4c-a254-75051a5e0a49"), new Guid("af30a151-e176-4331-92c2-f1240b2d58e5") },
                    { new Guid("ddba090e-df80-4e6a-a801-8ce821ca5a7d"), new Guid("8855c982-5d2c-4ca3-ba42-878b5e1b5b46") }
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
