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
    public partial class FormPharmacy : Form
    {
        public FormPharmacy()
        {
            InitializeComponent();
            ShowPharrmacy();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Pharmacy pharmacy = new Pharmacy();
            pharmacy.NamePharmacy = textBoxName.Text;
            pharmacy.Adress = textBoxAdress.Text;
            pharmacy.Post = textBoxPost.Text;
            pharmacy.Phone = textBoxPhone.Text;
            Program.pharmacy.Pharmacy.Add(pharmacy);
            Program.pharmacy.SaveChanges();
            ShowPharrmacy();
        }
        void ShowPharrmacy()
        {
            listViewPharmacy.Items.Clear();
            foreach(Pharmacy pharmacy in Program.pharmacy.Pharmacy)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    pharmacy.ID.ToString(),
                    pharmacy.NamePharmacy,
                    pharmacy.Adress,
                    pharmacy.Post,
                    pharmacy.Phone
                });
                item.Tag = pharmacy;
                listViewPharmacy.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewPharmacy.SelectedItems.Count == 1)
            {
                Pharmacy pharmacy = listViewPharmacy.SelectedItems[0].Tag as Pharmacy;
                pharmacy.NamePharmacy = textBoxName.Text;
                pharmacy.Adress = textBoxAdress.Text;
                pharmacy.Post = textBoxPost.Text;
                pharmacy.Phone = textBoxPhone.Text;
                Program.pharmacy.SaveChanges();
                ShowPharrmacy();
            }
        }

        private void listViewPharmacy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPharmacy.SelectedItems.Count ==1)
            {
                Pharmacy pharmacy = listViewPharmacy.SelectedItems[0].Tag as Pharmacy;
                textBoxName.Text = pharmacy.NamePharmacy;
                textBoxAdress.Text = pharmacy.Adress;
                textBoxPost.Text = pharmacy.Post;
                textBoxPhone.Text = pharmacy.Phone;
            }
            else
            {
                textBoxName.Text = "";
                textBoxAdress.Text = "";
                textBoxPost.Text = "";
                textBoxPhone.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPharmacy.SelectedItems.Count == 1)
                {
                    Pharmacy pharmacy = listViewPharmacy.SelectedItems[0].Tag as Pharmacy;
                    Program.pharmacy.Pharmacy.Remove(pharmacy);
                    Program.pharmacy.SaveChanges();
                    ShowPharrmacy();
                }
                textBoxName.Text = "";
                textBoxAdress.Text = "";
                textBoxPost.Text = "";
                textBoxPhone.Text = "";
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
