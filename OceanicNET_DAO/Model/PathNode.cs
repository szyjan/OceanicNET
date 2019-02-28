using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanicNET_DAO.Model
{
    public class PathNode
    {
        [Key]
        public int nodeId { get; set; }
        public int nodeSeqNumber { get; set; }
        public virtual City city { get; set; }
        public virtual PathNode nextNode { get; set; }
    }
}
