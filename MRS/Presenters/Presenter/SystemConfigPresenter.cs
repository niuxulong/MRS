using Common.DataBaseAccessor;
using Common.EventArguments;
using MRS.Entity.Entities;
using MRS.Model.Interfaces;
using MRS.Model.Models;
using MRS.Presenters.Interface;
using MRS.Views.Interface;
using System.Collections.Generic;
using System.Configuration;

namespace MRS.Presenters.Presenter
{
    public class SystemConfigPresenter : Presenter<ISystemConfigView>
    {
        public ITemplateCatalogModel templateCatalogModel { get; private set; }

        public SystemConfigPresenter(ISystemConfigView view)
            : base(view)
        {
            this.templateCatalogModel = new TemplateCatalogModel();
        }

        protected override void OnViewSet()
        {
            this.View.RetriveTemplateCatalogConfigTree += HandleRetriveTemplateCatalogTree;
            this.View.SaveSystemConfigsAndCheckDBConnectionEvent += HandleSaveSystemConfigsAndCheckDBConnectionEvent;
            this.View.RetriveDatabaseConfigEvent += HandleRetriveDatabaseConfigEvent;
        }

        private void HandleRetriveDatabaseConfigEvent(object sender, object e)
        {
            var connString = SqlHelper.GetConnSting();
            var config = DatabaseConfig.FromString(connString);
            if (config != null)
            {
                this.View.PopulateDatabaseConfig(config);
            }
        }

        private void HandleSaveSystemConfigsAndCheckDBConnectionEvent(object sender, SystemConfigEventArgs args)
        {
            //保存本数据库的系统配置
			//this.SaveSystemConfig(args.TemplateCatalogNodes);
            //检查新数据库连接
            var canConnect = SqlHelper.CheckDatabaseConnection(args.DatabaseConfig.Server, args.DatabaseConfig.Database, args.DatabaseConfig.User, args.DatabaseConfig.Password);
            if (!canConnect)
            {
                this.View.NotificationNoDatabaseFound();
            }
            else
            {
                // 更新配置文件数据库连接
                var settings = new ConnectionStringSettings()
                {
                    Name = "ConStr",
                    ConnectionString = SqlHelper.GenerateConnString(args.DatabaseConfig.Server, args.DatabaseConfig.Database, args.DatabaseConfig.User, args.DatabaseConfig.Password)

                };

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings.Clear();
                config.ConnectionStrings.ConnectionStrings.Add(settings);

                config.Save(ConfigurationSaveMode.Modified);  
                ConfigurationManager.RefreshSection("connectionStrings");

                //数据库配置更新后从新数据库更新cache
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

        private void SaveSystemConfig(List<TemplateCatalogNode> templateCatalogNodes)
        {
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
