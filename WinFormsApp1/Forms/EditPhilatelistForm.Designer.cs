using System.Windows.Forms;

namespace WinFormsApp1.Forms
{
    partial class EditPhilatelistForm
    {
        private System.Windows.Forms.TextBox txtPhilCountry;
        private System.Windows.Forms.TextBox txtPhilName;
        private System.Windows.Forms.TextBox txtPhilContact;
        private System.Windows.Forms.TextBox txtPhilRareStamps;
        private System.Windows.Forms.TextBox txtPhilCollection;
        private System.Windows.Forms.Button btnAddPhilatelist;
        private System.Windows.Forms.Button btnEditPhilatelist;
        private System.Windows.Forms.Button btnDeletePhilatelist;

        private void InitializeComponent()
        {
            txtPhilCountry = new TextBox();
            txtPhilName = new TextBox();
            txtPhilContact = new TextBox();
            txtPhilRareStamps = new TextBox();
            txtPhilCollection = new TextBox();
            btnAddPhilatelist = new Button();
            btnEditPhilatelist = new Button();
            btnDeletePhilatelist = new Button();
            SuspendLayout();

            // 
            // txtPhilName
            // 
            txtPhilName.Location = new Point(20, 40);
            txtPhilName.Size = new Size(130, 23);
            txtPhilName.MaxLength = 50;
            txtPhilName.PlaceholderText = "Ім'я";
            txtPhilName.Name = "txtPhilName";
            //
            // txtPhilCountry
            //
            txtPhilCountry.Location = new Point(155, 40);
            txtPhilCountry.Size = new Size(110, 23);
            txtPhilCountry.MaxLength = 15;
            txtPhilCountry.PlaceholderText = "Країна";
            txtPhilCountry.Name = "txtPhilCountry";
            // 
            // txtPhilContact
            // 
            txtPhilContact.Location = new Point(270, 40);
            txtPhilContact.Size = new Size(140, 23);
            txtPhilContact.MaxLength = 10;
            txtPhilContact.PlaceholderText = "Номер";
            txtPhilContact.Name = "txtPhilContact";
            // 
            // txtPhilRareStamps
            // 
            txtPhilRareStamps.Location = new Point(415, 40);
            txtPhilRareStamps.Size = new Size(115, 23);
            txtPhilRareStamps.MaxLength = 4;
            txtPhilRareStamps.PlaceholderText = "Рідкісні марки";
            txtPhilRareStamps.Name = "txtPhilRareStamps";
            // 
            // txtPhilCollection
            // 
            txtPhilCollection.Location = new Point(20, 70);
            txtPhilCollection.Size = new Size(250, 23);
            txtPhilCollection.MaxLength = 250;
            txtPhilCollection.PlaceholderText = "Власна колекція";
            txtPhilCollection.Name = "txtPhilCollection";
            //
            // btnAddStamps
            //
            btnAddPhilatelist.Location = new Point(280, 70);
            btnAddPhilatelist.Size = new Size(80, 23);
            btnAddPhilatelist.Text = "Додати";
            //
            // btnEditStamps
            //
            btnEditPhilatelist.Location = new Point(365, 70);
            btnEditPhilatelist.Size = new Size(80, 23);
            btnEditPhilatelist.Text = "Редагувати";
            //
            // btnDeleteStamps
            //
            btnDeletePhilatelist.Location = new Point(450, 70);
            btnDeletePhilatelist.Size = new Size(80, 23);
            btnDeletePhilatelist.Text = "Видалити";

            // --- MainForm ---
            ClientSize = new Size(550, 150);
            Controls.Add(txtPhilName);
            Controls.Add(txtPhilCountry);
            Controls.Add(txtPhilContact);
            Controls.Add(txtPhilRareStamps);
            Controls.Add(txtPhilCollection);
            Controls.Add(btnAddPhilatelist);
            Controls.Add(btnEditPhilatelist);
            Controls.Add(btnDeletePhilatelist);
            Name = "MainForm";
            Text = "Філателіст - Редагування";
            ResumeLayout(false);
            PerformLayout();
        }

    }
}