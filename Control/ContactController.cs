using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCPractice.Model;

namespace MVCPractice.Control
{
    public static class ContactController
    {
        public static List<Contact> Contacts { get; set; } = new List<Contact>();

        public static void ReadContacts()
        {
            var tmp = FilesController.ReadContacts();
            if (tmp != null)
                Contacts = tmp;
        }

        public static void AddContact() => Contacts.Add(new Contact());
        public static void AddContact(Contact contact) => Contacts.Add(contact);
        public static void RemoveContact(int ind) => Contacts.RemoveAt(ind);
    }
}
