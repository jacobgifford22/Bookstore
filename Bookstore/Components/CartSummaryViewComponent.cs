﻿using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;
        
        public CartSummaryViewComponent(Cart c)
        {
            cart = c;
        }

        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
