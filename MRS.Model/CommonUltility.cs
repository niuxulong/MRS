using Common.Enums;
using MRS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Model
{
    public static class CommonUltility
    {
        public static DatabaseConfig GetDatabaseConfigFromCache()
        {
            var systemSettings = DataCacheManager.DataCacheManager.GetCacheManagerInstance().GetSystemSettingsFromCache();
            var dbConfigXml = systemSettings[Enums.SystemSettingKeyEnum.DataBaseConnection.ToString()];
            return Common.Utility.SerializeUtility<DatabaseConfig>.XmlDeserialize(dbConfigXml);
        }
    }
}
