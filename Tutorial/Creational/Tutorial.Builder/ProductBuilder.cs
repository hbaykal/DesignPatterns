using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Builder
{
    public abstract class ProductBuilder
    {
        public abstract void GetProductData();
        public abstract void ApplyDiscount();
        public abstract ProductViewModel GetProduct();
    }

    public class NewCustomerProductBuilder : ProductBuilder
    {
        ProductViewModel product = new ProductViewModel();
        public override void ApplyDiscount()
        {
            product.DiscountedPrice = product.UnitPrice * (decimal)0.9;
            product.IsDiscount = true;
        }

        public override ProductViewModel GetProduct()
        {
            return product;
        }

        public override void GetProductData()
        {
            product.Id = 22;
            product.CategoryName = "Clothes";
            product.ProductName = "Jeans";
            product.UnitPrice = 35;
        }
    }

    public class OldCustomerProductBuilder : ProductBuilder
    {
        ProductViewModel product = new ProductViewModel();
        public override void ApplyDiscount()
        {
        }

        public override ProductViewModel GetProduct()
        {
            return product;
        }

        public override void GetProductData()
        {
            product.Id = 22;
            product.CategoryName = "Clothes";
            product.ProductName = "Jeans";
            product.UnitPrice = 35;
        }
    }
}
