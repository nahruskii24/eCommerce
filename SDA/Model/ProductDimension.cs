using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA.Model
{
    public class ProductDimension
    {
        [Key]
        public string Id { get; set; }
        public string ImageSrc { get; set; }
        public string Color { get; set; }
        public int Size { get; set; }
        public int QuantityAvailable { get; set; }
    }
}
