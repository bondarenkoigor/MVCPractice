namespace MVCPractice.View.UserControls
{
    partial class ShortContactControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AvatarButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AvatarButton
            // 
            this.AvatarButton.BackColor = System.Drawing.SystemColors.Control;
            this.AvatarButton.BackgroundImage = global::MVCPractice.Properties.Resources.Google_Contacts_icon_svg;
            this.AvatarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AvatarButton.FlatAppearance.BorderSize = 0;
            this.AvatarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AvatarButton.Location = new System.Drawing.Point(0, 0);
            this.AvatarButton.Name = "AvatarButton";
            this.AvatarButton.Size = new System.Drawing.Size(100, 100);
            this.AvatarButton.TabIndex = 0;
            this.AvatarButton.UseVisualStyleBackColor = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(132, 23);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(61, 24);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabel.Location = new System.Drawing.Point(132, 47);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(87, 24);
            this.SurnameLabel.TabIndex = 2;
            this.SurnameLabel.Text = "Surname";
            // 
            // ShortContactControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AvatarButton);
            this.Name = "ShortContactControl";
            this.Size = new System.Drawing.Size(278, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        public System.Windows.Forms.Button AvatarButton;
    }
}
