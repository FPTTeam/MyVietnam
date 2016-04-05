using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Properties;
using MongoDB.Driver;

namespace DAL
{
    public class MyVietnamContext
    {
        private IMongoClient client;
        private IMongoDatabase database;

        public MyVietnamContext()
        {
            client = new MongoClient(Settings.Default.MyVietnamConnectionString);
            database = client.GetDatabase(Settings.Default.MyVietnamDatabaseName);
        }

        public MyVietnamContext(string connectionString, string databaseName)
        {
            client = new MongoClient(connectionString);
            database = client.GetDatabase(databaseName);
        }

        public MyVietnamContext(string connectionString)
        {
            client = new MongoClient(connectionString);
            database = client.GetDatabase(Settings.Default.MyVietnamDatabaseName);
        }

        public IMongoDatabase GetDatabase()
        {
            return database;
        }
    }
}
