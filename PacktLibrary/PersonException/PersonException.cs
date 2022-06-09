namespace Packt.Shared;

// dirived from Microsoft's types
public class PersonException : Exception
{
    public PersonException(): base(){}

    public PersonException(string message) : base(message) { }

    public PersonException(string message, Exception innerException): base(message, innerException) { }
}