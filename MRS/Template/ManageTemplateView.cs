using MRS.Entity.Entities;
using MRS.Presenters.Presenter;
using MRS.Views.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRS
{
    public partial class ManageTemplate : ViewBase, IManageTemplateView
    {
        public event EventHandler<string> SearchTemplatesEvent;
        public event EventHandler<Template> DeleteTemplateEvent;
		public event EventHandler<Template> SaveTemplateEvent;

        public ManageTemplate()
        {
            InitializeComponent();
            this.baseTemplateControl.ShowSelectButton = false;
        }

        protected override object CreatePresenter()
        {
            return new ManageTemplatePresenter(this);
        }

        private void ManageTemplate_Load(object sender, EventArgs e)
        {
            baseTemplateControl.SearchButtonClickEvent += HandleSearchButtonClickEvent;
        }

        private void HandleSearchButtonClickEvent(object sender, string args)
        {
            if (SearchTemplatesEvent != null)
            {
                SearchTemplatesEvent(sender, args);
            }
        }

        public void PopulateTemlatesInfo(List<Template> templates)
        {
            baseTemplateControl.PopulateTemlatesInfo(templates);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "ȷ��ɾ��ģ�壿", "ɾ��", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (this.baseTemplateControl.SelectedTemplate != null)
                    if (DeleteTemplateEvent != null)
                        DeleteTemplateEvent(sender, this.baseTemplateControl.SelectedTemplate);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
			if (this.baseTemplateControl.SelectedTemplate != null)
				if (SaveTemplateEvent != null)
					SaveTemplateEvent(sender, this.baseTemplateControl.SelectedTemplate);
        }
    }
}
