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
            #region Q3
            /*
             
            var cheapProducts = ProductList
    .OrderBy(p => p.UnitPrice)
    .TakeWhile(p => p.UnitPrice < 25);

foreach (var p in cheapProducts)
{
    Console.WriteLine($"Name: {p.ProductName}, Price: {p.UnitPrice}");
}
             
             */
            #endregion
            #region Q4
            /*
             
             bool allInStock = ProductList
    .Where(p => p.Category == "Seafood")
    .All(p => p.UnitsInStock > 0);

Console.WriteLine($"Are all Seafood products in stock? {allInStock}");
             
             */
            #endregion
            #region Q5

            /*
             
             int[] ids = { 3, 9, 13, 18 };

bool containsNine = ids.Contains(9);

Console.WriteLine($"Contains 9: {containsNine}");
             */

            #endregion
            #region Q6
            /*
             var productGroups = ProductList.GroupBy(p => p.Category);

foreach (var group in productGroups)
{
    Console.WriteLine($"Category: {group.Key}, Count: {group.Count()}");
}
             
             */

            #endregion
            #region Q7

            /*
             
             var categoryNames = ProductList
    .GroupBy(p => p.Category)
    .Select(g => new {
        Category = g.Key,
        ProductNames = g.Select(p => p.ProductName)
    });

foreach (var item in categoryNames)
{
    Console.WriteLine($"Category: {item.Category}");
    foreach (var name in item.ProductNames)
    {
        Console.WriteLine($"  - {name}");
    }
}
             */

            #endregion
            #region Q8
            /*
             
             var categoriesWithManyProducts = ProductList
    .GroupBy(p => p.Category)
    .Where(g => g.Count() > 3)
    .Select(g => g.Key);

foreach (var cat in categoriesWithManyProducts)
{
    Console.WriteLine(cat);
}
             
             */

            #endregion
            #region Q9
            /*
             
             var customerGroups = from c in CustomerList
                     group c by c.Country into g
                     select new {
                         Country = g.Key,
                         Count = g.Count(),
                         TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total)) 
                     };
             
             */
            #endregion
            #region Q10
            /*
             
             int totalUnits = ProductList.Sum(p => p.UnitsInStock);

Console.WriteLine($"Total Units in Stock: {totalUnits}");
             
             */
            #endregion
            #region Q11
            /*
             
             
             decimal cheapestPrice = ProductList.Min(p => p.UnitPrice);
decimal mostExpensivePrice = ProductList.Max(p => p.UnitPrice);

Console.WriteLine($"Cheapest: {cheapestPrice}, Most Expensive: {mostExpensivePrice}");
             
             
             */
            #endregion
            #region Q12

            /*
             
             var categories = ProductList
    .Select(p => p.Category)
    .Distinct();

foreach (var cat in categories)
{
    Console.WriteLine(cat);
}
             
             */
            #endregion
            #region Q13
            /*
             
            int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
int[] setB = { 3, 6, 9, 12, 15, 13 };

var result = setA.Except(setB);

foreach (var id in result)
{
    Console.WriteLine(id);
} 

             */

            #endregion
            #region Q14
            /*
             
             string[] list1 = { "Germany", "France", "UK", "Spain" };
string[] list2 = { "france", "SPAIN", "Italy" };

var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

foreach (var country in result)
{
    Console.WriteLine(country);
}
             */

            #endregion
        }
    }
}
