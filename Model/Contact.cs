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
        public List<string> Numbers { get; private set; }
        public int id { get; private set; }

        public static int idCounter = 0;
        public Contact(string name, string surname, string address, List<string> nums)
        {
            Name = name;
            Surname = surname;
            Address = address;
            Numbers = nums;
            id = ++idCounter;
        }
        public Contact() : this("Name", "Surname", "Address", new List<string> { "number" }) { }

        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}
