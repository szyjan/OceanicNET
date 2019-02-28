using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanicNET_DAO.Model
{
    public class ParcelSizeCategory
    {
        [Key]
        public int parcelSizeCategoryId { get; set; }
        public int priceCategory { get; set; }
        public double maxHeight { get; set; }
        public double maxBreadth { get; set; }
        public double maxDepth { get; set; }
    }
}
