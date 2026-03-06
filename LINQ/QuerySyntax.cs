namespace linq.Queries;

public class QuerySyntax
{
    private static int[] Numbers { get; set; } = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
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

    // Cherrypicking and ordering
    public static List<int> GetXNumbers(int x) => (from n in Numbers select n).Take(x).ToList(); // Get X numbers
    public static List<int> SkipXFirstNumbers(int x) => (from n in Numbers select n).Skip(x).ToList(); // Skip the first X numbers
    public static List<int> ReverseNumbers() => (from n in Numbers select n).Reverse().ToList(); // Returns a reversed list of numbers

    // Element operators
    public static int GetNumberAtIndex(int index) => (from n in Numbers select n).ElementAt(index); // Get a number at a specific index
    public static int GetLowestNumber() => (from n in Numbers orderby n select n).First(); // Gets the first number of an ordered array
    public static int GetHighestNumber() => (from n in Numbers orderby n select n).Last(); // Gets the last number of an ordered array


    // Aggregation operators
    public static int GetCountOfNumbers() => (from n in Numbers select n).Count(); // Gets the amount of numbers in the array
    public static int GetSumOfNumbers() => (from n in Numbers select n).Sum(); // Sums up the numbers in the array
    public static int GetMinNumber() => (from n in Numbers select n).Min(); // Has its own Min method

    // Quantifiers
    public static bool IsXInThere(int x) => (from n in Numbers select n).Any(n => n == x); // Any returns a bool, takes a predicates that checks wether ANY of the items in the source satisfies the condition

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
    // OrderBy orders ascending by default, so in order to get the first / or last name by an alphabetically ordere sequence we can use
    // First() and Last()
    public static string FirstNameAlphabetically() => (from s in Names orderby s select s).First();
    public static string LastNameAlphabetically() => (from s in Names orderby s select s).Last();
}