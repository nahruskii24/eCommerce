using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using SDA.Model;

namespace Store.Legacy.Models
{
    public class AccountModel
    {
        public string Id { get; set; }

        public string Type { get; set; }

        [Required]
        [Display(Name = "First Name:")]
        [StringLength(30, ErrorMessage = "Input does not meet min {2}/max {1} requirements ", MinimumLength = 3)]
        [RegularExpression("^[A-Z][a-zA-Z]*$", ErrorMessage = "Invalid format: No numbers or special characters ")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name:")]
        [StringLength(30, ErrorMessage = "Input does not meet min {2}/max {1} requirements ", MinimumLength = 3)]
        [RegularExpression("^[A-Z][a-zA-Z]*$", ErrorMessage = "Invalid format: No numbers or special characters ")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email:")]
        [StringLength(50, ErrorMessage = "Input does not meet min{1}/max{0}Characters bro", MinimumLength = 5)]
        [DataType(DataType.EmailAddress, ErrorMessage = "please enter a valid email address")]
        public string Email { get; set; }

        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        public DateTime DateCreated { get; set; }

        public string ValidationCode { get; set; }

        [Display(Name = "Password:")]
        [StringLength(20, ErrorMessage = "Input does not meet min {2}/max {1} requirements ", MinimumLength = 3)]
        [DataType(DataType.Password)]//validation formatting password
        [RegularExpression("(?=.*[a-z])(?=.*[A-Z])(?=.*)(?=.*[^a-zA-Z]).{6,20}$", ErrorMessage = "Invalid format: Passwords are 6-20 characters and require at least 1 uppercase letter and 1 number ")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Verify Password:")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]//we want this password to match Password property
        public string PasswordVerify { get; set; }
    }

    public class LoginModel
    {
        [Required]
        [Display(Name = "Email:")]
        [StringLength(50, ErrorMessage = "Input does not meet min{1}/max{0}characters", MinimumLength = 5)]
        [DataType(DataType.EmailAddress, ErrorMessage = "please enter a valid email address")]
        public string Email { get; set; }

        [Display(Name = "Password:")]
        [StringLength(20, ErrorMessage = "Input does not meet min {2}/max {1} requirements ", MinimumLength = 3)]
        [DataType(DataType.Password)]//validation formatting password
        [RegularExpression("(?=.*[a-z])(?=.*[A-Z])(?=.*)(?=.*[^a-zA-Z]).{6,20}$", ErrorMessage = "Invalid format: Passwords are 6-20 characters and require at least 1 uppercase letter and 1 number ")]
        public string Password { get; set; }
    }
}