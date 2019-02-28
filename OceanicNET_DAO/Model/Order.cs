using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OceanicNET_DAO.Utility.EnumHelper;

namespace OceanicNET_DAO.Model
{
    public class Order
    {
        [Key]
        public int orderID { get; set; }
        public DateTime orderDate { get; set; }
        public virtual City sourceCity { get; set; }
        public virtual City destinationCity { get; set; }
        public OrderStatus status { get; set; }
        public virtual Path path {get;set;}
        public decimal price { get; set; }
        public Parcel parcel { get; set; }
        public virtual User user { get; set; }
    }


}
