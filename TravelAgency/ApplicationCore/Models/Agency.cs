using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore
{
    public class Agency : BaseEntity
    {
        public int IdAgency { get; set; }
        public string NameAgency { get; set; }
        public long NumTelephone { get; set; } 
        public string Img { get; set; }
        public virtual ICollection<Manager> Managers { get; set; }
        public virtual ICollection<Tour> Tours { get; set; }
    }
}
