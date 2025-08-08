using System.Security.Cryptography.X509Certificates;

namespace prjInventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product> //Anonymouse types
            {
                new Product{Id = 1, Name ="Water", quantity = 10, price = 50},
                new Product{Id = 2, Name ="Kfc", quantity = 23, price = 150},
                new Product{Id = 3, Name ="Pizza", quantity = 12, price = 30},
            };
            //LinQ to select product names & prices
            var productNamesAndPrice = products.Select(p => new { p.Name, p.price, p.quantity }).ToList();

            //Iterate anonymouse types to print results
            foreach (var product in productNamesAndPrice)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.price}, Quantity: {product.quantity}");
            }

            decimal totalValue = products.CalculateTotalValue();
            Console.WriteLine($"Total Value: {totalValue}");

            //Method to check the low stock product
            List<Product> lowStockProducts = products.FilterLowStockProducts(10);
            foreach (var product in lowStockProducts)
            {
                Console.WriteLine($"Low in stock: {product.Name}");
            }
        }
    }
}
/* Reference List: 
   Microsoft Learn, 2025. Anonymouse types. [Online] Available at: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/anonymous-types [Accessed on: 08 August 2025]
   C# corner, 2023. Extention methods. [Online] Available at: https://www.c-sharpcorner.com/UploadFile/puranindia/extension-methods-in-C-Sharp-3-0 [Accessed on: 08 August 2025]
 */
