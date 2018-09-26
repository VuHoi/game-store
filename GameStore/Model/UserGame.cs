using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Model
{
    public class UserGame
    {
            public Guid GameId { get; set; }
            public Game Game { get; set; }
            public string UserId { get; set; }
            public User User { get; set; }
       
    }
}
