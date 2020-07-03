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
    public partial class FormAccounting : Form
    {
        public FormAccounting()
        {
            InitializeComponent();
            ComboBoxShowMedicine();
            ComboBoxShowPharmacy();
            ShowAccounting();
        }

        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            char sym = e.KeyChar;
            if (!Char.IsDigit(sym) && sym != 8 || sym == 127)
            {
                e.Handled = true;
            }
        }
        void ComboBoxShowMedicine()
        {
            comboBoxMedecine.Items.Clear();
            foreach(Medicine medicine in Program.pharmacy.Medicine)
            {
                string[] item =
                {
                    medicine.ID.ToString()+".",
                    medicine.NameMedicine
                };
                comboBoxMedecine.Items.Add(string.Join(" ", item));
            }
        }
        void ComboBoxShowPharmacy()
        {
            comboBoxPharmane.Items.Clear();
            foreach(Pharmacy pharmacy in Program.pharmacy.Pharmacy)
            {
                string[] item = 
                {
                    pharmacy.ID.ToString()+".",
                    pharmacy.NamePharmacy
                };
                comboBoxPharmane.Items.Add(string.Join("", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxMedecine.SelectedItem != null && comboBoxPharmane.SelectedItem != null && textBoxQuantity.Text != "" && textBoxPrice.Text != "")
            {
                Accounting accounting = new Accounting();
                accounting.IDMedicine = Convert.ToInt32(comboBoxMedecine.SelectedItem.ToString().Split('.')[0]);
                accounting.IDPharmacy = Convert.ToInt32(comboBoxPharmane.SelectedItem.ToString().Split('.')[0]);
                accounting.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                accounting.Price = textBoxPrice.Text;
                Program.pharmacy.Accounting.Add(accounting);
                Program.pharmacy.SaveChanges();
                ShowAccounting();

            }
            else
            {
                MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void ShowAccounting()
        {
            listViewAccounting.Items.Clear();
            foreach (Accounting accounting in Program.pharmacy.Accounting)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    accounting.ID.ToString(),
                    accounting.IDMedicine.ToString()+ accounting.Medicine.NameMedicine,
                    accounting.IDPharmacy.ToString()+accounting.Pharmacy.NamePharmacy,
                    accounting.Quantity.ToString(),
                    accounting.Price
                });
                item.Tag = accounting;
                listViewAccounting.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAccounting.SelectedItems.Count == 1)
            {
                Accounting accounting = listViewAccounting.SelectedItems[0].Tag as Accounting;
                accounting.IDMedicine = Convert.ToInt32(comboBoxMedecine.SelectedItem.ToString().Split('.')[0]);
                accounting.IDPharmacy= Convert.ToInt32(comboBoxPharmane.SelectedItem.ToString().Split('.')[0]);
                accounting.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                accounting.Price = textBoxPrice.Text;
                Program.pharmacy.SaveChanges();
                ShowAccounting();
            }
        }

        private void listViewAccounting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAccounting.SelectedItems.Count == 1)
            {
                Accounting accounting = listViewAccounting.SelectedItems[0].Tag as Accounting;
                comboBoxMedecine.SelectedIndex = comboBoxMedecine.FindString(accounting.IDMedicine.ToString());
                comboBoxPharmane.SelectedIndex = comboBoxPharmane.FindString(accounting.IDPharmacy.ToString());
                textBoxQuantity.Text = accounting.Quantity.ToString();
                textBoxPrice.Text = accounting.Price;
            }
            else
            {
                comboBoxMedecine.SelectedItem = null;
                comboBoxPharmane.SelectedItem = null;
                textBoxQuantity.Text = "";
                textBoxPrice.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAccounting.SelectedItems.Count == 1)
                {
                    Accounting accounting= listViewAccounting.SelectedItems[0].Tag as Accounting;
                    Program.pharmacy.Accounting.Remove(accounting);
                    Program.pharmacy.SaveChanges();
                    ShowAccounting();
                }
                comboBoxMedecine.SelectedItem = null;
                comboBoxPharmane.SelectedItem = null;
                textBoxQuantity.Text = "";
                textBoxPrice.Text = "";

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
