using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCL
{
    public class Repository
    {
         public Product GetProductByID(int ID)
        {

            return Products.FirstOrDefault(p => p.ProductID == ID);

        }

        List<Product> Products = new List<Product>
        {

            new Product {ProductID = 1, ProductName="azucar", UnitPrice=10, UnitsInStock = 20 },
            new Product {ProductID = 2, ProductName="Leche", UnitPrice=10, UnitsInStock = 20 },
            new Product {ProductID = 3, ProductName="Queso", UnitPrice=10, UnitsInStock = 20 },
            new Product {ProductID = 4, ProductName="frijol", UnitPrice=10, UnitsInStock = 20 },
            new Product {ProductID = 5, ProductName="mayonesa", UnitPrice=10, UnitsInStock = 20 },
            new Product {ProductID = 6, ProductName="cafe", UnitPrice=10, UnitsInStock = 20 },

        };
    }
}
