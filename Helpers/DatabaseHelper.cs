using Dapper;
using MySql.Data.MySqlClient;
using SmartTourAPI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SmartTourAPI.Helpers
{
    public class DatabaseHelper
    {
        private static string ConnectionString =
            ConfigurationManager.ConnectionStrings["Database"].ConnectionString; //personalizzare la set per gestire l'eccezione

        public static List<Consumer> GetAllCosumers()
        {
            var consumers = new List<Consumer>();
            using (var connection = new MySqlConnection(ConnectionString))
            {
                var sql = "select * from consumer";
                consumers = connection.Query<Consumer>(sql).ToList();
            }
            return consumers;
        }

    }
}