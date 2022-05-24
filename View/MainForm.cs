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
using MVCPractice.View.UserControls;

namespace MVCPractice.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            ContactController.ReadContacts();
            InitializeComponent();
            AddAllContactsToPanel();
        }

        private void AddAllContactsToPanel()
        {
            foreach (Contact contact in ContactController.Contacts)
            {
                AddContactToPanel(contact);
            };
        }
        private void AddContactToPanel(Contact contact)
        {
            Point location = new Point(0, 0);
            for (int i = 0; i < this.ContactsPanel.Controls.Count; i++)
            {
                location = new Point(location.X, location.Y + 110);
            }
            ShortContactControl control = new ShortContactControl(contact);
            control.Location = location;

            control.AvatarButton.Click += (sender, e) =>
            {
                DetailedContactForm form = new DetailedContactForm(ContactController.Contacts.Find(_contact => _contact.id == control.ContactId));
                form.FormClosing += DetailedContactForm_FormClosing;
                form.Show();
            };

            this.ContactsPanel.Controls.Add(control);
        }

        private void DetailedContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = sender as DetailedContactForm;
            if (form.ShouldDelete)
            {
                this.ContactsPanel.Controls.RemoveAt(this.ContactsPanel.Controls.Cast<ShortContactControl>().ToList().FindIndex(contact => contact.ContactId == form.ContactId));
                ContactController.Contacts.RemoveAll(contact => contact.id == form.ContactId);
            }
            if(form.ShouldRedact != null)
            {
                ContactController.AddContact(form.ShouldRedact);
                this.AddContactToPanel(form.ShouldRedact);
            }
            ResetPositions();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ContactManagerForm form = new ContactManagerForm();
            form.ShowDialog();
            ContactController.AddContact(form.Result);

            AddContactToPanel(form.Result);
        }
        private void ResetPositions()
        {
            this.ContactsPanel.Controls.Clear();
            AddAllContactsToPanel();
        }

        private void SortContacts(string filter)
        {
            this.ContactsPanel.Controls.Clear();

            if(filter == String.Empty)
            {
                AddAllContactsToPanel();
                return;
            }

            foreach (Contact contact in ContactController.Contacts)
            {
               if(contact.Name.Contains(filter) || contact.Surname.Contains(filter)) AddContactToPanel(contact);
            };

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
            => FilesController.SaveContacts(ContactController.Contacts);



        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SortContacts((sender as TextBox).Text);
        }
    }
}
