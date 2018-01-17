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
            string dateStr = "";
            string month= date.ToString("MMMM");
            dateStr = month + " " + date.Day + ", " + date.Year;

            return dateStr;
        }
    }
}