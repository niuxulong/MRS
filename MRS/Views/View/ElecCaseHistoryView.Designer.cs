using Common;
namespace MRS.Views.View
{
	partial class ElecCaseHistoryView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElecCaseHistoryView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pl_info = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_hospitalNo = new System.Windows.Forms.TextBox();
            this.txt_BedNo = new System.Windows.Forms.TextBox();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lb_SystemTime = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Department = new System.Windows.Forms.Label();
            this.lb_BedNo = new System.Windows.Forms.Label();
            this.lb_HospitalizedNo = new System.Windows.Forms.Label();
            this.lb_User = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.pl_Menu = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_data = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_Temperature = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_LoadTemplate = new System.Windows.Forms.ToolStripLabel();
            this.btn_SaveTemplate = new System.Windows.Forms.ToolStripLabel();
            this.btn_ManageTemplate = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_SaveRecord = new System.Windows.Forms.ToolStripLabel();
            this.btn_ManageData = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Eval = new System.Windows.Forms.ToolStripLabel();
            this.btn_Validate = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_ElecSignature = new System.Windows.Forms.ToolStripLabel();
            this.btn_Finalize = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_UserConfigure = new System.Windows.Forms.ToolStripLabel();
            this.btn_Search = new System.Windows.Forms.ToolStripLabel();
            this.btn_SystemConfigure = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tv_TemplateCatalog = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.txt_Creator = new System.Windows.Forms.TextBox();
            this.txt_CaseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_CaseId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_FinishedCaseHistory = new System.Windows.Forms.DataGridView();
            this.col_Complated_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Complated_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Complated_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Complated_Check = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuSrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_Commit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_RollbackCommit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_RemoveRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_CheckRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_RemoveCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AppendRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.editorControl = new Common.UserControls.EditorControl();
            this.writerCommandControler1 = new DCSoft.Writer.Commands.WriterCommandControler(this.components);
            this.pl_info.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pl_Menu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FinishedCaseHistory)).BeginInit();
            this.ContextMenuSrip.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.writerCommandControler1)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_info
            // 
            this.pl_info.Controls.Add(this.tableLayoutPanel1);
            this.pl_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_info.Location = new System.Drawing.Point(0, 0);
            this.pl_info.Name = "pl_info";
            this.pl_info.Size = new System.Drawing.Size(1436, 33);
            this.pl_info.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 12;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 465F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txt_User, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_hospitalNo, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_BedNo, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_Subject, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_Name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_SystemTime, 11, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Department, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_BedNo, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_HospitalizedNo, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_User, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.label99, 10, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1436, 33);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txt_User
            // 
            this.txt_User.BackColor = System.Drawing.Color.White;
            this.txt_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_User.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.ForeColor = System.Drawing.Color.Silver;
            this.txt_User.Location = new System.Drawing.Point(777, 8);
            this.txt_User.Name = "txt_User";
            this.txt_User.ReadOnly = true;
            this.txt_User.Size = new System.Drawing.Size(136, 29);
            this.txt_User.TabIndex = 13;
            this.txt_User.Text = "ZY20160658";
            // 
            // txt_hospitalNo
            // 
            this.txt_hospitalNo.BackColor = System.Drawing.Color.White;
            this.txt_hospitalNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_hospitalNo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hospitalNo.ForeColor = System.Drawing.Color.Silver;
            this.txt_hospitalNo.Location = new System.Drawing.Point(573, 8);
            this.txt_hospitalNo.Name = "txt_hospitalNo";
            this.txt_hospitalNo.ReadOnly = true;
            this.txt_hospitalNo.Size = new System.Drawing.Size(117, 29);
            this.txt_hospitalNo.TabIndex = 12;
            this.txt_hospitalNo.Text = "ZY20160658";
            // 
            // txt_BedNo
            // 
            this.txt_BedNo.BackColor = System.Drawing.Color.White;
            this.txt_BedNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_BedNo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BedNo.ForeColor = System.Drawing.Color.Silver;
            this.txt_BedNo.Location = new System.Drawing.Point(390, 8);
            this.txt_BedNo.Name = "txt_BedNo";
            this.txt_BedNo.ReadOnly = true;
            this.txt_BedNo.Size = new System.Drawing.Size(96, 29);
            this.txt_BedNo.TabIndex = 11;
            this.txt_BedNo.Text = "ZY20160658";
            // 
            // txt_Subject
            // 
            this.txt_Subject.BackColor = System.Drawing.Color.White;
            this.txt_Subject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Subject.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Subject.ForeColor = System.Drawing.Color.Silver;
            this.txt_Subject.Location = new System.Drawing.Point(228, 8);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.ReadOnly = true;
            this.txt_Subject.Size = new System.Drawing.Size(87, 29);
            this.txt_Subject.TabIndex = 10;
            this.txt_Subject.Text = "ZY20160658";
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.White;
            this.txt_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.ForeColor = System.Drawing.Color.Silver;
            this.txt_Name.Location = new System.Drawing.Point(68, 8);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.Size = new System.Drawing.Size(86, 29);
            this.txt_Name.TabIndex = 9;
            this.txt_Name.Text = "张散散病人";
            // 
            // lb_SystemTime
            // 
            this.lb_SystemTime.AutoSize = true;
            this.lb_SystemTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SystemTime.Location = new System.Drawing.Point(1048, 10);
            this.lb_SystemTime.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lb_SystemTime.Name = "lb_SystemTime";
            this.lb_SystemTime.Size = new System.Drawing.Size(132, 21);
            this.lb_SystemTime.TabIndex = 7;
            this.lb_SystemTime.Text = "2000-5-52 16:54";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(3, 10);
            this.lb_Name.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(59, 23);
            this.lb_Name.TabIndex = 1;
            this.lb_Name.Text = "姓名：";
            // 
            // lb_Department
            // 
            this.lb_Department.AutoSize = true;
            this.lb_Department.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Department.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Department.Location = new System.Drawing.Point(160, 10);
            this.lb_Department.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lb_Department.Name = "lb_Department";
            this.lb_Department.Size = new System.Drawing.Size(62, 23);
            this.lb_Department.TabIndex = 2;
            this.lb_Department.Text = "科室：";
            // 
            // lb_BedNo
            // 
            this.lb_BedNo.AutoSize = true;
            this.lb_BedNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_BedNo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BedNo.Location = new System.Drawing.Point(321, 10);
            this.lb_BedNo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lb_BedNo.Name = "lb_BedNo";
            this.lb_BedNo.Size = new System.Drawing.Size(63, 23);
            this.lb_BedNo.TabIndex = 3;
            this.lb_BedNo.Text = "床号：";
            // 
            // lb_HospitalizedNo
            // 
            this.lb_HospitalizedNo.AutoSize = true;
            this.lb_HospitalizedNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_HospitalizedNo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HospitalizedNo.Location = new System.Drawing.Point(492, 10);
            this.lb_HospitalizedNo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lb_HospitalizedNo.Name = "lb_HospitalizedNo";
            this.lb_HospitalizedNo.Size = new System.Drawing.Size(75, 23);
            this.lb_HospitalizedNo.TabIndex = 4;
            this.lb_HospitalizedNo.Text = "住院号：";
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_User.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_User.Location = new System.Drawing.Point(696, 10);
            this.lb_User.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(75, 23);
            this.lb_User.TabIndex = 5;
            this.lb_User.Text = "操作员：";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label99.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.Location = new System.Drawing.Point(919, 10);
            this.label99.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(123, 23);
            this.label99.TabIndex = 6;
            this.label99.Text = "当前系统时间：";
            // 
            // pl_Menu
            // 
            this.pl_Menu.Controls.Add(this.toolStrip1);
            this.pl_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_Menu.Location = new System.Drawing.Point(0, 33);
            this.pl_Menu.Name = "pl_Menu";
            this.pl_Menu.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.pl_Menu.Size = new System.Drawing.Size(1436, 28);
            this.pl_Menu.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_data,
            this.btn_LoadTemplate,
            this.btn_SaveTemplate,
            this.btn_ManageTemplate,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.btn_SaveRecord,
            this.btn_ManageData,
            this.toolStripSeparator5,
            this.toolStripSeparator6,
            this.btn_Eval,
            this.btn_Validate,
            this.toolStripSeparator7,
            this.toolStripSeparator8,
            this.btn_ElecSignature,
            this.btn_Finalize,
            this.toolStripSeparator9,
            this.toolStripSeparator10,
            this.btn_UserConfigure,
            this.btn_Search,
            this.btn_SystemConfigure});
            this.toolStrip1.Location = new System.Drawing.Point(0, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1436, 29);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_data
            // 
            this.btn_data.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_data.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Temperature});
            this.btn_data.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_data.ForeColor = System.Drawing.Color.Blue;
            this.btn_data.Image = ((System.Drawing.Image)(resources.GetObject("btn_data.Image")));
            this.btn_data.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_data.Name = "btn_data";
            this.btn_data.Size = new System.Drawing.Size(87, 26);
            this.btn_data.Text = "病人数据";
            // 
            // btn_Temperature
            // 
            this.btn_Temperature.Name = "btn_Temperature";
            this.btn_Temperature.Size = new System.Drawing.Size(128, 26);
            this.btn_Temperature.Text = "体温单";
            this.btn_Temperature.Click += new System.EventHandler(this.btn_Temperature_Click);
            // 
            // btn_LoadTemplate
            // 
            this.btn_LoadTemplate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadTemplate.IsLink = true;
            this.btn_LoadTemplate.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btn_LoadTemplate.Name = "btn_LoadTemplate";
            this.btn_LoadTemplate.Size = new System.Drawing.Size(74, 26);
            this.btn_LoadTemplate.Text = "加载模板";
            this.btn_LoadTemplate.Click += new System.EventHandler(this.btn_LoadTemplate_Click);
            // 
            // btn_SaveTemplate
            // 
            this.btn_SaveTemplate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveTemplate.IsLink = true;
            this.btn_SaveTemplate.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btn_SaveTemplate.Name = "btn_SaveTemplate";
            this.btn_SaveTemplate.Size = new System.Drawing.Size(74, 26);
            this.btn_SaveTemplate.Text = "保存模板";
            this.btn_SaveTemplate.Click += new System.EventHandler(this.btn_SaveTemplate_Click);
            // 
            // btn_ManageTemplate
            // 
            this.btn_ManageTemplate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageTemplate.IsLink = true;
            this.btn_ManageTemplate.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btn_ManageTemplate.Name = "btn_ManageTemplate";
            this.btn_ManageTemplate.Size = new System.Drawing.Size(74, 26);
            this.btn_ManageTemplate.Text = "模板维护";
            this.btn_ManageTemplate.Click += new System.EventHandler(this.btn_ManageTemplate_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 29);
            // 
            // btn_SaveRecord
            // 
            this.btn_SaveRecord.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveRecord.IsLink = true;
            this.btn_SaveRecord.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btn_SaveRecord.Name = "btn_SaveRecord";
            this.btn_SaveRecord.Size = new System.Drawing.Size(74, 26);
            this.btn_SaveRecord.Text = "病历保存";
            this.btn_SaveRecord.Click += new System.EventHandler(this.btn_SaveRecord_Click);
            // 
            // btn_ManageData
            // 
            this.btn_ManageData.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageData.IsLink = true;
            this.btn_ManageData.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btn_ManageData.Name = "btn_ManageData";
            this.btn_ManageData.Size = new System.Drawing.Size(74, 26);
            this.btn_ManageData.Text = "辅检数据";
            this.btn_ManageData.Click += new System.EventHandler(this.btn_ManageData_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 29);
            // 
            // btn_Eval
            // 
            this.btn_Eval.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eval.IsLink = true;
            this.btn_Eval.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btn_Eval.Name = "btn_Eval";
            this.btn_Eval.Size = new System.Drawing.Size(74, 26);
            this.btn_Eval.Text = "质控评分";
            this.btn_Eval.Click += new System.EventHandler(this.btn_Eval_Click);
            // 
            // btn_Validate
            // 
            this.btn_Validate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Validate.IsLink = true;
            this.btn_Validate.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btn_Validate.Name = "btn_Validate";
            this.btn_Validate.Size = new System.Drawing.Size(74, 26);
            this.btn_Validate.Text = "病历校验";
            this.btn_Validate.Click += new System.EventHandler(this.btn_Validate_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 29);
            // 
            // btn_ElecSignature
            // 
            this.btn_ElecSignature.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ElecSignature.IsLink = true;
            this.btn_ElecSignature.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btn_ElecSignature.Name = "btn_ElecSignature";
            this.btn_ElecSignature.Size = new System.Drawing.Size(74, 26);
            this.btn_ElecSignature.Text = "电子签名";
            this.btn_ElecSignature.Click += new System.EventHandler(this.btn_ElecSignature_Click);
            // 
            // btn_Finalize
            // 
            this.btn_Finalize.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Finalize.IsLink = true;
            this.btn_Finalize.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btn_Finalize.Name = "btn_Finalize";
            this.btn_Finalize.Size = new System.Drawing.Size(74, 26);
            this.btn_Finalize.Text = "病案归档";
            this.btn_Finalize.Click += new System.EventHandler(this.btn_Finalize_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 29);
            // 
            // btn_UserConfigure
            // 
            this.btn_UserConfigure.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UserConfigure.IsLink = true;
            this.btn_UserConfigure.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btn_UserConfigure.Name = "btn_UserConfigure";
            this.btn_UserConfigure.Size = new System.Drawing.Size(74, 26);
            this.btn_UserConfigure.Text = "用户配置";
            this.btn_UserConfigure.Click += new System.EventHandler(this.btn_Configure_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_Search.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Blue;
            this.btn_Search.IsLink = true;
            this.btn_Search.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(42, 26);
            this.btn_Search.Text = "查找";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_SystemConfigure
            // 
            this.btn_SystemConfigure.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SystemConfigure.IsLink = true;
            this.btn_SystemConfigure.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btn_SystemConfigure.Name = "btn_SystemConfigure";
            this.btn_SystemConfigure.Size = new System.Drawing.Size(74, 26);
            this.btn_SystemConfigure.Text = "系统配置";
            this.btn_SystemConfigure.Click += new System.EventHandler(this.btn_SystemConfigure_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1436, 644);
            this.panel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1432, 640);
            this.splitContainer1.SplitterDistance = 143;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tv_TemplateCatalog);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 635);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1、病历目录";
            // 
            // tv_TemplateCatalog
            // 
            this.tv_TemplateCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_TemplateCatalog.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_TemplateCatalog.Location = new System.Drawing.Point(3, 25);
            this.tv_TemplateCatalog.Name = "tv_TemplateCatalog";
            this.tv_TemplateCatalog.Size = new System.Drawing.Size(137, 607);
            this.tv_TemplateCatalog.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(1285, 640);
            this.splitContainer2.SplitterDistance = 401;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(401, 635);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2、已完成病历";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(4, 494);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(393, 137);
            this.panel4.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Content});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.Size = new System.Drawing.Size(393, 137);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "序号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 67;
            // 
            // Content
            // 
            this.Content.HeaderText = "提醒内容";
            this.Content.Name = "Content";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label11);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(4, 452);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(393, 42);
            this.panel5.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(21, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "审核提示，时效提醒";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(4, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(393, 178);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.80749F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.21296F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.42593F));
            this.tableLayoutPanel2.Controls.Add(this.textBox16, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBox15, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBox14, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox13, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox12, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox11, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox10, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_Creator, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_CaseName, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label10, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.txt_CaseId, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(393, 178);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.Color.White;
            this.textBox16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox16.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.ForeColor = System.Drawing.Color.Silver;
            this.textBox16.Location = new System.Drawing.Point(245, 144);
            this.textBox16.Margin = new System.Windows.Forms.Padding(4);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(144, 29);
            this.textBox16.TabIndex = 19;
            this.textBox16.Text = "100";
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.Color.White;
            this.textBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.ForeColor = System.Drawing.Color.Silver;
            this.textBox15.Location = new System.Drawing.Point(62, 144);
            this.textBox15.Margin = new System.Windows.Forms.Padding(4);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(100, 29);
            this.textBox15.TabIndex = 18;
            this.textBox15.Text = "已完成";
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.White;
            this.textBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.ForeColor = System.Drawing.Color.Silver;
            this.textBox14.Location = new System.Drawing.Point(245, 109);
            this.textBox14.Margin = new System.Windows.Forms.Padding(4);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(144, 29);
            this.textBox14.TabIndex = 17;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.White;
            this.textBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.ForeColor = System.Drawing.Color.Silver;
            this.textBox13.Location = new System.Drawing.Point(62, 109);
            this.textBox13.Margin = new System.Windows.Forms.Padding(4);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(100, 29);
            this.textBox13.TabIndex = 16;
            this.textBox13.Text = "未打印";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.White;
            this.textBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.ForeColor = System.Drawing.Color.Silver;
            this.textBox12.Location = new System.Drawing.Point(245, 74);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(144, 29);
            this.textBox12.TabIndex = 15;
            this.textBox12.Text = "2016-03-18 18：30";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.White;
            this.textBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.ForeColor = System.Drawing.Color.Silver;
            this.textBox11.Location = new System.Drawing.Point(62, 74);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(100, 29);
            this.textBox11.TabIndex = 14;
            this.textBox11.Text = "李主任";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.White;
            this.textBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ForeColor = System.Drawing.Color.Silver;
            this.textBox10.Location = new System.Drawing.Point(245, 39);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(144, 29);
            this.textBox10.TabIndex = 13;
            this.textBox10.Text = "2016-03-18 18：30";
            // 
            // txt_Creator
            // 
            this.txt_Creator.BackColor = System.Drawing.Color.White;
            this.txt_Creator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Creator.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Creator.ForeColor = System.Drawing.Color.Silver;
            this.txt_Creator.Location = new System.Drawing.Point(62, 39);
            this.txt_Creator.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Creator.Name = "txt_Creator";
            this.txt_Creator.ReadOnly = true;
            this.txt_Creator.Size = new System.Drawing.Size(100, 29);
            this.txt_Creator.TabIndex = 12;
            this.txt_Creator.Text = "系统管理员";
            // 
            // txt_CaseName
            // 
            this.txt_CaseName.BackColor = System.Drawing.Color.White;
            this.txt_CaseName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_CaseName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CaseName.ForeColor = System.Drawing.Color.Silver;
            this.txt_CaseName.Location = new System.Drawing.Point(245, 4);
            this.txt_CaseName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CaseName.Name = "txt_CaseName";
            this.txt_CaseName.ReadOnly = true;
            this.txt_CaseName.Size = new System.Drawing.Size(144, 29);
            this.txt_CaseName.TabIndex = 11;
            this.txt_CaseName.Text = "入院记录";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "病历ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "病历名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "创建人";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "创建时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "审核人";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(170, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "审核时间";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "打印否";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(170, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "打印时间";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 33);
            this.label9.TabIndex = 8;
            this.label9.Text = "时   效";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(170, 146);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 32);
            this.label10.TabIndex = 9;
            this.label10.Text = "质控评分";
            // 
            // txt_CaseId
            // 
            this.txt_CaseId.BackColor = System.Drawing.Color.White;
            this.txt_CaseId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_CaseId.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CaseId.ForeColor = System.Drawing.Color.Silver;
            this.txt_CaseId.Location = new System.Drawing.Point(62, 4);
            this.txt_CaseId.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CaseId.Name = "txt_CaseId";
            this.txt_CaseId.ReadOnly = true;
            this.txt_CaseId.Size = new System.Drawing.Size(100, 29);
            this.txt_CaseId.TabIndex = 10;
            this.txt_CaseId.Text = "10";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_FinishedCaseHistory);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 248);
            this.panel2.TabIndex = 0;
            // 
            // dgv_FinishedCaseHistory
            // 
            this.dgv_FinishedCaseHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_FinishedCaseHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FinishedCaseHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Complated_No,
            this.col_Complated_ID,
            this.col_Complated_Name,
            this.col_Complated_Check});
            this.dgv_FinishedCaseHistory.ContextMenuStrip = this.ContextMenuSrip;
            this.dgv_FinishedCaseHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_FinishedCaseHistory.Location = new System.Drawing.Point(0, 42);
            this.dgv_FinishedCaseHistory.Name = "dgv_FinishedCaseHistory";
            this.dgv_FinishedCaseHistory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_FinishedCaseHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_FinishedCaseHistory.Size = new System.Drawing.Size(393, 206);
            this.dgv_FinishedCaseHistory.TabIndex = 0;
            // 
            // col_Complated_No
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_Complated_No.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_Complated_No.HeaderText = "序号";
            this.col_Complated_No.Name = "col_Complated_No";
            this.col_Complated_No.ReadOnly = true;
            // 
            // col_Complated_ID
            // 
            this.col_Complated_ID.HeaderText = "病历ID";
            this.col_Complated_ID.Name = "col_Complated_ID";
            this.col_Complated_ID.ReadOnly = true;
            // 
            // col_Complated_Name
            // 
            this.col_Complated_Name.HeaderText = "病历名称";
            this.col_Complated_Name.Name = "col_Complated_Name";
            this.col_Complated_Name.ReadOnly = true;
            // 
            // col_Complated_Check
            // 
            this.col_Complated_Check.HeaderText = "校验";
            this.col_Complated_Check.Name = "col_Complated_Check";
            this.col_Complated_Check.ReadOnly = true;
            // 
            // ContextMenuSrip
            // 
            this.ContextMenuSrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuSrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Commit,
            this.MenuItem_RollbackCommit,
            this.MenuItem_RemoveRecord,
            this.MenuItem_CheckRecord,
            this.MenuItem_RemoveCheck,
            this.MenuItem_AppendRecord});
            this.ContextMenuSrip.Name = "ContextMenuSrip";
            this.ContextMenuSrip.Size = new System.Drawing.Size(125, 136);
            this.ContextMenuSrip.Text = "提交受审";
            // 
            // MenuItem_Commit
            // 
            this.MenuItem_Commit.Name = "MenuItem_Commit";
            this.MenuItem_Commit.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_Commit.Text = "提交受审";
            this.MenuItem_Commit.Click += new System.EventHandler(this.CaseHistory_MenuItem_Commit_Click);
            // 
            // MenuItem_RollbackCommit
            // 
            this.MenuItem_RollbackCommit.Name = "MenuItem_RollbackCommit";
            this.MenuItem_RollbackCommit.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_RollbackCommit.Text = "撤销受审";
            this.MenuItem_RollbackCommit.Click += new System.EventHandler(this.CaseHistory_MenuItem_RollbackCommit_Click);
            // 
            // MenuItem_RemoveRecord
            // 
            this.MenuItem_RemoveRecord.Name = "MenuItem_RemoveRecord";
            this.MenuItem_RemoveRecord.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_RemoveRecord.Text = "删除病历";
            this.MenuItem_RemoveRecord.Click += new System.EventHandler(this.CaseHistory_MenuItem_RemoveRecord_Click);
            // 
            // MenuItem_CheckRecord
            // 
            this.MenuItem_CheckRecord.Name = "MenuItem_CheckRecord";
            this.MenuItem_CheckRecord.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_CheckRecord.Text = "审核病历";
            this.MenuItem_CheckRecord.Click += new System.EventHandler(this.CaseHistory_MenuItem_AppendRecord_Click);
            // 
            // MenuItem_RemoveCheck
            // 
            this.MenuItem_RemoveCheck.Name = "MenuItem_RemoveCheck";
            this.MenuItem_RemoveCheck.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_RemoveCheck.Text = "撤销审核";
            this.MenuItem_RemoveCheck.Click += new System.EventHandler(this.CaseHistory_MenuItem_RemoveCheck_Click);
            // 
            // MenuItem_AppendRecord
            // 
            this.MenuItem_AppendRecord.Name = "MenuItem_AppendRecord";
            this.MenuItem_AppendRecord.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_AppendRecord.Text = "追加病程";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(393, 42);
            this.panel6.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(181, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "检索";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(2, 3);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 29);
            this.textBox1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(879, 640);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.editorControl);
            this.tabPage1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(871, 614);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "操作页";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // editorControl
            // 
            this.editorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorControl.FileContent = resources.GetString("editorControl.FileContent");
            this.editorControl.Location = new System.Drawing.Point(3, 3);
            this.editorControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editorControl.Name = "editorControl";
            this.editorControl.Size = new System.Drawing.Size(865, 608);
            this.editorControl.TabIndex = 0;
            this.editorControl.Title = "";
            // 
            // ElecCaseHistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 705);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pl_Menu);
            this.Controls.Add(this.pl_info);
            this.Name = "ElecCaseHistoryView";
            this.Text = "电子病历";
            this.Load += new System.EventHandler(this.ElecCaseHistoryView_Load);
            this.pl_info.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pl_Menu.ResumeLayout(false);
            this.pl_Menu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FinishedCaseHistory)).EndInit();
            this.ContextMenuSrip.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.writerCommandControler1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pl_info;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lb_Name;
		private System.Windows.Forms.Label lb_Department;
		private System.Windows.Forms.Label lb_BedNo;
		private System.Windows.Forms.Label lb_HospitalizedNo;
		private System.Windows.Forms.Label lb_User;
		private System.Windows.Forms.Label label99;
		private System.Windows.Forms.Label lb_SystemTime;
		private System.Windows.Forms.TextBox txt_User;
		private System.Windows.Forms.TextBox txt_hospitalNo;
		private System.Windows.Forms.TextBox txt_BedNo;
		private System.Windows.Forms.TextBox txt_Subject;
		private System.Windows.Forms.TextBox txt_Name;
		private System.Windows.Forms.Panel pl_Menu;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel btn_LoadTemplate;
		private System.Windows.Forms.ToolStripLabel btn_SaveTemplate;
		private System.Windows.Forms.ToolStripLabel btn_ManageTemplate;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripLabel btn_SaveRecord;
		private System.Windows.Forms.ToolStripLabel btn_ManageData;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripLabel btn_Eval;
		private System.Windows.Forms.ToolStripLabel btn_Validate;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripLabel btn_ElecSignature;
		private System.Windows.Forms.ToolStripLabel btn_Finalize;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
		private System.Windows.Forms.ToolStripLabel btn_UserConfigure;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TreeView tv_TemplateCatalog;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dgv_FinishedCaseHistory;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox txt_Creator;
		private System.Windows.Forms.TextBox txt_CaseName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txt_CaseId;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Content;
		private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_Complated_No;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_Complated_ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_Complated_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Complated_Check;
		private System.Windows.Forms.ToolStripLabel btn_Search;
		private System.Windows.Forms.ContextMenuStrip ContextMenuSrip;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_Commit;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_RollbackCommit;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_RemoveRecord;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_CheckRecord;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_RemoveCheck;
        private System.Windows.Forms.ToolStripLabel btn_SystemConfigure;
        private DCSoft.Writer.Commands.WriterCommandControler writerCommandControler1;
        private System.Windows.Forms.ToolStripDropDownButton btn_data;
        private System.Windows.Forms.ToolStripMenuItem btn_Temperature;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_AppendRecord;
        private Common.UserControls.EditorControl editorControl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
	}
}

