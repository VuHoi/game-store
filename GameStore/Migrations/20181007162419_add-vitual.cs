using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStore.Migrations
{
    public partial class addvitual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("c044a561-a4cc-46ce-b60e-44ee715e5387"), "Url Image Here", "Title here" },
                    { new Guid("abb78c40-f50a-4654-bd34-b5f880320ac9"), "Url Image Here", "Title here" },
                    { new Guid("b7be593e-8c3b-4065-87cf-549e93388388"), "Url Image Here", "Title here" },
                    { new Guid("677f4b2c-fd57-47b6-8de1-b291b76e907c"), "Url Image Here", "Title here" },
                    { new Guid("206da7db-4d6d-4a47-8ec1-6ebc0c67db11"), "Url Image Here", "Title here" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Money", "Name", "Reliability" },
                values: new object[,]
                {
                    { new Guid("e18eea4b-992e-438d-9e3c-7522018fc629"), 10000000, "Name here", 5 },
                    { new Guid("ee1c0ac7-7ade-40eb-a05e-b1e72428396c"), 10000000, "Name here", 5 },
                    { new Guid("558e68d3-ac8d-4b34-a41d-340ff0e1eb92"), 10000000, "Name here", 5 },
                    { new Guid("20077c42-3d31-4444-8690-cabe5a2f276f"), 10000000, "Name here", 5 },
                    { new Guid("7aa72e40-d2a7-4726-a294-08abb48535bc"), 10000000, "Name here", 5 },
                    { new Guid("805d05cb-81cf-4941-8b79-b4d5ce41bb75"), 10000000, "Name here", 5 }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0984936d-7b21-47a0-a887-d530dca0c2af"), "User", "Limited Permission", "User", "User" },
                    { new Guid("5342bdfd-9b08-44ab-89a7-65175063ed61"), "Admin", "Full Permission", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Hobbies", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("beed1a4f-8218-4ef0-8418-11c51f29499a"), 0, "607825a7-9360-4fc2-a882-bc36161aa379", "Email@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509238098523", false, null, false, "UserName" },
                    { new Guid("e18b89f8-1f05-4a9d-b192-9cd59c9b2f30"), 0, "53345f54-c74f-4a0b-9f52-0db2b5d3c328", "Email1@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509228098523", false, null, false, "UserName1" },
                    { new Guid("359d7ca0-484e-4972-b93f-69c34cdb9fc2"), 0, "31119051-6320-4b1b-ac70-966acfe90020", "Email2@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098559238098523", false, null, false, "UserName2" },
                    { new Guid("41973f50-7b9a-48fe-ba2f-bdebc1c793bd"), 0, "b16198c3-e19f-4d8f-b905-a024c6dab847", "Email3@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098609238098523", false, null, false, "UserName3" },
                    { new Guid("fa58401d-2e2a-417e-bd29-1d13c832cadf"), 0, "06dd30aa-5ea6-4ee5-93e6-cb1b112d3938", "Email4@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509738098523", false, null, false, "UserName4" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Content", "Logo", "Name", "Price", "PublisherId", "PurchaseDate", "Rating", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("7a9bbfa0-be7d-4b73-8029-19625b50442e"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("558e68d3-ac8d-4b34-a41d-340ff0e1eb92"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("e34a66ea-d633-4786-a32a-783f7d5fd3a7"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("e18eea4b-992e-438d-9e3c-7522018fc629"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("7bb680d1-9bfd-4c8b-9a1b-35b69f7165c6"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("7aa72e40-d2a7-4726-a294-08abb48535bc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("c0e5d622-bf12-493d-82ee-fbbc48ae1121"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("805d05cb-81cf-4941-8b79-b4d5ce41bb75"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("872f8cff-1be2-4c68-89f6-f68afc957df9"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("20077c42-3d31-4444-8690-cabe5a2f276f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" }
                });

            migrationBuilder.InsertData(
                table: "CategoryGames",
                columns: new[] { "GameId", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("7a9bbfa0-be7d-4b73-8029-19625b50442e"), new Guid("c044a561-a4cc-46ce-b60e-44ee715e5387") },
                    { new Guid("872f8cff-1be2-4c68-89f6-f68afc957df9"), new Guid("206da7db-4d6d-4a47-8ec1-6ebc0c67db11") },
                    { new Guid("e34a66ea-d633-4786-a32a-783f7d5fd3a7"), new Guid("abb78c40-f50a-4654-bd34-b5f880320ac9") },
                    { new Guid("c0e5d622-bf12-493d-82ee-fbbc48ae1121"), new Guid("677f4b2c-fd57-47b6-8de1-b291b76e907c") },
                    { new Guid("7bb680d1-9bfd-4c8b-9a1b-35b69f7165c6"), new Guid("b7be593e-8c3b-4065-87cf-549e93388388") }
                });

            migrationBuilder.InsertData(
                table: "CodeFrees",
                columns: new[] { "Id", "Code", "GameId" },
                values: new object[,]
                {
                    { new Guid("8854734d-bf30-4817-956b-3d1a6e46459e"), "c3b34bf8-6faa-48e4-bd4d-c6f3ec31feb6", new Guid("872f8cff-1be2-4c68-89f6-f68afc957df9") },
                    { new Guid("beccfa44-626d-4074-bc85-db6df980e7b0"), "683f852f-d4ad-4956-a425-6edb36940587", new Guid("c0e5d622-bf12-493d-82ee-fbbc48ae1121") },
                    { new Guid("8a7aabfc-64b9-4e3c-aac5-419728a7c87c"), "31b8964c-1c6d-4d0a-943e-108f5d9b7768", new Guid("7bb680d1-9bfd-4c8b-9a1b-35b69f7165c6") },
                    { new Guid("b0559124-f314-40b8-aa66-5902ede5cbed"), "b4ba3419-794f-4d02-8310-c9e71ea30793", new Guid("e34a66ea-d633-4786-a32a-783f7d5fd3a7") },
                    { new Guid("a3bcceca-9c1a-4c38-abac-4e3ee17a2acc"), "56da0ec5-42e8-4044-8354-fb120acea189", new Guid("7a9bbfa0-be7d-4b73-8029-19625b50442e") }
                });

            migrationBuilder.InsertData(
                table: "UserGames",
                columns: new[] { "UserId", "GameId" },
                values: new object[,]
                {
                    { new Guid("e18b89f8-1f05-4a9d-b192-9cd59c9b2f30"), new Guid("e34a66ea-d633-4786-a32a-783f7d5fd3a7") },
                    { new Guid("fa58401d-2e2a-417e-bd29-1d13c832cadf"), new Guid("872f8cff-1be2-4c68-89f6-f68afc957df9") },
                    { new Guid("359d7ca0-484e-4972-b93f-69c34cdb9fc2"), new Guid("7bb680d1-9bfd-4c8b-9a1b-35b69f7165c6") },
                    { new Guid("41973f50-7b9a-48fe-ba2f-bdebc1c793bd"), new Guid("c0e5d622-bf12-493d-82ee-fbbc48ae1121") },
                    { new Guid("beed1a4f-8218-4ef0-8418-11c51f29499a"), new Guid("7a9bbfa0-be7d-4b73-8029-19625b50442e") }
                });

            migrationBuilder.InsertData(
                table: "WishGame",
                columns: new[] { "UserId", "GameId" },
                values: new object[,]
                {
                    { new Guid("359d7ca0-484e-4972-b93f-69c34cdb9fc2"), new Guid("7bb680d1-9bfd-4c8b-9a1b-35b69f7165c6") },
                    { new Guid("beed1a4f-8218-4ef0-8418-11c51f29499a"), new Guid("7a9bbfa0-be7d-4b73-8029-19625b50442e") },
                    { new Guid("41973f50-7b9a-48fe-ba2f-bdebc1c793bd"), new Guid("c0e5d622-bf12-493d-82ee-fbbc48ae1121") },
                    { new Guid("e18b89f8-1f05-4a9d-b192-9cd59c9b2f30"), new Guid("e34a66ea-d633-4786-a32a-783f7d5fd3a7") },
                    { new Guid("fa58401d-2e2a-417e-bd29-1d13c832cadf"), new Guid("872f8cff-1be2-4c68-89f6-f68afc957df9") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("7a9bbfa0-be7d-4b73-8029-19625b50442e"), new Guid("c044a561-a4cc-46ce-b60e-44ee715e5387") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("7bb680d1-9bfd-4c8b-9a1b-35b69f7165c6"), new Guid("b7be593e-8c3b-4065-87cf-549e93388388") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("872f8cff-1be2-4c68-89f6-f68afc957df9"), new Guid("206da7db-4d6d-4a47-8ec1-6ebc0c67db11") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("c0e5d622-bf12-493d-82ee-fbbc48ae1121"), new Guid("677f4b2c-fd57-47b6-8de1-b291b76e907c") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("e34a66ea-d633-4786-a32a-783f7d5fd3a7"), new Guid("abb78c40-f50a-4654-bd34-b5f880320ac9") });

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("8854734d-bf30-4817-956b-3d1a6e46459e"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("8a7aabfc-64b9-4e3c-aac5-419728a7c87c"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("a3bcceca-9c1a-4c38-abac-4e3ee17a2acc"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("b0559124-f314-40b8-aa66-5902ede5cbed"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("beccfa44-626d-4074-bc85-db6df980e7b0"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("ee1c0ac7-7ade-40eb-a05e-b1e72428396c"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("0984936d-7b21-47a0-a887-d530dca0c2af"), "User" });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("5342bdfd-9b08-44ab-89a7-65175063ed61"), "Admin" });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("359d7ca0-484e-4972-b93f-69c34cdb9fc2"), new Guid("7bb680d1-9bfd-4c8b-9a1b-35b69f7165c6") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("41973f50-7b9a-48fe-ba2f-bdebc1c793bd"), new Guid("c0e5d622-bf12-493d-82ee-fbbc48ae1121") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("beed1a4f-8218-4ef0-8418-11c51f29499a"), new Guid("7a9bbfa0-be7d-4b73-8029-19625b50442e") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("e18b89f8-1f05-4a9d-b192-9cd59c9b2f30"), new Guid("e34a66ea-d633-4786-a32a-783f7d5fd3a7") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("fa58401d-2e2a-417e-bd29-1d13c832cadf"), new Guid("872f8cff-1be2-4c68-89f6-f68afc957df9") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("359d7ca0-484e-4972-b93f-69c34cdb9fc2"), new Guid("7bb680d1-9bfd-4c8b-9a1b-35b69f7165c6") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("41973f50-7b9a-48fe-ba2f-bdebc1c793bd"), new Guid("c0e5d622-bf12-493d-82ee-fbbc48ae1121") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("beed1a4f-8218-4ef0-8418-11c51f29499a"), new Guid("7a9bbfa0-be7d-4b73-8029-19625b50442e") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("e18b89f8-1f05-4a9d-b192-9cd59c9b2f30"), new Guid("e34a66ea-d633-4786-a32a-783f7d5fd3a7") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("fa58401d-2e2a-417e-bd29-1d13c832cadf"), new Guid("872f8cff-1be2-4c68-89f6-f68afc957df9") });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("206da7db-4d6d-4a47-8ec1-6ebc0c67db11"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("677f4b2c-fd57-47b6-8de1-b291b76e907c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("abb78c40-f50a-4654-bd34-b5f880320ac9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b7be593e-8c3b-4065-87cf-549e93388388"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c044a561-a4cc-46ce-b60e-44ee715e5387"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("7a9bbfa0-be7d-4b73-8029-19625b50442e"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("7bb680d1-9bfd-4c8b-9a1b-35b69f7165c6"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("872f8cff-1be2-4c68-89f6-f68afc957df9"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("c0e5d622-bf12-493d-82ee-fbbc48ae1121"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e34a66ea-d633-4786-a32a-783f7d5fd3a7"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("359d7ca0-484e-4972-b93f-69c34cdb9fc2"), "31119051-6320-4b1b-ac70-966acfe90020" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("41973f50-7b9a-48fe-ba2f-bdebc1c793bd"), "b16198c3-e19f-4d8f-b905-a024c6dab847" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("beed1a4f-8218-4ef0-8418-11c51f29499a"), "607825a7-9360-4fc2-a882-bc36161aa379" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("e18b89f8-1f05-4a9d-b192-9cd59c9b2f30"), "53345f54-c74f-4a0b-9f52-0db2b5d3c328" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("fa58401d-2e2a-417e-bd29-1d13c832cadf"), "06dd30aa-5ea6-4ee5-93e6-cb1b112d3938" });

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("20077c42-3d31-4444-8690-cabe5a2f276f"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("558e68d3-ac8d-4b34-a41d-340ff0e1eb92"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("7aa72e40-d2a7-4726-a294-08abb48535bc"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("805d05cb-81cf-4941-8b79-b4d5ce41bb75"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("e18eea4b-992e-438d-9e3c-7522018fc629"));

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
    }
}
