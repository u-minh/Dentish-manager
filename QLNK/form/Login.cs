using QLNK.form;
using QLNK.form.formKH;
using QLNK.form.formNS;
using QLNK.form.formNV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNK
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Register_Click_1(object sender, EventArgs e)
        {
            Register f = new Register();
            f.Show();
            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string taiKhoan = txt_Username.Text;
            string matKhau = txt_Password.Text;
            string loaiTK;
            int ma;

            LoginProcessor.CheckCredentials(taiKhoan, matKhau, out loaiTK, out ma);
            if (!string.IsNullOrEmpty(loaiTK))
            {
                // Đăng nhập thành công, xử lý logic tiếp theo tùy vào loại tài khoản
                switch (loaiTK)
                {
                    case "NV":
                        // Xử lý cho nhân viên
                        MessageBox.Show($"Đăng nhập thành công với mã nhân viên: {ma}", "Thông báo");
                        NV f_NV = new NV(ma);
                        f_NV.Show();
                        this.Hide();
                        break;
                    case "KH":
                        // Xử lý cho khách hàng
                        MessageBox.Show($"Đăng nhập thành công với mã khách hàng: {ma}", "Thông báo");
                        KH f_KH = new KH(ma);
                        f_KH.Show();
                        this.Hide();
                        break;
                    case "NS":
                        // Xử lý cho nhà sĩ
                        MessageBox.Show($"Đăng nhập thành công với mã nhà sĩ: {ma}", "Thông báo");
                        NS f_NS = new NS(ma);
                        f_NS.Show();
                        this.Hide();
                        break;
                    case "QT":
                        // Xử lý cho quản trị viên
                        MessageBox.Show($"Đăng nhập thành công với mã quản trị viên: {ma}", "Thông báo");
                        QTV f_QTV = new QTV(ma);
                        f_QTV.Show();
                        this.Hide();
                        break;
                    default:
                        // Trường hợp khác (nếu có)
                        break;
                }
            }
            else
            {
                // Đăng nhập không thành công
                MessageBox.Show("Thông tin đăng nhập không đúng hoặc tài khoản đã bị khóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_ToBooking_Click(object sender, EventArgs e)
        {
            GuestInform f = new GuestInform();
            f.Show();
            this.Hide();
        }
    }
}
