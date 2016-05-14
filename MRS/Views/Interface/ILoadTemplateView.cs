using MRS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Views.Interface
{
    public interface ILoadTemplateView
    {
        event EventHandler<string> SearchTemplatesEvent;

        void PopulateTemlatesInfo(List<Template> templates);

        event EventHandler<Template> SelectTemplateEvent;
    }
}
