using Jantuscara.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jantuscara.Infrastructure.Persistence.Mappings
{
    public class IngredientConfiguration : BaseEntityConfiguration<Ingredient>
    {
        public override void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            base.Configure(builder);

            builder.ToTable("ingredients");

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .IsRequired();
        }
    }
}
