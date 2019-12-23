using ApplicationCore.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationCore.Repository
{
    public class TourRepository : IAgencyTour
    {
        private readonly AgencyContext _agencyContext;

        public TourRepository(AgencyContext agencyContext)
        {
            _agencyContext = agencyContext;
        }

        public IEnumerable<Tour> Tours => _agencyContext.Tour.Include(a => a.Agency);
        public IEnumerable<Tour> GetFavTours => _agencyContext.Tour.Where(p => p.isFavorite).Include(a => a.Agency);

        public Tour GetObjectTour(int IdTour) => _agencyContext.Tour.FirstOrDefault(p => p.IdTour == IdTour);
    }
}
