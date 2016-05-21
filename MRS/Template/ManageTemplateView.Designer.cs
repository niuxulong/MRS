namespace MRS
{
	partial class ManageTemplate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbb_ParentNodes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.baseTemplateControl = new Common.UserControls.BaseTemplateControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbb_ParentNodes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 9, 0, 0);
            this.panel1.Size = new System.Drawing.Size(1206, 40);
            this.panel1.TabIndex = 1;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(535, 7);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 28);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(439, 7);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 28);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(339, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbb_ParentNodes
            // 
            this.cbb_ParentNodes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_ParentNodes.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ParentNodes.FormattingEnabled = true;
            this.cbb_ParentNodes.Location = new System.Drawing.Point(107, 9);
            this.cbb_ParentNodes.Name = "cbb_ParentNodes";
            this.cbb_ParentNodes.Size = new System.Drawing.Size(189, 29);
            this.cbb_ParentNodes.TabIndex = 4;
            this.cbb_ParentNodes.SelectedIndexChanged += new System.EventHandler(this.cbb_ParentNodes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "父级模板：";
            // 
            // baseTemplateControl
            // 
            this.baseTemplateControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseTemplateControl.EditorReadonly = false;
            this.baseTemplateControl.Location = new System.Drawing.Point(0, 40);
            this.baseTemplateControl.Margin = new System.Windows.Forms.Padding(4);
            this.baseTemplateControl.Name = "baseTemplateControl";
            this.baseTemplateControl.ShowSelectButton = true;
            this.baseTemplateControl.Size = new System.Drawing.Size(1206, 562);
            this.baseTemplateControl.TabIndex = 2;
            // 
            // ManageTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 602);
            this.Controls.Add(this.baseTemplateControl);
            this.Controls.Add(this.panel1);
            this.Name = "ManageTemplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "模板维护";
            this.Load += new System.EventHandler(this.ManageTemplate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private Common.UserControls.BaseTemplateControl baseTemplateControl;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox cbb_ParentNodes;

	}
}