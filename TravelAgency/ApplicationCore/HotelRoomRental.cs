using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore
{
    public class HotelRoomRental
    {
        public int IdRental { get; set; }
        public string Address { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime CheckOut { get; set; }
        public int CountPerson { get; set; }
    }
}
