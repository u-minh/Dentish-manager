using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;
using System.Xml.Linq;
using QLNK.form;

namespace QLNK
{
    public static class ConnectionManager
    {
        // Biến lưu trữ phiên bản được chọn
        public static string SelectedVersion = "Default";

        // Phương thức để lấy chuỗi kết nối dựa trên phiên bản
        public static string GetConnectionString()
        {
            switch (SelectedVersion)
            {
                case "ValidatedVersion":
                    return "Data Source=LAPTOP-ETFG5SLK\\MSSQL;Initial Catalog=QLKHACHHANG;Integrated Security=True";
                case "FalseVersion":
                    return "Data Source=LAPTOP-ETFG5SLK\\MSSQL;Initial Catalog=QLKHACHHANGfalse;Integrated Security=True";
                // Thêm các phiên bản khác nếu cần
                default:
                    return "Data Source=LAPTOP-ETFG5SLK\\MSSQL;Initial Catalog=QLKHACHHANG;Integrated Security=True";
            }
        }
    }
    public class DBHelper
    {
        public static string strConn = ConnectionManager.GetConnectionString();
    }
    // Handle chức năng đăng nhập(ALL1), trả về loại tài khoản và mã của tài khoản đó
    public class LoginProcessor
    {
        public static void CheckCredentials(string taiKhoan, string matKhau, out string loaiTK, out int ma)
        {
            loaiTK = null;
            ma = 0;
           
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("dang_nhap", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                command.Parameters.Add("@tai_khoan", SqlDbType.VarChar, 10).Value = taiKhoan;
                                command.Parameters.Add("@mat_khau", SqlDbType.VarChar, 50).Value = matKhau;

                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        loaiTK = reader["loai_tk"].ToString();
                                        ma = Convert.ToInt32(reader["ma"]);
                                    }
                                }
                            }
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Đăng nhập không thành công. Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            
        }
    }
    #region Xử lý của khách hàng
    public class KHProcessor
    {
        // KH1: Tạo tài khoản
        public static void RegisterUser(string username, string password, string name, DateTime birthday, string address)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("kh_taoTK", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@username", username);
                                command.Parameters.AddWithValue("@password", password);
                                command.Parameters.AddWithValue("@name", name);
                                command.Parameters.AddWithValue("@birthday", birthday);
                                command.Parameters.AddWithValue("@address", address);

                                command.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Đăng ký thành công", "Thông báo");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Đăng ký không thành công. Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        // KH2: Xem thông tin lịch hẹn có thể đặt để thực hiện KH2(đặt lịch hẹn)
        public static void loadAppointmentData(DataGridView dataGridView)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("kh_xemLH", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                                {
                                    DataTable dataTable = new DataTable();
                                    adapter.Fill(dataTable);

                                    dataGridView.DataSource = dataTable;
                                }
                            }
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi trong transaction: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        // KH2: Đặt lịch hẹn
        public static void insertAppointment(DateTime ngay, TimeSpan gio, int idNS, int idKH)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("kh_datLH", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@date", ngay);
                                command.Parameters.AddWithValue("@time", gio);
                                command.Parameters.AddWithValue("@ID_NS", idNS);
                                command.Parameters.AddWithValue("@ID_KH", idKH);


                                command.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Đặt lịch hẹn thành công", "Thông báo");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Đặt lịch hẹn không thành công. Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        // KH: Xem lịch hẹn đã đặt loadScheduleData
        public static void loadScheduleData(DataGridView dataGridView, int idKH)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("kh_xemLHdadat", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@ID_KH", idKH);

                                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                                {
                                    DataTable dataTable = new DataTable();
                                    adapter.Fill(dataTable);

                                    dataGridView.DataSource = dataTable;
                                }
                            }
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi trong transaction: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        // KH3: Xem thông tin tài khoản cài đặt trong KH_inform.cs để đọc giá trị thẳng lên txtBox
        // KH4: Cập nhật thông tin cá nhân
        public static void editInform(string username, string password, string name, DateTime birthday, string address, int idKH, string email)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("kh_capnhatHS", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@newphone", username);
                                command.Parameters.AddWithValue("@newpassword", password);
                                command.Parameters.AddWithValue("@newname", name);
                                command.Parameters.AddWithValue("@newbirthdate", birthday);
                                command.Parameters.AddWithValue("@newadd", address);
                                command.Parameters.AddWithValue("@newemail", email);
                                command.Parameters.AddWithValue("@id", idKH);


                                command.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Sửa đổi thông tin thành công", "Thông báo");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Sửa đổi không thành công. Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        // KH5: Xem hồ sơ bệnh án
        public static void loadMedicalData(DataGridView dataGridView, int maKH)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("kh_xemBA", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@ID", maKH);

                                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                                {
                                    DataTable dataTable = new DataTable();
                                    adapter.Fill(dataTable);

                                    dataGridView.DataSource = dataTable;
                                }
                            }
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi trong transaction: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
    #endregion
    #region Xử lý của nha sĩ
    public class NSProcessor
    {
        //NS1: Xem hồ sơ bệnh án của nha sĩ
        public static void loadMedicalData(DataGridView dataGridView, int maNS)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("ns_xemBA", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@ID_NS", maNS);

                                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                                {
                                    DataTable dataTable = new DataTable();
                                    adapter.Fill(dataTable);

                                    dataGridView.DataSource = dataTable;
                                }
                            }
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi trong transaction: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        //NS1: Xem hồ sơ bệnh án của nha sĩ và khách hàng
        public static void loadMedicalDataKH(DataGridView dataGridView, int maNS, string phone)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("ns_xemBAKH", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@ID_NS", maNS);
                                command.Parameters.AddWithValue("@SDT", phone);


                                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                                {
                                    DataTable dataTable = new DataTable();
                                    adapter.Fill(dataTable);

                                    dataGridView.DataSource = dataTable;
                                }
                            }
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi trong transaction: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        // NS1: Tạo hồ sơ bệnh án
        public static void createMedicalRecord(int ma, string phone, DateTime ngayKham, string dichVu, string thuoc)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("ns_taoBA", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@ID_NS", ma);
                                command.Parameters.AddWithValue("@SDT", phone);
                                command.Parameters.AddWithValue("@NgayKham", ngayKham);
                                command.Parameters.AddWithValue("@DichVu", dichVu);
                                command.Parameters.AddWithValue("@Thuoc", thuoc);

                                command.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Tạo bệnh án thành công", "Thông báo");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Tạo bệnh án không thành công. Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        // NS2: Cập nhật hồ sơ bệnh án
        public static void updateMedicalRecord(int maNS, int maBA, string dichVu, string thuoc, DateTime ngayKham)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("ns_capnhatBA", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@ID_NS", maNS);
                                command.Parameters.AddWithValue("@ID_BA", maBA);
                                command.Parameters.AddWithValue("@DichVu", dichVu);
                                command.Parameters.AddWithValue("@Thuoc", thuoc);
                                command.Parameters.AddWithValue("@NgayKham", ngayKham);

                                command.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Cập nhật bệnh án thành công", "Thông báo");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Cập nhật bệnh án không thành công. Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        // NS3: xem lịch hẹn nha sĩ
        public static void loadSchedule(DataGridView dataGridView, int maNS)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("ns_xemLH", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@ID_NS", maNS);

                                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                                {
                                    DataTable dataTable = new DataTable();
                                    adapter.Fill(dataTable);

                                    dataGridView.DataSource = dataTable;
                                }
                            }
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi trong transaction: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        // NS3: Sửa lịch hẹn nha sĩ
        public static void editSchedule(int maNS, DateTime ngayKham, TimeSpan gioKham, DateTime ngayKhamCu, TimeSpan gioKhamCu)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("ns_suaLH", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@ID_NS", maNS);
                                command.Parameters.AddWithValue("@NgayKham", ngayKham);
                                command.Parameters.AddWithValue("@GioKham", gioKham);                               
                                command.Parameters.AddWithValue("@NgayKhamCu", ngayKhamCu);
                                command.Parameters.AddWithValue("@GioKhamCu", gioKhamCu);

                                command.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Sửa lịch hẹn thành công", "Thông báo");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Sửa lịch hẹn không thành công. Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        // NS3: Thêm lịch hẹn nha sĩ
        public static void addSchedule(int maNS, DateTime ngayKham, TimeSpan gioKham)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("ns_themLH", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@ID_NS", maNS);
                                command.Parameters.AddWithValue("@NgayKham", ngayKham);
                                command.Parameters.AddWithValue("@GioKham", gioKham);

                                command.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Thêm lịch hẹn thành công", "Thông báo");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Thêm lịch hẹn không thành công. Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
    #endregion

    #region Xử lý của nhân viên
    public class NVProcessor
    {
        // NV1: Xem thông tin lịch hẹn
        public static void loadAppointmentData(DataGridView dataGridView)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("nv_xemLH", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                                {
                                    DataTable dataTable = new DataTable();
                                    adapter.Fill(dataTable);

                                    dataGridView.DataSource = dataTable;
                                }
                            }
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi trong transaction: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        // NV2: Đặt lịch hẹn
        public static void insertAppointment(DateTime ngay, TimeSpan gio, int idNS, int idKH, int idNV)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("nv_datLH", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@date", ngay);
                                command.Parameters.AddWithValue("@time", gio);
                                command.Parameters.AddWithValue("@ID_NS", idNS);
                                command.Parameters.AddWithValue("@ID_KH", idKH);
                                command.Parameters.AddWithValue("@ID_NV_LAP", idNV);

                                command.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Thêm lịch hẹn thành công", "Thông báo");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Thêm lịch hẹn không thành công. Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        // NV2: Xem lịch hẹn đã đặt loadScheduleData
        public static void loadScheduleData(DataGridView dataGridView)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("nv_xemLHdadat", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                                {
                                    DataTable dataTable = new DataTable();
                                    adapter.Fill(dataTable);

                                    dataGridView.DataSource = dataTable;
                                }
                            }
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi trong transaction: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        // NV3: xem bệnh án để tạo hóa đơn
        public static void loadMedicalRecord(DataGridView dataGridView)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("nv_xemBA", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                                {
                                    DataTable dataTable = new DataTable();
                                    adapter.Fill(dataTable);

                                    dataGridView.DataSource = dataTable;
                                }
                            }
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi trong transaction: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public static void loadMedicalRecordKH(DataGridView dataGridView, string SDT)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("nv_xemBAKH", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@SDT", SDT);

                                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                                {
                                    DataTable dataTable = new DataTable();
                                    adapter.Fill(dataTable);

                                    dataGridView.DataSource = dataTable;
                                }
                            }
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi trong transaction: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        // NV3: xem giá để tạo hóa đơn
        public static decimal NV_checkPrice(string ten, string loai)
        {
            decimal gia = 0;
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("nv_xemGia", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                command.Parameters.AddWithValue("@Ten", ten);
                                command.Parameters.AddWithValue("@Loai", loai);
                                SqlParameter giaParam = new SqlParameter("@Gia", SqlDbType.Decimal);
                                giaParam.Direction = ParameterDirection.Output;
                                giaParam.Precision = 10;
                                giaParam.Scale = 2;

                                command.Parameters.Add(giaParam);
                                command.ExecuteNonQuery();
                                // lấy giá trị
                                gia = giaParam.Value != DBNull.Value ? Convert.ToDecimal(giaParam.Value) : 0;
                            }
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Check giá không thành công. Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            return gia;
        }
        // NV4: Xem ttin thuốc lấy từ QTV4: xem thông tin thuốc
    }
    #endregion
    #region Xử lý của quản trị viên
    public class QTVprocessor
    {
        // Xem thông tin tài khoản
        public static void loadAccountData(DataGridView dataGridView, int maQTV)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("qtv_xemTK", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@ID", maQTV);

                                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                                {
                                    DataTable dataTable = new DataTable();
                                    adapter.Fill(dataTable);

                                    dataGridView.DataSource = dataTable;
                                }
                            }
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi trong transaction: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }

            }
        }
        // QTV1: Thêm tài khoản
        public static void addAccount(string username, string password, string name, DateTime birthday, string address, int maQTV, string role)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("qtv_themTK", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@SDT", username);
                                command.Parameters.AddWithValue("@Password", password);
                                command.Parameters.AddWithValue("@HoTen", name);
                                command.Parameters.AddWithValue("@NgaySinh", birthday);
                                command.Parameters.AddWithValue("@DiaChi", address);
                                command.Parameters.AddWithValue("@ID_QTV", maQTV);
                                command.Parameters.AddWithValue("@Role", role);

                                command.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Đăng ký thành công", "Thông báo");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Đăng ký không thành công. Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        // QTV2: khóa tài khoản
        public static void lockAccount(int ma, string role)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("qtv_KhoaTK", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@ID", ma);
                                command.Parameters.AddWithValue("@Role", role);

                                command.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Khóa tài khoản thành công", "Thông báo");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Khóa không thành công. Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        // Xem thông tin thuốc
        public static void loadMedicineData(DataGridView dataGridView)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("qtv_xemThuoc", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                                {
                                    DataTable dataTable = new DataTable();
                                    adapter.Fill(dataTable);

                                    dataGridView.DataSource = dataTable;
                                }
                            }
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi trong transaction: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
                
            }
        }
        // QTV3: Thêm thuốc vào kho
        public static void addMedicine(string tenThuoc, string donVi, string chiDinh, int soLuong, decimal donGia, DateTime ngayHetHan)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("qtv_ThemThuoc", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                command.Parameters.AddWithValue("@TenThuoc", tenThuoc);
                                command.Parameters.AddWithValue("@DonViTinh", donVi);
                                command.Parameters.AddWithValue("@ChiDinh", chiDinh);
                                command.Parameters.AddWithValue("@SoLuongTon", soLuong);
                                command.Parameters.AddWithValue("@DonGiaThuoc", donGia);
                                command.Parameters.AddWithValue("@NgayHetHan", ngayHetHan);

                                command.ExecuteNonQuery();
                            }
                            transaction.Commit();
                            MessageBox.Show("Thêm thuốc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Thêm thuốc không thành công. Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }

            }
        }
        // QTV4: Xóa thuốc đã hết hạn
        public static void deleteMedicine()
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("qtv_xoaThuocHetHan", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                command.ExecuteNonQuery();
                            }
                            transaction.Commit();
                            MessageBox.Show("Xóa thuốc hết hạn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Xóa thuốc hết hạn không thành công. Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        // QTV5: Sửa thông tin số lượng thuốc
        public static void editQuantity(int idThuoc, int soLuong)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.strConn))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("qtv_UpdateSLThuoc", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                command.Parameters.AddWithValue("@ID_Thuoc", idThuoc);
                                command.Parameters.AddWithValue("@SoLuong", soLuong);

                                command.ExecuteNonQuery();
                            }
                            transaction.Commit();
                            MessageBox.Show("Cập nhật số lượng thuốc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Cập nhật số lượng thuốc không thành công. Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }

            }
        }
    }
    #endregion Quản trị viên
}
