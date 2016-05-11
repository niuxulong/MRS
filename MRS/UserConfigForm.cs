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
	public partial class UserConfigForm : Form
	{
		public UserConfigForm()
		{
			InitializeComponent();
		}

		private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			AddTemplateType form = new AddTemplateType();
			form.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			AddTemplate form = new AddTemplate();
			form.ShowDialog();
		}
	}
}
