using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SDA.Model
{
    public class Account
    {
        [Key]
        public string Id { get; set; }
        public string Type { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
        public bool ValidationSuccessful { get; set; }
        public string ValidationCode { get; set; }
        public string PasswordHashed { get; set; }
        public string PasswordSalt { get; set; }
        public virtual IEnumerable<Address> Addresses { get; set; }
        public virtual IEnumerable<Order> Orders { get; set; }
    }
}
