using GameStore.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Test.ResponseModel
{
    class PublishersResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public List<PublisherDTOs> Payload { get; set; }
    }
}
