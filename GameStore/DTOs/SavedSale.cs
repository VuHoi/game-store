using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.DTOs
{
    public class SavedSale
    {
        public float Sale { get; set; }
        public DateTime StartDateSale { get; set; }
        public DateTime EndDateSale { get; set; }
        public SavedSale()
        {
            Sale = 0;
            StartDateSale = DateTime.Now;
            EndDateSale = DateTime.Now;
        }
    }
}
