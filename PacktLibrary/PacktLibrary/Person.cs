using static System.Console;

namespace Packt.Shared;

public class Person : Object
{
    // fields
    public string? Name;
    public DateTime DateOfBirth;
    public List<Person> Children = new();

    // methods
    public void WriteToConsole()
    {
        WriteLine($"{ Name } was born on a { DateOfBirth:dddd}.");
    }
}
