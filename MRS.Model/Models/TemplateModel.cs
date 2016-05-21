using Common.Const;
using Common.DataBaseAccessor;
using Common.Enums;
using MRS.Entity.Entities;
using MRS.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Model.Models
{
    public class TemplateModel: ITemplateModel
    {
        public TemplateModel()
        { 
        
        }

        public List<Template> GetTemplatesByFilter(string name, int parentNodeId, Enums.TemplateAttrEnum templateAttr)
        {
            var allTemplates = DataCacheManager.DataCacheManager.GetCacheManagerInstance().GetTemplatesFromCache();
            if(!string.IsNullOrEmpty(name))
            {
                allTemplates = allTemplates.Where(t=>t.FileName.Contains(name)).ToList();
            }

            if(parentNodeId != 0)
            {
                allTemplates = allTemplates.Where(t=>t.ParentNodeId == parentNodeId).ToList();
            }

            if (templateAttr == Enums.TemplateAttrEnum.Common || templateAttr == Enums.TemplateAttrEnum.Personal)
            {
                allTemplates = allTemplates.Where(t => t.TemplateAttr == (int)templateAttr).ToList();
            }

            return allTemplates;
        }

        public bool UpdateTemplate(Template template)
        {
            try
            {
                var updateCacheSuccess = false;
                var rowAmount = SqlHelper.ExecuteNonQuery(SqlHelper.GetConnSting(), SqlConst.SP_UPDATETEMPLATE, GetUpdateTemplateParams(template.RecordId.ToString(), template.ParentNodeId, template.FileName, template.FileContent,template.CreatedById,template.CreatedBy,template.TemplateAttr));
                if (rowAmount > 0)
                {
                    updateCacheSuccess = DataCacheManager.DataCacheManager.GetCacheManagerInstance().UpdateTemplateCache(template);
                }
                return updateCacheSuccess; 
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool InsertTemplate(Template template)
        {
            try
            {
                var updateCacheSuccess = false;
                var rowAmount = SqlHelper.ExecuteNonQuery(SqlHelper.GetConnSting(), SqlConst.SP_INSERTTEMPLATE, GetUpdateTemplateParams(template.RecordId.ToString(), template.ParentNodeId, template.FileName, template.FileContent,template.CreatedById,template.CreatedBy,template.TemplateAttr));
                if (rowAmount > 0)
                {
                    updateCacheSuccess = DataCacheManager.DataCacheManager.GetCacheManagerInstance().InsertTemplateToCache(template);
                }
                return updateCacheSuccess;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool RemoveTemplates(Template template)
        {
            try
            {
                var updateCacheSuccess = false;
                var rowAmount = SqlHelper.ExecuteNonQuery(SqlHelper.GetConnSting(), SqlConst.SP_DELETETETEMPLATE, new object[] { template.RecordId.ToString() });
                if (rowAmount > 0)
                {
                     DataCacheManager.DataCacheManager.GetCacheManagerInstance().RemoveTemplateFromCache(template);
                }
                return updateCacheSuccess;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private object[] GetUpdateTemplateParams(string recordId, int parentId, string fileName, string fileContent,string createdById,string createdBy,int templateAttr)
        {
            return new object[] { recordId, parentId, fileName, fileContent, createdById, createdBy, templateAttr };
        }
    }
}
