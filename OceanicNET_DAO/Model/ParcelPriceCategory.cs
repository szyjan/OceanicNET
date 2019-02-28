using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanicNET_DAO.Model
{
    public class ParcelPriceCategory
    {
        [Key]
        public int parcelPriceCategoryId { get; set; }
        public double minWeigth { get; set; }
        public double maxWeigth { get; set; }
        public decimal price { get; set; }
        public virtual ParcelSizeCategory parcelSizeCategory { get; set; }
    }
}
