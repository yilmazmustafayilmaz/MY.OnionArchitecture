namespace Application.Features.Authors.Queries.GetByIdAuthor;

public record GetByIdAuthorQueryResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}


