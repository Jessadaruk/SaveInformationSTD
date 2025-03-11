using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_information
{
    internal class Advisor : Person
    {
        public List<Student> Students { get; set; }

        public Advisor(string firstName, string lastName, string major)
            : base(firstName, lastName, major)
        {
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public string DisplayAdvisorInfo
        {
            get { return $"{FirstName} {LastName} ({Major})"; }
        }
    }
}
