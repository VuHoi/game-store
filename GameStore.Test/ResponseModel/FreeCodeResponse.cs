using GameStore.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Test.ResponseModel
{
    class FreeCodeResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public List<FreeCodeDTOs> Payload { get; set; }
    }
}
