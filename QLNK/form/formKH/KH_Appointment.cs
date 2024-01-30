using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNK.form.formKH
{
    public partial class KH_Appointment : Form
    {
        private int ID_KH;
        public KH_Appointment(int ma)
        {
            InitializeComponent();
            ID_KH = ma;
            this.KeyDown += KH_Appointment_KeyDown;
            // Đảm bảo form có Focus để nhận sự kiện KeyDown
            this.Focus();
            this.KeyPreview = true;
            KHProcessor.loadAppointmentData(data_Appointment);
            KHProcessor.loadScheduleData(LH_done, ID_KH);

        }

        private void KH_Appointment_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra nếu phím được nhấn là phím Esc
            if (e.KeyCode == Keys.Escape)
            {
                KH f = new KH(ID_KH);
                f.Show();
                this.Hide();
            }
        }

        private void KH_Appointment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void data_Appointment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                                        KHProcessor.insertAppointment(ngayKham,gioKham, idNhaSi, ID_KH);
                                        KHProcessor.loadAppointmentData(data_Appointment);
                                        KHProcessor.loadScheduleData(LH_done, ID_KH);
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
}
