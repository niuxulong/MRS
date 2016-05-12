﻿using Common.Const;
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
        private DataCacheManager()
        {
            
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
            var templates = LoadTemplatesFromDB();
            dataCache.TemplateCache.AddRange(templates);

            var systemSettings = LoadSystemSettingFromDB();
            dataCache.SystemSettingCache = systemSettings;
            
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
                var dataSet = SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(), SqlConst.SP_SELECTSYSTEMSETTING);
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