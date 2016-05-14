﻿using Common.Const;
using Common.DataBaseAccessor;
using Common.Enums;
using Common.Utility;
using MRS.Entity.Entities;
using System;
using System.Data.SqlClient;

namespace MRS.Model.Interfaces
{
    public class SystemConfigBaseModel<T>
    {
        public SystemConfigBaseModel()
        {
            
        }

        public bool UpdateOrAddSystemConfig(T obj, Enums.SystemSettingIdEnum settingId, Enums.SystemSettingKeyEnum settingKey, DatabaseConfig dbConfig = null)
        {
            try
            {
                var configXml = SerializeUtility<T>.XmlSerialize(obj);
                if (dbConfig == null)
                {
                    dbConfig = CommonUltility.GetDatabaseConfigFromCache();    
                }

                var rowAmount = SqlHelper.ExecuteNonQuery(SqlHelper.GetConnSting(dbConfig.Server, dbConfig.Database, dbConfig.User, dbConfig.Password), SqlConst.SP_ADDUPDATESYSTEMSETTING, new object[] { (int)settingId, settingKey.ToString(), configXml });
                var updateCacheSuccess = false;
                if (rowAmount > 0)
                {
                    if (!DataCacheManager.DataCacheManager.GetCacheManagerInstance().CacheInitialized())
                    {
                        DataCacheManager.DataCacheManager.GetCacheManagerInstance().InitilizeDataCache(dbConfig);
                    }
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

        public bool DeleteSystemConfig(Enums.SystemSettingIdEnum settingId, Enums.SystemSettingKeyEnum settingKey)
        {
            try
            {
                var dbConfig = CommonUltility.GetDatabaseConfigFromCache();
                var rowAmount = SqlHelper.ExecuteNonQuery(SqlHelper.GetConnSting(dbConfig.Server, dbConfig.Database, dbConfig.User, dbConfig.Password), SqlConst.SP_DELETESYSTEMSETTING, (int)settingId);
                if (rowAmount > 0)
                {
                    DataCacheManager.DataCacheManager.GetCacheManagerInstance().DeleteSystemSettingsCache(settingKey.ToString());
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
