using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common.UserControls
{
    public partial class EditorControl : UserControl
    {
        public string Title { get; set; }

        public DCSoft.Writer.Controls.WriterControl WriteControl { get { return this.writerControl1; } }

        public string FileContent 
        { 
            get { return this.writerControl1.XMLText; }
            set { this.writerControl1.XMLText = value; }
        }



        public EditorControl()
        {
            InitializeComponent();
            this.writerControl1.CommandControler = this.writerCommandControler1;
            this.writerCommandControler1.Start();
        }

        public void ClearEditor()
        {  
            //清空编辑信息
            writerControl1.XMLText = null;
        }

        public object ExecuteCommand(string commandName,bool showUI, object paramters)
        {
            return this.writerControl1.ExecuteCommand(commandName, showUI, paramters);
        }
    }
}
