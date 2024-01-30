using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNK.form.formNS
{
    public partial class NS_Schedule : Form
    {
        int ID_NS;
        public NS_Schedule(int ma)
        {
            ID_NS = ma;
            InitializeComponent();

            this.KeyDown += NS_Schedule_keydown;
            // Đảm bảo form có Focus để nhận sự kiện KeyDown
            this.Focus();
            this.KeyPreview = true;

            panel1.Hide();
            panel2.Hide();
            NSProcessor.loadSchedule(data_ScheduleRecord, ID_NS);
        }

        private void NS_Schedule_keydown(object sender, KeyEventArgs e)
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
                    data_ScheduleRecord.Show();
                }
                else
                {
                    NS f = new NS(ID_NS);
                    f.Show();
                    this.Hide();
                }
            }
        }

        private void NS_Schedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            NS f = new NS(ID_NS);
            f.Show();
            this.Hide();
        }

        private void btn_AddRecord_Click(object sender, EventArgs e)
        {
            if (panel2.Visible)
            {
                MessageBox.Show("Vui lòng hoàn tất thao tác hiện tại hoặc ấn ESC quay lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            panel1.Show();
        }


        private void btn_ConfirmAdd_Click(object sender, EventArgs e)
        {
            DateTime ngayKham = date_Kham.Value;
            TimeSpan gioKham;
            // Kiểm tra điều kiện trống
            if (string.IsNullOrWhiteSpace(txt_GioKham.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (!ConvertToTimeSpan(txt_GioKham.Text, out gioKham))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng cho giờ khám", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Kiểm tra ngày khám
            if (ngayKham < DateTime.Now)
            {
                MessageBox.Show("Ngày khám phải là một ngày trong tương lai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NSProcessor.addSchedule(ID_NS, ngayKham, gioKham);
            ClearTextBoxesInPanel(panel1);
            panel1.Hide();
            NSProcessor.loadSchedule(data_ScheduleRecord, ID_NS);
        }

        //Biến cần dùng ở chức năng sửa lịch hẹn
        DateTime _ngayKham;
        TimeSpan _gioKham = TimeSpan.Zero;
        private void data_ScheduleRecord_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(panel1.Visible || panel2.Visible)
            {
                MessageBox.Show("Vui lòng hoàn tất thao tác hiện tại hoặc ấn ESC quay lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Kiểm tra xem có phải là dòng dữ liệu không
                if (e.RowIndex >= 0)
                {
                    // Lấy giá trị từ dòng được chọn
                    DataGridViewRow row = data_ScheduleRecord.Rows[e.RowIndex];

                    // Kiểm tra không có mã khách hàng mới thực hiện chỉnh sửa
                    if (!int.TryParse(row.Cells["Mã khách hẹn"].Value.ToString(), out int maKH))
                    {
                        panel2.Show();

                        // Lấy giá trị NgayKham từ cột Ngày khám
                        object cellValue = row.Cells["Ngày khám"].Value;
                        if (cellValue != null && DateTime.TryParse(cellValue.ToString(), out _ngayKham))
                        {
                            dateTimePicker1.Value = _ngayKham;
                        }

                        object cellValueGioKham = row.Cells["Giờ khám"].Value;

                        if (cellValueGioKham != null && ConvertToTimeSpan(cellValueGioKham.ToString(), out _gioKham))
                        {
                            txtGioKham_1.Text = cellValueGioKham.ToString();
                        }
                        else
                        {
                            txtGioKham_1.Text = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Lịch hẹn đã được đặt bởi khách hàng {maKH}, không được chỉnh sửa.", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Không có thông tin lịch hẹn.", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btn_ConfirmUpdate_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            if (ConvertToTimeSpan(txtGioKham_1.Text, out TimeSpan gioKham))
            {
                NSProcessor.editSchedule(ID_NS, dateTimePicker1.Value, gioKham, _ngayKham, _gioKham);
                NSProcessor.loadSchedule(data_ScheduleRecord, ID_NS);
                ClearTextBoxesInPanel(panel2);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng giờ khám.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
        static bool ConvertToTimeSpan(string timeString, out TimeSpan timeSpan)
        {
            // Phân tích chuỗi thành các thành phần thời gian
            string[] timeComponents = timeString.Split(':');

            if (timeComponents.Length == 3)
            {
                // Lấy giờ, phút và giây từ chuỗi
                int hours = int.Parse(timeComponents[0]);
                int minutes = int.Parse(timeComponents[1]);
                int seconds = int.Parse(timeComponents[2]);

                // Tạo đối tượng TimeSpan
                timeSpan = new TimeSpan(hours, minutes, seconds);
                return true;
            }
            else
            {
                timeSpan = TimeSpan.Zero;
                return false;
            }
        }

    }
}
