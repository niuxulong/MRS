using MRS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Views.Interface
{
    public interface IManageTemplateView
    {
        event EventHandler<string> SearchTemplatesEvent;
        
        event EventHandler<Template> DeleteTemplateEvent;
		
        event EventHandler<Template> SaveTemplateEvent;
        
        event EventHandler RetriveTemplateParentNodes;

        void PopulateTemlatesInfo(List<Template> templates);

        void PopulateTemplatesParentNodes(List<TemplateCatalogNode> nodes);
    }
}
