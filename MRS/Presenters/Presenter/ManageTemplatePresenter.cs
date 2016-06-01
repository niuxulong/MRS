using Common.Enums;
using MRS.Entity.Entities;
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
    public class ManageTemplatePresenter : Presenter<IManageTemplateView>
    {
        private ITemplateModel templateModel;
        private ITemplateCatalogModel templateCatalogModel;

        public ManageTemplatePresenter(IManageTemplateView view)
            : base(view)
        {
            this.templateModel = new TemplateModel();
            this.templateCatalogModel = new TemplateCatalogModel();
        }

        protected override void OnViewSet()
        {
            this.View.SearchTemplatesEvent += HandleSearchTemplatesEvent;
            this.View.DeleteTemplateEvent += HandleDeleteTemplateEvent;
            this.View.SaveTemplateEvent += HandleSaveTemplateEvent;
            this.View.RetriveTemplateParentNodes += HandleRetriveTemplateParentNodes;
        }

        private void HandleRetriveTemplateParentNodes(object sender, object e)
        {
            var nodes = templateCatalogModel.GetTemplateCatalogNodes();
            if (nodes != null)
            {
                var parentNodes = new List<TemplateCatalogNode>();
                foreach (var node in nodes)
                {
                    parentNodes.AddRange(node.ChildTemplateNodeList);
                }
                this.View.PopulateTemplatesParentNodes(parentNodes);
            }
        }

        void HandleSaveTemplateEvent(object sender, Entity.Entities.Template template)
        {
            templateModel.UpdateTemplate(template);
        }

        void HandleDeleteTemplateEvent(object sender, Entity.Entities.Template template)
        {
            templateModel.RemoveTemplates(template);
            HandleSearchTemplatesEvent(string.Empty, template.ParentNodeId);
            this.View.ClearViewAfterDeletedTemplate();
        }

        private void HandleSearchTemplatesEvent(string args, int parentNodeId)
        {
            //只检索个人模板
            var templates = templateModel.GetTemplatesByFilter(args, parentNodeId, Enums.TemplateAttrEnum.Personal);
            if (templates != null)
            {
                this.View.PopulateTemlatesInfo(templates);
            }
        }
    }
}
