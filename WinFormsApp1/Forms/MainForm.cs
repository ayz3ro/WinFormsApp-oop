using System;
using System.Windows.Forms;
using System.Linq;

namespace WinFormsApp1.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private readonly StampCatalog stampCatalog = new StampCatalog();
        private readonly PhilatelistCatalog philatelistCatalog = new PhilatelistCatalog();


        private void btnFindStamps_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
            string name = txtStampName.Text.Trim();
            string country = txtStampCountry.Text.Trim();
            string feature = txtStampFeature.Text.Trim();

            decimal? nominalValue = decimal.TryParse(txtStampNominalValue.Text, out var value) ? value : (decimal?)null;
            int? year = int.TryParse(txtStampYear.Text, out var y) ? y : (int?)null;
            int? circulation = int.TryParse(txtStampCirculation.Text, out var c) ? c : (int?)null;

            var results = stampCatalog.FindStamps(
                name: string.IsNullOrWhiteSpace(name) ? null : name,
                country: string.IsNullOrWhiteSpace(country) ? null : country,
                nominalValue: nominalValue,
                year: year,
                circulation: circulation,
                feature: string.IsNullOrWhiteSpace(feature) ? null : feature
            );

            foreach (var stamp in results)
            {
                lstResults.Items.Add(stamp.ToString());
            }
        }

        private void btnFindPhilatelists_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();

            string name = txtPhilName.Text.Trim();
            string country = txtPhilCountry.Text.Trim();
            string contact = txtPhilContact.Text.Trim();
            string rareStampsText = txtPhilRareStamps.Text.Trim();

            bool? hasRareStamps = null;
            if (!string.IsNullOrWhiteSpace(rareStampsText))
            {
                if (bool.TryParse(rareStampsText, out bool parsed))
                {
                    hasRareStamps = parsed;
                }
                else
                {
                    MessageBox.Show("Поле \"Рідкісні марки\" повинно бути true або false.");
                    return;
                }
            }

            var results = philatelistCatalog.FindPhilatelists(
                name: string.IsNullOrWhiteSpace(name) ? null : name,
                country: string.IsNullOrWhiteSpace(country) ? null : country,
                contactInfo: string.IsNullOrWhiteSpace(contact) ? null : contact,
                hasRareStamps: hasRareStamps
            );

            foreach (var philatelist in results)
            {
                lstResults.Items.Add(philatelist.ToString());
            }
        }

        private void EditStampMenuItem_Click(object sender, EventArgs e)
        {
            var form = new EditStampForm(stampCatalog);
            form.ShowDialog();
        }
        private void EditPhilMenuItem_Click(object sender, EventArgs e)
        {
            var form = new EditPhilatelistForm(philatelistCatalog);
            form.ShowDialog();
        }
    }
}