using MyWebSite.DAL.MyEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.DAL
{
    public class MyWebSiteContext : DbContext
    {
        public MyWebSiteContext()
        {

        }
        public DbSet<User> User { get; set; }
    }
}
