namespace QLNK.form.formNS
{
    partial class NS
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
            this.btn_ToScheduleHandle = new System.Windows.Forms.Button();
            this.btn_ToMedicalHandle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ToLogin
            // 
            this.btn_ToLogin.BackColor = System.Drawing.Color.Lavender;
            this.btn_ToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ToLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_ToLogin.Location = new System.Drawing.Point(110, 469);
            this.btn_ToLogin.Name = "btn_ToLogin";
            this.btn_ToLogin.Size = new System.Drawing.Size(271, 97);
            this.btn_ToLogin.TabIndex = 7;
            this.btn_ToLogin.Text = "Đăng xuất";
            this.btn_ToLogin.UseVisualStyleBackColor = false;
            this.btn_ToLogin.Click += new System.EventHandler(this.btn_ToLogin_Click);
            // 
            // btn_ToScheduleHandle
            // 
            this.btn_ToScheduleHandle.BackColor = System.Drawing.Color.Lavender;
            this.btn_ToScheduleHandle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ToScheduleHandle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_ToScheduleHandle.Location = new System.Drawing.Point(110, 310);
            this.btn_ToScheduleHandle.Name = "btn_ToScheduleHandle";
            this.btn_ToScheduleHandle.Size = new System.Drawing.Size(271, 97);
            this.btn_ToScheduleHandle.TabIndex = 6;
            this.btn_ToScheduleHandle.Text = "Quản lý lịch cá nhân";
            this.btn_ToScheduleHandle.UseVisualStyleBackColor = false;
            this.btn_ToScheduleHandle.Click += new System.EventHandler(this.btn_ToScheduleHandle_Click);
            // 
            // btn_ToMedicalHandle
            // 
            this.btn_ToMedicalHandle.BackColor = System.Drawing.Color.Lavender;
            this.btn_ToMedicalHandle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ToMedicalHandle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_ToMedicalHandle.Location = new System.Drawing.Point(110, 153);
            this.btn_ToMedicalHandle.Name = "btn_ToMedicalHandle";
            this.btn_ToMedicalHandle.Size = new System.Drawing.Size(271, 97);
            this.btn_ToMedicalHandle.TabIndex = 5;
            this.btn_ToMedicalHandle.Text = "Quản lý bệnh án";
            this.btn_ToMedicalHandle.UseVisualStyleBackColor = false;
            this.btn_ToMedicalHandle.Click += new System.EventHandler(this.btn_ToMedicalHandle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(57, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bộ phận nha sĩ";
            // 
            // NS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_ToLogin;
            this.ClientSize = new System.Drawing.Size(491, 602);
            this.Controls.Add(this.btn_ToLogin);
            this.Controls.Add(this.btn_ToScheduleHandle);
            this.Controls.Add(this.btn_ToMedicalHandle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang nha sĩ ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NS_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ToLogin;
        private Button btn_ToScheduleHandle;
        private Button btn_ToMedicalHandle;
        private Label label1;
    }
}