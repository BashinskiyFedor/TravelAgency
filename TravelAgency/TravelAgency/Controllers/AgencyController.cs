using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAgency.ViewModel;

namespace TravelAgency.Controllers
{
    [Authorize]
    public class AgencyController : Controller
    {
        private readonly IAllAgency _agencyRep;

        public AgencyController(IAllAgency agency)
        {
            _agencyRep = agency;
        }

        [Authorize]
        [Route("Agency/ListAgency")]
        public ViewResult ListAgency()
        {
            var agency = new AgencyListViewModel
            {
                AllAgency = _agencyRep.AllAgencies
            };
            return View(agency);
        }
    }
}
