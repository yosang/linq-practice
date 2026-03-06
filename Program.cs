using linq.Queries;

public class Program
{
    public static void Main()
    {
        var em = new ExtensionMethods();

        em.Print(em.GetOddNumbers());
        em.Print(em.GetShortNames());

        var qs = new QuerySyntax();
        // Working with Numbers
        // qs.Print(qs.GetXNumbers(5));
        // qs.Print(qs.SkipXFirstNumbers(3));
        // qs.Print(qs.ReverseNumbers());
        // qs.Print(qs.GetNumberAtIndex(2));
        // qs.Print(qs.GetLowestNumber());
        // qs.Print(qs.GetHighestNumber());
        // qs.Print(qs.GetCountOfNumbers());
        // qs.Print(qs.GetSumOfNumbers());
        // qs.Print(qs.GetMinNumber());
        // qs.Print(qs.IsXInThere(5)); // true
        // qs.Print(qs.IsXInThere(20)); // false
        // qs.Print(qs.GetNumbersBelowFive());

        // Working with Strings
        // Enumerables
        // qs.Print(qs.GetOddNumbers());
        // qs.Print(qs.GetLongestNamesWithLetter("l"));
        // qs.Print(qs.GetLongestNameWithLetterDescending("l"));
        // qs.Print(qs.MakeAllUpper());
        // qs.Print(qs.MakeUpperWithLetter("y"));
        // qs.Print(qs.GetShortNames());

        // Single values
        // qs.Print(qs.CountOfNamesContainingLetter("l"));
    }
}