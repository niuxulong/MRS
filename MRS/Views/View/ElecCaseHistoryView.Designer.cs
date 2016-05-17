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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElecCaseHistoryView));
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
            this.btn_History = new System.Windows.Forms.ToolStripLabel();
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
            this.writerControl1 = new DCSoft.Writer.Controls.WriterControl();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_FontName = new System.Windows.Forms.ToolStripComboBox();
            this.btn_FontSize = new System.Windows.Forms.ToolStripComboBox();
            this.writerCommandControler1 = new DCSoft.Writer.Commands.WriterCommandControler(this.components);
            this.btn_FileOpen = new System.Windows.Forms.ToolStripButton();
            this.btn_FileSave = new System.Windows.Forms.ToolStripButton();
            this.btn_Cut = new System.Windows.Forms.ToolStripButton();
            this.btn_Copy = new System.Windows.Forms.ToolStripButton();
            this.btn_Paste = new System.Windows.Forms.ToolStripButton();
            this.btn_Redo = new System.Windows.Forms.ToolStripButton();
            this.btn_Undo = new System.Windows.Forms.ToolStripButton();
            this.btn_Print = new System.Windows.Forms.ToolStripButton();
            this.btn_PrintView = new System.Windows.Forms.ToolStripButton();
            this.btn_AlignCenter = new System.Windows.Forms.ToolStripButton();
            this.btn_AlignRight = new System.Windows.Forms.ToolStripButton();
            this.btn_AlignLeft = new System.Windows.Forms.ToolStripButton();
            this.AlignJustify = new System.Windows.Forms.ToolStripButton();
            this.btn_NumberList = new System.Windows.Forms.ToolStripButton();
            this.btn_Superscript = new System.Windows.Forms.ToolStripButton();
            this.btn_Subscript = new System.Windows.Forms.ToolStripButton();
            this.btn_BackColor = new System.Windows.Forms.ToolStripButton();
            this.btn_FontColor = new System.Windows.Forms.ToolStripButton();
            this.btn_Underline = new System.Windows.Forms.ToolStripButton();
            this.btn_Italic = new System.Windows.Forms.ToolStripButton();
            this.btn_Bold = new System.Windows.Forms.ToolStripButton();
            this.btn_Font = new System.Windows.Forms.ToolStripButton();
            this.btn_data = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_Temperature = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.writerCommandControler1)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_info
            // 
            this.pl_info.Controls.Add(this.tableLayoutPanel1);
            this.pl_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_info.Location = new System.Drawing.Point(0, 0);
            this.pl_info.Name = "pl_info";
            this.pl_info.Size = new System.Drawing.Size(1510, 33);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1510, 33);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txt_User
            // 
            this.txt_User.BackColor = System.Drawing.Color.White;
            this.txt_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_User.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txt_hospitalNo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txt_BedNo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txt_Subject.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txt_Name.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lb_SystemTime.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lb_Name.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lb_Department.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lb_BedNo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lb_HospitalizedNo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lb_User.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label99.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pl_Menu.Size = new System.Drawing.Size(1510, 28);
            this.pl_Menu.TabIndex = 1;
            // 
            // toolStrip1
            // 
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
            this.btn_History,
            this.btn_SystemConfigure});
            this.toolStrip1.Location = new System.Drawing.Point(0, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1510, 29);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_LoadTemplate
            // 
            this.btn_LoadTemplate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadTemplate.IsLink = true;
            this.btn_LoadTemplate.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btn_LoadTemplate.Name = "btn_LoadTemplate";
            this.btn_LoadTemplate.Size = new System.Drawing.Size(74, 26);
            this.btn_LoadTemplate.Text = "加载模板";
            this.btn_LoadTemplate.Click += new System.EventHandler(this.btn_LoadTemplate_Click);
            // 
            // btn_SaveTemplate
            // 
            this.btn_SaveTemplate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveTemplate.IsLink = true;
            this.btn_SaveTemplate.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btn_SaveTemplate.Name = "btn_SaveTemplate";
            this.btn_SaveTemplate.Size = new System.Drawing.Size(74, 26);
            this.btn_SaveTemplate.Text = "保存模板";
            this.btn_SaveTemplate.Click += new System.EventHandler(this.btn_SaveTemplate_Click);
            // 
            // btn_ManageTemplate
            // 
            this.btn_ManageTemplate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_SaveRecord.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveRecord.IsLink = true;
            this.btn_SaveRecord.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btn_SaveRecord.Name = "btn_SaveRecord";
            this.btn_SaveRecord.Size = new System.Drawing.Size(74, 26);
            this.btn_SaveRecord.Text = "病历保存";
            this.btn_SaveRecord.Click += new System.EventHandler(this.btn_SaveRecord_Click);
            // 
            // btn_ManageData
            // 
            this.btn_ManageData.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_Eval.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eval.IsLink = true;
            this.btn_Eval.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btn_Eval.Name = "btn_Eval";
            this.btn_Eval.Size = new System.Drawing.Size(74, 26);
            this.btn_Eval.Text = "质控评分";
            this.btn_Eval.Click += new System.EventHandler(this.btn_Eval_Click);
            // 
            // btn_Validate
            // 
            this.btn_Validate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_ElecSignature.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ElecSignature.IsLink = true;
            this.btn_ElecSignature.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btn_ElecSignature.Name = "btn_ElecSignature";
            this.btn_ElecSignature.Size = new System.Drawing.Size(74, 26);
            this.btn_ElecSignature.Text = "电子签名";
            this.btn_ElecSignature.Click += new System.EventHandler(this.btn_ElecSignature_Click);
            // 
            // btn_Finalize
            // 
            this.btn_Finalize.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_UserConfigure.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_Search.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Blue;
            this.btn_Search.IsLink = true;
            this.btn_Search.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(42, 26);
            this.btn_Search.Text = "查找";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_History
            // 
            this.btn_History.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_History.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_History.ForeColor = System.Drawing.Color.Red;
            this.btn_History.IsLink = true;
            this.btn_History.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btn_History.LinkColor = System.Drawing.Color.Red;
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(74, 26);
            this.btn_History.Text = "历史病历";
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // btn_SystemConfigure
            // 
            this.btn_SystemConfigure.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel1.Size = new System.Drawing.Size(1510, 644);
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
            this.splitContainer1.Size = new System.Drawing.Size(1506, 640);
            this.splitContainer1.SplitterDistance = 151;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tv_TemplateCatalog);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 635);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1、病历目录";
            // 
            // tv_TemplateCatalog
            // 
            this.tv_TemplateCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_TemplateCatalog.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_TemplateCatalog.Location = new System.Drawing.Point(3, 25);
            this.tv_TemplateCatalog.Name = "tv_TemplateCatalog";
            this.tv_TemplateCatalog.Size = new System.Drawing.Size(145, 607);
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
            this.splitContainer2.Panel2.Controls.Add(this.writerControl1);
            this.splitContainer2.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer2.Size = new System.Drawing.Size(1351, 640);
            this.splitContainer2.SplitterDistance = 438;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 635);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2、已完成病历";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 399);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(432, 233);
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
            this.dataGridView2.Size = new System.Drawing.Size(432, 233);
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
            this.panel5.Location = new System.Drawing.Point(3, 365);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(432, 34);
            this.panel5.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel3.Location = new System.Drawing.Point(3, 223);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(432, 142);
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
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(432, 142);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.Color.White;
            this.textBox16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox16.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.ForeColor = System.Drawing.Color.Silver;
            this.textBox16.Location = new System.Drawing.Point(268, 115);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(161, 29);
            this.textBox16.TabIndex = 19;
            this.textBox16.Text = "100";
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.Color.White;
            this.textBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox15.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.ForeColor = System.Drawing.Color.Silver;
            this.textBox15.Location = new System.Drawing.Point(67, 115);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(113, 29);
            this.textBox15.TabIndex = 18;
            this.textBox15.Text = "已完成";
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.White;
            this.textBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox14.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.ForeColor = System.Drawing.Color.Silver;
            this.textBox14.Location = new System.Drawing.Point(268, 87);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(161, 29);
            this.textBox14.TabIndex = 17;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.White;
            this.textBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox13.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.ForeColor = System.Drawing.Color.Silver;
            this.textBox13.Location = new System.Drawing.Point(67, 87);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(113, 29);
            this.textBox13.TabIndex = 16;
            this.textBox13.Text = "未打印";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.White;
            this.textBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox12.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.ForeColor = System.Drawing.Color.Silver;
            this.textBox12.Location = new System.Drawing.Point(268, 59);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(161, 29);
            this.textBox12.TabIndex = 15;
            this.textBox12.Text = "2016-03-18 18：30";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.White;
            this.textBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.ForeColor = System.Drawing.Color.Silver;
            this.textBox11.Location = new System.Drawing.Point(67, 59);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(113, 29);
            this.textBox11.TabIndex = 14;
            this.textBox11.Text = "李主任";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.White;
            this.textBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ForeColor = System.Drawing.Color.Silver;
            this.textBox10.Location = new System.Drawing.Point(268, 31);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(161, 29);
            this.textBox10.TabIndex = 13;
            this.textBox10.Text = "2016-03-18 18：30";
            // 
            // txt_Creator
            // 
            this.txt_Creator.BackColor = System.Drawing.Color.White;
            this.txt_Creator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Creator.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Creator.ForeColor = System.Drawing.Color.Silver;
            this.txt_Creator.Location = new System.Drawing.Point(67, 31);
            this.txt_Creator.Name = "txt_Creator";
            this.txt_Creator.ReadOnly = true;
            this.txt_Creator.Size = new System.Drawing.Size(113, 29);
            this.txt_Creator.TabIndex = 12;
            this.txt_Creator.Text = "系统管理员";
            // 
            // txt_CaseName
            // 
            this.txt_CaseName.BackColor = System.Drawing.Color.White;
            this.txt_CaseName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_CaseName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CaseName.ForeColor = System.Drawing.Color.Silver;
            this.txt_CaseName.Location = new System.Drawing.Point(268, 3);
            this.txt_CaseName.Name = "txt_CaseName";
            this.txt_CaseName.ReadOnly = true;
            this.txt_CaseName.Size = new System.Drawing.Size(161, 29);
            this.txt_CaseName.TabIndex = 11;
            this.txt_CaseName.Text = "入院记录";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "病历ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "病历名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "创建人";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "创建时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "审核人";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(186, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "审核时间";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "打印否";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(186, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "打印时间";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 117);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "时   效";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(186, 117);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "质控评分";
            // 
            // txt_CaseId
            // 
            this.txt_CaseId.BackColor = System.Drawing.Color.White;
            this.txt_CaseId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_CaseId.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CaseId.ForeColor = System.Drawing.Color.Silver;
            this.txt_CaseId.Location = new System.Drawing.Point(67, 3);
            this.txt_CaseId.Name = "txt_CaseId";
            this.txt_CaseId.ReadOnly = true;
            this.txt_CaseId.Size = new System.Drawing.Size(113, 29);
            this.txt_CaseId.TabIndex = 10;
            this.txt_CaseId.Text = "10";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_FinishedCaseHistory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 198);
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
            this.dgv_FinishedCaseHistory.Location = new System.Drawing.Point(0, 0);
            this.dgv_FinishedCaseHistory.Name = "dgv_FinishedCaseHistory";
            this.dgv_FinishedCaseHistory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_FinishedCaseHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_FinishedCaseHistory.Size = new System.Drawing.Size(432, 198);
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
            this.ContextMenuSrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Commit,
            this.MenuItem_RollbackCommit,
            this.MenuItem_RemoveRecord,
            this.MenuItem_CheckRecord,
            this.MenuItem_RemoveCheck});
            this.ContextMenuSrip.Name = "ContextMenuSrip";
            this.ContextMenuSrip.Size = new System.Drawing.Size(125, 114);
            this.ContextMenuSrip.Text = "提交受审";
            // 
            // MenuItem_Commit
            // 
            this.MenuItem_Commit.Name = "MenuItem_Commit";
            this.MenuItem_Commit.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_Commit.Text = "提交受审";
            // 
            // MenuItem_RollbackCommit
            // 
            this.MenuItem_RollbackCommit.Name = "MenuItem_RollbackCommit";
            this.MenuItem_RollbackCommit.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_RollbackCommit.Text = "撤销受审";
            // 
            // MenuItem_RemoveRecord
            // 
            this.MenuItem_RemoveRecord.Name = "MenuItem_RemoveRecord";
            this.MenuItem_RemoveRecord.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_RemoveRecord.Text = "删除病历";
            // 
            // MenuItem_CheckRecord
            // 
            this.MenuItem_CheckRecord.Name = "MenuItem_CheckRecord";
            this.MenuItem_CheckRecord.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_CheckRecord.Text = "审核病历";
            // 
            // MenuItem_RemoveCheck
            // 
            this.MenuItem_RemoveCheck.Name = "MenuItem_RemoveCheck";
            this.MenuItem_RemoveCheck.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_RemoveCheck.Text = "撤销审核";
            // 
            // writerControl1
            // 
            this.writerControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.writerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.writerControl1.Location = new System.Drawing.Point(0, 25);
            this.writerControl1.Name = "writerControl1";
            this.writerControl1.Size = new System.Drawing.Size(909, 615);
            this.writerControl1.TabIndex = 0;
            this.writerControl1.DocumentContentChanged += new DCSoft.Writer.WriterEventHandler(this.writerControl1_DocumentContentChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.btn_FileOpen,
            this.btn_FileSave,
            this.btn_Cut,
            this.btn_Copy,
            this.btn_Paste,
            this.toolStripSeparator2,
            this.btn_Redo,
            this.btn_Undo,
            this.btn_Print,
            this.btn_PrintView,
            this.toolStripSeparator11,
            this.btn_AlignCenter,
            this.btn_AlignRight,
            this.btn_AlignLeft,
            this.AlignJustify,
            this.toolStripSeparator12,
            this.btn_NumberList,
            this.btn_Superscript,
            this.btn_Subscript,
            this.toolStripSeparator13,
            this.btn_BackColor,
            this.btn_FontColor,
            this.btn_Underline,
            this.btn_Italic,
            this.btn_Bold,
            this.btn_Font,
            this.btn_FontName,
            this.btn_FontSize});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(909, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel1.Text = "3、编辑病例";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_FontName
            // 
            this.writerCommandControler1.SetCommandName(this.btn_FontName, "FontName");
            this.btn_FontName.Name = "btn_FontName";
            this.btn_FontName.Size = new System.Drawing.Size(121, 25);
            // 
            // btn_FontSize
            // 
            this.writerCommandControler1.SetCommandName(this.btn_FontSize, "FontSize");
            this.btn_FontSize.Name = "btn_FontSize";
            this.btn_FontSize.Size = new System.Drawing.Size(121, 25);
            // 
            // btn_FileOpen
            // 
            this.writerCommandControler1.SetCommandName(this.btn_FileOpen, "FileOpen");
            this.btn_FileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_FileOpen.Image = ((System.Drawing.Image)(resources.GetObject("btn_FileOpen.Image")));
            this.btn_FileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_FileOpen.Name = "btn_FileOpen";
            this.btn_FileOpen.Size = new System.Drawing.Size(23, 22);
            this.btn_FileOpen.Text = "打开";
            // 
            // btn_FileSave
            // 
            this.writerCommandControler1.SetCommandName(this.btn_FileSave, "FileSave");
            this.btn_FileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_FileSave.Image = ((System.Drawing.Image)(resources.GetObject("btn_FileSave.Image")));
            this.btn_FileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_FileSave.Name = "btn_FileSave";
            this.btn_FileSave.Size = new System.Drawing.Size(23, 22);
            this.btn_FileSave.Text = "保存";
            // 
            // btn_Cut
            // 
            this.writerCommandControler1.SetCommandName(this.btn_Cut, "Cut");
            this.btn_Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Cut.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cut.Image")));
            this.btn_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Cut.Name = "btn_Cut";
            this.btn_Cut.Size = new System.Drawing.Size(23, 22);
            this.btn_Cut.Text = "剪切";
            // 
            // btn_Copy
            // 
            this.writerCommandControler1.SetCommandName(this.btn_Copy, "Copy");
            this.btn_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Copy.Image = ((System.Drawing.Image)(resources.GetObject("btn_Copy.Image")));
            this.btn_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(23, 22);
            this.btn_Copy.Text = "复制";
            // 
            // btn_Paste
            // 
            this.writerCommandControler1.SetCommandName(this.btn_Paste, "Paste");
            this.btn_Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Paste.Image = ((System.Drawing.Image)(resources.GetObject("btn_Paste.Image")));
            this.btn_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Paste.Name = "btn_Paste";
            this.btn_Paste.Size = new System.Drawing.Size(23, 22);
            this.btn_Paste.Text = "粘贴";
            // 
            // btn_Redo
            // 
            this.writerCommandControler1.SetCommandName(this.btn_Redo, "Redo");
            this.btn_Redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Redo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Redo.Image")));
            this.btn_Redo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Redo.Name = "btn_Redo";
            this.btn_Redo.Size = new System.Drawing.Size(23, 22);
            this.btn_Redo.Text = "重做";
            // 
            // btn_Undo
            // 
            this.writerCommandControler1.SetCommandName(this.btn_Undo, "Undo");
            this.btn_Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Undo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Undo.Image")));
            this.btn_Undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(23, 22);
            this.btn_Undo.Text = "撤销";
            // 
            // btn_Print
            // 
            this.writerCommandControler1.SetCommandName(this.btn_Print, "FileCleanPrint");
            this.btn_Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Print.Image = ((System.Drawing.Image)(resources.GetObject("btn_Print.Image")));
            this.btn_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(23, 22);
            this.btn_Print.Text = "打印";
            // 
            // btn_PrintView
            // 
            this.writerCommandControler1.SetCommandName(this.btn_PrintView, "FilePrintPreview");
            this.btn_PrintView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_PrintView.Image = ((System.Drawing.Image)(resources.GetObject("btn_PrintView.Image")));
            this.btn_PrintView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_PrintView.Name = "btn_PrintView";
            this.btn_PrintView.Size = new System.Drawing.Size(23, 22);
            this.btn_PrintView.Text = "打印预览";
            // 
            // btn_AlignCenter
            // 
            this.writerCommandControler1.SetCommandName(this.btn_AlignCenter, "AlignCenter");
            this.btn_AlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_AlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("btn_AlignCenter.Image")));
            this.btn_AlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AlignCenter.Name = "btn_AlignCenter";
            this.btn_AlignCenter.Size = new System.Drawing.Size(23, 22);
            this.btn_AlignCenter.Text = "居中";
            // 
            // btn_AlignRight
            // 
            this.writerCommandControler1.SetCommandName(this.btn_AlignRight, "AlignRight");
            this.btn_AlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_AlignRight.Image = ((System.Drawing.Image)(resources.GetObject("btn_AlignRight.Image")));
            this.btn_AlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AlignRight.Name = "btn_AlignRight";
            this.btn_AlignRight.Size = new System.Drawing.Size(23, 22);
            this.btn_AlignRight.Text = "右对齐";
            // 
            // btn_AlignLeft
            // 
            this.writerCommandControler1.SetCommandName(this.btn_AlignLeft, "AlignLeft");
            this.btn_AlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_AlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("btn_AlignLeft.Image")));
            this.btn_AlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AlignLeft.Name = "btn_AlignLeft";
            this.btn_AlignLeft.Size = new System.Drawing.Size(23, 22);
            this.btn_AlignLeft.Text = "左对齐";
            // 
            // AlignJustify
            // 
            this.writerCommandControler1.SetCommandName(this.AlignJustify, "AlignJustify");
            this.AlignJustify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AlignJustify.Image = ((System.Drawing.Image)(resources.GetObject("AlignJustify.Image")));
            this.AlignJustify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlignJustify.Name = "AlignJustify";
            this.AlignJustify.Size = new System.Drawing.Size(23, 22);
            this.AlignJustify.Text = "toolStripButton3";
            // 
            // btn_NumberList
            // 
            this.writerCommandControler1.SetCommandName(this.btn_NumberList, "NumberedList");
            this.btn_NumberList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_NumberList.Image = ((System.Drawing.Image)(resources.GetObject("btn_NumberList.Image")));
            this.btn_NumberList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_NumberList.Name = "btn_NumberList";
            this.btn_NumberList.Size = new System.Drawing.Size(23, 22);
            this.btn_NumberList.Text = "toolStripButton1";
            // 
            // btn_Superscript
            // 
            this.writerCommandControler1.SetCommandName(this.btn_Superscript, "Superscript");
            this.btn_Superscript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Superscript.Image = ((System.Drawing.Image)(resources.GetObject("btn_Superscript.Image")));
            this.btn_Superscript.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Superscript.Name = "btn_Superscript";
            this.btn_Superscript.Size = new System.Drawing.Size(23, 22);
            this.btn_Superscript.Text = "toolStripButton1";
            // 
            // btn_Subscript
            // 
            this.writerCommandControler1.SetCommandName(this.btn_Subscript, "Subscript");
            this.btn_Subscript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Subscript.Image = ((System.Drawing.Image)(resources.GetObject("btn_Subscript.Image")));
            this.btn_Subscript.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Subscript.Name = "btn_Subscript";
            this.btn_Subscript.Size = new System.Drawing.Size(23, 22);
            this.btn_Subscript.Text = "toolStripButton1";
            // 
            // btn_BackColor
            // 
            this.writerCommandControler1.SetCommandName(this.btn_BackColor, "BackColor");
            this.btn_BackColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_BackColor.Image = ((System.Drawing.Image)(resources.GetObject("btn_BackColor.Image")));
            this.btn_BackColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_BackColor.Name = "btn_BackColor";
            this.btn_BackColor.Size = new System.Drawing.Size(23, 22);
            this.btn_BackColor.Text = "背景颜色";
            // 
            // btn_FontColor
            // 
            this.writerCommandControler1.SetCommandName(this.btn_FontColor, "Color");
            this.btn_FontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_FontColor.Image = ((System.Drawing.Image)(resources.GetObject("btn_FontColor.Image")));
            this.btn_FontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_FontColor.Name = "btn_FontColor";
            this.btn_FontColor.Size = new System.Drawing.Size(23, 22);
            this.btn_FontColor.Text = "字体颜色";
            // 
            // btn_Underline
            // 
            this.writerCommandControler1.SetCommandName(this.btn_Underline, "Underline");
            this.btn_Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Underline.Image = ((System.Drawing.Image)(resources.GetObject("btn_Underline.Image")));
            this.btn_Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Underline.Name = "btn_Underline";
            this.btn_Underline.Size = new System.Drawing.Size(23, 22);
            this.btn_Underline.Text = "下划线";
            // 
            // btn_Italic
            // 
            this.writerCommandControler1.SetCommandName(this.btn_Italic, "Italic");
            this.btn_Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Italic.Image = ((System.Drawing.Image)(resources.GetObject("btn_Italic.Image")));
            this.btn_Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Italic.Name = "btn_Italic";
            this.btn_Italic.Size = new System.Drawing.Size(23, 22);
            this.btn_Italic.Text = "斜体";
            // 
            // btn_Bold
            // 
            this.writerCommandControler1.SetCommandName(this.btn_Bold, "Bold");
            this.btn_Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Bold.Image = ((System.Drawing.Image)(resources.GetObject("btn_Bold.Image")));
            this.btn_Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Bold.Name = "btn_Bold";
            this.btn_Bold.Size = new System.Drawing.Size(23, 22);
            this.btn_Bold.Text = "加粗";
            // 
            // btn_Font
            // 
            this.writerCommandControler1.SetCommandName(this.btn_Font, "Font");
            this.btn_Font.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Font.Image = ((System.Drawing.Image)(resources.GetObject("btn_Font.Image")));
            this.btn_Font.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Font.Name = "btn_Font";
            this.btn_Font.Size = new System.Drawing.Size(23, 22);
            this.btn_Font.Text = "字体";
            // 
            // btn_data
            // 
            this.btn_data.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_data.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Temperature});
            this.btn_data.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            // ElecCaseHistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 705);
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
            this.splitContainer2.Panel2.PerformLayout();
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
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
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
		private System.Windows.Forms.ToolStripLabel btn_History;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_Complated_No;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_Complated_ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_Complated_Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_Complated_Check;
		private DCSoft.Writer.Controls.WriterControl writerControl1;
		private System.Windows.Forms.ToolStripLabel btn_Search;
		private System.Windows.Forms.ContextMenuStrip ContextMenuSrip;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_Commit;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_RollbackCommit;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_RemoveRecord;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_CheckRecord;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_RemoveCheck;
		private System.Windows.Forms.ToolStripLabel btn_SystemConfigure;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btn_FileOpen;
        private DCSoft.Writer.Commands.WriterCommandControler writerCommandControler1;
        private System.Windows.Forms.ToolStripButton btn_FileSave;
        private System.Windows.Forms.ToolStripButton btn_Cut;
        private System.Windows.Forms.ToolStripButton btn_Copy;
        private System.Windows.Forms.ToolStripButton btn_Paste;
        private System.Windows.Forms.ToolStripButton btn_Redo;
        private System.Windows.Forms.ToolStripButton btn_Undo;
        private System.Windows.Forms.ToolStripButton btn_Print;
        private System.Windows.Forms.ToolStripButton btn_PrintView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton btn_AlignCenter;
        private System.Windows.Forms.ToolStripButton btn_AlignRight;
        private System.Windows.Forms.ToolStripButton AlignJustify;
        private System.Windows.Forms.ToolStripButton btn_AlignLeft;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton btn_NumberList;
        private System.Windows.Forms.ToolStripButton btn_Superscript;
        private System.Windows.Forms.ToolStripButton btn_Subscript;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripButton btn_BackColor;
        private System.Windows.Forms.ToolStripButton btn_FontColor;
        private System.Windows.Forms.ToolStripButton btn_Underline;
        private System.Windows.Forms.ToolStripButton btn_Italic;
        private System.Windows.Forms.ToolStripButton btn_Bold;
        private System.Windows.Forms.ToolStripButton btn_Font;
        private System.Windows.Forms.ToolStripComboBox btn_FontName;
        private System.Windows.Forms.ToolStripComboBox btn_FontSize;
        private System.Windows.Forms.ToolStripDropDownButton btn_data;
        private System.Windows.Forms.ToolStripMenuItem btn_Temperature;
	}
}

