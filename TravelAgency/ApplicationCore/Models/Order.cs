using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore
{
    public class Order
    {
        public Tour tour;

        public int IdOrder { get; set; }
        //public Client Client { get; set; }
        //public Manager Manager { get; set; }
        public decimal price { get; set; }
        public Tour Tour { get; set; }
        public string ShopCartId { get; set; }
    }
}
