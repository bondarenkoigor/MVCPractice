using MVCPractice.Control;
using MVCPractice.Model;


namespace MVCPractice.View
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddButton = new System.Windows.Forms.Button();
            this.ContactsPanel = new System.Windows.Forms.Panel();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(113, 362);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(93, 38);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ContactsPanel
            // 
            this.ContactsPanel.AutoScroll = true;
            this.ContactsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactsPanel.Location = new System.Drawing.Point(6, 35);
            this.ContactsPanel.Name = "ContactsPanel";
            this.ContactsPanel.Size = new System.Drawing.Size(307, 321);
            this.ContactsPanel.TabIndex = 2;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(40, 12);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(268, 20);
            this.SearchTextBox.TabIndex = 3;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MVCPractice.Properties.Resources.search_icon_png_21;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::MVCPractice.Properties.Resources.search_icon_png_21;
            this.pictureBox1.InitialImage = global::MVCPractice.Properties.Resources.search_icon_png_21;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 20);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 413);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ContactsPanel);
            this.Controls.Add(this.AddButton);
            this.Name = "MainForm";
            this.Text = "Contacts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel ContactsPanel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }

}

