using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCPractice.Control;

namespace MVCPractice.View
{
    public partial class Form1 : Form
    {
        ContactController Controller;
        public Form1()
        {
            Controller = new ContactController();
            InitializeComponent();
            this.ContactsListBox.Items.AddRange(Controller.Contacts.ToArray());
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ContactAdderForm form = new ContactAdderForm();
            form.ShowDialog();
            Controller.AddContact(form.Result);
            this.ContactsListBox.Items.Add(form.Result);
        }
    }
}
