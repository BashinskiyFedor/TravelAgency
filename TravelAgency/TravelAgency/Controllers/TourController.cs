using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelAgency.ViewModel;

namespace TravelAgency.Controllers
{
    [Authorize]
    public class TourController : Controller
    {
        private readonly IAllAgency _allAgency;
        private readonly IAgencyTour _AllTour;

        public TourController(IAllAgency iAllAgency, IAgencyTour iAgencyTour)
        {
            _allAgency = iAllAgency;
            _AllTour = iAgencyTour;
        }
        [Authorize]
        [HttpGet]
        [Route("Tour/List")]
        [Route("Tour/List/{agency}")]
        public ViewResult List(int agency)
        {
            int _agency = agency;
            IEnumerable<Tour> tours = null;
          
            tours = _AllTour.Tours.Where(i => i.Agency.IdAgency.Equals(_agency)).OrderBy(i => i.IdTour);
                
            var tourObj = new TourListViewModel
            {
                AllTour = tours
            };
            return View(tourObj);
        }
    }
}
