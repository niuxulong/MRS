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
        public event EventHandler<string> SearchTemplatesEvent;
        #endregion

        public LoadTemplateView()
		{
			InitializeComponent();
		}

        protected override object CreatePresenter()
        {
            return new LoadTemplatePresenter(this);
        }

        private void LoadTemplateView_Load(object sender, System.EventArgs e)
        {
            baseTemplateControl.SearchButtonClickEvent += HandleSearchButtonClickEvent;
        }

        public void PopulateTemlatesInfo(List<Template> templates)
        {
            baseTemplateControl.PopulateTemlatesInfo(templates);
        }

        private void HandleSearchButtonClickEvent(object sender, string args)
        {
            if (SearchTemplatesEvent != null)
            {
                SearchTemplatesEvent(sender, args);
            }
        }
	}
}
