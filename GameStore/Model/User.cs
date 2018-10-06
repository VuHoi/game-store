using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Model
{
    public class User : IdentityUser<Guid>
    {

        public ICollection<UserGame> Games { get; set; }
        public string Hobbies { get; set; }
        public string FullName { get; set; }
        public ICollection<WishGame> WishGames { get; set; }
        public User()
        {
            this.Games = new Collection<UserGame>();
        }
    }
}
