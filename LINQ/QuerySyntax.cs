namespace linq.Queries;

public class QuerySyntax
{
    private int[] _nums { get; set; }

    public QuerySyntax(int[] data) => _nums = data;

    public void Print<T>(List<T> list)
    {
        foreach (var i in list)
        {
            Console.WriteLine(i);
        }
    }

    public List<int> getOddNumbers()
    {
        var query = (from n in _nums
                     where n % 2 == 1
                     select n
                    );

        return query.ToList();
    }

}