using ApplicationCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.ViewModel
{
    public class TourListViewModel
    {
        public IEnumerable<Tour> AllTour { get; set; }
    }
}
