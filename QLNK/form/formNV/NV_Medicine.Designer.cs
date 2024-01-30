namespace QLNK.form.formNV
{
    partial class NV_Medicine
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
            this.data_Medicine = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_Medicine)).BeginInit();
            this.SuspendLayout();
            // 
            // data_Medicine
            // 
            this.data_Medicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data_Medicine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_Medicine.BackgroundColor = System.Drawing.Color.White;
            this.data_Medicine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_Medicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Medicine.Location = new System.Drawing.Point(28, 107);
            this.data_Medicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_Medicine.MultiSelect = false;
            this.data_Medicine.Name = "data_Medicine";
            this.data_Medicine.ReadOnly = true;
            this.data_Medicine.RowHeadersWidth = 40;
            this.data_Medicine.RowTemplate.Height = 37;
            this.data_Medicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_Medicine.Size = new System.Drawing.Size(912, 480);
            this.data_Medicine.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(167, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(627, 65);
            this.label2.TabIndex = 16;
            this.label2.Text = "Thông tin thuốc trong kho";
            // 
            // NV_Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 598);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data_Medicine);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NV_Medicine";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem thông tin thuốc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NV_Medicine_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.data_Medicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView data_Medicine;
        private Label label2;
    }
}