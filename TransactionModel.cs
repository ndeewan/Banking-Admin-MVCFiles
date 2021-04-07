using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Banking.Models
{
    public class TransactionModel : AccBalModel
    {
        [Display(Name = "Sender's Account Number ")]
        public long Sender_Acc { get; set; }

        [Display(Name = "Receiver's Account Number ")]
        public long Receiver_Acc { get; set; }

        [Display(Name = "Receiver's Bank IFSC ")]
        public string Rec_IFSC { get; set; }

        [Display(Name = "Amount ")]
        public double Amount { get; set; }

        [Display(Name = "Transaction Date and Time ")]
        public DateTime Transaction_time { get; set; }
        
    }
}