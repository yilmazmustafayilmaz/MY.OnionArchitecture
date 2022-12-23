namespace Application.Exceptions;

public class AuthenticationException : Exception
{
    public AuthenticationException() : base("Kimlik doðrulama hatasý") { }

    public AuthenticationException(string? message) : base(message) { }

    public AuthenticationException(string? message, Exception? innerException) : base(message, innerException) { }
}


