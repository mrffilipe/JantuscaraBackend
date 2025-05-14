using Jantuscara.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jantuscara.Infrastructure.Persistence.Mappings
{
    public class RecipeTasterConfiguration : BaseEntityConfiguration<RecipeTaster>
    {
        public override void Configure(EntityTypeBuilder<RecipeTaster> builder)
        {
            base.Configure(builder);

            builder.ToTable("recipe_tasters");

            builder.Property(x => x.RecipeId)
                .HasColumnName("recipe_id")
                .IsRequired();

            builder.Property(x => x.TasterId)
                .HasColumnName("taster_id")
                .IsRequired();
        }
    }
}
