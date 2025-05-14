using Jantuscara.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jantuscara.Infrastructure.Persistence.Mappings
{
    public class TasterConfiguration : BaseEntityConfiguration<Taster>
    {
        public override void Configure(EntityTypeBuilder<Taster> builder)
        {
            base.Configure(builder);

            builder.ToTable("tasters");

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .IsRequired();

            builder.Property(x => x.ContractDate)
                .HasColumnName("contract_date")
                .IsRequired();
        }
    }
}
