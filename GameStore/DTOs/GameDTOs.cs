using GameStore.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.DTOs
{
    public class GameDTOs
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public PublisherDTOs Publisher { get; set; }
        public ICollection<TitleUser> Members { get; set; }
        public ICollection<TitleUser> FavoriteMembers { get; set; }
        public float Rating { get; set; }
        public string Logo { get; set; }
        public string VideoUrl { get; set; }
        public string Content { get; set; }
        public ICollection<TitleCategory> Categories { get; set; }
        public DateTime PurchaseDate { get; set; }

        public GameDTOs()
        {
            Members = new Collection<TitleUser>();
            FavoriteMembers = new Collection<TitleUser>();
            Categories = new Collection<TitleCategory>();
        }
    }
}
