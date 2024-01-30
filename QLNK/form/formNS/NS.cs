using QLNK.form.formQTV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNK.form.formNS
{
    public partial class NS : Form
    {
        private int ID_NS;
        public NS(int ma)
        {
            InitializeComponent();
            ID_NS = ma;
        }

        private void NS_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btn_ToMedicalHandle_Click(object sender, EventArgs e)
        {
            NS_MedicalRecord f = new NS_MedicalRecord(ID_NS);
            f.Show();
            this.Hide();
        }

        private void btn_ToScheduleHandle_Click(object sender, EventArgs e)
        {
            NS_Schedule f = new NS_Schedule(ID_NS);
            f.Show();
            this.Hide();
        }
    }
}
