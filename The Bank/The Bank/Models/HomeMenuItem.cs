using System;
using System.Collections.Generic;
using System.Text;

namespace The_Bank.Models
{
    public enum MenuItemType
    {
        Home = 0,
        Browse = 1,
        About = 2
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
