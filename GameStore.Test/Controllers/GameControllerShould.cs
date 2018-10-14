using GameStore.Test.ResponseModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using Xunit;
using Xunit.Abstractions;

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
            Init(49914);
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BASE_URI;
                HttpResponseMessage result = client.GetAsync("api/games").GetAwaiter().GetResult();
                var content = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                GamesResponse gamesResponse = JsonConvert.DeserializeObject<GamesResponse>(content);
                Assert.Equal(HttpStatusCode.OK, result.StatusCode);
                Assert.Equal(5, gamesResponse.Payload.Count);
                Assert.True(gamesResponse.IsSuccess);
            }

        }

        [Theory]
        [InlineData("39ACCDD9-161A-4FE0-8A10-310F8C98AD93")]
        [InlineData("8B4DDF45-3956-486B-A2F6-3FEC1B3D3048")]
        [InlineData("F5153E60-15B8-468E-97AE-A01E5188F053")]
        [InlineData("42DFEC91-42C7-49F5-B449-B4E22E895088")]
        [InlineData("EC1FB6A2-755E-4561-903C-D504845D9475")]
        [Trait("Games", "GameE2E")]
        public void TestGetGameByIdController(string Id)
        {
            Init(49914);
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BASE_URI;
                HttpResponseMessage result = client.GetAsync($"api/games/{Id}").GetAwaiter().GetResult();
                var content = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                GameResponse gamesResponse = JsonConvert.DeserializeObject<GameResponse>(content);
                Assert.Equal(HttpStatusCode.OK, result.StatusCode);
                Assert.True(gamesResponse.IsSuccess);
            }

        }
    }
}
