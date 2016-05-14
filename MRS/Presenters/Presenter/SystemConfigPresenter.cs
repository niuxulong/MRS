using Common.DataBaseAccessor;
using Common.EventArguments;
using MRS.Entity.Entities;
using MRS.Model.Interfaces;
using MRS.Model.Models;
using MRS.Presenters.Interface;
using MRS.Views.Interface;
using System.Collections.Generic;

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
            this.View.RetriveTemplateCatalogConfigTree += HandleRetriveTemplateCatalogTree;
            this.View.CheckDatabaseConnectionAndSaveConfigEvent += HandleCheckDatabaseConnectionAndSaveConfigEvent;
            this.View.RetriveDatabaseConfigEvent += HandleRetriveDatabaseConfigEvent;
        }

        private void HandleRetriveDatabaseConfigEvent(object sender, object e)
        {
            if (DataCacheManager.DataCacheManager.GetCacheManagerInstance().CacheInitialized())
            {
                var config = databaseConfigModel.GetDatabaseConfig();
                if (config != null)
                {
                    this.View.PopulateDatabaseConfig(config);
                }
            }
        }

        private void HandleCheckDatabaseConnectionAndSaveConfigEvent(object sender, SystemConfigEventArgs args)
        {
            var result = SqlHelper.CheckDatabaseConnection(args.DatabaseConfig.Server, args.DatabaseConfig.Database, args.DatabaseConfig.User, args.DatabaseConfig.Password);
            if (!result)
            {
                this.View.NotificationNoDatabaseFound();
            }
            else
            {
                this.SaveSystemConfig(args.DatabaseConfig, args.TemplateCatalogNodes);

                //数据库配置更新后更新cache
                DataCacheManager.DataCacheManager.GetCacheManagerInstance().InitilizeDataCache();

                this.View.CloseForm();
            }
        }

        private void HandleRetriveTemplateCatalogTree(object sender, object e)
        {
            if (DataCacheManager.DataCacheManager.GetCacheManagerInstance().CacheInitialized())
            {
                var templateTreeNodes = templateCatalogModel.GetTemplateCatalogNodes();
                if (templateTreeNodes != null)
                {
                    this.View.PopulateTemplateCatalogConfigTree(templateTreeNodes);
                }    
            }
        }

        private void SaveSystemConfig(DatabaseConfig databaseConfig, List<TemplateCatalogNode> templateCatalogNodes)
        {
            databaseConfigModel.UpdateOrAddDatabaseConfig(databaseConfig);
            if (templateCatalogNodes.Count == 0)
            {
                templateCatalogModel.DeleteTemplateCatgalogNodes();
            }
            else
            {
                templateCatalogModel.UpdateOrAddTemplateCatgalogNodes(templateCatalogNodes);
            }
        }
    }
}
