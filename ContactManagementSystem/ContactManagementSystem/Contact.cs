using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementSystem
{
    internal class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public void DisplayContact()
        {
            Console.WriteLine($"Name: {Name}, Phone: {PhoneNumber}, Email: {Email}");
        }
    }
}
