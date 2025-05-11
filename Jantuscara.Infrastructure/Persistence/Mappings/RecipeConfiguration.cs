using Jantuscara.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jantuscara.Infrastructure.Persistence.Mappings
{
    public class RecipeConfiguration : BaseEntityConfiguration<Recipe>
    {
        public override void Configure(EntityTypeBuilder<Recipe> builder)
        {
            base.Configure(builder);

            builder.ToTable("recipes");

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .IsRequired();

            builder.Property(x => x.CreationDate)
                .HasColumnName("creation_date")
                .IsRequired();

            builder.Property(x => x.ChefId)
                .HasColumnName("chef_id")
                .IsRequired();

            builder.Property(x => x.CategoryId)
                .HasColumnName("category_id")
                .IsRequired();
        }
    }
}