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
	public partial class SaveTemplate : Form
	{
        public event EventHandler<string> SaveTemplateEvent;

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
            if (SaveTemplateEvent != null)
            {
                SaveTemplateEvent(sender, tb_TemplateName.Text.Trim());
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_TemplateName.Text = string.Empty;
        }
	}
}
