using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MRS.DataCacheManager;
using MRS.Entity.Entities;
using MRS.Views.Interface;
using MRS.Presenters.Presenter;

namespace MRS.Views.View
{
	public partial class ElecCaseHistoryView : ViewBase, IElecCaseHistoryView
	{
		public ElecCaseHistoryView()
		{
			InitializeComponent();

            InitilizeCache();

            
            //this.writerControl1.XMLText = templates[0].FileContent;
		}

        protected override object CreatePresenter()
        {
            return new ElecCaseHistoryPresenter(this);
        }

        private void InitilizeCache()
        {
            var cacheManager = DataCacheManager.DataCacheManager.GetCacheManagerInstance();
            cacheManager.InitilizeDataCache();
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

		private void btn_Configure_Click(object sender, EventArgs e)
		{
			UserConfigView form = new UserConfigView();
			form.ShowDialog();
		}

		private void btn_Search_Click(object sender, EventArgs e)
		{
			SearchPatientView form = new SearchPatientView();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var selectedPatient = form.selectedPatient;
                if (selectedPatient != null)
                { 
                    // call its presenter to retrive other info like case history or template and populate to the main form
                }
            }
		}

		private void btn_History_Click(object sender, EventArgs e)
		{
			SearchPatientView form = new SearchPatientView();
			form.ShowDialog();
		}

		private void btn_SystemConfigure_Click(object sender, EventArgs e)
		{
            AdminValidationView form = new AdminValidationView();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SystemConfigView form1 = new SystemConfigView();
                form1.Show();
            }


        }


        //this.writerControl1.XMLText = templates[0].FileContent;

        #region 待实现
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
        #endregion
    }
}
