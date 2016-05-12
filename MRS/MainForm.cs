using MRS.Presenter.Interfaces;
using MRS.Presenter.Presenters;
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

namespace MRS
{
	public partial class MainForm : Form
	{
        private IPatientPresenter patientPresenter;
        private ITemplatePresenter templatePresenter;
        private ITemplateCatalogPresenter templateCatalogPresenter;

		public MainForm()
		{
			InitializeComponent();

            patientPresenter = new PatientPresenter();
            templatePresenter = new TemplatePresenter();
            templateCatalogPresenter = new TemplateCatalogPresenter();

            InitilizeCache();

            var patients = patientPresenter.GetPatientsByName();
            var templates = templatePresenter.GetTemplates();
            var templateCatalogNodes = templateCatalogPresenter.GetTemplateCatalogNodes();
            this.writerControl1.XMLText = templates[0].FileContent;
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
			UserConfigForm form = new UserConfigForm();
			form.ShowDialog();
		}

		private void btn_Search_Click(object sender, EventArgs e)
		{
			SearchPatient form = new SearchPatient();
            form.SelectPatientEvent += form_SelectPatientEvent;
			form.ShowDialog();
		}

        void form_SelectPatientEvent(Patient patient)
        {
            
        }

      

		private void btn_History_Click(object sender, EventArgs e)
		{
			SearchPatient form = new SearchPatient();
			form.ShowDialog();
		}

		private void btn_SystemConfigure_Click(object sender, EventArgs e)
		{
            AdminValidationForm form = new AdminValidationForm();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SystemConfigForm form1 = new SystemConfigForm();
                form1.Show();
            }


		}
	}
}
