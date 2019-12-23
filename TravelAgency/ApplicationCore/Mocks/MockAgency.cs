using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Mocks
{
    public class MockAgency : IAllAgency
    {
        public IEnumerable<Agency> AllAgencies
        {
            get 
            {
                return new List<Agency>
                {
                    new Agency { NameAgency="СофияТур", NumTelephone=89155293455,Img="/img/саванна.webp"},
                    new Agency { NameAgency="TurDeFrance", NumTelephone=89155293455,Img="/img/саванна.webp"},
                    new Agency { NameAgency="TurDeJapan", NumTelephone=89155293455,Img="/img/саванна.webp"},
                    new Agency { NameAgency="Tur La Leo", NumTelephone=89155293455,Img="/img/саванна.webp"},
                    new Agency { NameAgency="TUr Viva ly France", NumTelephone=89155293455,Img="/img/саванна.webp"}
                };
            }
        }
    }
}
