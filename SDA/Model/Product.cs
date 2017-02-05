using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA.Model
{
    public class Product
    {
        [Key]
        public string Id { get; set; }
        public string CategoryParentId { get; set; }
        public IEnumerable<ProductDimension> ProductDimension { get; set;}
        public decimal DiscountPrice { get; set; }
        public decimal OriginalPrice { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
