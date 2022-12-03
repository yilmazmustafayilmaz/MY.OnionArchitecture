using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class ArticleConfiguration : IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        builder.ToTable("Article");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.AuthorId).HasColumnName("auther_Id");
        builder.Property(x => x.Title).IsRequired().HasColumnName("title");
        builder.Property(x => x.Description).IsRequired().HasColumnName("description");
        builder.Property(x => x.CreatedDate).HasColumnName("created_date");
        builder.Property(x => x.UpdatedDate).HasColumnName("updated_date");
        builder.HasOne(x => x.Author);
    }
}


