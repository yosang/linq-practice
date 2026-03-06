namespace linq.Queries;

public class QuerySyntax
{
    public int[] Numbers { get; set; } = [];
    public string[] Strings { get; set; } = [];

    public void Print<T>(List<T> list)
    {
        foreach (var i in list)
        {
            Console.WriteLine(i);
        }
    }

    public List<int> getOddNumbers()
    {
        var query = (from n in Numbers
                     where n % 2 == 1
                     select n
                    );

        return query.ToList();
    }

}