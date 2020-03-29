using SmartTourAPI.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SmartTourAPI.Controllers
{
    public class ConsumersController : ApiController
    {
        private static string ConnectionString =
           ConfigurationManager.ConnectionStrings["Database"].ConnectionString; //personalizzare la set per gestire l'eccezione

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage GetConsumers()
        {
            var consumers = DatabaseHelper.GetAllCosumers();
            return new HttpResponseMessage()
            {
                Content = new JsonHelper(consumers)
            };
        }
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage GetConsumer(int id)
        {
            var consumer = DatabaseHelper.GetCosumerById(id);
            return new HttpResponseMessage()
            {
                Content = new JsonHelper(consumer)
            };
        }

    }
}
