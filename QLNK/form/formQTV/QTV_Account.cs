using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNK.form.formQTV
{
    public partial class QTV_Account : Form
    {
        private int ID_QTV;
        public QTV_Account(int ma)
        {
            InitializeComponent();
            ID_QTV = ma;
            panel1.Hide();
            panel2.Hide();
            QTVprocessor.loadAccountData(data_Account, ID_QTV);
            data_Account.Show();
        }

        private void btn_AddTK_Click(object sender, EventArgs e)
        {
            //Trong trường hợp đang cập nhật thuốc thì lại chuyển qua thêm thuốc
            if (panel2.Visible)
            {
                MessageBox.Show("Vui lòng hoàn tất thao tác hiện tại hoặc ấn quay lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            data_Account.Hide();
            panel1.Show();
        }

        private void btn_ConfirmAdd_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text;
            string phone = txt_Phone.Text;
            string password = txt_Password.Text;
            string location = txt_Location.Text;
            DateTime birthdate = dateTimePicker1.Value;
            string role = txt_Role.Text;

            // Kiểm tra ngày sinh
            if (birthdate >= DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không được là trong tương lai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra số điện thoại và mật khẩu
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
            if (!IsPasswordValid(phone))
            {
                MessageBox.Show("Mật khẩu không hợp lệ, mật khẩu phải ít hơn 50 kí tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng lại nếu có lỗi
            }
            // Kiểm tra vai trò
            role = role.ToUpper(); 
            if (role == "KHÁCH HÀNG" || role == "KH")
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận thêm khách hàng trên với vai trò Khách hàng?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return; //dừng lại để sửa lại vai trò
                }
                else
                {
                    role = "KH";
                }
            }
            else if (role == "NHÂN VIÊN" || role == "NV")
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận thêm nhân viên trên với vai trò Nhân viên?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return; //dừng lại để sửa lại vai trò
                }
                else
                {
                    role = "NV";
                }
            }
            else if (role == "NHA SĨ" || role == "NS")
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận thêm nha sĩ trên với vai trò Nha sĩ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return; //dừng lại để sửa lại vai trò
                }
                else
                {
                    role = "NS";
                }
            }
            else
            {
                MessageBox.Show("Vai trò không hợp lệ, có 3 vai trò là KH, NV, NS.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            QTVprocessor.addAccount(phone, password, name, birthdate, location, ID_QTV, role);
            ClearTextBoxesInPanel(panel1);
            panel1.Hide();
            QTVprocessor.loadAccountData(data_Account, ID_QTV);
            data_Account.Show();
        }


        private void btn_EditLock_Click(object sender, EventArgs e)
        {
            //Trong trường hợp đang cập nhật tài khoản thì lại chuyển qua cài đặt khóa
            if (panel1.Visible)
            {
                MessageBox.Show("Vui lòng hoàn tất thao tác hiện tại hoặc ấn quay lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            panel2.Show();
        }

        private void QTV_Account_FormClosed(object sender, FormClosedEventArgs e)
        {
            QTV f = new QTV(ID_QTV);
            f.Show();
            this.Hide();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            if (panel1.Visible || panel2.Visible)
            {
                panel1.Hide();
                panel2.Hide();
                data_Account.Show();
            }
            else
            {
                QTV f = new QTV(ID_QTV);
                f.Show();
                this.Hide();
            }
        }

        // Hàm kiểm tra số điện thoại có hợp lệ hay không
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            // Loại bỏ khoảng trắng và kiểm tra xem số ký tự còn lại có từ 7 đến 10 không
            return !string.IsNullOrWhiteSpace(phoneNumber) && phoneNumber.Length >= 7 && phoneNumber.Length <= 10 && phoneNumber.All(char.IsDigit);
        }
        // Hàm kiểm tra mật khẩu có hợp lệ hay không
        private bool IsPasswordValid(string phoneNumber)
        {
            return !string.IsNullOrWhiteSpace(phoneNumber) && phoneNumber.Length < 51;
        }

        private void ClearTextBoxesInPanel(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = string.Empty;
                }
            }
        }

        private void btn_LockUpdate_Click(object sender, EventArgs e)
        {
            int id = 0;
            string role = txt_Role1.Text;

            // Kiểm tra số mã tài khoản
            if (int.TryParse(txt_IDTK.Text, out id))
            {
                if (id < 0)
                {
                    MessageBox.Show("ID tài khoản không hợp lệ, vui lòng nhập số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("ID tài khoản không hợp lệ, vui lòng nhập số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Kiểm tra vai trò
            role = role.ToUpper();
            if (role == "KHÁCH HÀNG" || role == "KH")
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận khóa tài khoản khách hàng trên?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return; 
                }
                else
                {
                    role = "KH";
                }
            }
            else if (role == "NHÂN VIÊN" || role == "NV")
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận khóa nhân viên trên?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                else
                {
                    role = "NV";
                }
            }
            else if (role == "NHA SĨ" || role == "NS")
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận khóa tài khoản nha sĩ trên?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                else
                {
                    role = "NS";
                }
            }
            else
            {
                MessageBox.Show("Vai trò không hợp lệ, có 3 vai trò là KH, NV, NS.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            QTVprocessor.lockAccount(id, role);
            ClearTextBoxesInPanel(panel2);
            panel2.Hide();
            QTVprocessor.loadAccountData(data_Account, ID_QTV);
            data_Account.Show();
        }
    }
}
