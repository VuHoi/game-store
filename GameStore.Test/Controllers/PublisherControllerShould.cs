using GameStore.DTOs;
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
            Init(49900);
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BASE_URI;
                HttpResponseMessage result = client.GetAsync("api/publishers").GetAwaiter().GetResult();
                var content = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                Responses<PublisherDTOs> publishersResponse = JsonConvert.DeserializeObject<Responses<PublisherDTOs>>(content);
                Assert.Equal(HttpStatusCode.OK, result.StatusCode);
                //Assert.Equal(6, publishersResponse.Payload.Count);
                Assert.True(publishersResponse.IsSuccess);
            }

        }


        [Theory]
        [InlineData("0703A244-3012-4725-B9A5-2E3D5AF9F0FE",49905)]
        [InlineData("B49D6EDB-140D-46CC-BD0B-482BE03C8C46",49906)]
        [InlineData("773F8D2E-B12D-4A9F-91D9-9E5DA568F0EB",49907)]
        [InlineData("DC23F861-FF43-45AF-845C-AF4514DF22A2",49908)]
        [InlineData("CA1ACA5F-CDEE-43A6-BDCB-E596D1B909A5",49909)]
        [InlineData("0E276582-8CA0-4DE3-A465-ED721530AE2C",49910)]
        [Trait("Publisher", "GameE2E")]
        public void TestGetPublisherByIdController(string Id,int port)
        {
            Init(port);
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BASE_URI;
                HttpResponseMessage result = client.GetAsync($"api/publishers/{Id}").GetAwaiter().GetResult();
                var content = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                Response<PublisherDTOs> publisherResponse = JsonConvert.DeserializeObject<Response<PublisherDTOs>>(content);
                Assert.Equal(HttpStatusCode.OK, result.StatusCode);
                Assert.True(publisherResponse.IsSuccess);
            }

        }



        [Theory]
        [InlineData("Gunny",10000000,10, 49901)]
        [InlineData("Gamloft", 20000000, 10, 49902)]
        [InlineData("VNG", 30000000, 10, 49903)]
        [InlineData("GameHub", 10000000, 10,49904)]

        [Trait("Freecodes", "FreecodeE2E")]
        public void TestPostNewPublisherController(string name,int money,int reliability,int port)
        {
            Init(port);

            SavedPublisherDTOs savedPublisherDTOs = new SavedPublisherDTOs()
            {
               Name= name,
               Money=money,
               Reliability=reliability
            };
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BASE_URI;
                HttpResponseMessage result = client.PostAsJsonAsync($"api/publishers", savedPublisherDTOs).GetAwaiter().GetResult();
                var content = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                Response<PublisherDTOs> freeCodeResponse = JsonConvert.DeserializeObject<Response<PublisherDTOs>>(content);
                Assert.Equal(HttpStatusCode.OK, result.StatusCode);
                Assert.True(freeCodeResponse.IsSuccess);
            }
        }
    }
}
