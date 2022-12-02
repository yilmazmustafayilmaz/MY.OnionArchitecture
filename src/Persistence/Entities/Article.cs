using Persistence.Comman;

namespace Persistence.Entities;

public class Article : BaseEntity, ICreatedDate, IUpdatedDate
{
    public Guid AuthorId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

    public Author Author { get; set; }
}


