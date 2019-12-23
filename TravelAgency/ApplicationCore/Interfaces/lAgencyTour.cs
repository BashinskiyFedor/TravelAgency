using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    
    public interface IAgencyTour
    {
        IEnumerable<Tour> Tours { get;  }
        IEnumerable<Tour> GetFavTours { get; }
        Tour GetObjectTour(int IdTour);
    }
}
