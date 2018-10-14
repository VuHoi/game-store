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
    [Collection("FreecodeE2E")]
    public  class FreecodeControllerShould : BaseController
    {
        private readonly ITestOutputHelper _output;

        public FreecodeControllerShould(ITestOutputHelper output) : base(49914)
        {
            _output = output;
        }
        [Fact]
        [Trait("Freecodes", "FreecodeE2E")]
        public void TestGetAllFreeCodesController()
        {
            Init(49914);
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BASE_URI;
                HttpResponseMessage result = client.GetAsync("api/freecodes").GetAwaiter().GetResult();
                var content = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                FreeCodeResponse freeCodeResponse = JsonConvert.DeserializeObject<FreeCodeResponse>(content);
                Assert.Equal(HttpStatusCode.OK, result.StatusCode);
                Assert.Equal(5, freeCodeResponse.Payload.Count);
                Assert.True(freeCodeResponse.IsSuccess);
            }

        }
    }
}
