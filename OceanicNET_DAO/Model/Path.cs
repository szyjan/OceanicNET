using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanicNET_DAO.Model
{
    public class Path
    {
        [Key]
        public int pathId { get; set; }
        public virtual City sourceCity { get; set; }
        public virtual City destinationCity { get; set; }
        public virtual PathNode startNode { get; set; }
        /// <summary>
        /// Time to traverse the path in Hours
        /// </summary>
        public double time { get; set; }
        public decimal price { get; set; }
    }
}
