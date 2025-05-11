using Jantuscara.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jantuscara.Infrastructure.Persistence.Mappings
{
    public class RestaurantConfiguration : BaseEntityConfiguration<Restaurant>
    {
        public override void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            base.Configure(builder);

            builder.ToTable("restaurants");

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .IsRequired();

            builder.Property(x => x.Resume)
                .HasColumnName("resume")
                .IsRequired();
        }
    }
}
