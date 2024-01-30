namespace QLNK.form.formNS
{
    partial class NS_Schedule
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
            this.btn_AddRecord = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ConfirmAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.date_Kham = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_GioKham = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGioKham_1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_ConfirmUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.data_ScheduleRecord = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_ScheduleRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddRecord
            // 
            this.btn_AddRecord.BackColor = System.Drawing.Color.Lavender;
            this.btn_AddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddRecord.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AddRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_AddRecord.Location = new System.Drawing.Point(923, 106);
            this.btn_AddRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddRecord.Name = "btn_AddRecord";
            this.btn_AddRecord.Size = new System.Drawing.Size(253, 52);
            this.btn_AddRecord.TabIndex = 3;
            this.btn_AddRecord.Text = "Thêm lịch hẹn mới";
            this.btn_AddRecord.UseVisualStyleBackColor = false;
            this.btn_AddRecord.Click += new System.EventHandler(this.btn_AddRecord_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_ConfirmAdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.date_Kham);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_GioKham);
            this.panel1.Location = new System.Drawing.Point(607, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 368);
            this.panel1.TabIndex = 52;
            // 
            // btn_ConfirmAdd
            // 
            this.btn_ConfirmAdd.BackColor = System.Drawing.Color.Lavender;
            this.btn_ConfirmAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ConfirmAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ConfirmAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_ConfirmAdd.Location = new System.Drawing.Point(219, 291);
            this.btn_ConfirmAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ConfirmAdd.Name = "btn_ConfirmAdd";
            this.btn_ConfirmAdd.Size = new System.Drawing.Size(137, 47);
            this.btn_ConfirmAdd.TabIndex = 11;
            this.btn_ConfirmAdd.Text = "Xác nhận";
            this.btn_ConfirmAdd.UseVisualStyleBackColor = false;
            this.btn_ConfirmAdd.Click += new System.EventHandler(this.btn_ConfirmAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(52, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 32);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ngày khám";
            // 
            // date_Kham
            // 
            this.date_Kham.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.date_Kham.CalendarMonthBackground = System.Drawing.Color.RosyBrown;
            this.date_Kham.Location = new System.Drawing.Point(54, 136);
            this.date_Kham.Name = "date_Kham";
            this.date_Kham.Size = new System.Drawing.Size(458, 38);
            this.date_Kham.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label5.Location = new System.Drawing.Point(147, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 32);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nhập thông tin lịch hẹn";
            // 
            // txt_GioKham
            // 
            this.txt_GioKham.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_GioKham.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_GioKham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_GioKham.Location = new System.Drawing.Point(54, 219);
            this.txt_GioKham.Name = "txt_GioKham";
            this.txt_GioKham.PlaceholderText = "Giờ khám (hh:mm:ss)";
            this.txt_GioKham.Size = new System.Drawing.Size(458, 38);
            this.txt_GioKham.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtGioKham_1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.btn_ConfirmUpdate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(88, 554);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 104);
            this.panel2.TabIndex = 51;
            // 
            // txtGioKham_1
            // 
            this.txtGioKham_1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGioKham_1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGioKham_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txtGioKham_1.Location = new System.Drawing.Point(366, 41);
            this.txtGioKham_1.Name = "txtGioKham_1";
            this.txtGioKham_1.PlaceholderText = "Giờ khám (hh:mm:ss)";
            this.txtGioKham_1.Size = new System.Drawing.Size(421, 38);
            this.txtGioKham_1.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(296, 38);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // btn_ConfirmUpdate
            // 
            this.btn_ConfirmUpdate.BackColor = System.Drawing.Color.Lavender;
            this.btn_ConfirmUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ConfirmUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ConfirmUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_ConfirmUpdate.Location = new System.Drawing.Point(834, 36);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 32);
            this.label1.TabIndex = 50;
            this.label1.Text = "Bảng thông tin lịch hẹn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(281, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(627, 65);
            this.label2.TabIndex = 49;
            this.label2.Text = "Thông tin lịch hẹn của bạn";
            // 
            // data_ScheduleRecord
            // 
            this.data_ScheduleRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data_ScheduleRecord.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_ScheduleRecord.BackgroundColor = System.Drawing.Color.White;
            this.data_ScheduleRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_ScheduleRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ScheduleRecord.Location = new System.Drawing.Point(70, 180);
            this.data_ScheduleRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_ScheduleRecord.MultiSelect = false;
            this.data_ScheduleRecord.Name = "data_ScheduleRecord";
            this.data_ScheduleRecord.ReadOnly = true;
            this.data_ScheduleRecord.RowHeadersWidth = 40;
            this.data_ScheduleRecord.RowTemplate.Height = 37;
            this.data_ScheduleRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_ScheduleRecord.Size = new System.Drawing.Size(1070, 354);
            this.data_ScheduleRecord.TabIndex = 48;
            this.data_ScheduleRecord.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_ScheduleRecord_CellContentDoubleClick);
            // 
            // NS_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1230, 673);
            this.Controls.Add(this.btn_AddRecord);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data_ScheduleRecord);
            this.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NS_Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch cá nhân";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NS_Schedule_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_ScheduleRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_AddRecord;
        private Panel panel1;
        private Button btn_ConfirmAdd;
        private Label label4;
        private DateTimePicker date_Kham;
        private Label label5;
        private TextBox txt_GioKham;
        private Panel panel2;
        private DateTimePicker dateTimePicker1;
        private Button btn_ConfirmUpdate;
        private Label label6;
        private Label label1;
        private Label label2;
        private DataGridView data_ScheduleRecord;
        private TextBox txtGioKham_1;
    }
}