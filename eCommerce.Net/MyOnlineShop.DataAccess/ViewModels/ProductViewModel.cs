using MyOnlineShop.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOnlineShop.DataAccess.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public Product Product { get; set; }
    }
}

