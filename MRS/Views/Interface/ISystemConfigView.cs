using Common.EventArguments;
using MRS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Views.Interface
{
    public interface ISystemConfigView : IViewBase
    {
        event EventHandler<SystemConfigEventArgs> SaveSystemConfigEvent;

        event EventHandler RetriveTemplateCatalogConfigTree;

        void PopulateTemplateCatalogConfigTree(List<TemplateCatalogNode> nodes);
    }
}
