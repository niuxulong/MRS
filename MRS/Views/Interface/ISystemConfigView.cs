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
        event EventHandler RetriveTemplateCatalogConfigTree;

        event EventHandler<SystemConfigEventArgs> SaveSystemConfigsAndCheckDBConnectionEvent;

        event EventHandler RetriveDatabaseConfigEvent;

        void PopulateTemplateCatalogConfigTree(List<TemplateCatalogNode> nodes);

        void PopulateDatabaseConfig(DatabaseConfig config);

        void NotificationNoDatabaseFound();

        void CloseForm();
    }
}
