using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransitAPI.Models
{
    public class Report
    {
        public int ID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public double TotalDistance { get; set; }
        public double TotalPrice { get; set; }
    }
}
