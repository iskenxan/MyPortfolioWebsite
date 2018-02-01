using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models
{
    public class Review:DatabaseRecord
    {
        private int rating;
        private string name;
        private string projectName;
        private string dateStr;
        private string comment;

        public string Name { get { return name; } set { name = value; } }
        public string ProjectName { get { return projectName; } set { projectName = value; } }
        public int Rating { get { return rating; } set { rating = value; } }
        public string DateString { get { return dateStr; } set { dateStr = value; } }
        public string Comment { get { return comment; } set { comment = value; } }
    }
}