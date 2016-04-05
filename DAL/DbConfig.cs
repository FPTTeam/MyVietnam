using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unities;

namespace DAL
{
    public class DbConfig
    {
        public static MyVietnamContext GetMongoConnection()
        {            
            try
            {
                var context = (MyVietnamContext)CacheBase.Instance.GetCache(Constants.MongoCacheKey);
                if (context != null)
                {
                    return context;
                }
                context = new MyVietnamContext();
                CacheBase.Instance.Add(Constants.MongoCacheKey, context);
                return context;                
            }
            catch (Exception ex)
            {
                return new MyVietnamContext();
            }
        }
    }
}
