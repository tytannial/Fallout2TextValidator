namespace Fallout2TextValidator
{
    partial class FrmMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCheck = new System.Windows.Forms.Button();
            this.ListBoxError = new System.Windows.Forms.ListBox();
            this.txbPath = new System.Windows.Forms.TextBox();
            this.btnBrowsePath = new System.Windows.Forms.Button();
            this.ckbSubDir = new System.Windows.Forms.CheckBox();
            this.lblErrorList = new System.Windows.Forms.Label();
            this.cbxEncoding = new System.Windows.Forms.ComboBox();
            this.ckbFullLog = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheck.Location = new System.Drawing.Point(697, 526);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // ListBoxError
            // 
            this.ListBoxError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBoxError.FormattingEnabled = true;
            this.ListBoxError.ItemHeight = 12;
            this.ListBoxError.Location = new System.Drawing.Point(13, 25);
            this.ListBoxError.Name = "ListBoxError";
            this.ListBoxError.Size = new System.Drawing.Size(759, 460);
            this.ListBoxError.TabIndex = 1;
            // 
            // txbPath
            // 
            this.txbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPath.Location = new System.Drawing.Point(13, 498);
            this.txbPath.Name = "txbPath";
            this.txbPath.Size = new System.Drawing.Size(678, 21);
            this.txbPath.TabIndex = 2;
            this.txbPath.Leave += new System.EventHandler(this.txbPath_Leave);
            // 
            // btnBrowsePath
            // 
            this.btnBrowsePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowsePath.Location = new System.Drawing.Point(697, 497);
            this.btnBrowsePath.Name = "btnBrowsePath";
            this.btnBrowsePath.Size = new System.Drawing.Size(75, 23);
            this.btnBrowsePath.TabIndex = 3;
            this.btnBrowsePath.Text = "Browse";
            this.btnBrowsePath.UseVisualStyleBackColor = true;
            this.btnBrowsePath.Click += new System.EventHandler(this.btnBrowsePath_Click);
            // 
            // ckbSubDir
            // 
            this.ckbSubDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbSubDir.AutoSize = true;
            this.ckbSubDir.Location = new System.Drawing.Point(13, 530);
            this.ckbSubDir.Name = "ckbSubDir";
            this.ckbSubDir.Size = new System.Drawing.Size(156, 16);
            this.ckbSubDir.TabIndex = 4;
            this.ckbSubDir.Text = "All Files in Directory";
            this.ckbSubDir.UseVisualStyleBackColor = true;
            // 
            // lblErrorList
            // 
            this.lblErrorList.AutoSize = true;
            this.lblErrorList.Location = new System.Drawing.Point(12, 9);
            this.lblErrorList.Name = "lblErrorList";
            this.lblErrorList.Size = new System.Drawing.Size(401, 12);
            this.lblErrorList.TabIndex = 5;
            this.lblErrorList.Text = "If error listed here, please check log files for more information.";
            // 
            // cbxEncoding
            // 
            this.cbxEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEncoding.FormattingEnabled = true;
            this.cbxEncoding.Items.AddRange(new object[] {
            "gb2312",
            "BIG5",
            "Windows-1252",
            "Windows-1251",
            "ANSI",
            "UTF-8"});
            this.cbxEncoding.Location = new System.Drawing.Point(298, 528);
            this.cbxEncoding.Name = "cbxEncoding";
            this.cbxEncoding.Size = new System.Drawing.Size(121, 20);
            this.cbxEncoding.TabIndex = 6;
            // 
            // ckbFullLog
            // 
            this.ckbFullLog.AutoSize = true;
            this.ckbFullLog.Location = new System.Drawing.Point(175, 530);
            this.ckbFullLog.Name = "ckbFullLog";
            this.ckbFullLog.Size = new System.Drawing.Size(72, 16);
            this.ckbFullLog.TabIndex = 7;
            this.ckbFullLog.Text = "Full log";
            this.ckbFullLog.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ckbFullLog);
            this.Controls.Add(this.cbxEncoding);
            this.Controls.Add(this.lblErrorList);
            this.Controls.Add(this.ckbSubDir);
            this.Controls.Add(this.btnBrowsePath);
            this.Controls.Add(this.txbPath);
            this.Controls.Add(this.ListBoxError);
            this.Controls.Add(this.btnCheck);
            this.Name = "FrmMain";
            this.Text = "Fallout 2 Text Validator";
            this.Click += new System.EventHandler(this.FrmMain_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        public System.Windows.Forms.ListBox ListBoxError;
        private System.Windows.Forms.TextBox txbPath;
        private System.Windows.Forms.Button btnBrowsePath;
        private System.Windows.Forms.CheckBox ckbSubDir;
        private System.Windows.Forms.Label lblErrorList;
        private System.Windows.Forms.ComboBox cbxEncoding;
        public System.Windows.Forms.CheckBox ckbFullLog;
    }
}

