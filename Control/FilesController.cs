using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MVCPractice.Model;

namespace MVCPractice.Control
{
    internal static class FilesController
    {
        public static void SaveContacts(List<Contact> contacts)
        {
            File.WriteAllText("Contacts.txt", "");
            foreach (Contact contact in contacts)
            {
                string name = contact.Name;
                string surname = contact.Surname;
                string address = contact.Address;
                string numbers = String.Join("/", contact.Numbers.ToArray());
                File.AppendAllText("Contacts.txt", String.Format("{0}|{1}|{2}|{3}\n", name, surname, address, numbers));
            }
        }
        public static List<Contact> ReadContacts()
        {
            if (!File.Exists("Contacts.txt")) return null;
            string[] fileContents = File.ReadAllLines("Contacts.txt");
            List<Contact> contacts = new List<Contact>();
            foreach(string line in fileContents)
            {
                string[] splitLine = line.Split('|');
                string name = splitLine[0], surname = splitLine[1], address = splitLine[2];
                string[] numbers = splitLine[3].Split('/');
                contacts.Add(new Contact(name, surname, address, numbers.ToList<string>()));
            }
            return contacts;
        }
    }
}
