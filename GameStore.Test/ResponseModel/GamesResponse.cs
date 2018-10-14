using GameStore.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Test.ResponseModel
{
    class GamesResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public List<GameDTOs> Payload { get; set; }
    }
}
