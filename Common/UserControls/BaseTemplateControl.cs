using MRS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Common.UserControls
{
	public partial class BaseTemplateControl : UserControl
	{
        public event EventHandler<string> SearchButtonClickEvent; 

		public BaseTemplateControl()
		{
			InitializeComponent();
            ConfigColumns();
		}

        private void dgv_templateList_SelectionChanged(object sender, EventArgs e)
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

        private void ConfigColumns()
        {
            this.dgv_templateList.Columns["col_Number"].DataPropertyName = "RecordId";
            this.dgv_templateList.Columns["col_Name"].DataPropertyName = "FileName";
        }
	}
}
