using System;
using System.Collections.Generic;
using System.Linq;

namespace OceanicNET.Models.ApiModel
{
    public class SearchRequestResponse
    {
        public List<SingleResult> results { get; set; } = new List<SingleResult>();
    }

    public class SingleResult
    {
        public SearchRequest request { get; set; }
        public double time { get; set; }
        public decimal price { get; set; }
        public int offerID { get; set; }
        public DateTime dateOfSearch { get; set; }
        public int errorCode { get; set; } = 0;
        public string errorMessage { get; set; }
    }
}