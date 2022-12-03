using Domain.Comman;

namespace Domain.Entities;

public class Author : BaseEntity, ICreatedDate, IUpdatedDate
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

    public virtual ICollection<Article> Articles { get; set; }
}


