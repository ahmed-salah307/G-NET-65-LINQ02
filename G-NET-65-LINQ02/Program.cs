namespace G_NET_65_LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
             var top3Expensive = ProductList
    .OrderByDescending(p => p.UnitPrice)
    .Take(3);

foreach (var p in top3Expensive)
{
    Console.WriteLine($"Name: {p.ProductName}, Price: {p.UnitPrice}");
}
             
             */
            #endregion
            #region Q2
            /*
             int pageSize = 5;
int pageNumber = 2;

var page2Products = ProductList
    .Skip((pageNumber - 1) * pageSize)
    .Take(pageSize);

foreach (var p in page2Products)
{
    Console.WriteLine(p.ProductName);
}
             
             */
            #endregion
        }
    }
}
