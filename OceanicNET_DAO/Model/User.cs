using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OceanicNET_DAO.Utility.EnumHelper;

namespace OceanicNET_DAO.Model
{
    public class User
    {
        [Key]
        public int userId { get; set; }
        public string login { get; set; }
        public UserRole role { get; set; }
        public virtual Password password { get; set; }
    }

}
