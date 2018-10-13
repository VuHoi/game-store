using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.DTOs
{
    public class LikeGameDTOs
    {
        public Guid Id { get; set; }
        public virtual ICollection<Guid> IDWishGames { get; set; }
        public LikeGameDTOs()
        {
            IDWishGames = new Collection<Guid>();
        }
    }
}
