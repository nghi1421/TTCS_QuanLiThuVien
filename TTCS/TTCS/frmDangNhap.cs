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


        /******************************************************************
         * Để tránh việc người dùng ấn vào 1 form đến 2 lần chúng ta 
         * cần sử dụng hàm này để kiểm tra xem cái form hiện tại đã 
         * có trong bộ nhớ chưa
         * Nếu có trả về "f"
         * Nếu không trả về "null"
         ******************************************************************/
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


            Program.mlogin = txtTenDangNhap.Text.Trim();
            Program.password = txtMatKhau.Text.Trim();

            if (Program.KetNoi() == 0)
                return;
            else
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông Báo", MessageBoxButtons.OK);

            }


          /*  String statement = "EXEC SP_DANGNHAP '" + Program.loginName + "'";// exec sp_DangNhap 'TP'
            Program.myReader = Program.ExecSqlDataReader(statement);*/

/*            if (Program.myReader == null)
                return;*/
            // đọc một dòng của myReader - điều này là hiển nhiên vì kết quả chỉ có 1 dùng duy nhất
//            Program.myReader.Read();

            /*Program.userName = Program.myReader.GetString(0);// lấy userName(Mã nhân viên)
            if (Convert.IsDBNull(Program.userName))
            {
                MessageBox.Show("Tài khoản này không có quyền truy cập \n Hãy thử tài khoản khác", "Thông Báo", MessageBoxButtons.OK);
            }

            Program.staff = Program.myReader.GetString(1);
            Program.role = Program.myReader.GetString(2);

            Program.myReader.Close();
            Program.conn.Close();
            

            Program.FormChinh.ssMaNv.Text = $"Mã nhân viên: " + Program.userName;
            Program.FormChinh.ssHoTen.Text = "Họ tên: " + Program.staff;
            Program.FormChinh.ssVaiTro.Text = "Vai trò: " + Program.role;

            this.Visible = false;
            Program.FormChinh.enableButtons();*/
            this.Visible = false;
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // đặt sẵn mật khẩu để đỡ nhập lại nhiều lần
/*            txtTenDangNhap.Text = "sa";// nguyen long - chi nhanh
            txtMatKhau.Text = "123123";
            if (KetNoiDatabaseGoc() == 0)
                return;*/
        }

    }
}
