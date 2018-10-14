using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStore.Migrations
{
    public partial class seeddata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Title" },
                values: new object[,]
                {
                    { new Guid("d723b944-d295-457b-b2ea-68775843dc8a"), "Url Image Here", "Title here" },
                    { new Guid("5482f380-50af-477c-993d-e20a96f56256"), "Url Image Here", "Title here" },
                    { new Guid("7e623d51-bd34-4d45-a7ad-af6f77e27b62"), "Url Image Here", "Title here" },
                    { new Guid("82005dcf-7ccd-4182-affa-8403cc2bba40"), "Url Image Here", "Title here" },
                    { new Guid("e2169b4c-5d95-4f5b-a72f-f58c389ce434"), "Url Image Here", "Title here" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Money", "Name", "Reliability" },
                values: new object[,]
                {
                    { new Guid("06a2a15f-34fd-4787-b8d6-7eda3e4f7f07"), 10000000, "Name here", 5 },
                    { new Guid("915da842-62bc-4f4e-9c1f-73a20c18f01c"), 10000000, "Name here", 5 },
                    { new Guid("f59bacb7-3032-4711-8f2e-36c8123c0527"), 10000000, "Name here", 5 },
                    { new Guid("09716228-bd11-4bd9-94fb-cf25a037ef46"), 10000000, "Name here", 5 },
                    { new Guid("75cf0ab5-0b07-4e56-ace2-62297ff2e3de"), 10000000, "Name here", 5 },
                    { new Guid("b7c91955-d125-4ffc-b856-a689d26ac073"), 10000000, "Name here", 5 }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("afc17676-7360-466b-b19e-61c135460299"), "User", "Limited Permission", "User", "User" },
                    { new Guid("9286b375-dd76-4506-a4e6-d839ded95dc4"), "Admin", "Full Permission", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Hobbies", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("9a2abfb7-00a9-4361-97bc-31413aa0eb66"), 0, "f1b14ecf-bbe2-4d03-9a64-bbe2dd7b43b6", "Email@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509238098523", false, null, false, "UserName" },
                    { new Guid("fdfa6328-3798-48f7-a03b-3e751950a1a4"), 0, "ad795d56-a7db-4d75-adc8-354eada9e5eb", "Email1@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509228098523", false, null, false, "UserName1" },
                    { new Guid("24071d67-4d6d-4d9d-958d-ccb73cd6fa90"), 0, "d6e8f12a-3d8b-4690-a667-9645a7cda028", "Email2@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098559238098523", false, null, false, "UserName2" },
                    { new Guid("1b1adaa5-95a0-415e-9f40-0bc8c925d31a"), 0, "f1a828c6-7ae7-4644-a016-c84512bac18e", "Email3@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098609238098523", false, null, false, "UserName3" },
                    { new Guid("2b0c1a6e-6880-4376-9a58-2030323f4f99"), 0, "ee76fa96-e17f-4329-8c47-0f8ee366289c", "Email4@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509738098523", false, null, false, "UserName4" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Content", "Logo", "Name", "Price", "PublisherId", "Rating", "ReleaseDate", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("e2631a6f-7dc8-4956-965e-5f196026c3ad"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("f59bacb7-3032-4711-8f2e-36c8123c0527"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("ff03c0d4-d88a-4a8f-ade8-b57b7708d4c7"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("06a2a15f-34fd-4787-b8d6-7eda3e4f7f07"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("c780fa77-d689-4a13-b879-a7f83a838070"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("75cf0ab5-0b07-4e56-ace2-62297ff2e3de"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("b17fabcf-461f-4eb4-a5a8-c9de46a3ea73"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("b7c91955-d125-4ffc-b856-a689d26ac073"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("e414012f-1b42-4bee-a72b-4398f2b60a14"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("09716228-bd11-4bd9-94fb-cf25a037ef46"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" }
                });

            migrationBuilder.InsertData(
                table: "CategoryGames",
                columns: new[] { "GameId", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("e2631a6f-7dc8-4956-965e-5f196026c3ad"), new Guid("d723b944-d295-457b-b2ea-68775843dc8a") },
                    { new Guid("e414012f-1b42-4bee-a72b-4398f2b60a14"), new Guid("e2169b4c-5d95-4f5b-a72f-f58c389ce434") },
                    { new Guid("ff03c0d4-d88a-4a8f-ade8-b57b7708d4c7"), new Guid("5482f380-50af-477c-993d-e20a96f56256") },
                    { new Guid("b17fabcf-461f-4eb4-a5a8-c9de46a3ea73"), new Guid("82005dcf-7ccd-4182-affa-8403cc2bba40") },
                    { new Guid("c780fa77-d689-4a13-b879-a7f83a838070"), new Guid("7e623d51-bd34-4d45-a7ad-af6f77e27b62") }
                });

            migrationBuilder.InsertData(
                table: "FreeCodes",
                columns: new[] { "Id", "Code", "GameId" },
                values: new object[,]
                {
                    { new Guid("e2e95a94-1621-4ae7-9300-a151e5bbd6a5"), "9af0b0c3-bd26-4409-a2f3-4e1800cb9d79", new Guid("e414012f-1b42-4bee-a72b-4398f2b60a14") },
                    { new Guid("6b94459f-32da-496e-95b5-4389392d8b5f"), "dbdc3c5c-e3bc-4be9-a1c1-82dc3810a7c8", new Guid("b17fabcf-461f-4eb4-a5a8-c9de46a3ea73") },
                    { new Guid("cf6fb8f9-e196-4891-9364-c34dc68fe556"), "732f0c63-89c8-4ac7-8dc3-53ab8addbff9", new Guid("c780fa77-d689-4a13-b879-a7f83a838070") },
                    { new Guid("de233f16-5c92-4248-8916-ae5227d50b4b"), "03b71e20-13af-40b5-9c44-0610aa733ec4", new Guid("ff03c0d4-d88a-4a8f-ade8-b57b7708d4c7") },
                    { new Guid("768c5a72-b34b-419b-a276-0364b22eb53c"), "5010a5ac-fdee-4a1c-80e2-8cbfb57f4785", new Guid("e2631a6f-7dc8-4956-965e-5f196026c3ad") }
                });

            migrationBuilder.InsertData(
                table: "UserGames",
                columns: new[] { "UserId", "GameId", "PurchaseDate" },
                values: new object[,]
                {
                    { new Guid("fdfa6328-3798-48f7-a03b-3e751950a1a4"), new Guid("ff03c0d4-d88a-4a8f-ade8-b57b7708d4c7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2b0c1a6e-6880-4376-9a58-2030323f4f99"), new Guid("e414012f-1b42-4bee-a72b-4398f2b60a14"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("24071d67-4d6d-4d9d-958d-ccb73cd6fa90"), new Guid("c780fa77-d689-4a13-b879-a7f83a838070"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1b1adaa5-95a0-415e-9f40-0bc8c925d31a"), new Guid("b17fabcf-461f-4eb4-a5a8-c9de46a3ea73"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9a2abfb7-00a9-4361-97bc-31413aa0eb66"), new Guid("e2631a6f-7dc8-4956-965e-5f196026c3ad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "WishGame",
                columns: new[] { "UserId", "GameId" },
                values: new object[,]
                {
                    { new Guid("24071d67-4d6d-4d9d-958d-ccb73cd6fa90"), new Guid("c780fa77-d689-4a13-b879-a7f83a838070") },
                    { new Guid("9a2abfb7-00a9-4361-97bc-31413aa0eb66"), new Guid("e2631a6f-7dc8-4956-965e-5f196026c3ad") },
                    { new Guid("1b1adaa5-95a0-415e-9f40-0bc8c925d31a"), new Guid("b17fabcf-461f-4eb4-a5a8-c9de46a3ea73") },
                    { new Guid("fdfa6328-3798-48f7-a03b-3e751950a1a4"), new Guid("ff03c0d4-d88a-4a8f-ade8-b57b7708d4c7") },
                    { new Guid("2b0c1a6e-6880-4376-9a58-2030323f4f99"), new Guid("e414012f-1b42-4bee-a72b-4398f2b60a14") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("b17fabcf-461f-4eb4-a5a8-c9de46a3ea73"), new Guid("82005dcf-7ccd-4182-affa-8403cc2bba40") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("c780fa77-d689-4a13-b879-a7f83a838070"), new Guid("7e623d51-bd34-4d45-a7ad-af6f77e27b62") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("e2631a6f-7dc8-4956-965e-5f196026c3ad"), new Guid("d723b944-d295-457b-b2ea-68775843dc8a") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("e414012f-1b42-4bee-a72b-4398f2b60a14"), new Guid("e2169b4c-5d95-4f5b-a72f-f58c389ce434") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("ff03c0d4-d88a-4a8f-ade8-b57b7708d4c7"), new Guid("5482f380-50af-477c-993d-e20a96f56256") });

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("6b94459f-32da-496e-95b5-4389392d8b5f"));

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("768c5a72-b34b-419b-a276-0364b22eb53c"));

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("cf6fb8f9-e196-4891-9364-c34dc68fe556"));

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("de233f16-5c92-4248-8916-ae5227d50b4b"));

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("e2e95a94-1621-4ae7-9300-a151e5bbd6a5"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("915da842-62bc-4f4e-9c1f-73a20c18f01c"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("9286b375-dd76-4506-a4e6-d839ded95dc4"), "Admin" });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("afc17676-7360-466b-b19e-61c135460299"), "User" });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("1b1adaa5-95a0-415e-9f40-0bc8c925d31a"), new Guid("b17fabcf-461f-4eb4-a5a8-c9de46a3ea73") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("24071d67-4d6d-4d9d-958d-ccb73cd6fa90"), new Guid("c780fa77-d689-4a13-b879-a7f83a838070") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("2b0c1a6e-6880-4376-9a58-2030323f4f99"), new Guid("e414012f-1b42-4bee-a72b-4398f2b60a14") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("9a2abfb7-00a9-4361-97bc-31413aa0eb66"), new Guid("e2631a6f-7dc8-4956-965e-5f196026c3ad") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("fdfa6328-3798-48f7-a03b-3e751950a1a4"), new Guid("ff03c0d4-d88a-4a8f-ade8-b57b7708d4c7") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("1b1adaa5-95a0-415e-9f40-0bc8c925d31a"), new Guid("b17fabcf-461f-4eb4-a5a8-c9de46a3ea73") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("24071d67-4d6d-4d9d-958d-ccb73cd6fa90"), new Guid("c780fa77-d689-4a13-b879-a7f83a838070") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("2b0c1a6e-6880-4376-9a58-2030323f4f99"), new Guid("e414012f-1b42-4bee-a72b-4398f2b60a14") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("9a2abfb7-00a9-4361-97bc-31413aa0eb66"), new Guid("e2631a6f-7dc8-4956-965e-5f196026c3ad") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("fdfa6328-3798-48f7-a03b-3e751950a1a4"), new Guid("ff03c0d4-d88a-4a8f-ade8-b57b7708d4c7") });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5482f380-50af-477c-993d-e20a96f56256"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7e623d51-bd34-4d45-a7ad-af6f77e27b62"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("82005dcf-7ccd-4182-affa-8403cc2bba40"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d723b944-d295-457b-b2ea-68775843dc8a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e2169b4c-5d95-4f5b-a72f-f58c389ce434"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b17fabcf-461f-4eb4-a5a8-c9de46a3ea73"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("c780fa77-d689-4a13-b879-a7f83a838070"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e2631a6f-7dc8-4956-965e-5f196026c3ad"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e414012f-1b42-4bee-a72b-4398f2b60a14"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ff03c0d4-d88a-4a8f-ade8-b57b7708d4c7"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("1b1adaa5-95a0-415e-9f40-0bc8c925d31a"), "f1a828c6-7ae7-4644-a016-c84512bac18e" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("24071d67-4d6d-4d9d-958d-ccb73cd6fa90"), "d6e8f12a-3d8b-4690-a667-9645a7cda028" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("2b0c1a6e-6880-4376-9a58-2030323f4f99"), "ee76fa96-e17f-4329-8c47-0f8ee366289c" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("9a2abfb7-00a9-4361-97bc-31413aa0eb66"), "f1b14ecf-bbe2-4d03-9a64-bbe2dd7b43b6" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("fdfa6328-3798-48f7-a03b-3e751950a1a4"), "ad795d56-a7db-4d75-adc8-354eada9e5eb" });

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("06a2a15f-34fd-4787-b8d6-7eda3e4f7f07"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("09716228-bd11-4bd9-94fb-cf25a037ef46"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("75cf0ab5-0b07-4e56-ace2-62297ff2e3de"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("b7c91955-d125-4ffc-b856-a689d26ac073"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("f59bacb7-3032-4711-8f2e-36c8123c0527"));
        }
    }
}
