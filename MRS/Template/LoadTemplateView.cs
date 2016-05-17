using MRS.Entity.Entities;
using MRS.Presenters.Presenter;
using MRS.Views.Interface;
using System;
using System.Collections.Generic;

namespace MRS
{
    public partial class LoadTemplateView : ViewBase, ILoadTemplateView
    {
        #region Event Handler
        public event EventHandler<Tuple<string, int, bool>> SearchTemplatesEvent;
        public event EventHandler<Template> SelectTemplateEvent;
        #endregion

        TemplateCatalogNode templateCatalog = null;
        string name = string.Empty;

        public LoadTemplateView(TemplateCatalogNode templateCatalog)
        {
            this.templateCatalog = templateCatalog;
            InitializeComponent();
        }

        protected override object CreatePresenter()
        {
            return new LoadTemplatePresenter(this);
        }

        private void LoadTemplateView_Load(object sender, System.EventArgs e)
        {
            this.baseTemplateControl.EditorReadonly = true;
            baseTemplateControl.SearchButtonClickEvent += HandleSearchButtonClickEvent;
            baseTemplateControl.SelectButtonClickEvent += HandleSelectButtonClickEvent;
        }


        public void PopulateTemlatesInfo(List<Template> templates)
        {
            baseTemplateControl.PopulateTemlatesInfo(templates);
        }

        private void HandleSearchButtonClickEvent(object sender, string name)
        {
            this.name = name;
            PopupTemplates(sender);
        }

        private void PopupTemplates(object sender)
        {
            if (SearchTemplatesEvent != null)
            {
                Tuple<string, int, bool> args = new Tuple<string, int, bool>(this.name, templateCatalog.TemplateNodeId, this.chb_Common.Checked == this.chb_private.Checked == false ? true : this.chb_Common.Checked);
                SearchTemplatesEvent(sender, args);
            }
        }

        private void HandleSelectButtonClickEvent(object sender, Template args)
        {
            if (SelectTemplateEvent != null)
            {
                SelectTemplateEvent(sender, args);
            }

            this.Close();
        }

        private void baseTemplateControl_Load(object sender, EventArgs e)
        {

        }

        private void chb_Common_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chb_Common.Checked)
            {
                this.chb_private.Checked = false;
                PopupTemplates(null);
            }
        }

        private void chb_private_CheckedChanged(object sender, EventArgs e)
        {

            if (this.chb_private.Checked)
            {
                this.chb_Common.Checked = false;
                PopupTemplates(null);
            }
        }
    }
}
