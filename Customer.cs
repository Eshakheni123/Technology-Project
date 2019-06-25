//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JigneshWebApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Customer
    {
      
        
        public int CustomerId { get; set; }


        [Required]
        [Display(Name = "Enter UserName")]
        public string UserName { get; set; }
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).*$",
                     ErrorMessage = "Enter Number,small and upper letter for password")]
        public string Password { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]
        public string Address { get; set; }

        [Required(ErrorMessage = "Enter 10 digit numeric phone number.")]
        [RegularExpression(@"\d{10}",
                       ErrorMessage = "Phone is not valid")]
        public string Phone { get; set; }
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                         ErrorMessage = "Email is not valid")]
        public string Email { get; set; }
        [Required]
        public string City { get; set; }
    }
}
