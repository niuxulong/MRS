namespace Common.UserControls
{
    partial class EditorControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorControl));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_FileOpen = new System.Windows.Forms.ToolStripButton();
            this.btn_FileSave = new System.Windows.Forms.ToolStripButton();
            this.btn_Cut = new System.Windows.Forms.ToolStripButton();
            this.btn_Copy = new System.Windows.Forms.ToolStripButton();
            this.btn_Paste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Redo = new System.Windows.Forms.ToolStripButton();
            this.btn_Undo = new System.Windows.Forms.ToolStripButton();
            this.btn_Print = new System.Windows.Forms.ToolStripButton();
            this.btn_PrintView = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_AlignCenter = new System.Windows.Forms.ToolStripButton();
            this.btn_AlignRight = new System.Windows.Forms.ToolStripButton();
            this.btn_AlignLeft = new System.Windows.Forms.ToolStripButton();
            this.AlignJustify = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_NumberList = new System.Windows.Forms.ToolStripButton();
            this.btn_Superscript = new System.Windows.Forms.ToolStripButton();
            this.btn_Subscript = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_BackColor = new System.Windows.Forms.ToolStripButton();
            this.btn_FontColor = new System.Windows.Forms.ToolStripButton();
            this.btn_Underline = new System.Windows.Forms.ToolStripButton();
            this.btn_Italic = new System.Windows.Forms.ToolStripButton();
            this.btn_Bold = new System.Windows.Forms.ToolStripButton();
            this.btn_Font = new System.Windows.Forms.ToolStripButton();
            this.btn_FontName = new System.Windows.Forms.ToolStripComboBox();
            this.btn_FontSize = new System.Windows.Forms.ToolStripComboBox();
            this.writerControl1 = new DCSoft.Writer.Controls.WriterControl();
            this.writerCommandControler1 = new DCSoft.Writer.Commands.WriterCommandControler(this.components);
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.writerCommandControler1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.toolStrip2.Size = new System.Drawing.Size(928, 32);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(124, 29);
            this.toolStripLabel1.Text = "3、编辑病例";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // btn_FileOpen
            // 
            this.btn_FileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_FileOpen.Image = ((System.Drawing.Image)(resources.GetObject("btn_FileOpen.Image")));
            this.btn_FileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_FileOpen.Name = "btn_FileOpen";
            this.btn_FileOpen.Size = new System.Drawing.Size(24, 29);
            this.btn_FileOpen.Text = "打开";
            // 
            // btn_FileSave
            // 
            this.btn_FileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_FileSave.Image = ((System.Drawing.Image)(resources.GetObject("btn_FileSave.Image")));
            this.btn_FileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_FileSave.Name = "btn_FileSave";
            this.btn_FileSave.Size = new System.Drawing.Size(24, 29);
            this.btn_FileSave.Text = "保存";
            // 
            // btn_Cut
            // 
            this.btn_Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Cut.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cut.Image")));
            this.btn_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Cut.Name = "btn_Cut";
            this.btn_Cut.Size = new System.Drawing.Size(24, 29);
            this.btn_Cut.Text = "剪切";
            // 
            // btn_Copy
            // 
            this.btn_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Copy.Image = ((System.Drawing.Image)(resources.GetObject("btn_Copy.Image")));
            this.btn_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(24, 29);
            this.btn_Copy.Text = "复制";
            // 
            // btn_Paste
            // 
            this.btn_Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Paste.Image = ((System.Drawing.Image)(resources.GetObject("btn_Paste.Image")));
            this.btn_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Paste.Name = "btn_Paste";
            this.btn_Paste.Size = new System.Drawing.Size(24, 29);
            this.btn_Paste.Text = "粘贴";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // btn_Redo
            // 
            this.btn_Redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Redo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Redo.Image")));
            this.btn_Redo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Redo.Name = "btn_Redo";
            this.btn_Redo.Size = new System.Drawing.Size(24, 29);
            this.btn_Redo.Text = "重做";
            // 
            // btn_Undo
            // 
            this.btn_Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Undo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Undo.Image")));
            this.btn_Undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(24, 29);
            this.btn_Undo.Text = "撤销";
            // 
            // btn_Print
            // 
            this.btn_Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Print.Image = ((System.Drawing.Image)(resources.GetObject("btn_Print.Image")));
            this.btn_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(24, 29);
            this.btn_Print.Text = "打印";
            // 
            // btn_PrintView
            // 
            this.btn_PrintView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_PrintView.Image = ((System.Drawing.Image)(resources.GetObject("btn_PrintView.Image")));
            this.btn_PrintView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_PrintView.Name = "btn_PrintView";
            this.btn_PrintView.Size = new System.Drawing.Size(24, 29);
            this.btn_PrintView.Text = "打印预览";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 32);
            // 
            // btn_AlignCenter
            // 
            this.btn_AlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_AlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("btn_AlignCenter.Image")));
            this.btn_AlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AlignCenter.Name = "btn_AlignCenter";
            this.btn_AlignCenter.Size = new System.Drawing.Size(24, 29);
            this.btn_AlignCenter.Text = "居中";
            // 
            // btn_AlignRight
            // 
            this.btn_AlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_AlignRight.Image = ((System.Drawing.Image)(resources.GetObject("btn_AlignRight.Image")));
            this.btn_AlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AlignRight.Name = "btn_AlignRight";
            this.btn_AlignRight.Size = new System.Drawing.Size(24, 29);
            this.btn_AlignRight.Text = "右对齐";
            // 
            // btn_AlignLeft
            // 
            this.btn_AlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_AlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("btn_AlignLeft.Image")));
            this.btn_AlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AlignLeft.Name = "btn_AlignLeft";
            this.btn_AlignLeft.Size = new System.Drawing.Size(24, 29);
            this.btn_AlignLeft.Text = "左对齐";
            // 
            // AlignJustify
            // 
            this.AlignJustify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AlignJustify.Image = ((System.Drawing.Image)(resources.GetObject("AlignJustify.Image")));
            this.AlignJustify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlignJustify.Name = "AlignJustify";
            this.AlignJustify.Size = new System.Drawing.Size(24, 29);
            this.AlignJustify.Text = "toolStripButton3";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 32);
            // 
            // btn_NumberList
            // 
            this.btn_NumberList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_NumberList.Image = ((System.Drawing.Image)(resources.GetObject("btn_NumberList.Image")));
            this.btn_NumberList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_NumberList.Name = "btn_NumberList";
            this.btn_NumberList.Size = new System.Drawing.Size(24, 29);
            this.btn_NumberList.Text = "toolStripButton1";
            // 
            // btn_Superscript
            // 
            this.btn_Superscript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Superscript.Image = ((System.Drawing.Image)(resources.GetObject("btn_Superscript.Image")));
            this.btn_Superscript.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Superscript.Name = "btn_Superscript";
            this.btn_Superscript.Size = new System.Drawing.Size(24, 29);
            this.btn_Superscript.Text = "toolStripButton1";
            // 
            // btn_Subscript
            // 
            this.btn_Subscript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Subscript.Image = ((System.Drawing.Image)(resources.GetObject("btn_Subscript.Image")));
            this.btn_Subscript.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Subscript.Name = "btn_Subscript";
            this.btn_Subscript.Size = new System.Drawing.Size(24, 29);
            this.btn_Subscript.Text = "toolStripButton1";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 32);
            // 
            // btn_BackColor
            // 
            this.btn_BackColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_BackColor.Image = ((System.Drawing.Image)(resources.GetObject("btn_BackColor.Image")));
            this.btn_BackColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_BackColor.Name = "btn_BackColor";
            this.btn_BackColor.Size = new System.Drawing.Size(24, 29);
            this.btn_BackColor.Text = "背景颜色";
            // 
            // btn_FontColor
            // 
            this.btn_FontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_FontColor.Image = ((System.Drawing.Image)(resources.GetObject("btn_FontColor.Image")));
            this.btn_FontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_FontColor.Name = "btn_FontColor";
            this.btn_FontColor.Size = new System.Drawing.Size(24, 29);
            this.btn_FontColor.Text = "字体颜色";
            // 
            // btn_Underline
            // 
            this.btn_Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Underline.Image = ((System.Drawing.Image)(resources.GetObject("btn_Underline.Image")));
            this.btn_Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Underline.Name = "btn_Underline";
            this.btn_Underline.Size = new System.Drawing.Size(24, 29);
            this.btn_Underline.Text = "下划线";
            // 
            // btn_Italic
            // 
            this.btn_Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Italic.Image = ((System.Drawing.Image)(resources.GetObject("btn_Italic.Image")));
            this.btn_Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Italic.Name = "btn_Italic";
            this.btn_Italic.Size = new System.Drawing.Size(24, 29);
            this.btn_Italic.Text = "斜体";
            // 
            // btn_Bold
            // 
            this.btn_Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Bold.Image = ((System.Drawing.Image)(resources.GetObject("btn_Bold.Image")));
            this.btn_Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Bold.Name = "btn_Bold";
            this.btn_Bold.Size = new System.Drawing.Size(24, 29);
            this.btn_Bold.Text = "加粗";
            // 
            // btn_Font
            // 
            this.btn_Font.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Font.Image = ((System.Drawing.Image)(resources.GetObject("btn_Font.Image")));
            this.btn_Font.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Font.Name = "btn_Font";
            this.btn_Font.Size = new System.Drawing.Size(24, 29);
            this.btn_Font.Text = "字体";
            // 
            // btn_FontName
            // 
            this.btn_FontName.Name = "btn_FontName";
            this.btn_FontName.Size = new System.Drawing.Size(160, 32);
            // 
            // btn_FontSize
            // 
            this.btn_FontSize.Name = "btn_FontSize";
            this.btn_FontSize.Size = new System.Drawing.Size(121, 28);
            // 
            // writerControl1
            // 
            this.writerControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.writerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.writerControl1.Location = new System.Drawing.Point(0, 32);
            this.writerControl1.Margin = new System.Windows.Forms.Padding(5);
            this.writerControl1.Name = "writerControl1";
            this.writerControl1.Size = new System.Drawing.Size(928, 554);
            this.writerControl1.TabIndex = 4;
            // 
            // EditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.writerControl1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "EditorControl";
            this.Size = new System.Drawing.Size(928, 586);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.writerCommandControler1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_FileOpen;
        private System.Windows.Forms.ToolStripButton btn_FileSave;
        private System.Windows.Forms.ToolStripButton btn_Cut;
        private System.Windows.Forms.ToolStripButton btn_Copy;
        private System.Windows.Forms.ToolStripButton btn_Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Redo;
        private System.Windows.Forms.ToolStripButton btn_Undo;
        private System.Windows.Forms.ToolStripButton btn_Print;
        private System.Windows.Forms.ToolStripButton btn_PrintView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton btn_AlignCenter;
        private System.Windows.Forms.ToolStripButton btn_AlignRight;
        private System.Windows.Forms.ToolStripButton btn_AlignLeft;
        private System.Windows.Forms.ToolStripButton AlignJustify;
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
        private DCSoft.Writer.Controls.WriterControl writerControl1;
        private DCSoft.Writer.Commands.WriterCommandControler writerCommandControler1;
    }
}
