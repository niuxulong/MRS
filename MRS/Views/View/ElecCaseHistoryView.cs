using MRS.Entity.Entities;
using MRS.Presenters.Presenter;
using MRS.Views.Interface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MRS.Views.View
{
	public partial class ElecCaseHistoryView : ViewBase, IElecCaseHistoryView
	{
        Timer timer = new Timer();

        #region Event Handler
        public event EventHandler<string> RetriveCaseHistoriesByPatientIdEvent;
        public event EventHandler RetriveTemplateCatalogTree;
        #endregion

        public ElecCaseHistoryView()
		{
			InitializeComponent();
            
            //this.writerControl1.XMLText = templates[0].FileContent;
		}

        private void ElecCaseHistoryView_Load(object sender, EventArgs e)
        {
            InitilizeCache();
            InitilizeTimer();
            SetupTemplateCatalogTree();
            ConfigDgvFinishedCaseHistoryColumns();
        }

        private void SetupTemplateCatalogTree()
        {
            tv_TemplateCatalog.Nodes.Clear();
            if (RetriveTemplateCatalogTree != null)
            {
                RetriveTemplateCatalogTree(null, null);
            }
        }

        private void ConfigDgvFinishedCaseHistoryColumns()
        {
            this.dgv_FinishedCaseHistory.Columns["col_Complated_No"].DataPropertyName = "PatientId";
            this.dgv_FinishedCaseHistory.Columns["col_Complated_ID"].DataPropertyName = "PatientId";
            this.dgv_FinishedCaseHistory.Columns["col_Complated_Name"].DataPropertyName = "FileName";
            this.dgv_FinishedCaseHistory.Columns["col_Complated_Check"].DataPropertyName = "FileTitle";
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

        private void InitilizeTimer()
        {
            lb_SystemTime.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToShortTimeString();
            this.timer.Interval = 2000;
            this.timer.Tick += (sender, e) => { lb_SystemTime.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToShortTimeString(); };
            this.timer.Start();
        }

        public void PopulateCaseHistoryRecords(List<CaseHistory> caseHistories)
        {
            dgv_FinishedCaseHistory.DataSource = null;
            dgv_FinishedCaseHistory.DataSource = caseHistories;
        }

        public void PopulateTemplateCatalogTree(List<TemplateCatalogNode> nodes)
        {
            foreach (var node in nodes)
            {
                tv_TemplateCatalog.Nodes.Add(node.ToTreeNode());
            }
        }

        public void PopulatePatientInfo(Patient patient)
        { 
            txt_Name.Text = patient.Name;
            // and other info
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
                    PopulatePatientInfo(selectedPatient);
                    if (RetriveCaseHistoriesByPatientIdEvent != null)
                    {
                        RetriveCaseHistoriesByPatientIdEvent(sender, selectedPatient.PatientId);
                    }
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
                if (form1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    SetupTemplateCatalogTree();

                    //update database connection, currently not sure the details.
                }
            }


        }

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
