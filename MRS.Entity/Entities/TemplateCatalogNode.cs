using System.Collections.Generic;
using System.Windows.Forms;

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

        public TreeNode ToTreeNode()
        {
            var parentNode = new TreeNode()
            {
                Tag = this.TemplateNodeId,
                Name = this.TemplateNodeName,
                Text = this.TemplateNodeName
            };
            foreach (var cNode in this.ChildTemplateNodeList)
            {
                var childNode = new TreeNode()
                {
                    Tag = cNode.TemplateNodeId,
                    Name = cNode.TemplateNodeName,
                    Text = cNode.TemplateNodeName
                };

                parentNode.Nodes.Add(childNode);
            }

            return parentNode;
        }
    }
}
