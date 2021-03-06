namespace Packt.Shared;

public class PersonComparer : IComparer<Person>
{
    public int Compare(Person? x, Person? y)
    {
        if(x == null || y == null)
        {
            return 0;
        }
        // Compare the Name Lengths...
        int result = x.Name.Length.CompareTo(y.Name.Length);

        // ... if they are equal...
        if (result == 0)
        {
            // ...then compare to by the Names...
            return x.Name.CompareTo(y.Name);
        }
        else // result will be -1 or 1
        {
            // ...otherwise compare by the Lengths
            return result;
        }
    }
}
