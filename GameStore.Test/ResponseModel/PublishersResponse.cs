using GameStore.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Test.ResponseModel
{
    class PublishersResponse : BaseResponse
    {
        public List<PublisherDTOs> Payload { get; set; }
    }
    class PublisherResponse : BaseResponse
    {
        public PublisherDTOs Payload { get; set; }
    }
}
