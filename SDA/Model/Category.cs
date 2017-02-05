using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA.Model
{
    public class Category
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string ParentId { get; set; }
        public int Level { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
