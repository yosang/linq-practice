using linq.Queries;

public class Program
{
    public static void Main()
    {
        var instance = new QuerySyntax();

        instance.Numbers = new[] { 1, 2, 3, 4, 5 };

        instance.Print(instance.getOddNumbers());

        // var names = new QuerySyntax(new[])
    }
}