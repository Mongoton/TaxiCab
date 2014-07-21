using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiCab.Models
{
    public class TaxiModel
    {
        public string TaxiID { get; set; }
        public DateTime TaxiRideDate { get; set; }
        public int TaxiMinutesUnder6 { get; set; }
        public int TaxiMinutesOver6 { get; set; }
    }
}