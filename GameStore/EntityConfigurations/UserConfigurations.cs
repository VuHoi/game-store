using GameStore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.EntityConfigurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {

        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
        {
            builder
                   .HasOne(a => a.ImageUser)
                   .WithOne(p => p.User)
                   .HasForeignKey<User>(a => a.ImageUserId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
