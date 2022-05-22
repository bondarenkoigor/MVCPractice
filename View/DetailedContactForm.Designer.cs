namespace MVCPractice.View
{
    partial class DetailedContactForm
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
            this.NumberList = new System.Windows.Forms.ListView();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AvatarPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // NumberList
            // 
            this.NumberList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumberList.Enabled = false;
            this.NumberList.HideSelection = false;
            this.NumberList.LabelWrap = false;
            this.NumberList.Location = new System.Drawing.Point(12, 306);
            this.NumberList.MultiSelect = false;
            this.NumberList.Name = "NumberList";
            this.NumberList.Size = new System.Drawing.Size(238, 97);
            this.NumberList.TabIndex = 4;
            this.NumberList.UseCompatibleStateImageBehavior = false;
            this.NumberList.View = System.Windows.Forms.View.List;
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(-13, 129);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(278, 39);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabel.Location = new System.Drawing.Point(-13, 168);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(278, 39);
            this.SurnameLabel.TabIndex = 2;
            this.SurnameLabel.Text = "Surname";
            this.SurnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddressLabel
            // 
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressLabel.Location = new System.Drawing.Point(-13, 207);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(278, 39);
            this.AddressLabel.TabIndex = 3;
            this.AddressLabel.Text = "Address";
            this.AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackgroundImage = global::MVCPractice.Properties.Resources.icon_delete_16;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteButton.Location = new System.Drawing.Point(217, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(41, 41);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AvatarPanel
            // 
            this.AvatarPanel.BackgroundImage = global::MVCPractice.Properties.Resources.Google_Contacts_icon_svg;
            this.AvatarPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AvatarPanel.Location = new System.Drawing.Point(67, 12);
            this.AvatarPanel.Name = "AvatarPanel";
            this.AvatarPanel.Size = new System.Drawing.Size(114, 114);
            this.AvatarPanel.TabIndex = 0;
            // 
            // DetailedContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 415);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NumberList);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AvatarPanel);
            this.Name = "DetailedContactForm";
            this.Text = "DetailedContactForm";
            this.Load += new System.EventHandler(this.DetailedContactForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AvatarPanel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.ListView NumberList;
        private System.Windows.Forms.Button DeleteButton;
    }
}