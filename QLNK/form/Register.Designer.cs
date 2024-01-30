namespace QLNK
{
    partial class Register
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
            this.btn_Register = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Location = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_toLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.Lavender;
            this.btn_Register.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_Register.Location = new System.Drawing.Point(59, 448);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(375, 52);
            this.btn_Register.TabIndex = 25;
            this.btn_Register.Text = "Đăng ký";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_Password.Location = new System.Drawing.Point(23, 239);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PlaceholderText = "Mật khẩu";
            this.txt_Password.Size = new System.Drawing.Size(443, 38);
            this.txt_Password.TabIndex = 22;
            // 
            // txt_Location
            // 
            this.txt_Location.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Location.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Location.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_Location.Location = new System.Drawing.Point(23, 305);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.PlaceholderText = "Địa chỉ";
            this.txt_Location.Size = new System.Drawing.Size(443, 38);
            this.txt_Location.TabIndex = 23;
            // 
            // txt_Phone
            // 
            this.txt_Phone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Phone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_Phone.Location = new System.Drawing.Point(23, 173);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.PlaceholderText = "Số điện thoại (tài khoản)";
            this.txt_Phone.Size = new System.Drawing.Size(443, 38);
            this.txt_Phone.TabIndex = 21;
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_Name.Location = new System.Drawing.Point(23, 110);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PlaceholderText = "Họ và Tên";
            this.txt_Name.Size = new System.Drawing.Size(443, 38);
            this.txt_Name.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 65);
            this.label1.TabIndex = 19;
            this.label1.Text = "Đăng ký";
            // 
            // btn_toLogin
            // 
            this.btn_toLogin.BackColor = System.Drawing.Color.Lavender;
            this.btn_toLogin.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_toLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_toLogin.Location = new System.Drawing.Point(59, 538);
            this.btn_toLogin.Name = "btn_toLogin";
            this.btn_toLogin.Size = new System.Drawing.Size(375, 52);
            this.btn_toLogin.TabIndex = 27;
            this.btn_toLogin.Text = "Quay lại đăng nhập";
            this.btn_toLogin.UseVisualStyleBackColor = false;
            this.btn_toLogin.Click += new System.EventHandler(this.btn_toLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(149, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 32);
            this.label2.TabIndex = 28;
            this.label2.Text = "Đã có tài khoản?";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 391);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(443, 38);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(21, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 32);
            this.label3.TabIndex = 29;
            this.label3.Text = "Ngày sinh";
            // 
            // Register
            // 
            this.AcceptButton = this.btn_Register;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_toLogin;
            this.ClientSize = new System.Drawing.Size(491, 602);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_toLogin);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Location);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Register;
        private TextBox txt_Password;
        private TextBox txt_Location;
        private TextBox txt_Phone;
        private TextBox txt_Name;
        private Label label1;
        private Button btn_toLogin;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
    }
}