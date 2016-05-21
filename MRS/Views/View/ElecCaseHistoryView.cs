using Common.Enums;
using Common.EventArguments;
using Common.UserControls;
using DCSoft.Writer.Dom;
using MRS.Entity.Entities;
using MRS.Presenters.Presenter;
using MRS.Views.Interface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using DCSoft.Writer.Controls;

namespace MRS.Views.View
{
    public partial class ElecCaseHistoryView : ViewBase, IElecCaseHistoryView
    {
        //this.MyWriterControl.DocumentOptions.SecurityOptions.AutoEnablePermissionWhenUserLogin = true;
        //MyWriterControl.UserLoginByParameter("108","张三医生",0);

        Timer timer = new Timer();

        #region Event Handler
        public event EventHandler<string> RetriveCaseHistoriesByPatientIdEvent;
        public event EventHandler RetriveTemplateCatalogTree;
        public event EventHandler<CaseHistory> SaveCaseHistoryEvent;
        public event EventHandler<UpdateCaseHistoryStatusEventArgs> UpdateCasetoryStatusEvent;
        public event EventHandler<UpdateCaseHistoryStatusEventArgs> DeleteCaseHistoryEvent;
        public event EventHandler<Template> SaveTemplateEvent;
        #endregion

        private Patient currentSelectedPatient;
        private Template currentSelectedTemplate;

        private EditorControl ActiveEditorControl
        {
            get
            {
                if (this.tabControl1.SelectedTab.Controls.Count > 0)
                    return ((EditorControl)this.tabControl1.SelectedTab.Controls[0]);
                return this.editorControl;
            }
        }

        public ElecCaseHistoryView()
        {
            InitializeComponent();
        }

        private void ElecCaseHistoryView_Load(object sender, EventArgs e)
        {
            ConfigDgvFinishedCaseHistoryColumns();
            InitilizeTimer();

            if (DataCacheManager.DataCacheManager.GetCacheManagerInstance().CacheInitialized())
            {
                SetupTemplateCatalogTree();
            }
        }

        private void SetupTemplateCatalogTree()
        {
            tv_TemplateCatalog.Nodes.Clear();
            if (RetriveTemplateCatalogTree != null)
            {
                RetriveTemplateCatalogTree(null, null);
            }
        }

        private void ClearView()
        {
            //清空病人信息
            ClearPatientInfo();
            //清空病历信息
            dgv_FinishedCaseHistory.DataSource = null;
          
        }

        private void ConfigDgvFinishedCaseHistoryColumns()
        {
            this.dgv_FinishedCaseHistory.AutoGenerateColumns = false;
            this.dgv_FinishedCaseHistory.Columns["col_Complated_No"].DataPropertyName = "PatientId";
            this.dgv_FinishedCaseHistory.Columns["col_Complated_ID"].DataPropertyName = "PatientId";
            this.dgv_FinishedCaseHistory.Columns["col_Complated_Name"].DataPropertyName = "FileName";
            this.dgv_FinishedCaseHistory.Columns["col_Complated_Check"].DataPropertyName = "FileTitle";
        }

        protected override object CreatePresenter()
        {
            return new ElecCaseHistoryPresenter(this);
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
            var baseProgressNote = caseHistories.Where(c => c.CaseType == (int)Common.Enums.Enums.CaseType.ProgressNote).ToList();
            List<CaseHistory> tempList = new List<CaseHistory>();
            if (baseProgressNote.Count() > 0)
            {
                WriterControl tempControl = new WriterControl();
                tempControl.XMLText = baseProgressNote[0].FileContent;
                foreach (XTextSubDocumentElement document in tempControl.SubDocuments)
                {
                    string title = document.Title;
                    if (string.IsNullOrEmpty(title))
                    {
                        title = System.IO.Path.GetFileNameWithoutExtension(document.FileName);
                    }
                    var newCase = (CaseHistory)baseProgressNote[0].Clone();
                    newCase.FileContent = title;
                    newCase.Tag = document;
                    tempList.Add(newCase);
                }
            }
            var dataSource = caseHistories.Where(c => c.CaseType != (int)Common.Enums.Enums.CaseType.ProgressNote).ToList();
            dataSource.AddRange(tempList);
            dgv_FinishedCaseHistory.DataSource = dataSource;
        }

        public void PopulateTemplateCatalogTree(List<TemplateCatalogNode> nodes)
        {
            tv_TemplateCatalog.Nodes.AddRange(nodes.Select(n => n.ToTreeNode()).ToArray());
        }

        public void PopulatePatientInfo(Patient patient)
        {
            txt_Name.Text = patient.Name;
            txt_hospitalNo.Text = patient.BeinHospitalCode;
        }

        private void ClearPatientInfo()
        {
            txt_Name.Text = string.Empty;
            txt_hospitalNo.Text = string.Empty;
        }

