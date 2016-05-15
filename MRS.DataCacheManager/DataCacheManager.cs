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

        public void InitilizeDataCache()
        {
            dataCache = DataCache.GetCacheInstance();
            //Load系统配置
            var systemSettings = LoadSystemSettingFromDB();
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
            if (dataCache != null)
            {
                return dataCache.TemplateCache;    
            }
            return new List<Template>();
        }

        public Dictionary<string, string> GetSystemSettingsFromCache()
        {
            return dataCache.SystemSettingCache;
        }

        public bool UpdateTemplateCache(Template template)
        {
            var pendingUpdateTemplate = dataCache.TemplateCache.Where(x => x.RecordId == template.RecordId).FirstOrDefault();
            dataCache.TemplateCache[dataCache.TemplateCache.IndexOf(pendingUpdateTemplate)] = template;
            return true;
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
                var dataSet = SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(), SqlConst.SP_SELECTTEMPLATE);
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                {
                    var template = new Template();
                    template.RecordId = new Guid(dataRow.ItemArray[0].ToString());
                    template.FileName = dataRow.ItemArray[1].ToString();
                    template.FileTitle = dataRow.ItemArray[2].ToString();
                    template.FileContent = dataRow.ItemArray[3].ToString();
                    template.ParentNodeId = (int)dataRow.ItemArray[4];
                    template.CreatedById = dataRow.ItemArray[5].ToString();
                    template.CreatedBy = dataRow.ItemArray[6].ToString();
                    int templateAttr = 0;
                    int.TryParse(dataRow.ItemArray[7].ToString(), out templateAttr);
                    template.TemplateAttr = templateAttr;
                    results.Add(template);
                }
                return results;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private Dictionary<string, string> LoadSystemSettingFromDB()
        {
            try
            {
                var results = new Dictionary<string, string>();
                var dataSet = SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(),SqlConst.SP_SELECTSYSTEMSETTING);
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
