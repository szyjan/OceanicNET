using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using OceanicNET_DAO.Model;

namespace OceanicNET_DAO
{
    public class ContextOceanicNET : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Route> Routes { get; set; }

        public ContextOceanicNET() : base("OceanicContext")
        {

        }

    }
}
