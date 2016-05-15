using Common.Const;
using Common.DataBaseAccessor;
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

        public List<Template> GetTemplatesByName(string name)
        {
            var allTemplates = DataCacheManager.DataCacheManager.GetCacheManagerInstance().GetTemplatesFromCache();
            if (string.IsNullOrEmpty(name))
            {
                return allTemplates;
            }
            else
            {
                return allTemplates.Where(t => t.FileName.Contains(name)).ToList();
            }
        }

        public bool UpdateTemplate(Template template)
        {
            try
            {
                var updateCacheSuccess = false;
                var rowAmount = SqlHelper.ExecuteNonQuery(SqlHelper.GetConnSting(), SqlConst.SP_UPDATETEMPLATE, GetUpdateTemplateParams(template.RecordId.ToString(), template.ParentNodeId, template.FileName, template.FileContent));
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

        private object[] GetUpdateTemplateParams(string recordId, int parentId, string fileName, string fileContent)
        {
            return new object[]{recordId, parentId, fileName, fileContent};
        }
    }
}
