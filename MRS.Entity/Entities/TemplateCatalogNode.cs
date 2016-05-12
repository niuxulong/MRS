using System.Collections.Generic;

namespace MRS.Entity.Entities
{
    public class TemplateCatalogNode
    {
        public int TemplateNodeId { get; set; }

        public string TemplateNodeName { get; set; }

        public int TemplateParentNodeId { get; set; }

        public List<TemplateCatalogNode> ChildTemplateNodeList { get; set; }

        public bool IsParentTemplateNode 
        {
            get
            {
                return ChildTemplateNodeList != null && ChildTemplateNodeList.Count > 0;
            }
        }
    }
}
