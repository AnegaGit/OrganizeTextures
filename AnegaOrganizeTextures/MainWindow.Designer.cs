namespace AnegaOrganizeTextures
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.labelInfo = new System.Windows.Forms.Label();
            this.ioSourceDir = new System.Windows.Forms.TextBox();
            this.ioTargetDir = new System.Windows.Forms.TextBox();
            this.targetSize = new System.Windows.Forms.ComboBox();
            this.labelTargetSize = new System.Windows.Forms.Label();
            this.labelSourceDir = new System.Windows.Forms.Label();
            this.labelTargetDirectory = new System.Windows.Forms.Label();
            this.FindSourceDirectory = new System.Windows.Forms.Button();
            this.findTargetDirectory = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonClear = new System.Windows.Forms.Button();
            this.LogText = new System.Windows.Forms.RichTextBox();
            this.openFileDialogDir = new System.Windows.Forms.OpenFileDialog();
            this.buttonAbout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(7, 11);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(383, 26);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "The tool replaces all textures in the target. The target should be the Unity Asse" +
    "t.\r\nIt takes all files *_diffuse.png, *_normal.png and *_metall.png into conside" +
    "ration. ";
            // 
            // ioSourceDir
            // 
            this.ioSourceDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ioSourceDir.Location = new System.Drawing.Point(10, 88);
            this.ioSourceDir.Name = "ioSourceDir";
            this.ioSourceDir.ReadOnly = true;
            this.ioSourceDir.Size = new System.Drawing.Size(380, 20);
            this.ioSourceDir.TabIndex = 1;
            // 
            // ioTargetDir
            // 
            this.ioTargetDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ioTargetDir.Location = new System.Drawing.Point(10, 170);
            this.ioTargetDir.Name = "ioTargetDir";
            this.ioTargetDir.ReadOnly = true;
            this.ioTargetDir.Size = new System.Drawing.Size(380, 20);
            this.ioTargetDir.TabIndex = 1;
            // 
            // targetSize
            // 
            this.targetSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.targetSize.FormattingEnabled = true;
            this.targetSize.Items.AddRange(new object[] {
            "256",
            "512",
            "1024",
            "2048"});
            this.targetSize.Location = new System.Drawing.Point(77, 118);
            this.targetSize.Name = "targetSize";
            this.targetSize.Size = new System.Drawing.Size(121, 21);
            this.targetSize.TabIndex = 3;
            // 
            // labelTargetSize
            // 
            this.labelTargetSize.AutoSize = true;
            this.labelTargetSize.Location = new System.Drawing.Point(7, 121);
            this.labelTargetSize.Name = "labelTargetSize";
            this.labelTargetSize.Size = new System.Drawing.Size(64, 13);
            this.labelTargetSize.TabIndex = 4;
            this.labelTargetSize.Text = "Target Size:";
            // 
            // labelSourceDir
            // 
            this.labelSourceDir.AutoSize = true;
            this.labelSourceDir.Location = new System.Drawing.Point(7, 72);
            this.labelSourceDir.Name = "labelSourceDir";
            this.labelSourceDir.Size = new System.Drawing.Size(86, 13);
            this.labelSourceDir.TabIndex = 5;
            this.labelSourceDir.Text = "Source Directory";
            // 
            // labelTargetDirectory
            // 
            this.labelTargetDirectory.AutoSize = true;
            this.labelTargetDirectory.Location = new System.Drawing.Point(10, 154);
            this.labelTargetDirectory.Name = "labelTargetDirectory";
            this.labelTargetDirectory.Size = new System.Drawing.Size(83, 13);
            this.labelTargetDirectory.TabIndex = 5;
            this.labelTargetDirectory.Text = "Target Directory";
            // 
            // FindSourceDirectory
            // 
            this.FindSourceDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FindSourceDirectory.Location = new System.Drawing.Point(396, 85);
            this.FindSourceDirectory.Name = "FindSourceDirectory";
            this.FindSourceDirectory.Size = new System.Drawing.Size(47, 23);
            this.FindSourceDirectory.TabIndex = 6;
            this.FindSourceDirectory.Text = "select";
            this.FindSourceDirectory.UseVisualStyleBackColor = true;
            this.FindSourceDirectory.Click += new System.EventHandler(this.FindSourceDirectory_Click);
            // 
            // findTargetDirectory
            // 
            this.findTargetDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.findTargetDirectory.Location = new System.Drawing.Point(396, 167);
            this.findTargetDirectory.Name = "findTargetDirectory";
            this.findTargetDirectory.Size = new System.Drawing.Size(47, 23);
            this.findTargetDirectory.TabIndex = 6;
            this.findTargetDirectory.Text = "select";
            this.findTargetDirectory.UseVisualStyleBackColor = true;
            this.findTargetDirectory.Click += new System.EventHandler(this.FindTargetDirectory_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.buttonAbout);
            this.splitContainer.Panel1.Controls.Add(this.buttonReplace);
            this.splitContainer.Panel1.Controls.Add(this.buttonCompare);
            this.splitContainer.Panel1.Controls.Add(this.labelInfo);
            this.splitContainer.Panel1.Controls.Add(this.findTargetDirectory);
            this.splitContainer.Panel1.Controls.Add(this.ioSourceDir);
            this.splitContainer.Panel1.Controls.Add(this.labelTargetDirectory);
            this.splitContainer.Panel1.Controls.Add(this.FindSourceDirectory);
            this.splitContainer.Panel1.Controls.Add(this.ioTargetDir);
            this.splitContainer.Panel1.Controls.Add(this.labelTargetSize);
            this.splitContainer.Panel1.Controls.Add(this.labelSourceDir);
            this.splitContainer.Panel1.Controls.Add(this.targetSize);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.progressBar);
            this.splitContainer.Panel2.Controls.Add(this.buttonClear);
            this.splitContainer.Panel2.Controls.Add(this.LogText);
            this.splitContainer.Size = new System.Drawing.Size(884, 482);
            this.splitContainer.SplitterDistance = 451;
            this.splitContainer.TabIndex = 7;
            // 
            // buttonReplace
            // 
            this.buttonReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReplace.Location = new System.Drawing.Point(12, 255);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(430, 23);
            this.buttonReplace.TabIndex = 7;
            this.buttonReplace.Text = "Replace target with source";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.ButtonReplace_Click);
            // 
            // buttonCompare
            // 
            this.buttonCompare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCompare.Location = new System.Drawing.Point(13, 226);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(430, 23);
            this.buttonCompare.TabIndex = 7;
            this.buttonCompare.Text = "Compare target with source";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.ButtonCompare_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(86, 458);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(336, 16);
            this.progressBar.TabIndex = 2;
            this.progressBar.Visible = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClear.Location = new System.Drawing.Point(4, 456);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // LogText
            // 
            this.LogText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogText.Location = new System.Drawing.Point(4, 4);
            this.LogText.Name = "LogText";
            this.LogText.ReadOnly = true;
            this.LogText.Size = new System.Drawing.Size(418, 448);
            this.LogText.TabIndex = 0;
            this.LogText.Text = "";
            // 
            // openFileDialogDir
            // 
            this.openFileDialogDir.CheckFileExists = false;
            this.openFileDialogDir.FileName = "Find Directory";
            this.openFileDialogDir.ValidateNames = false;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(13, 456);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(47, 23);
            this.buttonAbout.TabIndex = 8;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 486);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Organize Textures";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox ioSourceDir;
        private System.Windows.Forms.TextBox ioTargetDir;
        private System.Windows.Forms.ComboBox targetSize;
        private System.Windows.Forms.Label labelTargetSize;
        private System.Windows.Forms.Label labelSourceDir;
        private System.Windows.Forms.Label labelTargetDirectory;
        private System.Windows.Forms.Button FindSourceDirectory;
        private System.Windows.Forms.Button findTargetDirectory;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.RichTextBox LogText;
        private System.Windows.Forms.OpenFileDialog openFileDialogDir;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonAbout;
    }
}

