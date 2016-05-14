using MRS.Model.Interfaces;
using MRS.Model.Models;
using MRS.Presenters.Interface;
using MRS.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Presenters.Presenter
{
    public class LoadTemplatePresenter: Presenter<ILoadTemplateView>
    {
        public ITemplateModel templateModel { get; private set; }

        public LoadTemplatePresenter(ILoadTemplateView view)
            : base(view)
        {
            this.templateModel = new TemplateModel();
        }

        protected override void OnViewSet()
        {
            this.View.SearchTemplatesEvent += HandleSearchTemplatesEvent;
        }

        private void HandleSearchTemplatesEvent(object sender, string args)
        {
            var templates = templateModel.GetTemplatesByName(args);
            if (templates != null && templates.Count > 0)
            {
                this.View.PopulateTemlatesInfo(templates);
            }
        }
    }
}
