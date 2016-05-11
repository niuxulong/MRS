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
	public partial class SystemConfigForm : Form
	{
		public SystemConfigForm()
		{
			InitializeComponent();
		}

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.treeView1.SelectedNode = e.Node;
                this.contextMenuStrip1.Show(this.treeView1, e.Location);
            }
        }
	}
}
