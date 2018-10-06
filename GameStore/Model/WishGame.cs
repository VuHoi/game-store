using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Model
{
    public class WishGame
    {
        public Guid GameId { get; set; }
        public Game Game { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
