using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace DAL
{
    public class MongoService<T> : BaseMongoService<T>
    {
        protected override string ConnectionName => typeof (T).Name;
    }

}
    