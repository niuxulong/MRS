using Common.EventArguments;
using MRS.Model.Interfaces;
using MRS.Model.Models;
using MRS.Presenters.Interface;
using MRS.Views.Interface;

namespace MRS.Presenters.Presenter
{
    public class SystemConfigPresenter: Presenter<ISystemConfigView>
    {
        public IDatabaseConfigModel databaseConfigModel { get; private set; }
        public ITemplateCatalogModel templateCatalogModel { get; private set; }

        public SystemConfigPresenter(ISystemConfigView view)
            : base(view)
        {
            this.databaseConfigModel = new DatabaseConfigModel();
            this.templateCatalogModel = new TemplateCatalogModel();
        }

        protected override void OnViewSet()
        {
            this.View.SaveSystemConfigEvent += HandleSaveSystemConfigEvent;
            this.View.RetriveTemplateCatalogConfigTree += HandleRetriveTemplateCatalogTree;

        }

        private void HandleRetriveTemplateCatalogTree(object sender, object e)
        {
            var templateTreeNodes = templateCatalogModel.GetTemplateCatalogNodes();
            if (templateTreeNodes != null)
            {
                this.View.PopulateTemplateCatalogConfigTree(templateTreeNodes);
            }
        }

        private void HandleSaveSystemConfigEvent(object sender, SystemConfigEventArgs args)
        {
            if (args.TemplateCatalogNodes.Count == 0)
            {
                templateCatalogModel.DeleteTemplateCatgalogNodes();
            }
            else
            {
                templateCatalogModel.UpdateOrAddTemplateCatgalogNodes(args.TemplateCatalogNodes);
            }
            databaseConfigModel.UpdateOrAddDatabaseConfig(args.DatabaseConfig);
        }
    }
}
