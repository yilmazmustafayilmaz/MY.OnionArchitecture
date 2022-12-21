using Domain.Comman;
using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Persistence.Configurations;

namespace Persistence.Contexts;

public class Context : IdentityDbContext<AppUser, AppRole, Guid>
{
    public Context(DbContextOptions<Context> options) : base(options) { }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Article> Articles { get; set; }
    public DbSet<BaseFile> BaseFiles { get; set; }
    public DbSet<AuthorImageFile> AuthorImageFiles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AuthorConfiguration());
        modelBuilder.ApplyConfiguration(new ArticleConfiguration());
        base.OnModelCreating(modelBuilder);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var modifiedEntries = ChangeTracker
            .Entries().Where(x => x.Entity is BaseEntity && x.State == EntityState.Modified);

        foreach (var modifiedEntry in modifiedEntries)
        {
            if (modifiedEntry.State == EntityState.Modified)
                ((IUpdatedDate)modifiedEntry.Entity).UpdatedDate = DateTime.UtcNow;
        }

        var addedEntries = ChangeTracker
            .Entries().Where(x => x.Entity is BaseEntity && x.State == EntityState.Added);

        foreach (var addedEntry in addedEntries)
        {
            if (addedEntry.State == EntityState.Added)
                ((ICreatedDate)addedEntry.Entity).CreatedDate = DateTime.UtcNow;
        }

        return base.SaveChangesAsync(cancellationToken);
    }
}


