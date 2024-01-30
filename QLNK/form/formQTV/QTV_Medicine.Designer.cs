using System.Windows.Forms;

namespace QLNK.form.formQTV
{
    partial class QTV_Medicine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Return = new System.Windows.Forms.Button();
            this.data_Medicine = new System.Windows.Forms.DataGridView();
            this.btn_AddMedicine = new System.Windows.Forms.Button();
            this.btn_DeleteMedicine = new System.Windows.Forms.Button();
            this.btn_EditMedicine = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ConfirmAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.date_HetHan = new System.Windows.Forms.DateTimePicker();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ChiDinh = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_DonVi = new System.Windows.Forms.TextBox();
            this.txt_TenThuoc = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_SoLuongMoi2 = new System.Windows.Forms.TextBox();
            this.btn_ConfirmUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SoLuongMoi1 = new System.Windows.Forms.TextBox();
            this.txt_IDThuoc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_Medicine)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Return
            // 
            this.btn_Return.BackColor = System.Drawing.Color.Lavender;
            this.btn_Return.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Return.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Return.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_Return.Location = new System.Drawing.Point(730, 10);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(137, 47);
            this.btn_Return.TabIndex = 4;
            this.btn_Return.Text = "Quay lại";
            this.btn_Return.UseVisualStyleBackColor = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // data_Medicine
            // 
            this.data_Medicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data_Medicine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_Medicine.BackgroundColor = System.Drawing.Color.White;
            this.data_Medicine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_Medicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Medicine.Location = new System.Drawing.Point(25, 103);
            this.data_Medicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_Medicine.MultiSelect = false;
            this.data_Medicine.Name = "data_Medicine";
            this.data_Medicine.ReadOnly = true;
            this.data_Medicine.RowHeadersWidth = 40;
            this.data_Medicine.RowTemplate.Height = 37;
            this.data_Medicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_Medicine.Size = new System.Drawing.Size(842, 465);
            this.data_Medicine.TabIndex = 5;
            // 
            // btn_AddMedicine
            // 
            this.btn_AddMedicine.BackColor = System.Drawing.Color.Lavender;
            this.btn_AddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddMedicine.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AddMedicine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_AddMedicine.Location = new System.Drawing.Point(25, 10);
            this.btn_AddMedicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddMedicine.Name = "btn_AddMedicine";
            this.btn_AddMedicine.Size = new System.Drawing.Size(159, 47);
            this.btn_AddMedicine.TabIndex = 1;
            this.btn_AddMedicine.Text = "Thêm Thuốc";
            this.btn_AddMedicine.UseVisualStyleBackColor = false;
            this.btn_AddMedicine.Click += new System.EventHandler(this.btn_AddMedicine_Click);
            // 
            // btn_DeleteMedicine
            // 
            this.btn_DeleteMedicine.BackColor = System.Drawing.Color.Lavender;
            this.btn_DeleteMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DeleteMedicine.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DeleteMedicine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_DeleteMedicine.Location = new System.Drawing.Point(210, 11);
            this.btn_DeleteMedicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DeleteMedicine.Name = "btn_DeleteMedicine";
            this.btn_DeleteMedicine.Size = new System.Drawing.Size(244, 47);
            this.btn_DeleteMedicine.TabIndex = 2;
            this.btn_DeleteMedicine.Text = "Xóa thuốc hết hạn";
            this.btn_DeleteMedicine.UseVisualStyleBackColor = false;
            this.btn_DeleteMedicine.Click += new System.EventHandler(this.btn_DeleteMedicine_Click);
            // 
            // btn_EditMedicine
            // 
            this.btn_EditMedicine.BackColor = System.Drawing.Color.Lavender;
            this.btn_EditMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EditMedicine.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_EditMedicine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_EditMedicine.Location = new System.Drawing.Point(486, 10);
            this.btn_EditMedicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_EditMedicine.Name = "btn_EditMedicine";
            this.btn_EditMedicine.Size = new System.Drawing.Size(213, 47);
            this.btn_EditMedicine.TabIndex = 3;
            this.btn_EditMedicine.Text = "Sửa số lượng Thuốc";
            this.btn_EditMedicine.UseVisualStyleBackColor = false;
            this.btn_EditMedicine.Click += new System.EventHandler(this.btn_EditMedicine_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_ConfirmAdd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.date_HetHan);
            this.panel1.Controls.Add(this.txt_DonGia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_ChiDinh);
            this.panel1.Controls.Add(this.txt_SoLuong);
            this.panel1.Controls.Add(this.txt_DonVi);
            this.panel1.Controls.Add(this.txt_TenThuoc);
            this.panel1.Location = new System.Drawing.Point(152, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 402);
            this.panel1.TabIndex = 6;
            // 
            // btn_ConfirmAdd
            // 
            this.btn_ConfirmAdd.BackColor = System.Drawing.Color.Lavender;
            this.btn_ConfirmAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ConfirmAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ConfirmAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_ConfirmAdd.Location = new System.Drawing.Point(209, 336);
            this.btn_ConfirmAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ConfirmAdd.Name = "btn_ConfirmAdd";
            this.btn_ConfirmAdd.Size = new System.Drawing.Size(137, 47);
            this.btn_ConfirmAdd.TabIndex = 11;
            this.btn_ConfirmAdd.Text = "Xác nhận";
            this.btn_ConfirmAdd.UseVisualStyleBackColor = false;
            this.btn_ConfirmAdd.Click += new System.EventHandler(this.btn_ConfirmAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(52, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 32);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ngày hết hạn";
            // 
            // date_HetHan
            // 
            this.date_HetHan.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.date_HetHan.CalendarMonthBackground = System.Drawing.Color.RosyBrown;
            this.date_HetHan.Location = new System.Drawing.Point(54, 272);
            this.date_HetHan.Name = "date_HetHan";
            this.date_HetHan.Size = new System.Drawing.Size(458, 33);
            this.date_HetHan.TabIndex = 10;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_DonGia.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_DonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_DonGia.Location = new System.Drawing.Point(377, 115);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.PlaceholderText = "Đơn giá";
            this.txt_DonGia.Size = new System.Drawing.Size(135, 38);
            this.txt_DonGia.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(140, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nhập thông tin thuốc";
            // 
            // txt_ChiDinh
            // 
            this.txt_ChiDinh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ChiDinh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_ChiDinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_ChiDinh.Location = new System.Drawing.Point(54, 181);
            this.txt_ChiDinh.Name = "txt_ChiDinh";
            this.txt_ChiDinh.PlaceholderText = "Chỉ định";
            this.txt_ChiDinh.Size = new System.Drawing.Size(458, 38);
            this.txt_ChiDinh.TabIndex = 9;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_SoLuong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_SoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_SoLuong.Location = new System.Drawing.Point(209, 115);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.PlaceholderText = "Số lượng tồn";
            this.txt_SoLuong.Size = new System.Drawing.Size(162, 38);
            this.txt_SoLuong.TabIndex = 7;
            // 
            // txt_DonVi
            // 
            this.txt_DonVi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_DonVi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_DonVi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_DonVi.Location = new System.Drawing.Point(54, 115);
            this.txt_DonVi.Name = "txt_DonVi";
            this.txt_DonVi.PlaceholderText = "Đơn vị tính";
            this.txt_DonVi.Size = new System.Drawing.Size(149, 38);
            this.txt_DonVi.TabIndex = 6;
            // 
            // txt_TenThuoc
            // 
            this.txt_TenThuoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_TenThuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_TenThuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_TenThuoc.Location = new System.Drawing.Point(54, 52);
            this.txt_TenThuoc.Name = "txt_TenThuoc";
            this.txt_TenThuoc.PlaceholderText = "Tên thuốc";
            this.txt_TenThuoc.Size = new System.Drawing.Size(458, 38);
            this.txt_TenThuoc.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_SoLuongMoi2);
            this.panel2.Controls.Add(this.btn_ConfirmUpdate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_SoLuongMoi1);
            this.panel2.Controls.Add(this.txt_IDThuoc);
            this.panel2.Location = new System.Drawing.Point(12, 478);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 89);
            this.panel2.TabIndex = 32;
            // 
            // txt_SoLuongMoi2
            // 
            this.txt_SoLuongMoi2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_SoLuongMoi2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_SoLuongMoi2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_SoLuongMoi2.Location = new System.Drawing.Point(440, 34);
            this.txt_SoLuongMoi2.Name = "txt_SoLuongMoi2";
            this.txt_SoLuongMoi2.PlaceholderText = "Xác nhận số lượng";
            this.txt_SoLuongMoi2.Size = new System.Drawing.Size(227, 38);
            this.txt_SoLuongMoi2.TabIndex = 14;
            // 
            // btn_ConfirmUpdate
            // 
            this.btn_ConfirmUpdate.BackColor = System.Drawing.Color.Lavender;
            this.btn_ConfirmUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ConfirmUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ConfirmUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_ConfirmUpdate.Location = new System.Drawing.Point(717, 29);
            this.btn_ConfirmUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ConfirmUpdate.Name = "btn_ConfirmUpdate";
            this.btn_ConfirmUpdate.Size = new System.Drawing.Size(137, 47);
            this.btn_ConfirmUpdate.TabIndex = 15;
            this.btn_ConfirmUpdate.Text = "Xác nhận";
            this.btn_ConfirmUpdate.UseVisualStyleBackColor = false;
            this.btn_ConfirmUpdate.Click += new System.EventHandler(this.btn_ConfirmUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label6.Location = new System.Drawing.Point(3, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 32);
            this.label6.TabIndex = 28;
            this.label6.Text = "Nhập thông tin thuốc";
            // 
            // txt_SoLuongMoi1
            // 
            this.txt_SoLuongMoi1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_SoLuongMoi1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_SoLuongMoi1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_SoLuongMoi1.Location = new System.Drawing.Point(230, 34);
            this.txt_SoLuongMoi1.Name = "txt_SoLuongMoi1";
            this.txt_SoLuongMoi1.PlaceholderText = "Số lượng mới";
            this.txt_SoLuongMoi1.Size = new System.Drawing.Size(162, 38);
            this.txt_SoLuongMoi1.TabIndex = 13;
            // 
            // txt_IDThuoc
            // 
            this.txt_IDThuoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_IDThuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_IDThuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_IDThuoc.Location = new System.Drawing.Point(12, 34);
            this.txt_IDThuoc.Name = "txt_IDThuoc";
            this.txt_IDThuoc.PlaceholderText = "ID thuốc";
            this.txt_IDThuoc.Size = new System.Drawing.Size(172, 38);
            this.txt_IDThuoc.TabIndex = 12;
            // 
            // QTV_Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_Return;
            this.ClientSize = new System.Drawing.Size(893, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_EditMedicine);
            this.Controls.Add(this.btn_DeleteMedicine);
            this.Controls.Add(this.btn_AddMedicine);
            this.Controls.Add(this.data_Medicine);
            this.Controls.Add(this.btn_Return);
            this.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QTV_Medicine";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thuốc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QTV_Medicine_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.data_Medicine)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Return;
        private DataGridView data_Medicine;
        private Button btn_AddMedicine;
        private Button btn_DeleteMedicine;
        private Button btn_EditMedicine;
        private Panel panel1;
        private Label label1;
        private TextBox txt_ChiDinh;
        private TextBox txt_SoLuong;
        private TextBox txt_DonVi;
        private TextBox txt_TenThuoc;
        private TextBox txt_DonGia;
        private Button btn_ConfirmAdd;
        private Label label2;
        private DateTimePicker date_HetHan;
        private Panel panel2;
        private TextBox txt_SoLuongMoi2;
        private Button btn_ConfirmUpdate;
        private Label label6;
        private TextBox txt_SoLuongMoi1;
        private TextBox txt_IDThuoc;
    }
}