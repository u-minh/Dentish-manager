using QLNK.form.formKH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNK.form.formNV
{
    public partial class NV_Medicine : Form
    {
        int ID_NV;
        public NV_Medicine(int ma)
        {
            InitializeComponent();
            ID_NV = ma;
            this.KeyDown += NV_Medicine_KeyDown;
            // Đảm bảo form có Focus để nhận sự kiện KeyDown
            this.Focus();
            this.KeyPreview = true;
            QTVprocessor.loadMedicineData(data_Medicine);
        }
        private void NV_Medicine_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra nếu phím được nhấn là phím Esc
            if (e.KeyCode == Keys.Escape)
            {
                NV f = new NV(ID_NV);
                f.Show();
                this.Hide();
            }
        }

        private void NV_Medicine_FormClosed(object sender, FormClosedEventArgs e)
        {
            NV f = new NV(ID_NV);
            f.Show();
            this.Hide();
        }
    }
}
