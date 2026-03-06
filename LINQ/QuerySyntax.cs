namespace linq.Queries;

public class QuerySyntax
{
    private int[] Numbers { get; set; } = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    private string[] Names { get; set; } = { "Harry", "Ari", "Tom", "Alex", "Christina", "Warren", "Yosmel" };

    public void Print<T>(List<T> data)
    {
        foreach (var i in data) Console.WriteLine(i);
    }

    public void Print<T>(T item) => Console.WriteLine(item);

    // Filtering
    public List<int> GetOddNumbers() => (from n in Numbers where n % 2 == 1 select n).ToList();
    public List<string> GetShortNames() => (from s in Names where s.Length == 3 select s).ToList();
    public List<string> GetShortestNames() => (from s in Names where s.Length == Names.Min(n => n.Length) select s).ToList(); // Does the same as above, but here we are doing a suquery to get the name with the shortest length for the where clause

    // Partinioning
    public List<int> GetXNumbers(int x) => (from n in Numbers select n).Take(x).ToList(); // Get X numbers
    public List<int> GetNumbersBelowFive() => (from n in Numbers select n).TakeWhile((n) => n < 5).ToList(); // Get numbers for as long as n < 5
    public List<int> SkipXFirstNumbers(int x) => (from n in Numbers select n).Skip(x).ToList(); // Skip the first X numbers
    public List<int> ReverseNumbers() => (from n in Numbers select n).Reverse().ToList(); // Returns a reversed list of numbers

    // Element
    public int GetNumberAtIndex(int index) => (from n in Numbers select n).ElementAt(index); // Get a number at a specific index
    public int GetLowestNumber() => (from n in Numbers orderby n select n).First(); // Gets the first number of an ordered array
    public int GetHighestNumber() => (from n in Numbers orderby n select n).Last(); // Gets the last number of an ordered array

    // Aggregation
    public int GetCountOfNumbers() => (from n in Numbers select n).Count(); // Gets the amount of numbers in the array
    public int GetSumOfNumbers() => (from n in Numbers select n).Sum(); // Sums up the numbers in the array
    public int GetMinNumber() => (from n in Numbers select n).Min(); // Has its own Min method
    public int CountOfNamesContainingLetter(string l) => (from s in Names where s.Contains(l) select s).Count();

    // Quantifiers
    public bool IsXInThere(int x) => (from n in Numbers select n).Any(n => n == x); // Any returns a bool, takes a predicates that checks wether ANY of the items in the source satisfies the condition

    // Ordering (sorting)
    public List<string> GetLongestNamesWithLetter(string l) => (from s in Names
                                                                where s.ToLower().Contains(l.Trim().ToLower())
                                                                orderby s.Length
                                                                select s
                                                                ).ToList();

    public List<string> GetLongestNameWithLetterDescending(string l) => (
                                                                        from s in Names
                                                                        where s.ToLower().Contains(l.Trim().ToLower())
                                                                        orderby s.Length descending
                                                                        select s
                                                                        ).ToList();

    // Projection (transformation)
    public List<string> MakeAllUpper() => (from s in Names select s.ToUpper()).ToList();

    public List<string> MakeUpperWithLetter(string l) => (from s in Names
                                                          where s.ToLower().StartsWith(l.Trim().ToLower())
                                                          select s.ToUpper()
                                                          ).ToList();

    // let keyword
    // Allows us to introduce a new variable inside the query expression, this does the same as GetShortestNames()
    public List<string> GetShortestnamesV2() => (
                                                from s in Names
                                                let shortestName = Names.Min(e => e.Length)
                                                where s.Length == shortestName
                                                select s
                                                ).ToList();
}