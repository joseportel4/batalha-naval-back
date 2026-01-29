namespace BatalhaNaval.Domain.Exceptions;

public class InvalidCoordinateException : Exception
{
    public InvalidCoordinateException(string message) : base(message)
    {
    }
}