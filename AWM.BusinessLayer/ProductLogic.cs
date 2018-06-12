using AWM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWM.BusinessLayer
{
    public class ProductLogic
    {
        ProductRepository pr = new ProductRepository();

        public List<Product> GetAllProducts()
        {
            return pr.GetAllProducts();
        }
    }
}
