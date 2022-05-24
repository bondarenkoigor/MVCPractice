namespace MVCPractice.View
{
    partial class ContactManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.PhoneNumbersLabel = new System.Windows.Forms.Label();
            this.NumbersTextBox = new System.Windows.Forms.RichTextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(112, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(112, 38);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.SurnameTextBox.TabIndex = 1;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(112, 64);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddressTextBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(29, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name:";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(29, 44);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(52, 13);
            this.SurnameLabel.TabIndex = 4;
            this.SurnameLabel.Text = "Surname:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(29, 70);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(48, 13);
            this.AddressLabel.TabIndex = 5;
            this.AddressLabel.Text = "Address:";
            // 
            // PhoneNumbersLabel
            // 
            this.PhoneNumbersLabel.AutoSize = true;
            this.PhoneNumbersLabel.Location = new System.Drawing.Point(29, 109);
            this.PhoneNumbersLabel.Name = "PhoneNumbersLabel";
            this.PhoneNumbersLabel.Size = new System.Drawing.Size(83, 13);
            this.PhoneNumbersLabel.TabIndex = 6;
            this.PhoneNumbersLabel.Text = "PhoneNumbers:";
            // 
            // NumbersTextBox
            // 
            this.NumbersTextBox.Location = new System.Drawing.Point(112, 106);
            this.NumbersTextBox.Name = "NumbersTextBox";
            this.NumbersTextBox.Size = new System.Drawing.Size(100, 96);
            this.NumbersTextBox.TabIndex = 7;
            this.NumbersTextBox.Text = "";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(64, 211);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(98, 52);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ContactManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 275);
            this.Controls.Add(this.NumbersTextBox);
            this.Controls.Add(this.PhoneNumbersLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.AddButton);
            this.Name = "ContactManagerForm";
            this.Text = "Add Contact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label PhoneNumbersLabel;
        private System.Windows.Forms.RichTextBox NumbersTextBox;
        public System.Windows.Forms.Button AddButton;
    }
}