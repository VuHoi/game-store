using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Model
{
    public class Game
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<User> Members { get; }
        public float Rating { get; set; }
        public string Logo { get; set; }
        public string VideoUrl { get; set; }
        public string Content { get; set; }
        public ICollection<Category> Categories { get; set; }
        public DateTime PurchaseDate { get; set; }
        public ICollection<CodeFree> FreeCode { get; set; }
        //Server=(localdb)\\mssqllocaldb;Database=GameDB;Trusted_Connection=True
        //Server=tcp:gamestorecrosplatformdbserver.database.windows.net,1433;Initial Catalog = GameDB; Persist Security Info=False;User ID = vkhoi; Password=Thatvuhai_7595;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;
        public Game()
        {
            Id = Guid.NewGuid();
            Members = new Collection<User>();
            FreeCode = new Collection<CodeFree>();
            Categories = new Collection<Category>();
            PurchaseDate= DateTime.Now;
        }
    }
}
