using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore
{
    public class Client
    {
        public int IdClient { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int PaspSerial { get; set; }
        public int PaspNomer { get; set; }
        public int Registration { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
