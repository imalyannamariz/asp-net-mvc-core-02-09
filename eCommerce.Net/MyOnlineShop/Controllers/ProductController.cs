using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.DataAccess.Models;
using MyOnlineShop.DataAccess.Repository;
using MyOnlineShop.DataAccess.ViewModels;

namespace MyOnlineShop.Controllers
{
    public class ProductController : Controller
    {
        IOnlineShopRepository onlineShopRepository;
        public ProductController(IOnlineShopRepository _onlineShopRepository)
        {
            onlineShopRepository = _onlineShopRepository;
        }

        // GET: Product
        public ActionResult Index()
        {
            var viewModel = new ProductViewModel();

            var products = onlineShopRepository.GetProducts();

            viewModel.Products = products;
            return View();
        }

        // GET: Product/Details/5
        public ActionResult GetProductDetails(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult CreateProduct()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [Route("AddProduct/{Product}")]
        public IActionResult CreateProduct(Product product)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    onlineShopRepository.AddProduct(product);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult EditProduct(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditProduct(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult DeleteProduct(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteProduct(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}