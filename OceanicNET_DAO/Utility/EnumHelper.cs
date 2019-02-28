using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanicNET_DAO.Utility

{
    public static class EnumHelper
    {
        public enum Cooperant
        {
            INTERNAL,
            EIT,
            TL
        }

        public enum OrderStatus
        {
            OFFER,
            IN_PREPARATION,
            ORDERED,
            IN_DELIVERY,
            DELIVERED,
            REJECTED
        }

        public enum UserRole
        {
            NOTLOGGED,
            USER,
            PRICE_ADMIN,
            ADMIN
        }
    }
}
