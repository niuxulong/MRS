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

            # region test update nodes db and cache
            List<TemplateCatalogNode> nodes = new List<TemplateCatalogNode>();
            var childNode = new TemplateCatalogNode()
            {
                TemplateNodeId = 11,
                TemplateNodeName = "Name11",
                TemplateParentNodeId = 1
            };
            var childNode2 = new TemplateCatalogNode()
            {
                TemplateNodeId = 12,
                TemplateNodeName = "Name12ss",
                TemplateParentNodeId = 1
            };
            var childList = new List<TemplateCatalogNode>();
            childList.Add(childNode);
            childList.Add(childNode2);
            TemplateCatalogNode parentNode1 = new TemplateCatalogNode()
            {
                TemplateNodeId = 1,
                TemplateNodeName = "Name1",
                TemplateParentNodeId = 0,
                ChildTemplateNodeList = childList
            };

            var childNode3 = new TemplateCatalogNode()
            {
                TemplateNodeId = 21,
                TemplateNodeName = "Name2ss1",
                TemplateParentNodeId = 2
            };
            var childNode4 = new TemplateCatalogNode()
            {
                TemplateNodeId = 22,
                TemplateNodeName = "Name22",
                TemplateParentNodeId = 2
            };
            var childList2 = new List<TemplateCatalogNode>();
            childList2.Add(childNode3);
            childList2.Add(childNode4);
            TemplateCatalogNode parentNode2 = new TemplateCatalogNode()
            {
                TemplateNodeId = 2,
                TemplateNodeName = "Name2",
                TemplateParentNodeId = 0,
                ChildTemplateNodeList = childList2
            };

            nodes.Add(parentNode1);
            nodes.Add(parentNode2);

            var success = templateCatalogPresenter.UpdateOrAddTemplateCatgalogNodes(nodes);

            var lists = templateCatalogPresenter.GetTemplateCatalogNodes();
            #endregion
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
			form.ShowDialog();
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
