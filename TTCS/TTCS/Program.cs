using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;

namespace TTCS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publisher = "Data Source=Localhost; Initial Catalog = QuanLiThuVien; Integrated Security = true; MultipleActiveResultSets=true";
        public static SqlDataReader myReader;
        public static String servername = "Localhost";
        public static String mlogin = "sa";
        public static String password = "123123";

        public static String database = "QuanLiThuVien";

        public static frmMain frmChinh;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=Localhost"+";Initial Catalog=" +
                      "QuanLiThuVien" + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password+ "; MultipleActiveResultSets=true";
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }


        }
        public static int KetNoi2()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                String connstrPublisher = "Data Source=Localhost ;Initial Catalog=master"
                       + ";User ID=sa" + ";password=123123";
                Program.conn.ConnectionString = connstrPublisher;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu." + e.Message, "", MessageBoxButtons.OK);
                //Console.WriteLine(e.Message);
                return 0;
            }
        }
        public static  Boolean checkdbexist()
        {
            if (Program.conn.State != ConnectionState.Open)
            {
                Program.conn.Open();
            }
            string cmd = "select case when DB_ID('quanlithuvien') IS NOT NULL then 1 else 0 end";
            SqlCommand command = new SqlCommand(cmd, Program.conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader != null)
            {
                reader.Read();
                int result = int.Parse(reader.GetValue(0).ToString());
                if (result == 1)
                {
                    reader.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
                }

            }
            return false;

        }
        public static SqlDataReader ExecSqlDataReader(String cmd)
        {
            SqlDataReader myreader;
            SqlCommand sqlCmd = new SqlCommand(cmd, Program.conn);
            sqlCmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlCmd.ExecuteReader();
                return myreader;
            }
            catch (Exception)
            {
                Console.Write(cmd);
                Program.conn.Close();
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            Program.conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String cmd)
        {
            SqlCommand sqlCmd = new SqlCommand(cmd, Program.conn);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandTimeout = 600;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                conn.Close();
                Console.Write(sqlCmd);
                MessageBox.Show(ex.ToString());
                return ex.State;
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            KetNoi2();
            if (checkdbexist()) KetNoi();
            Application.Run(new frmMain());
            
        }
    }
}
