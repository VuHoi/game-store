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
  public  class PublisherControllerShould :BaseController
    {
        private readonly ITestOutputHelper _output;

        public PublisherControllerShould(ITestOutputHelper output) : base(49914)
        {
            _output = output;
        }
        [Fact]
        [Trait("Publisher", "GameE2E")]
        public void TestGetAllPublishersController()
        {
            Init(49914);
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BASE_URI;
                HttpResponseMessage result = client.GetAsync("api/games").GetAwaiter().GetResult();
                var content = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                PublishersResponse gamesResponse = JsonConvert.DeserializeObject<PublishersResponse>(content);
                Assert.Equal(HttpStatusCode.OK, result.StatusCode);
                Assert.Equal(5, gamesResponse.Payload.Count);
                Assert.True(gamesResponse.IsSuccess);
            }

        }
    }
}
