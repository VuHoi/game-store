using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using GameStore.Model;
using GameStore.Extention;

namespace GameStore.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, ApplicationRole,Guid>
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CodeFree> CodeFrees { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<UserGame> UserGames { get; set; }
        public DbSet<ApplicationRole> ApplicationRoles { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyEntityConfigurations();
            base.OnModelCreating(builder);

            //builder.ChangeIdentityTableNames();



            //seed data 

            var Publishers = new[]
           {
                new Publisher(){ Id = Guid.NewGuid(), Name="Name here",Money=10000000,Reliability=5},
                new Publisher(){ Id = Guid.NewGuid(), Name="Name here",Money=10000000,Reliability=5},
                new Publisher(){ Id = Guid.NewGuid(), Name="Name here",Money=10000000,Reliability=5},
                new Publisher(){ Id = Guid.NewGuid(), Name="Name here",Money=10000000,Reliability=5},
                new Publisher(){ Id = Guid.NewGuid(), Name="Name here",Money=10000000,Reliability=5},
                new Publisher(){ Id = Guid.NewGuid(), Name="Name here",Money=10000000,Reliability=5},
            };
            builder.Entity<Publisher>().HasData(Publishers);

            //var Categories = new[]
            //{
            //    new Category(){ Id = Guid.NewGuid(), Image="Url Image Here",Title="Title here"},
            //    new Category(){ Id = Guid.NewGuid(), Image="Url Image Here",Title="Title here"},
            //    new Category(){ Id = Guid.NewGuid(), Image="Url Image Here",Title="Title here"},
            //    new Category(){ Id = Guid.NewGuid(), Image="Url Image Here",Title="Title here"},
            //    new Category(){ Id = Guid.NewGuid(), Image="Url Image Here",Title="Title here"},
            //};
            //builder.Entity<Category>().HasData(Categories);

            var Games = new[]
          {
                new Game(){ Id = Guid.NewGuid(), Content="Good Game",Logo="URL Logo here",Name="Name Of Game",Price=100000,PurchaseDate=new DateTime(),Rating=4.5f,VideoUrl="URL Video here",PublisherId=Publishers[0].Id},
                new Game(){ Id = Guid.NewGuid(), Content="Good Game",Logo="URL Logo here",Name="Name Of Game",Price=100000,PurchaseDate=new DateTime(),Rating=4.5f,VideoUrl="URL Video here",PublisherId=Publishers[1].Id},
                new Game(){ Id = Guid.NewGuid(), Content="Good Game",Logo="URL Logo here",Name="Name Of Game",Price=100000,PurchaseDate=new DateTime(),Rating=4.5f,VideoUrl="URL Video here" ,PublisherId=Publishers[2].Id},
                new Game(){ Id = Guid.NewGuid(), Content="Good Game",Logo="URL Logo here",Name="Name Of Game",Price=100000,PurchaseDate=new DateTime(),Rating=4.5f,VideoUrl="URL Video here" ,PublisherId=Publishers[3].Id},
                new Game(){ Id = Guid.NewGuid(), Content="Good Game",Logo="URL Logo here",Name="Name Of Game",Price=100000,PurchaseDate=new DateTime(),Rating=4.5f,VideoUrl="URL Video here" ,PublisherId=Publishers[4].Id},
            };
            builder.Entity<Game>().HasData(Games);

            var CodeFrees = new[]
            {
                new CodeFree(){ Id = Guid.NewGuid(), Code = (Guid.NewGuid()).ToString(),GameId= Games[0].Id},
                new CodeFree(){ Id = Guid.NewGuid(), Code = (Guid.NewGuid()).ToString(),GameId= Games[1].Id},
                new CodeFree(){ Id = Guid.NewGuid(), Code = (Guid.NewGuid()).ToString(),GameId= Games[2].Id},
                new CodeFree(){ Id = Guid.NewGuid(), Code = (Guid.NewGuid()).ToString(),GameId= Games[3].Id},
                new CodeFree(){ Id = Guid.NewGuid(), Code = (Guid.NewGuid()).ToString(),GameId= Games[4].Id},
            };
            builder.Entity<CodeFree>().HasData(CodeFrees);

           

        }

    }
}
