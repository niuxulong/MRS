using Common.Const;
using Common.DataBaseAccessor;
using Common.Enums;
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
            if (systemSettingsDic.ContainsKey(Enums.SystemSettingKeyEnum.TemplateCatalogNode.ToString()))
            {
                var templateCatalogNodeXml = DataCacheManager.DataCacheManager.GetCacheManagerInstance().GetSystemSettingsFromCache()[Enums.SystemSettingKeyEnum.TemplateCatalogNode.ToString()];
                return SerializeUtility<List<TemplateCatalogNode>>.XmlDeserialize(templateCatalogNodeXml);
            }

            return null;
        }

        public bool UpdateOrAddTemplateCatgalogNodes(List<TemplateCatalogNode> nodes)
        {
            try
            {
                var templateCatalogXml = SerializeUtility<List<TemplateCatalogNode>>.XmlSerialize(nodes);
                var rowAmount = SqlHelper.ExecuteNonQuery(SqlHelper.GetConnSting(), SqlConst.SP_ADDUPDATESYSTEMSETTING, new object[] { (int)Enums.SystemSettingIdEnum.TemplateCatalogNodeId, Enums.SystemSettingKeyEnum.TemplateCatalogNode.ToString(), templateCatalogXml });
                var updateCacheSuccess = false;
                if (rowAmount > 0)
                {
                   updateCacheSuccess = DataCacheManager.DataCacheManager.GetCacheManagerInstance().UpdateSystemSettingsCache(Enums.SystemSettingKeyEnum.TemplateCatalogNode.ToString(), templateCatalogXml);
                }

                return updateCacheSuccess && rowAmount > 0;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
