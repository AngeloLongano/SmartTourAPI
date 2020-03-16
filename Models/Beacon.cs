using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartTourAPI.Models
{
    public class Beacon
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int IDMap { get; set; }
        public int IDType { get; set; }
    }
}