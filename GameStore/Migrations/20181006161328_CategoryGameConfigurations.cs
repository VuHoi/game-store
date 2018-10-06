using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStore.Migrations
{
    public partial class CategoryGameConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Games_GameId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_GameId",
                table: "Categories");

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("766ff9f8-2e15-4c1b-ba4d-ce16b02a200f"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("82e195e3-4cf9-413d-8d9e-034285290c49"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("89ea38be-c9ad-4b62-867f-1cceca06d79e"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("97a5bb01-4584-46db-af2f-70148e66d20e"));

            migrationBuilder.DeleteData(
                table: "CodeFrees",
                keyColumn: "Id",
                keyValue: new Guid("dca4fb69-d665-4507-b2c6-629e7f12d4bb"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("7260f4c8-b51e-4cb4-a9da-97e8a586a06c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("089c9284-0e43-4d15-b04c-dc8c5657c795"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("17dfb15d-3cae-4c20-8d8a-569c22b44b37"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("4813fe2c-92cc-4859-af21-8b90c18ba686"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("734b02b0-9113-4f79-9633-de7fa4fcdfa5"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("aa2452d5-33ca-4517-b43b-a849e80b92f6"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("34ea1c1f-1981-4d64-82f9-bdb61f8a72cc"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3b0d9018-8dff-49a6-a6f8-aa545d1f9ff8"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("62cdfdb4-325b-451e-9e55-5a96c39b5ad7"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("81906f10-0081-4a9b-814a-e0ca60ed6a6b"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("a9290d79-ac44-4a14-83ad-c0e2f3411552"));

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Categories");

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

            migrationBuilder.CreateIndex(
                name: "IX_CategoryGames_CategoryId",
                table: "CategoryGames",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryGames");

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

            migrationBuilder.AddColumn<Guid>(
                name: "GameId",
                table: "Categories",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Money", "Name", "Reliability" },
                values: new object[,]
                {
                    { new Guid("81906f10-0081-4a9b-814a-e0ca60ed6a6b"), 10000000, "Name here", 5 },
                    { new Guid("3b0d9018-8dff-49a6-a6f8-aa545d1f9ff8"), 10000000, "Name here", 5 },
                    { new Guid("34ea1c1f-1981-4d64-82f9-bdb61f8a72cc"), 10000000, "Name here", 5 },
                    { new Guid("a9290d79-ac44-4a14-83ad-c0e2f3411552"), 10000000, "Name here", 5 },
                    { new Guid("62cdfdb4-325b-451e-9e55-5a96c39b5ad7"), 10000000, "Name here", 5 },
                    { new Guid("7260f4c8-b51e-4cb4-a9da-97e8a586a06c"), 10000000, "Name here", 5 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Content", "Logo", "Name", "Price", "PublisherId", "PurchaseDate", "Rating", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("734b02b0-9113-4f79-9633-de7fa4fcdfa5"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("81906f10-0081-4a9b-814a-e0ca60ed6a6b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("17dfb15d-3cae-4c20-8d8a-569c22b44b37"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("3b0d9018-8dff-49a6-a6f8-aa545d1f9ff8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("089c9284-0e43-4d15-b04c-dc8c5657c795"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("34ea1c1f-1981-4d64-82f9-bdb61f8a72cc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("aa2452d5-33ca-4517-b43b-a849e80b92f6"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("a9290d79-ac44-4a14-83ad-c0e2f3411552"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" },
                    { new Guid("4813fe2c-92cc-4859-af21-8b90c18ba686"), "Good Game", "URL Logo here", "Name Of Game", 100000f, new Guid("62cdfdb4-325b-451e-9e55-5a96c39b5ad7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "URL Video here" }
                });

            migrationBuilder.InsertData(
                table: "CodeFrees",
                columns: new[] { "Id", "Code", "GameId" },
                values: new object[,]
                {
                    { new Guid("dca4fb69-d665-4507-b2c6-629e7f12d4bb"), "e1f6f5a8-7c0f-4e58-b723-f4c4a2558c31", new Guid("734b02b0-9113-4f79-9633-de7fa4fcdfa5") },
                    { new Guid("766ff9f8-2e15-4c1b-ba4d-ce16b02a200f"), "5895a2e3-74ed-4681-8c3a-03a4733d4200", new Guid("17dfb15d-3cae-4c20-8d8a-569c22b44b37") },
                    { new Guid("89ea38be-c9ad-4b62-867f-1cceca06d79e"), "5373325b-627f-4f2e-a657-3a84d228f081", new Guid("089c9284-0e43-4d15-b04c-dc8c5657c795") },
                    { new Guid("82e195e3-4cf9-413d-8d9e-034285290c49"), "8a3e6c04-afb4-4f18-9e07-d63f43bb0a4c", new Guid("aa2452d5-33ca-4517-b43b-a849e80b92f6") },
                    { new Guid("97a5bb01-4584-46db-af2f-70148e66d20e"), "4afe60dc-7b25-4a26-a22c-f1c86dd68825", new Guid("4813fe2c-92cc-4859-af21-8b90c18ba686") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_GameId",
                table: "Categories",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Games_GameId",
                table: "Categories",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
