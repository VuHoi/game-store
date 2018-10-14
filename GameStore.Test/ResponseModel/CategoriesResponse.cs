using GameStore.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Test.ResponseModel
{
    class CategoriesResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public List<CategoryDTOs> Payload { get; set; }
    }
}
