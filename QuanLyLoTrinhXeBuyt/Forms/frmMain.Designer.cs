namespace QuanLyLoTrinhXeBuyt.Forms
{
    partial class frmMain
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
            đăngNhậpToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhâiruToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            SuspendLayout();
            // 
            // đăngNhậpToolStripMenuItem
            // 
            đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            đăngNhậpToolStripMenuItem.Size = new Size(181, 26);
            đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(181, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // đổiMậtKhâiruToolStripMenuItem
            // 
            đổiMậtKhâiruToolStripMenuItem.Name = "đổiMậtKhâiruToolStripMenuItem";
            đổiMậtKhâiruToolStripMenuItem.Size = new Size(181, 26);
            đổiMậtKhâiruToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(178, 6);
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(181, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.AutoSize = false;
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngNhậpToolStripMenuItem, đăngXuấtToolStripMenuItem, đổiMậtKhâiruToolStripMenuItem, toolStripSeparator1, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(145, 60);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 480);
            Name = "frmMain";
            Text = "Main";
            Load += frmMain_Load;
            ResumeLayout(false);
        }

        #endregion
        private ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhâiruToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
    }
}