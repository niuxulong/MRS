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
    public delegate void CreateTemplatEventTemplate(int parentId, string name,int templateAttr);
    public partial class SaveTemplate : Form
    {
        public event CreateTemplatEventTemplate CreateTemplateEvent;

        public SaveTemplate()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_TemplateName.Text.Trim()))
            {
                MessageBox.Show("请输入模板名称");
                return;
            }
            if (CreateTemplateEvent != null)
            {
                CreateTemplateEvent(Convert.ToInt32(this.tb_ParentNodeId.Text), tb_TemplateName.Text.Trim(), this.chb_Common.Checked ? 0 : 1);
            }

            this.Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_TemplateName.Text = string.Empty;
        }

        public void PopulateSelectedTemplateInfo(int parentNodeId, string parentNodeName, string fileName, string createdDate)
        {
            this.tb_ParentNodeId.Text = parentNodeId.ToString();
            this.tb_ParentNodeName.Text = parentNodeName;
            this.tb_TemplateName.Text = fileName;
            this.tb_CreateDate.Text = createdDate;
        }

        private void chb_Common_CheckedChanged(object sender, EventArgs e)
        {
            chb_Private.Checked = !chb_Common.Checked;
        }

        private void chb_Private_CheckedChanged(object sender, EventArgs e)
        {
            chb_Common.Checked = !chb_Private.Checked;
        }
    }
}
