using Common.EventArguments;
using MRS.Entity.Entities;
using MRS.Presenters.Presenter;
using MRS.Views.Interface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MRS.Views.View
{
    public partial class SystemConfigView : ViewBase, ISystemConfigView
	{
        private string InitialNode = "请点击右键编辑";

        #region Event Handler
        public event EventHandler RetriveTemplateCatalogConfigTree;
        public event EventHandler<SystemConfigEventArgs> CheckDatabaseConnectionAndSaveConfigEvent;
        public event EventHandler RetriveDatabaseConfigEvent;
        #endregion

		public SystemConfigView()
		{
			InitializeComponent();
		}

        private void SystemConfigView_Load(object sender, EventArgs e)
        {
            SetupTemplateCatalogConfigTree();
            SetupDatabaseCofigInfo();
        }

        private void SetupDatabaseCofigInfo()
        {
            if (RetriveDatabaseConfigEvent != null)
            {
                RetriveDatabaseConfigEvent(null, null);
            }
        }

        private void SetupTemplateCatalogConfigTree()
        {
            if (RetriveTemplateCatalogConfigTree != null)
            {
                RetriveTemplateCatalogConfigTree(null, null);
            }
        }

        protected override object CreatePresenter()
        {
            return new SystemConfigPresenter(this);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.tv_ConfigTemplateTree.SelectedNode = e.Node;
                this.contextMenuStrip.Show(this.tv_ConfigTemplateTree, e.Location);
            }
        }

        public void NotificationNoDatabaseFound()
        {
            MessageBox.Show("未发现数据库，或指定用户名密码不正确，请检查数据库配置。");
            this.tabControl1.SelectedIndex = 0;
        }

        public void PopulateDatabaseConfig(DatabaseConfig config)
        {
            this.tb_Server.Text = config.Server;
            this.tb_Database.Text = config.Database;
            this.tb_User.Text = config.User;
            this.tb_Pwd.Text = config.Password;
        }

        public void PopulateTemplateCatalogConfigTree(List<TemplateCatalogNode> nodes)
        {
            if (nodes != null && nodes.Count > 0)
            {
                tv_ConfigTemplateTree.Nodes.Clear();
            }
            foreach (var node in nodes)
            {
                tv_ConfigTemplateTree.Nodes.Add(node.ToTreeNode());
            }
        }

        private void MenuAddCatolog_Click(object sender, EventArgs e)
        {
            TreeNode node;
            if (tv_ConfigTemplateTree.SelectedNode.Text == InitialNode)
            {
                tv_ConfigTemplateTree.SelectedNode.Text = "类别名";
                node = tv_ConfigTemplateTree.SelectedNode;
            }
            else
            {
                node = new TreeNode()
                {
                    Text = "类别名"
                };
                tv_ConfigTemplateTree.Nodes.Add(node);
                  
            }

            node.BeginEdit();  
        }

        private void MenuAddTemplateType_Click(object sender, EventArgs e)
        {
            if (tv_ConfigTemplateTree.SelectedNode != null)
            {
                if (tv_ConfigTemplateTree.SelectedNode.Text == InitialNode)
                {
                    return;
                }

                var node = new TreeNode()
                {
                    Text = "模板名"
                };

                if (tv_ConfigTemplateTree.SelectedNode.Level == 0)
                {
                    tv_ConfigTemplateTree.SelectedNode.Nodes.Add(node);
                }
                else
                {
                    tv_ConfigTemplateTree.SelectedNode.Parent.Nodes.Add(node);
                }

                if (!node.Parent.IsExpanded)
                {
                    node.Parent.Toggle();
                }
                node.BeginEdit();
            }
        }

        private void MenuRename_Click(object sender, EventArgs e)
        {
            if (tv_ConfigTemplateTree.SelectedNode != null)
            {
                tv_ConfigTemplateTree.SelectedNode.BeginEdit();
            }
        }

        private void MenuDelete_Click(object sender, EventArgs e)
        {
            if (tv_ConfigTemplateTree.SelectedNode != null && tv_ConfigTemplateTree.SelectedNode.Text != InitialNode)
            {
                tv_ConfigTemplateTree.SelectedNode.Remove();
                if (tv_ConfigTemplateTree.Nodes.Count == 0)
                {
                    tv_ConfigTemplateTree.Nodes.Add(new TreeNode() { Text = InitialNode });
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var eventArgs = new SystemConfigEventArgs();
            var databaseConfig = new DatabaseConfig()
            {
                Server = tb_Server.Text,
                Database = tb_Database.Text,
                User = tb_User.Text,
                Password = tb_Pwd.Text
            };
            eventArgs.DatabaseConfig = databaseConfig;
            eventArgs.TemplateCatalogNodes = GetTemplateCatalogTreeInfo();

            //检查数据库配置是否正确
            if (CheckDatabaseConnectionAndSaveConfigEvent != null)
            {
                CheckDatabaseConnectionAndSaveConfigEvent(this, eventArgs);
            }
        }

        public void CloseForm()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private List<TemplateCatalogNode> GetTemplateCatalogTreeInfo()
        {
            var results = new List<TemplateCatalogNode>();
            if (tv_ConfigTemplateTree.Nodes.Count == 1 && tv_ConfigTemplateTree.Nodes[0].Text == InitialNode)
            {
                return results;
            }
            for(int index = 0; index < tv_ConfigTemplateTree.Nodes.Count; index++)
            {
                var node = tv_ConfigTemplateTree.Nodes[index];
                var childNodeList = new List<TemplateCatalogNode>();
                for(int subIndex = 0; subIndex < node.Nodes.Count; subIndex++)
                {
                    var childNode = new TemplateCatalogNode()
                    {
                        TemplateNodeId = subIndex + 1,
                        TemplateNodeName = node.Nodes[subIndex].Text,
                        TemplateParentNodeId = index + 1
                    };
                    childNodeList.Add(childNode);
                }
                var parentNode = new TemplateCatalogNode()
                {
                       TemplateNodeId = index + 1,
                       TemplateNodeName = node.Text,
                       ChildTemplateNodeList = childNodeList
                };
                results.Add(parentNode);
            }
            return results;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
	}
}
