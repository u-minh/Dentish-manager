using QLNK.form.formKH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNK.form.formNV
{
    public partial class NV_Invoice : Form
    {
        int ID_NV;
        public NV_Invoice(int ma)
        {
            InitializeComponent();
            ID_NV = ma;

            this.KeyDown += NV_InvoiceKeydown;
            // Đảm bảo form có Focus để nhận sự kiện KeyDown
            this.Focus();
            this.KeyPreview = true;

            NVProcessor.loadMedicalRecord(data_MedicalRecord);
        }

        private void NV_Invoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            NV f = new NV(ID_NV);
            f.Show();
            this.Hide();
        }
        private void NV_InvoiceKeydown(object sender, KeyEventArgs e)
        {
            // Kiểm tra nếu phím được nhấn là phím Esc
            if (e.KeyCode == Keys.Escape)
            {
                NV f = new NV(ID_NV);
                f.Show();
                this.Hide();
            }
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            string phone = txt_Phone.Text;
            if (!IsPhoneNumberValid(phone))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Số điện thoại phải có từ 7 đến 10 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng lại nếu có lỗi
            }
            else
            {
                NVProcessor.loadMedicalRecordKH(data_MedicalRecord, phone);
            }
        }
        // Hàm kiểm tra số điện thoại có hợp lệ hay không
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            // Loại bỏ khoảng trắng và kiểm tra xem số ký tự còn lại có từ 7 đến 10 không
            return !string.IsNullOrWhiteSpace(phoneNumber) && phoneNumber.Length >= 7 && phoneNumber.Length <= 10 && phoneNumber.All(char.IsDigit);
        }

        private void data_MedicalRecord_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có phải là dòng dữ liệu không
            if (e.RowIndex >= 0)
            {
                List<string> listDichVuvaThuoc = new List<string>();
                List<decimal> listDonGia = new List<decimal>();

                // Lấy giá trị từ cột "Dịch vụ" và "Thuốc" của dòng được chọn
                object cellValueDichVu = data_MedicalRecord.Rows[e.RowIndex].Cells["Dịch vụ"].Value;
                object cellValueThuoc = data_MedicalRecord.Rows[e.RowIndex].Cells["Thuốc"].Value; 

                if (cellValueDichVu != null)
                {
                    string strDichVu = cellValueDichVu.ToString();
                    string[] CacDichVu = strDichVu.Split(',');
                    for (int i = 0; i < CacDichVu.Length; i++)
                    {
                        CacDichVu[i] = CacDichVu[i].Trim();
                    }

                    foreach (var dichvu in CacDichVu)
                    {
                        listDichVuvaThuoc.Add(dichvu);
                        listDonGia.Add(NVProcessor.NV_checkPrice(dichvu, "DICHVU"));
                    }
                }
                if (cellValueThuoc != null)
                {
                    string strThuoc = cellValueThuoc.ToString();
                    string[] CacThuoc = strThuoc.Split(',');
                    for (int i = 0; i < CacThuoc.Length; i++)
                    {
                        CacThuoc[i] = CacThuoc[i].Trim();
                    }
                    foreach (var thuoc in CacThuoc)
                    {
                        listDichVuvaThuoc.Add(thuoc);
                        listDonGia.Add(NVProcessor.NV_checkPrice(thuoc, "THUOC"));
                    }
                }
                // Hiển thị thông tin
                if (listDichVuvaThuoc.Count > 0)
                {
                    // Tìm chiều dài lớn nhất của tên Dịch vụ/Thuốc để căn chỉnh cột
                    int maxLength = listDichVuvaThuoc.Max(s => s.Length);

                    // Chuỗi để lưu thông tin để hiển thị trong MessageBox
                    string message = "Dịch vụ/Thuốc".PadRight(maxLength) + "         \t Giá\n--\n";

                    for (int i = 0; i < listDichVuvaThuoc.Count; i++)
                    {
                        message += $"{listDichVuvaThuoc[i].PadRight(maxLength)}         \t {listDonGia[i]}\n";
                    }

                    message += "--\nTổng giá tiền:".PadRight(maxLength) + $"         \t {listDonGia.Sum()}";
                    
                    MessageBox.Show(message, "Thông tin giá Dịch vụ và Thuốc", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không có thông tin giá Dịch vụ và Thuốc.", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
    }
}
