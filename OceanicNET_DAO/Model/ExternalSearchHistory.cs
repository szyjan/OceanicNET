using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OceanicNET_DAO.Utility.EnumHelper;

namespace OceanicNET_DAO.Model
{
    public class ExternalSearchHistory
    {
        [Key]
        public int externalSearchHistoryId { get; set; }
        public virtual City sourceCity { get; set; }
        public virtual City destinationcity { get; set; }
        public DateTime searchDate { get; set; } 
        public Cooperant cooperant { get; set; }
        public double time { get; set; }
        public double length { get; set; }
        public decimal price { get; set; }
    }
}
