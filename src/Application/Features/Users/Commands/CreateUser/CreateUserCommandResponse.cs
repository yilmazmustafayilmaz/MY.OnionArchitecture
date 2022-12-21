namespace Application.Features.Users.Commands.CreateUser;

public record CreateUserCommandResponse
{
    public bool Succeeded { get; set; }
    public string Message { get; set; }
}
