using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Model
{
    public class User : IdentityUser
    {

        public ICollection<Game> Games { get;  }
        public User()
        {
            this.Games = new Collection<Game>();
        }
    }
}
