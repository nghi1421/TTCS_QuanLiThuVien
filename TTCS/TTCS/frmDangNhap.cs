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
using TTCS;

namespace CSPT_NGANHANG
{
    public partial class frmDangNhap : Form
    {
        private SqlConnection connPublisher = new SqlConnection();

        public frmDangNhap()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnDangNhap_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản & mật khẩu không thể bỏ trống", "Thông Báo", MessageBoxButtons.OK);
                return;
            }

             String cauTruyVan = "DECLARE @RESULT INT" +
                "EXEC @RESULT = SP_KIEMTRA_QUYEN " + txtTenDangNhap.Text.Trim() + "" +
                "SELECT @RESULT ";
         
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    MessageBox.Show("Thực thi database thất bại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.conn.ConnectionString = "";
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                Program.conn.ConnectionString = "";
                return;
            }

            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            if(result == 0)
            {
                MessageBox.Show("Login không có quyền sử dụng phần mềm", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Program.mlogin = txtTenDangNhap.Text.Trim();
            Program.password = txtMatKhau.Text.Trim();

            if (Program.KetNoi() == 0)
                return;
            else
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông Báo", MessageBoxButtons.OK);

            }
            this.Visible = false;
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

        }
    }
}
