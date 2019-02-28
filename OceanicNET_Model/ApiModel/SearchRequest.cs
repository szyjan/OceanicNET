using System;
using System.Collections.Generic;
using System.Linq;

namespace OceanicNET.Models.ApiModel
{
    public class SearchRequest
    {
        public List<SingleRequest> searchRequests { get; set; } = new List<SingleRequest>();
    }
    
    public class SingleRequest
    {
        public string sourceCity { get; set; }
        public string destinationCity { get; set; }
        public string typeOfGood { get; set; }
        public double weight { get; set; }
        public double height { get; set; }
        public double width { get; set; }
        public double length { get; set; }
        public DateTime parcelDate { get; set; } = DateTime.Now;
    }
}