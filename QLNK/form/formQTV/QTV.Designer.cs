namespace QLNK.form
{
    partial class QTV
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
            this.btn_ToMedicineHandle = new System.Windows.Forms.Button();
            this.btn_ToAccountHandle = new System.Windows.Forms.Button();
            this.btn_ToLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bộ phận quản trị";
            // 
            // btn_ToMedicineHandle
            // 
            this.btn_ToMedicineHandle.BackColor = System.Drawing.Color.Lavender;
            this.btn_ToMedicineHandle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ToMedicineHandle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_ToMedicineHandle.Location = new System.Drawing.Point(106, 128);
            this.btn_ToMedicineHandle.Name = "btn_ToMedicineHandle";
            this.btn_ToMedicineHandle.Size = new System.Drawing.Size(271, 97);
            this.btn_ToMedicineHandle.TabIndex = 1;
            this.btn_ToMedicineHandle.Text = "Quản lý thuốc";
            this.btn_ToMedicineHandle.UseVisualStyleBackColor = false;
            this.btn_ToMedicineHandle.Click += new System.EventHandler(this.btn_ToMedicineHandle_Click);
            // 
            // btn_ToAccountHandle
            // 
            this.btn_ToAccountHandle.BackColor = System.Drawing.Color.Lavender;
            this.btn_ToAccountHandle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ToAccountHandle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_ToAccountHandle.Location = new System.Drawing.Point(106, 285);
            this.btn_ToAccountHandle.Name = "btn_ToAccountHandle";
            this.btn_ToAccountHandle.Size = new System.Drawing.Size(271, 97);
            this.btn_ToAccountHandle.TabIndex = 2;
            this.btn_ToAccountHandle.Text = "Quản lý tài khoản";
            this.btn_ToAccountHandle.UseVisualStyleBackColor = false;
            this.btn_ToAccountHandle.Click += new System.EventHandler(this.btn_ToAccountHandle_Click);
            // 
            // btn_ToLogin
            // 
            this.btn_ToLogin.BackColor = System.Drawing.Color.Lavender;
            this.btn_ToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ToLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_ToLogin.Location = new System.Drawing.Point(106, 444);
            this.btn_ToLogin.Name = "btn_ToLogin";
            this.btn_ToLogin.Size = new System.Drawing.Size(271, 97);
            this.btn_ToLogin.TabIndex = 3;
            this.btn_ToLogin.Text = "Đăng xuất";
            this.btn_ToLogin.UseVisualStyleBackColor = false;
            this.btn_ToLogin.Click += new System.EventHandler(this.btn_ToLogin_Click);
            // 
            // QTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_ToLogin;
            this.ClientSize = new System.Drawing.Size(491, 602);
            this.Controls.Add(this.btn_ToLogin);
            this.Controls.Add(this.btn_ToAccountHandle);
            this.Controls.Add(this.btn_ToMedicineHandle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QTV";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Trị Viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QTV_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_ToMedicineHandle;
        private Button btn_ToAccountHandle;
        private Button btn_ToLogin;
    }
}