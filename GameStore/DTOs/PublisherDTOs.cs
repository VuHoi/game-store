using GameStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.DTOs
{
    public class PublisherDTOs
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Game> Games { get; set; }
        public int Money { get; set; }
        public int Reliability { get; set; }
    }
}
