namespace Application.Exceptions;

public class NotFoundUserException : Exception
{
    public NotFoundUserException() : base("Kullanýcý bulunamadý") { }

    public NotFoundUserException(string? message) : base(message) { }

    public NotFoundUserException(string? message, Exception? innerException) : base(message, innerException) { }
}


