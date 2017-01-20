using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Fallout2TextValidator
{
    public partial class FrmMain : Form
    {
        public static FrmMain frmMain;
        TextValidator validator = new TextValidator();

        public FrmMain()
        {
            InitializeComponent();
            frmMain = this;
            cbxEncoding.SelectedIndex = 0;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (CheckDirectory())
            {
                ListBoxError.Items.Clear();
                string[] files = Directory.GetFiles(txbPath.Text, "*.MSG", ckbSubDir.Checked ? SearchOption.AllDirectories : 0);
                validator.ValidateFiles(files, cbxEncoding.SelectedItem.ToString(), DateTime.Now.ToString("yyyyMMddHHmmss"));
            }
        }

        private void btnBrowsePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select Directory";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txbPath.Text = dialog.SelectedPath;
            }
        }

        private void txbPath_Leave(object sender, EventArgs e)
        {
            CheckDirectory();
        }

        private bool CheckDirectory()
        {
            Regex regex = new Regex(@"^[a-zA-Z]:(((\\(?! )[^/:*?<>\""|\\]+)+\\?)|(\\)?)\s*$");
            if (!regex.IsMatch(txbPath.Text))
            {
                MessageBox.Show("Invalid Directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void FrmMain_Click(object sender, EventArgs e)
        {
            ListBoxError.Focus();
        }
    }
}
