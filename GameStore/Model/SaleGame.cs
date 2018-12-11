using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Model
{
    public class SaleGame
    {
        public Guid Id { get; set; }
        public Guid GameId { get; set; }
        public virtual Game Game { get; set; }
        public float sale { get; set; }

    }
}
