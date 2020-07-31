using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductManager.Core.Models;

namespace ProductManage.Controllers
{
    public class ProductCustomerController : Controller
    {
        private readonly ProductDbContext _context;

        public ProductCustomerController(ProductDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        public IActionResult Details(int id)
        {
            var product = _context.Products.Find(id);

            var products = _context.Products.Where(x =>
                x.CategoryId == product.CategoryId &&
                x.Id != product.Id).ToList();
            var productViewModel = new ProductViewModel()
            {
                ProductDetails = product,
                SanPhamLienQuan = products
            };
            return View(productViewModel);
        }

        [AllowAnonymous]
        public IActionResult ListProduct(int categoryId)
        {
            var products = _context.Products.Where(x => x.CategoryId == categoryId).ToList();
            ViewBag.CategoryName = _context.Categories.Find(categoryId).Name;
            return View(products);
        }
    }
}
