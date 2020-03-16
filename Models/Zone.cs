using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartTourAPI.Models
{
    public class Zone
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Features { get; set; }
        public int IDItem { get; set; }
    }
}