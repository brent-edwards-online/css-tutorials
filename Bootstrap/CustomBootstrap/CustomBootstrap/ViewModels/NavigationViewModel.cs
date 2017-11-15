using CustomBootstrap.Models.Navigation;
using System.Collections.Generic;
using System.Linq;

namespace CustomBootstrap.Models
{
    public class NavigationViewModel
    {
        public NavigationViewModel()
        {
            var menu = new List<MenuItem>();
            menu.Add(new MenuItem("PARK INFO", "http://www.parkinfo.com.au"));
            var columns = new List<MenuItem>();
            columns.Add(new MenuItem("COLUMN 1-1", ""));
            var submenu = new List<MenuItem>();
            submenu.Add(new MenuItem("Tickets and Passes", ""));
            submenu.Add(new MenuItem("Passholder Benefits", ""));
            submenu.Add(new MenuItem("Membership Benefits", ""));
            submenu.Add(new MenuItem("Holiday Deals", ""));
            submenu.Add(new MenuItem("Whats On", ""));
            var subsubMenu = new List<MenuItem>();
            subsubMenu.Add(new MenuItem("Festive Street Market", ""));
            subsubMenu.Add(new MenuItem("Park After dark", ""));
            subsubMenu.Add(new MenuItem("Christmas at Dreamworld", ""));
            submenu.Find(m => m.Text == "Whats On").SubMenuItems = subsubMenu;
            columns[0].SubMenuItems = submenu;    

            columns.Add(new MenuItem("COLUMN 1-2", ""));
            columns[1].SubMenuItems = new List<MenuItem>();
            submenu = new List<MenuItem>();
            submenu.Add(new MenuItem("ITEM 1", ""));
            submenu.Add(new MenuItem("ITEM 2", ""));
            submenu.Add(new MenuItem("ITEM 3", ""));
            submenu.Add(new MenuItem("ITEM 4", ""));
            submenu.Add(new MenuItem("ITEM 5", ""));
            submenu.Add(new MenuItem("ITEM 6", ""));
            columns[1].SubMenuItems = submenu;

            columns.Add(new MenuItem("COLUMN 1-3", ""));
            columns.Add(new MenuItem("COLUMN 1-4", ""));
            menu[0].SubMenuItems = columns;

            menu.Add(new MenuItem("RIDES", "http://www.rides.com.au"));
            columns = new List<MenuItem>();
            columns.Add(new MenuItem("COLUMN 2-1", ""));
            columns.Add(new MenuItem("COLUMN 2-2", ""));
            columns.Add(new MenuItem("COLUMN 2-3", ""));
            columns.Add(new MenuItem("COLUMN 2-4", ""));
            menu[1].SubMenuItems = columns;

            menu.Add(new MenuItem("ATTRACTIONS", "http://www.attractions.com.au"));
            columns = new List<MenuItem>();
            columns.Add(new MenuItem("COLUMN 3-1", ""));
            columns.Add(new MenuItem("COLUMN 3-2", ""));
            columns.Add(new MenuItem("COLUMN 3-3", ""));
            columns.Add(new MenuItem("COLUMN 3-4", ""));
            menu[2].SubMenuItems = columns;

            menu.Add(new MenuItem("FOOD & SHOPPING", "http://www.food.shopping.com.au"));
            columns = new List<MenuItem>();
            columns.Add(new MenuItem("COLUMN 4-1", ""));
            columns.Add(new MenuItem("COLUMN 4-2", ""));
            columns.Add(new MenuItem("COLUMN 4-3", ""));
            columns.Add(new MenuItem("COLUMN 4-4", ""));
            menu[3].SubMenuItems = columns;

            menu.Add(new MenuItem("SCHOOLS", "http://www.schools.com.au"));
            columns = new List<MenuItem>();
            columns.Add(new MenuItem("COLUMN 1", ""));
            columns.Add(new MenuItem("COLUMN 2", ""));
            columns.Add(new MenuItem("COLUMN 3", ""));
            columns.Add(new MenuItem("COLUMN 4", ""));
            menu[4].SubMenuItems = columns;

            Menu = menu;

        }

        public IEnumerable<MenuItem> Menu { get; set; }
    }
}