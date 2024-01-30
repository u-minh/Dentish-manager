namespace QLNK.form.formKH
{
    partial class KH
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
            this.btn_ToLogin = new System.Windows.Forms.Button();
            this.btn_ToAccountHandle = new System.Windows.Forms.Button();
            this.btn_ToAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ToMedicalRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ToLogin
            // 
            this.btn_ToLogin.BackColor = System.Drawing.Color.Lavender;
            this.btn_ToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ToLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_ToLogin.Location = new System.Drawing.Point(116, 482);
            this.btn_ToLogin.Name = "btn_ToLogin";
            this.btn_ToLogin.Size = new System.Drawing.Size(294, 100);
            this.btn_ToLogin.TabIndex = 8;
            this.btn_ToLogin.Text = "Đăng xuất";
            this.btn_ToLogin.UseVisualStyleBackColor = false;
            this.btn_ToLogin.Click += new System.EventHandler(this.btn_ToLogin_Click);
            // 
            // btn_ToAccountHandle
            // 
            this.btn_ToAccountHandle.BackColor = System.Drawing.Color.Lavender;
            this.btn_ToAccountHandle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ToAccountHandle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_ToAccountHandle.Location = new System.Drawing.Point(116, 235);
            this.btn_ToAccountHandle.Name = "btn_ToAccountHandle";
            this.btn_ToAccountHandle.Size = new System.Drawing.Size(294, 100);
            this.btn_ToAccountHandle.TabIndex = 6;
            this.btn_ToAccountHandle.Text = "Đặt lịch hẹn";
            this.btn_ToAccountHandle.UseVisualStyleBackColor = false;
            this.btn_ToAccountHandle.Click += new System.EventHandler(this.btn_ToAccountHandle_Click);
            // 
            // btn_ToAccount
            // 
            this.btn_ToAccount.BackColor = System.Drawing.Color.Lavender;
            this.btn_ToAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ToAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_ToAccount.Location = new System.Drawing.Point(116, 114);
            this.btn_ToAccount.Name = "btn_ToAccount";
            this.btn_ToAccount.Size = new System.Drawing.Size(294, 100);
            this.btn_ToAccount.TabIndex = 5;
            this.btn_ToAccount.Text = "Thông tin tài khoản";
            this.btn_ToAccount.UseVisualStyleBackColor = false;
            this.btn_ToAccount.Click += new System.EventHandler(this.btn_ToAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bộ phận khách hàng";
            // 
            // btn_ToMedicalRecord
            // 
            this.btn_ToMedicalRecord.BackColor = System.Drawing.Color.Lavender;
            this.btn_ToMedicalRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ToMedicalRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_ToMedicalRecord.Location = new System.Drawing.Point(116, 360);
            this.btn_ToMedicalRecord.Name = "btn_ToMedicalRecord";
            this.btn_ToMedicalRecord.Size = new System.Drawing.Size(294, 100);
            this.btn_ToMedicalRecord.TabIndex = 7;
            this.btn_ToMedicalRecord.Text = "Xem bệnh án";
            this.btn_ToMedicalRecord.UseVisualStyleBackColor = false;
            this.btn_ToMedicalRecord.Click += new System.EventHandler(this.btn_ToMedicalRecord_Click);
            // 
            // KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_ToLogin;
            this.ClientSize = new System.Drawing.Size(532, 602);
            this.Controls.Add(this.btn_ToMedicalRecord);
            this.Controls.Add(this.btn_ToLogin);
            this.Controls.Add(this.btn_ToAccountHandle);
            this.Controls.Add(this.btn_ToAccount);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KH";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KH_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ToLogin;
        private Button btn_ToAccountHandle;
        private Button btn_ToAccount;
        private Label label1;
        private Button btn_ToMedicalRecord;
    }
}