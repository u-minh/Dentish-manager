namespace QLNK.form.formNV
{
    partial class NV
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ToMedicine = new System.Windows.Forms.Button();
            this.btn_ToLogin = new System.Windows.Forms.Button();
            this.btn_ToBooking = new System.Windows.Forms.Button();
            this.btn_ToInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(65, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 65);
            this.label2.TabIndex = 15;
            this.label2.Text = "Bộ phận nhân viên";
            // 
            // btn_ToMedicine
            // 
            this.btn_ToMedicine.BackColor = System.Drawing.Color.Lavender;
            this.btn_ToMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ToMedicine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_ToMedicine.Location = new System.Drawing.Point(134, 376);
            this.btn_ToMedicine.Name = "btn_ToMedicine";
            this.btn_ToMedicine.Size = new System.Drawing.Size(344, 106);
            this.btn_ToMedicine.TabIndex = 19;
            this.btn_ToMedicine.Text = "Xem kho thuốc";
            this.btn_ToMedicine.UseVisualStyleBackColor = false;
            this.btn_ToMedicine.Click += new System.EventHandler(this.btn_ToMedicine_Click);
            // 
            // btn_ToLogin
            // 
            this.btn_ToLogin.BackColor = System.Drawing.Color.Lavender;
            this.btn_ToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ToLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_ToLogin.Location = new System.Drawing.Point(134, 506);
            this.btn_ToLogin.Name = "btn_ToLogin";
            this.btn_ToLogin.Size = new System.Drawing.Size(344, 106);
            this.btn_ToLogin.TabIndex = 20;
            this.btn_ToLogin.Text = "Đăng xuất";
            this.btn_ToLogin.UseVisualStyleBackColor = false;
            this.btn_ToLogin.Click += new System.EventHandler(this.btn_ToLogin_Click);
            // 
            // btn_ToBooking
            // 
            this.btn_ToBooking.BackColor = System.Drawing.Color.Lavender;
            this.btn_ToBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ToBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_ToBooking.Location = new System.Drawing.Point(134, 243);
            this.btn_ToBooking.Name = "btn_ToBooking";
            this.btn_ToBooking.Size = new System.Drawing.Size(344, 106);
            this.btn_ToBooking.TabIndex = 18;
            this.btn_ToBooking.Text = "Đặt lịch hẹn";
            this.btn_ToBooking.UseVisualStyleBackColor = false;
            this.btn_ToBooking.Click += new System.EventHandler(this.btn_ToBooking_Click);
            // 
            // btn_ToInvoice
            // 
            this.btn_ToInvoice.BackColor = System.Drawing.Color.Lavender;
            this.btn_ToInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ToInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_ToInvoice.Location = new System.Drawing.Point(134, 114);
            this.btn_ToInvoice.Name = "btn_ToInvoice";
            this.btn_ToInvoice.Size = new System.Drawing.Size(344, 106);
            this.btn_ToInvoice.TabIndex = 17;
            this.btn_ToInvoice.Text = "In hóa đơn";
            this.btn_ToInvoice.UseVisualStyleBackColor = false;
            this.btn_ToInvoice.Click += new System.EventHandler(this.btn_ToInvoice_Click);
            // 
            // NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_ToLogin;
            this.ClientSize = new System.Drawing.Size(624, 643);
            this.Controls.Add(this.btn_ToMedicine);
            this.Controls.Add(this.btn_ToLogin);
            this.Controls.Add(this.btn_ToBooking);
            this.Controls.Add(this.btn_ToInvoice);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NV";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NV_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Button btn_ToMedicine;
        private Button btn_ToLogin;
        private Button btn_ToBooking;
        private Button btn_ToInvoice;
    }
}