using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNK.form.formKH
{
    public partial class KH_MedicalRecord : Form
    {
        private int ID_KH;
        public KH_MedicalRecord(int ma)
        {
            InitializeComponent();
            this.KeyDown += KH_MedicalRecord_KeyDown;
            // Đảm bảo form có Focus để nhận sự kiện KeyDown
            this.Focus();
            this.KeyPreview = true;
            ID_KH = ma;
            KHProcessor.loadMedicalData(data_MedicalRecord, ID_KH);
        }

        private void KH_MedicalRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void KH_MedicalRecord_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra nếu phím được nhấn là phím Esc
            if (e.KeyCode == Keys.Escape)
            {
                KH f = new KH(ID_KH);
                f.Show();
                this.Hide();
            }
        }
    }
}
