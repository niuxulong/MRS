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
    public class TemplateCatalogModel : SystemConfigBaseModel<List<TemplateCatalogNode>>, ITemplateCatalogModel
    {
        public TemplateCatalogModel()
        {
            
        }

        public List<TemplateCatalogNode> GetTemplateCatalogNodes()
        {
            return this.GetSystemConfig(Enums.SystemSettingKeyEnum.TemplateCatalogNode);
        }

        public bool UpdateOrAddTemplateCatgalogNodes(List<TemplateCatalogNode> nodes)
        {
            return this.UpdateOrAddSystemConfig(nodes, Enums.SystemSettingIdEnum.TemplateCatalogNodeId, Enums.SystemSettingKeyEnum.TemplateCatalogNode);
        }

        public bool DeleteTemplateCatgalogNodes()
        {
            return this.DeleteSystemConfig(Enums.SystemSettingIdEnum.TemplateCatalogNodeId, Enums.SystemSettingKeyEnum.TemplateCatalogNode);
        }
    }
}
