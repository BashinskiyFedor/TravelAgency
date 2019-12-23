using ApplicationCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data
{
    public class DBObjects
    {
        public static void Initial(AgencyContext ctx)
        {
            if (!ctx.Agency.Any())
                ctx.Agency.AddRange(Agencies.Select(c => c.Value));

            if (!ctx.Tour.Any())
            {
                ctx.AddRange(
                     new Tour { PictureUri = "/img/саванна.webp", Price = 10000, isFavorite = true, Agency = Agencies["София тур"] }
                );
            }
            ctx.SaveChanges();
        }
        public static Dictionary<string, Agency> agency;
        public static Dictionary<string, Agency> Agencies 
        { 
            get
            {
                if(agency == null)
                {
                    var list = new Agency[]
                    {
                        new Agency { Img="https://picsum.photos/seed/picsum/200/300", NameAgency="София тур", NumTelephone=89997779087 },
                        new Agency { Img="https://picsum.photos/seed/picsum/200/300", NameAgency="ТУр де Франс", NumTelephone=89997779087 },
                        new Agency { Img="https://picsum.photos/seed/picsum/200/300", NameAgency="Поэрторикко", NumTelephone=89997779087 },
                    };

                    agency = new Dictionary<string, Agency>();
                    foreach (Agency el in list)
                        agency.Add(el.NameAgency, el);
                }
                return agency;
            }

        }


    }
}
