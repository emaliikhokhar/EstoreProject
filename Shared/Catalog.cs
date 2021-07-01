using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estore.Server.Models
{
    public class Catalog
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public Product GetProduct(int id) =>
            Products.SingleOrDefault(p => p.Id == id);
    }
}
