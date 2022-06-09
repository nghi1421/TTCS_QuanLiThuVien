using CSPT_NGANHANG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ttcs;

namespace TTCS
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
/*            Program.conn.ConnectionString = Program.connstr_publisher;
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }*/

        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Program.KetNoi2();
            if (!Program.checkdbexist())
            {
                MessageBox.Show("Database không tồn tại !");
                return;
            }
            Program.KetNoi();
            Form frm = this.CheckExists(typeof(frmTK));
            if (frm != null) frm.Activate();
            else
            {
                frmTK f = new frmTK();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.KetNoi2();
            if (!Program.checkdbexist())
            {
                MessageBox.Show("Database không tồn tại !");
                return;
            }
            Program.KetNoi();
            Form frm = this.CheckExists(typeof(frmRole));
            if (frm != null) frm.Activate();
            else
            {
                frmRole f = new frmRole();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Form1));
            if (frm != null) frm.Activate();
            else
            {
                Form1 f = new Form1();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
