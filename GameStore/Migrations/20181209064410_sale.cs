using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStore.Migrations
{
    public partial class sale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("2a0ffe9e-d7f3-407c-8203-ccd18f2c3411"), new Guid("05bb4066-33fb-45fb-8e83-c6dcfd147ae3") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("6d207d13-0cbb-469b-96b8-5342e68cad5e"), new Guid("0a16e661-1a8d-40d8-8d16-e6834e7d810b") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("b2cdff6e-c70d-4aa5-8f69-f0524f8e1662"), new Guid("83808d70-3dd0-4b9f-a91d-2f9c93c8bf3e") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("cafa1ca6-0429-4e93-b3ec-5bea71f7dbdc"), new Guid("e6be55d3-df3b-497e-a066-d2accbbaef2e") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("f4ef0ad1-e1d4-4513-8754-84a3cb78bef1"), new Guid("6cd8e859-cbae-46e1-a584-ae443996a199") });

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("2ebd203d-13f7-4f0a-adbe-a394a12994d4"));

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("452eafe2-67fa-43d3-af23-bfc76de27daa"));

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("94cc43fc-3446-47d3-a735-c4dbda5de144"));

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("db7a3b28-6146-43f5-a76e-ec9b798a9397"));

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("fb26db4e-ad6e-4e0a-9a2a-6ff4c3b3a96d"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("0246dcd4-c665-44dd-b9dd-6fcbbc776a53"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("0c82039f-374c-4582-ad63-b7ffd8b49084"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("103aafff-daf0-4f03-afc4-dd5f0444ff64"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("154898cd-0d68-4b88-b466-7702362eb3a5"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("1a2efd51-ba72-46d9-8f9b-9e0114ea2653"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("1b3df0d4-e6a6-441c-8644-f2f2156f51a8"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("1d8058c7-b757-4975-9c20-1b2c9042f816"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("1dda6ad8-3ae1-4477-b802-f09072b5862b"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("284f5e2a-8363-4a99-8ac4-b898efe0bf02"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("29de524e-52d7-4569-b071-012a921c8cb7"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("2bf4ad21-4722-41bf-a487-84c7c0131fe3"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("2d504a50-19a9-48ad-9571-348e4dea8b56"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("3026cdb0-2b55-4ad5-b581-2cc424e48e71"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("331e7d54-d197-4541-ab32-24afb50d5e14"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("33b92d52-f0b7-4188-b48f-a304235746da"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("352df0ac-3313-4855-9e0e-f0ae943cbb17"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("380b0b57-40ab-4af1-a9f3-9a87b171550c"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("388dba3b-51db-49ad-9d26-f3d246571e5c"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("3ee10dcc-1672-43ca-999e-a47578b3c3c6"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("3f45ce64-7275-44a9-9c03-67779ef50e52"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("4714fe62-478f-46c8-9b7d-35bf296726d6"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("494830a6-0a28-49b6-bc19-a4aab241c1a0"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("4bf8b801-ec64-4c91-9f76-40c777b8a022"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("4c0f543c-f40e-4241-800a-563c23d11931"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("4c77e707-b6c4-405d-b995-de56cba8db7e"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("52fc2683-c6a7-4a4a-b0e8-69469876bdf8"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("58d6b958-75ca-4966-8d0c-09d8cfa77eb1"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("5ac8caed-095f-4dc6-8a7b-054da3c14cc0"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("5dae44e0-8e3b-415b-a27d-c1d79723a1ec"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("5dbff9e3-0b1b-4fcd-aeea-9114468ce76f"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("61686d71-962a-44d0-b2e0-e7961c2c03df"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("6347589d-713e-42ba-84b1-7e17a323e9e0"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("66041824-ff1d-409e-9a7d-a17f218ba02b"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("66345a16-125d-4c63-bd78-7d4a29049110"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("66c3ef34-e821-4f44-b360-d7f9d5837dfb"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("6aa6cd19-269f-4d30-b88e-542fad65650c"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("6bab413b-b9f3-47a7-b31d-96999acc3170"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("6fc3a1bc-6b87-4da1-90e7-de6c8878eaf8"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("709b7063-3fc7-4763-bc81-4040729daac2"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("74b3ef9e-328e-4c69-9fd0-357b9ac09a28"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("75620beb-9c66-40e5-a9e4-86103540f818"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("77a52d48-b9e4-454b-a061-431bd3ef8a3a"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("7cc229ba-646a-425e-b9e7-90c544771f74"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("833ab0a5-26d4-413f-8090-d18ff0d2304b"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("8684a17a-f7f8-4541-8ed8-b497c2393240"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("88f91370-e00e-4417-8763-7a769eb8ea1b"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("8917270e-fcb3-4c44-90a2-42e824240794"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("8ae523ce-52bd-4c54-8b1e-ce125bdbb5a2"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("8b006e07-21f6-43d1-9fcf-021fd4206d19"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("90cde699-1046-4dc5-9ef6-a7ef689954b3"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("90f6540c-def0-46ad-a1f6-6a87fec771b3"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("939f53de-ff4c-4013-b002-cd219c2314dd"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("96578e08-ac41-49ea-bfad-64b212c5f600"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("99c4dfba-96e4-4ca1-ab26-6c69bb8db208"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("9e1ab976-ca52-497a-b40f-614ca7f5aedc"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("a003913e-9e96-4e68-ae8d-8c236dadb188"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("a3286ebd-8190-4e92-a84f-4bef20021444"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("afebac09-cd0e-432b-b647-ab202396f32a"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("b01b54ed-7860-4f30-97cd-26082ff4fa57"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("b11e35f2-1ed5-439f-b25c-bc20ecf1145a"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("b80ce391-2cd2-4925-99a7-b0861e0cf028"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("bbf5f195-c962-4368-9a18-9e06b32b90a8"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("c19e5adf-7e0a-4e9e-9973-5cd256bdae6b"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("c85d55b8-f7ba-4b83-9509-f7a728a893e1"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("cddac6f7-3f4d-4d0b-ad36-b4985ccfb8a8"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("ce3739dc-8a29-4ff2-83be-16173c552315"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("d6953922-f45e-4026-bd49-a9f47dc17a4d"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("dd858fef-1268-4160-9b52-e94ea307ee35"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("e172ea08-c92b-4167-85d9-29cc6c5ee8f8"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("e4436c65-4da6-4878-829c-6f18e2e179a8"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("e4942ff7-ee42-4c7c-8053-64785b20e4df"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("e5f8f1fd-b3f4-4740-9966-00c3b5cee137"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("f15bdd0f-d724-4852-bcc7-08909b4ab369"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("f1a83cca-032f-490a-8dd9-fa9f559bdb43"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("f893dfe1-794d-48bc-a651-49eb0e9c4959"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("fdd791a2-f76c-43cb-b85f-a3195fb71f8c"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("05ae0ff7-2369-4620-a43d-01c3b9a1ed13"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("08ffec37-e19a-4704-8941-1544978dbdca"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("387b241a-6d51-4dfe-81f7-db6630cf1268"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("47a33a6c-1b32-4394-b341-c1c576d02269"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("7dcf281d-4013-40f6-a84f-85828536c779"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("81102236-9bc8-4672-a451-47241320471f"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("8ee5076e-fba3-4b7a-8a16-85d55cb61c57"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("9789619a-da39-4202-9c50-15b016b4f5df"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("a59f2ed2-5a40-4d9a-8368-6a253e173532"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("abb815d5-0261-420a-ae44-1cbbad1cc11b"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("aeb244a4-0eb5-459d-a528-34f293a52fec"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("ee9b09d6-abb4-406d-96df-173e79bafdc1"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("837729a4-d96b-4f84-ba94-65e1dc45ff32"), "User" });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("d79a42b6-6f4c-470d-95af-80f92519ea0a"), "Admin" });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("9025855a-8baf-482f-80dc-852a0a8f22b7"), new Guid("b2cdff6e-c70d-4aa5-8f69-f0524f8e1662") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("92417557-ceac-4229-bd39-013b65cc0fbd"), new Guid("cafa1ca6-0429-4e93-b3ec-5bea71f7dbdc") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("bcfdfd0f-ddd6-4533-8f10-54f11a89cdba"), new Guid("2a0ffe9e-d7f3-407c-8203-ccd18f2c3411") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("d18587d8-66b5-4aa7-8f92-db5ed036697d"), new Guid("6d207d13-0cbb-469b-96b8-5342e68cad5e") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("eb7d9d2d-107b-4730-a2a3-0acc61fde5e9"), new Guid("f4ef0ad1-e1d4-4513-8754-84a3cb78bef1") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("9025855a-8baf-482f-80dc-852a0a8f22b7"), new Guid("b2cdff6e-c70d-4aa5-8f69-f0524f8e1662") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("92417557-ceac-4229-bd39-013b65cc0fbd"), new Guid("cafa1ca6-0429-4e93-b3ec-5bea71f7dbdc") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("bcfdfd0f-ddd6-4533-8f10-54f11a89cdba"), new Guid("2a0ffe9e-d7f3-407c-8203-ccd18f2c3411") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("d18587d8-66b5-4aa7-8f92-db5ed036697d"), new Guid("6d207d13-0cbb-469b-96b8-5342e68cad5e") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("eb7d9d2d-107b-4730-a2a3-0acc61fde5e9"), new Guid("f4ef0ad1-e1d4-4513-8754-84a3cb78bef1") });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("05bb4066-33fb-45fb-8e83-c6dcfd147ae3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0a16e661-1a8d-40d8-8d16-e6834e7d810b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6cd8e859-cbae-46e1-a584-ae443996a199"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("83808d70-3dd0-4b9f-a91d-2f9c93c8bf3e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e6be55d3-df3b-497e-a066-d2accbbaef2e"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0103fa55-1bec-464c-9121-375d953c58af"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("143203a7-69c1-4a75-b04f-4b56c3cafde2"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("196e363c-ffa1-47bb-a701-3ba50c203287"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("2a0ffe9e-d7f3-407c-8203-ccd18f2c3411"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("4eec3fd2-d6f2-4b61-97ca-39cac256bed4"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("621dfe75-6e9c-4264-a72d-330533e29d49"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6d207d13-0cbb-469b-96b8-5342e68cad5e"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("acd32c9e-26ff-403b-9199-cb5d9b1b71a1"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2915638-a97b-4305-a377-2c717866a24b"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2cdff6e-c70d-4aa5-8f69-f0524f8e1662"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b55a1ae3-5e06-416f-8532-8406201f45fc"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b93a3a8e-1db8-4221-80a4-79336b613c59"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b9d7a713-1d9b-474c-b605-5948c7598727"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("c1fc2ff2-0562-4f41-a543-c8488a799dc0"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("c31974c6-8bdb-4984-b881-cceec254d18a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("cafa1ca6-0429-4e93-b3ec-5bea71f7dbdc"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e14552de-2b28-4332-8181-70617811f804"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e291a33f-3938-4079-8a6c-853efac83147"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f4ef0ad1-e1d4-4513-8754-84a3cb78bef1"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("2c232b87-86ef-4e25-92e5-d3d3092626ec"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("7590e48f-fc84-4625-8590-7c3fd0c450b9"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("f572bc41-0731-456f-af74-29b2ab39981c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("9025855a-8baf-482f-80dc-852a0a8f22b7"), "bc90b5c5-2148-4f8c-82c9-4daf30a596f4" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("92417557-ceac-4229-bd39-013b65cc0fbd"), "263879f7-1f28-4b7d-8dfa-a7f74e2fe3ae" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("bcfdfd0f-ddd6-4533-8f10-54f11a89cdba"), "83bab6ab-d1a9-42c0-be13-aa35906d20e6" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("d18587d8-66b5-4aa7-8f92-db5ed036697d"), "d0468431-28a1-49e7-90af-f088afc0a512" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("eb7d9d2d-107b-4730-a2a3-0acc61fde5e9"), "5ba03cb7-0097-4fb6-a118-633fd0d31146" });

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("074ec8ce-c16e-477a-b75b-34b52ae8087a"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("0ac34e93-611c-4518-8396-5f1a82b22d6d"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("2211448e-4b82-4aaf-aac6-17eae0ce5bea"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3ba59319-5efe-4990-bf08-b67180368582"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("51517093-aa4d-4cf1-a7ac-37a8b2d3eba1"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("529dcff9-cbae-449f-8e24-f2c99a830a3c"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6f76d72b-0e80-4bb5-b740-5db4282b83ce"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("af9d9533-ff1c-4f01-bac7-21bb443a8dbd"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("c24e6e15-535d-4b7a-b6aa-d004f524896a"));

            migrationBuilder.AddColumn<float>(
                name: "sale",
                table: "Games",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("9ef4566a-0817-4cb9-b325-d3ed4347e794"), "FPS" },
                    { new Guid("87c0f2be-9fda-4f32-98b6-a23ea3974cc3"), "Action" },
                    { new Guid("b4e09509-be8c-4b58-97c7-eb54f44c11c1"), "Adventure" },
                    { new Guid("0892341c-66bf-431a-a982-d5e84b545d03"), "Puzzle" },
                    { new Guid("359d5185-401f-4b78-bab6-31899c5e6e82"), "Open world" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Money", "Name", "Reliability" },
                values: new object[,]
                {
                    { new Guid("65c41248-d194-457e-83c2-d8b546281ae5"), 0f, "King", 0 },
                    { new Guid("a1d92e4f-644f-481e-a5bb-de0aff808a41"), 0f, "Rovio Entertainment Corporation", 0 },
                    { new Guid("29cabc93-41f2-47a1-8ab6-41c5588a2137"), 0f, "Outfit7 Limited", 0 },
                    { new Guid("86b7600a-724e-4aef-bb46-e3715e442704"), 0f, "AMANOTES", 0 },
                    { new Guid("0e73cf7a-7231-4f12-93b6-c87f9089a894"), 0f, "Gameloft", 0 },
                    { new Guid("a67d3c43-5dd3-4d59-981a-8efa4c6c7a0e"), 0f, "Mobigame S.A.R.L.", 0 },
                    { new Guid("8c71ea7a-6904-4a3c-895e-4d23988fe24f"), 0f, "Imangi Studios", 0 },
                    { new Guid("05f9247c-140e-4f56-909e-7eb7c645e3c8"), 0f, "NEKKI", 0 },
                    { new Guid("a2eb0c3c-a27d-40b2-9ad4-08a1d59eedb3"), 0f, "Kiloo", 0 },
                    { new Guid("fcc86f57-587d-4e35-b0cd-cd94e057a6b4"), 0f, "ZeptoLab", 0 },
                    { new Guid("fa2a0115-b0da-4cba-8e84-c911705b19c8"), 0f, "ELECTRONIC ARTS", 0 },
                    { new Guid("080db791-6652-4e65-aa7a-7fce8f0c359e"), 0f, "J-PARK", 0 }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("be6ab956-8893-4c73-801a-b11bf852febf"), "User", "Limited Permission", "User", "User" },
                    { new Guid("7028deff-1023-4943-ab10-8d35ff59f006"), "Admin", "Full Permission", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Hobbies", "LockoutEnabled", "LockoutEnd", "Money", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3524b7f0-4024-40c0-a2b6-f826c6bed071"), 0, "1171f7f7-f7be-477d-9b7e-d3290e3ffaeb", "duykkxm92@gmail.com", false, "Nguyen Ngoc Duy", "Hobbies", false, null, 0f, null, null, "duykkxm92", "01638789455", false, null, false, "duykkxm92" },
                    { new Guid("02a2f635-d049-44c4-9564-477e0aad0630"), 0, "8ca82bb1-a978-441a-9869-0b470d9c58c3", "Email1@gmail.com", false, "Full Name", "Hobbies", false, null, 0f, null, null, "Thatvuhai_7595", "93098509228098523", false, null, false, "UserName1" },
                    { new Guid("3d98220d-387b-4c64-ae62-197dd41657bc"), 0, "76edfe44-b400-47cf-b5fb-67f3dce2b966", "Email2@gmail.com", false, "Full Name", "Hobbies", false, null, 0f, null, null, "Thatvuhai_7595", "93098559238098523", false, null, false, "UserName2" },
                    { new Guid("84c9c1de-a029-456a-bf21-193301846a94"), 0, "2ab41f20-d5f1-4515-9b74-ee6b061039ef", "Email3@gmail.com", false, "Full Name", "Hobbies", false, null, 0f, null, null, "Thatvuhai_7595", "93098609238098523", false, null, false, "UserName3" },
                    { new Guid("6594f0fa-dbe1-4dc7-a57f-35d736316e99"), 0, "0e372e8d-4a80-4e28-9dfa-ccb7edb5177b", "Email4@gmail.com", false, "Full Name", "Hobbies", false, null, 0f, null, null, "Thatvuhai_7595", "93098509738098523", false, null, false, "UserName4" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Content", "Name", "Price", "PublisherId", "Rating", "ReleaseDate", "VideoUrl", "sale" },
                values: new object[,]
                {
                    { new Guid("dc3ec80c-2563-4e41-8b25-56a5d6a2619a"), "DASH as fast as you can! DODGE the oncoming trains!Help Jake, Tricky & Fresh escape from the grumpy Inspector and his dog.  Grind trains with your cool crew!  Colorful and vivid HD graphics!  Hoverboard Surfing!  Paint powered jetpack!  Lightning fast swipe acrobatics!  Challenge and help your friends!", "Subway Surfers", 0f, new Guid("a2eb0c3c-a27d-40b2-9ad4-08a1d59eedb3"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here", 0f },
                    { new Guid("ab364f2e-ad15-4157-b1f4-c87754af9a8a"), "The sequel to the famous Facebook smash hit with 40 million users Shadow Fight 2 is a nail-biting mix of RPG and classical Fighting. This game lets you equip your character with countless lethal weapons and rare armor sets, and features dozens of lifelike-animated Martial Arts techniques! Crush your enemies, humiliate demon bosses, and be the one to close the Gate of Shadows. Do you have what it takes to kick, punch, jump, and slash your way to victory? There’s only one way to find out", "Shadow Fight 2", 100000f, new Guid("05f9247c-140e-4f56-909e-7eb7c645e3c8"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here", 0f },
                    { new Guid("6d84598a-8355-4cfb-a6cd-bcfed109dd6d"), "Strap on your running shoes and join the award-winning, fan-favorite runner, Minion Rush. Enter Gru's Lair, discover its many mysterious rooms, and take on manic missions around the world. Along the way, your Minions will jump, roll and dodge obstacles while unlocking a collection of cool Minion costumes.", "Minion Rush: Despicable Me Official Game", 100000f, new Guid("a1d92e4f-644f-481e-a5bb-de0aff808a41"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here", 0f },
                    { new Guid("d4cabd56-b6ba-4778-a060-4206daf3665f"), "Use the unique powers of the Angry Birds to destroy the greedy pigs' defenses! The survival of the Angry Birds is at stake. Dish out revenge on the greedy pigs who stole their eggs. Use the unique powers of each bird to destroy the pigs’ defenses. Angry Birds features challenging physics-based gameplay and hours of replay value. Each level requires logic, skill and force to solve.", "Angry Birds Classic", 100000f, new Guid("a1d92e4f-644f-481e-a5bb-de0aff808a41"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here", 0f },
                    { new Guid("146a2136-f83e-492b-b470-7933bedbfa55"), "Is it a baby? Is it a puppy? No! It’s Talking Tom! The cutest kitten, the coolest cat, and the biggest superstar in the world! My Talking Tom is the best virtual pet game for children, and big kids of all ages.That’s right - even grandma and grandpa can join the fun!", "My Talking Tom", 100000f, new Guid("29cabc93-41f2-47a1-8ab6-41c5588a2137"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here", 0f },
                    { new Guid("aede8454-cfa3-427e-b6fa-27370da34299"), "Dragon Mania Legends is for anyone that wants their very own pet dragon, which is obviously everyone… – Gamezebo", "Dragon Mania Legends", 100000f, new Guid("86b7600a-724e-4aef-bb46-e3715e442704"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here", 0f },
                    { new Guid("24608d67-717e-4ce3-9274-c38b7eee7e1b"), "Play the award-winning hit action-strategy adventure where you meet, greet, and defeat legions of hilarious zombies from the dawn of time, to the end of days. Amass an army of amazing plants, supercharge them with Plant Food, and devise the ultimate plan to protect your brain.", "Plants vs Zombies 2 Free", 0f, new Guid("86b7600a-724e-4aef-bb46-e3715e442704"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here", 0f },
                    { new Guid("b00bd132-0843-4beb-a839-fa41a45bec4f"), "Magic Tiles 3 ™ is one of the most loved piano games among thousands of free games in 2018 which has more than 80 million players around the world.", "Magic Tiles 3", 100000f, new Guid("86b7600a-724e-4aef-bb46-e3715e442704"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here", 0f },
                    { new Guid("b12b384c-188d-4cce-bccc-e9d2b4e1869c"), "Follow the adventure of Om Nom in the first part of the legendary Cut the Rope logic puzzles series. Get it now for free and start playing with millions of players around the world!", "Cut the Rope FULL FREE", 0f, new Guid("65c41248-d194-457e-83c2-d8b546281ae5"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here", 0f },
                    { new Guid("a755dac5-992f-4ce5-b94c-f7a20d9357f6"), "A strange group of enemies appeared in the city and have been using innocent people as experimental tools. Lots of people have turned into Zombie so that Hero and his friends should save the people and remove the enemies.", "Anger of stick 5 : zombie", 100000f, new Guid("65c41248-d194-457e-83c2-d8b546281ae5"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here", 0f },
                    { new Guid("45be5896-5696-48e0-ba07-f7750e244c9b"), "Start playing Candy Crush Saga today – loved by millions of players around the world. With over a trillion levels played, this sweet match 3 puzzle game is one of the most popular mobile games of all time!", "Candy Crush Saga", 100000f, new Guid("65c41248-d194-457e-83c2-d8b546281ae5"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here", 0f },
                    { new Guid("203cc275-e374-4a64-acd2-d43cc8352b5c"), "The time to take action and strike back is now! We’re calling for the best sniper in the world to take aim at evil, wherever it hides.There’s no room for remorse, so shoot to kill…", "Sniper Fury: Top shooting game - FPS", 100000f, new Guid("65c41248-d194-457e-83c2-d8b546281ae5"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here", 0f },
                    { new Guid("ce1bec21-cb5a-45e8-8b2f-2ec64e02db93"), "5 lớp nhân vật tùy biến có thể lên cấp cả trong chơi đơn lẫn chơi mạng. Kiếm và dùng Điểm Kĩ năng để kích hoạt kĩ năng riêng của từng lớp nhân vật. Đấu Đội trong các trận Chơi mạng. Bảng xếp hạng Cá nhân và Đội. Nói chuyện với người chơi khác trong mục Chat Toàn cầu và Đội. Nhiệm vụ tiết tấu nhanh với nhiều thử thách khác nhau từ Tokyo đến Venice.", "Modern Combat 5: eSports FPS", 100000f, new Guid("fa2a0115-b0da-4cba-8e84-c911705b19c8"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here", 0f },
                    { new Guid("56ec23eb-77ca-4286-a696-f34603803dc6"), "Help Swampy by guiding water to his broken shower. Each level is a challenging physics-based puzzle with amazing life-like mechanics. Cut through dirt and guide fresh water, dirty water, toxic water, steam, and ooze through increasingly challenging scenarios! Every drop count", "Where's My Water? Free", 0f, new Guid("a2eb0c3c-a27d-40b2-9ad4-08a1d59eedb3"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here", 0f },
                    { new Guid("33440e72-9579-4d42-b724-6199c8462193"), "The zombies are revolting ! Attack the city with a horde of zombies, change pedestrians into zombies and create the largest horde. Eat your friends, and challenge them to a crazy race by destroying everything in your path. Zombie Tsunami has proudly exceeded 200 million players around the world.", "Zombie Tsunami", 100000f, new Guid("a67d3c43-5dd3-4d59-981a-8efa4c6c7a0e"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here", 0f },
                    { new Guid("10c1dd12-82b9-4544-9839-706301ff1de7"), "N.O.V.A. Legacy brings you the best 3D sci-fi FPS experience based on the epic first episode of N.O.V.A., which received critical acclaim -- all in a compact version of the shooter. Kal Wardin, our hero, is a veteran N.O.V.A. marine, summoned once again to don his Mobile Armored Suit and strike against the enemies of the Colonial Administration forces. Helped by Yelena, his personal AI Agent, Kal must protect humanity's destiny by engaging in combat against alien invaders while uncovering the mystery behind their sudden assault.", "N.O.V.A. Legacy", 100000f, new Guid("a67d3c43-5dd3-4d59-981a-8efa4c6c7a0e"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here", 0f },
                    { new Guid("306a343f-1f8e-4117-8ce2-20be792495f3"), "With over a zillion downloads, Temple Run redefined mobile gaming. Now get more of the exhilarating running, jumping, turning and sliding you love in Temple Run 2! Navigate perilous cliffs, zip lines, mines and forests as you try to escape with the cursed idol. How far can you run ? !", "Temple Run 2", 50000f, new Guid("8c71ea7a-6904-4a3c-895e-4d23988fe24f"), 4.3f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here", 0f },
                    { new Guid("39a5e5b2-1438-4f9e-a187-c3f0afc4a593"), "In Asphalt 8, you’ll race in some of the hottest, most high-performance dream machines ever created, from cars to bikes, as you take them on a global tour of speed. From the blazing Nevada Desert to the tight turns of Tokyo, you’ll find a world of challenge, excitement and arcade fun on your road to the top!", "Asphalt 8: Airborne", 100000f, new Guid("a67d3c43-5dd3-4d59-981a-8efa4c6c7a0e"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here", 0f },
                    { new Guid("3fc49719-0bcf-4ffb-97e7-743350da0f64"), "Get ready to soil your plants as a mob of fun-loving zombies is about to invade your home. Use your arsenal of 49 zombie-zapping plants — peashooters, wall-nuts, cherry bombs and more — to mulchify 26 types of zombies before they break down your door.", "Plants vs. Zombies FREE", 100000f, new Guid("fa2a0115-b0da-4cba-8e84-c911705b19c8"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here", 0f }
                });

            migrationBuilder.InsertData(
                table: "ImagePublishers",
                columns: new[] { "Id", "PublisherId", "UrlLocal", "UrlOnline" },
                values: new object[,]
                {
                    { new Guid("8c865392-6891-4455-9b8d-89c69617ed49"), new Guid("a67d3c43-5dd3-4d59-981a-8efa4c6c7a0e"), null, "http://4.bp.blogspot.com/-jAUhK8EAuiA/VmnLpfRWLHI/AAAAAAAAAkI/Hp8mTQXl8xM/s1600/Zombie%2BTsunami%2B-%2BLogo%2BMobigame.jpg" },
                    { new Guid("fc660cf9-046a-4ce0-8c39-31ae0bf21196"), new Guid("0e73cf7a-7231-4f12-93b6-c87f9089a894"), null, "https://pbs.twimg.com/profile_images/1026435341312512001/u3D328AP_400x400.jpg" },
                    { new Guid("eb5d09e2-5fd7-4c86-9d70-e557b595fd6b"), new Guid("86b7600a-724e-4aef-bb46-e3715e442704"), null, "https://employer.jobsgo.vn/image.php?src=1187_logo_1187_20170209115933_1779.jpg&w=300&h=300" },
                    { new Guid("8aec7e6e-510e-4277-a74c-02fb86f86257"), new Guid("fa2a0115-b0da-4cba-8e84-c911705b19c8"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRbShsNR-wcUaPKBv2NxLSeE6arTMAMGZNs5L219VYdIxUapVJc" },
                    { new Guid("b6a14b45-d41b-418b-ace1-f4c433ab29c9"), new Guid("29cabc93-41f2-47a1-8ab6-41c5588a2137"), null, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/O7_logo-red_cmyk.jpg/1200px-O7_logo-red_cmyk.jpg" },
                    { new Guid("4d9ba321-d4af-489d-9cc5-cec711bd7116"), new Guid("8c71ea7a-6904-4a3c-895e-4d23988fe24f"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS3aHsnIsbz6CxKRg5tmpq73iNWV6J65niLvsEs9tKf9feje5iv" },
                    { new Guid("a4a5e16a-86a8-424e-937c-b8cadfbb79a3"), new Guid("a2eb0c3c-a27d-40b2-9ad4-08a1d59eedb3"), null, "https://www.kiloo.com/wp-content/uploads/2017/03/sharelogo-2.png" },
                    { new Guid("2bc4efee-b271-4bc2-82f9-99e0ec5de892"), new Guid("a1d92e4f-644f-481e-a5bb-de0aff808a41"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdbIPf6EeERMGnyQoYkE4xUMuaU22OEtWLEfHWjAw6vxzGJ5oq" },
                    { new Guid("f1d97351-09a6-41a9-baed-e02148556aeb"), new Guid("05f9247c-140e-4f56-909e-7eb7c645e3c8"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQkyOmWOFhXD1lRsMIHkAJrLIvjwmImH1GBwlmqb3I5ysGUNY0-" },
                    { new Guid("4d4a5b74-c885-407c-917f-cf048867fea8"), new Guid("080db791-6652-4e65-aa7a-7fce8f0c359e"), null, "https://upload.wikimedia.org/wikipedia/vi/thumb/2/2a/ZeptoLab.png/200px-ZeptoLab.png" },
                    { new Guid("c1742d14-5165-4da7-954a-7c83de32ff09"), new Guid("65c41248-d194-457e-83c2-d8b546281ae5"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSE0L-3DI9ruta232UcPOIlvnE3I3xV-8l1u_C3Grzx6tmXrDzs" },
                    { new Guid("7f8a2c0f-779b-4b93-82cc-85b9dc22cfcd"), new Guid("fcc86f57-587d-4e35-b0cd-cd94e057a6b4"), null, "https://upload.wikimedia.org/wikipedia/vi/thumb/2/2a/ZeptoLab.png/200px-ZeptoLab.png" }
                });

            migrationBuilder.InsertData(
                table: "CategoryGames",
                columns: new[] { "GameId", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("dc3ec80c-2563-4e41-8b25-56a5d6a2619a"), new Guid("9ef4566a-0817-4cb9-b325-d3ed4347e794") },
                    { new Guid("306a343f-1f8e-4117-8ce2-20be792495f3"), new Guid("b4e09509-be8c-4b58-97c7-eb54f44c11c1") },
                    { new Guid("45be5896-5696-48e0-ba07-f7750e244c9b"), new Guid("359d5185-401f-4b78-bab6-31899c5e6e82") },
                    { new Guid("3fc49719-0bcf-4ffb-97e7-743350da0f64"), new Guid("0892341c-66bf-431a-a982-d5e84b545d03") },
                    { new Guid("33440e72-9579-4d42-b724-6199c8462193"), new Guid("87c0f2be-9fda-4f32-98b6-a23ea3974cc3") }
                });

            migrationBuilder.InsertData(
                table: "FreeCodes",
                columns: new[] { "Id", "Code", "GameId" },
                values: new object[,]
                {
                    { new Guid("3a893150-8db6-40a5-8f7e-70438cad992a"), "61174dcd-87fe-4eb8-870d-2f44293708ff", new Guid("306a343f-1f8e-4117-8ce2-20be792495f3") },
                    { new Guid("b5f3b1a5-deb1-44a8-9045-f2b896f979fd"), "bb396405-43b7-42aa-871c-338bc9003028", new Guid("3fc49719-0bcf-4ffb-97e7-743350da0f64") },
                    { new Guid("5803a231-953b-4377-9bf3-27e60f407f4a"), "8cb350df-8f4d-491f-b03e-1725dd7c13e1", new Guid("45be5896-5696-48e0-ba07-f7750e244c9b") },
                    { new Guid("60455195-5f87-4596-a131-ea9f3172ff36"), "cff39756-9939-493c-83de-bd9d3b6e1fbf", new Guid("33440e72-9579-4d42-b724-6199c8462193") },
                    { new Guid("ef69bebf-7962-44a4-83a4-4bb9036da2ec"), "4ff7f1bd-8393-4efe-97f7-5773c2f89307", new Guid("dc3ec80c-2563-4e41-8b25-56a5d6a2619a") }
                });

            migrationBuilder.InsertData(
                table: "ImageGames",
                columns: new[] { "Id", "GameId", "UrlLocal", "UrlOnline" },
                values: new object[,]
                {
                    { new Guid("672a5d88-de66-4666-a80d-7ad666b0d23e"), new Guid("b12b384c-188d-4cce-bccc-e9d2b4e1869c"), "", "https://lh3.googleusercontent.com/Qnm85mIcd32-R8IxmDXM1MPgCfpM2-duddE7P_iS55P0xFO6ZM9jo9dt6PThjWhZvw=w720-h310" },
                    { new Guid("7644c761-92da-489c-90ba-39f19359b0cc"), new Guid("45be5896-5696-48e0-ba07-f7750e244c9b"), "", "https://lh3.googleusercontent.com/ucBNG7Vj8Lqo8b14PUMyzB8h7f2YcZ9oKB6BuFaJTgCj4jEv3Zo1jFPg-FjdONrw8c7b=w720-h310" },
                    { new Guid("07cf2fbd-8c92-4297-9611-9890e0bd475a"), new Guid("b00bd132-0843-4beb-a839-fa41a45bec4f"), "", "https://lh3.googleusercontent.com/Z_KPg-BqbZVMMLlH689YEwzPefUXW0l_7MfPS8-KUzDV4-y-VeSfnswbSXakPJfoJw8=w720-h310" },
                    { new Guid("248a56ca-c86f-43d9-816f-ee7c91f361ce"), new Guid("b00bd132-0843-4beb-a839-fa41a45bec4f"), "", "https://lh3.googleusercontent.com/uJK2kFV81mdNGWE9nDO__wadnVhC8afhQourrne9WhOy0ip1UjlsElsw9xd0BV3NCG8=w720-h310" },
                    { new Guid("d63fad2d-45af-4b66-8a94-0e783a091272"), new Guid("203cc275-e374-4a64-acd2-d43cc8352b5c"), "", "https://lh3.googleusercontent.com/5W6OOrho0AFit_nm98QqpCsu52uHc-kw7RQPK4_PUdGEi6DjrmfZdPJIGYl2u_3Ibw=w720-h310" },
                    { new Guid("62276856-e096-4f0c-ab83-2e2ae712aa11"), new Guid("203cc275-e374-4a64-acd2-d43cc8352b5c"), "", "https://lh3.googleusercontent.com/5W6OOrho0AFit_nm98QqpCsu52uHc-kw7RQPK4_PUdGEi6DjrmfZdPJIGYl2u_3Ibw=w720-h310" },
                    { new Guid("e6ab0c2f-24d1-463b-b3de-a2c137ce33c9"), new Guid("203cc275-e374-4a64-acd2-d43cc8352b5c"), "", "https://lh3.googleusercontent.com/qSl0aQ-tQiBC_Ut0MC3n-I3HTgQsDQ52XUq_cnfu5rq9kyDSBs2vneGXZZ-PhVv8yb22=w720-h310" },
                    { new Guid("22e1c049-fcb8-4af7-9360-3534e8e8349b"), new Guid("203cc275-e374-4a64-acd2-d43cc8352b5c"), "", "https://lh3.googleusercontent.com/nNjmESXQm2dJupXjwYn9RvD6nhS6_5bAthB6GrjrHCdaoiftDAKABIEOBJd3paXCYg=w720-h310" },
                    { new Guid("daeb6b4b-1d7e-45cb-9c45-1d509aeb496a"), new Guid("45be5896-5696-48e0-ba07-f7750e244c9b"), "", "https://lh3.googleusercontent.com/EFv_aMUrdXQLXLesEfQAuFv9bNvQ5hwzYnuKZ1cr_OBDZU6cY6OZhIiDzfhx4eSuvtI=w720-h310" },
                    { new Guid("eb9299ce-6b72-4f43-9d79-07c44ecb3f09"), new Guid("a755dac5-992f-4ce5-b94c-f7a20d9357f6"), "", "https://lh3.googleusercontent.com/NdRmiugakoZ-CgyoqeEd7SC9xT_xFIfjY3LtjMifJ9_iKsUdzA5WgBrs2cgoAK3d_CNr=w720-h310" },
                    { new Guid("89f90832-a380-4d44-a31d-54c94b0fff3a"), new Guid("b12b384c-188d-4cce-bccc-e9d2b4e1869c"), "", "https://lh3.googleusercontent.com/uFYADCilcHxlddeBXKAAu9HNzQG0Mx1VqwuwGQg3WiXBZAg41hooWQTAUilvZetyYhqy=w720-h310" },
                    { new Guid("948c3038-39f2-4a71-a4ac-4c6abe7123f7"), new Guid("a755dac5-992f-4ce5-b94c-f7a20d9357f6"), "", "https://lh3.googleusercontent.com/A4POGA0IPwbcaSj5dba5zrn6tUlCiyvu4ppse912kWUzr084-qqgvCT0m-E99RPi228=w720-h310" },
                    { new Guid("d714a3e6-0e37-41e3-949a-37f63d8d137e"), new Guid("a755dac5-992f-4ce5-b94c-f7a20d9357f6"), "", "https://lh3.googleusercontent.com/PeX7REevxeIec-hxFckCJP0xyg88TEzwPh4zz2Prv08d-0UsspP6wcoaBXYJqWzkuQ=w720-h310" },
                    { new Guid("068984c3-a2a9-4e1b-9d34-a78c48b0274b"), new Guid("b12b384c-188d-4cce-bccc-e9d2b4e1869c"), "", "https://lh3.googleusercontent.com/cOijr_HBBvrjn7t00qwPQiXJ2y53NMSMI4iF2YSH89RDlmpe_MbppoqJmXTyIUPCj7M=w720-h310" },
                    { new Guid("7cf651de-d70d-4d4f-a4b9-7c87afac3ef8"), new Guid("b12b384c-188d-4cce-bccc-e9d2b4e1869c"), "", "https://lh3.googleusercontent.com/Kri8NpWg8Nt5BmgNxbMCrW4vxk7LqzjpvibCYHb24_RJgS-l58n-gFR2f4RE_uGfuKI=w720-h310" },
                    { new Guid("d6432d85-669a-4371-aa4a-d400494ca308"), new Guid("a755dac5-992f-4ce5-b94c-f7a20d9357f6"), "", "https://lh3.googleusercontent.com/YL2_i-PixRM-qYfrZ6CpAqyNiXW_MrIx2KFyg2zZLkdjjosIK5qyPg1dfbyTAC-BdNg=w720-h310" },
                    { new Guid("37cf6590-17cc-49d6-a772-ff60a24dbccc"), new Guid("b00bd132-0843-4beb-a839-fa41a45bec4f"), "", "https://lh3.googleusercontent.com/CjrXpLQr5ixH5K9RjdL4CFLhmfgkVCJVAw0bhOuFuFI0v4IaQyt1zbXLVxKfGz2l246x=w720-h310" },
                    { new Guid("ba990448-02e4-4a49-8b13-087d02ba9245"), new Guid("24608d67-717e-4ce3-9274-c38b7eee7e1b"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("52abf201-82ef-421d-b209-3618a26f00b1"), new Guid("24608d67-717e-4ce3-9274-c38b7eee7e1b"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("aa648f12-3f55-4800-bc93-047acaf452dd"), new Guid("ab364f2e-ad15-4157-b1f4-c87754af9a8a"), "", "https://lh3.googleusercontent.com/zRs9fTN-tL-p4yNL3ccFr1w3wUH-hqN0ShgwAnbzcnH2FidymdlixdDN-lpqF3xck4I=w720-h310" },
                    { new Guid("dfa7fd22-974c-4f34-9243-459f1113158f"), new Guid("ab364f2e-ad15-4157-b1f4-c87754af9a8a"), "", "https://lh3.googleusercontent.com/o0i5z7sG2EArHccVaOCYU516s3PzflywGTbzf3ylRoZwOizKm-jH2AKwXweh2_77Tw=w720-h310" },
                    { new Guid("7e466b50-fd2c-430c-b914-b508da5b14d6"), new Guid("6d84598a-8355-4cfb-a6cd-bcfed109dd6d"), "", "https://lh3.googleusercontent.com/JMc16QhAhKFbnW2jusl-T6xu8xo31BDzv8h7APyDdU006PkYvtk3q3Ey76LU-G908M0=w720-h310" },
                    { new Guid("3ad154ec-3491-46d6-8772-555bb2a44e88"), new Guid("6d84598a-8355-4cfb-a6cd-bcfed109dd6d"), "", "https://lh3.googleusercontent.com/RdxHjaoI2WK-ku4--LmPMaZ6DkLVYt0q9IKiSrdqXnmMKlPo4hgZHf0VdN8Oee5pxg=w720-h310" },
                    { new Guid("daa2e3da-f87d-40fe-8131-b04f322a310c"), new Guid("6d84598a-8355-4cfb-a6cd-bcfed109dd6d"), "", "https://lh3.googleusercontent.com/YYz6o1qMBxop37bvU1rfACXRv1AS-gNHOCjUW9lp6eLDV7BQAZ7zUIkG3PF597svP4gP=w720-h310" },
                    { new Guid("42825d2f-963d-46ee-a374-15900646f0c8"), new Guid("6d84598a-8355-4cfb-a6cd-bcfed109dd6d"), "", "https://lh3.googleusercontent.com/Ziiu3YNdzaoJf7_rdy9tk7pbPiPlluFvA_JdU0FtzqlvZuLrfyuWNnfkRtMvxq4_lA=w720-h310" },
                    { new Guid("3e21e994-519c-47cc-b328-d6e70c05bede"), new Guid("d4cabd56-b6ba-4778-a060-4206daf3665f"), "", "https://lh3.googleusercontent.com/ClxJrJjyrjj5uaAxZvSaQcjjRfeCta4_otNRCsGJacfFptfTtamCUJpQ0hcQWOd8u-Q=w720-h310" },
                    { new Guid("c0b6691e-f685-4a9f-93f0-4991b384d626"), new Guid("d4cabd56-b6ba-4778-a060-4206daf3665f"), "", "https://lh3.googleusercontent.com/JIvkWPFnKbYeVV5h3AxjMgR9ogQ2a0vMQgCp5B3JP4dEXU4zIR40H8ROTg8WkPrjcEA=w720-h310" },
                    { new Guid("2bb53708-9e42-4273-84f3-66c792d57313"), new Guid("d4cabd56-b6ba-4778-a060-4206daf3665f"), "", "https://lh3.googleusercontent.com/d0jf4r7KjWBCzi2GELWFSf6MaJIHepkJIN8JYT8g0tSIThiH_W6FhUnHjBN_fYdl3Q=w720-h310" },
                    { new Guid("979e284e-6d47-4a1f-a59a-aceba10712a1"), new Guid("b00bd132-0843-4beb-a839-fa41a45bec4f"), "", "https://lh3.googleusercontent.com/HteHDUkzuMjCEHM1B-3jvLqlbBYtJZFWiHm-vf47YcE7QiInhXn2O-LkYPxvzPnPGA=w720-h310" },
                    { new Guid("6bbf4d2b-a697-4ffd-8375-65075ce9703c"), new Guid("d4cabd56-b6ba-4778-a060-4206daf3665f"), "", "https://lh3.googleusercontent.com/UbTWxlQujVdxOaYqy_FmC4LRBlm_wSUgQe0wIM0BSXeGUZ0Vzle9OTWNNs4wk8nOKI4=w720-h310" },
                    { new Guid("7d66a8db-8b75-47c8-b391-295414820045"), new Guid("146a2136-f83e-492b-b470-7933bedbfa55"), "", "https://lh3.googleusercontent.com/jCNaOtE_9-Zcs9r5MFtGzaxO8xNz3UYEcB3XdPe1oLO3X6PH-hYEspWnR26lUZef_5A=w720-h310" },
                    { new Guid("b192a826-e716-48a4-ba8d-0e3e1cb38ec4"), new Guid("146a2136-f83e-492b-b470-7933bedbfa55"), "", "https://lh3.googleusercontent.com/d6CY2BSvBXFLK8J3WqJEdDr53_OZ43Aijr43CjG1QKUfHXt4E_zDNBZWoMqkxONzOQ=w720-h310" },
                    { new Guid("39882bb4-09af-42ac-aee8-52043218d93c"), new Guid("146a2136-f83e-492b-b470-7933bedbfa55"), "", "https://lh3.googleusercontent.com/L615QU2G2qxv68di7WqB4V40mDsOgko4iKmz-NB6SzwLejM8x4i2CbAqgkIxBqZ3A9M=w720-h310" },
                    { new Guid("c2d114ee-58bf-4ebb-a9ca-cc43f82bf92d"), new Guid("aede8454-cfa3-427e-b6fa-27370da34299"), "", "https://lh3.googleusercontent.com/9lQV-3IWYXkSndN4GsVQTflvUCSKPMj-uSuH9tEd8FlHuBOslA52Q-Z7wEEKmhwuxJE=w720-h310" },
                    { new Guid("2fbe31d2-101b-4e9b-853b-9a9cee8bf0f0"), new Guid("aede8454-cfa3-427e-b6fa-27370da34299"), "", "https://lh3.googleusercontent.com/3HUpkFFcnCkLbgUosodwIrfzzq3VkebxVQkjfa_uDhapJyrz0ATxq6wRyYpyxKauyg=w720-h310" },
                    { new Guid("ad435762-4a07-41f6-8c9e-19d37403dbce"), new Guid("aede8454-cfa3-427e-b6fa-27370da34299"), "", "https://lh3.googleusercontent.com/JJNpXkj5HNkscW_bmZ1yGu-GuakL4Q4zRwOPmACFaqbIT5C2HMaI4LwhjGNiIrup_Ew4=w720-h310" },
                    { new Guid("2bf7e5a2-9106-4dd2-a94f-3baf06b64c35"), new Guid("aede8454-cfa3-427e-b6fa-27370da34299"), "", "https://lh3.googleusercontent.com/aU5RuCIDy7JzNtp5ib2huaa1t33TVY_zdsES_ooMWSwY6K1JnHG0HC9RK0OgVuXqs9U=w720-h310" },
                    { new Guid("1c1a0b72-a4ef-4023-a9e6-643f8890b207"), new Guid("24608d67-717e-4ce3-9274-c38b7eee7e1b"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("97a02068-99ef-4581-9275-1ee1f54cc6c0"), new Guid("24608d67-717e-4ce3-9274-c38b7eee7e1b"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("b4624391-268d-4fb2-9139-c5647b8702d5"), new Guid("146a2136-f83e-492b-b470-7933bedbfa55"), "", "https://lh3.googleusercontent.com/sCw3rT7aK1z589o_MBBn1JzVd7fYC1-fWkYV2Tz4eDfCDTi49dS9tOFBLqBrd_XwQCc=w720-h310" },
                    { new Guid("ebe82153-b209-43d5-9dad-6321d2e3e9e2"), new Guid("45be5896-5696-48e0-ba07-f7750e244c9b"), "", "https://lh3.googleusercontent.com/xaL3b80wmBVOrpH-q_DX8F5kKsASHH8Fllf3u65TsS0zs9_y0J4DWKJj5T9QVAWuT3Rn=w720-h310" },
                    { new Guid("b92a54c4-d9a4-4287-a4c6-d71700f7b454"), new Guid("ce1bec21-cb5a-45e8-8b2f-2ec64e02db93"), "", "https://lh3.googleusercontent.com/Ibj-Kt-6Pc1IBDVj0yWf1sNjSpdGpRlapbTbjc5MuitmDkoKVMP45GF0LBlg6pnIbYE=w720-h310" },
                    { new Guid("526b4ce6-f212-444f-bb69-406b8b0642cb"), new Guid("ab364f2e-ad15-4157-b1f4-c87754af9a8a"), "", "https://lh3.googleusercontent.com/AinG9y8hyEb_p2B6Rg8-iOVjYR7EcsGDmv_rThdnfzgkBjbukLIT4mWFOg5ObAO4RMq0=w720-h310" },
                    { new Guid("bfca8228-c148-433b-afc0-b5177a399355"), new Guid("39a5e5b2-1438-4f9e-a187-c3f0afc4a593"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("6b7bb1bb-608a-42ee-99f4-2456dffd0599"), new Guid("39a5e5b2-1438-4f9e-a187-c3f0afc4a593"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("037faafb-966e-4524-ba4c-201da46215a4"), new Guid("39a5e5b2-1438-4f9e-a187-c3f0afc4a593"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("f5a8fb0d-5dac-40ad-a5bc-9f3b996d37ea"), new Guid("39a5e5b2-1438-4f9e-a187-c3f0afc4a593"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("7e31b2bc-53e0-4e0c-98d4-bbb13c00baaf"), new Guid("33440e72-9579-4d42-b724-6199c8462193"), "", "https://lh3.googleusercontent.com/UY9fte3alDnv-cZ94Jx27Lf4g9FUT2395jhXPScEllshpdCO4zfnuWrTNtO1FVRt3w=w720-h310" },
                    { new Guid("bea668dd-ba55-43cc-aa2f-80eb8a76fd74"), new Guid("33440e72-9579-4d42-b724-6199c8462193"), "", "https://lh3.googleusercontent.com/-BUT6NCVxZsPPjsUW8zdrVk4XLMRuE_oWSTwaXrAPYZbBsMKBfqXxOVI7OowXxoLwa8=w720-h310" },
                    { new Guid("faa6142b-15c6-4505-b31b-c5ff6a2f2856"), new Guid("33440e72-9579-4d42-b724-6199c8462193"), "", "https://lh3.googleusercontent.com/MwNuIIzmxxJgM8JeNi2aBhpE-kNnXBGOVPRb_gZoRE-gel5q9ZP7mrQfTT_9xzV8dz4=w720-h310" },
                    { new Guid("593afac8-1983-4e51-8f5c-93b8af140c77"), new Guid("45be5896-5696-48e0-ba07-f7750e244c9b"), "", "https://lh3.googleusercontent.com/gFZCgWFd8-oR8zu2ApqRWk6dgwIkDM8jex4MxbA-MdiYgfpHJlkAcPBCZX5czXgddA=w720-h310" },
                    { new Guid("1f9029c8-951f-4d9c-a921-60457bdf1440"), new Guid("33440e72-9579-4d42-b724-6199c8462193"), "", "https://lh3.googleusercontent.com/mfGdhejubeU1m1Pkj2vpWMLTlLMhnQz0f2Z8M79g6g0thY9cDyHggntmd_A7ckZPGVM=w720-h310" },
                    { new Guid("afad89d0-068f-4a63-bded-676be7d486ae"), new Guid("56ec23eb-77ca-4286-a696-f34603803dc6"), "", "https://lh3.ggpht.com/y7On3vVZhFWycuekTPLwARYJ3MwQyODIzKHRt4ofyeS_gmXRDF271NsFDfu_lLhlX2Rj=w720-h310" },
                    { new Guid("a3dc1614-603b-41ee-9e26-6647582ac25b"), new Guid("56ec23eb-77ca-4286-a696-f34603803dc6"), "", "https://lh3.ggpht.com/y7On3vVZhFWycuekTPLwARYJ3MwQyODIzKHRt4ofyeS_gmXRDF271NsFDfu_lLhlX2Rj=w720-h310" },
                    { new Guid("5a2bbb07-8175-4a20-a7f0-5a9898d851dc"), new Guid("56ec23eb-77ca-4286-a696-f34603803dc6"), "", "https://lh3.ggpht.com/y7On3vVZhFWycuekTPLwARYJ3MwQyODIzKHRt4ofyeS_gmXRDF271NsFDfu_lLhlX2Rj=w720-h310" },
                    { new Guid("882e253d-afb2-40e9-88c2-5ecf9415e9c5"), new Guid("dc3ec80c-2563-4e41-8b25-56a5d6a2619a"), "", "https://lh3.googleusercontent.com/h4JQOfS4vmim_WhTHeC3RGxtY8eoFG0fgtgsWWk6VvVSrjnjtlgSFzR6sW0hzbncWA=w720-h310" },
                    { new Guid("4d8059f5-7579-45a3-8106-2a350c0c650d"), new Guid("dc3ec80c-2563-4e41-8b25-56a5d6a2619a"), "", "https://lh3.googleusercontent.com/oMcH_a4lXShvowzyaiQpE0_MhYWZvdN9RkaYLtkdnw_rlDR_uHbHj9Eu2zbrvyOAXHQ=w720-h310" },
                    { new Guid("89c4b9c5-f17b-45e7-97b5-3ddc6c57f7f7"), new Guid("dc3ec80c-2563-4e41-8b25-56a5d6a2619a"), "", "https://lh3.googleusercontent.com/Ia1psbcXgeCV9FBZk1b08QnxC-uSHCgJ112VeJZB19_F2Q-m_w3Z7P_OjFStnYM3LaCC=w720-h310" },
                    { new Guid("129fcda0-ef4b-49f2-9870-cad49833d913"), new Guid("dc3ec80c-2563-4e41-8b25-56a5d6a2619a"), "", "https://lh3.googleusercontent.com/vInYRcyjzVjBFfY4HIGLLf-tSLK9S55HjUbmQuxmrbpVpItV3AfyuxVMFGASoDdMHc4=w720-h310" },
                    { new Guid("d820bd66-8030-4d36-99da-6471fadcda5b"), new Guid("56ec23eb-77ca-4286-a696-f34603803dc6"), "", "https://lh3.ggpht.com/y7On3vVZhFWycuekTPLwARYJ3MwQyODIzKHRt4ofyeS_gmXRDF271NsFDfu_lLhlX2Rj=w720-h310" },
                    { new Guid("46416ba7-8b84-49f7-aad2-f5c97da9d379"), new Guid("10c1dd12-82b9-4544-9839-706301ff1de7"), "", "https://lh3.googleusercontent.com/FMgP9XZNML3lieBG9KDgiJGnT2WlmHMG5lFGcAl0rk93GtGFjf9X2J6vxcCCElNPJDw=w720-h310" },
                    { new Guid("18aebc63-7106-43c4-b053-6810696c8da4"), new Guid("10c1dd12-82b9-4544-9839-706301ff1de7"), "", "https://lh3.googleusercontent.com/DQppPRLU04SzwExhZTIKsYL1y3iZXzRsZbTBrmHJqJO1aTCsApHGdYxTKt3dvkN7ctRb=w720-h310" },
                    { new Guid("65c5e5ae-8537-4d2e-ab40-79c44b431675"), new Guid("10c1dd12-82b9-4544-9839-706301ff1de7"), "", "https://lh3.googleusercontent.com/-oRMqwODzaru2JCxLf3JtHVZXtpYfQ8Qo0IQRbRsZtssH6dUGr51WMfH0j3eMrfO5w=w720-h310" },
                    { new Guid("1857272b-2cba-4468-81a0-27a5419ce77a"), new Guid("ce1bec21-cb5a-45e8-8b2f-2ec64e02db93"), "", "https://lh3.googleusercontent.com/W_3i_ZHnSjan-N8egYQy9sQw87CppDDda9ITzTIQyTFHZpO2VJlhCzP_BORM3Hd-CDw=w720-h310" },
                    { new Guid("c98fc0d8-0443-43c4-8c17-511dc1ae8474"), new Guid("ce1bec21-cb5a-45e8-8b2f-2ec64e02db93"), "", "https://lh3.googleusercontent.com/RhBTJ2IEOhtPEbOpmMTxfMC9iU06JihtylD-lQxbTrIPfT2U-B0YLAjGELbj2Ppk1w8=w720-h310" },
                    { new Guid("32323907-1fce-452a-b577-296d794daac5"), new Guid("ce1bec21-cb5a-45e8-8b2f-2ec64e02db93"), "", "https://lh3.googleusercontent.com/nlXezemMS359X8dy6MxUJMgumyw6abz15NX0CjtnT8V57vni_uuS3saDllIMeyfQ6e-6=w720-h310" },
                    { new Guid("41d50d71-324b-4ade-93be-920e35ae7672"), new Guid("3fc49719-0bcf-4ffb-97e7-743350da0f64"), "", "https://lh3.googleusercontent.com/aosNkyZihAba_VF_HRKOUMGFuK5SxNcZMMvYIAXufiG8znXvrxJ_7jMgmP2E01CapoQ=w720-h310" },
                    { new Guid("1a4797ae-01cd-403a-a0a2-8b8d1c8bb294"), new Guid("10c1dd12-82b9-4544-9839-706301ff1de7"), "", "https://lh3.googleusercontent.com/wzk-BPRwz5Lrh2YZ66uEJb8JjXkFE8oVm4RpZVTmWsCcx1e1nxP3XBhqr2q9Iff7Xica=w720-h310" },
                    { new Guid("2e771417-c1bd-4d38-bd5b-e16ece2de26c"), new Guid("3fc49719-0bcf-4ffb-97e7-743350da0f64"), "", "https://lh3.googleusercontent.com/Km7Il6ij6xZBtWJPSpEacmz8dC2C9WACUuf37VdjIYaXWaPaC6WWWmx3T8aaNgNkJaBx=w720-h310" },
                    { new Guid("dd6b6a66-ab5d-4c63-a39e-bd98a20d03df"), new Guid("3fc49719-0bcf-4ffb-97e7-743350da0f64"), "", "https://lh3.googleusercontent.com/tk_p7dIHQBEBeYiVkFaPcU_5bd3fOhE8HerKp4Ei0cTyxVoVDdd_QD0SLPJeJrSm4c4=w720-h310" },
                    { new Guid("596e359a-a160-4cab-b91c-5395ac5e89ef"), new Guid("3fc49719-0bcf-4ffb-97e7-743350da0f64"), "", "https://lh3.googleusercontent.com/Zsth8maheotaUA0he3vGtWmm11dWsEsLlffOsvzGX65Sp4nXNAuKSx-Z96f8as3twQ4=w720-h310" },
                    { new Guid("fe00692d-ed6c-43af-889f-13bd40642611"), new Guid("306a343f-1f8e-4117-8ce2-20be792495f3"), "", "https://lh3.ggpht.com/GqnDETqoUP17xJg0cQ3pyEHsgO-KLjx-MbJ0Mcwg4Lvd2PnEO-JARZhYtfd8AYwjEew=w720-h310" },
                    { new Guid("04cdb46c-d1d2-4c67-b644-73651846d9e2"), new Guid("306a343f-1f8e-4117-8ce2-20be792495f3"), "", "https://lh3.ggpht.com/Vbi7XVMzoCMoAyHFhJlziKjldN5F-Mkp4EOf5YyiMOPsd-of4ckac2BzPAiKGIveSI4=w720-h310" },
                    { new Guid("5c6d2801-b2bc-40c7-b40f-90938d90ab49"), new Guid("306a343f-1f8e-4117-8ce2-20be792495f3"), "", "https://lh3.ggpht.com/AZ2OkTlsJuqUvCP8IQKwkCg7Fv56FRAb_CV8bXRsR15Ayre8fmWJrkr4RCIvx1wYoktm=w720-h310" },
                    { new Guid("23eee84f-c971-4196-95b6-5f779dd20567"), new Guid("306a343f-1f8e-4117-8ce2-20be792495f3"), "", "https://lh3.ggpht.com/WRg7Mzp5FM-cSiKGb7TbzgeYBY8oMSV4Vgn35XYHDbejbNkWM7lNgqFeQjMlNAZoUX7Z=w720-h310" },
                    { new Guid("71119a47-3fef-435e-a325-584f806224ed"), new Guid("ab364f2e-ad15-4157-b1f4-c87754af9a8a"), "", "https://lh3.googleusercontent.com/WJIWdX6YPms3-diI1TPcCPtgv_YGH2QNMGqOXLK-ta5FLulrZps4KObsB1-frjU6syA=w720-h310" }
                });

            migrationBuilder.InsertData(
                table: "UserGames",
                columns: new[] { "UserId", "GameId", "PurchaseDate" },
                values: new object[,]
                {
                    { new Guid("02a2f635-d049-44c4-9564-477e0aad0630"), new Guid("33440e72-9579-4d42-b724-6199c8462193"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3d98220d-387b-4c64-ae62-197dd41657bc"), new Guid("306a343f-1f8e-4117-8ce2-20be792495f3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("84c9c1de-a029-456a-bf21-193301846a94"), new Guid("3fc49719-0bcf-4ffb-97e7-743350da0f64"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3524b7f0-4024-40c0-a2b6-f826c6bed071"), new Guid("dc3ec80c-2563-4e41-8b25-56a5d6a2619a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6594f0fa-dbe1-4dc7-a57f-35d736316e99"), new Guid("45be5896-5696-48e0-ba07-f7750e244c9b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "WishGame",
                columns: new[] { "UserId", "GameId" },
                values: new object[,]
                {
                    { new Guid("02a2f635-d049-44c4-9564-477e0aad0630"), new Guid("33440e72-9579-4d42-b724-6199c8462193") },
                    { new Guid("84c9c1de-a029-456a-bf21-193301846a94"), new Guid("3fc49719-0bcf-4ffb-97e7-743350da0f64") },
                    { new Guid("3524b7f0-4024-40c0-a2b6-f826c6bed071"), new Guid("dc3ec80c-2563-4e41-8b25-56a5d6a2619a") },
                    { new Guid("6594f0fa-dbe1-4dc7-a57f-35d736316e99"), new Guid("45be5896-5696-48e0-ba07-f7750e244c9b") },
                    { new Guid("3d98220d-387b-4c64-ae62-197dd41657bc"), new Guid("306a343f-1f8e-4117-8ce2-20be792495f3") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("306a343f-1f8e-4117-8ce2-20be792495f3"), new Guid("b4e09509-be8c-4b58-97c7-eb54f44c11c1") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("33440e72-9579-4d42-b724-6199c8462193"), new Guid("87c0f2be-9fda-4f32-98b6-a23ea3974cc3") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("3fc49719-0bcf-4ffb-97e7-743350da0f64"), new Guid("0892341c-66bf-431a-a982-d5e84b545d03") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("45be5896-5696-48e0-ba07-f7750e244c9b"), new Guid("359d5185-401f-4b78-bab6-31899c5e6e82") });

            migrationBuilder.DeleteData(
                table: "CategoryGames",
                keyColumns: new[] { "GameId", "CategoryId" },
                keyValues: new object[] { new Guid("dc3ec80c-2563-4e41-8b25-56a5d6a2619a"), new Guid("9ef4566a-0817-4cb9-b325-d3ed4347e794") });

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("3a893150-8db6-40a5-8f7e-70438cad992a"));

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("5803a231-953b-4377-9bf3-27e60f407f4a"));

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("60455195-5f87-4596-a131-ea9f3172ff36"));

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("b5f3b1a5-deb1-44a8-9045-f2b896f979fd"));

            migrationBuilder.DeleteData(
                table: "FreeCodes",
                keyColumn: "Id",
                keyValue: new Guid("ef69bebf-7962-44a4-83a4-4bb9036da2ec"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("037faafb-966e-4524-ba4c-201da46215a4"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("04cdb46c-d1d2-4c67-b644-73651846d9e2"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("068984c3-a2a9-4e1b-9d34-a78c48b0274b"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("07cf2fbd-8c92-4297-9611-9890e0bd475a"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("129fcda0-ef4b-49f2-9870-cad49833d913"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("1857272b-2cba-4468-81a0-27a5419ce77a"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("18aebc63-7106-43c4-b053-6810696c8da4"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("1a4797ae-01cd-403a-a0a2-8b8d1c8bb294"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("1c1a0b72-a4ef-4023-a9e6-643f8890b207"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("1f9029c8-951f-4d9c-a921-60457bdf1440"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("22e1c049-fcb8-4af7-9360-3534e8e8349b"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("23eee84f-c971-4196-95b6-5f779dd20567"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("248a56ca-c86f-43d9-816f-ee7c91f361ce"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("2bb53708-9e42-4273-84f3-66c792d57313"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("2bf7e5a2-9106-4dd2-a94f-3baf06b64c35"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("2e771417-c1bd-4d38-bd5b-e16ece2de26c"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("2fbe31d2-101b-4e9b-853b-9a9cee8bf0f0"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("32323907-1fce-452a-b577-296d794daac5"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("37cf6590-17cc-49d6-a772-ff60a24dbccc"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("39882bb4-09af-42ac-aee8-52043218d93c"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("3ad154ec-3491-46d6-8772-555bb2a44e88"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("3e21e994-519c-47cc-b328-d6e70c05bede"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("41d50d71-324b-4ade-93be-920e35ae7672"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("42825d2f-963d-46ee-a374-15900646f0c8"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("46416ba7-8b84-49f7-aad2-f5c97da9d379"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("4d8059f5-7579-45a3-8106-2a350c0c650d"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("526b4ce6-f212-444f-bb69-406b8b0642cb"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("52abf201-82ef-421d-b209-3618a26f00b1"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("593afac8-1983-4e51-8f5c-93b8af140c77"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("596e359a-a160-4cab-b91c-5395ac5e89ef"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("5a2bbb07-8175-4a20-a7f0-5a9898d851dc"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("5c6d2801-b2bc-40c7-b40f-90938d90ab49"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("62276856-e096-4f0c-ab83-2e2ae712aa11"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("65c5e5ae-8537-4d2e-ab40-79c44b431675"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("672a5d88-de66-4666-a80d-7ad666b0d23e"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("6b7bb1bb-608a-42ee-99f4-2456dffd0599"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("6bbf4d2b-a697-4ffd-8375-65075ce9703c"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("71119a47-3fef-435e-a325-584f806224ed"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("7644c761-92da-489c-90ba-39f19359b0cc"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("7cf651de-d70d-4d4f-a4b9-7c87afac3ef8"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("7d66a8db-8b75-47c8-b391-295414820045"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("7e31b2bc-53e0-4e0c-98d4-bbb13c00baaf"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("7e466b50-fd2c-430c-b914-b508da5b14d6"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("882e253d-afb2-40e9-88c2-5ecf9415e9c5"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("89c4b9c5-f17b-45e7-97b5-3ddc6c57f7f7"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("89f90832-a380-4d44-a31d-54c94b0fff3a"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("948c3038-39f2-4a71-a4ac-4c6abe7123f7"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("979e284e-6d47-4a1f-a59a-aceba10712a1"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("97a02068-99ef-4581-9275-1ee1f54cc6c0"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("a3dc1614-603b-41ee-9e26-6647582ac25b"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("aa648f12-3f55-4800-bc93-047acaf452dd"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("ad435762-4a07-41f6-8c9e-19d37403dbce"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("afad89d0-068f-4a63-bded-676be7d486ae"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("b192a826-e716-48a4-ba8d-0e3e1cb38ec4"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("b4624391-268d-4fb2-9139-c5647b8702d5"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("b92a54c4-d9a4-4287-a4c6-d71700f7b454"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("ba990448-02e4-4a49-8b13-087d02ba9245"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("bea668dd-ba55-43cc-aa2f-80eb8a76fd74"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("bfca8228-c148-433b-afc0-b5177a399355"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("c0b6691e-f685-4a9f-93f0-4991b384d626"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("c2d114ee-58bf-4ebb-a9ca-cc43f82bf92d"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("c98fc0d8-0443-43c4-8c17-511dc1ae8474"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("d63fad2d-45af-4b66-8a94-0e783a091272"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("d6432d85-669a-4371-aa4a-d400494ca308"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("d714a3e6-0e37-41e3-949a-37f63d8d137e"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("d820bd66-8030-4d36-99da-6471fadcda5b"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("daa2e3da-f87d-40fe-8131-b04f322a310c"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("daeb6b4b-1d7e-45cb-9c45-1d509aeb496a"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("dd6b6a66-ab5d-4c63-a39e-bd98a20d03df"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("dfa7fd22-974c-4f34-9243-459f1113158f"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("e6ab0c2f-24d1-463b-b3de-a2c137ce33c9"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("eb9299ce-6b72-4f43-9d79-07c44ecb3f09"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("ebe82153-b209-43d5-9dad-6321d2e3e9e2"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("f5a8fb0d-5dac-40ad-a5bc-9f3b996d37ea"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("faa6142b-15c6-4505-b31b-c5ff6a2f2856"));

            migrationBuilder.DeleteData(
                table: "ImageGames",
                keyColumn: "Id",
                keyValue: new Guid("fe00692d-ed6c-43af-889f-13bd40642611"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("2bc4efee-b271-4bc2-82f9-99e0ec5de892"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("4d4a5b74-c885-407c-917f-cf048867fea8"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("4d9ba321-d4af-489d-9cc5-cec711bd7116"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("7f8a2c0f-779b-4b93-82cc-85b9dc22cfcd"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("8aec7e6e-510e-4277-a74c-02fb86f86257"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("8c865392-6891-4455-9b8d-89c69617ed49"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("a4a5e16a-86a8-424e-937c-b8cadfbb79a3"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("b6a14b45-d41b-418b-ace1-f4c433ab29c9"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("c1742d14-5165-4da7-954a-7c83de32ff09"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("eb5d09e2-5fd7-4c86-9d70-e557b595fd6b"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("f1d97351-09a6-41a9-baed-e02148556aeb"));

            migrationBuilder.DeleteData(
                table: "ImagePublishers",
                keyColumn: "Id",
                keyValue: new Guid("fc660cf9-046a-4ce0-8c39-31ae0bf21196"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("7028deff-1023-4943-ab10-8d35ff59f006"), "Admin" });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("be6ab956-8893-4c73-801a-b11bf852febf"), "User" });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("02a2f635-d049-44c4-9564-477e0aad0630"), new Guid("33440e72-9579-4d42-b724-6199c8462193") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("3524b7f0-4024-40c0-a2b6-f826c6bed071"), new Guid("dc3ec80c-2563-4e41-8b25-56a5d6a2619a") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("3d98220d-387b-4c64-ae62-197dd41657bc"), new Guid("306a343f-1f8e-4117-8ce2-20be792495f3") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("6594f0fa-dbe1-4dc7-a57f-35d736316e99"), new Guid("45be5896-5696-48e0-ba07-f7750e244c9b") });

            migrationBuilder.DeleteData(
                table: "UserGames",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("84c9c1de-a029-456a-bf21-193301846a94"), new Guid("3fc49719-0bcf-4ffb-97e7-743350da0f64") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("02a2f635-d049-44c4-9564-477e0aad0630"), new Guid("33440e72-9579-4d42-b724-6199c8462193") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("3524b7f0-4024-40c0-a2b6-f826c6bed071"), new Guid("dc3ec80c-2563-4e41-8b25-56a5d6a2619a") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("3d98220d-387b-4c64-ae62-197dd41657bc"), new Guid("306a343f-1f8e-4117-8ce2-20be792495f3") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("6594f0fa-dbe1-4dc7-a57f-35d736316e99"), new Guid("45be5896-5696-48e0-ba07-f7750e244c9b") });

            migrationBuilder.DeleteData(
                table: "WishGame",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { new Guid("84c9c1de-a029-456a-bf21-193301846a94"), new Guid("3fc49719-0bcf-4ffb-97e7-743350da0f64") });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0892341c-66bf-431a-a982-d5e84b545d03"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("359d5185-401f-4b78-bab6-31899c5e6e82"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87c0f2be-9fda-4f32-98b6-a23ea3974cc3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9ef4566a-0817-4cb9-b325-d3ed4347e794"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b4e09509-be8c-4b58-97c7-eb54f44c11c1"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("10c1dd12-82b9-4544-9839-706301ff1de7"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("146a2136-f83e-492b-b470-7933bedbfa55"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("203cc275-e374-4a64-acd2-d43cc8352b5c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("24608d67-717e-4ce3-9274-c38b7eee7e1b"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("306a343f-1f8e-4117-8ce2-20be792495f3"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("33440e72-9579-4d42-b724-6199c8462193"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("39a5e5b2-1438-4f9e-a187-c3f0afc4a593"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3fc49719-0bcf-4ffb-97e7-743350da0f64"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("45be5896-5696-48e0-ba07-f7750e244c9b"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("56ec23eb-77ca-4286-a696-f34603803dc6"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6d84598a-8355-4cfb-a6cd-bcfed109dd6d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a755dac5-992f-4ce5-b94c-f7a20d9357f6"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ab364f2e-ad15-4157-b1f4-c87754af9a8a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("aede8454-cfa3-427e-b6fa-27370da34299"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b00bd132-0843-4beb-a839-fa41a45bec4f"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b12b384c-188d-4cce-bccc-e9d2b4e1869c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ce1bec21-cb5a-45e8-8b2f-2ec64e02db93"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d4cabd56-b6ba-4778-a060-4206daf3665f"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("dc3ec80c-2563-4e41-8b25-56a5d6a2619a"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("080db791-6652-4e65-aa7a-7fce8f0c359e"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("0e73cf7a-7231-4f12-93b6-c87f9089a894"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("fcc86f57-587d-4e35-b0cd-cd94e057a6b4"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("02a2f635-d049-44c4-9564-477e0aad0630"), "8ca82bb1-a978-441a-9869-0b470d9c58c3" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("3524b7f0-4024-40c0-a2b6-f826c6bed071"), "1171f7f7-f7be-477d-9b7e-d3290e3ffaeb" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("3d98220d-387b-4c64-ae62-197dd41657bc"), "76edfe44-b400-47cf-b5fb-67f3dce2b966" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("6594f0fa-dbe1-4dc7-a57f-35d736316e99"), "0e372e8d-4a80-4e28-9dfa-ccb7edb5177b" });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("84c9c1de-a029-456a-bf21-193301846a94"), "2ab41f20-d5f1-4515-9b74-ee6b061039ef" });

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("05f9247c-140e-4f56-909e-7eb7c645e3c8"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("29cabc93-41f2-47a1-8ab6-41c5588a2137"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65c41248-d194-457e-83c2-d8b546281ae5"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("86b7600a-724e-4aef-bb46-e3715e442704"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("8c71ea7a-6904-4a3c-895e-4d23988fe24f"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("a1d92e4f-644f-481e-a5bb-de0aff808a41"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("a2eb0c3c-a27d-40b2-9ad4-08a1d59eedb3"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("a67d3c43-5dd3-4d59-981a-8efa4c6c7a0e"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("fa2a0115-b0da-4cba-8e84-c911705b19c8"));

            migrationBuilder.DropColumn(
                name: "sale",
                table: "Games");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("e6be55d3-df3b-497e-a066-d2accbbaef2e"), "FPS" },
                    { new Guid("05bb4066-33fb-45fb-8e83-c6dcfd147ae3"), "Action" },
                    { new Guid("0a16e661-1a8d-40d8-8d16-e6834e7d810b"), "Adventure" },
                    { new Guid("6cd8e859-cbae-46e1-a584-ae443996a199"), "Puzzle" },
                    { new Guid("83808d70-3dd0-4b9f-a91d-2f9c93c8bf3e"), "Open world" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Money", "Name", "Reliability" },
                values: new object[,]
                {
                    { new Guid("af9d9533-ff1c-4f01-bac7-21bb443a8dbd"), 0f, "King", 0 },
                    { new Guid("529dcff9-cbae-449f-8e24-f2c99a830a3c"), 0f, "Rovio Entertainment Corporation", 0 },
                    { new Guid("2211448e-4b82-4aaf-aac6-17eae0ce5bea"), 0f, "Outfit7 Limited", 0 },
                    { new Guid("51517093-aa4d-4cf1-a7ac-37a8b2d3eba1"), 0f, "AMANOTES", 0 },
                    { new Guid("7590e48f-fc84-4625-8590-7c3fd0c450b9"), 0f, "Gameloft", 0 },
                    { new Guid("0ac34e93-611c-4518-8396-5f1a82b22d6d"), 0f, "Mobigame S.A.R.L.", 0 },
                    { new Guid("074ec8ce-c16e-477a-b75b-34b52ae8087a"), 0f, "Imangi Studios", 0 },
                    { new Guid("c24e6e15-535d-4b7a-b6aa-d004f524896a"), 0f, "NEKKI", 0 },
                    { new Guid("3ba59319-5efe-4990-bf08-b67180368582"), 0f, "Kiloo", 0 },
                    { new Guid("2c232b87-86ef-4e25-92e5-d3d3092626ec"), 0f, "ZeptoLab", 0 },
                    { new Guid("6f76d72b-0e80-4bb5-b740-5db4282b83ce"), 0f, "ELECTRONIC ARTS", 0 },
                    { new Guid("f572bc41-0731-456f-af74-29b2ab39981c"), 0f, "J-PARK", 0 }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("837729a4-d96b-4f84-ba94-65e1dc45ff32"), "User", "Limited Permission", "User", "User" },
                    { new Guid("d79a42b6-6f4c-470d-95af-80f92519ea0a"), "Admin", "Full Permission", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Hobbies", "LockoutEnabled", "LockoutEnd", "Money", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("92417557-ceac-4229-bd39-013b65cc0fbd"), 0, "263879f7-1f28-4b7d-8dfa-a7f74e2fe3ae", "duykkxm92@gmail.com", false, "Nguyen Ngoc Duy", "Hobbies", false, null, 0f, null, null, "duykkxm92", "01638789455", false, null, false, "duykkxm92" },
                    { new Guid("bcfdfd0f-ddd6-4533-8f10-54f11a89cdba"), 0, "83bab6ab-d1a9-42c0-be13-aa35906d20e6", "Email1@gmail.com", false, "Full Name", "Hobbies", false, null, 0f, null, null, "Thatvuhai_7595", "93098509228098523", false, null, false, "UserName1" },
                    { new Guid("d18587d8-66b5-4aa7-8f92-db5ed036697d"), 0, "d0468431-28a1-49e7-90af-f088afc0a512", "Email2@gmail.com", false, "Full Name", "Hobbies", false, null, 0f, null, null, "Thatvuhai_7595", "93098559238098523", false, null, false, "UserName2" },
                    { new Guid("eb7d9d2d-107b-4730-a2a3-0acc61fde5e9"), 0, "5ba03cb7-0097-4fb6-a118-633fd0d31146", "Email3@gmail.com", false, "Full Name", "Hobbies", false, null, 0f, null, null, "Thatvuhai_7595", "93098609238098523", false, null, false, "UserName3" },
                    { new Guid("9025855a-8baf-482f-80dc-852a0a8f22b7"), 0, "bc90b5c5-2148-4f8c-82c9-4daf30a596f4", "Email4@gmail.com", false, "Full Name", "Hobbies", false, null, 0f, null, null, "Thatvuhai_7595", "93098509738098523", false, null, false, "UserName4" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Content", "Name", "Price", "PublisherId", "Rating", "ReleaseDate", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("cafa1ca6-0429-4e93-b3ec-5bea71f7dbdc"), "DASH as fast as you can! DODGE the oncoming trains!Help Jake, Tricky & Fresh escape from the grumpy Inspector and his dog.  Grind trains with your cool crew!  Colorful and vivid HD graphics!  Hoverboard Surfing!  Paint powered jetpack!  Lightning fast swipe acrobatics!  Challenge and help your friends!", "Subway Surfers", 0f, new Guid("3ba59319-5efe-4990-bf08-b67180368582"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("b55a1ae3-5e06-416f-8532-8406201f45fc"), "The sequel to the famous Facebook smash hit with 40 million users Shadow Fight 2 is a nail-biting mix of RPG and classical Fighting. This game lets you equip your character with countless lethal weapons and rare armor sets, and features dozens of lifelike-animated Martial Arts techniques! Crush your enemies, humiliate demon bosses, and be the one to close the Gate of Shadows. Do you have what it takes to kick, punch, jump, and slash your way to victory? There’s only one way to find out", "Shadow Fight 2", 100000f, new Guid("c24e6e15-535d-4b7a-b6aa-d004f524896a"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("b2915638-a97b-4305-a377-2c717866a24b"), "Strap on your running shoes and join the award-winning, fan-favorite runner, Minion Rush. Enter Gru's Lair, discover its many mysterious rooms, and take on manic missions around the world. Along the way, your Minions will jump, roll and dodge obstacles while unlocking a collection of cool Minion costumes.", "Minion Rush: Despicable Me Official Game", 100000f, new Guid("529dcff9-cbae-449f-8e24-f2c99a830a3c"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("acd32c9e-26ff-403b-9199-cb5d9b1b71a1"), "Use the unique powers of the Angry Birds to destroy the greedy pigs' defenses! The survival of the Angry Birds is at stake. Dish out revenge on the greedy pigs who stole their eggs. Use the unique powers of each bird to destroy the pigs’ defenses. Angry Birds features challenging physics-based gameplay and hours of replay value. Each level requires logic, skill and force to solve.", "Angry Birds Classic", 100000f, new Guid("529dcff9-cbae-449f-8e24-f2c99a830a3c"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("b9d7a713-1d9b-474c-b605-5948c7598727"), "Is it a baby? Is it a puppy? No! It’s Talking Tom! The cutest kitten, the coolest cat, and the biggest superstar in the world! My Talking Tom is the best virtual pet game for children, and big kids of all ages.That’s right - even grandma and grandpa can join the fun!", "My Talking Tom", 100000f, new Guid("2211448e-4b82-4aaf-aac6-17eae0ce5bea"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("196e363c-ffa1-47bb-a701-3ba50c203287"), "Dragon Mania Legends is for anyone that wants their very own pet dragon, which is obviously everyone… – Gamezebo", "Dragon Mania Legends", 100000f, new Guid("51517093-aa4d-4cf1-a7ac-37a8b2d3eba1"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("e14552de-2b28-4332-8181-70617811f804"), "Play the award-winning hit action-strategy adventure where you meet, greet, and defeat legions of hilarious zombies from the dawn of time, to the end of days. Amass an army of amazing plants, supercharge them with Plant Food, and devise the ultimate plan to protect your brain.", "Plants vs Zombies 2 Free", 0f, new Guid("51517093-aa4d-4cf1-a7ac-37a8b2d3eba1"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("4eec3fd2-d6f2-4b61-97ca-39cac256bed4"), "Magic Tiles 3 ™ is one of the most loved piano games among thousands of free games in 2018 which has more than 80 million players around the world.", "Magic Tiles 3", 100000f, new Guid("51517093-aa4d-4cf1-a7ac-37a8b2d3eba1"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("143203a7-69c1-4a75-b04f-4b56c3cafde2"), "Follow the adventure of Om Nom in the first part of the legendary Cut the Rope logic puzzles series. Get it now for free and start playing with millions of players around the world!", "Cut the Rope FULL FREE", 0f, new Guid("af9d9533-ff1c-4f01-bac7-21bb443a8dbd"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("621dfe75-6e9c-4264-a72d-330533e29d49"), "A strange group of enemies appeared in the city and have been using innocent people as experimental tools. Lots of people have turned into Zombie so that Hero and his friends should save the people and remove the enemies.", "Anger of stick 5 : zombie", 100000f, new Guid("af9d9533-ff1c-4f01-bac7-21bb443a8dbd"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("b2cdff6e-c70d-4aa5-8f69-f0524f8e1662"), "Start playing Candy Crush Saga today – loved by millions of players around the world. With over a trillion levels played, this sweet match 3 puzzle game is one of the most popular mobile games of all time!", "Candy Crush Saga", 100000f, new Guid("af9d9533-ff1c-4f01-bac7-21bb443a8dbd"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("b93a3a8e-1db8-4221-80a4-79336b613c59"), "The time to take action and strike back is now! We’re calling for the best sniper in the world to take aim at evil, wherever it hides.There’s no room for remorse, so shoot to kill…", "Sniper Fury: Top shooting game - FPS", 100000f, new Guid("af9d9533-ff1c-4f01-bac7-21bb443a8dbd"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("c31974c6-8bdb-4984-b881-cceec254d18a"), "5 lớp nhân vật tùy biến có thể lên cấp cả trong chơi đơn lẫn chơi mạng. Kiếm và dùng Điểm Kĩ năng để kích hoạt kĩ năng riêng của từng lớp nhân vật. Đấu Đội trong các trận Chơi mạng. Bảng xếp hạng Cá nhân và Đội. Nói chuyện với người chơi khác trong mục Chat Toàn cầu và Đội. Nhiệm vụ tiết tấu nhanh với nhiều thử thách khác nhau từ Tokyo đến Venice.", "Modern Combat 5: eSports FPS", 100000f, new Guid("6f76d72b-0e80-4bb5-b740-5db4282b83ce"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("e291a33f-3938-4079-8a6c-853efac83147"), "Help Swampy by guiding water to his broken shower. Each level is a challenging physics-based puzzle with amazing life-like mechanics. Cut through dirt and guide fresh water, dirty water, toxic water, steam, and ooze through increasingly challenging scenarios! Every drop count", "Where's My Water? Free", 0f, new Guid("3ba59319-5efe-4990-bf08-b67180368582"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("2a0ffe9e-d7f3-407c-8203-ccd18f2c3411"), "The zombies are revolting ! Attack the city with a horde of zombies, change pedestrians into zombies and create the largest horde. Eat your friends, and challenge them to a crazy race by destroying everything in your path. Zombie Tsunami has proudly exceeded 200 million players around the world.", "Zombie Tsunami", 100000f, new Guid("0ac34e93-611c-4518-8396-5f1a82b22d6d"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("c1fc2ff2-0562-4f41-a543-c8488a799dc0"), "N.O.V.A. Legacy brings you the best 3D sci-fi FPS experience based on the epic first episode of N.O.V.A., which received critical acclaim -- all in a compact version of the shooter. Kal Wardin, our hero, is a veteran N.O.V.A. marine, summoned once again to don his Mobile Armored Suit and strike against the enemies of the Colonial Administration forces. Helped by Yelena, his personal AI Agent, Kal must protect humanity's destiny by engaging in combat against alien invaders while uncovering the mystery behind their sudden assault.", "N.O.V.A. Legacy", 100000f, new Guid("0ac34e93-611c-4518-8396-5f1a82b22d6d"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("6d207d13-0cbb-469b-96b8-5342e68cad5e"), "With over a zillion downloads, Temple Run redefined mobile gaming. Now get more of the exhilarating running, jumping, turning and sliding you love in Temple Run 2! Navigate perilous cliffs, zip lines, mines and forests as you try to escape with the cursed idol. How far can you run ? !", "Temple Run 2", 50000f, new Guid("074ec8ce-c16e-477a-b75b-34b52ae8087a"), 4.3f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("0103fa55-1bec-464c-9121-375d953c58af"), "In Asphalt 8, you’ll race in some of the hottest, most high-performance dream machines ever created, from cars to bikes, as you take them on a global tour of speed. From the blazing Nevada Desert to the tight turns of Tokyo, you’ll find a world of challenge, excitement and arcade fun on your road to the top!", "Asphalt 8: Airborne", 100000f, new Guid("0ac34e93-611c-4518-8396-5f1a82b22d6d"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" },
                    { new Guid("f4ef0ad1-e1d4-4513-8754-84a3cb78bef1"), "Get ready to soil your plants as a mob of fun-loving zombies is about to invade your home. Use your arsenal of 49 zombie-zapping plants — peashooters, wall-nuts, cherry bombs and more — to mulchify 26 types of zombies before they break down your door.", "Plants vs. Zombies FREE", 100000f, new Guid("6f76d72b-0e80-4bb5-b740-5db4282b83ce"), 4.5f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "URL Video here" }
                });

            migrationBuilder.InsertData(
                table: "ImagePublishers",
                columns: new[] { "Id", "PublisherId", "UrlLocal", "UrlOnline" },
                values: new object[,]
                {
                    { new Guid("7dcf281d-4013-40f6-a84f-85828536c779"), new Guid("0ac34e93-611c-4518-8396-5f1a82b22d6d"), null, "http://4.bp.blogspot.com/-jAUhK8EAuiA/VmnLpfRWLHI/AAAAAAAAAkI/Hp8mTQXl8xM/s1600/Zombie%2BTsunami%2B-%2BLogo%2BMobigame.jpg" },
                    { new Guid("81102236-9bc8-4672-a451-47241320471f"), new Guid("7590e48f-fc84-4625-8590-7c3fd0c450b9"), null, "https://pbs.twimg.com/profile_images/1026435341312512001/u3D328AP_400x400.jpg" },
                    { new Guid("05ae0ff7-2369-4620-a43d-01c3b9a1ed13"), new Guid("51517093-aa4d-4cf1-a7ac-37a8b2d3eba1"), null, "https://employer.jobsgo.vn/image.php?src=1187_logo_1187_20170209115933_1779.jpg&w=300&h=300" },
                    { new Guid("387b241a-6d51-4dfe-81f7-db6630cf1268"), new Guid("6f76d72b-0e80-4bb5-b740-5db4282b83ce"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRbShsNR-wcUaPKBv2NxLSeE6arTMAMGZNs5L219VYdIxUapVJc" },
                    { new Guid("aeb244a4-0eb5-459d-a528-34f293a52fec"), new Guid("2211448e-4b82-4aaf-aac6-17eae0ce5bea"), null, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/O7_logo-red_cmyk.jpg/1200px-O7_logo-red_cmyk.jpg" },
                    { new Guid("ee9b09d6-abb4-406d-96df-173e79bafdc1"), new Guid("074ec8ce-c16e-477a-b75b-34b52ae8087a"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS3aHsnIsbz6CxKRg5tmpq73iNWV6J65niLvsEs9tKf9feje5iv" },
                    { new Guid("8ee5076e-fba3-4b7a-8a16-85d55cb61c57"), new Guid("3ba59319-5efe-4990-bf08-b67180368582"), null, "https://www.kiloo.com/wp-content/uploads/2017/03/sharelogo-2.png" },
                    { new Guid("a59f2ed2-5a40-4d9a-8368-6a253e173532"), new Guid("529dcff9-cbae-449f-8e24-f2c99a830a3c"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdbIPf6EeERMGnyQoYkE4xUMuaU22OEtWLEfHWjAw6vxzGJ5oq" },
                    { new Guid("9789619a-da39-4202-9c50-15b016b4f5df"), new Guid("c24e6e15-535d-4b7a-b6aa-d004f524896a"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQkyOmWOFhXD1lRsMIHkAJrLIvjwmImH1GBwlmqb3I5ysGUNY0-" },
                    { new Guid("47a33a6c-1b32-4394-b341-c1c576d02269"), new Guid("f572bc41-0731-456f-af74-29b2ab39981c"), null, "https://upload.wikimedia.org/wikipedia/vi/thumb/2/2a/ZeptoLab.png/200px-ZeptoLab.png" },
                    { new Guid("08ffec37-e19a-4704-8941-1544978dbdca"), new Guid("af9d9533-ff1c-4f01-bac7-21bb443a8dbd"), null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSE0L-3DI9ruta232UcPOIlvnE3I3xV-8l1u_C3Grzx6tmXrDzs" },
                    { new Guid("abb815d5-0261-420a-ae44-1cbbad1cc11b"), new Guid("2c232b87-86ef-4e25-92e5-d3d3092626ec"), null, "https://upload.wikimedia.org/wikipedia/vi/thumb/2/2a/ZeptoLab.png/200px-ZeptoLab.png" }
                });

            migrationBuilder.InsertData(
                table: "CategoryGames",
                columns: new[] { "GameId", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("cafa1ca6-0429-4e93-b3ec-5bea71f7dbdc"), new Guid("e6be55d3-df3b-497e-a066-d2accbbaef2e") },
                    { new Guid("6d207d13-0cbb-469b-96b8-5342e68cad5e"), new Guid("0a16e661-1a8d-40d8-8d16-e6834e7d810b") },
                    { new Guid("b2cdff6e-c70d-4aa5-8f69-f0524f8e1662"), new Guid("83808d70-3dd0-4b9f-a91d-2f9c93c8bf3e") },
                    { new Guid("f4ef0ad1-e1d4-4513-8754-84a3cb78bef1"), new Guid("6cd8e859-cbae-46e1-a584-ae443996a199") },
                    { new Guid("2a0ffe9e-d7f3-407c-8203-ccd18f2c3411"), new Guid("05bb4066-33fb-45fb-8e83-c6dcfd147ae3") }
                });

            migrationBuilder.InsertData(
                table: "FreeCodes",
                columns: new[] { "Id", "Code", "GameId" },
                values: new object[,]
                {
                    { new Guid("94cc43fc-3446-47d3-a735-c4dbda5de144"), "fdf31234-6f18-465e-8610-2226279fae72", new Guid("6d207d13-0cbb-469b-96b8-5342e68cad5e") },
                    { new Guid("fb26db4e-ad6e-4e0a-9a2a-6ff4c3b3a96d"), "abb5f9d9-31e2-47b0-ac2e-bdc6af01fb32", new Guid("f4ef0ad1-e1d4-4513-8754-84a3cb78bef1") },
                    { new Guid("2ebd203d-13f7-4f0a-adbe-a394a12994d4"), "25714220-75c0-417f-96bb-6d2ea4eb8636", new Guid("b2cdff6e-c70d-4aa5-8f69-f0524f8e1662") },
                    { new Guid("db7a3b28-6146-43f5-a76e-ec9b798a9397"), "cc815911-d3fa-4388-9eda-71feca92c937", new Guid("2a0ffe9e-d7f3-407c-8203-ccd18f2c3411") },
                    { new Guid("452eafe2-67fa-43d3-af23-bfc76de27daa"), "3caa77c9-a32a-4c8a-b7c6-ec214aa3bb82", new Guid("cafa1ca6-0429-4e93-b3ec-5bea71f7dbdc") }
                });

            migrationBuilder.InsertData(
                table: "ImageGames",
                columns: new[] { "Id", "GameId", "UrlLocal", "UrlOnline" },
                values: new object[,]
                {
                    { new Guid("4c77e707-b6c4-405d-b995-de56cba8db7e"), new Guid("143203a7-69c1-4a75-b04f-4b56c3cafde2"), "", "https://lh3.googleusercontent.com/Qnm85mIcd32-R8IxmDXM1MPgCfpM2-duddE7P_iS55P0xFO6ZM9jo9dt6PThjWhZvw=w720-h310" },
                    { new Guid("331e7d54-d197-4541-ab32-24afb50d5e14"), new Guid("b2cdff6e-c70d-4aa5-8f69-f0524f8e1662"), "", "https://lh3.googleusercontent.com/ucBNG7Vj8Lqo8b14PUMyzB8h7f2YcZ9oKB6BuFaJTgCj4jEv3Zo1jFPg-FjdONrw8c7b=w720-h310" },
                    { new Guid("6fc3a1bc-6b87-4da1-90e7-de6c8878eaf8"), new Guid("4eec3fd2-d6f2-4b61-97ca-39cac256bed4"), "", "https://lh3.googleusercontent.com/Z_KPg-BqbZVMMLlH689YEwzPefUXW0l_7MfPS8-KUzDV4-y-VeSfnswbSXakPJfoJw8=w720-h310" },
                    { new Guid("154898cd-0d68-4b88-b466-7702362eb3a5"), new Guid("4eec3fd2-d6f2-4b61-97ca-39cac256bed4"), "", "https://lh3.googleusercontent.com/uJK2kFV81mdNGWE9nDO__wadnVhC8afhQourrne9WhOy0ip1UjlsElsw9xd0BV3NCG8=w720-h310" },
                    { new Guid("66345a16-125d-4c63-bd78-7d4a29049110"), new Guid("b93a3a8e-1db8-4221-80a4-79336b613c59"), "", "https://lh3.googleusercontent.com/5W6OOrho0AFit_nm98QqpCsu52uHc-kw7RQPK4_PUdGEi6DjrmfZdPJIGYl2u_3Ibw=w720-h310" },
                    { new Guid("29de524e-52d7-4569-b071-012a921c8cb7"), new Guid("b93a3a8e-1db8-4221-80a4-79336b613c59"), "", "https://lh3.googleusercontent.com/5W6OOrho0AFit_nm98QqpCsu52uHc-kw7RQPK4_PUdGEi6DjrmfZdPJIGYl2u_3Ibw=w720-h310" },
                    { new Guid("5dae44e0-8e3b-415b-a27d-c1d79723a1ec"), new Guid("b93a3a8e-1db8-4221-80a4-79336b613c59"), "", "https://lh3.googleusercontent.com/qSl0aQ-tQiBC_Ut0MC3n-I3HTgQsDQ52XUq_cnfu5rq9kyDSBs2vneGXZZ-PhVv8yb22=w720-h310" },
                    { new Guid("e5f8f1fd-b3f4-4740-9966-00c3b5cee137"), new Guid("b93a3a8e-1db8-4221-80a4-79336b613c59"), "", "https://lh3.googleusercontent.com/nNjmESXQm2dJupXjwYn9RvD6nhS6_5bAthB6GrjrHCdaoiftDAKABIEOBJd3paXCYg=w720-h310" },
                    { new Guid("7cc229ba-646a-425e-b9e7-90c544771f74"), new Guid("b2cdff6e-c70d-4aa5-8f69-f0524f8e1662"), "", "https://lh3.googleusercontent.com/EFv_aMUrdXQLXLesEfQAuFv9bNvQ5hwzYnuKZ1cr_OBDZU6cY6OZhIiDzfhx4eSuvtI=w720-h310" },
                    { new Guid("5ac8caed-095f-4dc6-8a7b-054da3c14cc0"), new Guid("621dfe75-6e9c-4264-a72d-330533e29d49"), "", "https://lh3.googleusercontent.com/NdRmiugakoZ-CgyoqeEd7SC9xT_xFIfjY3LtjMifJ9_iKsUdzA5WgBrs2cgoAK3d_CNr=w720-h310" },
                    { new Guid("bbf5f195-c962-4368-9a18-9e06b32b90a8"), new Guid("143203a7-69c1-4a75-b04f-4b56c3cafde2"), "", "https://lh3.googleusercontent.com/uFYADCilcHxlddeBXKAAu9HNzQG0Mx1VqwuwGQg3WiXBZAg41hooWQTAUilvZetyYhqy=w720-h310" },
                    { new Guid("6bab413b-b9f3-47a7-b31d-96999acc3170"), new Guid("621dfe75-6e9c-4264-a72d-330533e29d49"), "", "https://lh3.googleusercontent.com/A4POGA0IPwbcaSj5dba5zrn6tUlCiyvu4ppse912kWUzr084-qqgvCT0m-E99RPi228=w720-h310" },
                    { new Guid("8ae523ce-52bd-4c54-8b1e-ce125bdbb5a2"), new Guid("621dfe75-6e9c-4264-a72d-330533e29d49"), "", "https://lh3.googleusercontent.com/PeX7REevxeIec-hxFckCJP0xyg88TEzwPh4zz2Prv08d-0UsspP6wcoaBXYJqWzkuQ=w720-h310" },
                    { new Guid("388dba3b-51db-49ad-9d26-f3d246571e5c"), new Guid("143203a7-69c1-4a75-b04f-4b56c3cafde2"), "", "https://lh3.googleusercontent.com/cOijr_HBBvrjn7t00qwPQiXJ2y53NMSMI4iF2YSH89RDlmpe_MbppoqJmXTyIUPCj7M=w720-h310" },
                    { new Guid("dd858fef-1268-4160-9b52-e94ea307ee35"), new Guid("143203a7-69c1-4a75-b04f-4b56c3cafde2"), "", "https://lh3.googleusercontent.com/Kri8NpWg8Nt5BmgNxbMCrW4vxk7LqzjpvibCYHb24_RJgS-l58n-gFR2f4RE_uGfuKI=w720-h310" },
                    { new Guid("103aafff-daf0-4f03-afc4-dd5f0444ff64"), new Guid("621dfe75-6e9c-4264-a72d-330533e29d49"), "", "https://lh3.googleusercontent.com/YL2_i-PixRM-qYfrZ6CpAqyNiXW_MrIx2KFyg2zZLkdjjosIK5qyPg1dfbyTAC-BdNg=w720-h310" },
                    { new Guid("f893dfe1-794d-48bc-a651-49eb0e9c4959"), new Guid("4eec3fd2-d6f2-4b61-97ca-39cac256bed4"), "", "https://lh3.googleusercontent.com/CjrXpLQr5ixH5K9RjdL4CFLhmfgkVCJVAw0bhOuFuFI0v4IaQyt1zbXLVxKfGz2l246x=w720-h310" },
                    { new Guid("52fc2683-c6a7-4a4a-b0e8-69469876bdf8"), new Guid("e14552de-2b28-4332-8181-70617811f804"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("c85d55b8-f7ba-4b83-9509-f7a728a893e1"), new Guid("e14552de-2b28-4332-8181-70617811f804"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("2d504a50-19a9-48ad-9571-348e4dea8b56"), new Guid("b55a1ae3-5e06-416f-8532-8406201f45fc"), "", "https://lh3.googleusercontent.com/zRs9fTN-tL-p4yNL3ccFr1w3wUH-hqN0ShgwAnbzcnH2FidymdlixdDN-lpqF3xck4I=w720-h310" },
                    { new Guid("33b92d52-f0b7-4188-b48f-a304235746da"), new Guid("b55a1ae3-5e06-416f-8532-8406201f45fc"), "", "https://lh3.googleusercontent.com/o0i5z7sG2EArHccVaOCYU516s3PzflywGTbzf3ylRoZwOizKm-jH2AKwXweh2_77Tw=w720-h310" },
                    { new Guid("77a52d48-b9e4-454b-a061-431bd3ef8a3a"), new Guid("b2915638-a97b-4305-a377-2c717866a24b"), "", "https://lh3.googleusercontent.com/JMc16QhAhKFbnW2jusl-T6xu8xo31BDzv8h7APyDdU006PkYvtk3q3Ey76LU-G908M0=w720-h310" },
                    { new Guid("1b3df0d4-e6a6-441c-8644-f2f2156f51a8"), new Guid("b2915638-a97b-4305-a377-2c717866a24b"), "", "https://lh3.googleusercontent.com/RdxHjaoI2WK-ku4--LmPMaZ6DkLVYt0q9IKiSrdqXnmMKlPo4hgZHf0VdN8Oee5pxg=w720-h310" },
                    { new Guid("6aa6cd19-269f-4d30-b88e-542fad65650c"), new Guid("b2915638-a97b-4305-a377-2c717866a24b"), "", "https://lh3.googleusercontent.com/YYz6o1qMBxop37bvU1rfACXRv1AS-gNHOCjUW9lp6eLDV7BQAZ7zUIkG3PF597svP4gP=w720-h310" },
                    { new Guid("fdd791a2-f76c-43cb-b85f-a3195fb71f8c"), new Guid("b2915638-a97b-4305-a377-2c717866a24b"), "", "https://lh3.googleusercontent.com/Ziiu3YNdzaoJf7_rdy9tk7pbPiPlluFvA_JdU0FtzqlvZuLrfyuWNnfkRtMvxq4_lA=w720-h310" },
                    { new Guid("cddac6f7-3f4d-4d0b-ad36-b4985ccfb8a8"), new Guid("acd32c9e-26ff-403b-9199-cb5d9b1b71a1"), "", "https://lh3.googleusercontent.com/ClxJrJjyrjj5uaAxZvSaQcjjRfeCta4_otNRCsGJacfFptfTtamCUJpQ0hcQWOd8u-Q=w720-h310" },
                    { new Guid("75620beb-9c66-40e5-a9e4-86103540f818"), new Guid("acd32c9e-26ff-403b-9199-cb5d9b1b71a1"), "", "https://lh3.googleusercontent.com/JIvkWPFnKbYeVV5h3AxjMgR9ogQ2a0vMQgCp5B3JP4dEXU4zIR40H8ROTg8WkPrjcEA=w720-h310" },
                    { new Guid("4714fe62-478f-46c8-9b7d-35bf296726d6"), new Guid("acd32c9e-26ff-403b-9199-cb5d9b1b71a1"), "", "https://lh3.googleusercontent.com/d0jf4r7KjWBCzi2GELWFSf6MaJIHepkJIN8JYT8g0tSIThiH_W6FhUnHjBN_fYdl3Q=w720-h310" },
                    { new Guid("0246dcd4-c665-44dd-b9dd-6fcbbc776a53"), new Guid("4eec3fd2-d6f2-4b61-97ca-39cac256bed4"), "", "https://lh3.googleusercontent.com/HteHDUkzuMjCEHM1B-3jvLqlbBYtJZFWiHm-vf47YcE7QiInhXn2O-LkYPxvzPnPGA=w720-h310" },
                    { new Guid("939f53de-ff4c-4013-b002-cd219c2314dd"), new Guid("acd32c9e-26ff-403b-9199-cb5d9b1b71a1"), "", "https://lh3.googleusercontent.com/UbTWxlQujVdxOaYqy_FmC4LRBlm_wSUgQe0wIM0BSXeGUZ0Vzle9OTWNNs4wk8nOKI4=w720-h310" },
                    { new Guid("b01b54ed-7860-4f30-97cd-26082ff4fa57"), new Guid("b9d7a713-1d9b-474c-b605-5948c7598727"), "", "https://lh3.googleusercontent.com/jCNaOtE_9-Zcs9r5MFtGzaxO8xNz3UYEcB3XdPe1oLO3X6PH-hYEspWnR26lUZef_5A=w720-h310" },
                    { new Guid("494830a6-0a28-49b6-bc19-a4aab241c1a0"), new Guid("b9d7a713-1d9b-474c-b605-5948c7598727"), "", "https://lh3.googleusercontent.com/d6CY2BSvBXFLK8J3WqJEdDr53_OZ43Aijr43CjG1QKUfHXt4E_zDNBZWoMqkxONzOQ=w720-h310" },
                    { new Guid("8b006e07-21f6-43d1-9fcf-021fd4206d19"), new Guid("b9d7a713-1d9b-474c-b605-5948c7598727"), "", "https://lh3.googleusercontent.com/L615QU2G2qxv68di7WqB4V40mDsOgko4iKmz-NB6SzwLejM8x4i2CbAqgkIxBqZ3A9M=w720-h310" },
                    { new Guid("e172ea08-c92b-4167-85d9-29cc6c5ee8f8"), new Guid("196e363c-ffa1-47bb-a701-3ba50c203287"), "", "https://lh3.googleusercontent.com/9lQV-3IWYXkSndN4GsVQTflvUCSKPMj-uSuH9tEd8FlHuBOslA52Q-Z7wEEKmhwuxJE=w720-h310" },
                    { new Guid("e4942ff7-ee42-4c7c-8053-64785b20e4df"), new Guid("196e363c-ffa1-47bb-a701-3ba50c203287"), "", "https://lh3.googleusercontent.com/3HUpkFFcnCkLbgUosodwIrfzzq3VkebxVQkjfa_uDhapJyrz0ATxq6wRyYpyxKauyg=w720-h310" },
                    { new Guid("99c4dfba-96e4-4ca1-ab26-6c69bb8db208"), new Guid("196e363c-ffa1-47bb-a701-3ba50c203287"), "", "https://lh3.googleusercontent.com/JJNpXkj5HNkscW_bmZ1yGu-GuakL4Q4zRwOPmACFaqbIT5C2HMaI4LwhjGNiIrup_Ew4=w720-h310" },
                    { new Guid("ce3739dc-8a29-4ff2-83be-16173c552315"), new Guid("196e363c-ffa1-47bb-a701-3ba50c203287"), "", "https://lh3.googleusercontent.com/aU5RuCIDy7JzNtp5ib2huaa1t33TVY_zdsES_ooMWSwY6K1JnHG0HC9RK0OgVuXqs9U=w720-h310" },
                    { new Guid("66041824-ff1d-409e-9a7d-a17f218ba02b"), new Guid("e14552de-2b28-4332-8181-70617811f804"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("f1a83cca-032f-490a-8dd9-fa9f559bdb43"), new Guid("e14552de-2b28-4332-8181-70617811f804"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("61686d71-962a-44d0-b2e0-e7961c2c03df"), new Guid("b9d7a713-1d9b-474c-b605-5948c7598727"), "", "https://lh3.googleusercontent.com/sCw3rT7aK1z589o_MBBn1JzVd7fYC1-fWkYV2Tz4eDfCDTi49dS9tOFBLqBrd_XwQCc=w720-h310" },
                    { new Guid("1dda6ad8-3ae1-4477-b802-f09072b5862b"), new Guid("b2cdff6e-c70d-4aa5-8f69-f0524f8e1662"), "", "https://lh3.googleusercontent.com/xaL3b80wmBVOrpH-q_DX8F5kKsASHH8Fllf3u65TsS0zs9_y0J4DWKJj5T9QVAWuT3Rn=w720-h310" },
                    { new Guid("2bf4ad21-4722-41bf-a487-84c7c0131fe3"), new Guid("c31974c6-8bdb-4984-b881-cceec254d18a"), "", "https://lh3.googleusercontent.com/Ibj-Kt-6Pc1IBDVj0yWf1sNjSpdGpRlapbTbjc5MuitmDkoKVMP45GF0LBlg6pnIbYE=w720-h310" },
                    { new Guid("74b3ef9e-328e-4c69-9fd0-357b9ac09a28"), new Guid("b55a1ae3-5e06-416f-8532-8406201f45fc"), "", "https://lh3.googleusercontent.com/AinG9y8hyEb_p2B6Rg8-iOVjYR7EcsGDmv_rThdnfzgkBjbukLIT4mWFOg5ObAO4RMq0=w720-h310" },
                    { new Guid("9e1ab976-ca52-497a-b40f-614ca7f5aedc"), new Guid("0103fa55-1bec-464c-9121-375d953c58af"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("8684a17a-f7f8-4541-8ed8-b497c2393240"), new Guid("0103fa55-1bec-464c-9121-375d953c58af"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("4c0f543c-f40e-4241-800a-563c23d11931"), new Guid("0103fa55-1bec-464c-9121-375d953c58af"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("352df0ac-3313-4855-9e0e-f0ae943cbb17"), new Guid("0103fa55-1bec-464c-9121-375d953c58af"), "", "https://lh3.googleusercontent.com/3w11K9XJxAy89BNu2LAbU9n8DD2fo-zF5ovi7mdQoAgcRye6-MLCWlEzebyxvSLqHnD_=w720-h310" },
                    { new Guid("88f91370-e00e-4417-8763-7a769eb8ea1b"), new Guid("2a0ffe9e-d7f3-407c-8203-ccd18f2c3411"), "", "https://lh3.googleusercontent.com/UY9fte3alDnv-cZ94Jx27Lf4g9FUT2395jhXPScEllshpdCO4zfnuWrTNtO1FVRt3w=w720-h310" },
                    { new Guid("90cde699-1046-4dc5-9ef6-a7ef689954b3"), new Guid("2a0ffe9e-d7f3-407c-8203-ccd18f2c3411"), "", "https://lh3.googleusercontent.com/-BUT6NCVxZsPPjsUW8zdrVk4XLMRuE_oWSTwaXrAPYZbBsMKBfqXxOVI7OowXxoLwa8=w720-h310" },
                    { new Guid("a3286ebd-8190-4e92-a84f-4bef20021444"), new Guid("2a0ffe9e-d7f3-407c-8203-ccd18f2c3411"), "", "https://lh3.googleusercontent.com/MwNuIIzmxxJgM8JeNi2aBhpE-kNnXBGOVPRb_gZoRE-gel5q9ZP7mrQfTT_9xzV8dz4=w720-h310" },
                    { new Guid("1a2efd51-ba72-46d9-8f9b-9e0114ea2653"), new Guid("b2cdff6e-c70d-4aa5-8f69-f0524f8e1662"), "", "https://lh3.googleusercontent.com/gFZCgWFd8-oR8zu2ApqRWk6dgwIkDM8jex4MxbA-MdiYgfpHJlkAcPBCZX5czXgddA=w720-h310" },
                    { new Guid("833ab0a5-26d4-413f-8090-d18ff0d2304b"), new Guid("2a0ffe9e-d7f3-407c-8203-ccd18f2c3411"), "", "https://lh3.googleusercontent.com/mfGdhejubeU1m1Pkj2vpWMLTlLMhnQz0f2Z8M79g6g0thY9cDyHggntmd_A7ckZPGVM=w720-h310" },
                    { new Guid("b11e35f2-1ed5-439f-b25c-bc20ecf1145a"), new Guid("e291a33f-3938-4079-8a6c-853efac83147"), "", "https://lh3.ggpht.com/y7On3vVZhFWycuekTPLwARYJ3MwQyODIzKHRt4ofyeS_gmXRDF271NsFDfu_lLhlX2Rj=w720-h310" },
                    { new Guid("3f45ce64-7275-44a9-9c03-67779ef50e52"), new Guid("e291a33f-3938-4079-8a6c-853efac83147"), "", "https://lh3.ggpht.com/y7On3vVZhFWycuekTPLwARYJ3MwQyODIzKHRt4ofyeS_gmXRDF271NsFDfu_lLhlX2Rj=w720-h310" },
                    { new Guid("afebac09-cd0e-432b-b647-ab202396f32a"), new Guid("e291a33f-3938-4079-8a6c-853efac83147"), "", "https://lh3.ggpht.com/y7On3vVZhFWycuekTPLwARYJ3MwQyODIzKHRt4ofyeS_gmXRDF271NsFDfu_lLhlX2Rj=w720-h310" },
                    { new Guid("3026cdb0-2b55-4ad5-b581-2cc424e48e71"), new Guid("cafa1ca6-0429-4e93-b3ec-5bea71f7dbdc"), "", "https://lh3.googleusercontent.com/h4JQOfS4vmim_WhTHeC3RGxtY8eoFG0fgtgsWWk6VvVSrjnjtlgSFzR6sW0hzbncWA=w720-h310" },
                    { new Guid("96578e08-ac41-49ea-bfad-64b212c5f600"), new Guid("cafa1ca6-0429-4e93-b3ec-5bea71f7dbdc"), "", "https://lh3.googleusercontent.com/oMcH_a4lXShvowzyaiQpE0_MhYWZvdN9RkaYLtkdnw_rlDR_uHbHj9Eu2zbrvyOAXHQ=w720-h310" },
                    { new Guid("f15bdd0f-d724-4852-bcc7-08909b4ab369"), new Guid("cafa1ca6-0429-4e93-b3ec-5bea71f7dbdc"), "", "https://lh3.googleusercontent.com/Ia1psbcXgeCV9FBZk1b08QnxC-uSHCgJ112VeJZB19_F2Q-m_w3Z7P_OjFStnYM3LaCC=w720-h310" },
                    { new Guid("90f6540c-def0-46ad-a1f6-6a87fec771b3"), new Guid("cafa1ca6-0429-4e93-b3ec-5bea71f7dbdc"), "", "https://lh3.googleusercontent.com/vInYRcyjzVjBFfY4HIGLLf-tSLK9S55HjUbmQuxmrbpVpItV3AfyuxVMFGASoDdMHc4=w720-h310" },
                    { new Guid("e4436c65-4da6-4878-829c-6f18e2e179a8"), new Guid("e291a33f-3938-4079-8a6c-853efac83147"), "", "https://lh3.ggpht.com/y7On3vVZhFWycuekTPLwARYJ3MwQyODIzKHRt4ofyeS_gmXRDF271NsFDfu_lLhlX2Rj=w720-h310" },
                    { new Guid("1d8058c7-b757-4975-9c20-1b2c9042f816"), new Guid("c1fc2ff2-0562-4f41-a543-c8488a799dc0"), "", "https://lh3.googleusercontent.com/FMgP9XZNML3lieBG9KDgiJGnT2WlmHMG5lFGcAl0rk93GtGFjf9X2J6vxcCCElNPJDw=w720-h310" },
                    { new Guid("4bf8b801-ec64-4c91-9f76-40c777b8a022"), new Guid("c1fc2ff2-0562-4f41-a543-c8488a799dc0"), "", "https://lh3.googleusercontent.com/DQppPRLU04SzwExhZTIKsYL1y3iZXzRsZbTBrmHJqJO1aTCsApHGdYxTKt3dvkN7ctRb=w720-h310" },
                    { new Guid("380b0b57-40ab-4af1-a9f3-9a87b171550c"), new Guid("c1fc2ff2-0562-4f41-a543-c8488a799dc0"), "", "https://lh3.googleusercontent.com/-oRMqwODzaru2JCxLf3JtHVZXtpYfQ8Qo0IQRbRsZtssH6dUGr51WMfH0j3eMrfO5w=w720-h310" },
                    { new Guid("6347589d-713e-42ba-84b1-7e17a323e9e0"), new Guid("c31974c6-8bdb-4984-b881-cceec254d18a"), "", "https://lh3.googleusercontent.com/W_3i_ZHnSjan-N8egYQy9sQw87CppDDda9ITzTIQyTFHZpO2VJlhCzP_BORM3Hd-CDw=w720-h310" },
                    { new Guid("284f5e2a-8363-4a99-8ac4-b898efe0bf02"), new Guid("c31974c6-8bdb-4984-b881-cceec254d18a"), "", "https://lh3.googleusercontent.com/RhBTJ2IEOhtPEbOpmMTxfMC9iU06JihtylD-lQxbTrIPfT2U-B0YLAjGELbj2Ppk1w8=w720-h310" },
                    { new Guid("5dbff9e3-0b1b-4fcd-aeea-9114468ce76f"), new Guid("c31974c6-8bdb-4984-b881-cceec254d18a"), "", "https://lh3.googleusercontent.com/nlXezemMS359X8dy6MxUJMgumyw6abz15NX0CjtnT8V57vni_uuS3saDllIMeyfQ6e-6=w720-h310" },
                    { new Guid("d6953922-f45e-4026-bd49-a9f47dc17a4d"), new Guid("f4ef0ad1-e1d4-4513-8754-84a3cb78bef1"), "", "https://lh3.googleusercontent.com/aosNkyZihAba_VF_HRKOUMGFuK5SxNcZMMvYIAXufiG8znXvrxJ_7jMgmP2E01CapoQ=w720-h310" },
                    { new Guid("a003913e-9e96-4e68-ae8d-8c236dadb188"), new Guid("c1fc2ff2-0562-4f41-a543-c8488a799dc0"), "", "https://lh3.googleusercontent.com/wzk-BPRwz5Lrh2YZ66uEJb8JjXkFE8oVm4RpZVTmWsCcx1e1nxP3XBhqr2q9Iff7Xica=w720-h310" },
                    { new Guid("8917270e-fcb3-4c44-90a2-42e824240794"), new Guid("f4ef0ad1-e1d4-4513-8754-84a3cb78bef1"), "", "https://lh3.googleusercontent.com/Km7Il6ij6xZBtWJPSpEacmz8dC2C9WACUuf37VdjIYaXWaPaC6WWWmx3T8aaNgNkJaBx=w720-h310" },
                    { new Guid("b80ce391-2cd2-4925-99a7-b0861e0cf028"), new Guid("f4ef0ad1-e1d4-4513-8754-84a3cb78bef1"), "", "https://lh3.googleusercontent.com/tk_p7dIHQBEBeYiVkFaPcU_5bd3fOhE8HerKp4Ei0cTyxVoVDdd_QD0SLPJeJrSm4c4=w720-h310" },
                    { new Guid("c19e5adf-7e0a-4e9e-9973-5cd256bdae6b"), new Guid("f4ef0ad1-e1d4-4513-8754-84a3cb78bef1"), "", "https://lh3.googleusercontent.com/Zsth8maheotaUA0he3vGtWmm11dWsEsLlffOsvzGX65Sp4nXNAuKSx-Z96f8as3twQ4=w720-h310" },
                    { new Guid("58d6b958-75ca-4966-8d0c-09d8cfa77eb1"), new Guid("6d207d13-0cbb-469b-96b8-5342e68cad5e"), "", "https://lh3.ggpht.com/GqnDETqoUP17xJg0cQ3pyEHsgO-KLjx-MbJ0Mcwg4Lvd2PnEO-JARZhYtfd8AYwjEew=w720-h310" },
                    { new Guid("0c82039f-374c-4582-ad63-b7ffd8b49084"), new Guid("6d207d13-0cbb-469b-96b8-5342e68cad5e"), "", "https://lh3.ggpht.com/Vbi7XVMzoCMoAyHFhJlziKjldN5F-Mkp4EOf5YyiMOPsd-of4ckac2BzPAiKGIveSI4=w720-h310" },
                    { new Guid("66c3ef34-e821-4f44-b360-d7f9d5837dfb"), new Guid("6d207d13-0cbb-469b-96b8-5342e68cad5e"), "", "https://lh3.ggpht.com/AZ2OkTlsJuqUvCP8IQKwkCg7Fv56FRAb_CV8bXRsR15Ayre8fmWJrkr4RCIvx1wYoktm=w720-h310" },
                    { new Guid("3ee10dcc-1672-43ca-999e-a47578b3c3c6"), new Guid("6d207d13-0cbb-469b-96b8-5342e68cad5e"), "", "https://lh3.ggpht.com/WRg7Mzp5FM-cSiKGb7TbzgeYBY8oMSV4Vgn35XYHDbejbNkWM7lNgqFeQjMlNAZoUX7Z=w720-h310" },
                    { new Guid("709b7063-3fc7-4763-bc81-4040729daac2"), new Guid("b55a1ae3-5e06-416f-8532-8406201f45fc"), "", "https://lh3.googleusercontent.com/WJIWdX6YPms3-diI1TPcCPtgv_YGH2QNMGqOXLK-ta5FLulrZps4KObsB1-frjU6syA=w720-h310" }
                });

            migrationBuilder.InsertData(
                table: "UserGames",
                columns: new[] { "UserId", "GameId", "PurchaseDate" },
                values: new object[,]
                {
                    { new Guid("bcfdfd0f-ddd6-4533-8f10-54f11a89cdba"), new Guid("2a0ffe9e-d7f3-407c-8203-ccd18f2c3411"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d18587d8-66b5-4aa7-8f92-db5ed036697d"), new Guid("6d207d13-0cbb-469b-96b8-5342e68cad5e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eb7d9d2d-107b-4730-a2a3-0acc61fde5e9"), new Guid("f4ef0ad1-e1d4-4513-8754-84a3cb78bef1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("92417557-ceac-4229-bd39-013b65cc0fbd"), new Guid("cafa1ca6-0429-4e93-b3ec-5bea71f7dbdc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9025855a-8baf-482f-80dc-852a0a8f22b7"), new Guid("b2cdff6e-c70d-4aa5-8f69-f0524f8e1662"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "WishGame",
                columns: new[] { "UserId", "GameId" },
                values: new object[,]
                {
                    { new Guid("bcfdfd0f-ddd6-4533-8f10-54f11a89cdba"), new Guid("2a0ffe9e-d7f3-407c-8203-ccd18f2c3411") },
                    { new Guid("eb7d9d2d-107b-4730-a2a3-0acc61fde5e9"), new Guid("f4ef0ad1-e1d4-4513-8754-84a3cb78bef1") },
                    { new Guid("92417557-ceac-4229-bd39-013b65cc0fbd"), new Guid("cafa1ca6-0429-4e93-b3ec-5bea71f7dbdc") },
                    { new Guid("9025855a-8baf-482f-80dc-852a0a8f22b7"), new Guid("b2cdff6e-c70d-4aa5-8f69-f0524f8e1662") },
                    { new Guid("d18587d8-66b5-4aa7-8f92-db5ed036697d"), new Guid("6d207d13-0cbb-469b-96b8-5342e68cad5e") }
                });
        }
    }
}
