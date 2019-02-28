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
        public DbSet<ExternalSearchHistory> ExternalSearchHistory { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<ParcelPriceCategory> ParcelPriceCategories { get; set; }
        public DbSet<ParcelSizeCategory> ParcelSizeCategories { get; set; }
        public DbSet<Password> Passwords { get; set; }
        public DbSet<Path> Paths { get; set; }
        public DbSet<PathNode> PathNodes { get; set; }
        public DbSet<Search> Searches { get; set; }
        public DbSet<TypeOfGoods> TypesOfGoods { get; set; }
        public DbSet<User> Users { get; set; }


        public ContextOceanicNET() : base("OceanicContext")
        {

        }

    }
}
