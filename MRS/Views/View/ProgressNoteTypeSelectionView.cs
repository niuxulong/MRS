using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace MRS.Views.View
{
    public partial class ProgressNoteTypeSelectionView : Form
    {
        private List<TreeNode> progressNoteTypes;

        public ProgressNoteTypeSelectionView()
        {
            InitializeComponent();
        }

        public List<TreeNode> ProgressNoteTypes
        {
            get
            {
                return progressNoteTypes;
            }
            set
            {
                progressNoteTypes = value;
                this.cbbTypes.DataSource = value.Select(n => n.Text).ToList();
            }
        }

        public TreeNode SelectedTypeNode { get; set; }

        private void ProgressNoteTypeSelectionView_Load(object sender, System.EventArgs e)
        {
        }

        private void btn_Ok_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cbbTypes_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            SelectedTypeNode = ProgressNoteTypes[this.cbbTypes.SelectedIndex];
        }
    }
}
