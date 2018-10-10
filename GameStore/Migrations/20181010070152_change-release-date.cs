using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStore.Migrations
{
    public partial class changereleasedate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("294bc8df-fda4-4cef-8cd0-6cd7e4eebc17"), new Guid("8b084066-1970-4667-8865-aac1347814a3") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("35348799-44c4-4a55-b534-5c2adb80c484"), new Guid("a020afc5-9765-4ff7-aef0-fd63b0175ba8") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("40ee69d3-43aa-49d9-bcac-d4c0b59b53be"), new Guid("e35502a2-c6d4-4b3c-9eba-ebe34b549dce") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("50146cf1-a579-4494-a57a-245b3e3a2782"), new Guid("f8dd3cbe-14c9-4dc8-b1ef-ae9989e71c6e") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("9b56717f-6d9f-4e10-83d0-dc399e6f1d21"), new Guid("ef79ece7-75d5-485c-9b39-a6f6a1dd30aa") });

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("15a4ed7e-e0cb-4204-ae35-0fff010891a7"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("23d01fb1-1f42-46f3-8d85-aabe02a22e53"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("aaa6c3dc-d9b2-4494-b3b0-ebfdc10a1d25"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("cdf97371-476f-4662-a985-301baeee0271"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("faec35ac-1312-469c-bf57-f41b55c151e3"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6124322f-0b9a-4f6a-b87e-0ea9e262d8eb"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("1afddfa2-9f74-4697-a03d-67fe99ba6425"), "Admin" });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("9ac38f5a-8345-47f2-b856-348d7aed2d84"), "User" });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("092f75a5-a2d0-4e99-9547-5b000a6b0a36"), new Guid("40ee69d3-43aa-49d9-bcac-d4c0b59b53be") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("498b7597-88c3-4fe4-9e1d-c3c30c9d4689"), new Guid("9b56717f-6d9f-4e10-83d0-dc399e6f1d21") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("5b5afad4-1dae-4e6c-b6e8-f64b7f846c8d"), new Guid("35348799-44c4-4a55-b534-5c2adb80c484") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("a9ae1345-0861-4dad-a310-5f671d73270b"), new Guid("294bc8df-fda4-4cef-8cd0-6cd7e4eebc17") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("f85ae91f-bc8c-4389-92b2-714b08047904"), new Guid("50146cf1-a579-4494-a57a-245b3e3a2782") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("092f75a5-a2d0-4e99-9547-5b000a6b0a36"), new Guid("40ee69d3-43aa-49d9-bcac-d4c0b59b53be") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("498b7597-88c3-4fe4-9e1d-c3c30c9d4689"), new Guid("9b56717f-6d9f-4e10-83d0-dc399e6f1d21") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("5b5afad4-1dae-4e6c-b6e8-f64b7f846c8d"), new Guid("35348799-44c4-4a55-b534-5c2adb80c484") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("a9ae1345-0861-4dad-a310-5f671d73270b"), new Guid("294bc8df-fda4-4cef-8cd0-6cd7e4eebc17") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("f85ae91f-bc8c-4389-92b2-714b08047904"), new Guid("50146cf1-a579-4494-a57a-245b3e3a2782") });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8b084066-1970-4667-8865-aac1347814a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a020afc5-9765-4ff7-aef0-fd63b0175ba8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e35502a2-c6d4-4b3c-9eba-ebe34b549dce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ef79ece7-75d5-485c-9b39-a6f6a1dd30aa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f8dd3cbe-14c9-4dc8-b1ef-ae9989e71c6e"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("294bc8df-fda4-4cef-8cd0-6cd7e4eebc17"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("35348799-44c4-4a55-b534-5c2adb80c484"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("40ee69d3-43aa-49d9-bcac-d4c0b59b53be"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("50146cf1-a579-4494-a57a-245b3e3a2782"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("9b56717f-6d9f-4e10-83d0-dc399e6f1d21"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("092f75a5-a2d0-4e99-9547-5b000a6b0a36"), "c593210b-b0a4-437b-8b86-4351c72b23fa" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("498b7597-88c3-4fe4-9e1d-c3c30c9d4689"), "658aa2aa-7f3f-4461-b283-6daab6aa0519" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("5b5afad4-1dae-4e6c-b6e8-f64b7f846c8d"), "7cb1f3b7-b680-48de-b90b-130d2a993d27" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("a9ae1345-0861-4dad-a310-5f671d73270b"), "91d4e5f3-ce87-4ed6-a999-f4035788e9fe" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("f85ae91f-bc8c-4389-92b2-714b08047904"), "b11d24b9-97e9-436b-ab7a-9560f168391e" });

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("1a822a8c-f83e-4a28-9bb6-1dc65f8996f8"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("450aca89-dc99-4b4b-b951-cf2b3529cb4a"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("7f2b73f4-e33a-46db-a766-7d5cf4fab972"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("bc3427fe-0bed-4c93-8769-ee852f5f1f23"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("ff641b0e-4ebf-4182-8147-cdd6846ef8f8"));

            migrationBuilder.RenameColumn(
                name: "PurchaseDate",
                table: "Games",
                newName: "ReleaseDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "PurchaseDate",
                table: "UserGames",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Title" },
                values: new object[,]
                {
                    { new Guid("df4b987f-f4c7-4580-beeb-f587287791c4"), "Url Image Here", "Title here" },
                    { new Guid("6dadbea0-319b-4a1b-ad94-555802c98947"), "Url Image Here", "Title here" },
                    { new Guid("be660cc7-11e0-4996-909d-cb41cff57a1f"), "Url Image Here", "Title here" },
                    { new Guid("2285c65d-e625-47f5-85a1-73e37a21871f"), "Url Image Here", "Title here" },
                    { new Guid("3db017a2-8176-4af8-a1d5-5a35bb1de638"), "Url Image Here", "Title here" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Money", "Name", "Reliability" },
                values: new object[,]
                {
                    { new Guid("63b54cd7-de42-4609-953a-017eeb6785fb"), 10000000, "Name here", 5 },
                    { new Guid("3d6869b6-d175-4c0e-8c72-614aa318058a"), 10000000, "Name here", 5 },
                    { new Guid("bb30687b-d36b-4c33-abb3-632965ace082"), 10000000, "Name here", 5 },
                    { new Guid("6a3dee87-896d-498f-9538-0c9a32878543"), 10000000, "Name here", 5 },
                    { new Guid("fa62cafa-7938-440d-8fb7-2f7bd6301d70"), 10000000, "Name here", 5 },
                    { new Guid("720656bb-5f30-4d28-b085-c40418558219"), 10000000, "Name here", 5 }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("6ca7b411-d6cf-45a4-9361-4b2553b550f8"), "User", "Limited Permission", "User", "User" },
                    { new Guid("8af59830-cb9b-4adc-a3e9-131f11bd4e98"), "Admin", "Full Permission", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Hobbies", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("612bf5a6-0dc0-434e-aa44-e1a8faf6c2f1"), 0, "7d4a7a5c-cca6-449f-8c7b-10cb3eb18ac1", "Email@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509238098523", false, null, false, "UserName" },
                    { new Guid("51625e1c-b444-4b3b-92dd-d3ecf132e16e"), 0, "fcb4b1fe-7949-4d4c-98e1-426acd522aa7", "Email1@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509228098523", false, null, false, "UserName1" },
                    { new Guid("5d30395d-2c1c-4a8f-817d-fabbe52294d6"), 0, "ca2a94af-3b6c-4690-84cc-e4565c40c144", "Email2@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098559238098523", false, null, false, "UserName2" },
                    { new Guid("fb40bd8f-22b1-447b-a168-d9dab225874b"), 0, "75956d5e-38b7-435e-b3b9-986a9a26de97", "Email3@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098609238098523", false, null, false, "UserName3" },
                    { new Guid("5f5129c9-a340-44bb-bb24-8fc13c2cb028"), 0, "87517926-261d-4378-b6fd-978bc5369275", "Email4@gmail.com", false, "Full Name", "Hobbies", false, null, null, null, "Thatvuhai_7595", "93098509738098523", false, null, false, "UserName4" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Content", "Logo", "Name", "Price", "PublisherId", "Rating", "ReleaseDate", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("db273dca-5f7f-4b8f-96c6-eec3f27ede0f"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("bb30687b-d36b-4c33-abb3-632965ace082"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("16261a90-1bdb-40f9-935e-c132c6896f6c"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("63b54cd7-de42-4609-953a-017eeb6785fb"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("ee3a459b-5d61-4a28-a1f3-e83060010670"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("fa62cafa-7938-440d-8fb7-2f7bd6301d70"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("7b346739-54fc-48ab-8a87-fe10184aa272"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("720656bb-5f30-4d28-b085-c40418558219"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("099cd90f-3dd6-48a8-b00a-657c376ed065"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("6a3dee87-896d-498f-9538-0c9a32878543"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" }
                });

            migrationBuilder.InsertData(
                table: "CategoryGames",
                columns: new[] { "GameId", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("db273dca-5f7f-4b8f-96c6-eec3f27ede0f"), new Guid("df4b987f-f4c7-4580-beeb-f587287791c4") },
                    { new Guid("099cd90f-3dd6-48a8-b00a-657c376ed065"), new Guid("3db017a2-8176-4af8-a1d5-5a35bb1de638") },
                    { new Guid("16261a90-1bdb-40f9-935e-c132c6896f6c"), new Guid("6dadbea0-319b-4a1b-ad94-555802c98947") },
                    { new Guid("7b346739-54fc-48ab-8a87-fe10184aa272"), new Guid("2285c65d-e625-47f5-85a1-73e37a21871f") },
                    { new Guid("ee3a459b-5d61-4a28-a1f3-e83060010670"), new Guid("be660cc7-11e0-4996-909d-cb41cff57a1f") }
                });

            migrationBuilder.InsertData(
                table: "CodeFrees",
                columns: new[] { "Id", "Code", "GameId" },
                values: new object[,]
                {
                    { new Guid("ad377c0e-a2f8-4283-85e4-1bee7b04725d"), "bc63fcfc-247f-468c-a9a9-d5bbaa75e3a8", new Guid("099cd90f-3dd6-48a8-b00a-657c376ed065") },
                    { new Guid("4ffa12c3-e4c1-4f07-a364-f30ec43e21ef"), "6b1f7d09-81e0-450a-8e19-4d0d638adf28", new Guid("7b346739-54fc-48ab-8a87-fe10184aa272") },
                    { new Guid("7890f1e6-86d4-4ce4-8259-9b92817c1b53"), "e24f2264-6c70-4639-8f99-a07e071f26cf", new Guid("ee3a459b-5d61-4a28-a1f3-e83060010670") },
                    { new Guid("3a4ca50f-852e-4a92-b074-661e6ae0ceeb"), "54f36847-6dd4-4955-88f6-d2848e161afb", new Guid("16261a90-1bdb-40f9-935e-c132c6896f6c") },
                    { new Guid("fa33906b-e090-4592-94ac-d33194669b64"), "6d6fefbd-d1b2-455f-8a30-051945825895", new Guid("db273dca-5f7f-4b8f-96c6-eec3f27ede0f") }
                });

            migrationBuilder.InsertData(
                table: "UserGames",
                columns: new[] { "UserId", "GameId", "PurchaseDate" },
                values: new object[,]
                {
                    { new Guid("51625e1c-b444-4b3b-92dd-d3ecf132e16e"), new Guid("16261a90-1bdb-40f9-935e-c132c6896f6c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5f5129c9-a340-44bb-bb24-8fc13c2cb028"), new Guid("099cd90f-3dd6-48a8-b00a-657c376ed065"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5d30395d-2c1c-4a8f-817d-fabbe52294d6"), new Guid("ee3a459b-5d61-4a28-a1f3-e83060010670"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fb40bd8f-22b1-447b-a168-d9dab225874b"), new Guid("7b346739-54fc-48ab-8a87-fe10184aa272"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("612bf5a6-0dc0-434e-aa44-e1a8faf6c2f1"), new Guid("db273dca-5f7f-4b8f-96c6-eec3f27ede0f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "WishGame",
                columns: new[] { "UserId", "GameId" },
                values: new object[,]
                {
                    { new Guid("5d30395d-2c1c-4a8f-817d-fabbe52294d6"), new Guid("ee3a459b-5d61-4a28-a1f3-e83060010670") },
                    { new Guid("612bf5a6-0dc0-434e-aa44-e1a8faf6c2f1"), new Guid("db273dca-5f7f-4b8f-96c6-eec3f27ede0f") },
                    { new Guid("fb40bd8f-22b1-447b-a168-d9dab225874b"), new Guid("7b346739-54fc-48ab-8a87-fe10184aa272") },
                    { new Guid("51625e1c-b444-4b3b-92dd-d3ecf132e16e"), new Guid("16261a90-1bdb-40f9-935e-c132c6896f6c") },
                    { new Guid("5f5129c9-a340-44bb-bb24-8fc13c2cb028"), new Guid("099cd90f-3dd6-48a8-b00a-657c376ed065") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("099cd90f-3dd6-48a8-b00a-657c376ed065"), new Guid("3db017a2-8176-4af8-a1d5-5a35bb1de638") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("16261a90-1bdb-40f9-935e-c132c6896f6c"), new Guid("6dadbea0-319b-4a1b-ad94-555802c98947") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("7b346739-54fc-48ab-8a87-fe10184aa272"), new Guid("2285c65d-e625-47f5-85a1-73e37a21871f") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("db273dca-5f7f-4b8f-96c6-eec3f27ede0f"), new Guid("df4b987f-f4c7-4580-beeb-f587287791c4") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("ee3a459b-5d61-4a28-a1f3-e83060010670"), new Guid("be660cc7-11e0-4996-909d-cb41cff57a1f") });

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("3a4ca50f-852e-4a92-b074-661e6ae0ceeb"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("4ffa12c3-e4c1-4f07-a364-f30ec43e21ef"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("7890f1e6-86d4-4ce4-8259-9b92817c1b53"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("ad377c0e-a2f8-4283-85e4-1bee7b04725d"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("fa33906b-e090-4592-94ac-d33194669b64"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3d6869b6-d175-4c0e-8c72-614aa318058a"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("6ca7b411-d6cf-45a4-9361-4b2553b550f8"), "User" });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("8af59830-cb9b-4adc-a3e9-131f11bd4e98"), "Admin" });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("51625e1c-b444-4b3b-92dd-d3ecf132e16e"), new Guid("16261a90-1bdb-40f9-935e-c132c6896f6c") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("5d30395d-2c1c-4a8f-817d-fabbe52294d6"), new Guid("ee3a459b-5d61-4a28-a1f3-e83060010670") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("5f5129c9-a340-44bb-bb24-8fc13c2cb028"), new Guid("099cd90f-3dd6-48a8-b00a-657c376ed065") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("612bf5a6-0dc0-434e-aa44-e1a8faf6c2f1"), new Guid("db273dca-5f7f-4b8f-96c6-eec3f27ede0f") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("fb40bd8f-22b1-447b-a168-d9dab225874b"), new Guid("7b346739-54fc-48ab-8a87-fe10184aa272") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("51625e1c-b444-4b3b-92dd-d3ecf132e16e"), new Guid("16261a90-1bdb-40f9-935e-c132c6896f6c") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("5d30395d-2c1c-4a8f-817d-fabbe52294d6"), new Guid("ee3a459b-5d61-4a28-a1f3-e83060010670") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("5f5129c9-a340-44bb-bb24-8fc13c2cb028"), new Guid("099cd90f-3dd6-48a8-b00a-657c376ed065") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("612bf5a6-0dc0-434e-aa44-e1a8faf6c2f1"), new Guid("db273dca-5f7f-4b8f-96c6-eec3f27ede0f") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("fb40bd8f-22b1-447b-a168-d9dab225874b"), new Guid("7b346739-54fc-48ab-8a87-fe10184aa272") });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2285c65d-e625-47f5-85a1-73e37a21871f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3db017a2-8176-4af8-a1d5-5a35bb1de638"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6dadbea0-319b-4a1b-ad94-555802c98947"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("be660cc7-11e0-4996-909d-cb41cff57a1f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("df4b987f-f4c7-4580-beeb-f587287791c4"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("099cd90f-3dd6-48a8-b00a-657c376ed065"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16261a90-1bdb-40f9-935e-c132c6896f6c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("7b346739-54fc-48ab-8a87-fe10184aa272"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("db273dca-5f7f-4b8f-96c6-eec3f27ede0f"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ee3a459b-5d61-4a28-a1f3-e83060010670"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("51625e1c-b444-4b3b-92dd-d3ecf132e16e"), "fcb4b1fe-7949-4d4c-98e1-426acd522aa7" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("5d30395d-2c1c-4a8f-817d-fabbe52294d6"), "ca2a94af-3b6c-4690-84cc-e4565c40c144" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("5f5129c9-a340-44bb-bb24-8fc13c2cb028"), "87517926-261d-4378-b6fd-978bc5369275" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("612bf5a6-0dc0-434e-aa44-e1a8faf6c2f1"), "7d4a7a5c-cca6-449f-8c7b-10cb3eb18ac1" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("fb40bd8f-22b1-447b-a168-d9dab225874b"), "75956d5e-38b7-435e-b3b9-986a9a26de97" });

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("63b54cd7-de42-4609-953a-017eeb6785fb"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6a3dee87-896d-498f-9538-0c9a32878543"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("720656bb-5f30-4d28-b085-c40418558219"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("bb30687b-d36b-4c33-abb3-632965ace082"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("fa62cafa-7938-440d-8fb7-2f7bd6301d70"));

            migrationBuilder.DropColumn(
                name: "PurchaseDate",
                table: "UserGames");

            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Games",
                newName: "PurchaseDate");

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
        }
    }
}
