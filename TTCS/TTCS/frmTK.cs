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
    public partial class frmTK : Form
    {
        Boolean sua = false;
        string oldName;
        SqlDataReader reader;
        public frmTK()
        {
            InitializeComponent();
            barButtonItem2.Enabled = false;
            panelControl1.Enabled = false;
            barButtonItem3.Enabled = false;
            barButtonItem7.Enabled = false;
            barButtonItem4.Enabled = false;
        }

        private void frmTK_Load(object sender, EventArgs e)
        {
            quanLiThuVienDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'quanLiThuVienDataSet.syslogins' table. You can move, or remove it, as needed.
            this.sysloginsTableAdapter.Connection.ConnectionString = Program.connstr_publisher;
            this.sysloginsTableAdapter.Fill(this.quanLiThuVienDataSet.syslogins);
           
            DataTable dt = Program.ExecSqlDataTable("select name from sys.database_principals where type='R' and principal_id > 0 and principal_id <16384");
            foreach (DataRow dtr in dt.Rows)
            {
                string NHOM = dtr.Field<string>(0);
                Console.WriteLine("10");
                nHOMCheckedListBox.Items.Add(NHOM);
            }

        }

        private void resetCheck()
        {
            for(int i=0;i<nHOMCheckedListBox.Items.Count;i++)
            {
                nHOMCheckedListBox.SetItemChecked(i, false);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sysloginsBindingSource.AddNew();
            sysloginsGridControl.Enabled = false;
            barButtonItem1.Enabled = false;
            barButtonItem2.Enabled = true;
            barButtonItem4.Enabled = false;
            barButtonItem1.Enabled = false;
            barButtonItem3.Enabled = false;
            barButtonItem5.Enabled = false;
            barButtonItem6.Enabled = false;
            barButtonItem7.Enabled = true;
            panelControl1.Enabled = true;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (nameTextEdit.Text.Equals(""))
            {
                MessageBox.Show("Ten role khong duoc trong!");
                
                return;
            }
            
           

            if (sua == true)
            {
                reader = Program.ExecSqlDataReader("select name from sys.sysusers where name = '" + nameTextEdit.Text + "'");
                if (reader == null) { }
                MessageBox.Show(nameTextEdit.Text);
                if (reader.HasRows && !oldName.Equals(nameTextEdit.Text))
                {
                    MessageBox.Show("Ten tk ton tai!");

                    return;
                }
                Program.ExecSqlNonQuery("alter login " + oldName + " with name = " + nameTextEdit.Text);
                Program.ExecSqlNonQuery("alter user " + oldName + " with name = " + nameTextEdit.Text);
                if(!txtMK.Equals("")) Program.ExecSqlNonQuery("alter login " + nameTextEdit.Text + " with password = '" +txtMK.Text+"'");
                for (int i = 0;i < nHOMCheckedListBox.Items.Count;i++)
                {
                        if(nHOMCheckedListBox.GetItemChecked(i)==false)
                        Program.ExecSqlNonQuery("Exec sp_droprolemember '" + nHOMCheckedListBox.Items[i].ToString() + "','" + nameTextEdit.Text + "'");

                }

                int commited1 = 0;
                foreach (int indexChecked in nHOMCheckedListBox.CheckedIndices)
                {
                 
                        Program.ExecSqlNonQuery("Exec sp_addrolemember '" + nHOMCheckedListBox.Items[indexChecked].ToString() + "','" + nameTextEdit.Text + "'");
                        commited1++;
                   


                }
                if (commited1 == nHOMCheckedListBox.CheckedIndices.Count) MessageBox.Show("Thành công!");
                else MessageBox.Show("Thao tác thất bại!");
                sysloginsGridControl.Enabled = true;
                barButtonItem3.Enabled = false;
                barButtonItem1.Enabled = true;
                barButtonItem2.Enabled = false;
                barButtonItem4.Enabled = false;
                barButtonItem5.Enabled = true;
                barButtonItem6.Enabled = true;
                barButtonItem7.Enabled = false;
                this.sysloginsTableAdapter.Fill(this.quanLiThuVienDataSet.syslogins);
                sua = false;
                panelControl1.Enabled = false;
                txtMK.Text = "";
                resetCheck();
                return;
            }
            reader = Program.ExecSqlDataReader("select name from sys.sysusers where name = '" + nameTextEdit.Text + "'");
            if (reader == null) { }
            if (reader.HasRows)
            {
                MessageBox.Show("Ten tk ton tai!");

                return;
            }
            int commited = 0;
            if (txtMK.Text.Equals(""))
            {
                MessageBox.Show("MK khong duoc trong!");
       
                return;
            }
            
            if (nHOMCheckedListBox.CheckedIndices.Count==0)
            {
                Program.ExecSqlNonQuery("EXEC SP_ADDLOGIN '" + nameTextEdit.Text + "','" + txtMK.Text + "'," + "'QuanLiThuVien'" +



  "EXEC SP_GRANTDBACCESS '" + nameTextEdit.Text + "','" + nameTextEdit.Text + "'");
                MessageBox.Show("Thành công!");
                sysloginsGridControl.Enabled = true;
                barButtonItem3.Enabled = false;
                barButtonItem1.Enabled = true;
                barButtonItem2.Enabled = false;
                barButtonItem4.Enabled = false;
                barButtonItem5.Enabled = true;
                barButtonItem6.Enabled = true;
                barButtonItem7.Enabled = false;
                panelControl1.Enabled = false;
                this.sysloginsTableAdapter.Fill(this.quanLiThuVienDataSet.syslogins);
                txtMK.Text = "";
                resetCheck();
                return;

            }
           foreach (int indexChecked in nHOMCheckedListBox.CheckedIndices)
            {
                if (commited == 0)
                {
                    String strLenh = "Exec sp_taologin '" + nameTextEdit.Text + "','" + txtMK.Text + "','" + nameTextEdit.Text + "','" + nHOMCheckedListBox.Items[indexChecked].ToString() + "'";
                    if (Program.ExecSqlNonQuery(strLenh) == 0)
                        commited++;
                }
                else
                {
                    Program.ExecSqlNonQuery("Exec sp_addrolemember '" + nHOMCheckedListBox.Items[indexChecked].ToString() + "','" + nameTextEdit.Text + "'");
                    commited++;
                }


            }
           if(commited == nHOMCheckedListBox.CheckedIndices.Count) MessageBox.Show("Thành công!");
            else MessageBox.Show("Thao tác thất bại!");
            sysloginsGridControl.Enabled = true;
            barButtonItem3.Enabled = false;
            barButtonItem1.Enabled = true;
            barButtonItem2.Enabled = false;
            barButtonItem4.Enabled = false;
            barButtonItem5.Enabled = true;
            barButtonItem6.Enabled = true;
            barButtonItem7.Enabled = false;
            panelControl1.Enabled = false;
            this.sysloginsTableAdapter.Fill(this.quanLiThuVienDataSet.syslogins);
            txtMK.Text = "";
            resetCheck();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Xóa", MessageBoxButtons.OKCancel) == DialogResult.No)
                return;
            String strLenh = "Exec xoa_login '" + nameTextEdit.Text + "','" + nameTextEdit.Text +"'";
            
            if (Program.ExecSqlNonQuery(strLenh) == 0)
            {
                MessageBox.Show("Thành công!");
                barButtonItem3.Enabled = false;
                barButtonItem4.Enabled = false;
            }
               
            else MessageBox.Show("Thao tác thất bại!");
            this.sysloginsTableAdapter.Fill(this.quanLiThuVienDataSet.syslogins);
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            
        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {

        }

        private void gridView1_RowCellClick_1(object sender, RowCellClickEventArgs e)
        {
            resetCheck();
            barButtonItem3.Enabled = true;
            barButtonItem4.Enabled = true;
            string sd = (sender as GridView).GetFocusedRowCellValue("name").ToString();
            oldName = (sender as GridView).GetFocusedRowCellValue("name").ToString();
            SqlDataReader r;
            r=Program.ExecSqlDataReader("exec sp_getrolefromname '" + sd + "'");
            List<int> index = new List<int>();
            if (r == null) return;
            if (r.HasRows)
            {
                while(r.Read())
                {
                    int i = 0;
                    foreach (string item in nHOMCheckedListBox.Items)
                    {
                        if (r.GetString(1).Equals(item))
                        {
                            index.Add(i);
                        }
                        i++;
                    }
                }
                
            }
            for(int i=0;i<index.Count;i++)
            {
                nHOMCheckedListBox.SetItemChecked(index[i], true);
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Enabled = true;
            barButtonItem3.Enabled = false;
            barButtonItem1.Enabled = false;
            barButtonItem2.Enabled = true;
            barButtonItem4.Enabled = false;
            barButtonItem7.Enabled = true;
            barButtonItem5.Enabled = false;
            barButtonItem6.Enabled = false;
            sysloginsGridControl.Enabled = false;
            sua = true;
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.frmTK_Load(this, null);
            resetCheck();
            barButtonItem2.Enabled = false;
            panelControl1.Enabled = false;
            barButtonItem3.Enabled = false;
            barButtonItem1.Enabled = true;
            barButtonItem4.Enabled = false;
            barButtonItem5.Enabled = true;
            barButtonItem6.Enabled = true;
            barButtonItem7.Enabled = false;
            sysloginsGridControl.Enabled = true;
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
    }
}
