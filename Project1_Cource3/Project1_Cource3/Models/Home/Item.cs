using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project1_Cource3.DAL;

namespace Project1_Cource3.Models.Home
{
    public class Item
    {
        public Tbl_Product Product { get; set; }
        public int Quantity { get; set; }
    }
}