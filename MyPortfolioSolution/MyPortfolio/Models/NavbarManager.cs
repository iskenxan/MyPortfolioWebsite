using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models
{
    public class NavbarManager
    {
        public NavbarManager(string activeLink)
        {

        }

        public List<NavLink> links { get; set; }
        public string ActiveLink { get; set; }

    }
}