using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using GameStore.Model;
namespace GameStore.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CodeFree> CodeFrees { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<UserGame> UserGames { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {


            base.OnModelCreating(builder);
            builder.Entity<UserGame>()
           .HasKey(t => new { t.UserId, t.GameId });
            builder.Entity<Publisher>()
           .HasMany(p => p.Games)
           .WithOne(p => p.Publisher);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            //seed data 
            var deviceCategorys = new[]
            {
                new CodeFree(){ Id = Guid.NewGuid(), Code = "Monitor"},
                new CodeFree(){ Id = Guid.NewGuid(), Code = "Keyboard"},
                new CodeFree(){ Id = Guid.NewGuid(), Code = "Computer"},
                new CodeFree(){ Id = Guid.NewGuid(), Code = "VGA cable"},
                new CodeFree(){ Id = Guid.NewGuid(), Code = "Power cable"},
            };

            builder.Entity<CodeFree>().HasData(deviceCategorys);

        }

    }
}
