using GameStore.Common;
using GameStore.DTOs;
using GameStore.Model;
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
    [Collection("AccountE2E")]
    public class AccountsControllerShould : BaseController
    {
        private readonly ITestOutputHelper _output;

        public AccountsControllerShould(ITestOutputHelper output) : base(49912)
        {
            _output = output;
        }

        [Fact]
        [Trait("Account", "AccountE2E")]
        public void TestGetAllUsersController()
        {
            Init(49912);
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BASE_URI;
                HttpResponseMessage result = client.GetAsync("api/accounts").GetAwaiter().GetResult();
                var content = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                UsersResponse freeCodeResponse = JsonConvert.DeserializeObject<UsersResponse>(content);
                Assert.Equal(HttpStatusCode.OK, result.StatusCode);
                Assert.Equal(5, freeCodeResponse.Payload.Count);
                Assert.True(freeCodeResponse.IsSuccess);
            }

        }
    
    }
}
