using GameStore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.EntityConfigurations
{
    public class CategoryConfigurations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
                   builder
                   .HasOne(a => a.ImageCategory )
                   .WithOne(p => p.Category)
                   .HasForeignKey<Category>(a => a.ImageCategoryId)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
