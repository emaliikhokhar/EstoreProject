﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Estore.Server.Models
{
    public partial class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
    }
}
