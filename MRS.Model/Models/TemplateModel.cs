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

        public List<Template> GetTemplates()
        {
            return DataCacheManager.DataCacheManager.GetCacheManagerInstance().GetTemplatesFromCache();
        }
    }
}
