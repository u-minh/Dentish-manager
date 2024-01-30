namespace QLNK.form.formNV
{
    partial class NV_Invoice
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
            this.data_MedicalRecord = new System.Windows.Forms.DataGridView();
            this.btn_Find = new System.Windows.Forms.Button();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_MedicalRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(260, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(514, 65);
            this.label2.TabIndex = 18;
            this.label2.Text = "Thông tin khám bệnh";
            // 
            // data_MedicalRecord
            // 
            this.data_MedicalRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data_MedicalRecord.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_MedicalRecord.BackgroundColor = System.Drawing.Color.White;
            this.data_MedicalRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_MedicalRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_MedicalRecord.Location = new System.Drawing.Point(28, 189);
            this.data_MedicalRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_MedicalRecord.MultiSelect = false;
            this.data_MedicalRecord.Name = "data_MedicalRecord";
            this.data_MedicalRecord.ReadOnly = true;
            this.data_MedicalRecord.RowHeadersWidth = 40;
            this.data_MedicalRecord.RowTemplate.Height = 37;
            this.data_MedicalRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_MedicalRecord.Size = new System.Drawing.Size(988, 418);
            this.data_MedicalRecord.TabIndex = 17;
            this.data_MedicalRecord.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_MedicalRecord_CellContentDoubleClick);
            // 
            // btn_Find
            // 
            this.btn_Find.BackColor = System.Drawing.Color.Lavender;
            this.btn_Find.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Find.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Find.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_Find.Location = new System.Drawing.Point(899, 98);
            this.btn_Find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(137, 38);
            this.btn_Find.TabIndex = 32;
            this.btn_Find.Text = "Tìm kiếm";
            this.btn_Find.UseVisualStyleBackColor = false;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // txt_Phone
            // 
            this.txt_Phone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Phone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_Phone.Location = new System.Drawing.Point(707, 98);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.PlaceholderText = "Số điện thoại";
            this.txt_Phone.Size = new System.Drawing.Size(186, 38);
            this.txt_Phone.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 34;
            this.label1.Text = "Bảng thông tin khám";
            // 
            // NV_Invoice
            // 
            this.AcceptButton = this.btn_Find;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 618);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data_MedicalRecord);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NV_Invoice";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo hóa đơn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NV_Invoice_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.data_MedicalRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private DataGridView data_MedicalRecord;
        private Button btn_Find;
        private TextBox txt_Phone;
        private Label label1;
    }
}