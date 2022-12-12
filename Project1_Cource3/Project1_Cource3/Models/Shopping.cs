using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project1_Cource3.Models
{
    public class Shippingdatail
    {
        public int ShippingDetailsId { get; set; }
        [Required]
        public Nullable<int> memberId { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string ZipCode { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<decimal> AmontPaid { get; set; }
        [Required]
        public string PaymentType { get; set; }
    }
}