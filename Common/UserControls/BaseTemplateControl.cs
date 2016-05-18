using MRS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Common.UserControls
{
    public partial class BaseTemplateControl : UserControl
    {
        public event EventHandler<string> SearchButtonClickEvent;
        public event EventHandler<Template> SelectButtonClickEvent;

        public bool ShowSelectButton
        {
            get { return this.btn_Select.Visible; }
            set { this.btn_Select.Visible = value; }
        }

        public bool EditorReadonly
        {
            get { return this.writerControl.Readonly; }
            set { this.writerControl.Readonly = value; }
        }

        public Template SelectedTemplate
        {
            get { return dgv_templateList.SelectedRows[0].DataBoundItem as Template; }
        }

        public BaseTemplateControl()
        {
            InitializeComponent();
            ConfigDgvTemplateList();
        }

        public void DeleteSelectedTemplate()
        {
            var selectedTemplate = dgv_templateList.SelectedRows[0].DataBoundItem as Template;
            var templates = dgv_templateList.DataSource as List<Template>;
            templates.Remove(selectedTemplate);
            dgv_templateList.DataSource = templates;
        }

        private void dgv_templateList_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgv_templateList.SelectedRows.Count > 0)
            //{
            //    var selectedTemplate = dgv_templateList.SelectedRows[0].DataBoundItem as Template;
            //    if (selectedTemplate != null)
            //    {
            //        this.writerControl.XMLText = selectedTemplate.FileContent;
            //    }
            //}
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (SearchButtonClickEvent != null)
            {
                SearchButtonClickEvent(sender, tb_forSearch.Text.Trim());
            }
        }

        public void PopulateTemlatesInfo(List<Template> templates)
        {
            dgv_templateList.DataSource = null;
            dgv_templateList.DataSource = templates;
        }

        private void ConfigDgvTemplateList()
        {
            this.dgv_templateList.SelectionChanged += dgv_templateList_SelectionChanged;
            this.dgv_templateList.AutoGenerateColumns = false;
            this.dgv_templateList.ColumnCount = 2;
            this.dgv_templateList.Columns["col_Number"].DataPropertyName = "ParentNodeId";
            this.dgv_templateList.Columns["col_Name"].DataPropertyName = "FileName";
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            if (dgv_templateList.SelectedRows.Count > 0 && SelectButtonClickEvent != null)
            {
                var selectedTemplate = dgv_templateList.SelectedRows[0].DataBoundItem as Template;
                SelectButtonClickEvent(sender, selectedTemplate);
            }
        }

        private void dgv_templateList_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_templateList.SelectedRows.Count > 0)
            {
                var selectedTemplate = dgv_templateList.SelectedRows[0].DataBoundItem as Template;
                if (selectedTemplate != null)
                {
                    this.writerControl.XMLText = selectedTemplate.FileContent;
                }
            }
        }
    }
}
