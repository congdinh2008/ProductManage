using System.Collections.Generic;
using ProductManager.Core.Models;

namespace ProductManage.Controllers
{
    public class ProductViewModel
    {
        public Product ProductDetails { get; set; }

        public ICollection<Product> SanPhamLienQuan { get; set; }
    }
}