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
using MVCPractice.Model;

namespace MVCPractice.View
{
    public partial class MainForm : Form
    {
        ContactController Controller;
        public MainForm()
        {
            Controller = new ContactController();
            InitializeComponent();
            this.ContactsListBox.Items.AddRange(Controller.Contacts.ToArray());
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ContactManagerForm form = new ContactManagerForm();
            form.ShowDialog();
            Controller.AddContact(form.Result);
            this.ContactsListBox.Items.Add(form.Result);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
            => FilesController.SaveContacts(Controller.Contacts);

        private void ContactsListBox_DoubleClick(object sender, EventArgs e)
        {
            
            if ((sender as ListBox).SelectedIndex < 0) return;
            DetailedContactForm form = new DetailedContactForm((sender as ListBox).SelectedItem as Contact);
            form.FormClosing += DetailedContactForm_FormClosing;
            form.Show();
        }

        private void DetailedContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = sender as DetailedContactForm;
            if (form.ShouldDelete)
            {
                this.ContactsListBox.Items.RemoveAt(this.ContactsListBox.Items.Cast<Contact>().ToList().FindIndex(contact => contact.id == form.ContactId));
                this.Controller.Contacts.RemoveAll(contact => contact.id == form.ContactId);
            }
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
