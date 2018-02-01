using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models
{
    public abstract class DatabaseRecord
    {
        int id;
        public int Id { get { return id; } set { id = value; } }
    }
}