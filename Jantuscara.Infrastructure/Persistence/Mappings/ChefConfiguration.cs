using Jantuscara.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jantuscara.Infrastructure.Persistence.Mappings
{
    public class ChefConfiguration : BaseEntityConfiguration<Chef>
    {
        public override void Configure(EntityTypeBuilder<Chef> builder)
        {
            base.Configure(builder);

            builder.ToTable("chefs");

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .IsRequired();

            builder.Property(x => x.TradeName)
                .HasColumnName("trade_name")
                .IsRequired();

            builder.Property(x => x.ContractDate)
                .HasColumnName("contract_date")
                .IsRequired();

            builder.Property(x => x.RestaurantId)
                .HasColumnName("restaurant_id")
                .IsRequired();
        }
    }
}