        private void btn_LoadTemplate_Click(object sender, EventArgs e)
        {
            if (tv_TemplateCatalog.SelectedNode != null && tv_TemplateCatalog.SelectedNode.Level == 1)
            {
                LoadTemplateView form = new LoadTemplateView((TemplateCatalogNode)tv_TemplateCatalog.SelectedNode.Tag);
                form.SelectTemplateEvent += HandleSelectTemplateEvent;
                form.ShowDialog();
            }
        }

        private void HandleSelectTemplateEvent(object sender, Template args)
        {
            PopulateSelectedTemplateInfo(args);
        }

        private void HandleSaveTemplateEvent(object sender, string args)
        {
            if (SaveTemplateEvent != null)
            {
                currentSelectedTemplate.CreatedBy = "User1";
                currentSelectedTemplate.FileContent = this.ActiveEditorControl.WriteControl.XMLText;
                currentSelectedTemplate.FileName = args;
                SaveTemplateEvent(sender, currentSelectedTemplate);
            }
        }

        private void PopulateSelectedTemplateInfo(Template args)
        {
            if (args != null)
            {
                if (this.tabControl1.TabPages.Count > 0)
                {
                    this.tabControl1.TabPages.Add("操做页");
                    var newPage = this.tabControl1.TabPages[this.tabControl1.TabPages.Count - 1];
                    var editorControl = new EditorControl();
                    editorControl.Dock = DockStyle.Fill;
                    newPage.Controls.Add(editorControl);
                    tabControl1.SelectTab(newPage);
                }
                    //显示到编辑控件
                this.ActiveEditorControl.FileContent = args.FileContent;

                currentSelectedTemplate = args;
                if (currentSelectedTemplate.ParentNodeId == 0)
                {
                    currentSelectedTemplate.ParentNodeId = ((TemplateCatalogNode)tv_TemplateCatalog.SelectedNode.Tag).TemplateNodeId;
                }
            }
        }

        private void btn_SaveTemplate_Click(object sender, EventArgs e)
        {
            if (currentSelectedTemplate != null)
            {
                SaveTemplate form = new SaveTemplate();
                form.SaveTemplateEvent += HandleSaveTemplateEvent;
                var node = GetTemplateNodeByParentId(currentSelectedTemplate.ParentNodeId);
                if (node != null)
                {
                    form.PopulateSelectedTemplateInfo(currentSelectedTemplate.ParentNodeId, node.Text, currentSelectedTemplate.FileName, DateTime.Now.ToShortDateString());
                    form.ShowDialog();
                }
            }
        }

        private TreeNode GetTemplateNodeByParentId(int parentId)
        {
            foreach(TreeNode node in tv_TemplateCatalog.Nodes)
            {
                foreach (TreeNode subNode in node.Nodes)
                {
                    if ((subNode.Tag as TemplateCatalogNode).TemplateNodeId == parentId)
                    {
                        return subNode;
                    }
                }
            }
            return null;
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
            form.SelectPatientEvent += HandleSelectPatientEvent;
            form.ShowDialog();
        }

        private void HandleSelectPatientEvent(object sender, Patient args)
        {
            if (args != null)
            {
                currentSelectedPatient = args;
                PopulatePatientInfo(args);
                if (RetriveCaseHistoriesByPatientIdEvent != null)
                {
                    RetriveCaseHistoriesByPatientIdEvent(sender, args.PatientId);
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
                    //加载模板树节点
                    SetupTemplateCatalogTree();
                    //系统配置更新后清空页面信息   
                    ClearView();
                }
            }
        }

        private void btn_SaveRecord_Click(object sender, EventArgs e)
        {
            if (currentSelectedPatient != null)
            {
                var caseHistory = new CaseHistory()
                {
                    Id = System.Guid.NewGuid(),
                    PatientId = currentSelectedPatient.PatientId,
                    FileName = currentSelectedTemplate.FileName,
                    FileTitle = string.Empty,
                    FileContent = this.ActiveEditorControl.WriteControl.XMLText,
                    CreatedBy = "User1"
                };
                if (SaveCaseHistoryEvent != null)
                {
                    SaveCaseHistoryEvent(sender, caseHistory);
                    MessageBox.Show("保存病历成功");
                }
            }
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
            ValueValidateResultList list = (ValueValidateResultList)this.editorControl.ExecuteCommand(
                                            "DocumentValueValidate",
                                             false,
                                             null);
            if (list != null && list.Count > 0)
            {
                //验证不通过
            }
            else
            {
                MessageBox.Show("验证通过");
            }

        }

        private void btn_ElecSignature_Click(object sender, EventArgs e)
        {
            MessageBox.Show("电子签名");
        }

        private void btn_Finalize_Click(object sender, EventArgs e)
        {
            if (UpdateCaseHistoryStatus("档案归档", Enums.CaseHistoryStatus.Checked, Enums.CaseHistoryStatus.Finalized))
            {
                MessageBox.Show("归档成功");
            }
        }

        private void btn_Temperature_Click(object sender, EventArgs e)
        {
            //TemperatureView form = new TemperatureView();
            //form.Show();

        }

