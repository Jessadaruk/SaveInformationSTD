using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_information
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }

        public Person(string firstName, string lastName, string major)
        {
            FirstName = firstName;
            LastName = lastName;
            Major = major;
        }
    }
}
