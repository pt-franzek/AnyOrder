using AnyOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class MenuController : ApiController
    {
        [System.Web.Mvc.Route("menu")]
        [System.Web.Mvc.Route("menu/menu")]
        public IEnumerable<MenuItem> Menu()
        {
            var menu = GetMenu();

            return menu;
        }

        public MenuItem MenuItemDetails(int id)
        {
            MenuItem menuItem = GetMenu().SingleOrDefault(m => m.Id == id);

            if (menuItem == null) 
                throw new HttpResponseException(HttpStatusCode.NotFound);
            else
                return menuItem;
        }

        private IEnumerable<MenuItem> GetMenu()
        {
            return new List<MenuItem>
            {

            };
        } 
    }
}
