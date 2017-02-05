using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA.Model
{
    public class Order
    {
        [Key]
        public string Id { get; set; }
        public string Type { get; set; }
        public int OrderNumber { get; set; }
        public int TrackingNumber { get; set; }
        public string Status { get; set; }
        public decimal Total { get; set; }
        public IEnumerable<OrderItem> Items { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
