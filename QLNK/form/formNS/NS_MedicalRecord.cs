using QLNK.form.formNV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace QLNK.form.formNS
{
    public partial class NS_MedicalRecord : Form
    {
        int ID_NS;
        int ID_BA;
        public NS_MedicalRecord(int ma)
        {
            InitializeComponent();
            ID_NS = ma;

            this.KeyDown += NS_MedicalRecord_Keydown;
            // Đảm bảo form có Focus để nhận sự kiện KeyDown
            this.Focus();
            this.KeyPreview = true;

            panel1.Hide();
            panel2.Hide();
            NSProcessor.loadMedicalData(data_MedicalRecord, ID_NS);
        }

        private void NS_MedicalRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            NS f = new NS(ID_NS);
            f.Show();
            this.Hide();
        }

        private void NS_MedicalRecord_Keydown(object sender, KeyEventArgs e)
        {
            // Kiểm tra nếu phím được nhấn là phím Esc
            if (e.KeyCode == Keys.Escape)
            {
                if (panel1.Visible || panel2.Visible)
                {
                    ClearTextBoxesInPanel(panel1);
                    ClearTextBoxesInPanel(panel2);
                    panel1.Hide();
                    panel2.Hide();
                    data_MedicalRecord.Show();
                }
                else
                {
                    NS f = new NS(ID_NS);
                    f.Show();
                    this.Hide();
                }
            }
        }

        private void btn_Find_Click_1(object sender, EventArgs e)
        {
            string phone = txt_Phone.Text;
            if (!IsPhoneNumberValid(phone))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Số điện thoại phải có từ 7 đến 10 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng lại nếu có lỗi
            }
            else
            {
                NSProcessor.loadMedicalDataKH(data_MedicalRecord, ID_NS, phone);
            }
        }
        private void data_MedicalRecord_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (panel1.Visible || panel2.Visible)
            {
                MessageBox.Show("Vui lòng hoàn tất thao tác hiện tại hoặc ấn ESC quay lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Kiểm tra xem có phải là dòng dữ liệu không
                if (e.RowIndex >= 0)
                {
                    int id_BA;
                    // Lấy giá trị từ dòng được chọn
                    DataGridViewRow row = data_MedicalRecord.Rows[e.RowIndex];

                    // Lấy giá trị id_BA kiểu int
                    if (int.TryParse(row.Cells["ID_BA"].Value.ToString(), out id_BA))
                    {
                        ID_BA = id_BA;
                        panel2.Show();

                        // Lấy giá trị NgayKham từ cột Ngày khám
                        object cellValue = row.Cells["Ngày khám"].Value;
                        if (cellValue != null && DateTime.TryParse(cellValue.ToString(), out DateTime ngayKham))
                        {
                            dateTimePicker1.Value = ngayKham;
                        }

                        // Lấy giá trị từ cột "Dịch vụ"
                        object cellValueDichVu = row.Cells["Dịch vụ"].Value;

                        // Lấy giá trị từ cột "Thuốc"
                        object cellValueThuoc = row.Cells["Thuốc"].Value;

                        // Kiểm tra giá trị có là null không
                        if (cellValueDichVu != null && cellValueThuoc != null)
                        {
                            txt_DichVuMoi.Text = cellValueDichVu.ToString();
                            txt_ThuocMoi.Text = cellValueThuoc.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không đọc được thông tin mã bệnh án.", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Không có thông tin giá Dịch vụ và Thuốc.", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
        private void btn_ConfirmUpdate_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            NSProcessor.updateMedicalRecord(ID_NS, ID_BA, txt_DichVuMoi.Text, txt_ThuocMoi.Text, dateTimePicker1.Value);
            NSProcessor.loadMedicalData(data_MedicalRecord, ID_NS);
            ClearTextBoxesInPanel(panel2);
        }

        private void btn_AddRecord_Click_1(object sender, EventArgs e)
        {
            if (panel2.Visible)
            {
                MessageBox.Show("Vui lòng hoàn tất thao tác hiện tại hoặc ấn ESC quay lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            data_MedicalRecord.Hide();
            panel1.Show();
        }


        private void btn_ConfirmAdd_Click_1(object sender, EventArgs e)
        {
            string tenThuoc = txt_Thuoc.Text;
            string dichVu = txt_DichVu.Text;
            string phone = txt_SDT.Text;
            DateTime ngayKham = date_Kham.Value;

            // Kiểm tra điều kiện trống
            if (string.IsNullOrWhiteSpace(tenThuoc) || string.IsNullOrWhiteSpace(dichVu) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra ngày hết hạn
            if (ngayKham > DateTime.Now)
            {
                MessageBox.Show("Ngày khám phải là một ngày trong quá khứ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra số điện thoại
            if (!IsPhoneNumberValid(phone))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Số điện thoại phải có từ 7 đến 10 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng lại nếu có lỗi
            }

            NSProcessor.createMedicalRecord(ID_NS, phone, ngayKham, dichVu, tenThuoc);
            ClearTextBoxesInPanel(panel1);
            panel1.Hide();
            NSProcessor.loadMedicalData(data_MedicalRecord, ID_NS);
            data_MedicalRecord.Show();
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
        // Hàm kiểm tra số điện thoại có hợp lệ hay không
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            // Loại bỏ khoảng trắng và kiểm tra xem số ký tự còn lại có từ 7 đến 10 không
            return !string.IsNullOrWhiteSpace(phoneNumber) && phoneNumber.Length >= 7 && phoneNumber.Length <= 10 && phoneNumber.All(char.IsDigit);
        }
    }
}

