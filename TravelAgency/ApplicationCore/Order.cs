using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore
{
    public class Order
    {
        public int IdOrder { get; set; }
        public int IdClient { get; set; }
        public int IdManager { get; set; }
        public int IdTour { get; set; }
    }
}
