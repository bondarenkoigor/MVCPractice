using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPractice.Model
{
    public class Contact
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public List<string> Numbers { get; set; }

        public Contact(string name, string surname, string address, List<string> nums)
        {
            Name = name;
            Surname = surname;
            Address = address;
            Numbers = nums;
        }
        public Contact() : this("Name", "Surname", "Address", new List<string> { "number" }) { }

        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}
