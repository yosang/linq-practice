using static linq.Queries.QuerySyntax;

public class Program
{
    public static void Main()
    {
        // Working with Numbers
        // Print(GetXNumbers(5));
        // Print(SkipXFirstNumbers(3));
        // Print(ReverseNumbers());
        // Print(GetNumberAtIndex(2));
        // Print(GetLowestNumber());
        // Print(GetHighestNumber());
        // Print(GetCountOfNumbers());
        // Print(GetSumOfNumbers());
        // Print(GetMinNumber());
        Print(IsXInThere(5)); // true
        Print(IsXInThere(20)); // false

        // Working with Strings
        // Enumerables
        // Print(GetOddNumbers());
        // Print(GetLongestNamesWithLetter("l"));
        // Print(MakeAllUpper());
        // Print(MakeUpperWithLetter("y"));

        // Single values
        // Print(CountOfNamesContainingLetter("l"));
        // Print(FirstNameAlphabetically());
        // Print(LastNameAlphabetically());
    }
}