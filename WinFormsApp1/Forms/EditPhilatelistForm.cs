using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Forms
{
    public partial class EditPhilatelistForm : Form
    {
        private PhilatelistCatalog catalog;

        public EditPhilatelistForm(PhilatelistCatalog catalog)
        {
            this.catalog = catalog;
            InitializeComponent();
            AttachEventHandlers();
        }

        private bool TryCreatePhilatelistFromInput(out Philatelist philatelist)
        {
            philatelist = null!;
            try
            {
                string name = txtPhilName.Text.Trim();
                string country = txtPhilCountry.Text.Trim();
                string contact = txtPhilContact.Text.Trim();
                string rarePhilatelistStamps = txtPhilRareStamps.Text.Trim();
                string collectionText = txtPhilCollection.Text.Trim();

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Ім'я не може бути порожнім.");
                    return false;
                }

                bool hasRareStamps = false;
                if (!string.IsNullOrWhiteSpace(rarePhilatelistStamps))
                {
                    if (!bool.TryParse(rarePhilatelistStamps, out hasRareStamps))
                    {
                        MessageBox.Show("Поле \"Рідкісні марки\" повинно бути true або false.");
                        return false;
                    }
                }

                List<Stamp> collection = new List<Stamp>();
                if (!string.IsNullOrWhiteSpace(collectionText))
                {
                    string[] stampNames = collectionText.Split(',', StringSplitOptions.RemoveEmptyEntries);
                    foreach (var stampName in stampNames)
                    {
                        collection.Add(new Stamp(stampName.Trim(), "", null, null, null, ""));
                    }
                }

                philatelist = new Philatelist(name, country, contact, hasRareStamps, collection);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при зчитуванні даних:");
                return false;
            }
        }
        private void AttachEventHandlers()
        {
            btnAddPhilatelist.Click += btnAddPhilatelist_Click;
            btnEditPhilatelist.Click += btnEditPhilatelist_Click;
            btnDeletePhilatelist.Click += btnDeletePhilatelist_Click;
        }

        private void btnAddPhilatelist_Click(object? sender, EventArgs e)
        {
            if (TryCreatePhilatelistFromInput(out Philatelist philatelist))
            {
                if (catalog.AddPhilatelist(philatelist))
                    MessageBox.Show("Філателіста додано успішно!");
                else
                    MessageBox.Show("Філателіста з таким імʼям вже існує.");
            }
        }

        private void btnEditPhilatelist_Click(object? sender, EventArgs e)
        {
            if (TryCreatePhilatelistFromInput(out Philatelist philatelist))
            {
                if (catalog.EditPhilatelist(philatelist.Name, philatelist))
                    MessageBox.Show("Філателіста оновлено.");
                else
                    MessageBox.Show("Філателіста не знайдено.");
            }
        }

        private void btnDeletePhilatelist_Click(object? sender, EventArgs e)
        {
            string name = txtPhilName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введіть імʼя Філателіста.");
                return;
            }

            if (catalog.RemovePhilatelist(name))
                MessageBox.Show("Філателіста видалено.");
            else
                MessageBox.Show("Філателіста не знайдено.");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close(); 
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
