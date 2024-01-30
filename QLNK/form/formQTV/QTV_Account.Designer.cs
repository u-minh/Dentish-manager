namespace QLNK.form.formQTV
{
    partial class QTV_Account
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_LockUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Role1 = new System.Windows.Forms.TextBox();
            this.txt_IDTK = new System.Windows.Forms.TextBox();
            this.btn_ConfirmAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Role = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Location = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_EditLock = new System.Windows.Forms.Button();
            this.btn_AddTK = new System.Windows.Forms.Button();
            this.data_Account = new System.Windows.Forms.DataGridView();
            this.btn_Return = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Account)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_LockUpdate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_Role1);
            this.panel2.Controls.Add(this.txt_IDTK);
            this.panel2.Location = new System.Drawing.Point(12, 478);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 89);
            this.panel2.TabIndex = 39;
            // 
            // btn_LockUpdate
            // 
            this.btn_LockUpdate.BackColor = System.Drawing.Color.Lavender;
            this.btn_LockUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LockUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_LockUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_LockUpdate.Location = new System.Drawing.Point(717, 29);
            this.btn_LockUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LockUpdate.Name = "btn_LockUpdate";
            this.btn_LockUpdate.Size = new System.Drawing.Size(137, 47);
            this.btn_LockUpdate.TabIndex = 30;
            this.btn_LockUpdate.Text = "Xác nhận";
            this.btn_LockUpdate.UseVisualStyleBackColor = false;
            this.btn_LockUpdate.Click += new System.EventHandler(this.btn_LockUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label6.Location = new System.Drawing.Point(3, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 32);
            this.label6.TabIndex = 28;
            this.label6.Text = "Nhập thông tin tài khoản";
            // 
            // txt_Role1
            // 
            this.txt_Role1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Role1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Role1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_Role1.Location = new System.Drawing.Point(343, 35);
            this.txt_Role1.Name = "txt_Role1";
            this.txt_Role1.PlaceholderText = "Vai trò";
            this.txt_Role1.Size = new System.Drawing.Size(162, 38);
            this.txt_Role1.TabIndex = 26;
            // 
            // txt_IDTK
            // 
            this.txt_IDTK.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_IDTK.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_IDTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_IDTK.Location = new System.Drawing.Point(12, 34);
            this.txt_IDTK.Name = "txt_IDTK";
            this.txt_IDTK.PlaceholderText = "ID tài khoản";
            this.txt_IDTK.Size = new System.Drawing.Size(172, 38);
            this.txt_IDTK.TabIndex = 24;
            // 
            // btn_ConfirmAdd
            // 
            this.btn_ConfirmAdd.BackColor = System.Drawing.Color.Lavender;
            this.btn_ConfirmAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ConfirmAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ConfirmAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_ConfirmAdd.Location = new System.Drawing.Point(369, 387);
            this.btn_ConfirmAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ConfirmAdd.Name = "btn_ConfirmAdd";
            this.btn_ConfirmAdd.Size = new System.Drawing.Size(137, 47);
            this.btn_ConfirmAdd.TabIndex = 36;
            this.btn_ConfirmAdd.Text = "Xác nhận";
            this.btn_ConfirmAdd.UseVisualStyleBackColor = false;
            this.btn_ConfirmAdd.Click += new System.EventHandler(this.btn_ConfirmAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_Role);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.txt_Location);
            this.panel1.Controls.Add(this.txt_Phone);
            this.panel1.Controls.Add(this.btn_ConfirmAdd);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(158, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 465);
            this.panel1.TabIndex = 38;
            // 
            // txt_Role
            // 
            this.txt_Role.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Role.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_Role.Location = new System.Drawing.Point(61, 392);
            this.txt_Role.Name = "txt_Role";
            this.txt_Role.PlaceholderText = "Vai trò";
            this.txt_Role.Size = new System.Drawing.Size(239, 38);
            this.txt_Role.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(61, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 32);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ngày sinh";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 323);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(443, 35);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_Password.Location = new System.Drawing.Point(63, 171);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PlaceholderText = "Mật khẩu";
            this.txt_Password.Size = new System.Drawing.Size(443, 38);
            this.txt_Password.TabIndex = 32;
            // 
            // txt_Location
            // 
            this.txt_Location.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Location.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Location.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_Location.Location = new System.Drawing.Point(63, 237);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.PlaceholderText = "Địa chỉ";
            this.txt_Location.Size = new System.Drawing.Size(443, 38);
            this.txt_Location.TabIndex = 33;
            // 
            // txt_Phone
            // 
            this.txt_Phone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Phone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_Phone.Location = new System.Drawing.Point(61, 107);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.PlaceholderText = "Số điện thoại (tài khoản)";
            this.txt_Phone.Size = new System.Drawing.Size(443, 38);
            this.txt_Phone.TabIndex = 31;
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_Name.Location = new System.Drawing.Point(63, 42);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PlaceholderText = "Họ và Tên";
            this.txt_Name.Size = new System.Drawing.Size(443, 38);
            this.txt_Name.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(140, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nhập thông tin tài khoản";
            // 
            // btn_EditLock
            // 
            this.btn_EditLock.BackColor = System.Drawing.Color.Lavender;
            this.btn_EditLock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EditLock.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_EditLock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_EditLock.Location = new System.Drawing.Point(371, 11);
            this.btn_EditLock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_EditLock.Name = "btn_EditLock";
            this.btn_EditLock.Size = new System.Drawing.Size(241, 47);
            this.btn_EditLock.TabIndex = 21;
            this.btn_EditLock.Text = "Khóa tài khoản";
            this.btn_EditLock.UseVisualStyleBackColor = false;
            this.btn_EditLock.Click += new System.EventHandler(this.btn_EditLock_Click);
            // 
            // btn_AddTK
            // 
            this.btn_AddTK.BackColor = System.Drawing.Color.Lavender;
            this.btn_AddTK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddTK.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AddTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_AddTK.Location = new System.Drawing.Point(25, 11);
            this.btn_AddTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddTK.Name = "btn_AddTK";
            this.btn_AddTK.Size = new System.Drawing.Size(241, 47);
            this.btn_AddTK.TabIndex = 20;
            this.btn_AddTK.Text = "Thêm Tài khoản";
            this.btn_AddTK.UseVisualStyleBackColor = false;
            this.btn_AddTK.Click += new System.EventHandler(this.btn_AddTK_Click);
            // 
            // data_Account
            // 
            this.data_Account.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data_Account.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_Account.BackgroundColor = System.Drawing.Color.White;
            this.data_Account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_Account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Account.Location = new System.Drawing.Point(158, 91);
            this.data_Account.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_Account.MultiSelect = false;
            this.data_Account.Name = "data_Account";
            this.data_Account.ReadOnly = true;
            this.data_Account.RowHeadersWidth = 40;
            this.data_Account.RowTemplate.Height = 37;
            this.data_Account.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_Account.Size = new System.Drawing.Size(754, 376);
            this.data_Account.TabIndex = 37;
            // 
            // btn_Return
            // 
            this.btn_Return.BackColor = System.Drawing.Color.Lavender;
            this.btn_Return.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Return.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Return.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_Return.Location = new System.Drawing.Point(730, 11);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(137, 47);
            this.btn_Return.TabIndex = 22;
            this.btn_Return.Text = "Quay lại";
            this.btn_Return.UseVisualStyleBackColor = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // QTV_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_Return;
            this.ClientSize = new System.Drawing.Size(893, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_EditLock);
            this.Controls.Add(this.btn_AddTK);
            this.Controls.Add(this.data_Account);
            this.Controls.Add(this.btn_Return);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QTV_Account";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QTV_Account";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QTV_Account_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Account)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Button btn_LockUpdate;
        private Label label6;
        private TextBox txt_Role1;
        private TextBox txt_IDTK;
        private Panel panel1;
        private Button btn_ConfirmAdd;
        private Label label1;
        private Button btn_EditLock;
        private Button btn_AddTK;
        private DataGridView data_Account;
        private Button btn_Return;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_Password;
        private TextBox txt_Location;
        private TextBox txt_Phone;
        private TextBox txt_Name;
        private TextBox txt_Role;
    }
}