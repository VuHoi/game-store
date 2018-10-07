using GameStore.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.DTOs
{
    public class UserDTOs
    {
        public ICollection<GameTitle> Games { get; set; }
        public string Hobbies { get; set; }
        public string FullName { get; set; }
        public ICollection<GameTitle> WishGames { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public UserDTOs()
        {
            Games = new Collection<GameTitle>();
            WishGames = new Collection<GameTitle>();
        }

    }
}
