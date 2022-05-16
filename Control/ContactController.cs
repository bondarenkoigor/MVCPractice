using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCPractice.Model;

namespace MVCPractice.Control
{
    internal class ContactController
    {
        public List<Contact> Contacts { get; set; }

        public ContactController() => Contacts = new List<Contact>();

        public void AddContact() => Contacts.Add(new Contact());

        public void RemoveContact(int ind) => Contacts.RemoveAt(ind);
    }
}
