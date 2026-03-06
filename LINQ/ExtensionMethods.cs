namespace linq.Queries;

public class ExtensionMethods
{
    private int[] Numbers { get; set; } = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    private string[] Names { get; set; } = { "Harry", "Tom", "Alex", "Christina", "Warren", "Yosmel" };

    public void Print<T>(List<T> data)
    {
        foreach (var i in data) Console.WriteLine(i);
    }

    public void Print<T>(T item) => Console.WriteLine(item);

    // Filtering
    public List<int> GetOddNumbers() => Numbers.Where(n => n % 2 == 0).ToList();
    public List<string> GetShortNamesByLenth(int l = 4) => Names.Where(n => n.Length < l).ToList();

    // Partinioning
    public void GetXNumbers(int x) { }
    public void GetNumbersBelowFive() { }
    public void SkipXFirstNumbers(int x) { }
    public void ReverseNumbers() { }

    // Element
    public void GetNumberAtIndex(int index) { }
    public void GetLowestNumber() { }
    public void GetHighestNumber() { }

    // Aggregation
    public void GetCountOfNumbers() { }
    public void GetSumOfNumbers() { }
    public void GetMinNumber() { }
    public void CountOfNamesContainingLetter(string l) { }

    // Quantifiers
    public void IsXInThere(int x) { }

    // Ordering (sorting)
    public void GetLongestNamesWithLetter(string l) { }

    public void GetLongestNameWithLetterDescending(string l) { }


    // Projection (transformation)
    public void MakeAllUpper() { }
    public void MakeUpperWithLetter(string l) { }


}