namespace Application.Features.Authors.Commands.CreateAuthor;

public record CreateAuthorCommandResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public DateTime CreatedDate { get; set; }
}

