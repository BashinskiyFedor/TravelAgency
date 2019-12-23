using ApplicationCore.Interfaces;
using ApplicationCore.Repository;
using Infrastructure.Data;
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
    public class ShopCartController : Controller
    {
        private readonly IAgencyTour _tourRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAgencyTour tourRepository, ShopCart shopCart)
        {
            _tourRep = tourRepository;
            _shopCart = shopCart;
        }
        [Authorize]
        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.ListOrder = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };
            return View(obj);
        }
        [Authorize]
        public RedirectToActionResult addToCart(int id)
        {
            var item = _tourRep.Tours.FirstOrDefault(i => i.IdTour == id);
            if(item !=null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }


    }
}
