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
	public partial class SearchCase : Form
	{
        public SearchCase()
		{
			InitializeComponent();
		}

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var name = this.txt_name.Text.Trim();

        }
	}
}
