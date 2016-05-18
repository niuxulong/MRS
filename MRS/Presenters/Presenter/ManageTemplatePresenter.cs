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
    public class ManageTemplatePresenter: Presenter<IManageTemplateView>
    {
        public ITemplateModel templateModel { get; private set; }

        public ManageTemplatePresenter(IManageTemplateView view)
            : base(view)
        {
            this.templateModel = new TemplateModel();
        }

        protected override void OnViewSet()
        {
            this.View.SearchTemplatesEvent += HandleSearchTemplatesEvent;
            this.View.DeleteTemplateEvent += View_DeleteTemplateEvent;
			this.View.SaveTemplateEvent += View_SaveTemplateEvent;
        }

		void View_SaveTemplateEvent(object sender, Entity.Entities.Template template)
		{
			templateModel.UpdateTemplate(template);
		}

        void View_DeleteTemplateEvent(object sender, Entity.Entities.Template template)
        {
            templateModel.RemoveTemplates(template);
            HandleSearchTemplatesEvent(null, null);

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
