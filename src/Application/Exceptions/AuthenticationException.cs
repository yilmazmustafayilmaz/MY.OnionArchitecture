namespace Application.Exceptions;

public class AuthenticationException : Exception
{
    public AuthenticationException() : base("Kimlik do�rulama hatas�") { }

    public AuthenticationException(string? message) : base(message) { }

    public AuthenticationException(string? message, Exception? innerException) : base(message, innerException) { }
}


