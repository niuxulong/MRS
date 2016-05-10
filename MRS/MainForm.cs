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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void btn_LoadTemplate_Click(object sender, EventArgs e)
		{
			LoadTemplate form = new LoadTemplate();
			form.ShowDialog();
		}

		private void btn_SaveTemplate_Click(object sender, EventArgs e)
		{
			SaveTemplate form = new SaveTemplate();
			form.ShowDialog();
		}

		private void btn_ManageTemplate_Click(object sender, EventArgs e)
		{
			ManageTemplate form = new ManageTemplate();
			form.ShowDialog();
		}

		private void btn_SaveRecord_Click(object sender, EventArgs e)
		{
			MessageBox.Show("保存病历");
		}

		private void btn_ManageData_Click(object sender, EventArgs e)
		{
			MessageBox.Show("辅检数据");
		}

		private void btn_Eval_Click(object sender, EventArgs e)
		{
			MessageBox.Show("质控评分");
		}

		private void btn_Validate_Click(object sender, EventArgs e)
		{
			MessageBox.Show("病历校验");
		}

		private void btn_ElecSignature_Click(object sender, EventArgs e)
		{
			MessageBox.Show("电子签名");
		}

		private void btn_Finalize_Click(object sender, EventArgs e)
		{
			MessageBox.Show("档案归档");
		}

		private void btn_Configure_Click(object sender, EventArgs e)
		{
			SystemConfigForm form = new SystemConfigForm();
			form.ShowDialog();
		}

		private void btn_Search_Click(object sender, EventArgs e)
		{
			SearchPatient form = new SearchPatient();
			form.ShowDialog();
		}

		private void btn_History_Click(object sender, EventArgs e)
		{
			SearchPatient form = new SearchPatient();
			form.ShowDialog();
		}
	}
}
