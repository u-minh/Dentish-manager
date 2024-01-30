using QLNK.form.formKH;
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

namespace QLNK.form.formNV
{
    public partial class NV_Appointment : Form
    {
        int ID_NV;
        int ID_Quest = 0;
        public NV_Appointment(int ma)
        {
            InitializeComponent();
            ID_NV = ma;

            this.KeyDown += NV_Appointment_KeyDown;
            // Đảm bảo form có Focus để nhận sự kiện KeyDown
            this.Focus();
            this.KeyPreview = true;

            NVProcessor.loadAppointmentData(data_Appointment);
            NVProcessor.loadScheduleData(LH_done);
        }

        private void NV_Appointment_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra nếu phím được nhấn là phím Esc
            if (e.KeyCode == Keys.Escape)
            {
                NV f = new NV(ID_NV);
                f.Show();
                this.Hide();
            }
        }

        private void NV_Appointment_FormClosed(object sender, FormClosedEventArgs e)
        {
            NV f = new NV(ID_NV);
            f.Show();
            this.Hide();
        }



        private void btn_toKHAppointment_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text;
            string phone = txt_Phone.Text;
            string location = txt_Location.Text;
            DateTime birthdate = dateTimePicker1.Value;
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

             bool checkIDexist = false;
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
                            }
                        }
                    }
                    if (ID_Quest != 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("Số điện thoại đã được đăng kí, lấy thông tin khách hàng đó để đặt lịch?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.No)
                        {
                            checkIDexist = false;
                            return;
                        }
                        else
                        {
                            checkIDexist = true;
                        }
                    }
                    else
                    {
                        using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                // Tạo câu truy vấn INSERT
                                string insertQuery = "INSERT INTO KHACH_HANG (HoTen, NgaySinh, SDT, DiaChi) VALUES (@hoten, @ngaysinh, @sdt, @diachi)";

                                // Tạo đối tượng SqlCommand với transaction
                                using (SqlCommand command1 = new SqlCommand(insertQuery, connection, transaction))
                                {
                                    command1.Parameters.AddWithValue("@hoten", name);
                                    command1.Parameters.AddWithValue("@ngaysinh", birthdate);
                                    command1.Parameters.AddWithValue("@sdt", phone);
                                    command1.Parameters.AddWithValue("@diachi", location);

                                    // Thực hiện truy vấn INSERT
                                    command1.ExecuteNonQuery();
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
            if (checkIDexist == false)
            {
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
                            }
                        }
                    }
                    connection.Close();
                }
                MessageBox.Show("Đăng ký thông tin thành công, đặt lịch hẹn bằng cách chọn vào dòng trên bảng lịch hẹn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void data_Appointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ID_Quest == 0)
            {
                MessageBox.Show($"Chưa có thông tin khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (e.RowIndex >= 0)
                {
                    int idNhaSi;
                    DateTime ngayKham;
                    TimeSpan gioKham;
                    // Lấy giá trị từ dòng được chọn
                    DataGridViewRow row = data_Appointment.Rows[e.RowIndex];

                    // Lấy giá trị ID_NS kiểu int
                    if (int.TryParse(row.Cells["ID Nha sĩ"].Value.ToString(), out idNhaSi))
                    {
                        DialogResult dialogResult = MessageBox.Show($"Xác nhận ID Nha Sĩ: {idNhaSi}?", "Thông báo", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.No)
                        {
                            return;
                        }
                        else
                        {
                            // Lấy giá trị NgayKham kiểu DateTime
                            if (DateTime.TryParse(row.Cells["Ngày khám"].Value.ToString(), out ngayKham))
                            {
                                // Lấy giá trị GioKham kiểu TimeSpan
                                if (TimeSpan.TryParse(row.Cells["Giờ khám"].Value.ToString(), out gioKham))
                                {
                                    ngayKham = ngayKham.Date + gioKham;
                                    DialogResult dialogResult1 = MessageBox.Show($"Xác nhận ngày khám: {ngayKham}?", "Thông báo", MessageBoxButtons.YesNo);
                                    if (dialogResult1 == DialogResult.No)
                                    {
                                        return;
                                    }
                                    else
                                    {
                                        if (ngayKham < DateTime.Now)
                                        {
                                            MessageBox.Show("Hãy chọn lại một ngày trong tương lai.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                        else
                                        {
                                            NVProcessor.insertAppointment(ngayKham, gioKham, idNhaSi, ID_Quest, ID_NV);
                                            NVProcessor.loadAppointmentData(data_Appointment);
                                            NVProcessor.loadScheduleData(LH_done);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không lấy được các giá trị của lịch hẹn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LH_done_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maLH;
                string nhaSi;
                string khachHang;
                DateTime ngayKham;
                TimeSpan gioKham;

                // Lấy giá trị từ dòng được chọn
                DataGridViewRow row = LH_done.Rows[e.RowIndex];

                // Lấy giá trị ID_NS kiểu int
                if (row.Cells["Mã số"].Value != null && int.TryParse(row.Cells["Mã số"].Value.ToString(), out maLH))
                {
                    DialogResult dialogResult = MessageBox.Show($"Xác nhận in phiếu khám cho mã lịch hẹn: {maLH}?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        nhaSi = row.Cells["Nha sĩ"].Value?.ToString();
                        khachHang = row.Cells["Khách hàng"].Value?.ToString();

                        // Lấy giá trị NgayKham kiểu DateTime
                        if (row.Cells["Ngày khám"].Value != null && DateTime.TryParse(row.Cells["Ngày khám"].Value.ToString(), out ngayKham))
                        {
                            // Lấy giá trị GioKham kiểu TimeSpan
                            if (row.Cells["Giờ khám"].Value != null && TimeSpan.TryParse(row.Cells["Giờ khám"].Value.ToString(), out gioKham))
                            {
                                ngayKham = ngayKham.Date + gioKham;
                                string NgayKhamString = ngayKham.ToString();
                                // Thực hiện in phiếu tại đây
                                MessageBox.Show($"Đã in phiếu khám cho khách hàng: {khachHang}.\nHẹn nha sĩ: {nhaSi}, ngày giờ khám: {NgayKhamString}.\nMã lịch hẹn: {maLH}, Mã nhân viên lâp: {ID_NV}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không lấy được mã lịch hẹn cần in.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
