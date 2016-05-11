namespace MRS
{
	partial class LoadTemplate
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
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.baseTemplateControl1 = new Common.UserControls.BaseTemplateControl();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.chb_private);
			this.panel1.Controls.Add(this.chb_Common);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.panel1.Size = new System.Drawing.Size(1206, 42);
			this.panel1.TabIndex = 1;
			// 
			// chb_private
			// 
			this.chb_private.AutoSize = true;
			this.chb_private.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chb_private.Location = new System.Drawing.Point(456, 9);
			this.chb_private.Name = "chb_private";
			this.chb_private.Size = new System.Drawing.Size(93, 25);
			this.chb_private.TabIndex = 3;
			this.chb_private.Text = "个人模板";
			this.chb_private.UseVisualStyleBackColor = true;
			// 
			// chb_Common
			// 
			this.chb_Common.AutoSize = true;
			this.chb_Common.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chb_Common.Location = new System.Drawing.Point(357, 9);
			this.chb_Common.Name = "chb_Common";
			this.chb_Common.Size = new System.Drawing.Size(93, 25);
			this.chb_Common.TabIndex = 2;
			this.chb_Common.Text = "通用模板";
			this.chb_Common.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Left;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(169, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "住院记录";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Left;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(100, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "【201】";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(10, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "父级模板：";
			// 
			// baseTemplateControl1
			// 
			this.baseTemplateControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.baseTemplateControl1.Location = new System.Drawing.Point(0, 42);
			this.baseTemplateControl1.Name = "baseTemplateControl1";
			this.baseTemplateControl1.Size = new System.Drawing.Size(1206, 610);
			this.baseTemplateControl1.TabIndex = 2;
			// 
			// LoadTemplate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1206, 652);
			this.Controls.Add(this.baseTemplateControl1);
			this.Controls.Add(this.panel1);
			this.Name = "LoadTemplate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "加载模板";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox chb_private;
		private System.Windows.Forms.CheckBox chb_Common;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Common.UserControls.BaseTemplateControl baseTemplateControl1;

	}
}