using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.ToTable("Author");

        builder.HasKey(a => a.Id);

        builder.Property(a => a.Name).IsRequired().HasColumnName("name");
        builder.Property(a => a.Surname).IsRequired().HasColumnName("surname");
        builder.Property(a => a.Age).IsRequired().HasColumnName("age");
        builder.Property(a => a.CreatedDate).HasColumnName("created_date");
        builder.Property(a => a.UpdatedDate).HasColumnName("updated_date");
        builder.HasMany(a => a.Articles);
    }
}


