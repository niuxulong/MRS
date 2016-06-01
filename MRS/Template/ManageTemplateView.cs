using MRS.Entity.Entities;
using MRS.Presenters.Presenter;
using MRS.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MRS
{
    public delegate void SearchTemplateEventHandler(string name,int parentId);
    public partial class ManageTemplate : ViewBase, IManageTemplateView
    {
        #region 事件
        public event SearchTemplateEventHandler SearchTemplatesEvent;
        public event EventHandler<Template> DeleteTemplateEvent;
		public event EventHandler<Template> SaveTemplateEvent;
        public event EventHandler RetriveTemplateParentNodes;
        #endregion

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
            if (RetriveTemplateParentNodes != null)
            {
                RetriveTemplateParentNodes(null, null);
            }
        }

        private void HandleSearchButtonClickEvent(object sender, string args)
        {
            if (SearchTemplatesEvent != null)
            {
                SearchTemplatesEvent( args,Convert.ToInt32(this.cbb_ParentNodes.SelectedValue));
            }
        }

        public void PopulateTemplatesParentNodes(List<TemplateCatalogNode> nodes)
        {
            this.cbb_ParentNodes.DataSource = nodes;
            this.cbb_ParentNodes.DisplayMember = "TemplateNodeName";
            this.cbb_ParentNodes.ValueMember = "TemplateNodeId";
        }

        public void PopulateTemlatesInfo(List<Template> templates)
        {
            baseTemplateControl.PopulateTemlatesInfo(templates);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "确定删除模板？", "删除模板", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (this.baseTemplateControl.SelectedTemplate != null)
                    if (DeleteTemplateEvent != null)
                        DeleteTemplateEvent(sender, this.baseTemplateControl.SelectedTemplate);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.baseTemplateControl.SelectedTemplate != null)
                    if (SaveTemplateEvent != null)
                        SaveTemplateEvent(sender, this.baseTemplateControl.SelectedTemplate);

                MessageBox.Show("保存成功");
            }
            catch (Exception ex)
            {

                throw;
            }
			
        }

        private void cbb_ParentNodes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ClearViewAfterDeletedTemplate()
        {
            this.baseTemplateControl.ClearViewAfterDeletedTemplate();
        }
    }
}
