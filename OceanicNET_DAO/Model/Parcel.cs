using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanicNET_DAO.Model
{
    public class Parcel
    {
        [Key]
        public int parcelId { get; set; }
        public double weight { get; set; }
        public double height { get; set; }
        public double breadth { get; set; }
        public double depth { get; set; }
        public virtual TypeOfGoods typeOfGood { get; set; }
    }
}
