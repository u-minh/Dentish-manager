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
    public partial class NV : Form
    {
        int ID_NV;
        public NV(int ma)
        {
            InitializeComponent();
            ID_NV = ma;
        }

        private void NV_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void btn_ToLogin_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void btn_ToMedicine_Click(object sender, EventArgs e)
        {
            NV_Medicine f = new NV_Medicine(ID_NV);
            f.Show();
            this.Hide();
        }

        private void btn_ToBooking_Click(object sender, EventArgs e)
        {
            NV_Appointment f = new NV_Appointment(ID_NV);
            f.Show();
            this.Hide();
        }

        private void btn_ToInvoice_Click(object sender, EventArgs e)
        {
            NV_Invoice f = new NV_Invoice(ID_NV);
            f.Show();
            this.Hide();
        }
    }
}
