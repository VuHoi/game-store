using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStore.Migrations
{
    public partial class seeddata4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_RefreshTokens_AspNetUsers_UserId",
                table: "RefreshTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_UserGames_AspNetUsers_UserId",
                table: "UserGames");

            migrationBuilder.DropForeignKey(
                name: "FK_WishGame_AspNetUsers_UserId",
                table: "WishGame");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("1b3723f0-4756-4005-aed3-f0433f1b3c0b"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("5177776d-d432-467c-a1f4-682acdb88861"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("8d002c60-fdab-4aa0-be7b-24474a6a0926"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("ba12102a-031c-420b-ae50-ce5796a2e6b5"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("cc8dab7f-dcc2-4d78-a305-a941c86b459b"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("297a0f92-dbb7-469c-af09-ad44b583fe3f"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("147c5ea7-98e8-4843-b3c3-58d9acc81808"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("2c014f0a-6adf-4e56-8de1-8e66a7bfbe4e"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("917a5d33-efee-42fe-9378-cd240cca4b72"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d6c29a46-d188-45a0-a753-540b2a837200"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f5535b92-375d-48b1-ab36-c248645f5ec8"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("39944b61-c54a-4ddb-8ffa-3513445f5898"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("810230f9-7f79-4f2b-b35f-1f63d6fa60b6"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("c9169317-540d-422e-a88f-ded10f00d842"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("e33013a1-4030-4b08-893c-fb952f8dbfe9"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("f99ff978-f44d-47cd-a70e-47716af0a664"));

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "UserRole");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "UserLogin");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "UserClaim");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "Role");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "UserRole",
                newName: "IX_UserRole_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "UserLogin",
                newName: "IX_UserLogin_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "UserClaim",
                newName: "IX_UserClaim_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogin",
                table: "UserLogin",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClaim",
                table: "UserClaim",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_Role_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_User_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshTokens_User_UserId",
                table: "RefreshTokens",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaim_User_UserId",
                table: "UserClaim",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserGames_User_UserId",
                table: "UserGames",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogin_User_UserId",
                table: "UserLogin",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Role_RoleId",
                table: "UserRole",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_UserId",
                table: "UserRole",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WishGame_User_UserId",
                table: "WishGame",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_Role_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_User_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_RefreshTokens_User_UserId",
                table: "RefreshTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClaim_User_UserId",
                table: "UserClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_UserGames_User_UserId",
                table: "UserGames");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogin_User_UserId",
                table: "UserLogin");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Role_RoleId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_User_UserId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_WishGame_User_UserId",
                table: "WishGame");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogin",
                table: "UserLogin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClaim",
                table: "UserClaim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

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

            migrationBuilder.RenameTable(
                name: "UserRole",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "UserLogin",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "UserClaim",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "AspNetRoles");

            migrationBuilder.RenameIndex(
                name: "IX_UserRole_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogin_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserClaim_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Money", "Name", "Reliability" },
                values: new object[,]
                {
                    { new Guid("39944b61-c54a-4ddb-8ffa-3513445f5898"), 10000000, "Name here", 5 },
                    { new Guid("e33013a1-4030-4b08-893c-fb952f8dbfe9"), 10000000, "Name here", 5 },
                    { new Guid("c9169317-540d-422e-a88f-ded10f00d842"), 10000000, "Name here", 5 },
                    { new Guid("810230f9-7f79-4f2b-b35f-1f63d6fa60b6"), 10000000, "Name here", 5 },
                    { new Guid("f99ff978-f44d-47cd-a70e-47716af0a664"), 10000000, "Name here", 5 },
                    { new Guid("297a0f92-dbb7-469c-af09-ad44b583fe3f"), 10000000, "Name here", 5 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Content", "Logo", "Name", "Price", "PublisherId", "PurchaseDate", "Rating", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("d6c29a46-d188-45a0-a753-540b2a837200"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("39944b61-c54a-4ddb-8ffa-3513445f5898"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("917a5d33-efee-42fe-9378-cd240cca4b72"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("e33013a1-4030-4b08-893c-fb952f8dbfe9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("f5535b92-375d-48b1-ab36-c248645f5ec8"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("c9169317-540d-422e-a88f-ded10f00d842"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("2c014f0a-6adf-4e56-8de1-8e66a7bfbe4e"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("810230f9-7f79-4f2b-b35f-1f63d6fa60b6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("147c5ea7-98e8-4843-b3c3-58d9acc81808"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("f99ff978-f44d-47cd-a70e-47716af0a664"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" }
                });

            migrationBuilder.InsertData(
                table: "CodeFrees",
                columns: new[] { "Id", "Code", "GameId" },
                values: new object[,]
                {
                    { new Guid("8d002c60-fdab-4aa0-be7b-24474a6a0926"), "7e60e51c-7aed-4ae6-8dd3-63aa3e35d96c", new Guid("d6c29a46-d188-45a0-a753-540b2a837200") },
                    { new Guid("1b3723f0-4756-4005-aed3-f0433f1b3c0b"), "20d6ecd6-8fb4-4917-b5b1-0ccee5556ccd", new Guid("917a5d33-efee-42fe-9378-cd240cca4b72") },
                    { new Guid("5177776d-d432-467c-a1f4-682acdb88861"), "a77976c4-d55b-4f1c-88f1-9bad7dda4325", new Guid("f5535b92-375d-48b1-ab36-c248645f5ec8") },
                    { new Guid("ba12102a-031c-420b-ae50-ce5796a2e6b5"), "fd350304-7a81-4921-b79a-3a965041fa05", new Guid("2c014f0a-6adf-4e56-8de1-8e66a7bfbe4e") },
                    { new Guid("cc8dab7f-dcc2-4d78-a305-a941c86b459b"), "b0bf89d8-24b2-41e2-b25f-89c34c99a199", new Guid("147c5ea7-98e8-4843-b3c3-58d9acc81808") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshTokens_AspNetUsers_UserId",
                table: "RefreshTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserGames_AspNetUsers_UserId",
                table: "UserGames",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WishGame_AspNetUsers_UserId",
                table: "WishGame",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
