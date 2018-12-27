using GameStore.DTOs;
using GameStore.Test.ResponseModel;
using Newtonsoft.Json;
using GameStore.Extention;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using Xunit;
using Xunit.Abstractions;
using System.Collections.ObjectModel;

namespace GameStore.Test.Controllers
{
    [Collection("GameE2E")]
    public class GameControllerShould : BaseController
    {
        private readonly ITestOutputHelper _output;

        public GameControllerShould(ITestOutputHelper output) : base(49914)
        {
            _output = output;
        }
        [Fact]
        [Trait("Games", "GameE2E")]
        public void TestGetAllGamesController()
        {
            Init(49893);
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BASE_URI;
                HttpResponseMessage result = client.GetAsync("api/games").GetAwaiter().GetResult();
                var content = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                Responses<GameDTOs> gamesResponse = JsonConvert.DeserializeObject<Responses<GameDTOs>>(content);
                Assert.Equal(HttpStatusCode.OK, result.StatusCode);
                //Assert.Equal(19, gamesResponse.Payload.Count);
                Assert.True(gamesResponse.IsSuccess);
            }

        }

        [Theory]
        [InlineData("8c4934f9-cacc-42b5-a060-19216cf11856", 49894)]
        [InlineData("e58f2c65-c474-4955-9233-efd4f684b6b1", 49895)]
        [InlineData("09d7037e-0e3c-4941-bc80-53c46497b6f3", 49896)]
        [InlineData("e6cc0faf-7c08-462b-b354-4963ef6ab5e0", 49897)]
        [InlineData("7a897fb7-1b25-49cc-99ae-9ad516eef7e3", 49898)]
        [Trait("Games", "GameE2E")]
        public void TestGetGameByIdController(string Id,int port)
        {
            Init(port);
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BASE_URI;
                HttpResponseMessage result = client.GetAsync($"api/games/{Id}").GetAwaiter().GetResult();
                var content = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                Response<GameDTOs> gamesResponse = JsonConvert.DeserializeObject<Response<GameDTOs>>(content);
                Assert.Equal(HttpStatusCode.OK, result.StatusCode);
                Assert.False(gamesResponse.IsSuccess);
            }

        }


        [Theory]
        [InlineData("Gunny", "17d7f739-062e-4af7-b90f-c1e90c304de2", "EC1FB6A2-755E-4561-903C-D504845D9475",
            "42DFEC91-42C7-49F5-B449-B4E22E895088", "42DFEC91-42C7-49F5-B449-B4E22E895088",
            "EC1FB6A2-755E-4561-903C-D504845D9475", 3,"logo here",
            "video here","content here ", "EC1FB6A2-755E-4561-903C-D504845D9475",
            "42DFEC91-42C7-49F5-B449-B4E22E895088", 1000000
            )]


        [Trait("Freecodes", "FreecodeE2E")]
        public void TestPostNewGameController(string name, string publisherId,
                                              string members1, string members2,
                                              string favoriteMembers1, string favoriteMembers2,
                                              float rating,string logo,
                                              string videoUrl,string content,
                                              string categories1,string categories2,
                                              float price)
        {
            Init(49899);

            SavedGameDTOs savedGameDTOs = new SavedGameDTOs()
            {
                Name = name,
                PublisherId = publisherId.ToGuid(),
                Members = new Collection<Guid>{ members1.ToGuid(), members2.ToGuid()},
                FavoriteMembers= new Collection<Guid> { favoriteMembers1.ToGuid(), favoriteMembers2.ToGuid() },
                Rating=rating,
                Logo=logo,
                VideoUrl=videoUrl,
                Content=content,
                Categories=new Collection<Guid> { categories1.ToGuid(),categories2.ToGuid()},
                Price=price,
                PurchaseDate=DateTime.Now
            };
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BASE_URI;
                HttpResponseMessage result = client.PostAsJsonAsync($"api/games", savedGameDTOs).GetAwaiter().GetResult();
                var contentResult = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                Response<GameDTOs> gameResponse = JsonConvert.DeserializeObject<Response<GameDTOs>>(contentResult);
                Assert.Equal(HttpStatusCode.OK, result.StatusCode);
                Assert.True(gameResponse.IsSuccess);
            }
        }
    }
}
