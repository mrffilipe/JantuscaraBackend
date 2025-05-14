using Jantuscara.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jantuscara.Infrastructure.Persistence.Mappings
{
    public class EditorConfiguration : BaseEntityConfiguration<Editor>
    {
        public override void Configure(EntityTypeBuilder<Editor> builder)
        {
            base.Configure(builder);

            builder.ToTable("editors");

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .IsRequired();

            builder.Property(x => x.ContractDate)
                .HasColumnName("contract_date")
                .IsRequired();
        }
    }
}
