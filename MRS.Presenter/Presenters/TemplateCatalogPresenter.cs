using MRS.Entity.Entities;
using MRS.Model.Interfaces;
using MRS.Model.Models;
using MRS.Presenter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Presenter.Presenters
{
    public class TemplateCatalogPresenter : ITemplateCatalogPresenter
    {
        private ITemplateCatalogModel templateCatalogModel;

        public TemplateCatalogPresenter()
        {
            templateCatalogModel = new TemplateCatalogModel();
        }
        public List<TemplateCatalogNode> GetTemplateCatalogNodes()
        {
            return templateCatalogModel.GetTemplateCatalogNodes();
        }
    }
}
