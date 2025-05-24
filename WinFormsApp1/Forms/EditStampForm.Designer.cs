using System.Windows.Forms;

namespace WinFormsApp1.Forms
{
    partial class EditStampForm
    {
        private System.Windows.Forms.TextBox txtStampName;
        private System.Windows.Forms.TextBox txtStampCountry;
        private System.Windows.Forms.TextBox txtStampNominalValue;
        private System.Windows.Forms.TextBox txtStampYear;
        private System.Windows.Forms.TextBox txtStampCirculation;
        private System.Windows.Forms.TextBox txtStampFeature;
        private System.Windows.Forms.Button btnAddStamps;
        private System.Windows.Forms.Button btnEditStamps;
        private System.Windows.Forms.Button btnDeleteStamps;
        private void InitializeComponent()
        {
            txtStampName = new TextBox();
            txtStampCountry = new TextBox();
            txtStampNominalValue = new TextBox();
            txtStampYear = new TextBox();
            txtStampCirculation = new TextBox();
            txtStampFeature = new TextBox();
            btnAddStamps = new Button();
            btnEditStamps = new Button();
            btnDeleteStamps = new Button();
            SuspendLayout();
            // 
            // txtStampName
            // 
            txtStampName.Location = new Point(20, 40);
            txtStampName.Name = "txtStampName";
            txtStampName.PlaceholderText = "Назва";
            txtStampName.Size = new Size(150, 23);
            txtStampName.TabIndex = 0;
            // 
            // txtStampCountry
            // 
            txtStampCountry.Location = new Point(180, 40);
            txtStampCountry.Name = "txtStampCountry";
            txtStampCountry.PlaceholderText = "Країна";
            txtStampCountry.Size = new Size(100, 23);
            txtStampCountry.TabIndex = 1;
            // 
            // txtStampNominalValue
            // 
            txtStampNominalValue.Location = new Point(290, 40);
            txtStampNominalValue.Name = "txtStampNominalValue";
            txtStampNominalValue.PlaceholderText = "Вартість";
            txtStampNominalValue.Size = new Size(80, 23);
            txtStampNominalValue.TabIndex = 2;
            // 
            // txtStampYear
            // 
            txtStampYear.Location = new Point(380, 40);
            txtStampYear.Name = "txtStampYear";
            txtStampYear.PlaceholderText = "Рік";
            txtStampYear.Size = new Size(60, 23);
            txtStampYear.TabIndex = 3;
            // 
            // txtStampCirculation
            // 
            txtStampCirculation.Location = new Point(450, 40);
            txtStampCirculation.Name = "txtStampCirculation";
            txtStampCirculation.PlaceholderText = "Тираж";
            txtStampCirculation.Size = new Size(80, 23);
            txtStampCirculation.TabIndex = 4;
            // 
            // txtStampFeature
            // 
            txtStampFeature.Location = new Point(20, 70);
            txtStampFeature.Name = "txtStampFeature";
            txtStampFeature.PlaceholderText = "Особливості";
            txtStampFeature.Size = new Size(250, 23);
            txtStampFeature.TabIndex = 5;
            //
            // btnAddStamps
            //
            btnAddStamps.Location = new Point(280, 70);
            btnAddStamps.Size = new Size(80, 23);
            btnAddStamps.Text = "Додати";
            //
            // btnEditStamps
            //
            btnEditStamps.Location = new Point(365, 70);
            btnEditStamps.Size = new Size(80, 23);
            btnEditStamps.Text = "Редагувати";
            //
            // btnDeleteStamps
            //
            btnDeleteStamps.Location = new Point(450, 70);
            btnDeleteStamps.Size = new Size(80, 23);
            btnDeleteStamps.Text = "Видалити";
            // 
            // EditStampForms
            // 
            ClientSize = new Size(567, 180);
            Controls.Add(txtStampName);
            Controls.Add(txtStampCountry);
            Controls.Add(txtStampNominalValue);
            Controls.Add(txtStampYear);
            Controls.Add(txtStampCirculation);
            Controls.Add(txtStampFeature);
            Controls.Add(btnAddStamps);
            Controls.Add(btnEditStamps);
            Controls.Add(btnDeleteStamps);
            Name = "EditStampForm";
            Text = "Марка - Редагування";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}