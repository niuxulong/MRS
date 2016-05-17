namespace MRS
{
	partial class LoadTemplateView
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
            this.chb_private = new System.Windows.Forms.CheckBox();
            this.chb_Common = new System.Windows.Forms.CheckBox();
            this.lb_TemplateName = new System.Windows.Forms.Label();
            this.lb_TemplateId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.baseTemplateControl = new Common.UserControls.BaseTemplateControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chb_private);
            this.panel1.Controls.Add(this.chb_Common);
            this.panel1.Controls.Add(this.lb_TemplateName);
            this.panel1.Controls.Add(this.lb_TemplateId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 9, 0, 0);
            this.panel1.Size = new System.Drawing.Size(1206, 39);
            this.panel1.TabIndex = 1;
            // 
            // chb_private
            // 
            this.chb_private.AutoSize = true;
            this.chb_private.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_private.Location = new System.Drawing.Point(456, 8);
            this.chb_private.Name = "chb_private";
            this.chb_private.Size = new System.Drawing.Size(93, 25);
            this.chb_private.TabIndex = 3;
            this.chb_private.Text = "个人模板";
            this.chb_private.UseVisualStyleBackColor = true;
            this.chb_private.CheckedChanged += new System.EventHandler(this.chb_private_CheckedChanged);
            // 
            // chb_Common
            // 
            this.chb_Common.AutoSize = true;
            this.chb_Common.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_Common.Location = new System.Drawing.Point(357, 8);
            this.chb_Common.Name = "chb_Common";
            this.chb_Common.Size = new System.Drawing.Size(93, 25);
            this.chb_Common.TabIndex = 2;
            this.chb_Common.Text = "通用模板";
            this.chb_Common.UseVisualStyleBackColor = true;
            this.chb_Common.CheckedChanged += new System.EventHandler(this.chb_Common_CheckedChanged);
            // 
            // lb_TemplateName
            // 
            this.lb_TemplateName.AutoSize = true;
            this.lb_TemplateName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_TemplateName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TemplateName.ForeColor = System.Drawing.Color.Blue;
            this.lb_TemplateName.Location = new System.Drawing.Point(169, 9);
            this.lb_TemplateName.Name = "lb_TemplateName";
            this.lb_TemplateName.Size = new System.Drawing.Size(74, 21);
            this.lb_TemplateName.TabIndex = 2;
            this.lb_TemplateName.Text = "住院记录";
            // 
            // lb_TemplateId
            // 
            this.lb_TemplateId.AutoSize = true;
            this.lb_TemplateId.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_TemplateId.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TemplateId.ForeColor = System.Drawing.Color.Blue;
            this.lb_TemplateId.Location = new System.Drawing.Point(100, 9);
            this.lb_TemplateId.Name = "lb_TemplateId";
            this.lb_TemplateId.Size = new System.Drawing.Size(69, 21);
            this.lb_TemplateId.TabIndex = 1;
            this.lb_TemplateId.Text = "【201】";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "父级模板：";
            // 
            // baseTemplateControl
            // 
            this.baseTemplateControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseTemplateControl.Location = new System.Drawing.Point(0, 39);
            this.baseTemplateControl.Name = "baseTemplateControl";
            this.baseTemplateControl.Size = new System.Drawing.Size(1206, 563);
            this.baseTemplateControl.TabIndex = 2;
            this.baseTemplateControl.Load += new System.EventHandler(this.baseTemplateControl_Load);
            // 
            // LoadTemplateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 602);
            this.Controls.Add(this.baseTemplateControl);
            this.Controls.Add(this.panel1);
            this.Name = "LoadTemplateView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加载模板";
            this.Load += new System.EventHandler(this.LoadTemplateView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox chb_private;
		private System.Windows.Forms.CheckBox chb_Common;
		private System.Windows.Forms.Label lb_TemplateName;
		private System.Windows.Forms.Label lb_TemplateId;
		private System.Windows.Forms.Label label1;
		private Common.UserControls.BaseTemplateControl baseTemplateControl;

	}
}