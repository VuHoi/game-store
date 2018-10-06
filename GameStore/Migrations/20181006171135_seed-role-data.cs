using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStore.Migrations
{
    public partial class seedroledata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("24e33b59-091a-4017-87d6-9d7d41dfa877"), new Guid("e3a1676b-39fb-4e97-8a14-462fcfd9c57e") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("5c476cd6-6522-4035-91a8-30c9d91d0f75"), new Guid("dd3988da-2dbc-485f-b8c0-2d9a64d906ec") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("93603c77-60a0-4bf3-baf5-b2c8d6ad78cd"), new Guid("a4f047f8-a672-435b-aee8-956c72ecfd8d") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("cfcdda73-8c5e-41ae-9bc3-014056ec97c5"), new Guid("d3f13b61-de3c-435e-80c6-0a801a564f0e") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("d5388300-cba4-400b-9bcf-400006c588d4"), new Guid("c9166c80-8ed1-4979-89c1-6a99a93838ec") });

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("4926628a-8639-4048-a3e3-44ff6cc1aa6e"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("86b221e8-3ed9-4f08-8990-82ba4ecbd7cc"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("9a3b76ff-a103-4f2e-84ac-995b28cd439e"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("b78265a4-efcb-45c0-912e-9e36e47ad6aa"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("e84bf229-0a4b-49c0-9aba-6f42ff92060b"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("dd54be91-c39e-4819-974e-f469375f94e4"));

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("3554047b-d871-4a94-b300-55f2beb54050"), new Guid("d5388300-cba4-400b-9bcf-400006c588d4") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("93556b6e-ba6f-4770-8da6-525f9f4ef6a6"), new Guid("24e33b59-091a-4017-87d6-9d7d41dfa877") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("da01bbd0-b53b-46d3-9d3b-d96b5b1afc5f"), new Guid("cfcdda73-8c5e-41ae-9bc3-014056ec97c5") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("e16a732e-5f68-456d-96b5-681142bb3ac1"), new Guid("5c476cd6-6522-4035-91a8-30c9d91d0f75") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("edd42a5b-0046-4331-ab0c-e02a26bceedd"), new Guid("93603c77-60a0-4bf3-baf5-b2c8d6ad78cd") });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a4f047f8-a672-435b-aee8-956c72ecfd8d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c9166c80-8ed1-4979-89c1-6a99a93838ec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d3f13b61-de3c-435e-80c6-0a801a564f0e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dd3988da-2dbc-485f-b8c0-2d9a64d906ec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e3a1676b-39fb-4e97-8a14-462fcfd9c57e"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("24e33b59-091a-4017-87d6-9d7d41dfa877"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5c476cd6-6522-4035-91a8-30c9d91d0f75"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("93603c77-60a0-4bf3-baf5-b2c8d6ad78cd"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("cfcdda73-8c5e-41ae-9bc3-014056ec97c5"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d5388300-cba4-400b-9bcf-400006c588d4"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("3554047b-d871-4a94-b300-55f2beb54050"), "28f5349e-58a2-4ff3-aa72-fcd0398a6362" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("93556b6e-ba6f-4770-8da6-525f9f4ef6a6"), "53247c4b-9049-455d-9179-357b23f0e629" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("da01bbd0-b53b-46d3-9d3b-d96b5b1afc5f"), "2a7182fd-e46c-4935-a5ab-8be598c35e0c" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("e16a732e-5f68-456d-96b5-681142bb3ac1"), "06d518af-6616-49f4-883c-c04aca8f2751" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("edd42a5b-0046-4331-ab0c-e02a26bceedd"), "55094df8-70c3-401d-904a-bfc05e9ffe71" });

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("04f3c4a5-5896-4234-a325-163b6df11147"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("69eaa476-5353-411d-9173-5a93cbc4ffff"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("a31ff7cd-e0ce-468a-9ac6-b79339f496fd"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("b0b64c48-3b98-4134-b961-07f5ab6781db"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("e190cd32-f138-4249-8dbe-7e017671bebe"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("d3f13b61-de3c-435e-80c6-0a801a564f0e"), "Url Image Here", "Title here" },
                    { new Guid("c9166c80-8ed1-4979-89c1-6a99a93838ec"), "Url Image Here", "Title here" },
                    { new Guid("e3a1676b-39fb-4e97-8a14-462fcfd9c57e"), "Url Image Here", "Title here" },
                    { new Guid("dd3988da-2dbc-485f-b8c0-2d9a64d906ec"), "Url Image Here", "Title here" },
                    { new Guid("a4f047f8-a672-435b-aee8-956c72ecfd8d"), "Url Image Here", "Title here" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Money", "Name", "Reliability" },
                values: new object[,]
                {
                    { new Guid("69eaa476-5353-411d-9173-5a93cbc4ffff"), 10000000, "Name here", 5 },
                    { new Guid("b0b64c48-3b98-4134-b961-07f5ab6781db"), 10000000, "Name here", 5 },
                    { new Guid("04f3c4a5-5896-4234-a325-163b6df11147"), 10000000, "Name here", 5 },
                    { new Guid("e190cd32-f138-4249-8dbe-7e017671bebe"), 10000000, "Name here", 5 },
                    { new Guid("a31ff7cd-e0ce-468a-9ac6-b79339f496fd"), 10000000, "Name here", 5 },
                    { new Guid("dd54be91-c39e-4819-974e-f469375f94e4"), 10000000, "Name here", 5 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Hobbies", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("da01bbd0-b53b-46d3-9d3b-d96b5b1afc5f"), 0, "2a7182fd-e46c-4935-a5ab-8be598c35e0c", "Email@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509238098523", false, null, false, "UserName" },
                    { new Guid("3554047b-d871-4a94-b300-55f2beb54050"), 0, "28f5349e-58a2-4ff3-aa72-fcd0398a6362", "Email1@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509228098523", false, null, false, "UserName1" },
                    { new Guid("93556b6e-ba6f-4770-8da6-525f9f4ef6a6"), 0, "53247c4b-9049-455d-9179-357b23f0e629", "Email2@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098559238098523", false, null, false, "UserName2" },
                    { new Guid("e16a732e-5f68-456d-96b5-681142bb3ac1"), 0, "06d518af-6616-49f4-883c-c04aca8f2751", "Email3@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098609238098523", false, null, false, "UserName3" },
                    { new Guid("edd42a5b-0046-4331-ab0c-e02a26bceedd"), 0, "55094df8-70c3-401d-904a-bfc05e9ffe71", "Email4@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509738098523", false, null, false, "UserName4" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Content", "Logo", "Name", "Price", "PublisherId", "PurchaseDate", "Rating", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("cfcdda73-8c5e-41ae-9bc3-014056ec97c5"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("69eaa476-5353-411d-9173-5a93cbc4ffff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("d5388300-cba4-400b-9bcf-400006c588d4"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("b0b64c48-3b98-4134-b961-07f5ab6781db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("24e33b59-091a-4017-87d6-9d7d41dfa877"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("04f3c4a5-5896-4234-a325-163b6df11147"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("5c476cd6-6522-4035-91a8-30c9d91d0f75"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("e190cd32-f138-4249-8dbe-7e017671bebe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("93603c77-60a0-4bf3-baf5-b2c8d6ad78cd"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("a31ff7cd-e0ce-468a-9ac6-b79339f496fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" }
                });

            migrationBuilder.InsertData(
                table: "CategoryGames",
                columns: new[] { "GameId", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("cfcdda73-8c5e-41ae-9bc3-014056ec97c5"), new Guid("d3f13b61-de3c-435e-80c6-0a801a564f0e") },
                    { new Guid("d5388300-cba4-400b-9bcf-400006c588d4"), new Guid("c9166c80-8ed1-4979-89c1-6a99a93838ec") },
                    { new Guid("24e33b59-091a-4017-87d6-9d7d41dfa877"), new Guid("e3a1676b-39fb-4e97-8a14-462fcfd9c57e") },
                    { new Guid("5c476cd6-6522-4035-91a8-30c9d91d0f75"), new Guid("dd3988da-2dbc-485f-b8c0-2d9a64d906ec") },
                    { new Guid("93603c77-60a0-4bf3-baf5-b2c8d6ad78cd"), new Guid("a4f047f8-a672-435b-aee8-956c72ecfd8d") }
                });

            migrationBuilder.InsertData(
                table: "CodeFrees",
                columns: new[] { "Id", "Code", "GameId" },
                values: new object[,]
                {
                    { new Guid("9a3b76ff-a103-4f2e-84ac-995b28cd439e"), "c1939839-7361-47f3-b13c-56c8afea2f6c", new Guid("cfcdda73-8c5e-41ae-9bc3-014056ec97c5") },
                    { new Guid("e84bf229-0a4b-49c0-9aba-6f42ff92060b"), "c904a8c2-1848-41c9-b2d9-0e56cb083934", new Guid("d5388300-cba4-400b-9bcf-400006c588d4") },
                    { new Guid("b78265a4-efcb-45c0-912e-9e36e47ad6aa"), "8fcf90b6-bc5a-47ed-b992-fcadc5345af6", new Guid("24e33b59-091a-4017-87d6-9d7d41dfa877") },
                    { new Guid("86b221e8-3ed9-4f08-8990-82ba4ecbd7cc"), "11a2cefe-eeb2-41f1-80ad-f85b69c2c55e", new Guid("5c476cd6-6522-4035-91a8-30c9d91d0f75") },
                    { new Guid("4926628a-8639-4048-a3e3-44ff6cc1aa6e"), "49ee4ce0-2d11-4c1a-a20d-fedf20e841df", new Guid("93603c77-60a0-4bf3-baf5-b2c8d6ad78cd") }
                });

            migrationBuilder.InsertData(
                table: "UserGames",
                columns: new[] { "UserId", "GameId" },
                values: new object[,]
                {
                    { new Guid("da01bbd0-b53b-46d3-9d3b-d96b5b1afc5f"), new Guid("cfcdda73-8c5e-41ae-9bc3-014056ec97c5") },
                    { new Guid("3554047b-d871-4a94-b300-55f2beb54050"), new Guid("d5388300-cba4-400b-9bcf-400006c588d4") },
                    { new Guid("93556b6e-ba6f-4770-8da6-525f9f4ef6a6"), new Guid("24e33b59-091a-4017-87d6-9d7d41dfa877") },
                    { new Guid("e16a732e-5f68-456d-96b5-681142bb3ac1"), new Guid("5c476cd6-6522-4035-91a8-30c9d91d0f75") },
                    { new Guid("edd42a5b-0046-4331-ab0c-e02a26bceedd"), new Guid("93603c77-60a0-4bf3-baf5-b2c8d6ad78cd") }
                });
        }
    }
}
