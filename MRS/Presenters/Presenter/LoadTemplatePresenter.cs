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
    public class LoadTemplatePresenter : Presenter<ILoadTemplateView>
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

        private void HandleSearchTemplatesEvent(object sender, Tuple<string, int, bool> args)
        {
            var name = args.Item1;
            var templateId = args.Item2;
            var isCommon = args.Item3;
            var templateAttr = isCommon ? 0 : 1;
            var templates = templateModel.GetTemplatesByName(name);
            if (templates != null && templates.Count > 0)
            {
                this.View.PopulateTemlatesInfo(templates.Where(t => t.ParentNodeId == templateId && t.TemplateAttr == templateAttr).ToList());
            }
        }
    }
}
