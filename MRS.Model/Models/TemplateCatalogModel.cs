using Common.Utility;
using MRS.Entity.Entities;
using MRS.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Model.Models
{
    public class TemplateCatalogModel: ITemplateCatalogModel
    {
        public TemplateCatalogModel()
        { 
        
        }

        public List<TemplateCatalogNode> GetTemplateCatalogNodes()
        {
            var systemSettingsDic = DataCacheManager.DataCacheManager.GetCacheManagerInstance().GetSystemSettingsFromCache();
            if (systemSettingsDic.ContainsKey("TemplateCatalogNode"))
            {
                var templateCatalogNodeXml = DataCacheManager.DataCacheManager.GetCacheManagerInstance().GetSystemSettingsFromCache()["TemplateCatalogNode"];
                return SerializeUtility<List<TemplateCatalogNode>>.XmlDeserialize(templateCatalogNodeXml);
            }

            return null;
        }
    }
}
