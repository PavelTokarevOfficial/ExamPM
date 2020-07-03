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
    public partial class FormMedicine : Form
    {
        public FormMedicine()
        {
            InitializeComponent();
            ShowMedicine();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();
            medicine.NameMedicine = textBoxName.Text;
            medicine.Type = comboBoxType.Text;
            medicine.Dosage = textBoxDosage.Text;
            medicine.Manufacturer = textBoxManufacturer.Text;
            medicine.Data = textBoxData.Text;
            Program.pharmacy.Medicine.Add(medicine);
            Program.pharmacy.SaveChanges();
            ShowMedicine();
        }
        void ShowMedicine()
        {
            listViewMedecine.Items.Clear();
            foreach(Medicine medicine in Program.pharmacy.Medicine)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    medicine.ID.ToString(),
                    medicine.NameMedicine,
                    medicine.Type,
                    medicine.Dosage,
                    medicine.Manufacturer,
                    medicine.Data
                });
                item.Tag = medicine;
                listViewMedecine.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewMedecine.SelectedItems.Count==1)
            {
                Medicine medicine = listViewMedecine.SelectedItems[0].Tag as Medicine;
                medicine.NameMedicine = textBoxName.Text;
                medicine.Type = comboBoxType.Text;
                medicine.Dosage = textBoxDosage.Text;
                medicine.Manufacturer = textBoxManufacturer.Text;
                medicine.Data = textBoxData.Text;
                Program.pharmacy.SaveChanges();
                ShowMedicine();
            }
        }

        private void listViewMedecine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMedecine.SelectedItems.Count==1)
            {
                Medicine medicine = listViewMedecine.SelectedItems[0].Tag as Medicine;
                textBoxName.Text = medicine.NameMedicine;
                comboBoxType.Text = medicine.Type;
                textBoxDosage.Text = medicine.Dosage;
                textBoxManufacturer.Text = medicine.Manufacturer;
                textBoxData.Text = medicine.Data;
            }
            else
            {
                textBoxName.Text = "";
                comboBoxType.Text = "";
                textBoxDosage.Text = "";
                textBoxManufacturer.Text = "";
                textBoxData.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewMedecine.SelectedItems.Count == 1)
                {
                    Medicine medicine = listViewMedecine.SelectedItems[0].Tag as Medicine;
                    Program.pharmacy.Medicine.Remove(medicine);
                    Program.pharmacy.SaveChanges();
                    ShowMedicine();
                }
                textBoxName.Text = "";
                comboBoxType.Text = "";
                textBoxDosage.Text = "";
                textBoxManufacturer.Text = "";
                textBoxData.Text = "";

            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }
    }
}
