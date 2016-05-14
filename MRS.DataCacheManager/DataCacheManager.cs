using Common.Const;
using Common.DataBaseAccessor;
using Common.Enums;
using MRS.DataCacheManager.Interfaces;
using MRS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.DataCacheManager
{
    public class DataCacheManager : IDataCacheManager
    {
        private static IDataCacheManager dataCacheManager = null;
        private DataCache dataCache = null;
        private static readonly object locker = new object();
        private bool initializedCache = false;

        private DataCacheManager()
        {
            
        }

        public bool CacheInitialized()
        {
            return this.initializedCache;
        }

        public static IDataCacheManager GetCacheManagerInstance()
        {
            if (dataCacheManager == null)
            {
                lock (locker)
                {
                    if (dataCacheManager == null)
                    {
                        dataCacheManager = new DataCacheManager();
                    }
                }
            }

            return dataCacheManager;
        }

        public void InitilizeDataCache(DatabaseConfig dbConfig = null)
        {
            dataCache = DataCache.GetCacheInstance();
            //Load系统配置
            var systemSettings = LoadSystemSettingFromDB(dbConfig);
            dataCache.SystemSettingCache = systemSettings;
            //Load模板
            var templates = LoadTemplatesFromDB();
            dataCache.TemplateCache.Clear();
            if (templates != null)
            {
                dataCache.TemplateCache.AddRange(templates);
            }

            this.initializedCache = true;
        }

        public List<Template> GetTemplatesFromCache()
        {
            return dataCache.TemplateCache;
        }

        public Dictionary<string, string> GetSystemSettingsFromCache()
        {
            return dataCache.SystemSettingCache;
        }

        public bool UpdateSystemSettingsCache(string key, string value)
        {
            if (dataCache.SystemSettingCache.ContainsKey(key))
            {
                dataCache.SystemSettingCache[key] = value;
            }
            else
            {
                dataCache.SystemSettingCache.Add(key, value);
            }

            return true;
        }

        public void DeleteSystemSettingsCache(string settingKey)
        {
            if (dataCache.SystemSettingCache.ContainsKey(settingKey))
            {
                dataCache.SystemSettingCache.Remove(settingKey);
            }
        }

        /// <summary>
        /// 从数据库获取模板记录
        /// </summary>
        /// <returns></returns>
        private List<Template> LoadTemplatesFromDB()
        {
            try
            {
                var results = new List<Template>();
                var systemSettings = GetSystemSettingsFromCache();
                var dbConfigXml = systemSettings[Enums.SystemSettingKeyEnum.DataBaseConnection.ToString()];
                DatabaseConfig dbConfig = Common.Utility.SerializeUtility<DatabaseConfig>.XmlDeserialize(dbConfigXml);
                var dataSet = SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(dbConfig.Server, dbConfig.Database, dbConfig.User, dbConfig.Password), SqlConst.SP_SELECTTEMPLATE);
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                {
                    var template = new Template();
                    template.RecordId = new Guid(dataRow.ItemArray[0].ToString());
                    template.FileName = dataRow.ItemArray[1].ToString();
                    template.FileTitle = dataRow.ItemArray[2].ToString();
                    template.FileContent = dataRow.ItemArray[3].ToString();

                    results.Add(template);
                }
                return results;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private Dictionary<string, string> LoadSystemSettingFromDB(DatabaseConfig dbConfig = null)
        {
            try
            {
                var results = new Dictionary<string, string>();
                if (dbConfig == null)
                {
                    var systemSettings = GetSystemSettingsFromCache();
                    var dbConfigXml = systemSettings[Enums.SystemSettingKeyEnum.DataBaseConnection.ToString()];
                    dbConfig = Common.Utility.SerializeUtility<DatabaseConfig>.XmlDeserialize(dbConfigXml);
                }

                var dataSet = SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(dbConfig.Server, dbConfig.Database, dbConfig.User, dbConfig.Password), SqlConst.SP_SELECTSYSTEMSETTING);
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                {
                    results.Add(dataRow.ItemArray[1].ToString(), dataRow.ItemArray[2].ToString());
                }
                return results;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
