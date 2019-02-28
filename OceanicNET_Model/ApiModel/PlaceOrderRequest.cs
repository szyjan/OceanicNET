using System;
using System.Collections.Generic;
using System.Linq;

namespace OceanicNET.Models.ApiModel
{
    public class PlaceOrderRequest
    {
        public int offerID { get; set; }
        /// <summary>
        /// Name of the company/application that is placing the offer
        /// </summary>
        public string cooperantName { get; set; }
    }
}