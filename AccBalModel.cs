using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Banking.Models
{
    public class AccBalModel
    {
        [Display(Name = "Account Number ")]
        public long Account_NO { get; set; }

        [Display(Name = "Account Balance ")]
        public double Account_Balance { get; set; }
    }
}