using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanicNET_DAO.Model
{
    public class City
    {
        public int cityId { get; set; }
        public string name { get; set; }

        public virtual List<Route> routes { get; set; }
    }
}
