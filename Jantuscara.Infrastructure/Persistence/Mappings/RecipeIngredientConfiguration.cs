using Jantuscara.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jantuscara.Infrastructure.Persistence.Mappings
{
    public class RecipeIngredientConfiguration : BaseEntityConfiguration<RecipeIngredient>
    {
        public override void Configure(EntityTypeBuilder<RecipeIngredient> builder)
        {
            base.Configure(builder);

            builder.ToTable("recipe_ingredients");

            builder.Property(x => x.RecipeId)
                .HasColumnName("recipe_id")
                .IsRequired();

            builder.Property(x => x.IngredientId)
                .HasColumnName("ingredient_id")
                .IsRequired();

            builder.Property(x => x.Quantity)
                .HasColumnName("quantity")
                .IsRequired();

            builder.Property(x => x.Unit)
                .HasColumnName("unit")
                .IsRequired();
        }
    }
}
