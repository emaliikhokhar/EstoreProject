using System;
using System.Collections.Generic;

#nullable disable

namespace Estore.Server.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int? Discount { get; set; }
        public string ImageAddress { get; set; }
        public string Category { get; set; }
        public string OwnerId { get; set; }
        public int? Ratings { get; set; }

    }

}
