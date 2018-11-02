using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStore.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("0291eb80-a898-4dcd-a846-3475786ff3bf"), new Guid("db85a760-21a8-40dd-a422-1f92ecd8b4f2") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("276b25c4-7c11-4f5c-8da5-952331eab059"), new Guid("ff6f33a2-39b7-417b-b16f-da06bd526b23") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("85db9c3e-0dc3-495d-9b56-04bc61506685"), new Guid("f19c57cd-9df9-47fe-bd6d-5ff88ecb861d") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("992b1dc7-829a-417b-87a4-7ac103cb9199"), new Guid("390b789c-f4e7-4f7d-9882-203618142c88") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("d8938522-0605-4209-a540-32395cc8d833"), new Guid("e2d1cb35-efdc-4c26-b74e-79fb39d2150c") });

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("21b65ef7-9530-4d65-9665-806559a70331"));

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("9cf74a9d-ef74-49a4-92c6-f393b1c16da9"));

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("aa286cc3-dc47-4c76-bfc9-22114d3f2384"));

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("bb717a87-0571-41e2-9c09-d4b5482a264a"));

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("eee84308-a10b-4807-8fe3-2f52f16d63d0"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("057d9225-6c61-4815-a80c-96fb280de429"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("276f1de9-c5f1-42c7-8aed-e507d6bae821"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("27e50ead-ffd1-474f-941d-56f4c88cad3d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3b67129b-c490-44ab-a72d-976353d79ebb"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("469d7595-4311-45a2-98ac-f2ae78215335"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("603e3423-2690-4601-8c05-6217e95aaa13"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6ad4ec49-8b0a-4e66-9aa6-e7a4274bd969"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("71b52a7f-d63a-484e-9c85-13eba911559a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("853cbdd6-2a76-4601-91a2-e7c23685c853"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("99586dc1-27a2-4afe-92f2-ce19171e84ef"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("c378ead8-6c5d-4f2a-a087-372760b967d0"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ccb3a8f1-3d83-4d08-bf3c-3da91dc86513"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f4397b7d-2c1e-42db-8b3a-47448702a748"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ff70826c-8e51-451a-bb00-928bd3ac5c0a"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("c822d579-a881-40fc-a829-448941da5d77"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("e6bf3202-40c6-430e-a3a0-a0846f3c2356"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("f2c500c3-ce71-485e-9f01-a3a4a85acea9"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("a9ac8e60-1567-4be6-8703-34410be84c38"), "User" });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("c404b6e0-05cc-4de2-a045-28841a63e392"), "Admin" });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("7b103927-28b2-4d94-a855-1b4affbf6948"), new Guid("276b25c4-7c11-4f5c-8da5-952331eab059") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("7bbe887b-75cb-4c49-b07e-3029d528b7b2"), new Guid("0291eb80-a898-4dcd-a846-3475786ff3bf") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("d61784d1-f996-4f96-8694-3c2a4724116f"), new Guid("d8938522-0605-4209-a540-32395cc8d833") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("dc7fdfaa-16be-48b2-8a42-813b7d6cd18f"), new Guid("992b1dc7-829a-417b-87a4-7ac103cb9199") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("ed75e64a-9d3c-443b-9cec-40daae6129f6"), new Guid("85db9c3e-0dc3-495d-9b56-04bc61506685") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("7b103927-28b2-4d94-a855-1b4affbf6948"), new Guid("276b25c4-7c11-4f5c-8da5-952331eab059") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("7bbe887b-75cb-4c49-b07e-3029d528b7b2"), new Guid("0291eb80-a898-4dcd-a846-3475786ff3bf") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("d61784d1-f996-4f96-8694-3c2a4724116f"), new Guid("d8938522-0605-4209-a540-32395cc8d833") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("dc7fdfaa-16be-48b2-8a42-813b7d6cd18f"), new Guid("992b1dc7-829a-417b-87a4-7ac103cb9199") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("ed75e64a-9d3c-443b-9cec-40daae6129f6"), new Guid("85db9c3e-0dc3-495d-9b56-04bc61506685") });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("390b789c-f4e7-4f7d-9882-203618142c88"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("db85a760-21a8-40dd-a422-1f92ecd8b4f2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e2d1cb35-efdc-4c26-b74e-79fb39d2150c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f19c57cd-9df9-47fe-bd6d-5ff88ecb861d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ff6f33a2-39b7-417b-b16f-da06bd526b23"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0291eb80-a898-4dcd-a846-3475786ff3bf"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("276b25c4-7c11-4f5c-8da5-952331eab059"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85db9c3e-0dc3-495d-9b56-04bc61506685"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("992b1dc7-829a-417b-87a4-7ac103cb9199"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d8938522-0605-4209-a540-32395cc8d833"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("49b359ec-f164-4554-88a6-ab63eba0b0cc"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("78219330-10f7-42bf-956f-78ef88586abe"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("94270087-1093-4e81-baa7-98d2bd4b6fb6"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("e583d217-d55f-4a8f-8f99-c0efb9d3ea57"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("7b103927-28b2-4d94-a855-1b4affbf6948"), "e7ac42a5-1d29-4828-a160-2ab55c7e1fc9" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("7bbe887b-75cb-4c49-b07e-3029d528b7b2"), "62d9ec2d-a3e4-4420-92a4-e98f6eb07690" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("d61784d1-f996-4f96-8694-3c2a4724116f"), "a047e33a-4924-4054-828f-da4d069e163e" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("dc7fdfaa-16be-48b2-8a42-813b7d6cd18f"), "9efcf71a-b098-441b-81dc-9c7b6126961f" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("ed75e64a-9d3c-443b-9cec-40daae6129f6"), "b611ab40-fcb2-4f5a-ac6d-ba325cba729a" });

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("69d2a46f-3517-4d32-be77-396d274d0ef0"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("869d8d33-9f0a-42c1-b8f2-c4a51a909f73"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("93ec7248-4f8e-4f37-9e77-6d81b43341ac"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("95e4dbb5-e5f1-451a-afaf-5d7245edb237"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("f9b04b36-c34b-40e2-91fb-2f5130a5fce5"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("dd5ff859-ab2e-435a-84f2-fb0eeb6e43fd"), "FPS" },
                    { new Guid("4b8ddfe2-f7c1-4f7c-a4c7-c294e4c31aa1"), "Action" },
                    { new Guid("d79c5d70-a52f-45b7-89e0-9435bdc62bd7"), "Adventure" },
                    { new Guid("54d76b05-f328-4b38-ab4c-00daae464cd9"), "Puzzle" },
                    { new Guid("0d5b7004-613c-4ff5-b77b-7dcafe35d286"), "Open world" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Money", "Name", "Reliability" },
                values: new object[,]
                {
                    { new Guid("80b68798-e7d0-4c75-b8b1-e300ca2b90d6"), 0, "King", 0 },
                    { new Guid("617f4150-99cf-4704-9dda-05e77db71502"), 0, "Rovio Entertainment Corporation", 0 },
                    { new Guid("ea230f27-0e38-446a-898b-1780f205d9e9"), 0, "Outfit7 Limited", 0 },
                    { new Guid("24639b81-3afb-4b17-b892-5d3df6295376"), 0, "AMANOTES", 0 },
                    { new Guid("135b51ba-37f9-4ae7-9689-03e360d95ed6"), 0, "Gameloft", 0 },
                    { new Guid("16da2616-1346-4496-a2fe-9928c7ab46f5"), 0, "Mobigame S.A.R.L.", 0 },
                    { new Guid("9b02c6a1-88b2-418a-a594-4ebad51a3b22"), 0, "Imangi Studios", 0 },
                    { new Guid("a3fcbf76-b07a-46a2-98b9-3b9cd924b0bd"), 0, "NEKKI", 0 },
                    { new Guid("3d8c48b6-af4e-4a59-b0e4-ea842d6ebfa5"), 0, "Kiloo", 0 },
                    { new Guid("f9d8b4af-e2b9-4d7b-a452-9df2f5b01cc4"), 0, "ZeptoLab", 0 },
                    { new Guid("227c9675-abf8-41d7-8add-8f362c863d93"), 0, "ELECTRONIC ARTS", 0 },
                    { new Guid("10570df6-3e26-4876-8fe7-4cc647a9e5fd"), 0, "J-PARK", 0 }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("43d30116-2ff8-4ea7-af30-b2f1b2439c1d"), "User", "Limited Permission", "User", "User" },
                    { new Guid("7fca4a4a-297f-4418-a680-f5d57bc78cf5"), "Admin", "Full Permission", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Hobbies", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("ef72b719-d20a-4798-9a11-b5a0fc1bb809"), 0, "14740f16-7a23-4a70-bcb9-8a6c4377e6bd", "duykkxm92@gmail.com", false, "Nguyen Ngoc Duy", "Hobbies", false, null, null, null, "duykkxm92", "01638789455", false, null, false, "duykkxm92" },
                    { new Guid("9e37ac33-66fe-4899-ac61-b8642ee2c98a"), 0, "5ef2c6d6-65b8-4701-9fc2-4934a883ac4f", "Email1@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509228098523", false, null, false, "UserName1" },
                    { new Guid("f1560f53-6e08-4ec5-ab6a-d84dd18d53bd"), 0, "b42b1d35-6c89-4f34-a016-548be02f34d0", "Email2@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098559238098523", false, null, false, "UserName2" },
                    { new Guid("0f43d2b0-1e01-4ac2-8ab4-cc431ab2d3e6"), 0, "f83cdd40-273d-4f49-b845-fce47e28aa6a", "Email3@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098609238098523", false, null, false, "UserName3" },
                    { new Guid("37755108-3a0d-4ccc-b0a1-42b602645ae3"), 0, "80cd8fdc-7018-414e-8540-4e03183bfe6a", "Email4@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509738098523", false, null, false, "UserName4" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Content", "Name", "Price", "PublisherId", "Rating", "ReleaseDate", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("59f00599-0c60-48a0-a301-edd67b60bd19"), "DASH as fast as you can! DODGE the oncoming trains!Help Jake, Tricky & Fresh escape from the grumpy Inspector and his dog.  Grind trains with your cool crew!  Colorful and vivid HD graphics!  Hoverboard Surfing!  Paint powered jetpack!  Lightning fast swipe acrobatics!  Challenge and help your friends!", "Subway Surfers", 0f, new Guid("3d8c48b6-af4e-4a59-b0e4-ea842d6ebfa5"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("2db52882-1c4b-4833-a1d6-f8b8d6340f3d"), "The sequel to the famous Facebook smash hit with 40 million users Shadow Fight 2 is a nail-biting mix of RPG and classical Fighting. This game lets you equip your character with countless lethal weapons and rare armor sets, and features dozens of lifelike-animated Martial Arts techniques! Crush your enemies, humiliate demon bosses, and be the one to close the Gate of Shadows. Do you have what it takes to kick, punch, jump, and slash your way to victory? There’s only one way to find out", "Shadow Fight 2", 100000f, new Guid("a3fcbf76-b07a-46a2-98b9-3b9cd924b0bd"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("aec4463e-dfaa-4277-93f7-e5a9465179b5"), "Strap on your running shoes and join the award-winning, fan-favorite runner, Minion Rush. Enter Gru's Lair, discover its many mysterious rooms, and take on manic missions around the world. Along the way, your Minions will jump, roll and dodge obstacles while unlocking a collection of cool Minion costumes.", "Minion Rush: Despicable Me Official Game", 100000f, new Guid("617f4150-99cf-4704-9dda-05e77db71502"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("a792a400-8613-494a-b7b1-862842ca53ea"), "Use the unique powers of the Angry Birds to destroy the greedy pigs' defenses! The survival of the Angry Birds is at stake. Dish out revenge on the greedy pigs who stole their eggs. Use the unique powers of each bird to destroy the pigs’ defenses. Angry Birds features challenging physics-based gameplay and hours of replay value. Each level requires logic, skill and force to solve.", "Angry Birds Classic", 100000f, new Guid("617f4150-99cf-4704-9dda-05e77db71502"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("6be3f698-ece3-4398-a206-da9cb9f0b14b"), "Is it a baby? Is it a puppy? No! It’s Talking Tom! The cutest kitten, the coolest cat, and the biggest superstar in the world! My Talking Tom is the best virtual pet game for children, and big kids of all ages.That’s right - even grandma and grandpa can join the fun!", "My Talking Tom", 100000f, new Guid("ea230f27-0e38-446a-898b-1780f205d9e9"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("ec0194ee-8880-4a55-8477-2cfaf3f5a6d2"), "Dragon Mania Legends is for anyone that wants their very own pet dragon, which is obviously everyone… – Gamezebo", "Dragon Mania Legends", 100000f, new Guid("24639b81-3afb-4b17-b892-5d3df6295376"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("376e9bcc-b88f-4594-8f05-cb6e485b8ea3"), "Play the award-winning hit action-strategy adventure where you meet, greet, and defeat legions of hilarious zombies from the dawn of time, to the end of days. Amass an army of amazing plants, supercharge them with Plant Food, and devise the ultimate plan to protect your brain.", "Plants vs Zombies 2 Free", 0f, new Guid("24639b81-3afb-4b17-b892-5d3df6295376"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("98c31201-2c55-4c12-9dd0-51a133ae3efc"), "Magic Tiles 3 ™ is one of the most loved piano games among thousands of free games in 2018 which has more than 80 million players around the world.", "Magic Tiles 3", 100000f, new Guid("24639b81-3afb-4b17-b892-5d3df6295376"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("c14c9ad8-e166-4c91-8189-b0783abe17e7"), "Follow the adventure of Om Nom in the first part of the legendary Cut the Rope logic puzzles series. Get it now for free and start playing with millions of players around the world!", "Cut the Rope FULL FREE", 0f, new Guid("80b68798-e7d0-4c75-b8b1-e300ca2b90d6"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("beedc884-d5cb-4d0f-b046-db6df8c89b4a"), "A strange group of enemies appeared in the city and have been using innocent people as experimental tools. Lots of people have turned into Zombie so that Hero and his friends should save the people and remove the enemies.", "Anger of stick 5 : zombie", 100000f, new Guid("80b68798-e7d0-4c75-b8b1-e300ca2b90d6"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("e0c31d7a-1ef7-4bf2-9447-f3e8a0bfcfb9"), "Start playing Candy Crush Saga today – loved by millions of players around the world. With over a trillion levels played, this sweet match 3 puzzle game is one of the most popular mobile games of all time!", "Candy Crush Saga", 100000f, new Guid("80b68798-e7d0-4c75-b8b1-e300ca2b90d6"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("f624db70-be06-4c88-ac4d-c954bc644e49"), "The time to take action and strike back is now! We’re calling for the best sniper in the world to take aim at evil, wherever it hides.There’s no room for remorse, so shoot to kill…", "Sniper Fury: Top shooting game - FPS", 100000f, new Guid("80b68798-e7d0-4c75-b8b1-e300ca2b90d6"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("4e81066c-4092-4a53-a37f-90c1734bf565"), "5 lớp nhân vật tùy biến có thể lên cấp cả trong chơi đơn lẫn chơi mạng. Kiếm và dùng Điểm Kĩ năng để kích hoạt kĩ năng riêng của từng lớp nhân vật. Đấu Đội trong các trận Chơi mạng. Bảng xếp hạng Cá nhân và Đội. Nói chuyện với người chơi khác trong mục Chat Toàn cầu và Đội. Nhiệm vụ tiết tấu nhanh với nhiều thử thách khác nhau từ Tokyo đến Venice.", "Modern Combat 5: eSports FPS", 100000f, new Guid("227c9675-abf8-41d7-8add-8f362c863d93"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("d2c17fba-3ef8-401e-ae8d-fd7a096130df"), "Help Swampy by guiding water to his broken shower. Each level is a challenging physics-based puzzle with amazing life-like mechanics. Cut through dirt and guide fresh water, dirty water, toxic water, steam, and ooze through increasingly challenging scenarios! Every drop count", "Where's My Water? Free", 0f, new Guid("3d8c48b6-af4e-4a59-b0e4-ea842d6ebfa5"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("0a1a5e04-e563-4dac-9fee-de27cde80334"), "The zombies are revolting ! Attack the city with a horde of zombies, change pedestrians into zombies and create the largest horde. Eat your friends, and challenge them to a crazy race by destroying everything in your path. Zombie Tsunami has proudly exceeded 200 million players around the world.", "Zombie Tsunami", 100000f, new Guid("16da2616-1346-4496-a2fe-9928c7ab46f5"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("fef22046-66cb-4ed7-9e5a-b26f6e5b5735"), "N.O.V.A. Legacy brings you the best 3D sci-fi FPS experience based on the epic first episode of N.O.V.A., which received critical acclaim -- all in a compact version of the shooter. Kal Wardin, our hero, is a veteran N.O.V.A. marine, summoned once again to don his Mobile Armored Suit and strike against the enemies of the Colonial Administration forces. Helped by Yelena, his personal AI Agent, Kal must protect humanity's destiny by engaging in combat against alien invaders while uncovering the mystery behind their sudden assault.", "N.O.V.A. Legacy", 100000f, new Guid("16da2616-1346-4496-a2fe-9928c7ab46f5"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("28bfaec5-5732-4c9e-8208-3217379ad616"), "With over a zillion downloads, Temple Run redefined mobile gaming. Now get more of the exhilarating running, jumping, turning and sliding you love in Temple Run 2! Navigate perilous cliffs, zip lines, mines and forests as you try to escape with the cursed idol. How far can you run ? !", "Temple Run 2", 50000f, new Guid("9b02c6a1-88b2-418a-a594-4ebad51a3b22"), 4.3f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("3728e294-f378-4447-8a0a-b42f57f55d6f"), "In Asphalt 8, you’ll race in some of the hottest, most high-performance dream machines ever created, from cars to bikes, as you take them on a global tour of speed. From the blazing Nevada Desert to the tight turns of Tokyo, you’ll find a world of challenge, excitement and arcade fun on your road to the top!", "Asphalt 8: Airborne", 100000f, new Guid("16da2616-1346-4496-a2fe-9928c7ab46f5"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("b370e0f3-b909-4a9d-b396-6f1bf22d41fb"), "Get ready to soil your plants as a mob of fun-loving zombies is about to invade your home. Use your arsenal of 49 zombie-zapping plants — peashooters, wall-nuts, cherry bombs and more — to mulchify 26 types of zombies before they break down your door.", "Plants vs. Zombies FREE", 100000f, new Guid("227c9675-abf8-41d7-8add-8f362c863d93"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" }
                });

            migrationBuilder.InsertData(
                table: "ImagePublishers",
                columns: new[] { "Id", "PublisherId", "UrlLocal", "UrlOnline" },
                values: new object[,]
                {
                    { new Guid("39856b79-c2a6-41fb-b052-539ed4f1ce36"), new Guid("16da2616-1346-4496-a2fe-9928c7ab46f5"), null, "http://4.bp.blogspot.com/-jAUhK8EAuiA/VmnLpfRWLHI/AAAAAAAAAkI/Hp8mTQXl8xM/s1600/Zombie%2BTsunami%2B-%2BLogo%2BMobigame.jpg" },
                    { new Guid("cdb4aad9-dfb2-47a1-b4f3-7baac9bbaadb"), new Guid("135b51ba-37f9-4ae7-9689-03e360d95ed6"), null, "https://pbs.twimg.com/profile_images/1026435341312512001/u3D328AP_400x400.jpg" },
                    { new Guid("7e00c6c8-1b87-4f29-93f5-aed470c65b3d"), new Guid("24639b81-3afb-4b17-b892-5d3df6295376"), null, "https://employer.jobsgo.vn/image.php?src=1187_logo_1187_20170209115933_1779.jpg&w=300&h=300" },
                    { new Guid("24eb5751-d5f4-43ab-a5c6-015c8e6aaad3"), new Guid("227c9675-abf8-41d7-8add-8f362c863d93"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRbShsNR-wcUaPKBv2NxLSeE6arTMAMGZNs5L219VYdIxUapVJc" },
                    { new Guid("66c17e6c-5496-4000-bb9e-f54fa7766969"), new Guid("ea230f27-0e38-446a-898b-1780f205d9e9"), null, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/O7_logo-red_cmyk.jpg/1200px-O7_logo-red_cmyk.jpg" },
                    { new Guid("99fdefe6-d718-46bd-924b-29bb7f90c23b"), new Guid("9b02c6a1-88b2-418a-a594-4ebad51a3b22"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS3aHsnIsbz6CxKRg5tmpq73iNWV6J65niLvsEs9tKf9feje5iv" },
                    { new Guid("ca221640-e844-441f-a6a0-4ffb025bc7ae"), new Guid("3d8c48b6-af4e-4a59-b0e4-ea842d6ebfa5"), null, "https://www.kiloo.com/wp-content/uploads/2017/03/sharelogo-2.png" },
                    { new Guid("e44ac0ed-fdc6-4ad0-880f-77ff9c2ae578"), new Guid("617f4150-99cf-4704-9dda-05e77db71502"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdbIPf6EeERMGnyQoYkE4xUMuaU22OEtWLEfHWjAw6vxzGJ5oq" },
                    { new Guid("4b8ad4ad-c5d6-4adc-9d32-89cf04f7322c"), new Guid("a3fcbf76-b07a-46a2-98b9-3b9cd924b0bd"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQkyOmWOFhXD1lRsMIHkAJrLIvjwmImH1GBwlmqb3I5ysGUNY0-" },
                    { new Guid("ef64b1fd-dbd1-4330-911b-05da9effd861"), new Guid("10570df6-3e26-4876-8fe7-4cc647a9e5fd"), null, "https://upload.wikimedia.org/wikipedia/vi/thumb/2/2a/ZeptoLab.png/200px-ZeptoLab.png" },
                    { new Guid("08ff011c-79b8-481e-b4a3-cbef86598b8d"), new Guid("80b68798-e7d0-4c75-b8b1-e300ca2b90d6"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSE0L-3DI9ruta232UcPOIlvnE3I3xV-8l1u_C3Grzx6tmXrDzs" },
                    { new Guid("0a73ecf0-b9a0-4ad1-b5b1-48bc9495c047"), new Guid("f9d8b4af-e2b9-4d7b-a452-9df2f5b01cc4"), null, "https://upload.wikimedia.org/wikipedia/vi/thumb/2/2a/ZeptoLab.png/200px-ZeptoLab.png" }
                });

            migrationBuilder.InsertData(
                table: "CategoryGames",
                columns: new[] { "GameId", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("59f00599-0c60-48a0-a301-edd67b60bd19"), new Guid("dd5ff859-ab2e-435a-84f2-fb0eeb6e43fd") },
                    { new Guid("28bfaec5-5732-4c9e-8208-3217379ad616"), new Guid("d79c5d70-a52f-45b7-89e0-9435bdc62bd7") },
                    { new Guid("e0c31d7a-1ef7-4bf2-9447-f3e8a0bfcfb9"), new Guid("0d5b7004-613c-4ff5-b77b-7dcafe35d286") },
                    { new Guid("b370e0f3-b909-4a9d-b396-6f1bf22d41fb"), new Guid("54d76b05-f328-4b38-ab4c-00daae464cd9") },
                    { new Guid("0a1a5e04-e563-4dac-9fee-de27cde80334"), new Guid("4b8ddfe2-f7c1-4f7c-a4c7-c294e4c31aa1") }
                });

            migrationBuilder.InsertData(
                table: "FreeCodes",
                columns: new[] { "Id", "Code", "GameId" },
                values: new object[,]
                {
                    { new Guid("fffc1ef3-80fe-46fe-b213-e54462e1e3d9"), "638efae2-0bf0-4b2b-bbf9-0f8dac2e1358", new Guid("28bfaec5-5732-4c9e-8208-3217379ad616") },
                    { new Guid("1a062b36-1ea1-47af-b92b-cb3a63b30a32"), "58fb87f1-2853-4be2-8cce-d8732166d85d", new Guid("b370e0f3-b909-4a9d-b396-6f1bf22d41fb") },
                    { new Guid("d3adb51c-a3d7-4f6b-87b6-8032aa1dc0bb"), "1cdc73de-edec-4eb0-8626-df85adf1961e", new Guid("e0c31d7a-1ef7-4bf2-9447-f3e8a0bfcfb9") },
                    { new Guid("9a8da85e-4bbc-495f-bc35-64d9b49562e1"), "5b37a486-8b46-4623-ad2d-24748d09cc15", new Guid("0a1a5e04-e563-4dac-9fee-de27cde80334") },
                    { new Guid("457db70a-69de-48d9-9cde-2ba27aa39262"), "88509205-7348-40dc-9a2a-0d61802c6620", new Guid("59f00599-0c60-48a0-a301-edd67b60bd19") }
                });

            migrationBuilder.InsertData(
                table: "ImageGames",
                columns: new[] { "Id", "GameId", "UrlLocal", "UrlOnline" },
                values: new object[,]
                {
                    { new Guid("cc765b25-0b71-46a8-b19b-2f1c4bbe0624"), new Guid("c14c9ad8-e166-4c91-8189-b0783abe17e7"), "", "https://lh3.googleusercontent.com/Qnm85mIcd32-R8IxmDXM1MPgCfpM2-duddE7P_iS55P0xFO6ZM9jo9dt6PThjWhZvw=w720-h310" },
                    { new Guid("0eca2320-1eee-4e73-a4a7-b5561acee29e"), new Guid("e0c31d7a-1ef7-4bf2-9447-f3e8a0bfcfb9"), "", "https://lh3.googleusercontent.com/ucBNG7Vj8Lqo8b14PUMyzB8h7f2YcZ9oKB6BuFaJTgCj4jEv3Zo1jFPg-FjdONrw8c7b=w720-h310" },
                    { new Guid("590adc0c-bc6f-4e0c-bc2f-e935edbd9b7a"), new Guid("98c31201-2c55-4c12-9dd0-51a133ae3efc"), "", "https://lh3.googleusercontent.com/Z_KPg-BqbZVMMLlH689YEwzPefUXW0l_7MfPS8-KUzDV4-y-VeSfnswbSXakPJfoJw8=w720-h310" },
                    { new Guid("4d7e6eaa-e0ee-45ba-b607-85f485a8b492"), new Guid("98c31201-2c55-4c12-9dd0-51a133ae3efc"), "", "https://lh3.googleusercontent.com/uJK2kFV81mdNGWE9nDO__wadnVhC8afhQourrne9WhOy0ip1UjlsElsw9xd0BV3NCG8=w720-h310" },
                    { new Guid("08064e7b-66b8-4c10-8ef3-6247e46504e2"), new Guid("f624db70-be06-4c88-ac4d-c954bc644e49"), "", "https://lh3.googleusercontent.com/5W6OOrho0AFit_nm98QqpCsu52uHc-kw7RQPK4_PUdGEi6DjrmfZdPJIGYl2u_3Ibw=w720-h310" },
                    { new Guid("8ac792bd-eadc-472f-b1af-911cae24c288"), new Guid("f624db70-be06-4c88-ac4d-c954bc644e49"), "", "https://lh3.googleusercontent.com/5W6OOrho0AFit_nm98QqpCsu52uHc-kw7RQPK4_PUdGEi6DjrmfZdPJIGYl2u_3Ibw=w720-h310" },
                    { new Guid("524bacaf-8aab-4d28-b99c-c0bd5e53f1e3"), new Guid("f624db70-be06-4c88-ac4d-c954bc644e49"), "", "https://lh3.googleusercontent.com/qSl0aQ-tQiBC_Ut0MC3n-I3HTgQsDQ52XUq_cnfu5rq9kyDSBs2vneGXZZ-PhVv8yb22=w720-h310" },
                    { new Guid("5d6c6188-1c1c-404d-aa7d-02909bf1ca83"), new Guid("f624db70-be06-4c88-ac4d-c954bc644e49"), "", "https://lh3.googleusercontent.com/nNjmESXQm2dJupXjwYn9RvD6nhS6_5bAthB6GrjrHCdaoiftDAKABIEOBJd3paXCYg=w720-h310" },
                    { new Guid("e84d9ddc-fa3c-4013-b46f-cd4ab075d72f"), new Guid("e0c31d7a-1ef7-4bf2-9447-f3e8a0bfcfb9"), "", "https://lh3.googleusercontent.com/EFv_aMUrdXQLXLesEfQAuFv9bNvQ5hwzYnuKZ1cr_OBDZU6cY6OZhIiDzfhx4eSuvtI=w720-h310" },
                    { new Guid("06c42caf-4a48-4d95-9253-d2271b2a8f8e"), new Guid("beedc884-d5cb-4d0f-b046-db6df8c89b4a"), "", "https://lh3.googleusercontent.com/NdRmiugakoZ-CgyoqeEd7SC9xT_xFIfjY3LtjMifJ9_iKsUdzA5WgBrs2cgoAK3d_CNr=w720-h310" },
                    { new Guid("809ce199-2e2e-4be1-9d7f-c141361c42e8"), new Guid("c14c9ad8-e166-4c91-8189-b0783abe17e7"), "", "https://lh3.googleusercontent.com/uFYADCilcHxlddeBXKAAu9HNzQG0Mx1VqwuwGQg3WiXBZAg41hooWQTAUilvZetyYhqy=w720-h310" },
                    { new Guid("62f24cef-5d41-4181-aa09-941e480ca571"), new Guid("beedc884-d5cb-4d0f-b046-db6df8c89b4a"), "", "https://lh3.googleusercontent.com/A4POGA0IPwbcaSj5dba5zrn6tUlCiyvu4ppse912kWUzr084-qqgvCT0m-E99RPi228=w720-h310" },
                    { new Guid("423a8592-4866-4a1b-b3ca-3bac35470745"), new Guid("beedc884-d5cb-4d0f-b046-db6df8c89b4a"), "", "https://lh3.googleusercontent.com/PeX7REevxeIec-hxFckCJP0xyg88TEzwPh4zz2Prv08d-0UsspP6wcoaBXYJqWzkuQ=w720-h310" },
                    { new Guid("ca0bf776-e5f8-4436-a415-b5731f6efdf1"), new Guid("c14c9ad8-e166-4c91-8189-b0783abe17e7"), "", "https://lh3.googleusercontent.com/cOijr_HBBvrjn7t00qwPQiXJ2y53NMSMI4iF2YSH89RDlmpe_MbppoqJmXTyIUPCj7M=w720-h310" },
                    { new Guid("3c1909fd-d958-4101-81f6-25993a010b59"), new Guid("c14c9ad8-e166-4c91-8189-b0783abe17e7"), "", "https://lh3.googleusercontent.com/Kri8NpWg8Nt5BmgNxbMCrW4vxk7LqzjpvibCYHb24_RJgS-l58n-gFR2f4RE_uGfuKI=w720-h310" },
                    { new Guid("e2b98d5f-4681-4cd2-a742-82c78b430405"), new Guid("beedc884-d5cb-4d0f-b046-db6df8c89b4a"), "", "https://lh3.googleusercontent.com/YL2_i-PixRM-qYfrZ6CpAqyNiXW_MrIx2KFyg2zZLkdjjosIK5qyPg1dfbyTAC-BdNg=w720-h310" },
                    { new Guid("dfffdcea-b17e-4de6-afc8-be9a153a4850"), new Guid("98c31201-2c55-4c12-9dd0-51a133ae3efc"), "", "https://lh3.googleusercontent.com/CjrXpLQr5ixH5K9RjdL4CFLhmfgkVCJVAw0bhOuFuFI0v4IaQyt1zbXLVxKfGz2l246x=w720-h310" },
                    { new Guid("6922cd35-f5cc-4170-867d-c6cb75cc9a5d"), new Guid("376e9bcc-b88f-4594-8f05-cb6e485b8ea3"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("a69ec52b-879d-4ab4-8d2b-2c5758831bb4"), new Guid("376e9bcc-b88f-4594-8f05-cb6e485b8ea3"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("4b52da9d-2afe-429f-9834-cf52f79f6b4c"), new Guid("2db52882-1c4b-4833-a1d6-f8b8d6340f3d"), "", "https://lh3.googleusercontent.com/zRs9fTN-tL-p4yNL3ccFr1w3wUH-hqN0ShgwAnbzcnH2FidymdlixdDN-lpqF3xck4I=w720-h310" },
                    { new Guid("a8b05a5d-c712-46a1-856e-b626fa613112"), new Guid("2db52882-1c4b-4833-a1d6-f8b8d6340f3d"), "", "https://lh3.googleusercontent.com/o0i5z7sG2EArHccVaOCYU516s3PzflywGTbzf3ylRoZwOizKm-jH2AKwXweh2_77Tw=w720-h310" },
                    { new Guid("c832927f-e1d4-4bee-a2f6-9036c2a6e548"), new Guid("aec4463e-dfaa-4277-93f7-e5a9465179b5"), "", "https://lh3.googleusercontent.com/JMc16QhAhKFbnW2jusl-T6xu8xo31BDzv8h7APyDdU006PkYvtk3q3Ey76LU-G908M0=w720-h310" },
                    { new Guid("074c4ace-d587-4be7-9db0-82395fba3377"), new Guid("aec4463e-dfaa-4277-93f7-e5a9465179b5"), "", "https://lh3.googleusercontent.com/RdxHjaoI2WK-ku4--LmPMaZ6DkLVYt0q9IKiSrdqXnmMKlPo4hgZHf0VdN8Oee5pxg=w720-h310" },
                    { new Guid("eac01733-cd96-47b0-a777-9d1e7f04bf14"), new Guid("aec4463e-dfaa-4277-93f7-e5a9465179b5"), "", "https://lh3.googleusercontent.com/YYz6o1qMBxop37bvU1rfACXRv1AS-gNHOCjUW9lp6eLDV7BQAZ7zUIkG3PF597svP4gP=w720-h310" },
                    { new Guid("d77fb0da-b731-4e79-8a74-bcd233ced6d1"), new Guid("aec4463e-dfaa-4277-93f7-e5a9465179b5"), "", "https://lh3.googleusercontent.com/Ziiu3YNdzaoJf7_rdy9tk7pbPiPlluFvA_JdU0FtzqlvZuLrfyuWNnfkRtMvxq4_lA=w720-h310" },
                    { new Guid("38d9902d-764a-4f3f-9820-db6cc5d741e8"), new Guid("a792a400-8613-494a-b7b1-862842ca53ea"), "", "https://lh3.googleusercontent.com/ClxJrJjyrjj5uaAxZvSaQcjjRfeCta4_otNRCsGJacfFptfTtamCUJpQ0hcQWOd8u-Q=w720-h310" },
                    { new Guid("78af2d69-f7fa-4c42-9c30-1dde10fc93b2"), new Guid("a792a400-8613-494a-b7b1-862842ca53ea"), "", "https://lh3.googleusercontent.com/JIvkWPFnKbYeVV5h3AxjMgR9ogQ2a0vMQgCp5B3JP4dEXU4zIR40H8ROTg8WkPrjcEA=w720-h310" },
                    { new Guid("59732204-c6f5-40a2-9c53-a609f128fcf4"), new Guid("a792a400-8613-494a-b7b1-862842ca53ea"), "", "https://lh3.googleusercontent.com/d0jf4r7KjWBCzi2GELWFSf6MaJIHepkJIN8JYT8g0tSIThiH_W6FhUnHjBN_fYdl3Q=w720-h310" },
                    { new Guid("689c4338-d1f0-4eb9-9c7b-782237186fcf"), new Guid("98c31201-2c55-4c12-9dd0-51a133ae3efc"), "", "https://lh3.googleusercontent.com/HteHDUkzuMjCEHM1B-3jvLqlbBYtJZFWiHm-vf47YcE7QiInhXn2O-LkYPxvzPnPGA=w720-h310" },
                    { new Guid("7c246f32-9ed8-4430-ae53-30b4e4fd20e6"), new Guid("a792a400-8613-494a-b7b1-862842ca53ea"), "", "https://lh3.googleusercontent.com/UbTWxlQujVdxOaYqy_FmC4LRBlm_wSUgQe0wIM0BSXeGUZ0Vzle9OTWNNs4wk8nOKI4=w720-h310" },
                    { new Guid("48c49fd3-238b-45ed-b4b0-20ba7ab430e5"), new Guid("6be3f698-ece3-4398-a206-da9cb9f0b14b"), "", "https://lh3.googleusercontent.com/jCNaOtE_9-Zcs9r5MFtGzaxO8xNz3UYEcB3XdPe1oLO3X6PH-hYEspWnR26lUZef_5A=w720-h310" },
                    { new Guid("88fc3d8f-2f3a-4340-92da-09691c1f22f6"), new Guid("6be3f698-ece3-4398-a206-da9cb9f0b14b"), "", "https://lh3.googleusercontent.com/d6CY2BSvBXFLK8J3WqJEdDr53_OZ43Aijr43CjG1QKUfHXt4E_zDNBZWoMqkxONzOQ=w720-h310" },
                    { new Guid("0feed329-b144-481a-8ded-792ea266602d"), new Guid("6be3f698-ece3-4398-a206-da9cb9f0b14b"), "", "https://lh3.googleusercontent.com/L615QU2G2qxv68di7WqB4V40mDsOgko4iKmz-NB6SzwLejM8x4i2CbAqgkIxBqZ3A9M=w720-h310" },
                    { new Guid("bea1c1f6-d827-4d6b-a495-f4c8c5871ddd"), new Guid("ec0194ee-8880-4a55-8477-2cfaf3f5a6d2"), "", "https://lh3.googleusercontent.com/9lQV-3IWYXkSndN4GsVQTflvUCSKPMj-uSuH9tEd8FlHuBOslA52Q-Z7wEEKmhwuxJE=w720-h310" },
                    { new Guid("d6b10dbd-e8c2-4523-bd54-544a12e852f5"), new Guid("ec0194ee-8880-4a55-8477-2cfaf3f5a6d2"), "", "https://lh3.googleusercontent.com/3HUpkFFcnCkLbgUosodwIrfzzq3VkebxVQkjfa_uDhapJyrz0ATxq6wRyYpyxKauyg=w720-h310" },
                    { new Guid("69c07a6e-a048-445e-ac04-44e08ecc9696"), new Guid("ec0194ee-8880-4a55-8477-2cfaf3f5a6d2"), "", "https://lh3.googleusercontent.com/JJNpXkj5HNkscW_bmZ1yGu-GuakL4Q4zRwOPmACFaqbIT5C2HMaI4LwhjGNiIrup_Ew4=w720-h310" },
                    { new Guid("16a14544-7e76-4845-910f-71c8b6f86add"), new Guid("ec0194ee-8880-4a55-8477-2cfaf3f5a6d2"), "", "https://lh3.googleusercontent.com/aU5RuCIDy7JzNtp5ib2huaa1t33TVY_zdsES_ooMWSwY6K1JnHG0HC9RK0OgVuXqs9U=w720-h310" },
                    { new Guid("ee2fbce5-ae95-4c2c-a476-749a1319c047"), new Guid("376e9bcc-b88f-4594-8f05-cb6e485b8ea3"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("4a91aa4a-fee9-4adf-84fc-1e6f5fd579ce"), new Guid("376e9bcc-b88f-4594-8f05-cb6e485b8ea3"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("879a76c9-637d-4dd1-a7c7-1d492b9f1d70"), new Guid("6be3f698-ece3-4398-a206-da9cb9f0b14b"), "", "https://lh3.googleusercontent.com/sCw3rT7aK1z589o_MBBn1JzVd7fYC1-fWkYV2Tz4eDfCDTi49dS9tOFBLqBrd_XwQCc=w720-h310" },
                    { new Guid("61517d27-5ead-4d92-b0c4-1c0f0dbcac31"), new Guid("e0c31d7a-1ef7-4bf2-9447-f3e8a0bfcfb9"), "", "https://lh3.googleusercontent.com/xaL3b80wmBVOrpH-q_DX8F5kKsASHH8Fllf3u65TsS0zs9_y0J4DWKJj5T9QVAWuT3Rn=w720-h310" },
                    { new Guid("d6e226d7-a334-447c-90ab-5cc0b5702450"), new Guid("4e81066c-4092-4a53-a37f-90c1734bf565"), "", "https://lh3.googleusercontent.com/Ibj-Kt-6Pc1IBDVj0yWf1sNjSpdGpRlapbTbjc5MuitmDkoKVMP45GF0LBlg6pnIbYE=w720-h310" },
                    { new Guid("4623414b-f650-4a39-a21c-691e6afec84c"), new Guid("2db52882-1c4b-4833-a1d6-f8b8d6340f3d"), "", "https://lh3.googleusercontent.com/AinG9y8hyEb_p2B6Rg8-iOVjYR7EcsGDmv_rThdnfzgkBjbukLIT4mWFOg5ObAO4RMq0=w720-h310" },
                    { new Guid("6cc78f73-56c1-41e4-9549-a12917b741e8"), new Guid("3728e294-f378-4447-8a0a-b42f57f55d6f"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("5cf55fe1-adff-4916-9eca-6ae8a2623530"), new Guid("3728e294-f378-4447-8a0a-b42f57f55d6f"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("b76562c9-24f0-4447-8bff-5b9a73e112ed"), new Guid("3728e294-f378-4447-8a0a-b42f57f55d6f"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("6c7c5166-9e93-4610-829e-f5fbbe39d33e"), new Guid("3728e294-f378-4447-8a0a-b42f57f55d6f"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("5dfb192d-c0b5-4417-aa42-e91b102582de"), new Guid("0a1a5e04-e563-4dac-9fee-de27cde80334"), "", "https://lh3.googleusercontent.com/UY9fte3alDnv-cZ94Jx27Lf4g9FUT2395jhXPScEllshpdCO4zfnuWrTNtO1FVRt3w=w720-h310" },
                    { new Guid("5fa2c4f7-fc81-451a-a1dc-af0f0b682fcd"), new Guid("0a1a5e04-e563-4dac-9fee-de27cde80334"), "", "https://lh3.googleusercontent.com/-BUT6NCVxZsPPjsUW8zdrVk4XLMRuE_oWSTwaXrAPYZbBsMKBfqXxOVI7OowXxoLwa8=w720-h310" },
                    { new Guid("6fbca0be-8467-4ad5-9660-03f632536d92"), new Guid("0a1a5e04-e563-4dac-9fee-de27cde80334"), "", "https://lh3.googleusercontent.com/MwNuIIzmxxJgM8JeNi2aBhpE-kNnXBGOVPRb_gZoRE-gel5q9ZP7mrQfTT_9xzV8dz4=w720-h310" },
                    { new Guid("8f74f813-2762-40de-ba15-65123875e3a7"), new Guid("e0c31d7a-1ef7-4bf2-9447-f3e8a0bfcfb9"), "", "https://lh3.googleusercontent.com/gFZCgWFd8-oR8zu2ApqRWk6dgwIkDM8jex4MxbA-MdiYgfpHJlkAcPBCZX5czXgddA=w720-h310" },
                    { new Guid("03e034db-fb06-4a8e-98da-41e1f4674fc8"), new Guid("0a1a5e04-e563-4dac-9fee-de27cde80334"), "", "https://lh3.googleusercontent.com/mfGdhejubeU1m1Pkj2vpWMLTlLMhnQz0f2Z8M79g6g0thY9cDyHggntmd_A7ckZPGVM=w720-h310" },
                    { new Guid("0ee4caf8-574c-49e4-99c3-d69ce5ef5018"), new Guid("d2c17fba-3ef8-401e-ae8d-fd7a096130df"), "", "https://lh3.ggpht.com/y7On3vVZhFWycuekTPLwARYJ3MwQyODIzKHRt4ofyeS_gmXRDF271NsFDfu_lLhlX2Rj=w720-h310" },
                    { new Guid("9755a0a2-8b17-47cd-85f3-a5032d5e9b5e"), new Guid("d2c17fba-3ef8-401e-ae8d-fd7a096130df"), "", "https://lh3.ggpht.com/y7On3vVZhFWycuekTPLwARYJ3MwQyODIzKHRt4ofyeS_gmXRDF271NsFDfu_lLhlX2Rj=w720-h310" },
                    { new Guid("91207894-6d2a-444f-a898-57e39722f1af"), new Guid("d2c17fba-3ef8-401e-ae8d-fd7a096130df"), "", "https://lh3.ggpht.com/y7On3vVZhFWycuekTPLwARYJ3MwQyODIzKHRt4ofyeS_gmXRDF271NsFDfu_lLhlX2Rj=w720-h310" },
                    { new Guid("4438b45f-a61c-42b8-94a4-252ea9d4ff23"), new Guid("59f00599-0c60-48a0-a301-edd67b60bd19"), "", "https://lh3.googleusercontent.com/h4JQOfS4vmim_WhTHeC3RGxtY8eoFG0fgtgsWWk6VvVSrjnjtlgSFzR6sW0hzbncWA=w720-h310" },
                    { new Guid("de1c7ef1-8bcc-4681-826b-a5722992efce"), new Guid("59f00599-0c60-48a0-a301-edd67b60bd19"), "", "https://lh3.googleusercontent.com/oMcH_a4lXShvowzyaiQpE0_MhYWZvdN9RkaYLtkdnw_rlDR_uHbHj9Eu2zbrvyOAXHQ=w720-h310" },
                    { new Guid("21c73d3d-e4eb-41bc-aca8-458e2c764492"), new Guid("59f00599-0c60-48a0-a301-edd67b60bd19"), "", "https://lh3.googleusercontent.com/Ia1psbcXgeCV9FBZk1b08QnxC-uSHCgJ112VeJZB19_F2Q-m_w3Z7P_OjFStnYM3LaCC=w720-h310" },
                    { new Guid("30ede56c-3d4a-4d76-8a3b-2f50d6dae46a"), new Guid("59f00599-0c60-48a0-a301-edd67b60bd19"), "", "https://lh3.googleusercontent.com/vInYRcyjzVjBFfY4HIGLLf-tSLK9S55HjUbmQuxmrbpVpItV3AfyuxVMFGASoDdMHc4=w720-h310" },
                    { new Guid("2255dcbc-c5a2-4663-bd87-ab1fb0be28c9"), new Guid("d2c17fba-3ef8-401e-ae8d-fd7a096130df"), "", "https://lh3.ggpht.com/y7On3vVZhFWycuekTPLwARYJ3MwQyODIzKHRt4ofyeS_gmXRDF271NsFDfu_lLhlX2Rj=w720-h310" },
                    { new Guid("56ce4cca-61af-4446-8dba-8dbaf31419c2"), new Guid("fef22046-66cb-4ed7-9e5a-b26f6e5b5735"), "", "https://lh3.googleusercontent.com/FMgP9XZNML3lieBG9KDgiJGnT2WlmHMG5lFGcAl0rk93GtGFjf9X2J6vxcCCElNPJDw=w720-h310" },
                    { new Guid("73f5e27e-6443-443e-bf4e-6092992b0d6d"), new Guid("fef22046-66cb-4ed7-9e5a-b26f6e5b5735"), "", "https://lh3.googleusercontent.com/DQppPRLU04SzwExhZTIKsYL1y3iZXzRsZbTBrmHJqJO1aTCsApHGdYxTKt3dvkN7ctRb=w720-h310" },
                    { new Guid("2e1a0916-2b33-4abf-a32b-3689129b1a7a"), new Guid("fef22046-66cb-4ed7-9e5a-b26f6e5b5735"), "", "https://lh3.googleusercontent.com/-oRMqwODzaru2JCxLf3JtHVZXtpYfQ8Qo0IQRbRsZtssH6dUGr51WMfH0j3eMrfO5w=w720-h310" },
                    { new Guid("1b96572e-b765-494f-ab3a-5a4de256147a"), new Guid("4e81066c-4092-4a53-a37f-90c1734bf565"), "", "https://lh3.googleusercontent.com/W_3i_ZHnSjan-N8egYQy9sQw87CppDDda9ITzTIQyTFHZpO2VJlhCzP_BORM3Hd-CDw=w720-h310" },
                    { new Guid("8ba72d86-9903-4de0-8930-21536df2bbe5"), new Guid("4e81066c-4092-4a53-a37f-90c1734bf565"), "", "https://lh3.googleusercontent.com/RhBTJ2IEOhtPEbOpmMTxfMC9iU06JihtylD-lQxbTrIPfT2U-B0YLAjGELbj2Ppk1w8=w720-h310" },
                    { new Guid("51bb3915-dd66-44d7-8f32-af5fffec5971"), new Guid("4e81066c-4092-4a53-a37f-90c1734bf565"), "", "https://lh3.googleusercontent.com/nlXezemMS359X8dy6MxUJMgumyw6abz15NX0CjtnT8V57vni_uuS3saDllIMeyfQ6e-6=w720-h310" },
                    { new Guid("12d3656f-1d8f-4a7a-8b6a-bfa5a10f628f"), new Guid("b370e0f3-b909-4a9d-b396-6f1bf22d41fb"), "", "https://lh3.googleusercontent.com/aosNkyZihAba_VF_HRKOUMGFuK5SxNcZMMvYIAXufiG8znXvrxJ_7jMgmP2E01CapoQ=w720-h310" },
                    { new Guid("3403410e-7466-454e-86a2-d144ba22c814"), new Guid("fef22046-66cb-4ed7-9e5a-b26f6e5b5735"), "", "https://lh3.googleusercontent.com/wzk-BPRwz5Lrh2YZ66uEJb8JjXkFE8oVm4RpZVTmWsCcx1e1nxP3XBhqr2q9Iff7Xica=w720-h310" },
                    { new Guid("e152a542-719e-4db5-b669-e89aaf8fff4b"), new Guid("b370e0f3-b909-4a9d-b396-6f1bf22d41fb"), "", "https://lh3.googleusercontent.com/Km7Il6ij6xZBtWJPSpEacmz8dC2C9WACUuf37VdjIYaXWaPaC6WWWmx3T8aaNgNkJaBx=w720-h310" },
                    { new Guid("d06cef17-ce88-49a9-a642-18af61457223"), new Guid("b370e0f3-b909-4a9d-b396-6f1bf22d41fb"), "", "https://lh3.googleusercontent.com/tk_p7dIHQBEBeYiVkFaPcU_5bd3fOhE8HerKp4Ei0cTyxVoVDdd_QD0SLPJeJrSm4c4=w720-h310" },
                    { new Guid("2f64b934-4aa6-4fd9-b8c1-01cf59636970"), new Guid("b370e0f3-b909-4a9d-b396-6f1bf22d41fb"), "", "https://lh3.googleusercontent.com/Zsth8maheotaUA0he3vGtWmm11dWsEsLlffOsvzGX65Sp4nXNAuKSx-Z96f8as3twQ4=w720-h310" },
                    { new Guid("98b424d5-5f6d-4566-92bc-bd2100133c42"), new Guid("28bfaec5-5732-4c9e-8208-3217379ad616"), "", "https://lh3.ggpht.com/GqnDETqoUP17xJg0cQ3pyEHsgO-KLjx-MbJ0Mcwg4Lvd2PnEO-JARZhYtfd8AYwjEew=w720-h310" },
                    { new Guid("b62e2546-3369-46d7-972b-5e694c8213c3"), new Guid("28bfaec5-5732-4c9e-8208-3217379ad616"), "", "https://lh3.ggpht.com/Vbi7XVMzoCMoAyHFhJlziKjldN5F-Mkp4EOf5YyiMOPsd-of4ckac2BzPAiKGIveSI4=w720-h310" },
                    { new Guid("07dcd64a-7973-4d78-aefc-7e61d7219ff0"), new Guid("28bfaec5-5732-4c9e-8208-3217379ad616"), "", "https://lh3.ggpht.com/AZ2OkTlsJuqUvCP8IQKwkCg7Fv56FRAb_CV8bXRsR15Ayre8fmWJrkr4RCIvx1wYoktm=w720-h310" },
                    { new Guid("728ddf8d-f45b-4dd8-873a-685315e88ec3"), new Guid("28bfaec5-5732-4c9e-8208-3217379ad616"), "", "https://lh3.ggpht.com/WRg7Mzp5FM-cSiKGb7TbzgeYBY8oMSV4Vgn35XYHDbejbNkWM7lNgqFeQjMlNAZoUX7Z=w720-h310" },
                    { new Guid("450e8c5e-d92c-4dc0-9082-b4bd52de9caf"), new Guid("2db52882-1c4b-4833-a1d6-f8b8d6340f3d"), "", "https://lh3.googleusercontent.com/WJIWdX6YPms3-diI1TPcCPtgv_YGH2QNMGqOXLK-ta5FLulrZps4KObsB1-frjU6syA=w720-h310" }
                });

            migrationBuilder.InsertData(
                table: "UserGames",
                columns: new[] { "UserId", "GameId", "PurchaseDate" },
                values: new object[,]
                {
                    { new Guid("9e37ac33-66fe-4899-ac61-b8642ee2c98a"), new Guid("0a1a5e04-e563-4dac-9fee-de27cde80334"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f1560f53-6e08-4ec5-ab6a-d84dd18d53bd"), new Guid("28bfaec5-5732-4c9e-8208-3217379ad616"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0f43d2b0-1e01-4ac2-8ab4-cc431ab2d3e6"), new Guid("b370e0f3-b909-4a9d-b396-6f1bf22d41fb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ef72b719-d20a-4798-9a11-b5a0fc1bb809"), new Guid("59f00599-0c60-48a0-a301-edd67b60bd19"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("37755108-3a0d-4ccc-b0a1-42b602645ae3"), new Guid("e0c31d7a-1ef7-4bf2-9447-f3e8a0bfcfb9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "WishGame",
                columns: new[] { "UserId", "GameId" },
                values: new object[,]
                {
                    { new Guid("9e37ac33-66fe-4899-ac61-b8642ee2c98a"), new Guid("0a1a5e04-e563-4dac-9fee-de27cde80334") },
                    { new Guid("0f43d2b0-1e01-4ac2-8ab4-cc431ab2d3e6"), new Guid("b370e0f3-b909-4a9d-b396-6f1bf22d41fb") },
                    { new Guid("ef72b719-d20a-4798-9a11-b5a0fc1bb809"), new Guid("59f00599-0c60-48a0-a301-edd67b60bd19") },
                    { new Guid("37755108-3a0d-4ccc-b0a1-42b602645ae3"), new Guid("e0c31d7a-1ef7-4bf2-9447-f3e8a0bfcfb9") },
                    { new Guid("f1560f53-6e08-4ec5-ab6a-d84dd18d53bd"), new Guid("28bfaec5-5732-4c9e-8208-3217379ad616") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("0a1a5e04-e563-4dac-9fee-de27cde80334"), new Guid("4b8ddfe2-f7c1-4f7c-a4c7-c294e4c31aa1") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("28bfaec5-5732-4c9e-8208-3217379ad616"), new Guid("d79c5d70-a52f-45b7-89e0-9435bdc62bd7") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("59f00599-0c60-48a0-a301-edd67b60bd19"), new Guid("dd5ff859-ab2e-435a-84f2-fb0eeb6e43fd") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("b370e0f3-b909-4a9d-b396-6f1bf22d41fb"), new Guid("54d76b05-f328-4b38-ab4c-00daae464cd9") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("e0c31d7a-1ef7-4bf2-9447-f3e8a0bfcfb9"), new Guid("0d5b7004-613c-4ff5-b77b-7dcafe35d286") });

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("1a062b36-1ea1-47af-b92b-cb3a63b30a32"));

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("457db70a-69de-48d9-9cde-2ba27aa39262"));

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("9a8da85e-4bbc-495f-bc35-64d9b49562e1"));

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("d3adb51c-a3d7-4f6b-87b6-8032aa1dc0bb"));

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("fffc1ef3-80fe-46fe-b213-e54462e1e3d9"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("03e034db-fb06-4a8e-98da-41e1f4674fc8"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("06c42caf-4a48-4d95-9253-d2271b2a8f8e"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("074c4ace-d587-4be7-9db0-82395fba3377"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("07dcd64a-7973-4d78-aefc-7e61d7219ff0"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("08064e7b-66b8-4c10-8ef3-6247e46504e2"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("0eca2320-1eee-4e73-a4a7-b5561acee29e"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("0ee4caf8-574c-49e4-99c3-d69ce5ef5018"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("0feed329-b144-481a-8ded-792ea266602d"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("12d3656f-1d8f-4a7a-8b6a-bfa5a10f628f"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("16a14544-7e76-4845-910f-71c8b6f86add"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("1b96572e-b765-494f-ab3a-5a4de256147a"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("21c73d3d-e4eb-41bc-aca8-458e2c764492"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("2255dcbc-c5a2-4663-bd87-ab1fb0be28c9"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("2e1a0916-2b33-4abf-a32b-3689129b1a7a"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("2f64b934-4aa6-4fd9-b8c1-01cf59636970"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("30ede56c-3d4a-4d76-8a3b-2f50d6dae46a"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("3403410e-7466-454e-86a2-d144ba22c814"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("38d9902d-764a-4f3f-9820-db6cc5d741e8"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("3c1909fd-d958-4101-81f6-25993a010b59"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("423a8592-4866-4a1b-b3ca-3bac35470745"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("4438b45f-a61c-42b8-94a4-252ea9d4ff23"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("450e8c5e-d92c-4dc0-9082-b4bd52de9caf"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("4623414b-f650-4a39-a21c-691e6afec84c"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("48c49fd3-238b-45ed-b4b0-20ba7ab430e5"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("4a91aa4a-fee9-4adf-84fc-1e6f5fd579ce"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("4b52da9d-2afe-429f-9834-cf52f79f6b4c"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("4d7e6eaa-e0ee-45ba-b607-85f485a8b492"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("51bb3915-dd66-44d7-8f32-af5fffec5971"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("524bacaf-8aab-4d28-b99c-c0bd5e53f1e3"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("56ce4cca-61af-4446-8dba-8dbaf31419c2"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("590adc0c-bc6f-4e0c-bc2f-e935edbd9b7a"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("59732204-c6f5-40a2-9c53-a609f128fcf4"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("5cf55fe1-adff-4916-9eca-6ae8a2623530"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("5d6c6188-1c1c-404d-aa7d-02909bf1ca83"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("5dfb192d-c0b5-4417-aa42-e91b102582de"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("5fa2c4f7-fc81-451a-a1dc-af0f0b682fcd"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("61517d27-5ead-4d92-b0c4-1c0f0dbcac31"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("62f24cef-5d41-4181-aa09-941e480ca571"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("689c4338-d1f0-4eb9-9c7b-782237186fcf"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("6922cd35-f5cc-4170-867d-c6cb75cc9a5d"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("69c07a6e-a048-445e-ac04-44e08ecc9696"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("6c7c5166-9e93-4610-829e-f5fbbe39d33e"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("6cc78f73-56c1-41e4-9549-a12917b741e8"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("6fbca0be-8467-4ad5-9660-03f632536d92"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("728ddf8d-f45b-4dd8-873a-685315e88ec3"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("73f5e27e-6443-443e-bf4e-6092992b0d6d"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("78af2d69-f7fa-4c42-9c30-1dde10fc93b2"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("7c246f32-9ed8-4430-ae53-30b4e4fd20e6"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("809ce199-2e2e-4be1-9d7f-c141361c42e8"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("879a76c9-637d-4dd1-a7c7-1d492b9f1d70"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("88fc3d8f-2f3a-4340-92da-09691c1f22f6"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("8ac792bd-eadc-472f-b1af-911cae24c288"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("8ba72d86-9903-4de0-8930-21536df2bbe5"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("8f74f813-2762-40de-ba15-65123875e3a7"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("91207894-6d2a-444f-a898-57e39722f1af"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("9755a0a2-8b17-47cd-85f3-a5032d5e9b5e"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("98b424d5-5f6d-4566-92bc-bd2100133c42"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("a69ec52b-879d-4ab4-8d2b-2c5758831bb4"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("a8b05a5d-c712-46a1-856e-b626fa613112"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("b62e2546-3369-46d7-972b-5e694c8213c3"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("b76562c9-24f0-4447-8bff-5b9a73e112ed"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("bea1c1f6-d827-4d6b-a495-f4c8c5871ddd"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("c832927f-e1d4-4bee-a2f6-9036c2a6e548"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("ca0bf776-e5f8-4436-a415-b5731f6efdf1"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("cc765b25-0b71-46a8-b19b-2f1c4bbe0624"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("d06cef17-ce88-49a9-a642-18af61457223"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("d6b10dbd-e8c2-4523-bd54-544a12e852f5"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("d6e226d7-a334-447c-90ab-5cc0b5702450"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("d77fb0da-b731-4e79-8a74-bcd233ced6d1"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("de1c7ef1-8bcc-4681-826b-a5722992efce"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("dfffdcea-b17e-4de6-afc8-be9a153a4850"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("e152a542-719e-4db5-b669-e89aaf8fff4b"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("e2b98d5f-4681-4cd2-a742-82c78b430405"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("e84d9ddc-fa3c-4013-b46f-cd4ab075d72f"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("eac01733-cd96-47b0-a777-9d1e7f04bf14"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("ee2fbce5-ae95-4c2c-a476-749a1319c047"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("08ff011c-79b8-481e-b4a3-cbef86598b8d"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("0a73ecf0-b9a0-4ad1-b5b1-48bc9495c047"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("24eb5751-d5f4-43ab-a5c6-015c8e6aaad3"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("39856b79-c2a6-41fb-b052-539ed4f1ce36"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("4b8ad4ad-c5d6-4adc-9d32-89cf04f7322c"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("66c17e6c-5496-4000-bb9e-f54fa7766969"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("7e00c6c8-1b87-4f29-93f5-aed470c65b3d"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("99fdefe6-d718-46bd-924b-29bb7f90c23b"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("ca221640-e844-441f-a6a0-4ffb025bc7ae"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("cdb4aad9-dfb2-47a1-b4f3-7baac9bbaadb"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("e44ac0ed-fdc6-4ad0-880f-77ff9c2ae578"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("ef64b1fd-dbd1-4330-911b-05da9effd861"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("43d30116-2ff8-4ea7-af30-b2f1b2439c1d"), "User" });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("7fca4a4a-297f-4418-a680-f5d57bc78cf5"), "Admin" });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("0f43d2b0-1e01-4ac2-8ab4-cc431ab2d3e6"), new Guid("b370e0f3-b909-4a9d-b396-6f1bf22d41fb") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("37755108-3a0d-4ccc-b0a1-42b602645ae3"), new Guid("e0c31d7a-1ef7-4bf2-9447-f3e8a0bfcfb9") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("9e37ac33-66fe-4899-ac61-b8642ee2c98a"), new Guid("0a1a5e04-e563-4dac-9fee-de27cde80334") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("ef72b719-d20a-4798-9a11-b5a0fc1bb809"), new Guid("59f00599-0c60-48a0-a301-edd67b60bd19") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("f1560f53-6e08-4ec5-ab6a-d84dd18d53bd"), new Guid("28bfaec5-5732-4c9e-8208-3217379ad616") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("0f43d2b0-1e01-4ac2-8ab4-cc431ab2d3e6"), new Guid("b370e0f3-b909-4a9d-b396-6f1bf22d41fb") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("37755108-3a0d-4ccc-b0a1-42b602645ae3"), new Guid("e0c31d7a-1ef7-4bf2-9447-f3e8a0bfcfb9") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("9e37ac33-66fe-4899-ac61-b8642ee2c98a"), new Guid("0a1a5e04-e563-4dac-9fee-de27cde80334") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("ef72b719-d20a-4798-9a11-b5a0fc1bb809"), new Guid("59f00599-0c60-48a0-a301-edd67b60bd19") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("f1560f53-6e08-4ec5-ab6a-d84dd18d53bd"), new Guid("28bfaec5-5732-4c9e-8208-3217379ad616") });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0d5b7004-613c-4ff5-b77b-7dcafe35d286"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4b8ddfe2-f7c1-4f7c-a4c7-c294e4c31aa1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("54d76b05-f328-4b38-ab4c-00daae464cd9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d79c5d70-a52f-45b7-89e0-9435bdc62bd7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dd5ff859-ab2e-435a-84f2-fb0eeb6e43fd"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0a1a5e04-e563-4dac-9fee-de27cde80334"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("28bfaec5-5732-4c9e-8208-3217379ad616"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("2db52882-1c4b-4833-a1d6-f8b8d6340f3d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3728e294-f378-4447-8a0a-b42f57f55d6f"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("376e9bcc-b88f-4594-8f05-cb6e485b8ea3"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("4e81066c-4092-4a53-a37f-90c1734bf565"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("59f00599-0c60-48a0-a301-edd67b60bd19"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6be3f698-ece3-4398-a206-da9cb9f0b14b"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("98c31201-2c55-4c12-9dd0-51a133ae3efc"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a792a400-8613-494a-b7b1-862842ca53ea"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("aec4463e-dfaa-4277-93f7-e5a9465179b5"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b370e0f3-b909-4a9d-b396-6f1bf22d41fb"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("beedc884-d5cb-4d0f-b046-db6df8c89b4a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("c14c9ad8-e166-4c91-8189-b0783abe17e7"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d2c17fba-3ef8-401e-ae8d-fd7a096130df"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e0c31d7a-1ef7-4bf2-9447-f3e8a0bfcfb9"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ec0194ee-8880-4a55-8477-2cfaf3f5a6d2"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f624db70-be06-4c88-ac4d-c954bc644e49"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("fef22046-66cb-4ed7-9e5a-b26f6e5b5735"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("10570df6-3e26-4876-8fe7-4cc647a9e5fd"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("135b51ba-37f9-4ae7-9689-03e360d95ed6"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("f9d8b4af-e2b9-4d7b-a452-9df2f5b01cc4"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("0f43d2b0-1e01-4ac2-8ab4-cc431ab2d3e6"), "f83cdd40-273d-4f49-b845-fce47e28aa6a" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("37755108-3a0d-4ccc-b0a1-42b602645ae3"), "80cd8fdc-7018-414e-8540-4e03183bfe6a" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("9e37ac33-66fe-4899-ac61-b8642ee2c98a"), "5ef2c6d6-65b8-4701-9fc2-4934a883ac4f" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("ef72b719-d20a-4798-9a11-b5a0fc1bb809"), "14740f16-7a23-4a70-bcb9-8a6c4377e6bd" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("f1560f53-6e08-4ec5-ab6a-d84dd18d53bd"), "b42b1d35-6c89-4f34-a016-548be02f34d0" });

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("16da2616-1346-4496-a2fe-9928c7ab46f5"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("227c9675-abf8-41d7-8add-8f362c863d93"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("24639b81-3afb-4b17-b892-5d3df6295376"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3d8c48b6-af4e-4a59-b0e4-ea842d6ebfa5"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("617f4150-99cf-4704-9dda-05e77db71502"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("80b68798-e7d0-4c75-b8b1-e300ca2b90d6"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9b02c6a1-88b2-418a-a594-4ebad51a3b22"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("a3fcbf76-b07a-46a2-98b9-3b9cd924b0bd"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("ea230f27-0e38-446a-898b-1780f205d9e9"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("ff6f33a2-39b7-417b-b16f-da06bd526b23"), "FPS" },
                    { new Guid("390b789c-f4e7-4f7d-9882-203618142c88"), "Action" },
                    { new Guid("f19c57cd-9df9-47fe-bd6d-5ff88ecb861d"), "Adventure" },
                    { new Guid("db85a760-21a8-40dd-a422-1f92ecd8b4f2"), "Puzzle" },
                    { new Guid("e2d1cb35-efdc-4c26-b74e-79fb39d2150c"), "Open world" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Money", "Name", "Reliability" },
                values: new object[,]
                {
                    { new Guid("93ec7248-4f8e-4f37-9e77-6d81b43341ac"), 0, "King", 0 },
                    { new Guid("49b359ec-f164-4554-88a6-ab63eba0b0cc"), 0, "Rovio Entertainment Corporation", 0 },
                    { new Guid("94270087-1093-4e81-baa7-98d2bd4b6fb6"), 0, "Outfit7 Limited", 0 },
                    { new Guid("78219330-10f7-42bf-956f-78ef88586abe"), 0, "AMANOTES", 0 },
                    { new Guid("c822d579-a881-40fc-a829-448941da5d77"), 0, "Gameloft", 0 },
                    { new Guid("f9b04b36-c34b-40e2-91fb-2f5130a5fce5"), 0, "Mobigame S.A.R.L.", 0 },
                    { new Guid("69d2a46f-3517-4d32-be77-396d274d0ef0"), 0, "Imangi Studios", 0 },
                    { new Guid("e583d217-d55f-4a8f-8f99-c0efb9d3ea57"), 0, "NEKKI", 0 },
                    { new Guid("95e4dbb5-e5f1-451a-afaf-5d7245edb237"), 0, "Kiloo", 0 },
                    { new Guid("f2c500c3-ce71-485e-9f01-a3a4a85acea9"), 0, "ZeptoLab", 0 },
                    { new Guid("869d8d33-9f0a-42c1-b8f2-c4a51a909f73"), 0, "ELECTRONIC ARTS", 0 },
                    { new Guid("e6bf3202-40c6-430e-a3a0-a0846f3c2356"), 0, "J-PARK", 0 }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("a9ac8e60-1567-4be6-8703-34410be84c38"), "User", "Limited Permission", "User", "User" },
                    { new Guid("c404b6e0-05cc-4de2-a045-28841a63e392"), "Admin", "Full Permission", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Hobbies", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("7b103927-28b2-4d94-a855-1b4affbf6948"), 0, "e7ac42a5-1d29-4828-a160-2ab55c7e1fc9", "duykkxm92@gmail.com", false, "Nguyen Ngoc Duy", "Hobbies", false, null, null, null, "duykkxm92", "01638789455", false, null, false, "duykkxm92" },
                    { new Guid("dc7fdfaa-16be-48b2-8a42-813b7d6cd18f"), 0, "9efcf71a-b098-441b-81dc-9c7b6126961f", "Email1@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509228098523", false, null, false, "UserName1" },
                    { new Guid("ed75e64a-9d3c-443b-9cec-40daae6129f6"), 0, "b611ab40-fcb2-4f5a-ac6d-ba325cba729a", "Email2@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098559238098523", false, null, false, "UserName2" },
                    { new Guid("7bbe887b-75cb-4c49-b07e-3029d528b7b2"), 0, "62d9ec2d-a3e4-4420-92a4-e98f6eb07690", "Email3@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098609238098523", false, null, false, "UserName3" },
                    { new Guid("d61784d1-f996-4f96-8694-3c2a4724116f"), 0, "a047e33a-4924-4054-828f-da4d069e163e", "Email4@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509738098523", false, null, false, "UserName4" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Content", "Name", "Price", "PublisherId", "Rating", "ReleaseDate", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("276b25c4-7c11-4f5c-8da5-952331eab059"), "DASH as fast as you can! DODGE the oncoming trains!Help Jake, Tricky & Fresh escape from the grumpy Inspector and his dog.  Grind trains with your cool crew!  Colorful and vivid HD graphics!  Hoverboard Surfing!  Paint powered jetpack!  Lightning fast swipe acrobatics!  Challenge and help your friends!", "Subway Surfers", 0f, new Guid("95e4dbb5-e5f1-451a-afaf-5d7245edb237"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("c378ead8-6c5d-4f2a-a087-372760b967d0"), "Use the unique powers of the Angry Birds to destroy the greedy pigs' defenses! The survival of the Angry Birds is at stake. Dish out revenge on the greedy pigs who stole their eggs. Use the unique powers of each bird to destroy the pigs’ defenses. Angry Birds features challenging physics-based gameplay and hours of replay value. Each level requires logic, skill and force to solve.", "Angry Birds Classic", 100000f, new Guid("49b359ec-f164-4554-88a6-ab63eba0b0cc"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("27e50ead-ffd1-474f-941d-56f4c88cad3d"), "Is it a baby? Is it a puppy? No! It’s Talking Tom! The cutest kitten, the coolest cat, and the biggest superstar in the world! My Talking Tom is the best virtual pet game for children, and big kids of all ages.That’s right - even grandma and grandpa can join the fun!", "My Talking Tom", 100000f, new Guid("94270087-1093-4e81-baa7-98d2bd4b6fb6"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("71b52a7f-d63a-484e-9c85-13eba911559a"), "Dragon Mania Legends is for anyone that wants their very own pet dragon, which is obviously everyone… – Gamezebo", "Dragon Mania Legends", 100000f, new Guid("78219330-10f7-42bf-956f-78ef88586abe"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("ccb3a8f1-3d83-4d08-bf3c-3da91dc86513"), "Play the award-winning hit action-strategy adventure where you meet, greet, and defeat legions of hilarious zombies from the dawn of time, to the end of days. Amass an army of amazing plants, supercharge them with Plant Food, and devise the ultimate plan to protect your brain.", "Plants vs Zombies 2 Free", 0f, new Guid("78219330-10f7-42bf-956f-78ef88586abe"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("057d9225-6c61-4815-a80c-96fb280de429"), "Magic Tiles 3 ™ is one of the most loved piano games among thousands of free games in 2018 which has more than 80 million players around the world.", "Magic Tiles 3", 100000f, new Guid("78219330-10f7-42bf-956f-78ef88586abe"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("3b67129b-c490-44ab-a72d-976353d79ebb"), "The time to take action and strike back is now! We’re calling for the best sniper in the world to take aim at evil, wherever it hides.There’s no room for remorse, so shoot to kill…", "Sniper Fury: Top shooting game - FPS", 100000f, new Guid("93ec7248-4f8e-4f37-9e77-6d81b43341ac"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("f4397b7d-2c1e-42db-8b3a-47448702a748"), "Follow the adventure of Om Nom in the first part of the legendary Cut the Rope logic puzzles series. Get it now for free and start playing with millions of players around the world!", "Cut the Rope FULL FREE", 0f, new Guid("93ec7248-4f8e-4f37-9e77-6d81b43341ac"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("6ad4ec49-8b0a-4e66-9aa6-e7a4274bd969"), "Strap on your running shoes and join the award-winning, fan-favorite runner, Minion Rush. Enter Gru's Lair, discover its many mysterious rooms, and take on manic missions around the world. Along the way, your Minions will jump, roll and dodge obstacles while unlocking a collection of cool Minion costumes.", "Minion Rush: Despicable Me Official Game", 100000f, new Guid("49b359ec-f164-4554-88a6-ab63eba0b0cc"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("276f1de9-c5f1-42c7-8aed-e507d6bae821"), "A strange group of enemies appeared in the city and have been using innocent people as experimental tools. Lots of people have turned into Zombie so that Hero and his friends should save the people and remove the enemies.", "Anger of stick 5 : zombie", 100000f, new Guid("93ec7248-4f8e-4f37-9e77-6d81b43341ac"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("ff70826c-8e51-451a-bb00-928bd3ac5c0a"), "5 lớp nhân vật tùy biến có thể lên cấp cả trong chơi đơn lẫn chơi mạng. Kiếm và dùng Điểm Kĩ năng để kích hoạt kĩ năng riêng của từng lớp nhân vật. Đấu Đội trong các trận Chơi mạng. Bảng xếp hạng Cá nhân và Đội. Nói chuyện với người chơi khác trong mục Chat Toàn cầu và Đội. Nhiệm vụ tiết tấu nhanh với nhiều thử thách khác nhau từ Tokyo đến Venice.", "Modern Combat 5: eSports FPS", 100000f, new Guid("869d8d33-9f0a-42c1-b8f2-c4a51a909f73"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("0291eb80-a898-4dcd-a846-3475786ff3bf"), "Get ready to soil your plants as a mob of fun-loving zombies is about to invade your home. Use your arsenal of 49 zombie-zapping plants — peashooters, wall-nuts, cherry bombs and more — to mulchify 26 types of zombies before they break down your door.", "Plants vs. Zombies FREE", 100000f, new Guid("869d8d33-9f0a-42c1-b8f2-c4a51a909f73"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("85db9c3e-0dc3-495d-9b56-04bc61506685"), "With over a zillion downloads, Temple Run redefined mobile gaming. Now get more of the exhilarating running, jumping, turning and sliding you love in Temple Run 2! Navigate perilous cliffs, zip lines, mines and forests as you try to escape with the cursed idol. How far can you run ? !", "Temple Run 2", 50000f, new Guid("69d2a46f-3517-4d32-be77-396d274d0ef0"), 4.3f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("603e3423-2690-4601-8c05-6217e95aaa13"), "N.O.V.A. Legacy brings you the best 3D sci-fi FPS experience based on the epic first episode of N.O.V.A., which received critical acclaim -- all in a compact version of the shooter. Kal Wardin, our hero, is a veteran N.O.V.A. marine, summoned once again to don his Mobile Armored Suit and strike against the enemies of the Colonial Administration forces. Helped by Yelena, his personal AI Agent, Kal must protect humanity's destiny by engaging in combat against alien invaders while uncovering the mystery behind their sudden assault.", "N.O.V.A. Legacy", 100000f, new Guid("f9b04b36-c34b-40e2-91fb-2f5130a5fce5"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("853cbdd6-2a76-4601-91a2-e7c23685c853"), "In Asphalt 8, you’ll race in some of the hottest, most high-performance dream machines ever created, from cars to bikes, as you take them on a global tour of speed. From the blazing Nevada Desert to the tight turns of Tokyo, you’ll find a world of challenge, excitement and arcade fun on your road to the top!", "Asphalt 8: Airborne", 100000f, new Guid("f9b04b36-c34b-40e2-91fb-2f5130a5fce5"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("992b1dc7-829a-417b-87a4-7ac103cb9199"), "The zombies are revolting ! Attack the city with a horde of zombies, change pedestrians into zombies and create the largest horde. Eat your friends, and challenge them to a crazy race by destroying everything in your path. Zombie Tsunami has proudly exceeded 200 million players around the world.", "Zombie Tsunami", 100000f, new Guid("f9b04b36-c34b-40e2-91fb-2f5130a5fce5"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("469d7595-4311-45a2-98ac-f2ae78215335"), "Help Swampy by guiding water to his broken shower. Each level is a challenging physics-based puzzle with amazing life-like mechanics. Cut through dirt and guide fresh water, dirty water, toxic water, steam, and ooze through increasingly challenging scenarios! Every drop count", "Where's My Water? Free", 0f, new Guid("95e4dbb5-e5f1-451a-afaf-5d7245edb237"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("d8938522-0605-4209-a540-32395cc8d833"), "Start playing Candy Crush Saga today – loved by millions of players around the world. With over a trillion levels played, this sweet match 3 puzzle game is one of the most popular mobile games of all time!", "Candy Crush Saga", 100000f, new Guid("93ec7248-4f8e-4f37-9e77-6d81b43341ac"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("99586dc1-27a2-4afe-92f2-ce19171e84ef"), "The sequel to the famous Facebook smash hit with 40 million users Shadow Fight 2 is a nail-biting mix of RPG and classical Fighting. This game lets you equip your character with countless lethal weapons and rare armor sets, and features dozens of lifelike-animated Martial Arts techniques! Crush your enemies, humiliate demon bosses, and be the one to close the Gate of Shadows. Do you have what it takes to kick, punch, jump, and slash your way to victory? There’s only one way to find out", "Shadow Fight 2", 100000f, new Guid("e583d217-d55f-4a8f-8f99-c0efb9d3ea57"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" }
                });

            migrationBuilder.InsertData(
                table: "CategoryGames",
                columns: new[] { "GameId", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("276b25c4-7c11-4f5c-8da5-952331eab059"), new Guid("ff6f33a2-39b7-417b-b16f-da06bd526b23") },
                    { new Guid("d8938522-0605-4209-a540-32395cc8d833"), new Guid("e2d1cb35-efdc-4c26-b74e-79fb39d2150c") },
                    { new Guid("992b1dc7-829a-417b-87a4-7ac103cb9199"), new Guid("390b789c-f4e7-4f7d-9882-203618142c88") },
                    { new Guid("0291eb80-a898-4dcd-a846-3475786ff3bf"), new Guid("db85a760-21a8-40dd-a422-1f92ecd8b4f2") },
                    { new Guid("85db9c3e-0dc3-495d-9b56-04bc61506685"), new Guid("f19c57cd-9df9-47fe-bd6d-5ff88ecb861d") }
                });

            migrationBuilder.InsertData(
                table: "FreeCodes",
                columns: new[] { "Id", "Code", "GameId" },
                values: new object[,]
                {
                    { new Guid("9cf74a9d-ef74-49a4-92c6-f393b1c16da9"), "bab9905a-1200-464a-94e2-ad311db4db5b", new Guid("d8938522-0605-4209-a540-32395cc8d833") },
                    { new Guid("21b65ef7-9530-4d65-9665-806559a70331"), "40e0619f-f956-46ed-8e1c-4f64fa395706", new Guid("0291eb80-a898-4dcd-a846-3475786ff3bf") },
                    { new Guid("aa286cc3-dc47-4c76-bfc9-22114d3f2384"), "4cde5ec2-8f61-4cff-ac60-f12be6a963cc", new Guid("85db9c3e-0dc3-495d-9b56-04bc61506685") },
                    { new Guid("bb717a87-0571-41e2-9c09-d4b5482a264a"), "13e06a0d-4990-42e8-836f-743a8e121e72", new Guid("992b1dc7-829a-417b-87a4-7ac103cb9199") },
                    { new Guid("eee84308-a10b-4807-8fe3-2f52f16d63d0"), "54a97814-7275-4820-9068-c52d9311320b", new Guid("276b25c4-7c11-4f5c-8da5-952331eab059") }
                });

            migrationBuilder.InsertData(
                table: "UserGames",
                columns: new[] { "UserId", "GameId", "PurchaseDate" },
                values: new object[,]
                {
                    { new Guid("dc7fdfaa-16be-48b2-8a42-813b7d6cd18f"), new Guid("992b1dc7-829a-417b-87a4-7ac103cb9199"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d61784d1-f996-4f96-8694-3c2a4724116f"), new Guid("d8938522-0605-4209-a540-32395cc8d833"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ed75e64a-9d3c-443b-9cec-40daae6129f6"), new Guid("85db9c3e-0dc3-495d-9b56-04bc61506685"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7bbe887b-75cb-4c49-b07e-3029d528b7b2"), new Guid("0291eb80-a898-4dcd-a846-3475786ff3bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7b103927-28b2-4d94-a855-1b4affbf6948"), new Guid("276b25c4-7c11-4f5c-8da5-952331eab059"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "WishGame",
                columns: new[] { "UserId", "GameId" },
                values: new object[,]
                {
                    { new Guid("ed75e64a-9d3c-443b-9cec-40daae6129f6"), new Guid("85db9c3e-0dc3-495d-9b56-04bc61506685") },
                    { new Guid("7b103927-28b2-4d94-a855-1b4affbf6948"), new Guid("276b25c4-7c11-4f5c-8da5-952331eab059") },
                    { new Guid("7bbe887b-75cb-4c49-b07e-3029d528b7b2"), new Guid("0291eb80-a898-4dcd-a846-3475786ff3bf") },
                    { new Guid("dc7fdfaa-16be-48b2-8a42-813b7d6cd18f"), new Guid("992b1dc7-829a-417b-87a4-7ac103cb9199") },
                    { new Guid("d61784d1-f996-4f96-8694-3c2a4724116f"), new Guid("d8938522-0605-4209-a540-32395cc8d833") }
                });
        }
    }
}
