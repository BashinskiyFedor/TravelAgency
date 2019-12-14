using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore
{
    public class Manager
    {
        public int IdManager { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
