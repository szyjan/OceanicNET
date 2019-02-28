using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanicNET_DAO.Model
{
    public class Route
    {
        public int routeId { get; set; }
        public string type { get; set; }
        public int length { get; set; }
        public Cooperant cooperant { get; set; }
        public virtual City cityA { get; set; }
        public virtual City cityB { get; set; }
    }

    public enum Cooperant
    {
        INTERNAL,
        EIT,
        TL
    }
}
