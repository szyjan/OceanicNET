using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanicNET_DAO.Model
{
    public class TypeOfGoods
    {
        [Key]
        public int typeId { get; set; }
        public string name { get; set; }
    }
}
