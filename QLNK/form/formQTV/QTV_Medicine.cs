using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNK.form.formQTV
{
    public partial class QTV_Medicine : Form
    {
        private int ID_QTV;
        public QTV_Medicine(int ma)
        {
            InitializeComponent();
            ID_QTV = ma;
            panel1.Hide();
            panel2.Hide();
            QTVprocessor.loadMedicineData(data_Medicine);
        }
        private void QTV_Medicine_FormClosed(object sender, FormClosedEventArgs e)
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
                data_Medicine.Show();
            }
            else
            {
                QTV f = new QTV(ID_QTV);
                f.Show();
                this.Hide();
            }
        }

        private void btn_AddMedicine_Click(object sender, EventArgs e)
        {
            //Trong trường hợp đang cập nhật thuốc thì lại chuyển qua thêm thuốc
            if (panel2.Visible)
            {
                MessageBox.Show("Vui lòng hoàn tất thao tác hiện tại hoặc ấn quay lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            data_Medicine.Hide();
            panel1.Show();
        }

        private void btn_ConfirmAdd_Click(object sender, EventArgs e)
        {
            string tenThuoc = txt_TenThuoc.Text;
            string donVi = txt_DonVi.Text;
            string chiDinh = txt_ChiDinh.Text;
            DateTime ngayHetHan = date_HetHan.Value;

            // Kiểm tra điều kiện trống
            if (string.IsNullOrWhiteSpace(tenThuoc) || string.IsNullOrWhiteSpace(donVi) || string.IsNullOrWhiteSpace(chiDinh))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra số lượng
            if (!int.TryParse(txt_SoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là một số nguyên dương", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra đơn giá
            if (!decimal.TryParse(txt_DonGia.Text, out decimal donGia) || donGia <= 1000)
            {
                MessageBox.Show("Đơn giá phải là một số lớn hơn 1000", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            QTVprocessor.addMedicine(tenThuoc, donVi, chiDinh, soLuong, donGia, ngayHetHan);
            ClearTextBoxesInPanel(panel1);
            panel1.Hide();
            QTVprocessor.loadMedicineData(data_Medicine);
            data_Medicine.Show();
        }

        private void btn_EditMedicine_Click(object sender, EventArgs e)
        {
            //Trong trường hợp đang thêm thuốc thì lại chuyển qua cập nhật số lượng
            if(panel1.Visible)
            {
                MessageBox.Show("Vui lòng hoàn tất thao tác hiện tại hoặc ấn quay lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            panel2.Show();
        }
        private void btn_ConfirmUpdate_Click(object sender, EventArgs e)
        {
            int idThuoc = 0;
            int soLuong1 = 0, soLuong2 = 0;
            if (!int.TryParse(txt_IDThuoc.Text, out idThuoc) && idThuoc < 0)
            {
                MessageBox.Show("ID thuốc phải là số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.TryParse(txt_SoLuongMoi1.Text, out soLuong1) && int.TryParse(txt_SoLuongMoi2.Text, out soLuong2))
            {
                if (soLuong1 != soLuong2)
                {
                    MessageBox.Show("Xác nhận lại số lượng phải giống nhau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (soLuong1 < 0)
                {
                    MessageBox.Show("Số lượng phải là một số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Số lượng phải là một số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            QTVprocessor.editQuantity(idThuoc, soLuong1);
            ClearTextBoxesInPanel(panel2);
            panel2.Hide();
            QTVprocessor.loadMedicineData(data_Medicine);
        }

        private void btn_DeleteMedicine_Click(object sender, EventArgs e)
        {
            //Trong trường hợp đang thêm thuốc hoặc cập nhật thuốc thì lại chuyển qua yêu càu xóa thuốc
            if (panel1.Visible || panel2.Visible)
            {
                MessageBox.Show("Vui lòng hoàn tất thao tác hiện tại hoặc ấn quay lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            QTVprocessor.deleteMedicine();
            QTVprocessor.loadMedicineData(data_Medicine);
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
    }
}
