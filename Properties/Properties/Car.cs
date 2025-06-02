using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Car
    {
        // private member variable/fields
        // access modifier private
        private string _name;
        private int _hp;
        private string _colour;

        // the public property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
