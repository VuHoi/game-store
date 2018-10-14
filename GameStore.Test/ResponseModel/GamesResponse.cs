using GameStore.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Test.ResponseModel
{
    class GamesResponse : BaseResponse
    {
        public List<GameDTOs> Payload { get; set; }
    }
    class GameResponse : BaseResponse
    {
        public GameDTOs Payload { get; set; }
    }
}
