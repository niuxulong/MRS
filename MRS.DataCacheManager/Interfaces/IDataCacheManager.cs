using MRS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.DataCacheManager.Interfaces
{
    public interface IDataCacheManager
    {
        void InitilizeDataCache();

        List<Template> GetTemplatesFromCache();

        Dictionary<string, string> GetSystemSettingsFromCache();
    }
}
