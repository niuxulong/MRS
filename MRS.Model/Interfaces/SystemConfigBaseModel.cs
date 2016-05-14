﻿using Common.Const;
using Common.DataBaseAccessor;
using Common.Enums;
using Common.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Model.Interfaces
{
    public class SystemConfigBaseModel<T>
    {
        public bool UpdateOrAddSystemConfig(T obj, Enums.SystemSettingIdEnum settingId, Enums.SystemSettingKeyEnum settingKey)
        {
            try
            {
                var configXml = SerializeUtility<T>.XmlSerialize(obj);
                var rowAmount = SqlHelper.ExecuteNonQuery(SqlHelper.GetConnSting(), SqlConst.SP_ADDUPDATESYSTEMSETTING, new object[] { (int)settingId, settingKey.ToString(), configXml });
                var updateCacheSuccess = false;
                if (rowAmount > 0)
                {
                    updateCacheSuccess = DataCacheManager.DataCacheManager.GetCacheManagerInstance().UpdateSystemSettingsCache(settingKey.ToString(), configXml);
                }

                return updateCacheSuccess && rowAmount > 0;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public T GetSystemConfig(Enums.SystemSettingKeyEnum settingKey)
        {
            var systemSettingsDic = DataCacheManager.DataCacheManager.GetCacheManagerInstance().GetSystemSettingsFromCache();
            if (systemSettingsDic.ContainsKey(settingKey.ToString()))
            {
                var configXml = DataCacheManager.DataCacheManager.GetCacheManagerInstance().GetSystemSettingsFromCache()[settingKey.ToString()];
                return SerializeUtility<T>.XmlDeserialize(configXml);
            }

            return default(T);
        }
    }
}