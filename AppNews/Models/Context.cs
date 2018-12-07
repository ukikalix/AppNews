using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppNews.Models
{
    public class Context: DbContext
    {

        public Context()
            : base("DefaultConnection")
        {
        }
        public DbSet<News> TheNews { get; set; }
    }
}