using static linq.Queries.QuerySyntax;

public class Program
{
    public static void Main()
    {

        // Working with Enumerables
        // Print(GetOddNumbers());
        // Print(GetLongestNamesWithLetter("l"));
        // Print(MakeAllUpper());
        // Print(MakeUpperWithLetter("y"));

        // Working with single values
        Print(CountOfNamesContainingLetter("l"));
    }
}