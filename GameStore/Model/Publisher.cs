using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Model
{
    public class Publisher
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Game> Games { get; set; }
        public int Money { get; set; }
        public int Reliability { get; set; }
        
        public Publisher()
        {
            Id = Guid.NewGuid();
            Games = new Collection<Game>();
        }

    }
}
