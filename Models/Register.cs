using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace LabNumber21.Models
{
    [Bind, Register]
    public class Register : Attribute
    {
        [Required(ErrorMessage = "Please enter First Name")]
        [Display(Name = "First Name:")]
        public string FirstName { get; set; }
        

        [Display(Name = "Last Name:")]
        [Required(ErrorMessage = "Please enter Last Name")]
        public string LastName { get; set; }
        

        [Display(Name = "E-mail:")]
        [Required(ErrorMessage = "Please enter a email")]
        public string EMail { get; set; }
       

        [Display(Name = "Phone Number:")]
        [Required(ErrorMessage = "Please enter a phone number")]
        public int PhoneNumber { get; set; }
        

        [Display(Name = "Password: ")]
        [Required(ErrorMessage = "Please enter a password")]
        public string OnlinePassword { get; set; }
        
    }
}
