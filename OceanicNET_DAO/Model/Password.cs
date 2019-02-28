using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanicNET_DAO.Model
{
    public class Password
    {
        [Key]
        public int passwordId { get; set; }
        public string hash { get; set; }
    }
}
