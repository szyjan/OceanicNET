using System;
using System.Collections.Generic;
using System.Linq;

namespace OceanicNET.Models.ApiModel
{
    public class PlaceOrderResponse
    {
        public int orderId { get; set; }
        public int errorCode { get; set; } = 0;
        public string errorMessage { get; set; }
    }
}