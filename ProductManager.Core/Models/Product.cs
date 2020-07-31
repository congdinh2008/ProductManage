using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManager.Core.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }


        public virtual Category Category { get; set; }
    }
}
