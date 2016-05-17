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
            var currentNode = new TreeNode()
            {
                Name = this.TemplateNodeName,
                Text = this.TemplateNodeName
            };
            currentNode.Tag = this;
            foreach (var cNode in this.ChildTemplateNodeList)
            {
                var childNode = new TreeNode()
                {
                    Name = cNode.TemplateNodeName,
                    Text = cNode.TemplateNodeName
                };
                childNode.Tag = cNode;
                currentNode.Nodes.Add(childNode);
            }

            return currentNode;
        }
    }
}
