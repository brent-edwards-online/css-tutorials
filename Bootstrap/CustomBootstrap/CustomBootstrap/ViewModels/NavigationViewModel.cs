using CustomBootstrap.Models.Navigation;
using System.Collections.Generic;

namespace CustomBootstrap.Models
{
    public class NavigationViewModel
    {
        public NavigationViewModel()
        {
            var menu = new List<MenuItem>();
            menu.Add(new MenuItem("PARK INFO", "http://www.parkinfo.com.au"));
            menu.Add(new MenuItem("RIDES", "http://www.rides.com.au"));
            menu.Add(new MenuItem("ATTRACTIONS", "http://www.attractions.com.au"));
            menu.Add(new MenuItem("FOOD & SHOPPING", "http://www.food.shopping.com.au"));
            menu.Add(new MenuItem("SCHOOLS", "http://www.schools.com.au"));

            Menu = menu;

        }

        public IEnumerable<MenuItem> Menu { get; set; }
    }
}