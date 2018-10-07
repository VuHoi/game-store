using GameStore.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.DTOs
{
    public class PublisherDTOs
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<GameDTOs> Games { get; set; }
        public int Money { get; set; }
        public int Reliability { get; set; }

        public PublisherDTOs()
        {
            Games = new Collection<GameDTOs>();
        }
    }
}
