using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanicNET_DAO.Model
{
    public class Search
    {
        [Key]
        public int searchId { get; set; }
        public DateTime searchDate { get; set; }
        public virtual User user { get; set; }
        public virtual City sourceCity { get; set; }
        public virtual City destinationCity { get; set; }
        public virtual List<Path> paths { get; set; }
    }
}
