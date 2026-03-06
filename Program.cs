using linq.Queries;

public class Program
{
    public static void Main()
    {
        var instance = new QuerySyntax(new[] { 1, 2, 3, 4, 5 });
        var odds = instance.getOddNumbers();
        instance.Print(odds);
    }
}