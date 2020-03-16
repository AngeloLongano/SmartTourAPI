using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartTourAPI.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string UrlIcon { get; set; }
        public string OrderItem { get; set; }
        public string Text { get; set; }
        public string UrlImage { get; set; }
        public string UrlVideo { get; set; }
        public string UrlAudio { get; set; }

    }
}