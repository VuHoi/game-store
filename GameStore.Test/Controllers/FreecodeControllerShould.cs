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
  public  class FreecodeControllerShould : BaseController
    {
        private readonly ITestOutputHelper _output;

        public FreecodeControllerShould(ITestOutputHelper output) : base(49913)
        {
            _output = output;
        }
        [Fact]
        [Trait("Category", "CategoryE2E")]
        public void TestGetAllFreeCodesController()
        {

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
