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
            menu.Add(new MenuItem("PARK INFO", "http://www.parkinfo.com.au", "fa fa-info"));
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
            submenu.Add(new MenuItem("Download Park Map", ""));
            submenu.Add(new MenuItem("Opening Hours", ""));
            submenu.Add(new MenuItem("Getting Here", ""));
            submenu.Add(new MenuItem("Ride Height Limits", ""));
            submenu.Add(new MenuItem("Ride Express &ndash; Avoid the Queue", ""));
            submenu.Add(new MenuItem("Pure Imagination", ""));
            columns[1].SubMenuItems = submenu;

            columns.Add(new MenuItem("COLUMN 1-3", ""));
            columns[2].SubMenuItems = new List<MenuItem>();
            submenu = new List<MenuItem>();
            submenu.Add(new MenuItem("Maintenance", ""));
            submenu.Add(new MenuItem("Services and Facilities", ""));
            submenu.Add(new MenuItem("Guests with Disability", ""));
            submenu.Add(new MenuItem("Community Outreach &ndash; Support", ""));
            submenu.Add(new MenuItem("Wildlife Foundation", ""));
            submenu.Add(new MenuItem("Ride Safety", ""));
            columns[2].SubMenuItems = submenu;

            columns.Add(new MenuItem("COLUMN 1-4", ""));
            columns[3].SubMenuItems = new List<MenuItem>();
            submenu = new List<MenuItem>();
            submenu.Add(new MenuItem("Skypoint & Above the Gold Coast", ""));
            submenu.Add(new MenuItem("FAQs", ""));            
            columns[3].SubMenuItems = submenu;

            menu[0].SubMenuItems = columns;

            // ***** Rides
            menu.Add(new MenuItem("RIDES", "http://www.rides.com.au", "fa fa-car"));
            columns = new List<MenuItem>();
            columns.Add(new MenuItem("COLUMN 2-1", ""));
            submenu = new List<MenuItem>();           
            submenu.Add(new MenuItem("Big 9 Thrill Rides", ""));
            subsubMenu = new List<MenuItem>();
            subsubMenu.Add(new MenuItem("Hot Wheels SideWinder", ""));
            subsubMenu.Add(new MenuItem("Tower of Terror II", ""));
            subsubMenu.Add(new MenuItem("BuzzSaw", ""));
            subsubMenu.Add(new MenuItem("WipeOut", ""));
            subsubMenu.Add(new MenuItem("The Claw", ""));
            subsubMenu.Add(new MenuItem("The Giant Drop", ""));
            subsubMenu.Add(new MenuItem("Pandamonium", ""));
            subsubMenu.Add(new MenuItem("Mick Doohan's Motocoaster", ""));
            subsubMenu.Add(new MenuItem("Tail Spin", ""));
            submenu.Find(m => m.Text == "Big 9 Thrill Rides").SubMenuItems = subsubMenu;
            columns[0].SubMenuItems = submenu;

            columns.Add(new MenuItem("COLUMN 2-2", ""));
            submenu = new List<MenuItem>();
            submenu.Add(new MenuItem("Kids Rides", ""));
            subsubMenu = new List<MenuItem>();
            subsubMenu.Add(new MenuItem("Dorothy's Rosy Tea Cup Ride", ""));
            subsubMenu.Add(new MenuItem("Big Red Car Ride", ""));
            subsubMenu.Add(new MenuItem("Big Red Boat Ride", ""));
            subsubMenu.Add(new MenuItem("Hop and Hoot", ""));
            subsubMenu.Add(new MenuItem("Shrek's Ogre-Go-Round", ""));
            subsubMenu.Add(new MenuItem("Dronkey Flyers", ""));
            subsubMenu.Add(new MenuItem("Puss in Boots Sword Swing", ""));
            subsubMenu.Add(new MenuItem("ABC KIDS WORLD Fun Spot", ""));

            subsubMenu.Add(new MenuItem("Bananas in Pyjamas Fun Maze", ""));
            subsubMenu.Add(new MenuItem("Giggle and Hoot Pirate Ship", ""));
            subsubMenu.Add(new MenuItem("Play School Art Room", ""));

            submenu.Find(m => m.Text == "Kids Rides").SubMenuItems = subsubMenu;
            columns[1].SubMenuItems = submenu;

            columns.Add(new MenuItem("COLUMN 2-3", ""));
            submenu = new List<MenuItem>();
            submenu.Add(new MenuItem("Whitewater World", ""));
            subsubMenu = new List<MenuItem>();
            
            subsubMenu.Add(new MenuItem("Cave of Waves", ""));
            subsubMenu.Add(new MenuItem("Pipeline Plunge", ""));
            subsubMenu.Add(new MenuItem("Super Tubes Hydro Coaster", ""));
            subsubMenu.Add(new MenuItem("Wiggle Bay", ""));
            subsubMenu.Add(new MenuItem("Temple of Huey", ""));
            subsubMenu.Add(new MenuItem("The Little Rippers", ""));
            subsubMenu.Add(new MenuItem("Triple Vortex", ""));
            subsubMenu.Add(new MenuItem("The Green Room", ""));
            subsubMenu.Add(new MenuItem("The Wedgie", ""));
            subsubMenu.Add(new MenuItem("The RIP", ""));
            subsubMenu.Add(new MenuItem("The BRO", ""));

            submenu.Find(m => m.Text == "Whitewater World").SubMenuItems = subsubMenu;
            columns[2].SubMenuItems = submenu;

            columns.Add(new MenuItem("COLUMN 2-4", ""));
            menu[1].SubMenuItems = columns;

            menu.Add(new MenuItem("ATTRACTIONS", "http://www.attractions.com.au", "fa fa-magnet"));
            columns = new List<MenuItem>();
            columns.Add(new MenuItem("COLUMN 3-1", ""));
            columns.Add(new MenuItem("COLUMN 3-2", ""));
            columns.Add(new MenuItem("COLUMN 3-3", ""));
            columns.Add(new MenuItem("COLUMN 3-4", ""));
            menu[2].SubMenuItems = columns;

            menu.Add(new MenuItem("GROUP EVENTS", "http://www.group.events.com.au", "fa fa-calendar-o"));
            columns = new List<MenuItem>();
            columns.Add(new MenuItem("COLUMN 3-1", ""));
            columns.Add(new MenuItem("COLUMN 3-2", ""));
            columns.Add(new MenuItem("COLUMN 3-3", ""));
            columns.Add(new MenuItem("COLUMN 3-4", ""));
            menu[2].SubMenuItems = columns;

            menu.Add(new MenuItem("FOOD & SHOPPING", "http://www.food.shopping.com.au", "fa fa-cutlery"));
            columns = new List<MenuItem>();
            columns.Add(new MenuItem("COLUMN 4-1", ""));
            columns.Add(new MenuItem("COLUMN 4-2", ""));
            columns.Add(new MenuItem("COLUMN 4-3", ""));
            columns.Add(new MenuItem("COLUMN 4-4", ""));
            menu[3].SubMenuItems = columns;

            menu.Add(new MenuItem("SCHOOLS", "http://www.schools.com.au", "fa fa-graduation-cap"));
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