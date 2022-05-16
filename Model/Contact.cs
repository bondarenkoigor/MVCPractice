using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPractice.Model
{
    internal class Contact
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string[] Numbers { get; set; }

        public Contact(string name, string surname, string address, string[] nums)
        {
            Name = name;
            Surname = surname;
            Address = address;
            Numbers = nums;
        }
        public Contact() : this("Name", "Surname", "Address", new string[] { "number" }) { }
    }
}
