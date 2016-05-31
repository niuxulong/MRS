using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRS.Views
{
	public class UIHelper
	{
		public static void ShowWarningMessage(string content)
		{
			MessageBox.Show(content, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		public static void ShowErrorMessage(string content)
		{
			MessageBox.Show(content, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static void ShowInformationMessage(string content)
		{
			MessageBox.Show(content, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public static DialogResult ShowConfrimMessage(string content)
		{
			return MessageBox.Show(content, "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
		}
	}
}
