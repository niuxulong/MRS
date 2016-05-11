using MRS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.DataCacheManager
{
    public class DataCache
    {
        public List<Template> TemplateCache = new List<Template>();

        private static DataCache dataCache = null;
        private static readonly object locker = new object();
        private DataCache()
        {
            
        }

        public static DataCache GetCacheInstance()
        {
            if (dataCache == null)
            {
                lock (locker)
                {
                    if (dataCache == null)
                    {
                        dataCache = new DataCache();
                    }
                }
            }

            return dataCache;
        }
    }
}
