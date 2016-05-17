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
        void PopulateTemlatesInfo(List<Template> templates);
    }
}
