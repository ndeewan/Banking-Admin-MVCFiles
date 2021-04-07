using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Banking.Models
{
    public class AdminModel
    {
        [Display(Name = "Account Number ")]
        public long Account_No { get; set; }

        [Display(Name = "Account Name ")]
        public string Account_Name { get; set; }

        [Display(Name = "Mobile Number ")]
        public long Mobile_No { get; set; }

        [Display(Name = "Email Address ")]
        public string Email { get; set; }

        [Display(Name = "Address ")]
        public string Address { get; set; }

        [Display(Name = "Bank Branch ")]
        public string Bank_Branch { get; set; }

        [Display(Name = "IFSC ")]
        public string IFSC { get; set; }
    }
}