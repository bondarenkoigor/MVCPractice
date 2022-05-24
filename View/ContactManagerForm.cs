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
    public partial class ContactManagerForm : Form
    {
        public ContactManagerForm()
        {
            InitializeComponent();
        }

        public ContactManagerForm(Contact contact) : this()
        {
            this.NameTextBox.Text = contact.Name;
            this.SurnameTextBox.Text = contact.Surname;
            this.AddressTextBox.Text = contact.Address;
            this.NumbersTextBox.Text = String.Join("\n", contact.Numbers);
            this.AddButton.Text = "Confirm";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            List<string> numbers = NumbersTextBox.Text.Split('\n').ToList<string>();
            Result = new Contact(NameTextBox.Text, SurnameTextBox.Text, AddressTextBox.Text, numbers);
            this.Close();
        }

        public Contact Result = null;
    }
}
