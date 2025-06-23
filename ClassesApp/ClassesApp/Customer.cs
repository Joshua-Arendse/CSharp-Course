using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Customer
    {
        // Static field to hold the next ID available
        private static int nextId = 0;

        // Read-Only instance field initialized from the constructor
        private readonly int _id;

        // Backking field for write-only properties
        private string _password;

        // Write-Only property
        public string Password
        {
            set
            {
                _password = value;
            }
        }


        // Read-Only Property
        public int Id { 
            get
            {  return _id; }
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // Default Constructor
        public Customer()
        {
            _id = nextId++;
            Name = "DefaultName";
            Address = "Unkknown";
            ContactNumber = "No ContactNumber";
        }


        // Custom Constructor
        public Customer(string name,string address, string contactNumber)
        {
            _id = nextId++;
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
        public Customer(string name)
        {
            Name = name;
        }
        // Default Parameter contactNumber
        public void SetDetails(string name, string address ="NA", string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public void GetDetails() 
        { 
            Console.WriteLine($"Details about the customer: Name is {Name} and ID is {_id} ad the passsword is {_password}");
        }
    }
}
