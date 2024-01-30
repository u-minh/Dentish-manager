using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNK
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text;
            string phone = txt_Phone.Text;
            string password = txt_Password.Text;
            string location = txt_Location.Text;
            DateTime birthdate = dateTimePicker1.Value;
            if (string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Số điện thoại và mật khẩu không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng lại nếu có lỗi
            }
            if (!IsPhoneNumberValid(phone))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Số điện thoại phải có từ 7 đến 10 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng lại nếu có lỗi
            }
            if (!IsPasswordValid(password))
            {
                MessageBox.Show("Mật khẩu không hợp lệ, mật khẩu phải ít hơn 50 kí tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng lại nếu có lỗi
            }
            // Kiểm tra ngày sinh
            if (birthdate >= DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không được là trong tương lai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Thực hiện kiểm tra và xử lý đăng ký ở đây
            KHProcessor.RegisterUser(phone, password, name, birthdate, location);
        }

        // Hàm kiểm tra số điện thoại có hợp lệ hay không
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            // Loại bỏ khoảng trắng và kiểm tra xem số ký tự còn lại có từ 7 đến 10 không
            return !string.IsNullOrWhiteSpace(phoneNumber) && phoneNumber.Length >= 7 && phoneNumber.Length <= 10 && phoneNumber.All(char.IsDigit);
        }
        // Hàm kiểm tra mật khẩu có hợp lệ hay không
        private bool IsPasswordValid(string _password)
        {
            return !string.IsNullOrWhiteSpace(_password) && _password.Length < 51;
        }

        private void btn_toLogin_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }
    }
}
