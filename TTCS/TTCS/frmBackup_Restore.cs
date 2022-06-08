using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using TTCS;

namespace ttcs
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        String cautruyvan="";
        String location= "D:\\bktest";
        int freq_type;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = new string[2] { "Full", "Differential" };
            cbBKType.DataSource = ports.Select(p => new KeyValuePair<string, string>(p, p)).ToList();
            cbBKType.DisplayMember = "Key";
            cbBKType.ValueMember = "Value";
            cbBKType.SelectedValue = ports[0];

            ports = new string[3] { "Daily", "Weekly","Monthly" };
            cbFreOc.DataSource = ports.Select(p => new KeyValuePair<string, string>(p, p)).ToList();
            cbFreOc.DisplayMember = "Key";
            cbFreOc.ValueMember = "Value";
            cbFreOc.SelectedValue = ports[0];

            time1.Format = DateTimePickerFormat.Time;
            time1.ShowUpDown = true;
            time2.Format = DateTimePickerFormat.Time;
            time2.ShowUpDown = true;
            time3.Format = DateTimePickerFormat.Time;
            time3.ShowUpDown = true;

            ports = new string[3] { "hours", "miniue", "second" };
            comboBox2.DataSource = ports.Select(p => new KeyValuePair<string, string>(p, p)).ToList();
            comboBox2.DisplayMember = "Key";
            comboBox2.ValueMember = "Value";
            comboBox2.SelectedValue = ports[0];

            ports = new string[5] { "first", "second", "third","four","last"};
            comboBox1.DataSource = ports.Select(p => new KeyValuePair<string, string>(p, p)).ToList();
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
            comboBox1.SelectedValue = ports[0];

            ports = new string[10] { "Monday", "Tuesday", "Wesnesday", "Thursday", "Friday","Saturday","Sunday","day","weekday","weekend day" };
            comboBox3.DataSource = ports.Select(p => new KeyValuePair<string, string>(p, p)).ToList();
            comboBox3.DisplayMember = "Key";
            comboBox3.ValueMember = "Value";
            comboBox3.SelectedValue = ports[0];

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            label20.Visible = false;
            txtFile2.Visible = false;
            button6.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                bkLocation.Text = dlg.SelectedPath;
            }
        }

        private void bkType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string location = bkLocation.Text;


            string databse = Program.database.ToString();
            try
            {
                if (bkLocation.Text == string.Empty)
                {
                    MessageBox.Show("Please Browsing Database Backup Location....!");
                }
                else
                {
                    if(Program.KetNoi() ==0) MessageBox.Show("Error connecting database..!");
                    string cmd;
                    if (cbBKType.SelectedIndex == 0) cmd = "BACKUP DATABASE [" + Program.database + "] TO  DISK" +
                         " = N'" + bkLocation.Text + "\\QuanLiThuVien_FULL_" + DateTime.Now.ToString("yyyyMMddHHmm") + ".BAK'" +
                        " WITH NOFORMAT, NOINIT, NAME = N'QuanLiThuVien-Full Database Backup', " +
                        " SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                    else  cmd = "DECLARE	@return_value int "+
                                    "EXEC @return_value = [dbo].[sp_generateDifferentialBackups] "+
                                           "@strBackupPath = N'"+bkLocation.Text+"\\' "+
                                    "SELECT  'Return Value' = @return_value ";
                    Console.WriteLine(cmd);
                    using (SqlCommand command = new SqlCommand(cmd, Program.conn))
                    {
                        if (Program.conn.State != ConnectionState.Open)
                        {
                            Program.conn.Open();

                        }
                        if (cbBKType.SelectedIndex == 0)
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Database Backup has been Successefully Created..!");
                        }
                        else
                        {
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader != null)
                            {
                                reader.Read();
                                int result = int.Parse(reader.GetValue(0).ToString());
                                if (result == 1) MessageBox.Show("Database Backup has been Successefully Created..!");
                                else
                                {
                                    MessageBox.Show("File last full backup is not found !");
                                }
                                reader.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n\n" + ex);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtFile1.Text = dlg.FileName;
            }
        }
        string filedname = null;
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Error connecting database..!");
                    return;
                }
                if (Program.conn.State != ConnectionState.Open)
                {
                    Program.conn.Open();
                }
                try
                {
                    if (txtFile1.Text == string.Empty)
                    {
                        MessageBox.Show("Choose File Backup full !");
                        return;
                    }
                    if (radioButton9.Checked && txtFile2.Text == string.Empty)
                    {
                        MessageBox.Show("Choose File Backup diff !");
                        return;
                    }
                    if (radioButton10.Checked)
                    {
                        string sqlStmt2 = string.Format("ALTER DATABASE [" + Program.database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                        SqlCommand bu2 = new SqlCommand(sqlStmt2, Program.conn);
                        bu2.ExecuteNonQuery();

                        string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + Program.database + "] FROM DISK='" + txtFile1.Text + "'WITH REPLACE;";
                        SqlCommand bu3 = new SqlCommand(sqlStmt3, Program.conn);
                        bu3.ExecuteNonQuery();

                        string sqlStmt4 = string.Format("ALTER DATABASE [" + Program.database + "] SET MULTI_USER");
                        SqlCommand bu4 = new SqlCommand(sqlStmt4, Program.conn);
                        bu4.ExecuteNonQuery();
                    }else 
                    {
                        string sqlStmt2;
                        sqlStmt2 = "USE MASTER " +
                        "ALTER DATABASE[" + Program.database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE" +
                        " RESTORE DATABASE[" + Program.database + "] FROM " +
                        " DISK = '" + txtFile1.Text + "'" +
                        " WITH REPLACE, FILE = 1, NORECOVERY, NOUNLOAD, STATS = 5" +
                        " RESTORE DATABASE[" + Program.database + "] FROM" +
                        " DISK = '" + txtFile2.Text + "'" +
                        " WITH FILE = 1, NOUNLOAD, STATS = 5" +
                        " ALTER DATABASE[" + Program.database + "] SET MULTI_USER";
                       
                        Console.WriteLine(sqlStmt2);
                        SqlCommand bu2 = new SqlCommand(sqlStmt2, Program.conn);
                        //bu2.ExecuteNonQuery();
                    }
                    

                    MessageBox.Show("Database Restoration Done Successefully");
                    txtFile1.Text = "";
                    txtFile2.Text = "";
                    Program.conn.Close();
                   
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex);
                    MessageBox.Show(ex.ToString());
                    Program.conn.Close();
                }

            }
            catch (Exception ex) {
                Console.WriteLine( ex.StackTrace);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFreOc.SelectedIndex == 1)
            {
                label9.Visible = true;
                spinEdit1.Visible = true;
                label10.Visible = true;
                mc1.Visible = true;
                mc2.Visible = true;
                mc5.Visible = true;
                mc4.Visible = true;
                mc5.Visible = true;
                mc3.Visible = true;
                mc6.Visible = true;
                mc7.Visible = true;
                label10.Text = "weeks";
                panel3.Visible = false;
            }
            else if(cbFreOc.SelectedIndex == 0)
            {
                label9.Visible = true;
                spinEdit1.Visible = true;
                label10.Visible = true;
                label10.Text = "days";
                mc1.Visible = false;
                mc2.Visible = false;
                mc5.Visible = false;
                mc3.Visible = false;
                mc4.Visible = false;
                mc5.Visible = false;
                mc6.Visible = false;
                mc7.Visible = false;
                panel3.Visible = false;
            }
            else
            {
                mc1.Visible = false;
                mc2.Visible = false;
                mc5.Visible = false;
                mc3.Visible = false;
                mc4.Visible = false;
                mc5.Visible = false;
                mc6.Visible = false;
                mc7.Visible = false;
                label9.Visible = false;
                spinEdit1.Visible = false;
                label10.Visible = false;
                panel3.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                spinEdit3.Enabled = true;
                comboBox2.Enabled = true;
                time2.Enabled = true;
                time3.Enabled = true;
                time1.Enabled = false;

            }
            else
            {
                spinEdit3.Enabled = false;
                comboBox2.Enabled = false;
                time2.Enabled = false;
                time3.Enabled = false;
                time1.Enabled = true;

            }
        }

        private void time1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Type supplan name..!");
                return;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Error connecting database..!");
                return;
            }
            if (radioButton2.Checked)
            {
                if ((int)spinEdit3.Value <= 0)
                {
                    MessageBox.Show("@freq_subday_interval is invalid");
                    return;
                }
            }
            String startday = dateTimePicker1.Value.ToString("yyyyMMdd");
            string starttime;
            string endtime = time3.Value.ToString("HHmmss");
            string endday;
            string sql;
            int subdaytype = 0; ;
            int subdayinterval;
            int freq_type ;
            int freq_recurrence_factor = 0;
            int freq_interval = (int) spinEdit1.Value;
            int f_relative_interval = 0;
            if (cbFreOc.SelectedIndex == 0)
            {
                freq_type = 4;
            }
            else if (cbFreOc.SelectedIndex == 1)
            {
                if(!mc1.Checked && !mc2.Checked && !mc3.Checked && !mc4.Checked &&
                    !mc6.Checked && !mc5.Checked && !mc7.Checked)
                {
                    MessageBox.Show("freq_interval is invalid ");
                    return;
                }
                freq_type = 8;
                freq_recurrence_factor = freq_interval;
                freq_interval = 0;
                if (mc1.Checked) freq_interval += 2;
                if (mc2.Checked) freq_interval += 4;
                if (mc3.Checked) freq_interval += 8;
                if (mc4.Checked) freq_interval += 16;
                if (mc5.Checked) freq_interval += 32;
                if (mc6.Checked) freq_interval += 64;
                if (mc7.Checked) freq_interval += 1;

            }
            else
            {
                
                if (radioButton6.Checked)//monthly
                {
                    freq_type = 16;
                    freq_interval = (int)spinEdit2.Value;
                    freq_recurrence_factor = (int)spinEdit4.Value;
                }
                else//monthly relative
                {
                    freq_type = 32;
                    if (comboBox3.SelectedIndex == 0) freq_interval = 2;
                    else if(comboBox3.SelectedIndex == 1) freq_interval = 3;
                    else if (comboBox3.SelectedIndex == 2) freq_interval = 4;
                    else if (comboBox3.SelectedIndex == 3) freq_interval = 5;
                    else if (comboBox3.SelectedIndex == 4) freq_interval = 6;
                    else if (comboBox3.SelectedIndex == 5) freq_interval = 7;
                    else if (comboBox3.SelectedIndex == 6) freq_interval = 1;
                    else if (comboBox3.SelectedIndex == 7) freq_interval = 8;
                    else if (comboBox3.SelectedIndex == 8) freq_interval = 9;
                    else if (comboBox3.SelectedIndex == 9) freq_interval = 10;
                    freq_recurrence_factor = (int) spinEdit5.Value;
                    if (comboBox1.SelectedIndex == 0) f_relative_interval = 1;
                    else if (comboBox1.SelectedIndex == 1) f_relative_interval = 2;
                    else if (comboBox1.SelectedIndex == 2) f_relative_interval = 4;
                    else if (comboBox1.SelectedIndex == 3) f_relative_interval = 8;
                    else if (comboBox1.SelectedIndex == 4) f_relative_interval = 16;

                }
            }

            if (radioButton4.Checked)
            {
                endday = "99991231";
            } else endday = dateTimePicker2.Value.ToString("yyyyMMdd");

            if (radioButton2.Checked)
            {
                if (comboBox2.SelectedIndex == 0)
                    subdaytype = 8;
                if (comboBox2.SelectedIndex == 1)
                    subdaytype = 4;
                if (comboBox2.SelectedIndex == 2)
                    subdaytype = 2;
                subdayinterval = (int)spinEdit3.Value;
                starttime = time2.Value.ToString("HHmmss");
            }
            else
            {
                starttime = time1.Value.ToString("HHmmss");
                endtime = "235959";
                subdayinterval = 0;
                subdaytype = 1;
            }
            if(radioButton8.Checked)
            sql = "use quanlithuvien exec back_up_full_2 " + textBox1.Text + "," + freq_type.ToString() + "," +freq_interval + "," +
                subdaytype.ToString() + "," + subdayinterval + "," + freq_recurrence_factor + "," + f_relative_interval 
                + "," + startday + "," + endday + "," + starttime + "," + endtime;
            else sql = "use quanlithuvien exec back_up_diff " + textBox1.Text + "," + freq_type.ToString() + "," + freq_interval + "," +
                subdaytype.ToString() + "," + subdayinterval + "," + freq_recurrence_factor + "," + f_relative_interval
                + "," + startday + "," + endday + "," + starttime + "," + endtime;
            Console.WriteLine(sql);
            if (Program.ExecSqlNonQuery(sql) == 1)
            {
                MessageBox.Show("Success");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                spinEdit2.Enabled = true;
                spinEdit4.Enabled = true;
                comboBox1.Enabled = false;
                comboBox3.Enabled = false;
                spinEdit5.Enabled = false;
            }
            else
            {
                spinEdit2.Enabled = false;
                spinEdit4.Enabled = false;
                comboBox1.Enabled = true;
                comboBox3.Enabled = true;
                spinEdit5.Enabled = true;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mc7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mc1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mc6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mc3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mc5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mc2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void time3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void time2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mc4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void spinEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                label20.Visible = false;
                txtFile2.Visible = false;
                button6.Visible = false;
            }
            else
            {
                label20.Visible = true;
                txtFile2.Visible = true;
                button6.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtFile2.Text = dlg.FileName;
            }
        }
    }
}
