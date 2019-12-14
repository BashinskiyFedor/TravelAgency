using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore
{
    public class Agency
    {
        public int IdAgency { get; set; }
        public string NameAgency { get; set; }
        public int NumTelephone { get; set; } 
        public virtual ICollection<Manager> Managers { get; set; }
        public virtual ICollection<Tour> Tours { get; set; }
    }
}
