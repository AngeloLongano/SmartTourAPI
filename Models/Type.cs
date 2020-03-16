using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartTourAPI.Models
{
    public class Type
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string UrlIcon { get; set; }
        public string Features { get; set; }
    }
}