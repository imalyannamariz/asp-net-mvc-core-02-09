using MyOnlineShop.DataAccess.Models;
using System.Collections.Generic;

namespace MyOnlineShop.DataAccess.Repository
{
    public interface IOnlineShopRepository
    {
        Customer AddCustomer(Customer customer);
        Customer DeleteCustomer(Customer customer);
        IEnumerable<Customer> GetCustomers();
        IEnumerable<Customer> SearchCustomer(int Id);
        IEnumerable<Customer> SearchCustomer(string search);
        Customer UpdateCustomer(Customer customer);

        Product AddProduct(Product product);
        IEnumerable<Product> GetProducts();
        IEnumerable<Product> SearchProduct(int id);
        IEnumerable<Product> SearchProduct(string search);
        Product EditProduct(Product product);
        Product DeleteProduct(Product product)
    }
}