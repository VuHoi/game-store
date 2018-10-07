using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStore.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("1eda8992-e858-4167-86e0-b32ee72667ff"), new Guid("b2d90441-d617-45b6-932b-a74e0be41b25") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("4a0a0fae-60ac-4c8a-8307-ec26234ff60f"), new Guid("6c481ca2-c3ab-417f-9118-71b5fd04ca96") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("b040ff96-6537-4768-b8c5-729979993113"), new Guid("6840109d-2440-45bf-ac28-9fd544ec2172") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("d3c6d9db-f60a-4a61-ba41-308c667f2a16"), new Guid("e800efe7-88e7-4957-ae9b-73cf81b21308") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("df203216-f420-4ecf-8265-bf267cb65449"), new Guid("77da9e79-80af-4a35-b507-78acfbfc7007") });

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("1ef9dfc7-4c98-4f67-ab3a-f47dda122c24"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("6124c19a-1c94-4acf-a44c-fa77dc6494f2"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("699cb3c4-9840-4977-8d87-6b6abc02db50"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("77adce59-362a-491e-a769-d5702d6ee784"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("d0fedc90-6956-41a3-9ed9-b566dc08f4d5"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("e1acce29-31b0-4a9b-8772-f82adc28cd2e"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("8345e32c-1313-475b-9e13-380bf2075461"), "User" });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("e29d9e04-6d19-45d7-8953-59b18124ef68"), "Admin" });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("0e388fb6-18ba-4582-b3e1-61545fe5c963"), new Guid("b040ff96-6537-4768-b8c5-729979993113") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("32161737-43fd-4424-a5b6-ee05333e6eed"), new Guid("df203216-f420-4ecf-8265-bf267cb65449") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("49002caa-0090-46d7-8056-be15157b2298"), new Guid("d3c6d9db-f60a-4a61-ba41-308c667f2a16") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("b5175c1e-3f38-4322-8487-4b67b99c7855"), new Guid("4a0a0fae-60ac-4c8a-8307-ec26234ff60f") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("f59f9dea-1a39-4a66-8ff8-7c6d9020dd92"), new Guid("1eda8992-e858-4167-86e0-b32ee72667ff") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("0e388fb6-18ba-4582-b3e1-61545fe5c963"), new Guid("b040ff96-6537-4768-b8c5-729979993113") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("32161737-43fd-4424-a5b6-ee05333e6eed"), new Guid("df203216-f420-4ecf-8265-bf267cb65449") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("49002caa-0090-46d7-8056-be15157b2298"), new Guid("d3c6d9db-f60a-4a61-ba41-308c667f2a16") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("b5175c1e-3f38-4322-8487-4b67b99c7855"), new Guid("4a0a0fae-60ac-4c8a-8307-ec26234ff60f") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("f59f9dea-1a39-4a66-8ff8-7c6d9020dd92"), new Guid("1eda8992-e858-4167-86e0-b32ee72667ff") });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6840109d-2440-45bf-ac28-9fd544ec2172"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6c481ca2-c3ab-417f-9118-71b5fd04ca96"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("77da9e79-80af-4a35-b507-78acfbfc7007"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b2d90441-d617-45b6-932b-a74e0be41b25"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e800efe7-88e7-4957-ae9b-73cf81b21308"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("1eda8992-e858-4167-86e0-b32ee72667ff"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("4a0a0fae-60ac-4c8a-8307-ec26234ff60f"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b040ff96-6537-4768-b8c5-729979993113"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d3c6d9db-f60a-4a61-ba41-308c667f2a16"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("df203216-f420-4ecf-8265-bf267cb65449"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("0e388fb6-18ba-4582-b3e1-61545fe5c963"), "3d03b718-1ea8-4fe0-9ae5-13f9438d6ab6" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("32161737-43fd-4424-a5b6-ee05333e6eed"), "17a09956-88ad-4b5a-85dc-d4cb2858c440" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("49002caa-0090-46d7-8056-be15157b2298"), "847bb3fe-e334-40f7-9dbd-7b29c9f59655" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("b5175c1e-3f38-4322-8487-4b67b99c7855"), "c0d32ca0-2f86-4229-8d92-e67fc6473c79" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("f59f9dea-1a39-4a66-8ff8-7c6d9020dd92"), "6a553f39-da7d-4c81-be80-6709b61c13f1" });

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("18c5ad2f-b0df-496f-8f6c-8cb075db28f1"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("425d69de-43a5-4584-b509-b6ba55649b12"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("4c873a1a-8d45-4b9d-aee5-514d9c5562b4"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cf44c3ca-6689-492e-8c99-96619ab3f215"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("f8b0f5e0-bf11-4a1d-9413-5d9e5203e114"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Title" },
                values: new object[,]
                {
                    { new Guid("a1ec28eb-b936-4aed-bb98-be9be1fd40bc"), "Url Image Here", "Title here" },
                    { new Guid("98324ec4-1cf2-46dd-b624-607c1173cb8e"), "Url Image Here", "Title here" },
                    { new Guid("eb71c1ee-da51-4522-9b8e-34d9ddf41160"), "Url Image Here", "Title here" },
                    { new Guid("a914b203-ed21-465e-8694-dd298bfbce8b"), "Url Image Here", "Title here" },
                    { new Guid("1472c046-1a0c-4fbf-9a35-daa19aff67fb"), "Url Image Here", "Title here" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Money", "Name", "Reliability" },
                values: new object[,]
                {
                    { new Guid("a4745dd1-4787-4a26-a229-9925ccd09718"), 10000000, "Name here", 5 },
                    { new Guid("54295299-1b42-49b6-9560-e937e93f6398"), 10000000, "Name here", 5 },
                    { new Guid("73ccb3bf-e574-4b61-afbd-5de30f31e525"), 10000000, "Name here", 5 },
                    { new Guid("10ede6b4-86d7-407d-adc0-eeba77cd2c41"), 10000000, "Name here", 5 },
                    { new Guid("ea1a70c2-868a-410d-b7ec-5f5a5703fcb0"), 10000000, "Name here", 5 },
                    { new Guid("1b990994-0fbb-4a82-8af1-ba3e5302dc5b"), 10000000, "Name here", 5 }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("cb66fd09-7f5e-4256-be11-5c2a930034a3"), "User", "Limited Permission", "User", "User" },
                    { new Guid("655fdb63-3a70-43fa-8f5b-19805a3a1a3b"), "Admin", "Full Permission", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Hobbies", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("a403753c-dd6f-4cea-8fab-418b0626f20b"), 0, "9c06a449-f0c8-40c4-934c-33fef1e35375", "Email@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509238098523", false, null, false, "UserName" },
                    { new Guid("56dc3db2-b72f-4679-98b2-8ce755bebae7"), 0, "c7130487-1d9f-40d6-b233-ba168264a902", "Email1@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509228098523", false, null, false, "UserName1" },
                    { new Guid("06229f71-88ef-4fd7-9349-31133d072665"), 0, "bcf57312-af48-4953-9a88-21ef729cc9df", "Email2@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098559238098523", false, null, false, "UserName2" },
                    { new Guid("15c556b4-6fab-469a-a8dc-6a5adb98984e"), 0, "6f7c3a44-a3e7-4ac8-9bfe-0deca0c8dc8f", "Email3@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098609238098523", false, null, false, "UserName3" },
                    { new Guid("45afb091-8c2b-48d8-a8c9-75a8818bed77"), 0, "191a8ea5-d17a-4493-8d55-5cf3aa1d103d", "Email4@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509738098523", false, null, false, "UserName4" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Content", "Logo", "Name", "Price", "PublisherId", "PurchaseDate", "Rating", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("ea0c2397-5afc-458e-98ab-b1deeeff5f94"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("73ccb3bf-e574-4b61-afbd-5de30f31e525"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("c0836667-eb7e-49e0-ae05-f39d77ed4790"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("a4745dd1-4787-4a26-a229-9925ccd09718"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("8b70210e-b8d8-43b3-8fc5-6af7c9ecffce"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("ea1a70c2-868a-410d-b7ec-5f5a5703fcb0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("dbb7aa2f-9068-4369-a7ba-0e4315de6b76"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("1b990994-0fbb-4a82-8af1-ba3e5302dc5b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("b512100c-048b-4dd8-be62-571fe19df064"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("10ede6b4-86d7-407d-adc0-eeba77cd2c41"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" }
                });

            migrationBuilder.InsertData(
                table: "CategoryGames",
                columns: new[] { "GameId", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("ea0c2397-5afc-458e-98ab-b1deeeff5f94"), new Guid("a1ec28eb-b936-4aed-bb98-be9be1fd40bc") },
                    { new Guid("b512100c-048b-4dd8-be62-571fe19df064"), new Guid("1472c046-1a0c-4fbf-9a35-daa19aff67fb") },
                    { new Guid("c0836667-eb7e-49e0-ae05-f39d77ed4790"), new Guid("98324ec4-1cf2-46dd-b624-607c1173cb8e") },
                    { new Guid("dbb7aa2f-9068-4369-a7ba-0e4315de6b76"), new Guid("a914b203-ed21-465e-8694-dd298bfbce8b") },
                    { new Guid("8b70210e-b8d8-43b3-8fc5-6af7c9ecffce"), new Guid("eb71c1ee-da51-4522-9b8e-34d9ddf41160") }
                });

            migrationBuilder.InsertData(
                table: "CodeFrees",
                columns: new[] { "Id", "Code", "GameId" },
                values: new object[,]
                {
                    { new Guid("3c9a8de5-86fa-427d-9ee6-9822d91d801d"), "5c35dfe6-45a6-4a68-91fc-f9c6d5c66bc1", new Guid("b512100c-048b-4dd8-be62-571fe19df064") },
                    { new Guid("a5450eab-127b-413d-843e-c3a1ceb2f78d"), "a033b179-5152-4358-a5f2-915419b07a2c", new Guid("dbb7aa2f-9068-4369-a7ba-0e4315de6b76") },
                    { new Guid("83864b18-ad0b-43d9-a5a8-ea787accdbb3"), "34bf310a-d813-4821-ba32-9f1844632617", new Guid("8b70210e-b8d8-43b3-8fc5-6af7c9ecffce") },
                    { new Guid("1dcec842-a150-4767-a0fa-9ca082e01932"), "a026e7cf-c9b3-43d4-abcd-2f2c82513e4b", new Guid("c0836667-eb7e-49e0-ae05-f39d77ed4790") },
                    { new Guid("0518e5b0-7ae7-41b6-8d33-657186cbf171"), "d6957685-745d-407f-8b0d-0bad699a2190", new Guid("ea0c2397-5afc-458e-98ab-b1deeeff5f94") }
                });

            migrationBuilder.InsertData(
                table: "UserGames",
                columns: new[] { "UserId", "GameId" },
                values: new object[,]
                {
                    { new Guid("56dc3db2-b72f-4679-98b2-8ce755bebae7"), new Guid("c0836667-eb7e-49e0-ae05-f39d77ed4790") },
                    { new Guid("45afb091-8c2b-48d8-a8c9-75a8818bed77"), new Guid("b512100c-048b-4dd8-be62-571fe19df064") },
                    { new Guid("06229f71-88ef-4fd7-9349-31133d072665"), new Guid("8b70210e-b8d8-43b3-8fc5-6af7c9ecffce") },
                    { new Guid("15c556b4-6fab-469a-a8dc-6a5adb98984e"), new Guid("dbb7aa2f-9068-4369-a7ba-0e4315de6b76") },
                    { new Guid("a403753c-dd6f-4cea-8fab-418b0626f20b"), new Guid("ea0c2397-5afc-458e-98ab-b1deeeff5f94") }
                });

            migrationBuilder.InsertData(
                table: "WishGame",
                columns: new[] { "UserId", "GameId" },
                values: new object[,]
                {
                    { new Guid("06229f71-88ef-4fd7-9349-31133d072665"), new Guid("8b70210e-b8d8-43b3-8fc5-6af7c9ecffce") },
                    { new Guid("a403753c-dd6f-4cea-8fab-418b0626f20b"), new Guid("ea0c2397-5afc-458e-98ab-b1deeeff5f94") },
                    { new Guid("15c556b4-6fab-469a-a8dc-6a5adb98984e"), new Guid("dbb7aa2f-9068-4369-a7ba-0e4315de6b76") },
                    { new Guid("56dc3db2-b72f-4679-98b2-8ce755bebae7"), new Guid("c0836667-eb7e-49e0-ae05-f39d77ed4790") },
                    { new Guid("45afb091-8c2b-48d8-a8c9-75a8818bed77"), new Guid("b512100c-048b-4dd8-be62-571fe19df064") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("8b70210e-b8d8-43b3-8fc5-6af7c9ecffce"), new Guid("eb71c1ee-da51-4522-9b8e-34d9ddf41160") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("b512100c-048b-4dd8-be62-571fe19df064"), new Guid("1472c046-1a0c-4fbf-9a35-daa19aff67fb") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("c0836667-eb7e-49e0-ae05-f39d77ed4790"), new Guid("98324ec4-1cf2-46dd-b624-607c1173cb8e") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("dbb7aa2f-9068-4369-a7ba-0e4315de6b76"), new Guid("a914b203-ed21-465e-8694-dd298bfbce8b") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("ea0c2397-5afc-458e-98ab-b1deeeff5f94"), new Guid("a1ec28eb-b936-4aed-bb98-be9be1fd40bc") });

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("0518e5b0-7ae7-41b6-8d33-657186cbf171"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("1dcec842-a150-4767-a0fa-9ca082e01932"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("3c9a8de5-86fa-427d-9ee6-9822d91d801d"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("83864b18-ad0b-43d9-a5a8-ea787accdbb3"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("a5450eab-127b-413d-843e-c3a1ceb2f78d"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("54295299-1b42-49b6-9560-e937e93f6398"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("655fdb63-3a70-43fa-8f5b-19805a3a1a3b"), "Admin" });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("cb66fd09-7f5e-4256-be11-5c2a930034a3"), "User" });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("06229f71-88ef-4fd7-9349-31133d072665"), new Guid("8b70210e-b8d8-43b3-8fc5-6af7c9ecffce") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("15c556b4-6fab-469a-a8dc-6a5adb98984e"), new Guid("dbb7aa2f-9068-4369-a7ba-0e4315de6b76") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("45afb091-8c2b-48d8-a8c9-75a8818bed77"), new Guid("b512100c-048b-4dd8-be62-571fe19df064") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("56dc3db2-b72f-4679-98b2-8ce755bebae7"), new Guid("c0836667-eb7e-49e0-ae05-f39d77ed4790") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("a403753c-dd6f-4cea-8fab-418b0626f20b"), new Guid("ea0c2397-5afc-458e-98ab-b1deeeff5f94") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("06229f71-88ef-4fd7-9349-31133d072665"), new Guid("8b70210e-b8d8-43b3-8fc5-6af7c9ecffce") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("15c556b4-6fab-469a-a8dc-6a5adb98984e"), new Guid("dbb7aa2f-9068-4369-a7ba-0e4315de6b76") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("45afb091-8c2b-48d8-a8c9-75a8818bed77"), new Guid("b512100c-048b-4dd8-be62-571fe19df064") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("56dc3db2-b72f-4679-98b2-8ce755bebae7"), new Guid("c0836667-eb7e-49e0-ae05-f39d77ed4790") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("a403753c-dd6f-4cea-8fab-418b0626f20b"), new Guid("ea0c2397-5afc-458e-98ab-b1deeeff5f94") });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1472c046-1a0c-4fbf-9a35-daa19aff67fb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("98324ec4-1cf2-46dd-b624-607c1173cb8e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a1ec28eb-b936-4aed-bb98-be9be1fd40bc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a914b203-ed21-465e-8694-dd298bfbce8b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eb71c1ee-da51-4522-9b8e-34d9ddf41160"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8b70210e-b8d8-43b3-8fc5-6af7c9ecffce"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b512100c-048b-4dd8-be62-571fe19df064"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("c0836667-eb7e-49e0-ae05-f39d77ed4790"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("dbb7aa2f-9068-4369-a7ba-0e4315de6b76"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ea0c2397-5afc-458e-98ab-b1deeeff5f94"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("06229f71-88ef-4fd7-9349-31133d072665"), "bcf57312-af48-4953-9a88-21ef729cc9df" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("15c556b4-6fab-469a-a8dc-6a5adb98984e"), "6f7c3a44-a3e7-4ac8-9bfe-0deca0c8dc8f" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("45afb091-8c2b-48d8-a8c9-75a8818bed77"), "191a8ea5-d17a-4493-8d55-5cf3aa1d103d" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("56dc3db2-b72f-4679-98b2-8ce755bebae7"), "c7130487-1d9f-40d6-b233-ba168264a902" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("a403753c-dd6f-4cea-8fab-418b0626f20b"), "9c06a449-f0c8-40c4-934c-33fef1e35375" });

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("10ede6b4-86d7-407d-adc0-eeba77cd2c41"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("1b990994-0fbb-4a82-8af1-ba3e5302dc5b"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("73ccb3bf-e574-4b61-afbd-5de30f31e525"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("a4745dd1-4787-4a26-a229-9925ccd09718"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("ea1a70c2-868a-410d-b7ec-5f5a5703fcb0"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Title" },
                values: new object[,]
                {
                    { new Guid("6840109d-2440-45bf-ac28-9fd544ec2172"), "Url Image Here", "Title here" },
                    { new Guid("b2d90441-d617-45b6-932b-a74e0be41b25"), "Url Image Here", "Title here" },
                    { new Guid("77da9e79-80af-4a35-b507-78acfbfc7007"), "Url Image Here", "Title here" },
                    { new Guid("e800efe7-88e7-4957-ae9b-73cf81b21308"), "Url Image Here", "Title here" },
                    { new Guid("6c481ca2-c3ab-417f-9118-71b5fd04ca96"), "Url Image Here", "Title here" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Money", "Name", "Reliability" },
                values: new object[,]
                {
                    { new Guid("cf44c3ca-6689-492e-8c99-96619ab3f215"), 10000000, "Name here", 5 },
                    { new Guid("e1acce29-31b0-4a9b-8772-f82adc28cd2e"), 10000000, "Name here", 5 },
                    { new Guid("18c5ad2f-b0df-496f-8f6c-8cb075db28f1"), 10000000, "Name here", 5 },
                    { new Guid("f8b0f5e0-bf11-4a1d-9413-5d9e5203e114"), 10000000, "Name here", 5 },
                    { new Guid("425d69de-43a5-4584-b509-b6ba55649b12"), 10000000, "Name here", 5 },
                    { new Guid("4c873a1a-8d45-4b9d-aee5-514d9c5562b4"), 10000000, "Name here", 5 }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("8345e32c-1313-475b-9e13-380bf2075461"), "User", "Limited Permission", "User", "User" },
                    { new Guid("e29d9e04-6d19-45d7-8953-59b18124ef68"), "Admin", "Full Permission", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Hobbies", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0e388fb6-18ba-4582-b3e1-61545fe5c963"), 0, "3d03b718-1ea8-4fe0-9ae5-13f9438d6ab6", "Email@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509238098523", false, null, false, "UserName" },
                    { new Guid("f59f9dea-1a39-4a66-8ff8-7c6d9020dd92"), 0, "6a553f39-da7d-4c81-be80-6709b61c13f1", "Email1@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509228098523", false, null, false, "UserName1" },
                    { new Guid("32161737-43fd-4424-a5b6-ee05333e6eed"), 0, "17a09956-88ad-4b5a-85dc-d4cb2858c440", "Email2@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098559238098523", false, null, false, "UserName2" },
                    { new Guid("49002caa-0090-46d7-8056-be15157b2298"), 0, "847bb3fe-e334-40f7-9dbd-7b29c9f59655", "Email3@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098609238098523", false, null, false, "UserName3" },
                    { new Guid("b5175c1e-3f38-4322-8487-4b67b99c7855"), 0, "c0d32ca0-2f86-4229-8d92-e67fc6473c79", "Email4@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509738098523", false, null, false, "UserName4" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Content", "Logo", "Name", "Price", "PublisherId", "PurchaseDate", "Rating", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("b040ff96-6537-4768-b8c5-729979993113"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("18c5ad2f-b0df-496f-8f6c-8cb075db28f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("1eda8992-e858-4167-86e0-b32ee72667ff"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("cf44c3ca-6689-492e-8c99-96619ab3f215"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("df203216-f420-4ecf-8265-bf267cb65449"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("425d69de-43a5-4584-b509-b6ba55649b12"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("d3c6d9db-f60a-4a61-ba41-308c667f2a16"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("4c873a1a-8d45-4b9d-aee5-514d9c5562b4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("4a0a0fae-60ac-4c8a-8307-ec26234ff60f"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("f8b0f5e0-bf11-4a1d-9413-5d9e5203e114"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" }
                });

            migrationBuilder.InsertData(
                table: "CategoryGames",
                columns: new[] { "GameId", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("b040ff96-6537-4768-b8c5-729979993113"), new Guid("6840109d-2440-45bf-ac28-9fd544ec2172") },
                    { new Guid("4a0a0fae-60ac-4c8a-8307-ec26234ff60f"), new Guid("6c481ca2-c3ab-417f-9118-71b5fd04ca96") },
                    { new Guid("1eda8992-e858-4167-86e0-b32ee72667ff"), new Guid("b2d90441-d617-45b6-932b-a74e0be41b25") },
                    { new Guid("d3c6d9db-f60a-4a61-ba41-308c667f2a16"), new Guid("e800efe7-88e7-4957-ae9b-73cf81b21308") },
                    { new Guid("df203216-f420-4ecf-8265-bf267cb65449"), new Guid("77da9e79-80af-4a35-b507-78acfbfc7007") }
                });

            migrationBuilder.InsertData(
                table: "CodeFrees",
                columns: new[] { "Id", "Code", "GameId" },
                values: new object[,]
                {
                    { new Guid("699cb3c4-9840-4977-8d87-6b6abc02db50"), "b02ccb71-52f3-497b-950d-100048743a6b", new Guid("4a0a0fae-60ac-4c8a-8307-ec26234ff60f") },
                    { new Guid("1ef9dfc7-4c98-4f67-ab3a-f47dda122c24"), "75db4e4a-b9be-43e4-b541-d836c7a297fa", new Guid("d3c6d9db-f60a-4a61-ba41-308c667f2a16") },
                    { new Guid("77adce59-362a-491e-a769-d5702d6ee784"), "5ea4ef9c-aca4-4aae-bd51-088e6f8ccd2f", new Guid("df203216-f420-4ecf-8265-bf267cb65449") },
                    { new Guid("6124c19a-1c94-4acf-a44c-fa77dc6494f2"), "8dd80a6b-a401-4214-9243-a4d4a7d84587", new Guid("1eda8992-e858-4167-86e0-b32ee72667ff") },
                    { new Guid("d0fedc90-6956-41a3-9ed9-b566dc08f4d5"), "6ff0f86a-563c-4c4d-ab44-e00a4cd62794", new Guid("b040ff96-6537-4768-b8c5-729979993113") }
                });

            migrationBuilder.InsertData(
                table: "UserGames",
                columns: new[] { "UserId", "GameId" },
                values: new object[,]
                {
                    { new Guid("f59f9dea-1a39-4a66-8ff8-7c6d9020dd92"), new Guid("1eda8992-e858-4167-86e0-b32ee72667ff") },
                    { new Guid("b5175c1e-3f38-4322-8487-4b67b99c7855"), new Guid("4a0a0fae-60ac-4c8a-8307-ec26234ff60f") },
                    { new Guid("32161737-43fd-4424-a5b6-ee05333e6eed"), new Guid("df203216-f420-4ecf-8265-bf267cb65449") },
                    { new Guid("49002caa-0090-46d7-8056-be15157b2298"), new Guid("d3c6d9db-f60a-4a61-ba41-308c667f2a16") },
                    { new Guid("0e388fb6-18ba-4582-b3e1-61545fe5c963"), new Guid("b040ff96-6537-4768-b8c5-729979993113") }
                });

            migrationBuilder.InsertData(
                table: "WishGame",
                columns: new[] { "UserId", "GameId" },
                values: new object[,]
                {
                    { new Guid("32161737-43fd-4424-a5b6-ee05333e6eed"), new Guid("df203216-f420-4ecf-8265-bf267cb65449") },
                    { new Guid("0e388fb6-18ba-4582-b3e1-61545fe5c963"), new Guid("b040ff96-6537-4768-b8c5-729979993113") },
                    { new Guid("49002caa-0090-46d7-8056-be15157b2298"), new Guid("d3c6d9db-f60a-4a61-ba41-308c667f2a16") },
                    { new Guid("f59f9dea-1a39-4a66-8ff8-7c6d9020dd92"), new Guid("1eda8992-e858-4167-86e0-b32ee72667ff") },
                    { new Guid("b5175c1e-3f38-4322-8487-4b67b99c7855"), new Guid("4a0a0fae-60ac-4c8a-8307-ec26234ff60f") }
                });
        }
    }
}
