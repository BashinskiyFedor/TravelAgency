using ApplicationCore;
using ApplicationCore.Interfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class AgencyRepository : IAllAgency
    {
        private readonly AgencyContext _agencyContext;

        public AgencyRepository(AgencyContext agencyContext)
        {
            _agencyContext = agencyContext;
        }
        public IEnumerable<Agency> AllAgencies => _agencyContext.Agency;
    }
}
