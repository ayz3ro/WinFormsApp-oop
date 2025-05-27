namespace WinFormsApp1.Forms
{
    partial class MainForm
    {
        private System.Windows.Forms.TextBox txtStampName;
        private System.Windows.Forms.TextBox txtStampCountry;
        private System.Windows.Forms.TextBox txtStampNominalValue;
        private System.Windows.Forms.TextBox txtStampYear;
        private System.Windows.Forms.TextBox txtStampCirculation;
        private System.Windows.Forms.TextBox txtStampFeature;
        private System.Windows.Forms.TextBox txtPhilCountry;
        private System.Windows.Forms.TextBox txtPhilName;
        private System.Windows.Forms.TextBox txtPhilContact;
        private System.Windows.Forms.TextBox txtPhilRareStamps;
        private System.Windows.Forms.TextBox txtPhilCollection;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileMenuItem;
        private ToolStripMenuItem editMenuItem;
        private ToolStripMenuItem infoMenuItem;
        private ToolStripMenuItem addEditStampMenuItem;
        private ToolStripMenuItem addEditPhilatelistMenuItem;
        private ToolStripMenuItem addVersionInfoMenuItem;
        private System.Windows.Forms.Button btnFindStamps;
        private System.Windows.Forms.Button btnFindPhilatelists;
        private System.Windows.Forms.ListBox lstResults;

        private void InitializeComponent()
        {
            txtStampName = new TextBox();
            txtStampCountry = new TextBox();
            txtStampNominalValue = new TextBox();
            txtStampYear = new TextBox();
            txtStampCirculation = new TextBox();
            txtStampFeature = new TextBox();
            txtPhilCountry = new TextBox();
            txtPhilName = new TextBox();
            txtPhilContact = new TextBox();
            txtPhilRareStamps = new TextBox();
            // txtPhilCollection = new TextBox();
            btnFindStamps = new Button();
            btnFindPhilatelists = new Button();
            lstResults = new ListBox();
            menuStrip = new MenuStrip();
            fileMenuItem = new ToolStripMenuItem();
            editMenuItem = new ToolStripMenuItem();
            addEditStampMenuItem = new ToolStripMenuItem();
            addEditPhilatelistMenuItem = new ToolStripMenuItem();
            infoMenuItem = new ToolStripMenuItem();
            addVersionInfoMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // txtStampName
            // 
            txtStampName.Location = new Point(20, 40);
            txtStampName.Name = "txtStampName";
            txtStampName.MaxLength = 100;
            txtStampName.PlaceholderText = "Назва";
            txtStampName.Size = new Size(150, 23);
            txtStampName.TabIndex = 1;
            // 
            // txtStampCountry
            // 
            txtStampCountry.Location = new Point(180, 40);
            txtStampCountry.Name = "txtStampCountry";
            txtStampCountry.MaxLength = 15;
            txtStampCountry.PlaceholderText = "Країна";
            txtStampCountry.Size = new Size(100, 23);
            txtStampCountry.TabIndex = 2;
            // 
            // txtStampNominalValue
            // 
            txtStampNominalValue.Location = new Point(290, 40);
            txtStampNominalValue.Name = "txtStampNominalValue";
            txtStampNominalValue.PlaceholderText = "Вартість";
            txtStampNominalValue.MaxLength = 10;
            txtStampNominalValue.Size = new Size(80, 23);
            txtStampNominalValue.TabIndex = 3;
            // 
            // txtStampYear
            // 
            txtStampYear.Location = new Point(380, 40);
            txtStampYear.Name = "txtStampYear";
            txtStampYear.PlaceholderText = "Рік";
            txtStampYear.MaxLength = 4;
            txtStampYear.Size = new Size(60, 23);
            txtStampYear.TabIndex = 4;
            // 
            // txtStampCirculation
            // 
            txtStampCirculation.Location = new Point(450, 40);
            txtStampCirculation.Name = "txtStampCirculation";
            txtStampCirculation.PlaceholderText = "Тираж";
            txtStampCirculation.MaxLength = 10;
            txtStampCirculation.Size = new Size(80, 23);
            txtStampCirculation.TabIndex = 5;
            // 
            // txtStampFeature
            // 
            txtStampFeature.Location = new Point(20, 70);
            txtStampFeature.Name = "txtStampFeature";
            txtStampFeature.PlaceholderText = "Особливості";
            txtStampFeature.MaxLength = 250;
            txtStampFeature.Size = new Size(250, 23);
            txtStampFeature.TabIndex = 6;
            // 
            // txtPhilName
            // 
            txtPhilName.Location = new Point(20, 110);
            txtPhilName.Name = "txtPhilName";
            txtPhilName.MaxLength = 50;
            txtPhilName.PlaceholderText = "Ім'я";
            txtPhilName.Size = new Size(150, 23);
            txtPhilName.TabIndex = 8;
            // 
            // txtPhilCountry
            // 
            txtPhilCountry.Location = new Point(180, 110);
            txtPhilCountry.Name = "txtPhilCountry";
            txtPhilCountry.PlaceholderText = "Країна";
            txtPhilCountry.MaxLength = 15;
            txtPhilCountry.Size = new Size(120, 23);
            txtPhilCountry.TabIndex = 9;
            // 
            // txtPhilContact
            // 
            txtPhilContact.Location = new Point(310, 110);
            txtPhilContact.Name = "txtPhilContact";
            txtPhilContact.PlaceholderText = "Контактні координати";
            txtPhilContact.MaxLength = 10;
            txtPhilContact.Size = new Size(150, 23);
            txtPhilContact.TabIndex = 10;
            // 
            // txtPhilRareStamps
            // 
            txtPhilRareStamps.Location = new Point(20, 140);
            txtPhilRareStamps.Name = "txtPhilRareStamps";
            txtPhilRareStamps.MaxLength = 4;
            txtPhilRareStamps.PlaceholderText = "Рідкісні марки (є/нема)";
            txtPhilRareStamps.Size = new Size(200, 23);
            txtPhilRareStamps.TabIndex = 11;
            // 
            // txtPhilCollection
            // 
            // txtPhilCollection.Location = new Point(230, 140);
            // txtPhilCollection.Name = "txtPhilCollection";
            // txtPhilCollection.PlaceholderText = "Власна колекція";
            // txtPhilCollection.Size = new Size(230, 23);
            // txtPhilCollection.TabIndex = 12;
            // 
            // btnFindStamps
            // 
            btnFindStamps.Location = new Point(280, 70);
            btnFindStamps.Name = "btnFindStamps";
            btnFindStamps.Size = new Size(120, 23);
            btnFindStamps.TabIndex = 7;
            btnFindStamps.Text = "Пошук Марок";
            btnFindStamps.Click += btnFindStamps_Click;
            // 
            // btnFindPhilatelists
            // 
            btnFindPhilatelists.Location = new Point(230, 140);
            btnFindPhilatelists.Name = "btnFindPhilatelists";
            btnFindPhilatelists.Size = new Size(230, 23);
            btnFindPhilatelists.TabIndex = 13;
            btnFindPhilatelists.Text = "Пошук Філателістів";
            btnFindPhilatelists.Click += btnFindPhilatelists_Click;
            // 
            // lstResults
            // 
            lstResults.HorizontalExtent = 1000;
            lstResults.HorizontalScrollbar = true;
            lstResults.ItemHeight = 15;
            lstResults.Location = new Point(20, 180);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(520, 199);
            lstResults.TabIndex = 14;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileMenuItem, editMenuItem, infoMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(570, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // fileMenuItem
            // 
            fileMenuItem.Name = "fileMenuItem";
            fileMenuItem.Size = new Size(37, 20);
            fileMenuItem.Text = "File";
            // 
            // editMenuItem
            // 
            editMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addEditStampMenuItem, addEditPhilatelistMenuItem });
            editMenuItem.Name = "editMenuItem";
            editMenuItem.Size = new Size(39, 20);
            editMenuItem.Text = "Edit";
            // 
            // addEditStampMenuItem
            // 
            addEditStampMenuItem.Name = "addEditStampMenuItem";
            addEditStampMenuItem.Size = new Size(32, 19);
            addEditStampMenuItem.Text = "Змінити марку";
            addEditStampMenuItem.Click += EditStampMenuItem_Click;
            // 
            // addEditPhilatelistMenuItem
            // 
            addEditPhilatelistMenuItem.Name = "addEditPhilatelistMenuItem";
            addEditPhilatelistMenuItem.Size = new Size(32, 19);
            addEditPhilatelistMenuItem.Text = "Змінити філателіста";
            addEditPhilatelistMenuItem.Click += EditPhilMenuItem_Click;
            // 
            // infoMenuItem
            // 
            infoMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addVersionInfoMenuItem });
            infoMenuItem.Name = "infoMenuItem";
            infoMenuItem.Size = new Size(40, 20);
            infoMenuItem.Text = "Info";
            // 
            // addVersionInfoMenuItem
            // 
            addVersionInfoMenuItem.Name = "addVersionInfoMenuItem";
            addVersionInfoMenuItem.Size = new Size(32, 19);
            addVersionInfoMenuItem.Text = "Версія 0.1.0";
            // 
            // MainForm
            // 
            ClientSize = new Size(570, 400);
            Controls.Add(menuStrip);
            Controls.Add(txtStampName);
            Controls.Add(txtStampCountry);
            Controls.Add(txtStampNominalValue);
            Controls.Add(txtStampYear);
            Controls.Add(txtStampCirculation);
            Controls.Add(txtStampFeature);
            Controls.Add(btnFindStamps);
            Controls.Add(txtPhilCountry);
            Controls.Add(txtPhilName);
            Controls.Add(txtPhilContact);
            Controls.Add(txtPhilRareStamps);
            // Controls.Add(txtPhilCollection);
            Controls.Add(btnFindPhilatelists);
            Controls.Add(lstResults);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Text = "Довідник філателіста";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}