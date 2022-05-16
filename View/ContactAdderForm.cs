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
    public partial class ContactAdderForm : Form
    {
        public ContactAdderForm()
        {
            InitializeComponent();
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
