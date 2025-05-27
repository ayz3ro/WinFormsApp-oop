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
    public partial class EditStampForm : Form
    {
        private StampCatalog catalog;

        public EditStampForm(StampCatalog catalog)
        {
            this.catalog = catalog;
            InitializeComponent();
            AttachEventHandlers();
        }
        private void AttachEventHandlers()
        {
            btnAddStamps.Click += BtnAddStamps_Click;
            btnEditStamps.Click += BtnEditStamps_Click;
            btnDeleteStamps.Click += BtnDeleteStamps_Click;
        }

        private bool TryCreateStampFromInput(out Stamp stamp)
        {
            stamp = null!;
            try
            {
                string name = txtStampName.Text.Trim();
                string country = txtStampCountry.Text.Trim();
                decimal? nominalValue = string.IsNullOrWhiteSpace(txtStampNominalValue.Text)
                    ? (decimal?)null
                    : decimal.Parse(txtStampNominalValue.Text.Trim());
                int? year = string.IsNullOrWhiteSpace(txtStampYear.Text)
                    ? (int?)null
                    : int.Parse(txtStampYear.Text.Trim());
                int? circulation = string.IsNullOrWhiteSpace(txtStampCirculation.Text)
                    ? (int?)null
                    : int.Parse(txtStampCirculation.Text.Trim());
                string features = txtStampFeature.Text.Trim();

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Назва не може бути порожня.");
                    return false;
                }

                if (year.HasValue && year.Value < 1000)
                {
                    MessageBox.Show("Рік не може бути меншим за 1000.");
                    return false;
                }

                stamp = new Stamp(name, country, nominalValue, year, circulation, features);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при зчитуванні даних: " + ex.Message);
                return false;
            }
        }
        private void BtnAddStamps_Click(object? sender, EventArgs e)
        {
            if (TryCreateStampFromInput(out Stamp stamp))
            {
                if (catalog.AddStamp(stamp))
                    MessageBox.Show("Марку додано успішно!");
                else
                    MessageBox.Show("Марка з такою назвою вже існує.");
            }
        }

        private void BtnEditStamps_Click(object? sender, EventArgs e)
        {
            if (TryCreateStampFromInput(out Stamp stamp))
            {
                if (catalog.EditStamp(stamp.Name, stamp))
                    MessageBox.Show("Марку оновлено.");
                else
                    MessageBox.Show("Марку не знайдено.");
            }
        }

        private void BtnDeleteStamps_Click(object? sender, EventArgs e)
        {
            string name = txtStampName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введіть назву марки.");
                return;
            }

            if (catalog.RemoveStamp(name))
                MessageBox.Show("Марку видалено.");
            else
                MessageBox.Show("Марку не знайдено.");
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
