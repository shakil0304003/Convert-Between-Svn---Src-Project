namespace asthaSvnSrc
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbProgram = new System.Windows.Forms.GroupBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.rdbSrc = new System.Windows.Forms.RadioButton();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.rdbSVN = new System.Windows.Forms.RadioButton();
            this.lblSvnLocation = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtSvnLocation = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpenSvn = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSrcLocation = new System.Windows.Forms.Label();
            this.btnSrcLocation = new System.Windows.Forms.Button();
            this.txtSrcLocation = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRefreshSvn = new System.Windows.Forms.Button();
            this.btnSaveSvn = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.dgvFile = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFolder = new System.Windows.Forms.Label();
            this.dgvFolder = new System.Windows.Forms.DataGridView();
            this.Folder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRefreshSrc = new System.Windows.Forms.Button();
            this.btnSaveSrc = new System.Windows.Forms.Button();
            this.lblFileSrc = new System.Windows.Forms.Label();
            this.dgvFileSrc = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFolderSrc = new System.Windows.Forms.Label();
            this.dgvFolderSrc = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fbdOpen = new System.Windows.Forms.FolderBrowserDialog();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpenfile = new System.Windows.Forms.OpenFileDialog();
            this.pbRun = new System.Windows.Forms.ProgressBar();
            this.trRun = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbProgram.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolder)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolderSrc)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(370, 335);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbProgram);
            this.tabPage1.Controls.Add(this.btnOpen);
            this.tabPage1.Controls.Add(this.btnNew);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(362, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Project";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbProgram
            // 
            this.gbProgram.Controls.Add(this.lblProjectName);
            this.gbProgram.Controls.Add(this.rdbSrc);
            this.gbProgram.Controls.Add(this.txtProjectName);
            this.gbProgram.Controls.Add(this.rdbSVN);
            this.gbProgram.Controls.Add(this.lblSvnLocation);
            this.gbProgram.Controls.Add(this.btnRun);
            this.gbProgram.Controls.Add(this.txtSvnLocation);
            this.gbProgram.Controls.Add(this.btnClose);
            this.gbProgram.Controls.Add(this.btnOpenSvn);
            this.gbProgram.Controls.Add(this.btnSave);
            this.gbProgram.Controls.Add(this.lblSrcLocation);
            this.gbProgram.Controls.Add(this.btnSrcLocation);
            this.gbProgram.Controls.Add(this.txtSrcLocation);
            this.gbProgram.Location = new System.Drawing.Point(22, 43);
            this.gbProgram.Name = "gbProgram";
            this.gbProgram.Size = new System.Drawing.Size(319, 247);
            this.gbProgram.TabIndex = 24;
            this.gbProgram.TabStop = false;
            this.gbProgram.Text = "Project";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(18, 41);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(80, 13);
            this.lblProjectName.TabIndex = 11;
            this.lblProjectName.Text = "Project Name : ";
            // 
            // rdbSrc
            // 
            this.rdbSrc.AutoSize = true;
            this.rdbSrc.Location = new System.Drawing.Point(114, 180);
            this.rdbSrc.Name = "rdbSrc";
            this.rdbSrc.Size = new System.Drawing.Size(87, 17);
            this.rdbSrc.TabIndex = 23;
            this.rdbSrc.TabStop = true;
            this.rdbSrc.Text = "VSS To SVN";
            this.rdbSrc.UseVisualStyleBackColor = true;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(118, 38);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(151, 20);
            this.txtProjectName.TabIndex = 12;
            // 
            // rdbSVN
            // 
            this.rdbSVN.AutoSize = true;
            this.rdbSVN.Location = new System.Drawing.Point(114, 159);
            this.rdbSVN.Name = "rdbSVN";
            this.rdbSVN.Size = new System.Drawing.Size(87, 17);
            this.rdbSVN.TabIndex = 22;
            this.rdbSVN.TabStop = true;
            this.rdbSVN.Text = "SVN To VSS";
            this.rdbSVN.UseVisualStyleBackColor = true;
            // 
            // lblSvnLocation
            // 
            this.lblSvnLocation.AutoSize = true;
            this.lblSvnLocation.Location = new System.Drawing.Point(18, 81);
            this.lblSvnLocation.Name = "lblSvnLocation";
            this.lblSvnLocation.Size = new System.Drawing.Size(79, 13);
            this.lblSvnLocation.TabIndex = 13;
            this.lblSvnLocation.Text = "SVN Location :";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(74, 217);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 21;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtSvnLocation
            // 
            this.txtSvnLocation.Location = new System.Drawing.Point(116, 81);
            this.txtSvnLocation.Name = "txtSvnLocation";
            this.txtSvnLocation.Size = new System.Drawing.Size(153, 20);
            this.txtSvnLocation.TabIndex = 14;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(236, 217);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpenSvn
            // 
            this.btnOpenSvn.Location = new System.Drawing.Point(274, 80);
            this.btnOpenSvn.Name = "btnOpenSvn";
            this.btnOpenSvn.Size = new System.Drawing.Size(25, 23);
            this.btnOpenSvn.TabIndex = 15;
            this.btnOpenSvn.Text = "...";
            this.btnOpenSvn.UseVisualStyleBackColor = true;
            this.btnOpenSvn.Click += new System.EventHandler(this.btnOpenSvn_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(155, 217);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSrcLocation
            // 
            this.lblSrcLocation.AutoSize = true;
            this.lblSrcLocation.Location = new System.Drawing.Point(17, 128);
            this.lblSrcLocation.Name = "lblSrcLocation";
            this.lblSrcLocation.Size = new System.Drawing.Size(81, 13);
            this.lblSrcLocation.TabIndex = 16;
            this.lblSrcLocation.Text = "VSS Location : ";
            // 
            // btnSrcLocation
            // 
            this.btnSrcLocation.Location = new System.Drawing.Point(274, 123);
            this.btnSrcLocation.Name = "btnSrcLocation";
            this.btnSrcLocation.Size = new System.Drawing.Size(25, 23);
            this.btnSrcLocation.TabIndex = 18;
            this.btnSrcLocation.Text = "...";
            this.btnSrcLocation.UseVisualStyleBackColor = true;
            this.btnSrcLocation.Click += new System.EventHandler(this.btnSrcLocation_Click);
            // 
            // txtSrcLocation
            // 
            this.txtSrcLocation.Location = new System.Drawing.Point(114, 124);
            this.txtSrcLocation.Name = "txtSrcLocation";
            this.txtSrcLocation.Size = new System.Drawing.Size(153, 20);
            this.txtSrcLocation.TabIndex = 17;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(110, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(23, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRefreshSvn);
            this.tabPage2.Controls.Add(this.btnSaveSvn);
            this.tabPage2.Controls.Add(this.lblFile);
            this.tabPage2.Controls.Add(this.dgvFile);
            this.tabPage2.Controls.Add(this.lblFolder);
            this.tabPage2.Controls.Add(this.dgvFolder);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(362, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SVN Rules";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRefreshSvn
            // 
            this.btnRefreshSvn.Location = new System.Drawing.Point(221, 277);
            this.btnRefreshSvn.Name = "btnRefreshSvn";
            this.btnRefreshSvn.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshSvn.TabIndex = 10;
            this.btnRefreshSvn.Text = "Refresh";
            this.btnRefreshSvn.UseVisualStyleBackColor = true;
            this.btnRefreshSvn.Click += new System.EventHandler(this.btnRefreshSvn_Click);
            // 
            // btnSaveSvn
            // 
            this.btnSaveSvn.Location = new System.Drawing.Point(140, 277);
            this.btnSaveSvn.Name = "btnSaveSvn";
            this.btnSaveSvn.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSvn.TabIndex = 9;
            this.btnSaveSvn.Text = "Save";
            this.btnSaveSvn.UseVisualStyleBackColor = true;
            this.btnSaveSvn.Click += new System.EventHandler(this.btnSaveSvn_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(67, 146);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(29, 13);
            this.lblFile.TabIndex = 8;
            this.lblFile.Text = "File: ";
            // 
            // dgvFile
            // 
            this.dgvFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvFile.Location = new System.Drawing.Point(66, 166);
            this.dgvFile.Name = "dgvFile";
            this.dgvFile.RowHeadersVisible = false;
            this.dgvFile.Size = new System.Drawing.Size(230, 105);
            this.dgvFile.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 185F;
            this.dataGridViewTextBoxColumn1.HeaderText = "File Format";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(67, 9);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(42, 13);
            this.lblFolder.TabIndex = 6;
            this.lblFolder.Text = "Folder: ";
            // 
            // dgvFolder
            // 
            this.dgvFolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFolder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folder});
            this.dgvFolder.Location = new System.Drawing.Point(66, 25);
            this.dgvFolder.Name = "dgvFolder";
            this.dgvFolder.RowHeadersVisible = false;
            this.dgvFolder.Size = new System.Drawing.Size(230, 105);
            this.dgvFolder.TabIndex = 5;
            // 
            // Folder
            // 
            this.Folder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Folder.FillWeight = 200F;
            this.Folder.HeaderText = "Folder Name";
            this.Folder.Name = "Folder";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnRefreshSrc);
            this.tabPage3.Controls.Add(this.btnSaveSrc);
            this.tabPage3.Controls.Add(this.lblFileSrc);
            this.tabPage3.Controls.Add(this.dgvFileSrc);
            this.tabPage3.Controls.Add(this.lblFolderSrc);
            this.tabPage3.Controls.Add(this.dgvFolderSrc);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(362, 309);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "VSS Rules";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRefreshSrc
            // 
            this.btnRefreshSrc.Location = new System.Drawing.Point(221, 277);
            this.btnRefreshSrc.Name = "btnRefreshSrc";
            this.btnRefreshSrc.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshSrc.TabIndex = 15;
            this.btnRefreshSrc.Text = "Refresh";
            this.btnRefreshSrc.UseVisualStyleBackColor = true;
            this.btnRefreshSrc.Click += new System.EventHandler(this.btnRefreshSrc_Click);
            // 
            // btnSaveSrc
            // 
            this.btnSaveSrc.Location = new System.Drawing.Point(140, 277);
            this.btnSaveSrc.Name = "btnSaveSrc";
            this.btnSaveSrc.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSrc.TabIndex = 14;
            this.btnSaveSrc.Text = "Save";
            this.btnSaveSrc.UseVisualStyleBackColor = true;
            this.btnSaveSrc.Click += new System.EventHandler(this.btnSaveSrc_Click);
            // 
            // lblFileSrc
            // 
            this.lblFileSrc.AutoSize = true;
            this.lblFileSrc.Location = new System.Drawing.Point(67, 146);
            this.lblFileSrc.Name = "lblFileSrc";
            this.lblFileSrc.Size = new System.Drawing.Size(29, 13);
            this.lblFileSrc.TabIndex = 13;
            this.lblFileSrc.Text = "File: ";
            // 
            // dgvFileSrc
            // 
            this.dgvFileSrc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFileSrc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.dgvFileSrc.Location = new System.Drawing.Point(66, 166);
            this.dgvFileSrc.Name = "dgvFileSrc";
            this.dgvFileSrc.RowHeadersVisible = false;
            this.dgvFileSrc.Size = new System.Drawing.Size(230, 105);
            this.dgvFileSrc.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 185F;
            this.dataGridViewTextBoxColumn2.HeaderText = "File Format";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // lblFolderSrc
            // 
            this.lblFolderSrc.AutoSize = true;
            this.lblFolderSrc.Location = new System.Drawing.Point(67, 9);
            this.lblFolderSrc.Name = "lblFolderSrc";
            this.lblFolderSrc.Size = new System.Drawing.Size(42, 13);
            this.lblFolderSrc.TabIndex = 11;
            this.lblFolderSrc.Text = "Folder: ";
            // 
            // dgvFolderSrc
            // 
            this.dgvFolderSrc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFolderSrc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.dgvFolderSrc.Location = new System.Drawing.Point(66, 25);
            this.dgvFolderSrc.Name = "dgvFolderSrc";
            this.dgvFolderSrc.RowHeadersVisible = false;
            this.dgvFolderSrc.Size = new System.Drawing.Size(230, 105);
            this.dgvFolderSrc.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.FillWeight = 185F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Folder Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // sfdSave
            // 
            this.sfdSave.DefaultExt = "acc";
            this.sfdSave.Filter = "Astha Code Coverter Projects (*.ACC)|*.ACC";
            this.sfdSave.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdSave_FileOk);
            // 
            // ofdOpenfile
            // 
            this.ofdOpenfile.DefaultExt = "acc";
            this.ofdOpenfile.Filter = "Astha Code Coverter Projects (*.ACC)|*.ACC";
            this.ofdOpenfile.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdOpenfile_FileOk);
            // 
            // pbRun
            // 
            this.pbRun.Location = new System.Drawing.Point(7, 343);
            this.pbRun.Maximum = 200;
            this.pbRun.Name = "pbRun";
            this.pbRun.Size = new System.Drawing.Size(364, 16);
            this.pbRun.Step = 20;
            this.pbRun.TabIndex = 1;
            this.pbRun.Visible = false;
            // 
            // trRun
            // 
            this.trRun.Interval = 500;
            this.trRun.Tick += new System.EventHandler(this.trRun_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 363);
            this.Controls.Add(this.pbRun);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Astha Code Converter";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbProgram.ResumeLayout(false);
            this.gbProgram.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolder)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolderSrc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSrcLocation;
        private System.Windows.Forms.TextBox txtSrcLocation;
        private System.Windows.Forms.Label lblSrcLocation;
        private System.Windows.Forms.Button btnOpenSvn;
        private System.Windows.Forms.TextBox txtSvnLocation;
        private System.Windows.Forms.Label lblSvnLocation;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.RadioButton rdbSrc;
        private System.Windows.Forms.RadioButton rdbSVN;
        private System.Windows.Forms.FolderBrowserDialog fbdOpen;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.OpenFileDialog ofdOpenfile;
        private System.Windows.Forms.Button btnSaveSvn;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.DataGridView dgvFile;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.DataGridView dgvFolder;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSaveSrc;
        private System.Windows.Forms.Label lblFileSrc;
        private System.Windows.Forms.DataGridView dgvFileSrc;
        private System.Windows.Forms.Label lblFolderSrc;
        private System.Windows.Forms.DataGridView dgvFolderSrc;
        private System.Windows.Forms.Button btnRefreshSvn;
        private System.Windows.Forms.Button btnRefreshSrc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox gbProgram;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Timer trRun;
        public System.Windows.Forms.ProgressBar pbRun;
    }
}