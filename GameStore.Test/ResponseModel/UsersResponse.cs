using GameStore.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Test.ResponseModel
{
    class UsersResponse: BaseResponse
    {
        public List<UserDTOs> Payload { get; set; }
    }

    class UserResponse : BaseResponse
    {
        public UserDTOs Payload { get; set; }
    }
}
