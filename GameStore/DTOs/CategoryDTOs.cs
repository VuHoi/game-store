using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.DTOs
{
    public class CategoryDTOs
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public ICollection<GameDTOs> Games { get; set; }

        public CategoryDTOs()
        {
            Games = new Collection<GameDTOs>();
        }
    }
}
