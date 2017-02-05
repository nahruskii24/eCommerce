
using System.ComponentModel.DataAnnotations;

namespace SDA.Model
{
    public class Address
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string AddressType { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string Attention { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string StateOrProvidence { get; set; }
        public string Zip { get; set; }
    }
}