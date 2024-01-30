namespace QLNK.form.formNV
{
    partial class NV_Appointment
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
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_toKHAppointment = new System.Windows.Forms.Button();
            this.txt_Location = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.data_Appointment = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LH_done = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Appointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LH_done)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(9, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 32);
            this.label3.TabIndex = 46;
            this.label3.Text = "Ngày sinh";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 341);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(480, 38);
            this.dateTimePicker1.TabIndex = 44;
            // 
            // btn_toKHAppointment
            // 
            this.btn_toKHAppointment.BackColor = System.Drawing.Color.Lavender;
            this.btn_toKHAppointment.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_toKHAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_toKHAppointment.Location = new System.Drawing.Point(50, 399);
            this.btn_toKHAppointment.Name = "btn_toKHAppointment";
            this.btn_toKHAppointment.Size = new System.Drawing.Size(406, 54);
            this.btn_toKHAppointment.TabIndex = 45;
            this.btn_toKHAppointment.Text = "Đăng ký thông tin";
            this.btn_toKHAppointment.UseVisualStyleBackColor = false;
            this.btn_toKHAppointment.Click += new System.EventHandler(this.btn_toKHAppointment_Click);
            // 
            // txt_Location
            // 
            this.txt_Location.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Location.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Location.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_Location.Location = new System.Drawing.Point(11, 252);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.PlaceholderText = "Địa chỉ";
            this.txt_Location.Size = new System.Drawing.Size(480, 38);
            this.txt_Location.TabIndex = 43;
            // 
            // txt_Phone
            // 
            this.txt_Phone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Phone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_Phone.Location = new System.Drawing.Point(11, 182);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.PlaceholderText = "Số điện thoại (tài khoản)";
            this.txt_Phone.Size = new System.Drawing.Size(480, 38);
            this.txt_Phone.TabIndex = 42;
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_Name.Location = new System.Drawing.Point(11, 117);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PlaceholderText = "Họ và Tên";
            this.txt_Name.Size = new System.Drawing.Size(480, 38);
            this.txt_Name.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 65);
            this.label1.TabIndex = 40;
            this.label1.Text = "Đăng ký thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(675, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(446, 65);
            this.label2.TabIndex = 47;
            this.label2.Text = "Đăng ký lịch khám";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.pictureBox1.Location = new System.Drawing.Point(518, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // data_Appointment
            // 
            this.data_Appointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data_Appointment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_Appointment.BackgroundColor = System.Drawing.Color.White;
            this.data_Appointment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_Appointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Appointment.Location = new System.Drawing.Point(544, 163);
            this.data_Appointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_Appointment.MultiSelect = false;
            this.data_Appointment.Name = "data_Appointment";
            this.data_Appointment.ReadOnly = true;
            this.data_Appointment.RowHeadersWidth = 40;
            this.data_Appointment.RowTemplate.Height = 37;
            this.data_Appointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_Appointment.Size = new System.Drawing.Size(728, 270);
            this.data_Appointment.TabIndex = 49;
            this.data_Appointment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Appointment_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 32);
            this.label4.TabIndex = 50;
            this.label4.Text = "Lịch hẹn có thể đặt:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 32);
            this.label5.TabIndex = 51;
            this.label5.Text = "Các lịch hẹn đã đặt";
            // 
            // LH_done
            // 
            this.LH_done.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.LH_done.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.LH_done.BackgroundColor = System.Drawing.Color.White;
            this.LH_done.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LH_done.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LH_done.Location = new System.Drawing.Point(231, 537);
            this.LH_done.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LH_done.MultiSelect = false;
            this.LH_done.Name = "LH_done";
            this.LH_done.ReadOnly = true;
            this.LH_done.RowHeadersWidth = 40;
            this.LH_done.RowTemplate.Height = 37;
            this.LH_done.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LH_done.Size = new System.Drawing.Size(836, 246);
            this.LH_done.TabIndex = 52;
            this.LH_done.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LH_done_CellContentDoubleClick);
            // 
            // NV_Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 794);
            this.Controls.Add(this.LH_done);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.data_Appointment);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_toKHAppointment);
            this.Controls.Add(this.txt_Location);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NV_Appointment";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NV_Appointment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NV_Appointment_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Appointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LH_done)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button btn_toKHAppointment;
        private TextBox txt_Location;
        private TextBox txt_Phone;
        private TextBox txt_Name;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private DataGridView data_Appointment;
        private Label label4;
        private Label label5;
        private DataGridView LH_done;
    }
}