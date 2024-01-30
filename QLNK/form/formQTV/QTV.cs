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

namespace QLNK.form
{
    public partial class QTV : Form
    {
        private int ID_QTV;
        public QTV(int ma)
        {
            InitializeComponent();
            ID_QTV = ma;
        }

        private void btn_ToLogin_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void QTV_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void btn_ToMedicineHandle_Click(object sender, EventArgs e)
        {
            QTV_Medicine f = new QTV_Medicine(ID_QTV);
            f.Show();
            this.Hide();
        }

        private void btn_ToAccountHandle_Click(object sender, EventArgs e)
        {
            QTV_Account f = new QTV_Account(ID_QTV);
            f.Show();
            this.Hide();
        }
    }
}
