namespace linq.Queries;

public class QuerySyntax
{
    private static int[] Numbers { get; set; } = new[] { 1, 2, 3, 4, 5 };
    private static string[] Names { get; set; } = new[] { "Harry", "Tom", "Alex", "Christina", "Warren", "Yosmel" };

    public static void Print<T>(List<T> data)
    {
        foreach (var i in data) Console.WriteLine(i);
    }

    public static void Print<T>(T item) => Console.WriteLine(item);

    // Working with numbers
    // A Where condition - Returns a list of each item WHERE the condition is true (number is odd)
    public static List<int> GetOddNumbers() => (from n in Numbers
                                                where n % 2 == 1
                                                select n).ToList();

    // Working with strings
    // Where condition - Returns a list of each item WHERE the letter l is in the string
    // Order by - Sorts each of the items by the string length
    // Select - Projects each element (translates)
    public static List<string> GetLongestNamesWithLetter(string l) => (from s in Names
                                                                       where s.ToLower().Contains(l.Trim().ToLower())
                                                                       orderby s.Length
                                                                       select s).ToList();

    // Make all strings uppercase
    // Select - Only a projection where we make each string upperCase
    public static List<string> MakeAllUpper() => (from s in Names
                                                  select s.ToUpper()).ToList();

    // Make only names starting with specific letter uppercase
    public static List<string> MakeUpperWithLetter(string l) => (from s in Names
                                                                 where s.ToLower().StartsWith(l.Trim().ToLower())
                                                                 select s.ToUpper()).ToList();

    // Returning an integer from a sequence
    public static int CountOfNamesContainingLetter(string l) => (from s in Names
                                                                 where s.Contains(l)
                                                                 select s).Count();
    // Returning the first element of an ordered sequence
    // OrderBy orders ascending by default
}