        //提交审核
        private void CaseHistory_MenuItem_Commit_Click(object sender, EventArgs e)
        {
            UpdateCaseHistoryStatus("提交审核", Enums.CaseHistoryStatus.New, Enums.CaseHistoryStatus.Checking);
        }

        //撤销受审
        private void CaseHistory_MenuItem_RollbackCommit_Click(object sender, EventArgs e)
        {
            UpdateCaseHistoryStatus("撤销审核", Enums.CaseHistoryStatus.Checking, Enums.CaseHistoryStatus.New);
        }

        //删除病历
        private void CaseHistory_MenuItem_RemoveRecord_Click(object sender, EventArgs e)
        {
            if (dgv_FinishedCaseHistory.SelectedRows.Count > 0)
            {
                var selectedCaseHistory = this.dgv_FinishedCaseHistory.SelectedRows[0].DataBoundItem as CaseHistory;
                if (selectedCaseHistory != null)
                {

                    if (selectedCaseHistory.Status == (int)Enums.CaseHistoryStatus.New)
                    {
                        if (DeleteCaseHistoryEvent != null)
                        {
                            if (MessageBox.Show("确定要删除所选病例吗？", "删除病历", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                            {
                                DeleteCaseHistoryEvent(null, new UpdateCaseHistoryStatusEventArgs() { caseHistoryId = selectedCaseHistory.Id, status = Enums.CaseHistoryStatus.New, PatientId = selectedCaseHistory.PatientId });
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(string.Format("所选病例为{0}状态，不可删除。", GetCaseHistoryStatusString(selectedCaseHistory.Status)));
                    }
                }
            }
        }

        //审核病历
        private void CaseHistory_MenuItem_CheckRecord_Click(object sender, EventArgs e)
        {
            UpdateCaseHistoryStatus("审核病历", Enums.CaseHistoryStatus.Checking, Enums.CaseHistoryStatus.Checked);
        }

        //追加病程
        private void CaseHistory_MenuItem_AppendRecord_Click(object sender, EventArgs e)
        {

        }

        private void dgv_FinishedCaseHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_FinishedCaseHistory.SelectedRows.Count > 0)
            {
                var selectedCaseHistory = dgv_FinishedCaseHistory.SelectedRows[0].DataBoundItem as CaseHistory;
                if (selectedCaseHistory != null)
                {
                    if (selectedCaseHistory.CaseType == (int)Enums.CaseType.ProgressNote)
                    {
                        XTextSubDocumentElement record = (XTextSubDocumentElement)selectedCaseHistory.Tag;
                        if (record != null)
                        {
                            record.Focus();
                            record.SelectFirstLine();
                            ActiveEditorControl.WriteControl.Focus();
                            ActiveEditorControl.WriteControl.ScrollToCaretExt(DCSoft.WinForms.ScrollToViewStyle.Top);
                        }
                    }
                    else if(selectedCaseHistory.CaseType == (int)Enums.CaseType.Common)
                    {
                        ActiveEditorControl.WriteControl.XMLText = selectedCaseHistory.FileContent;
                    }
                }
            }
        }

        //撤销审核
        private void CaseHistory_MenuItem_RemoveCheck_Click(object sender, EventArgs e)
        {
            UpdateCaseHistoryStatus("审核病历", Enums.CaseHistoryStatus.Checked, Enums.CaseHistoryStatus.Checking);
        }

        private string GetCaseHistoryStatusString(int status)
        {
            var result = string.Empty;
            switch (status)
            { 
                case (int)Enums.CaseHistoryStatus.New:
                    result = "新建";
                    break;
                case (int)Enums.CaseHistoryStatus.Checking:
                    result = "审核";
                    break;
                case (int)Enums.CaseHistoryStatus.Checked:
                    result = "审核完毕";
                    break;
                case (int)Enums.CaseHistoryStatus.Finalized:
                    result = "归档";
                    break;
            }
            return result;
        }

        private bool UpdateCaseHistoryStatus(string actionName, Enums.CaseHistoryStatus allowedStatus, Enums.CaseHistoryStatus targetStatus)
        {
            if (dgv_FinishedCaseHistory.SelectedRows.Count > 0)
            {
                var selectedCaseHistory = this.dgv_FinishedCaseHistory.SelectedRows[0].DataBoundItem as CaseHistory;
                if (selectedCaseHistory != null)
                {
                    if (selectedCaseHistory.Status == (int)allowedStatus)
                    {
                        if (UpdateCasetoryStatusEvent != null)
                        {
                            UpdateCasetoryStatusEvent(null, new UpdateCaseHistoryStatusEventArgs() { caseHistoryId = selectedCaseHistory.Id, status = targetStatus, PatientId = selectedCaseHistory.PatientId });
                            return true;
                        }
                    }
                    else
                    {
                        MessageBox.Show(string.Format("所选病例为{0}状态，不可{1}。", GetCaseHistoryStatusString(selectedCaseHistory.Status), actionName));
                    }
                }
            }
            return false;
        }

    }
}
