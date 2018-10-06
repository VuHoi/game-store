using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Model
{
    public class CategoryGame
    {
        public Guid GameId { get; set; }
        public Game Game { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
