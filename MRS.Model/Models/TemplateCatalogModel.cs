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
        private List<TemplateCatalogNode> testNodes;

        public TemplateCatalogModel()
        {
            //Just for test now
            testNodes = new List<TemplateCatalogNode>();
            var childNode11 = new TemplateCatalogNode()
            {
                TemplateNodeId = 11,
                TemplateNodeName = "病案1"
            };
            var childNode12 = new TemplateCatalogNode()
            {
                TemplateNodeId = 12,
                TemplateNodeName = "病案2"
            };
            var list1 = new List<TemplateCatalogNode>();
            list1.Add(childNode11);
            list1.Add(childNode12);
            var parentNode1 = new TemplateCatalogNode()
            {
                TemplateNodeId = 1,
                TemplateNodeName = "病案首页",
                ChildTemplateNodeList = list1
            };


            var childNode21 = new TemplateCatalogNode()
            {
                TemplateNodeId = 21,
                TemplateNodeName = "入院记录1"
            };
            var childNode22 = new TemplateCatalogNode()
            {
                TemplateNodeId = 22,
                TemplateNodeName = "入院记录2"
            };
            var list2 = new List<TemplateCatalogNode>();
            list2.Add(childNode21);
            list2.Add(childNode22);
            var parentNode2 = new TemplateCatalogNode()
            {
                TemplateNodeId = 2,
                TemplateNodeName = "入院记录",
                ChildTemplateNodeList = list2
            };


            testNodes.Add(parentNode1);
            testNodes.Add(parentNode2);
        }

        public List<TemplateCatalogNode> GetTemplateCatalogNodes()
        {
            var systemSettingsDic = DataCacheManager.DataCacheManager.GetCacheManagerInstance().GetSystemSettingsFromCache();
            if (systemSettingsDic.ContainsKey(Enums.SystemSettingKeyEnum.TemplateCatalogNode.ToString()))
            {
                var templateCatalogNodeXml = DataCacheManager.DataCacheManager.GetCacheManagerInstance().GetSystemSettingsFromCache()[Enums.SystemSettingKeyEnum.TemplateCatalogNode.ToString()];
                return SerializeUtility<List<TemplateCatalogNode>>.XmlDeserialize(templateCatalogNodeXml);
            }
            else
            {
                return testNodes;
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
