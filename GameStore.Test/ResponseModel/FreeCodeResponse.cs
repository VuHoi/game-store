using GameStore.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Test.ResponseModel
{
    class FreeCodesResponse: BaseResponse
    {
        public List<FreeCodeDTOs> Payload { get; set; }
    }

    class FreeCodeResponse : BaseResponse
    {
        public FreeCodeDTOs Payload { get; set; }
    }
}
