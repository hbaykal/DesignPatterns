using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();
            var builder = new NewCustomerProductBuilder();
            productManager.GenerateProduct(builder);
            var model = builder.GetProduct();

            Console.WriteLine(model.CategoryName);
            Console.WriteLine(model.ProductName);
            Console.WriteLine(model.UnitPrice);
            Console.WriteLine(model.DiscountedPrice);

            Console.ReadLine();
        }
    }
}
