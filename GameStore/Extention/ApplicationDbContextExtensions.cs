using GameStore.EntityConfigurations;
using GameStore.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Extention
{
    public static class ApplicationDbContextExtensions
    {
        public static void ApplyEntityConfigurations(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfigurations());
            modelBuilder.ApplyConfiguration(new CategoryConfigurations());
            modelBuilder.ApplyConfiguration(new GameConfigurations());
            modelBuilder.ApplyConfiguration(new PublisherConfigurations());
            modelBuilder.ApplyConfiguration(new UserGameConfigurations());
            modelBuilder.ApplyConfiguration(new WishGameConfigurations());
            modelBuilder.ApplyConfiguration(new CodeFreeConfigurations());
            modelBuilder.ApplyConfiguration(new CategoryGameConfigurations());
        }

        public static void ChangeIdentityTableNames(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(e => e.ToTable("User"));
            modelBuilder.Entity<ApplicationRole>(e => e.ToTable("Role"));
            modelBuilder.Entity<IdentityUserRole<Guid>>(e => e.ToTable("UserRole"));
            modelBuilder.Entity<IdentityUserClaim<Guid>>(e => e.ToTable("UserClaim"));
            modelBuilder.Entity<IdentityUserLogin<Guid>>(e => e.ToTable("UserLogin"));
        }
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            var Publishers = new[]
         {
                new Publisher(){ Id = Guid.NewGuid(), Name="Name here",Money=10000000,Reliability=5},
                new Publisher(){ Id = Guid.NewGuid(), Name="Name here",Money=10000000,Reliability=5},
                new Publisher(){ Id = Guid.NewGuid(), Name="Name here",Money=10000000,Reliability=5},
                new Publisher(){ Id = Guid.NewGuid(), Name="Name here",Money=10000000,Reliability=5},
                new Publisher(){ Id = Guid.NewGuid(), Name="Name here",Money=10000000,Reliability=5},
                new Publisher(){ Id = Guid.NewGuid(), Name="Name here",Money=10000000,Reliability=5},
            };
            modelBuilder.Entity<Publisher>().HasData(Publishers);

            var Categories = new[]
            {
                new Category(){ Id = Guid.NewGuid(), Image="Url Image Here",Title="Title here"},
                new Category(){ Id = Guid.NewGuid(), Image="Url Image Here",Title="Title here"},
                new Category(){ Id = Guid.NewGuid(), Image="Url Image Here",Title="Title here"},
                new Category(){ Id = Guid.NewGuid(), Image="Url Image Here",Title="Title here"},
                new Category(){ Id = Guid.NewGuid(), Image="Url Image Here",Title="Title here"},
            };
            modelBuilder.Entity<Category>().HasData(Categories);
            var Users = new[]
          {
                new User(){ Id = Guid.NewGuid(), Hobbies="Hobbies",FullName="Full Name",Email="Email@gmail.com",PasswordHash="Thatvuhai_7595",PhoneNumber="93098509238098523",UserName="UserName"},
                new User(){ Id = Guid.NewGuid(), Hobbies="Hobbies",FullName="Full Name",Email="Email1@gmail.com",PasswordHash="Thatvuhai_7595",PhoneNumber="93098509228098523",UserName="UserName1"},
                new User(){ Id = Guid.NewGuid(), Hobbies="Hobbies",FullName="Full Name",Email="Email2@gmail.com",PasswordHash="Thatvuhai_7595",PhoneNumber="93098559238098523",UserName="UserName2"},
                new User(){ Id = Guid.NewGuid(), Hobbies="Hobbies",FullName="Full Name",Email="Email3@gmail.com",PasswordHash="Thatvuhai_7595",PhoneNumber="93098609238098523",UserName="UserName3"},
                new User(){ Id = Guid.NewGuid(), Hobbies="Hobbies",FullName="Full Name",Email="Email4@gmail.com",PasswordHash="Thatvuhai_7595",PhoneNumber="93098509738098523",UserName="UserName4"},
            };
            modelBuilder.Entity<User>().HasData(Users);
            var id = Guid.NewGuid();


            var Games = new[]
          {
                new Game(){ Id = id, Content="Good Game",Logo="URL Logo here",Name="Name Of Game",Price=100000,PurchaseDate=new DateTime(),Rating=4.5f,VideoUrl="URL Video here",PublisherId=Publishers[0].Id },
                new Game(){ Id = Guid.NewGuid(), Content="Good Game",Logo="URL Logo here",Name="Name Of Game",Price=100000,PurchaseDate=new DateTime(),Rating=4.5f,VideoUrl="URL Video here",PublisherId=Publishers[1].Id},
                new Game(){ Id = Guid.NewGuid(), Content="Good Game",Logo="URL Logo here",Name="Name Of Game",Price=100000,PurchaseDate=new DateTime(),Rating=4.5f,VideoUrl="URL Video here" ,PublisherId=Publishers[2].Id},
                new Game(){ Id = Guid.NewGuid(), Content="Good Game",Logo="URL Logo here",Name="Name Of Game",Price=100000,PurchaseDate=new DateTime(),Rating=4.5f,VideoUrl="URL Video here" ,PublisherId=Publishers[3].Id},
                new Game(){ Id = Guid.NewGuid(), Content="Good Game",Logo="URL Logo here",Name="Name Of Game",Price=100000,PurchaseDate=new DateTime(),Rating=4.5f,VideoUrl="URL Video here" ,PublisherId=Publishers[4].Id},
            };
            modelBuilder.Entity<Game>().HasData(Games);

            var UserGames = new[]
            {
                new UserGame(){ UserId = Users[0].Id, GameId=Games[0].Id},
                new UserGame(){ UserId = Users[1].Id, GameId=Games[1].Id },
                new UserGame(){ UserId = Users[2].Id, GameId=Games[2].Id},
                new UserGame(){ UserId = Users[3].Id, GameId=Games[3].Id},
                new UserGame(){ UserId = Users[4].Id, GameId=Games[4].Id},
            };
            modelBuilder.Entity<UserGame>().HasData(UserGames);

            var CodeFrees = new[]
            {
                new CodeFree(){ Id = Guid.NewGuid(), Code = (Guid.NewGuid()).ToString(),GameId= Games[0].Id},
                new CodeFree(){ Id = Guid.NewGuid(), Code = (Guid.NewGuid()).ToString(),GameId= Games[1].Id},
                new CodeFree(){ Id = Guid.NewGuid(), Code = (Guid.NewGuid()).ToString(),GameId= Games[2].Id},
                new CodeFree(){ Id = Guid.NewGuid(), Code = (Guid.NewGuid()).ToString(),GameId= Games[3].Id},
                new CodeFree(){ Id = Guid.NewGuid(), Code = (Guid.NewGuid()).ToString(),GameId= Games[4].Id},
            };
            modelBuilder.Entity<CodeFree>().HasData(CodeFrees);

            var CategoryGames = new[]
           {
                new CategoryGame(){ GameId = Games[0].Id, CategoryId=Categories[0].Id},
                new CategoryGame(){ GameId = Games[1].Id, CategoryId=Categories[1].Id },
                new CategoryGame(){ GameId = Games[2].Id, CategoryId=Categories[2].Id},
                new CategoryGame(){ GameId = Games[3].Id, CategoryId=Categories[3].Id},
                new CategoryGame(){ GameId = Games[4].Id, CategoryId=Categories[4].Id},
            };
            modelBuilder.Entity<CategoryGame>().HasData(CategoryGames);

           


          

            var WishGames = new[]
           {
                new WishGame(){ UserId = Users[0].Id, GameId=Games[0].Id},
                new WishGame(){ UserId = Users[1].Id, GameId=Games[1].Id },
                new WishGame(){ UserId = Users[2].Id, GameId=Games[2].Id},
                new WishGame(){ UserId = Users[3].Id, GameId=Games[3].Id},
                new WishGame(){ UserId = Users[4].Id, GameId=Games[4].Id},
            };
            modelBuilder.Entity<WishGame>().HasData(WishGames);

            var Roles = new[]
           {
                new ApplicationRole(){ Id=Guid.NewGuid(),ConcurrencyStamp="User",Name="User",Description="Limited Permission",NormalizedName="User"},
                new ApplicationRole(){ Id=Guid.NewGuid(),ConcurrencyStamp="Admin",Name="Admin",Description="Full Permission",NormalizedName="Admin" },
            };
            modelBuilder.Entity<ApplicationRole>().HasData(Roles);

        }
    }
}
