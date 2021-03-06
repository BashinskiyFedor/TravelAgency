﻿using ApplicationCore.Interfaces;
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
    public class HomeController : Controller
    {
        private readonly IAgencyTour _tourRep;

        
        public HomeController(IAgencyTour tourRepository)
        {
            _tourRep = tourRepository;
        }

        [Authorize]
        public ViewResult Index()
        {
            var homeTours = new HomeViewModel
            {
                favTours = _tourRep.GetFavTours
            };
            return View(homeTours);
        }
    }
}
