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
    public class TemplatePresenter: ITemplatePresenter
    {
        private ITemplateModel templateModel;

        public TemplatePresenter()
        { 
            templateModel = new TemplateModel();
        }

        public List<Template> GetTemplates()
        {
            return templateModel.GetTemplates();
        }
    }
}
