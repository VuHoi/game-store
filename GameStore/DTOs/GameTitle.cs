using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.DTOs
{
    public class GameTitle
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
