using ApplicationCore;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data
{
    public class ShopCart
    {
        private readonly AgencyContext _agencyContext;
        public ShopCart(AgencyContext agencyContext)
        {
            _agencyContext = agencyContext;
        }
        public String ShopCartId { get; set; }
        public List<Order> ListOrder { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AgencyContext>();
            string shopCardId = session.GetString("CardId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCardId);

            return new ShopCart(context) { ShopCartId = shopCardId };
        }

        public void AddToCart(Tour tour)
        {
            _agencyContext.Order.Add(new Order {
                ShopCartId = ShopCartId,
                tour = tour,
                price = tour.Price
            });

            _agencyContext.SaveChanges();
        }

        public List<Order> getShopItems()
        {
            return _agencyContext.Order.Where(c => c.ShopCartId == ShopCartId).Include(s => s.Tour).ToList();
        }
    }
}
