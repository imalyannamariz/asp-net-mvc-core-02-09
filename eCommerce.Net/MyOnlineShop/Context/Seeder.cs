﻿using MyOnlineShop.DataAccess.Context;
using MyOnlineShop.DataAccess.Models;
using MyOnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOnlineShop.Context
{
    public class Seeder
    {
        public static void Initialize(OnlineShopContext context)
        {
            context.Database.EnsureCreated();

            //var customer = new Customer() 
            //{
            //    FirstName = "Jok",
            //    LastName = "Garcia",
            //    Email = "jok@email.com",
            //    ContactNumber = "888777",
            //    IsActive = true
            //};

            //context.Customers.Add(customer);
            //context.SaveChanges();

            //var customer2 = new Customer()
            //{
            //    FirstName = "Lebron",
            //    LastName = "James",
            //    Email = "lbj@email.com",
            //    ContactNumber = "31231231",
            //};

            //context.Customers.Add(customer2);
            //context.SaveChanges();

            //var product = new Product()
            //{
            //    ProductName = "Laptop",
            //    ProductDescription = "A laptop computer is a portable personal computer powered by a battery, or an AC cord plugged into an electrical outlet, which is also used to charge the battery.",
            //    Amount = 50000,
            //    Category = "Computer",
            //    CreatedBy = "Alyanna Cantos",
            //    CreatedDate = DateTime.Now
            //};

            //context.Products.Add(product);
            //context.SaveChanges();
        }
    }
}
