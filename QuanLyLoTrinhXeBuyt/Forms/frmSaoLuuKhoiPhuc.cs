using QuanLyLoTrinhXeBuyt.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Microsoft.EntityFrameworkCore;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using Microsoft.Data.SqlClient;
using DocumentFormat.OpenXml.Wordprocessing;

namespace QuanLyLoTrinhXeBuyt.Forms
{
    public partial class frmSaoLuuKhoiPhuc : Form
    {
        QLLTXBContext context = new QLLTXBContext();
        public frmSaoLuuKhoiPhuc()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtBackupPath.Text = folderBrowserDialog.SelectedPath;
                btnBackup.Enabled = true;
            }
        }
        private void btnBackup_Click(object sender, EventArgs e)
        {
            string database = context.Database.GetDbConnection().Database;

            string backupPath = txtBackupPath.Text;
            if (backupPath == "")
            {
                MessageBox.Show("Please select a backup path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK = '" + txtBackupPath.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                using (SqlConnection conn = new SqlConnection(context.Database.GetDbConnection().ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(cmd, conn))
                    {
                        conn.Open();
                        command.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                MessageBox.Show("Backup completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBackup.Enabled = false;
            }
        }

        private void btnBrowseRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "SQL SERVER database backup files| *.bak";
            openFileDialog.Title = "Database restore";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtRestorePath.Text = openFileDialog.FileName;
                btnRestore.Enabled = true;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string database = context.Database.GetDbConnection().Database;
            using (SqlConnection conn = new SqlConnection(context.Database.GetDbConnection().ConnectionString))
            {
                try
                {
                    string str = string.Format($"ALTER DATABASE [{database}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    using (SqlCommand command = new SqlCommand(str, conn))
                    {
                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                    string str1 = string.Format($"USE MASTER RESTORE DATABASE [{database}] FROM DISK = '{txtRestorePath.Text}' WITH REPLACE;");
                    using (SqlCommand command = new SqlCommand(str1, conn))
                    {
                        command.ExecuteNonQuery();
                    }
                    string str2 = string.Format($"ALTER DATABASE [{database}] SET MULTI_USER");
                    using (SqlCommand command = new SqlCommand(str2, conn))
                    {
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Restore completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
        }
    }
}
