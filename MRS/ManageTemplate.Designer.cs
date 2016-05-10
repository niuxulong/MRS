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
			this.label1 = new System.Windows.Forms.Label();
			this.baseTemplateControl1 = new Common.UserControls.BaseTemplateControl();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.panel1.Size = new System.Drawing.Size(1206, 36);
			this.panel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(10, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "父级模板：";
			// 
			// baseTemplateControl1
			// 
			this.baseTemplateControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.baseTemplateControl1.Location = new System.Drawing.Point(0, 36);
			this.baseTemplateControl1.Name = "baseTemplateControl1";
			this.baseTemplateControl1.Size = new System.Drawing.Size(1206, 616);
			this.baseTemplateControl1.TabIndex = 2;
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(107, 10);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(189, 29);
			this.comboBox1.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(339, 9);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 30);
			this.button1.TabIndex = 5;
			this.button1.Text = "修改";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(439, 8);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 30);
			this.button2.TabIndex = 6;
			this.button2.Text = "删除";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(535, 8);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 30);
			this.button3.TabIndex = 7;
			this.button3.Text = "保存";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// ManageTemplate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1206, 652);
			this.Controls.Add(this.baseTemplateControl1);
			this.Controls.Add(this.panel1);
			this.Name = "ManageTemplate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "模板维护";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private Common.UserControls.BaseTemplateControl baseTemplateControl1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;

	}
}