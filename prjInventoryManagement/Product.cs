using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInventoryManagement
{
    public class Product //Custom types
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
    }
    public static class ProductExtention //Extention method
    {
        public static decimal CalculateTotalValue(this List<Product> products)
        {
            //Calculate the total value
            return products.Sum(p => p.quantity * p.price);
        }

        public static List<Product> FilterLowStockProducts(this List<Product> products, int lowStock)
        {
            //Filter products that are low in stock 10 or less
            return products.Where(p => p.quantity <= lowStock).ToList();
        }
    }
}
/* Reference List: 
   C# corner, 2023. Extention methods. [Online] Available at: https://www.c-sharpcorner.com/UploadFile/puranindia/extension-methods-in-C-Sharp-3-0 [Accessed on: 08 August 2025]
   Tutorialspoints, 2025, Explain cutom types. [Online] Available at: https://www.tutorialspoint.com/explain-the-custom-value-types-in-net [Accessed on: 08 August 2025]
   
 */