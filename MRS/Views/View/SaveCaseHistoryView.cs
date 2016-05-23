using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRS.Views.View
{
    public partial class SaveCaseHistoryView : Form
    {
        public string CaseHistoryName 
        {
            get { return tbName.Text.Trim(); }
        }
        public SaveCaseHistoryView()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbName.Text.Trim()))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("请输入病历名称。");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
