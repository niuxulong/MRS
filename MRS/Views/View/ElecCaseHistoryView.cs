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
using System.Drawing;
using DCSoft.Writer;

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
        public event EventHandler<Template> CreateTemplateEvent;
        #endregion

        private Patient currentSelectedPatient;
        private Template currentSelectedTemplate;

        private Dictionary<Guid, Tuple<TabPage, Enums.TabPageType>> tabPageMapper = new Dictionary<Guid, Tuple<TabPage, Enums.TabPageType>>();

        private Dictionary<Guid, TabPage> editorContrlsMapper;

        private EditorControl ActiveEditorControl
        {
            get
            {
                if (this.editorTabPageControl.SelectedTab.Controls.Count > 0)
                    return ((EditorControl)this.editorTabPageControl.SelectedTab.Controls[0]);
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

            this.editorContrlsMapper = new Dictionary<Guid, TabPage>();
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
            if (caseHistories == null) return;
            var baseProgressNote = caseHistories.Where(c => c.CaseType == (int)Common.Enums.Enums.CaseType.ProgressNote);
            List<CaseHistory> tempList = new List<CaseHistory>();
            if (baseProgressNote.Count() > 0)
            {
                WriterControl tempControl = new WriterControl();
                tempControl.XMLText = baseProgressNote.FirstOrDefault().FileContent;
                foreach (XTextSubDocumentElement document in tempControl.SubDocuments)
                {
                    string title = document.Title;
                    if (string.IsNullOrEmpty(title))
                    {
                        title = System.IO.Path.GetFileNameWithoutExtension(document.FileName);
                    }
                    var newCase = (CaseHistory)baseProgressNote.FirstOrDefault().Clone();
                    newCase.FileContent = baseProgressNote.FirstOrDefault().FileContent;
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

        private void HandleSelectTemplateForProgressNote(object sender, Template args)
        {
            //追加病程显示
            if (dgv_FinishedCaseHistory.SelectedRows.Count > 0)
            {
                var selectedCaseHistory = dgv_FinishedCaseHistory.SelectedRows[0].DataBoundItem as CaseHistory;
                if (selectedCaseHistory != null && selectedCaseHistory.CaseType == (int)Enums.CaseType.ProgressNote)
                {
                    OpenActiveEditControlPage(selectedCaseHistory.Id, currentSelectedPatient.Name + "的病程", args.FileContent, Enums.TabPageType.ProgressNote, true);
                }
            }
        }

        private XTextSubDocumentElement CreateNewSubDocument(XTextDocument document, string xml)
        {
            XTextSubDocumentElement doc = new XTextSubDocumentElement();
            doc.OwnerDocument = document;
            doc.DocumentInfo.Author = System.Environment.UserName;
            doc.DocumentInfo.Title = DateTime.Now.ToString("病程记录yyyy年MM月dd日 HH时mm分ss秒");
            doc.ID = doc.Title;

            doc.LoadDocumentFromString(xml, "xml");

            //doc.SetInnerTextFast(xml);
            // 新文档不启用权限
            doc.EnablePermission = DCBooleanValue.False;
            // 新文档是不只读的
            doc.ContentReadonly = ContentReadonlyState.False;
            // 打印时背景透明
            doc.Style.PrintBackColor = Color.Transparent;
            //// 设置新的文件名
            string fileName = doc.DocumentInfo.Title + ".xml";
            doc.FileName = fileName;
            return doc;
        }


        private void HandleSelectTemplateEvent(object sender, Template args)
        {
            PopulateSelectedTemplateInfo(args);
        }

        private void HandleCreateTemplateEvent(int parentId, string name, int templateAttr)
        {
            if (CreateTemplateEvent != null)
            {
                var newTemplate = new Template();
                newTemplate.RecordId = Guid.NewGuid();
                newTemplate.CreatedBy = "User1";
                newTemplate.FileContent = this.ActiveEditorControl.WriteControl.XMLText;
                newTemplate.FileName = name;
                newTemplate.ParentNodeId = parentId;
                newTemplate.TemplateAttr = templateAttr;
                CreateTemplateEvent(null, newTemplate);
            }
        }

        private void PopulateSelectedTemplateInfo(Template args)
        {
            if (args != null)
            {
                OpenActiveEditControlPage(args.RecordId, args.FileName + "模板", args.FileContent, args.ParentNodeId.ToString().StartsWith("4") ? Enums.TabPageType.ProgressNote : Enums.TabPageType.Template);
                currentSelectedTemplate = args;
                if (currentSelectedTemplate.ParentNodeId == 0)
                {
                    currentSelectedTemplate.ParentNodeId = ((TemplateCatalogNode)tv_TemplateCatalog.SelectedNode.Tag).TemplateNodeId;
                }
            }
        }

        private void btn_SaveTemplate_Click(object sender, EventArgs e)
        {
            if (tv_TemplateCatalog.SelectedNode != null)
            {
                var templateCatalogNode = (TemplateCatalogNode)tv_TemplateCatalog.SelectedNode.Tag;

                if (!templateCatalogNode.IsParentTemplateNode)
                {
                    SaveTemplate form = new SaveTemplate();
                    form.CreateTemplateEvent += HandleCreateTemplateEvent;
                    var parentId = templateCatalogNode.TemplateNodeId;
                    var node = GetTemplateNodeByParentId(parentId);
                    if (node != null)
                    {
                        form.PopulateSelectedTemplateInfo(parentId, node.Text, "", DateTime.Now.ToShortDateString());
                        form.ShowDialog();
                    }
                }
                else
                { MessageBox.Show("请在树形菜单选择一个模板类型"); }
            }
            else { MessageBox.Show("请在树形菜单选择一个模板类型"); }
        }

        private TreeNode GetTemplateNodeByParentId(int parentId)
        {
            foreach (TreeNode node in tv_TemplateCatalog.Nodes)
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
                var currentId = (Guid)editorTabPageControl.SelectedTab.Tag;
                if (tabPageMapper.ContainsKey(currentId))
                {
                    var tabPageType = tabPageMapper[currentId].Item2;
                    var caseHistory = new CaseHistory()
                    {
                        PatientId = currentSelectedPatient.PatientId,
                        FileName = editorTabPageControl.SelectedTab.Text,
                        FileTitle = string.Empty,
                        FileContent = this.ActiveEditorControl.WriteControl.XMLText,
                        CreatedBy = "User1"
                    };

                    if (tabPageType == Enums.TabPageType.Template)
                    {
                        caseHistory.Id = System.Guid.NewGuid();
                        caseHistory.CaseType = currentSelectedTemplate.ParentNodeId.ToString().StartsWith("4") == true ? (int)Enums.CaseType.ProgressNote : (int)Enums.CaseType.Common;

                        var targetTabPageType = Enums.TabPageType.CaseHistory;
                        if (caseHistory.CaseType == (int)Enums.CaseType.ProgressNote)
                        {
                            targetTabPageType = Enums.TabPageType.ProgressNote;
                        }

                        var tupple = new Tuple<TabPage, Enums.TabPageType>(tabPageMapper[currentId].Item1, targetTabPageType);

                        tabPageMapper.Add(caseHistory.Id, tupple);
                        tabPageMapper.Remove(currentId);
                    }
                    else if (tabPageType == Enums.TabPageType.CaseHistory)
                    {
                        caseHistory.Id = currentId;
                        caseHistory.CaseType = (int)Enums.CaseType.Common;
                    }
                    else if (tabPageType == Enums.TabPageType.ProgressNote)
                    {
                        caseHistory.Id = currentId;
                        caseHistory.CaseType = (int)Enums.CaseType.ProgressNote;
                    }
                    if (SaveCaseHistoryEvent != null)
                    {
                        SaveCaseHistoryEvent(sender, caseHistory);



                        MessageBox.Show("保存病历成功");
                    }
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
            if (dgv_FinishedCaseHistory.SelectedRows.Count > 0)
            {
                var selectedCaseHistory = dgv_FinishedCaseHistory.SelectedRows[0].DataBoundItem as CaseHistory;
                if (selectedCaseHistory != null && selectedCaseHistory.CaseType == (int)Enums.CaseType.ProgressNote)
                {
                    if (currentSelectedPatient != null)
                    {
                        ProgressNoteTypeSelectionView form = new ProgressNoteTypeSelectionView();
                        var types = new List<TreeNode>();
                        // Mark:第四树节点为病程节点
                        if (tv_TemplateCatalog.Nodes.Count > 3)
                        {
                            foreach (TreeNode subNode in tv_TemplateCatalog.Nodes[3].Nodes)
                            {
                                types.Add(subNode);
                            }
                        }

                        form.ProgressNoteTypes = types;
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            if (form.SelectedTypeNode != null)
                            {
                                LoadTemplateView loadTemplateForm = new LoadTemplateView((TemplateCatalogNode)form.SelectedTypeNode.Tag);
                                loadTemplateForm.SelectTemplateEvent += HandleSelectTemplateForProgressNote;
                                loadTemplateForm.ShowDialog();
                            }
                        }
                    }
                }

            }

        }

        private void dgv_FinishedCaseHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_FinishedCaseHistory.SelectedRows.Count > 0)
            {
                var selectedCaseHistory = dgv_FinishedCaseHistory.SelectedRows[0].DataBoundItem as CaseHistory;
                if (selectedCaseHistory != null)
                {
                    // 病程
                    if (selectedCaseHistory.CaseType == (int)Enums.CaseType.ProgressNote)
                    {
                        OpenActiveEditControlPage(selectedCaseHistory.Id, currentSelectedPatient.Name + "的病程", selectedCaseHistory.FileContent, Enums.TabPageType.ProgressNote);

                        XTextSubDocumentElement record = (XTextSubDocumentElement)selectedCaseHistory.Tag;
                        if (record != null)
                        {
                            record.Focus();
                            record.SelectFirstLine();
                            //ActiveEditorControl.WriteControl.Focus();
                            //ActiveEditorControl.WriteControl.ScrollToCaretExt(DCSoft.WinForms.ScrollToViewStyle.Top);
                        }
                    }
                    //病历
                    else if (selectedCaseHistory.CaseType == (int)Enums.CaseType.Common)
                    {
                        OpenActiveEditControlPage(selectedCaseHistory.Id, selectedCaseHistory.FileName + "(病历)", selectedCaseHistory.FileContent, Enums.TabPageType.CaseHistory);
                    }
                    //首日病程
                    else if (selectedCaseHistory.CaseType == (int)Enums.CaseType.FirstProgressNote)
                    {

                    }
                }
            }
        }

        /// <summary>
        /// 打开新的编辑TAB页，或定位到已打开的编辑TAB页
        /// </summary>
        /// <param name="RecordId" 可以是模板Id， 或是病历、病程 Id></param>
        private void OpenActiveEditControlPage(Guid RecordId, string tabTitle, string content, Enums.TabPageType tabPageType, bool isAppende = false)
        {
            if (tabPageMapper.ContainsKey(RecordId))
            {
                editorTabPageControl.SelectedTab = tabPageMapper[RecordId].Item1;
                editorTabPageControl.SelectedTab.Tag = RecordId;
                if (isAppende)
                {
                    var doc = CreateNewSubDocument(ActiveEditorControl.WriteControl.Document, content);
                    ActiveEditorControl.WriteControl.AppendSubDocument(doc);
                }
            }
            else
            {
                TabPage newTabPage = null;
                EditorControl editor = null;
                if (editorTabPageControl.TabPages.Count == 1 && (Guid)editorTabPageControl.TabPages[0].Tag == Guid.Empty)
                {
                    newTabPage = editorTabPageControl.TabPages[0];
                    newTabPage.Text = tabTitle;
                    newTabPage.Tag = RecordId;
                    editor = editorTabPageControl.TabPages[0].Controls[0] as EditorControl;
                }
                else
                {
                    newTabPage = new TabPage()
                   {
                       Text = tabTitle,
                       Tag = RecordId
                   };


                    editor = new EditorControl()
                    {
                        Dock = DockStyle.Fill,
                        Location = new Point(3, 3),
                        Margin = new Padding(3, 4, 3, 4),
                        Size = new Size(865, 600),
                        //FileContent = content
                    };

                    newTabPage.Controls.Add(editor);
                    editorTabPageControl.TabPages.Add(newTabPage);
                    editorTabPageControl.SelectedTab = newTabPage;
                }

                if (tabPageType == Enums.TabPageType.ProgressNote)
                {
                    var doc = CreateNewSubDocument(ActiveEditorControl.WriteControl.Document, content);
                    ActiveEditorControl.WriteControl.AppendSubDocument(doc);
                }
                else
                {
                    editor.FileContent = content;
                }


                var tupple = new Tuple<TabPage, Enums.TabPageType>(newTabPage, tabPageType);
                tabPageMapper.Add(RecordId, tupple);
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

        private void dgv_FinishedCaseHistory_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {

        }

        private void dgv_FinishedCaseHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void ContextMenuSrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.MenuItem_AppendRecord.Enabled = true;
            if (dgv_FinishedCaseHistory.SelectedRows.Count > 0 && dgv_FinishedCaseHistory.SelectedRows[0].DataBoundItem != null)
            {
                var selectedCaseHistory = dgv_FinishedCaseHistory.SelectedRows[0].DataBoundItem as CaseHistory;
                if (selectedCaseHistory.CaseType != (int)Enums.CaseType.ProgressNote)
                {
                    this.MenuItem_AppendRecord.Enabled = false;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void dgv_FinishedCaseHistory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {

                    if (dgv_FinishedCaseHistory.Rows[e.RowIndex].Selected == false)
                    {
                        dgv_FinishedCaseHistory.ClearSelection();
                        dgv_FinishedCaseHistory.Rows[e.RowIndex].Selected = true;
                    }

                    if (dgv_FinishedCaseHistory.SelectedRows.Count == 1)
                        dgv_FinishedCaseHistory.CurrentCell = dgv_FinishedCaseHistory.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    this.ContextMenuSrip.Show();
                }
            }
        }

    }
}
