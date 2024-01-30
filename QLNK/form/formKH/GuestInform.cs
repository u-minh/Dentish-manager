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

namespace QLNK.form.formKH
{
    public partial class GuestInform : Form
    {
        public GuestInform()
        {
            InitializeComponent();
        }

        private void GuestInform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void btn_toLogin_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void btn_toKHAppointment_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text;
            string phone = txt_Phone.Text;
            string location = txt_Location.Text;
            DateTime birthdate = dateTimePicker1.Value;
            int ID_Quest = 0;
            if (string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Số điện thoại và tên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsPhoneNumberValid(phone))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Số điện thoại phải có từ 7 đến 10 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra ngày sinh
            if (birthdate >= DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không được là trong tương lai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thực hiện thêm thông tin vào bảng khách hàng
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    // Kiểm tra số điện thoại đã tồn tại
                    string selectQuery = $"SELECT ID_KH FROM KHACH_HANG WHERE SDT = {phone}";

                    // Tạo đối tượng SqlCommand
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ID_Quest = Convert.ToInt32(reader["ID_KH"]);
                                if (ID_Quest != 0)
                                {
                                    MessageBox.Show("Số điện thoại đã được đăng kí.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                            }
                        }
                    }
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Tạo câu truy vấn INSERT
                            string insertQuery = "INSERT INTO KHACH_HANG (HoTen, NgaySinh, SDT, DiaChi) VALUES (@hoten, @ngaysinh, @sdt, @diachi)";

                            // Tạo đối tượng SqlCommand với transaction
                            using (SqlCommand command = new SqlCommand(insertQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@hoten", name);
                                command.Parameters.AddWithValue("@ngaysinh", birthdate);
                                command.Parameters.AddWithValue("@sdt", phone);
                                command.Parameters.AddWithValue("@diachi", location);

                                // Thực hiện truy vấn INSERT
                                command.ExecuteNonQuery();
                            }

                            // Commit transaction khi mọi thứ đều thành công
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Tạo thông tin không thành công. Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    connection.Close();
                }
            }
            MessageBox.Show("Đăng ký thông tin thành công, chuyển sang đặt lịch hẹn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Thực hiện lấy ID guest
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                connection.Open();
                string selectQuery = $"SELECT ID_KH FROM KHACH_HANG WHERE SDT = {phone}";

                // Tạo đối tượng SqlCommand
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ID_Quest = Convert.ToInt32(reader["ID_KH"]);
                            // Chuyển sang màn hình đặt lịch hẹn
                            KH_Appointment f = new KH_Appointment(ID_Quest);
                            f.Show();
                            this.Hide();
                        }
                    }
                }
                connection.Close();   
            }
        }

        // Hàm kiểm tra số điện thoại có hợp lệ hay không
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            // Loại bỏ khoảng trắng và kiểm tra xem số ký tự còn lại có từ 7 đến 10 không
            return !string.IsNullOrWhiteSpace(phoneNumber) && phoneNumber.Length >= 7 && phoneNumber.Length <= 10 && phoneNumber.All(char.IsDigit);
        }
    }
}
