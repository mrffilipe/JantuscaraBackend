using Jantuscara.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jantuscara.Infrastructure.Persistence.Mappings
{
    public class BookConfiguration : BaseEntityConfiguration<Book>
    {
        public override void Configure(EntityTypeBuilder<Book> builder)
        {
            base.Configure(builder);

            builder.ToTable("books");

            builder.Property(x => x.Title)
                .HasColumnName("title")
                .IsRequired();

            builder.Property(x => x.ISBN)
                .HasColumnName("isbn")
                .IsRequired();

            builder.Property(x => x.EditorId)
                .HasColumnName("editor_id")
                .IsRequired();
        }
    }
}
