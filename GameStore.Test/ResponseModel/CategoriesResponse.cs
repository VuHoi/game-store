using GameStore.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Test.ResponseModel
{
    class CategoriesResponse : BaseResponse
    {
        public List<CategoryDTOs> Payload { get; set; }
    }
    class CategoryResponse : BaseResponse
    {
        public CategoryDTOs Payload { get; set; }
    }
}
