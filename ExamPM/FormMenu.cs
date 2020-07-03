using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamPM
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonAccounting_Click(object sender, EventArgs e)
        {
            FormAccounting formAccounting = new FormAccounting();
            formAccounting.Show();
            this.Hide();
        }

        private void buttonMedicine_Click(object sender, EventArgs e)
        {
            FormMedicine formMedicine = new FormMedicine();
            formMedicine.Show();
            this.Hide();
        }

        private void buttonPharmacy_Click(object sender, EventArgs e)
        {
            FormPharmacy formPharmacy = new FormPharmacy();
            formPharmacy.Show();
            this.Hide();
        }

        private void buttonExid_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
