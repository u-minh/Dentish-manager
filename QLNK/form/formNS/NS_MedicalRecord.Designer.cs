namespace QLNK.form.formNS
{
    partial class NS_MedicalRecord
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Find = new System.Windows.Forms.Button();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.data_MedicalRecord = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_ThuocMoi = new System.Windows.Forms.TextBox();
            this.btn_ConfirmUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_DichVuMoi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ConfirmAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.date_Kham = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Thuoc = new System.Windows.Forms.TextBox();
            this.txt_DichVu = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.btn_AddRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_MedicalRecord)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 32);
            this.label1.TabIndex = 39;
            this.label1.Text = "Bảng thông tin bệnh án";
            // 
            // btn_Find
            // 
            this.btn_Find.BackColor = System.Drawing.Color.Lavender;
            this.btn_Find.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Find.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Find.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_Find.Location = new System.Drawing.Point(978, 92);
            this.btn_Find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(148, 39);
            this.btn_Find.TabIndex = 4;
            this.btn_Find.Text = "Tìm kiếm";
            this.btn_Find.UseVisualStyleBackColor = false;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click_1);
            // 
            // txt_Phone
            // 
            this.txt_Phone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Phone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_Phone.Location = new System.Drawing.Point(770, 92);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.PlaceholderText = "Số điện thoại";
            this.txt_Phone.Size = new System.Drawing.Size(201, 38);
            this.txt_Phone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(286, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(514, 65);
            this.label2.TabIndex = 36;
            this.label2.Text = "Thông tin khám bệnh";
            // 
            // data_MedicalRecord
            // 
            this.data_MedicalRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data_MedicalRecord.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_MedicalRecord.BackgroundColor = System.Drawing.Color.White;
            this.data_MedicalRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_MedicalRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_MedicalRecord.Location = new System.Drawing.Point(35, 166);
            this.data_MedicalRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_MedicalRecord.MultiSelect = false;
            this.data_MedicalRecord.Name = "data_MedicalRecord";
            this.data_MedicalRecord.ReadOnly = true;
            this.data_MedicalRecord.RowHeadersWidth = 40;
            this.data_MedicalRecord.RowTemplate.Height = 37;
            this.data_MedicalRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_MedicalRecord.Size = new System.Drawing.Size(1070, 354);
            this.data_MedicalRecord.TabIndex = 35;
            this.data_MedicalRecord.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_MedicalRecord_CellContentDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.txt_ThuocMoi);
            this.panel2.Controls.Add(this.btn_ConfirmUpdate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_DichVuMoi);
            this.panel2.Location = new System.Drawing.Point(53, 555);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 89);
            this.panel2.TabIndex = 43;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(533, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(296, 38);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // txt_ThuocMoi
            // 
            this.txt_ThuocMoi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ThuocMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_ThuocMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_ThuocMoi.Location = new System.Drawing.Point(255, 34);
            this.txt_ThuocMoi.Name = "txt_ThuocMoi";
            this.txt_ThuocMoi.PlaceholderText = "Thuốc";
            this.txt_ThuocMoi.Size = new System.Drawing.Size(259, 38);
            this.txt_ThuocMoi.TabIndex = 14;
            // 
            // btn_ConfirmUpdate
            // 
            this.btn_ConfirmUpdate.BackColor = System.Drawing.Color.Lavender;
            this.btn_ConfirmUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ConfirmUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ConfirmUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_ConfirmUpdate.Location = new System.Drawing.Point(844, 29);
            this.btn_ConfirmUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ConfirmUpdate.Name = "btn_ConfirmUpdate";
            this.btn_ConfirmUpdate.Size = new System.Drawing.Size(137, 47);
            this.btn_ConfirmUpdate.TabIndex = 16;
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
            this.label6.Size = new System.Drawing.Size(230, 32);
            this.label6.TabIndex = 28;
            this.label6.Text = "Nhập thông tin mới";
            // 
            // txt_DichVuMoi
            // 
            this.txt_DichVuMoi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_DichVuMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_DichVuMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_DichVuMoi.Location = new System.Drawing.Point(12, 34);
            this.txt_DichVuMoi.Name = "txt_DichVuMoi";
            this.txt_DichVuMoi.PlaceholderText = "Dịch vụ ";
            this.txt_DichVuMoi.Size = new System.Drawing.Size(221, 38);
            this.txt_DichVuMoi.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_ConfirmAdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.date_Kham);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_Thuoc);
            this.panel1.Controls.Add(this.txt_DichVu);
            this.panel1.Controls.Add(this.txt_SDT);
            this.panel1.Location = new System.Drawing.Point(272, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 402);
            this.panel1.TabIndex = 44;
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
            this.btn_ConfirmAdd.Click += new System.EventHandler(this.btn_ConfirmAdd_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(52, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 32);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ngày khám";
            // 
            // date_Kham
            // 
            this.date_Kham.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.date_Kham.CalendarMonthBackground = System.Drawing.Color.RosyBrown;
            this.date_Kham.Location = new System.Drawing.Point(54, 272);
            this.date_Kham.Name = "date_Kham";
            this.date_Kham.Size = new System.Drawing.Size(458, 38);
            this.date_Kham.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label5.Location = new System.Drawing.Point(129, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 32);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nhập thông tin bệnh án";
            // 
            // txt_Thuoc
            // 
            this.txt_Thuoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Thuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Thuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_Thuoc.Location = new System.Drawing.Point(54, 181);
            this.txt_Thuoc.Name = "txt_Thuoc";
            this.txt_Thuoc.PlaceholderText = "Thuốc";
            this.txt_Thuoc.Size = new System.Drawing.Size(458, 38);
            this.txt_Thuoc.TabIndex = 9;
            // 
            // txt_DichVu
            // 
            this.txt_DichVu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_DichVu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_DichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_DichVu.Location = new System.Drawing.Point(54, 115);
            this.txt_DichVu.Name = "txt_DichVu";
            this.txt_DichVu.PlaceholderText = "Dịch vụ";
            this.txt_DichVu.Size = new System.Drawing.Size(458, 38);
            this.txt_DichVu.TabIndex = 6;
            // 
            // txt_SDT
            // 
            this.txt_SDT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_SDT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_SDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_SDT.Location = new System.Drawing.Point(54, 52);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.PlaceholderText = "SDT khách hàng";
            this.txt_SDT.Size = new System.Drawing.Size(458, 38);
            this.txt_SDT.TabIndex = 5;
            // 
            // btn_AddRecord
            // 
            this.btn_AddRecord.BackColor = System.Drawing.Color.Lavender;
            this.btn_AddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddRecord.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AddRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_AddRecord.Location = new System.Drawing.Point(413, 92);
            this.btn_AddRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddRecord.Name = "btn_AddRecord";
            this.btn_AddRecord.Size = new System.Drawing.Size(253, 39);
            this.btn_AddRecord.TabIndex = 45;
            this.btn_AddRecord.Text = "Thêm bệnh án mới";
            this.btn_AddRecord.UseVisualStyleBackColor = false;
            this.btn_AddRecord.Click += new System.EventHandler(this.btn_AddRecord_Click_1);
            // 
            // NS_MedicalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 651);
            this.Controls.Add(this.btn_AddRecord);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data_MedicalRecord);
            this.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NS_MedicalRecord";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hồ sơ bệnh án";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NS_MedicalRecord_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.data_MedicalRecord)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_Find;
        private TextBox txt_Phone;
        private Label label2;
        private DataGridView data_MedicalRecord;
        private Panel panel2;
        private TextBox txt_ThuocMoi;
        private Button btn_ConfirmUpdate;
        private Label label6;
        private TextBox txt_DichVuMoi;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private Button btn_ConfirmAdd;
        private Label label4;
        private DateTimePicker date_Kham;
        private Label label5;
        private TextBox txt_Thuoc;
        private TextBox txt_DichVu;
        private TextBox txt_SDT;
        private Button btn_AddRecord;
    }
}