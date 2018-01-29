using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models
{
    public class Formatter
    {

        public static string convertDateToHumanString(DateTime date)
        {
            string dateStr = date.ToString("MMMM dd, yyyy");

            return dateStr;
        }
    }
}