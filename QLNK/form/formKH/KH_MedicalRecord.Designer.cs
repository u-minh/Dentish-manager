namespace QLNK.form.formKH
{
    partial class KH_MedicalRecord
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
            this.data_MedicalRecord = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_MedicalRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 65);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hồ sơ bệnh án của bạn";
            // 
            // data_MedicalRecord
            // 
            this.data_MedicalRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data_MedicalRecord.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_MedicalRecord.BackgroundColor = System.Drawing.Color.White;
            this.data_MedicalRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_MedicalRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_MedicalRecord.Location = new System.Drawing.Point(50, 103);
            this.data_MedicalRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_MedicalRecord.MultiSelect = false;
            this.data_MedicalRecord.Name = "data_MedicalRecord";
            this.data_MedicalRecord.ReadOnly = true;
            this.data_MedicalRecord.RowHeadersWidth = 40;
            this.data_MedicalRecord.RowTemplate.Height = 37;
            this.data_MedicalRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_MedicalRecord.Size = new System.Drawing.Size(842, 465);
            this.data_MedicalRecord.TabIndex = 38;
            // 
            // KH_MedicalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 579);
            this.Controls.Add(this.data_MedicalRecord);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KH_MedicalRecord";
            this.ShowIcon = false;
            this.Text = "Thông tin bệnh án";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KH_MedicalRecord_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.data_MedicalRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView data_MedicalRecord;
    }
}