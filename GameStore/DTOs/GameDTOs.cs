using GameStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.DTOs
{
    public class GameDTOs
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<UserDTOs> Members { get; set; }
        public ICollection<UserDTOs> FavoriteMembers { get; set; }
        public float Rating { get; set; }
        public string Logo { get; set; }
        public string VideoUrl { get; set; }
        public string Content { get; set; }
        public ICollection<CategoryDTOs> Categories { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
