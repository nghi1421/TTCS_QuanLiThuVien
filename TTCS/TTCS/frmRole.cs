using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCS
{
    public partial class frmRole : Form
    {
        Boolean sua = false;
        string oldName;
        SqlDataReader reader;
        public frmRole()
        {
            InitializeComponent();
            this.ContextMenuStrip = contextMenuStrip1;
            barButtonItem2.Enabled = false;
            panelControl1.Enabled = false;
            barButtonItem3.Enabled = false;
            barButtonItem7.Enabled = false;
            barButtonItem4.Enabled = false;
        }

        private void frmRole_Load(object sender, EventArgs e)
        {
            quanLiThuVienDataSet.EnforceConstraints = false;
            this.database_principalsTableAdapter.Connection.ConnectionString = Program.connstr_publisher;
            // TODO: This line of code loads data into the 'quanLiThuVienDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.quanLiThuVienDataSet.DataTable1);
            // TODO: This line of code loads data into the 'quanLiThuVienDataSet.database_principals' table. You can move, or remove it, as needed.
            this.database_principalsTableAdapter.Fill(this.quanLiThuVienDataSet.database_principals);

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resetCheck();
            barButtonItem2.Enabled = true;
            barButtonItem4.Enabled = false;
            barButtonItem1.Enabled = false;
            barButtonItem3.Enabled = false;
            barButtonItem5.Enabled = false;
            barButtonItem6.Enabled = false;
            barButtonItem7.Enabled = true;
            database_principalsGridControl.Enabled = false;
            panelControl1.Enabled = true;
            database_principalsBindingSource.AddNew();
            create_dateDateEdit.Text = DateTime.Now.ToString();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (nameTextEdit.Text.Equals(""))
            {
                MessageBox.Show("Ten role khong duoc trong!");
                return;
            }
            SqlDataReader reader;
            if (sua == true)
            {
                reader = Program.ExecSqlDataReader("select name from sys.sysusers where name = '" + nameTextEdit.Text.Trim() + "'");
                if(reader.HasRows && !oldName.Equals(nameTextEdit.Text))
                {
                    MessageBox.Show("Ten role ton tai hoac trung ten user!");
                   
                    return;
                }
                Program.ExecSqlNonQuery("alter role " + oldName + " with name = " + nameTextEdit.Text);
                if (!checkBoxdb_access.Checked) Program.ExecSqlNonQuery("Exec sp_droprolemember '" + checkBoxdb_access.Text + "','" + nameTextEdit.Text.Trim() + "'");
                if (!checkBoxdb_backup.Checked) Program.ExecSqlNonQuery("Exec sp_droprolemember '" + checkBoxdb_backup.Text + "','" + nameTextEdit.Text.Trim() + "'");
                if (!checkBoxdb_datareader.Checked) Program.ExecSqlNonQuery("Exec sp_droprolemember '" + checkBoxdb_datareader.Text + "','" + nameTextEdit.Text.Trim() + "'");
                if (!checkBoxdb_datawriter.Checked) Program.ExecSqlNonQuery("Exec sp_droprolemember '" + checkBoxdb_datawriter.Text + "','" + nameTextEdit.Text.Trim() + "'");
                if (!checkBoxdb_ddladmin.Checked) Program.ExecSqlNonQuery("Exec sp_droprolemember '" + checkBoxdb_ddladmin.Text + "','" + nameTextEdit.Text.Trim() + "'");
                if (!checkBoxdb_denyr.Checked) Program.ExecSqlNonQuery("Exec sp_droprolemember '" + checkBoxdb_denyr.Text + "','" + nameTextEdit.Text.Trim() + "'");
                if (!checkBoxdb_denyw.Checked) Program.ExecSqlNonQuery("Exec sp_droprolemember '" + checkBoxdb_denyw.Text + "','" + nameTextEdit.Text.Trim() + "'");
                if (!checkBoxdb_owner.Checked) Program.ExecSqlNonQuery("Exec sp_droprolemember '" + checkBoxdb_owner.Text + "','" + nameTextEdit.Text.Trim() + "'");
                if (!checkBoxdb_sercurity.Checked) Program.ExecSqlNonQuery("Exec sp_droprolemember '" + checkBoxdb_sercurity.Text + "','" + nameTextEdit.Text.Trim() + "'");

                if (checkBoxdb_access.Checked) Program.ExecSqlNonQuery("Exec sp_addrolemember '" + checkBoxdb_access.Text + "','" + nameTextEdit.Text.Trim() + "'");
                if (checkBoxdb_backup.Checked) Program.ExecSqlNonQuery("Exec sp_addrolemember '" + checkBoxdb_backup.Text + "','" + nameTextEdit.Text.Trim() + "'");
                if (checkBoxdb_datareader.Checked) Program.ExecSqlNonQuery("Exec sp_addrolemember '" + checkBoxdb_datareader.Text + "','" + nameTextEdit.Text.Trim() + "'");
                if (checkBoxdb_datawriter.Checked) Program.ExecSqlNonQuery("Exec sp_addrolemember '" + checkBoxdb_datawriter.Text + "','" + nameTextEdit.Text.Trim() + "'");
                if (checkBoxdb_ddladmin.Checked) Program.ExecSqlNonQuery("Exec sp_addrolemember '" + checkBoxdb_ddladmin.Text + "','" + nameTextEdit.Text.Trim() + "'");
                if (checkBoxdb_denyr.Checked) Program.ExecSqlNonQuery("Exec sp_addrolemember '" + checkBoxdb_denyr.Text + "','" + nameTextEdit.Text.Trim() + "'");
                if (checkBoxdb_denyw.Checked) Program.ExecSqlNonQuery("Exec sp_addrolemember '" + checkBoxdb_denyw.Text + "','" + nameTextEdit.Text.Trim() + "'");
                if (checkBoxdb_owner.Checked) Program.ExecSqlNonQuery("Exec sp_addrolemember '" + checkBoxdb_owner.Text + "','" + nameTextEdit.Text.Trim() + "'");
                if (checkBoxdb_sercurity.Checked) Program.ExecSqlNonQuery("Exec sp_addrolemember '" + checkBoxdb_sercurity.Text + "','" + nameTextEdit.Text.Trim() + "'");
                database_principalsGridControl.Enabled = true;
                this.database_principalsTableAdapter.Fill(this.quanLiThuVienDataSet.database_principals);
                this.dataTable1TableAdapter.Fill(this.quanLiThuVienDataSet.DataTable1);
                barButtonItem3.Enabled = false;
                barButtonItem1.Enabled = true;
                barButtonItem2.Enabled = false;
                barButtonItem4.Enabled = false;
                barButtonItem5.Enabled = true;
                barButtonItem6.Enabled = true;
                barButtonItem7.Enabled = false;
                database_principalsGridControl.Enabled = true;
                sua = false;
                panelControl1.Enabled = false;
                reader.Close();
                return;
            }
            
            reader = Program.ExecSqlDataReader("select name from sys.sysusers where name = '" + nameTextEdit.Text + "'");
            if (reader.HasRows)
            {
                MessageBox.Show("Ten role ton tai hoac trung ten user!");
               
                return;
            }
            database_principalsBindingSource.EndEdit();
            Program.ExecSqlNonQuery("create role " + nameTextEdit.Text + "");
            if(checkBoxdb_access.Checked) Program.ExecSqlNonQuery("Exec sp_addrolemember '" + checkBoxdb_access.Text + "','" +nameTextEdit.Text +"'" );
            if (checkBoxdb_backup.Checked) Program.ExecSqlNonQuery("Exec sp_addrolemember '" + checkBoxdb_backup.Text + "','" + nameTextEdit.Text + "'");
            if (checkBoxdb_datareader.Checked) Program.ExecSqlNonQuery("Exec sp_addrolemember '" + checkBoxdb_datareader.Text + "','" + nameTextEdit.Text + "'");
            if (checkBoxdb_datawriter.Checked) Program.ExecSqlNonQuery("Exec sp_addrolemember '" + checkBoxdb_datawriter.Text + "','" + nameTextEdit.Text + "'");
            if (checkBoxdb_ddladmin.Checked) Program.ExecSqlNonQuery("Exec sp_addrolemember '" + checkBoxdb_ddladmin.Text + "','" + nameTextEdit.Text + "'");
            if (checkBoxdb_denyr.Checked) Program.ExecSqlNonQuery("Exec sp_addrolemember '" + checkBoxdb_denyr.Text + "','" + nameTextEdit.Text + "'");
            if (checkBoxdb_denyw.Checked) Program.ExecSqlNonQuery("Exec sp_addrolemember '" + checkBoxdb_denyw.Text + "','" + nameTextEdit.Text + "'");
            if (checkBoxdb_owner.Checked) Program.ExecSqlNonQuery("Exec sp_addrolemember '" + checkBoxdb_owner.Text + "','" + nameTextEdit.Text + "'");
            if (checkBoxdb_sercurity.Checked) Program.ExecSqlNonQuery("Exec sp_addrolemember '" + checkBoxdb_sercurity.Text + "','" + nameTextEdit.Text + "'");
            barButtonItem3.Enabled = false;
            barButtonItem1.Enabled = true;
            barButtonItem2.Enabled = false;
            barButtonItem4.Enabled = false;
            barButtonItem5.Enabled = true;
            barButtonItem6.Enabled = true;
            barButtonItem7.Enabled = false;
            database_principalsGridControl.Enabled = true;
            panelControl1.Enabled = false;
            this.database_principalsTableAdapter.Fill(this.quanLiThuVienDataSet.database_principals);
            this.dataTable1TableAdapter.Fill(this.quanLiThuVienDataSet.DataTable1);
            database_principalsBindingSource.ResetCurrentItem();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Xóa", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            try
            {
                if(Program.ExecSqlNonQuery("drop role " + nameTextEdit.Text)==0)
                {
                    this.database_principalsBindingSource.RemoveCurrent();
                    barButtonItem3.Enabled = false;
                    barButtonItem4.Enabled = false;
                }
                    

                else MessageBox.Show("Có người dùng thuộc role này, không thể xóa");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Enabled = true;
            barButtonItem3.Enabled = false;
            barButtonItem1.Enabled = false;
            barButtonItem2.Enabled = true;
            barButtonItem4.Enabled = false;
            barButtonItem7.Enabled = true;
            barButtonItem5.Enabled = false;
            barButtonItem6.Enabled = false;
            database_principalsGridControl.Enabled = false;
            sua = true;
        }

        private void database_principalsGridControl_Click(object sender, EventArgs e)
        {

        }

        private void resetCheck()
        {
            checkBoxdb_access.Checked = false;
        
                
                        checkBoxdb_backup.Checked = false;
                    
                   
                        checkBoxdb_datareader.Checked = false;
                    
                   
                        checkBoxdb_datawriter.Checked = false;
                  
                        checkBoxdb_ddladmin.Checked = false;
                  
                        checkBoxdb_denyw.Checked = false;
                   
                        checkBoxdb_datareader.Checked = false;
                   
                        checkBoxdb_owner.Checked = false;
                    
                    
                        checkBoxdb_sercurity.Checked = false;
                    
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            resetCheck();
            barButtonItem3.Enabled = true;
            barButtonItem4.Enabled = true;
            string sd = (sender as GridView).GetFocusedRowCellValue("name").ToString();
            oldName = (sender as GridView).GetFocusedRowCellValue("name").ToString();
            SqlDataReader r;
            
            r = Program.ExecSqlDataReader("exec sp_getpermissons '" + sd + "'");
            List<string> index = new List<string>();
            if (r == null) return;
            if (r.HasRows)
            {
                while (r.Read())
                {
                    string temp = r.GetString(0);
                    if (temp.Equals("db_accessadmin"))
                    {
                        checkBoxdb_access.Checked = true;
                    }
                    if (temp.Equals("db_backupoperator"))
                    {
                        checkBoxdb_backup.Checked = true;
                    }
                    if (temp.Equals("db_datareader"))
                    {
                        checkBoxdb_datareader.Checked = true;
                    }
                    if (temp.Equals("db_datawriter"))
                    {
                        checkBoxdb_datawriter.Checked = true;
                    }
                    if (temp.Equals("db_ddladmin"))
                    {
                        checkBoxdb_ddladmin.Checked = true;
                    }
                    if (temp.Equals("db_denydatawriter"))
                    {
                        checkBoxdb_denyw.Checked = true;
                    }
                    if (temp.Equals("db_denydatareader"))
                    {
                        checkBoxdb_datareader.Checked = true;
                    }
                    if (temp.Equals("db_owner"))
                    {
                        checkBoxdb_owner.Checked = true;
                    }
                    if (temp.Equals("db_securityadmin"))
                    {
                        checkBoxdb_sercurity.Checked = true;
                    }

                }

            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.database_principalsTableAdapter.Fill(this.quanLiThuVienDataSet.database_principals);
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.frmRole_Load(this, null);
            resetCheck();
            barButtonItem2.Enabled = false;
            panelControl1.Enabled = false;
            barButtonItem3.Enabled = false;
            barButtonItem1.Enabled = true;
            barButtonItem4.Enabled = false;
            barButtonItem5.Enabled = true;
            barButtonItem6.Enabled = true;
            barButtonItem7.Enabled = false;
            database_principalsGridControl.Enabled = true;
        }
    }
}
