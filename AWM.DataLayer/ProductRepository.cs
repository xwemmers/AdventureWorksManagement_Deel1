using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWM.DataLayer
{
    public class ProductRepository
    {
        AdventureWorksEntities ctx = new AdventureWorksEntities();

        public List<Product> GetAllProducts()
        {
            return ctx.Products.ToList();
        }
    }
}
