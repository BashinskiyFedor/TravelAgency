using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationCore.Mocks
{
    public class MockTour : IAgencyTour
    {
        private readonly IAllAgency _agencyTour = new MockAgency();
        public IEnumerable<Tour> Tours
        { 
            get
            {
                return new List<Tour>
                {
                    new Tour { PictureUri = "/img/саванна.webp", Price = 10000, isFavorite=true, Agency =_agencyTour.AllAgencies.First() }
                };
            }
            set
            {

            }
        }
        public IEnumerable<Tour> GetFavTours { get; set; }

        public Tour GetObjectTour(int IdTour)
        {
            throw new NotImplementedException();
        }
    }
}
