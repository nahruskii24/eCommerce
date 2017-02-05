using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA.Model
{
    public class OrderItem
    {
        [Key]
        public string Id { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public ProductDimension ProductDimension { get; set; }
        public decimal DiscountPrice { get; set; }
        public decimal OriginalPrice { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
