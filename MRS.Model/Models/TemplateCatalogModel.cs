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

        public List<TemplateCatalogNode> GetTemplateCatalogNode()
        {
            var templateCatalogNodeXml = DataCacheManager.DataCacheManager.GetCacheManagerInstance().GetSystemSettingsFromCache()["TemplateCatalogNode"];



            return null;
        }
    }
}

/*
//
 
<xml>
    <ParentTemplateCatalog Id=1 Name=入院记录>
        <ChildTemplateCatalog Id=1 Name=节点1/>
        <ChildTemplateCatalog Id=2 Name=节点2/>
    </ParentTemplateCatalog>

    <ParentTemplateCatalog Id=2 Name=入院记录>
        <ChildTemplateCatalog Id=1 Name=节点1/>
        <ChildTemplateCatalog Id=2 Name=节点2/>
    </ParentTemplateCatalog>
</xml>
*/
