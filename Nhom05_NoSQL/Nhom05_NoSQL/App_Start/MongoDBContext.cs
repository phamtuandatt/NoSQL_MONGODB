using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Nhom05_NoSQL.App_Start
{
    public class MongoDBContext
    {
        public IMongoDatabase database;
        public MongoDBContext()
        {
            var conn = new MongoClient(ConfigurationManager.AppSettings["MongoDBHost"]);
            database = conn.GetDatabase(ConfigurationManager.AppSettings["MongoDBName"]);
        }
    }
}