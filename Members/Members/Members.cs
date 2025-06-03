using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
    internal class Members
    {
        // member - private field
        private string memberName;
        private string jobTitle;
        private int salary;

        // member - public field
        public int age;

        // members - property - exposes job title safely - properties start with a capital letter
        public string JobTitle {
            get 
            {
                return jobTitle;
            }
            set 
            {
                jobTitle = value;
            } 
        }

        // public member Method - can be called from other classes.
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("HI m,y name is {0}, and my job title is {1}. I'm {2} years old", memberName, jobTitle, age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        //member constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            jobTitle = "Developer";
            salary = 60000;
            Console.WriteLine("Object created");
        }

        // member - finalizer - destructor (don't use if it's gonna be empty)
        ~Members()
        {
            //cleanup statements
            Console.WriteLine("Deconstruct of Member objects");
            Debug.Write("Destruction of Members object");
        }

    }
}
