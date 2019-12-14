using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ApplicationCore
{
    public class Tour
    {
        public int IdTour { get; set; }
        public decimal Price { get; set; }
        public string PictureUri { get; set; }
        public HotelRoomRental HotelRoomRental { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
