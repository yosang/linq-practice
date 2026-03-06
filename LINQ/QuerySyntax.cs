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

    // Filtering
    public static List<int> GetOddNumbers() => (from n in Numbers where n % 2 == 1 select n).ToList();
    public static List<string> GetShortNames() => (from s in Names where s.Length <= 3 select s).ToList();

    // Partinioning
    public static List<int> GetXNumbers(int x) => (from n in Numbers select n).Take(x).ToList(); // Get X numbers
    public static List<int> GetNumbersBelowFive() => (from n in Numbers select n).TakeWhile((n) => n < 5).ToList(); // Get numbers for as long as n < 5
    public static List<int> SkipXFirstNumbers(int x) => (from n in Numbers select n).Skip(x).ToList(); // Skip the first X numbers
    public static List<int> ReverseNumbers() => (from n in Numbers select n).Reverse().ToList(); // Returns a reversed list of numbers

    // Element
    public static int GetNumberAtIndex(int index) => (from n in Numbers select n).ElementAt(index); // Get a number at a specific index
    public static int GetLowestNumber() => (from n in Numbers orderby n select n).First(); // Gets the first number of an ordered array
    public static int GetHighestNumber() => (from n in Numbers orderby n select n).Last(); // Gets the last number of an ordered array

    // Aggregation
    public static int GetCountOfNumbers() => (from n in Numbers select n).Count(); // Gets the amount of numbers in the array
    public static int GetSumOfNumbers() => (from n in Numbers select n).Sum(); // Sums up the numbers in the array
    public static int GetMinNumber() => (from n in Numbers select n).Min(); // Has its own Min method
    public static int CountOfNamesContainingLetter(string l) => (from s in Names where s.Contains(l) select s).Count();

    // Quantifiers
    public static bool IsXInThere(int x) => (from n in Numbers select n).Any(n => n == x); // Any returns a bool, takes a predicates that checks wether ANY of the items in the source satisfies the condition

    // Ordering (sorting)
    public static List<string> GetLongestNamesWithLetter(string l) => (from s in Names
                                                                       where s.ToLower().Contains(l.Trim().ToLower())
                                                                       orderby s.Length
                                                                       select s).ToList();
    public static List<string> GetLongestNameWithLetterDescending(string l) => (
                                                                        from s in Names
                                                                        where s.ToLower().Contains(l.Trim().ToLower())
                                                                        orderby s.Length descending
                                                                        select s).ToList();

    // Projection (transformation)
    public static List<string> MakeAllUpper() => (from s in Names select s.ToUpper()).ToList();
    public static List<string> MakeUpperWithLetter(string l) => (from s in Names
                                                                 where s.ToLower().StartsWith(l.Trim().ToLower())
                                                                 select s.ToUpper()).ToList();

}