using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNK.form.formKH
{
    public partial class KH_Inform : Form
    {
        int ID_KH;
        bool checkEdit = false;
        public KH_Inform(int ma)
        {
            InitializeComponent();
            this.KeyDown += KH_Inform_KeyDown;
            this.Focus();
            this.KeyPreview = true;
            ID_KH = ma;
            LoadCustomerInfo(ID_KH);
            DisableEdit(checkEdit);
        }
        private void KH_Inform_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra nếu phím được nhấn là phím Esc
            if (e.KeyCode == Keys.Escape)
            {
                KH f = new KH(ID_KH);
                f.Show();
                this.Hide();
            }
        }
        private void KH_Inform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void DisableEdit(bool check)
        {
            if (check == false)
            {
                txt_Name.Enabled = false;
                txt_Location.Enabled = false;
                txt_Phone.Enabled = false;
                txt_Email.Enabled = false;
                txt_Passwrd.Enabled = false;
                dateTimePicker1.Enabled = false;
            }
            else
            {
                txt_Name.Enabled = true;
                txt_Location.Enabled = true;
                txt_Phone.Enabled = true;
                txt_Email.Enabled = true;
                txt_Passwrd.Enabled = true;
                dateTimePicker1.Enabled = true;
            }
        }

        // KH3: Xem thông tin cá nhân
        private void LoadCustomerInfo(int idKH)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("kh_xemHS", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", idKH);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Đọc dữ liệu từ SqlDataReader và gán vào các TextBox
                            txt_Name.Text = reader["HoTen"].ToString();
                            txt_Location.Text = reader["DiaChi"].ToString();
                            txt_Phone.Text = reader["SDT"].ToString();
                            txt_Email.Text = reader["Email"].ToString();
                            txt_Passwrd.Text = reader["MatKhau"].ToString();
                            // Kiểm tra xem cột "NgaySinh" có giá trị không trống
                            if (reader["NgaySinh"] != DBNull.Value)
                            {
                                // Chuyển đổi giá trị từ cột "NgaySinh" sang kiểu DateTime
                                DateTime ngaySinh = (DateTime)reader["NgaySinh"];
                                dateTimePicker1.Value = ngaySinh;
                            }
                        }
                        else
                        {
                            // Không tìm thấy thông tin cho ID_KH tương ứng
                            MessageBox.Show("Không tìm thấy thông tin khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void box_Name_Click(object sender, EventArgs e)
        {
            if(!checkEdit)
            {
                MessageBox.Show("Nhập thông tin bạn muốn thay đổi vào ô bên cạnh sau đó nhấn xác nhận để thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txt_Name.Enabled = true;
            checkEdit = true;
        }

        private void box_Phone_Click(object sender, EventArgs e)
        {
            if (!checkEdit)
            {
                MessageBox.Show("Nhập thông tin bạn muốn thay đổi vào ô bên cạnh sau đó nhấn xác nhận để thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txt_Phone.Enabled = true;
            checkEdit = true;
        }

        private void box_PW_Click(object sender, EventArgs e)
        {
            if (!checkEdit)
            {
                MessageBox.Show("Nhập thông tin bạn muốn thay đổi vào ô bên cạnh sau đó nhấn xác nhận để thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txt_Passwrd.Enabled = true;
            checkEdit = true;
        }

        private void box_Email_Click(object sender, EventArgs e)
        {
            if (!checkEdit)
            {
                MessageBox.Show("Nhập thông tin bạn muốn thay đổi vào ô bên cạnh sau đó nhấn xác nhận để thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txt_Email.Enabled = true;
            checkEdit = true;
        }

        private void box_Adr_Click(object sender, EventArgs e)
        {
            if (!checkEdit)
            {
                MessageBox.Show("Nhập thông tin bạn muốn thay đổi vào ô bên cạnh sau đó nhấn xác nhận để thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txt_Location.Enabled = true;
            checkEdit = true;
        }

        private void box_BD_Click(object sender, EventArgs e)
        {
            if (!checkEdit)
            {
                MessageBox.Show("Nhập thông tin bạn muốn thay đổi vào ô bên cạnh sau đó nhấn xác nhận để thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dateTimePicker1.Enabled = true;
            checkEdit = true;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (!checkEdit)
            {
                KH f = new KH(ID_KH);
                f.Show();
                this.Hide();
            }
            else
            {
                KHProcessor.editInform(txt_Phone.Text, txt_Passwrd.Text, txt_Name.Text, dateTimePicker1.Value, txt_Location.Text, ID_KH, txt_Email.Text);
                LoadCustomerInfo(ID_KH);
                DisableEdit(false);
            }
        }

        private void btn_EditTrue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhập thông tin bạn muốn thay đổi vào các ô sau đó nhấn xác nhận để thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            checkEdit = true;
            DisableEdit(checkEdit);
        }
    }
}
