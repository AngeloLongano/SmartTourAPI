using SmartTourAPI.Helpers;
using SmartTourAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmartTourAPI.Controllers
{
    public class SmartTourController : ApiController
    {
        public HttpResponseMessage GetConsumers()
        {
            var consumers = DatabaseHelper.GetAllCosumers();
            return new HttpResponseMessage()
            {
                Content = new JsonHelper(consumers)
            };
        }
    }
}
