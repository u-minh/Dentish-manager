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
    public partial class KH : Form
    {
        private int ID_KH;
        public KH(int ma)
        {
            InitializeComponent();
            ID_KH = ma;
        }

        private void btn_ToLogin_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void KH_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void btn_ToAccount_Click(object sender, EventArgs e)
        {
            KH_Inform f = new KH_Inform(ID_KH);
            f.Show();
            this.Hide();
        }

        private void btn_ToAccountHandle_Click(object sender, EventArgs e)
        {
            KH_Appointment f = new KH_Appointment(ID_KH);
            f.Show();
            this.Hide();
        }

        private void btn_ToMedicalRecord_Click(object sender, EventArgs e)
        {
            KH_MedicalRecord f = new KH_MedicalRecord(ID_KH);
            f.Show();
            this.Hide();
        }
    }
}
