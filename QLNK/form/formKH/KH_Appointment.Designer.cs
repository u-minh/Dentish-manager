namespace QLNK.form.formKH
{
    partial class KH_Appointment
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
            this.data_Appointment = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LH_done = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_Appointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LH_done)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 65);
            this.label1.TabIndex = 6;
            this.label1.Text = "Trang đặt lịch khám";
            // 
            // data_Appointment
            // 
            this.data_Appointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data_Appointment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_Appointment.BackgroundColor = System.Drawing.Color.White;
            this.data_Appointment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_Appointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Appointment.Location = new System.Drawing.Point(119, 143);
            this.data_Appointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_Appointment.MultiSelect = false;
            this.data_Appointment.Name = "data_Appointment";
            this.data_Appointment.ReadOnly = true;
            this.data_Appointment.RowHeadersWidth = 40;
            this.data_Appointment.RowTemplate.Height = 37;
            this.data_Appointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_Appointment.Size = new System.Drawing.Size(728, 270);
            this.data_Appointment.TabIndex = 39;
            this.data_Appointment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Appointment_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 32);
            this.label2.TabIndex = 40;
            this.label2.Text = "Lịch hẹn có thể đặt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(736, 32);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nháy đúp chuột vào dòng chứa lịch hẹn muốn đặt để đặt lịch hẹn";
            // 
            // LH_done
            // 
            this.LH_done.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.LH_done.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.LH_done.BackgroundColor = System.Drawing.Color.White;
            this.LH_done.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LH_done.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LH_done.Location = new System.Drawing.Point(119, 514);
            this.LH_done.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LH_done.MultiSelect = false;
            this.LH_done.Name = "LH_done";
            this.LH_done.ReadOnly = true;
            this.LH_done.RowHeadersWidth = 40;
            this.LH_done.RowTemplate.Height = 37;
            this.LH_done.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LH_done.Size = new System.Drawing.Size(728, 143);
            this.LH_done.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 32);
            this.label4.TabIndex = 43;
            this.label4.Text = "Lịch hẹn đã đặt:";
            // 
            // KH_Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 659);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LH_done);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data_Appointment);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KH_Appointment";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt lịch hẹn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KH_Appointment_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.data_Appointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LH_done)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView data_Appointment;
        private Label label2;
        private Label label3;
        private DataGridView LH_done;
        private Label label4;
    }
}