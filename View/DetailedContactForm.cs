using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCPractice.Model;

namespace MVCPractice.View
{
    public partial class DetailedContactForm : Form
    {
        public int ContactId { get; private set; }
        public bool ShouldDelete { get; private set; } = false;
        public DetailedContactForm()
        {
            InitializeComponent();
        }
        public DetailedContactForm(Contact contact) : this()
        {
            this.NameLabel.Text = contact.Name;
            this.SurnameLabel.Text = contact.Surname;
            this.AddressLabel.Text = contact.Address;
            this.ContactId = contact.id;
            foreach (string number in contact.Numbers)
            {
                this.NumberList.Items.Add(number);
            }
        }

        private void DetailedContactForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < this.NumberList.Columns.Count; i++)
            {
                this.NumberList.Columns[i].TextAlign = HorizontalAlignment.Center;
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ShouldDelete = true;
                this.Close();
            }
        }

    }
}
