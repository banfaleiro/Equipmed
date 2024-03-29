﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class OrderResponseBE:BaseResponse
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string OrderDate { get; set; }
        public double ProductPrice { get; set; }
        public int TotalAmount { get; set; }
        public int SupplierID { get;set; }
    }
}
