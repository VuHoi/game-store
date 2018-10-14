using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStore.Migrations
{
    public partial class addgetuserbyid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("39accdd9-161a-4fe0-8a10-310f8c98ad93"), new Guid("388b8039-2474-4f6c-952d-de7940492694") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("42dfec91-42c7-49f5-b449-b4e22e895088"), new Guid("1e733f80-d9cf-4410-a804-59279a4ace74") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("8b4ddf45-3956-486b-a2f6-3fec1b3d3048"), new Guid("7aa1b4ac-f827-45d1-acb1-0d195b1325a0") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("ec1fb6a2-755e-4561-903c-d504845d9475"), new Guid("b6894abf-26ec-4a84-b397-4494bb91bc86") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("f5153e60-15b8-468e-97ae-a01e5188f053"), new Guid("97b6eb55-75ed-45a3-9976-0b348522fbe4") });

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("32d87bf9-25fd-4c8a-878f-de11bc6f6a4b"));

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("40f1dc47-f47b-4cdf-be37-e9c1bfd39ef2"));

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("578cfe81-2ce2-438f-951e-4d7a272e720b"));

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("85c9210a-ed3a-4936-a171-e006d81d66f7"));

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("bfa3dbae-19ef-4f0d-9b88-bd8d47321fb2"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("dc23f861-ff43-45af-845c-af4514df22a2"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("1ae148d3-587d-4479-bd2c-83984b9e3919"), "Admin" });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("f2f8d801-9d7b-4488-95ad-396357931752"), "User" });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("0c55ccca-8bd2-4e54-8454-be78847d8c85"), new Guid("ec1fb6a2-755e-4561-903c-d504845d9475") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("6eaf3521-3277-4db7-ad91-924db908ffcf"), new Guid("8b4ddf45-3956-486b-a2f6-3fec1b3d3048") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("a986b22d-70be-4cc1-a5ac-af06ec5401ef"), new Guid("39accdd9-161a-4fe0-8a10-310f8c98ad93") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("bc5f30ba-47e7-49ae-8f44-37443db55064"), new Guid("f5153e60-15b8-468e-97ae-a01e5188f053") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("d180ad76-1c84-430b-8889-f8df64bc7251"), new Guid("42dfec91-42c7-49f5-b449-b4e22e895088") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("0c55ccca-8bd2-4e54-8454-be78847d8c85"), new Guid("ec1fb6a2-755e-4561-903c-d504845d9475") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("6eaf3521-3277-4db7-ad91-924db908ffcf"), new Guid("8b4ddf45-3956-486b-a2f6-3fec1b3d3048") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("a986b22d-70be-4cc1-a5ac-af06ec5401ef"), new Guid("39accdd9-161a-4fe0-8a10-310f8c98ad93") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("bc5f30ba-47e7-49ae-8f44-37443db55064"), new Guid("f5153e60-15b8-468e-97ae-a01e5188f053") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("d180ad76-1c84-430b-8889-f8df64bc7251"), new Guid("42dfec91-42c7-49f5-b449-b4e22e895088") });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e733f80-d9cf-4410-a804-59279a4ace74"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("388b8039-2474-4f6c-952d-de7940492694"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7aa1b4ac-f827-45d1-acb1-0d195b1325a0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("97b6eb55-75ed-45a3-9976-0b348522fbe4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b6894abf-26ec-4a84-b397-4494bb91bc86"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("39accdd9-161a-4fe0-8a10-310f8c98ad93"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("42dfec91-42c7-49f5-b449-b4e22e895088"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8b4ddf45-3956-486b-a2f6-3fec1b3d3048"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ec1fb6a2-755e-4561-903c-d504845d9475"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f5153e60-15b8-468e-97ae-a01e5188f053"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("0c55ccca-8bd2-4e54-8454-be78847d8c85"), "44e383be-23e8-452f-b0a1-29da135b4302" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("6eaf3521-3277-4db7-ad91-924db908ffcf"), "18deecaf-7278-4296-87d2-833e9f11bef4" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("a986b22d-70be-4cc1-a5ac-af06ec5401ef"), "f6772774-84b3-41f9-ab4f-6ade999f56fb" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("bc5f30ba-47e7-49ae-8f44-37443db55064"), "40e9a4a0-ca50-4cfa-83db-dae7d158d897" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("d180ad76-1c84-430b-8889-f8df64bc7251"), "856038b7-f8fe-4461-bd99-cef4f4e12c63" });

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("0703a244-3012-4725-b9a5-2e3d5af9f0fe"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("0e276582-8ca0-4de3-a465-ed721530ae2c"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("773f8d2e-b12d-4a9f-91d9-9e5da568f0eb"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("b49d6edb-140d-46cc-bd0b-482be03c8c46"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("ca1aca5f-cdee-43a6-bdcb-e596d1b909a5"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Title" },
                values: new object[,]
                {
                    { new Guid("388b8039-2474-4f6c-952d-de7940492694"), "Url Image Here", "Title here" },
                    { new Guid("97b6eb55-75ed-45a3-9976-0b348522fbe4"), "Url Image Here", "Title here" },
                    { new Guid("b6894abf-26ec-4a84-b397-4494bb91bc86"), "Url Image Here", "Title here" },
                    { new Guid("1e733f80-d9cf-4410-a804-59279a4ace74"), "Url Image Here", "Title here" },
                    { new Guid("7aa1b4ac-f827-45d1-acb1-0d195b1325a0"), "Url Image Here", "Title here" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Money", "Name", "Reliability" },
                values: new object[,]
                {
                    { new Guid("0e276582-8ca0-4de3-a465-ed721530ae2c"), 10000000, "Name here", 5 },
                    { new Guid("dc23f861-ff43-45af-845c-af4514df22a2"), 10000000, "Name here", 5 },
                    { new Guid("0703a244-3012-4725-b9a5-2e3d5af9f0fe"), 10000000, "Name here", 5 },
                    { new Guid("ca1aca5f-cdee-43a6-bdcb-e596d1b909a5"), 10000000, "Name here", 5 },
                    { new Guid("773f8d2e-b12d-4a9f-91d9-9e5da568f0eb"), 10000000, "Name here", 5 },
                    { new Guid("b49d6edb-140d-46cc-bd0b-482be03c8c46"), 10000000, "Name here", 5 }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("f2f8d801-9d7b-4488-95ad-396357931752"), "User", "Limited Permission", "User", "User" },
                    { new Guid("1ae148d3-587d-4479-bd2c-83984b9e3919"), "Admin", "Full Permission", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Hobbies", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("a986b22d-70be-4cc1-a5ac-af06ec5401ef"), 0, "f6772774-84b3-41f9-ab4f-6ade999f56fb", "Email@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509238098523", false, null, false, "UserName" },
                    { new Guid("bc5f30ba-47e7-49ae-8f44-37443db55064"), 0, "40e9a4a0-ca50-4cfa-83db-dae7d158d897", "Email1@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509228098523", false, null, false, "UserName1" },
                    { new Guid("0c55ccca-8bd2-4e54-8454-be78847d8c85"), 0, "44e383be-23e8-452f-b0a1-29da135b4302", "Email2@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098559238098523", false, null, false, "UserName2" },
                    { new Guid("d180ad76-1c84-430b-8889-f8df64bc7251"), 0, "856038b7-f8fe-4461-bd99-cef4f4e12c63", "Email3@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098609238098523", false, null, false, "UserName3" },
                    { new Guid("6eaf3521-3277-4db7-ad91-924db908ffcf"), 0, "18deecaf-7278-4296-87d2-833e9f11bef4", "Email4@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509738098523", false, null, false, "UserName4" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Content", "Logo", "Name", "Price", "PublisherId", "Rating", "ReleaseDate", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("39accdd9-161a-4fe0-8a10-310f8c98ad93"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("0703a244-3012-4725-b9a5-2e3d5af9f0fe"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("f5153e60-15b8-468e-97ae-a01e5188f053"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("0e276582-8ca0-4de3-a465-ed721530ae2c"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("ec1fb6a2-755e-4561-903c-d504845d9475"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("773f8d2e-b12d-4a9f-91d9-9e5da568f0eb"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("42dfec91-42c7-49f5-b449-b4e22e895088"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("b49d6edb-140d-46cc-bd0b-482be03c8c46"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("8b4ddf45-3956-486b-a2f6-3fec1b3d3048"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("ca1aca5f-cdee-43a6-bdcb-e596d1b909a5"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" }
                });

            migrationBuilder.InsertData(
                table: "CategoryGames",
                columns: new[] { "GameId", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("39accdd9-161a-4fe0-8a10-310f8c98ad93"), new Guid("388b8039-2474-4f6c-952d-de7940492694") },
                    { new Guid("8b4ddf45-3956-486b-a2f6-3fec1b3d3048"), new Guid("7aa1b4ac-f827-45d1-acb1-0d195b1325a0") },
                    { new Guid("f5153e60-15b8-468e-97ae-a01e5188f053"), new Guid("97b6eb55-75ed-45a3-9976-0b348522fbe4") },
                    { new Guid("42dfec91-42c7-49f5-b449-b4e22e895088"), new Guid("1e733f80-d9cf-4410-a804-59279a4ace74") },
                    { new Guid("ec1fb6a2-755e-4561-903c-d504845d9475"), new Guid("b6894abf-26ec-4a84-b397-4494bb91bc86") }
                });

            migrationBuilder.InsertData(
                table: "FreeCodes",
                columns: new[] { "Id", "Code", "GameId" },
                values: new object[,]
                {
                    { new Guid("32d87bf9-25fd-4c8a-878f-de11bc6f6a4b"), "ce7b4bbc-22d7-4c53-80a4-d651a0cb43db", new Guid("8b4ddf45-3956-486b-a2f6-3fec1b3d3048") },
                    { new Guid("578cfe81-2ce2-438f-951e-4d7a272e720b"), "6014cea7-e559-470e-8645-de51e5d18d7f", new Guid("42dfec91-42c7-49f5-b449-b4e22e895088") },
                    { new Guid("85c9210a-ed3a-4936-a171-e006d81d66f7"), "a03dfe86-28b3-4541-b0cd-07c9cf40f4ec", new Guid("ec1fb6a2-755e-4561-903c-d504845d9475") },
                    { new Guid("bfa3dbae-19ef-4f0d-9b88-bd8d47321fb2"), "69f2aed6-b52e-4fd7-a0ec-3c941fd12208", new Guid("f5153e60-15b8-468e-97ae-a01e5188f053") },
                    { new Guid("40f1dc47-f47b-4cdf-be37-e9c1bfd39ef2"), "152d27bc-33c1-4122-b87c-b8794bdeb6a9", new Guid("39accdd9-161a-4fe0-8a10-310f8c98ad93") }
                });

            migrationBuilder.InsertData(
                table: "UserGames",
                columns: new[] { "UserId", "GameId", "PurchaseDate" },
                values: new object[,]
                {
                    { new Guid("bc5f30ba-47e7-49ae-8f44-37443db55064"), new Guid("f5153e60-15b8-468e-97ae-a01e5188f053"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6eaf3521-3277-4db7-ad91-924db908ffcf"), new Guid("8b4ddf45-3956-486b-a2f6-3fec1b3d3048"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0c55ccca-8bd2-4e54-8454-be78847d8c85"), new Guid("ec1fb6a2-755e-4561-903c-d504845d9475"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d180ad76-1c84-430b-8889-f8df64bc7251"), new Guid("42dfec91-42c7-49f5-b449-b4e22e895088"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a986b22d-70be-4cc1-a5ac-af06ec5401ef"), new Guid("39accdd9-161a-4fe0-8a10-310f8c98ad93"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "WishGame",
                columns: new[] { "UserId", "GameId" },
                values: new object[,]
                {
                    { new Guid("0c55ccca-8bd2-4e54-8454-be78847d8c85"), new Guid("ec1fb6a2-755e-4561-903c-d504845d9475") },
                    { new Guid("a986b22d-70be-4cc1-a5ac-af06ec5401ef"), new Guid("39accdd9-161a-4fe0-8a10-310f8c98ad93") },
                    { new Guid("d180ad76-1c84-430b-8889-f8df64bc7251"), new Guid("42dfec91-42c7-49f5-b449-b4e22e895088") },
                    { new Guid("bc5f30ba-47e7-49ae-8f44-37443db55064"), new Guid("f5153e60-15b8-468e-97ae-a01e5188f053") },
                    { new Guid("6eaf3521-3277-4db7-ad91-924db908ffcf"), new Guid("8b4ddf45-3956-486b-a2f6-3fec1b3d3048") }
                });
        }
    }
}
