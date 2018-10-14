using GameStore.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Test.ResponseModel
{
    class UsersResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public List<UserDTOs> Payload { get; set; }
    }
}
