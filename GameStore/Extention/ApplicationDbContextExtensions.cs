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

        }

        public static void ChangeIdentityTableNames(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(e => e.ToTable("User"));
            modelBuilder.Entity<ApplicationRole>(e => e.ToTable("Role"));
            modelBuilder.Entity<IdentityUserRole<Guid>>(e => e.ToTable("UserRole"));
            modelBuilder.Entity<IdentityUserClaim<Guid>>(e => e.ToTable("UserClaim"));
            modelBuilder.Entity<IdentityUserLogin<Guid>>(e => e.ToTable("UserLogin"));
        }
    }
}
