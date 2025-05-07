namespace QuanLyLoTrinhXeBuyt.Forms
{
    partial class frmSaoLuuKhoiPhuc
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
            btnBrowseBackup = new Button();
            txtBackupPath = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnBackup = new Button();
            groupBox2 = new GroupBox();
            label2 = new Label();
            btnRestore = new Button();
            btnBrowseRestore = new Button();
            txtRestorePath = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnBrowseBackup
            // 
            btnBrowseBackup.Location = new Point(341, 38);
            btnBrowseBackup.Name = "btnBrowseBackup";
            btnBrowseBackup.Size = new Size(141, 29);
            btnBrowseBackup.TabIndex = 0;
            btnBrowseBackup.Text = "Browse...";
            btnBrowseBackup.UseVisualStyleBackColor = true;
            btnBrowseBackup.Click += btnBrowse_Click;
            // 
            // txtBackupPath
            // 
            txtBackupPath.Location = new Point(94, 39);
            txtBackupPath.Name = "txtBackupPath";
            txtBackupPath.ReadOnly = true;
            txtBackupPath.Size = new Size(198, 27);
            txtBackupPath.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnBackup);
            groupBox1.Controls.Add(btnBrowseBackup);
            groupBox1.Controls.Add(txtBackupPath);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(696, 125);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Backup Database";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 47);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 3;
            label1.Text = "Location";
            // 
            // btnBackup
            // 
            btnBackup.Location = new Point(341, 73);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(141, 29);
            btnBackup.TabIndex = 0;
            btnBackup.Text = "Backup";
            btnBackup.UseVisualStyleBackColor = true;
            btnBackup.Click += btnBackup_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnRestore);
            groupBox2.Controls.Add(btnBrowseRestore);
            groupBox2.Controls.Add(txtRestorePath);
            groupBox2.Location = new Point(12, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(696, 125);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Restore Database";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 47);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Location";
            // 
            // btnRestore
            // 
            btnRestore.Location = new Point(341, 73);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(141, 29);
            btnRestore.TabIndex = 0;
            btnRestore.Text = "Restore";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += btnRestore_Click;
            // 
            // btnBrowseRestore
            // 
            btnBrowseRestore.Location = new Point(341, 38);
            btnBrowseRestore.Name = "btnBrowseRestore";
            btnBrowseRestore.Size = new Size(141, 29);
            btnBrowseRestore.TabIndex = 0;
            btnBrowseRestore.Text = "Browse...";
            btnBrowseRestore.UseVisualStyleBackColor = true;
            btnBrowseRestore.Click += btnBrowseRestore_Click;
            // 
            // txtRestorePath
            // 
            txtRestorePath.Location = new Point(94, 39);
            txtRestorePath.Name = "txtRestorePath";
            txtRestorePath.ReadOnly = true;
            txtRestorePath.Size = new Size(198, 27);
            txtRestorePath.TabIndex = 1;
            // 
            // frmSaoLuuKhoiPhuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmSaoLuuKhoiPhuc";
            Text = "frmSaoLuuKhoiPhuc";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBrowseBackup;
        private TextBox txtBackupPath;
        private GroupBox groupBox1;
        private Label label1;
        private Button btnBackup;
        private GroupBox groupBox2;
        private Label label2;
        private Button btnRestore;
        private Button btnBrowseRestore;
        private TextBox txtRestorePath;
    }
}