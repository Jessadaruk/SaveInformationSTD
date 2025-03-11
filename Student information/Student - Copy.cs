using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_information
{
    internal class Student : Person
    {
        public string StudentID { get; set; }
        public Advisor Advisor { get; set; }
        public double Score { get; set; }

        public Student(string firstName, string lastName, string major, string studentID, Advisor advisor, double score)
            : base(firstName, lastName, major)
        {
            StudentID = studentID;
            Advisor = advisor;
            Score = score;
        }

        public override string ToString()
        {
            return $"{StudentID} - {FirstName} {LastName} ({Major}) - Advisor: {Advisor.FirstName} {Advisor.LastName} - Score: {Score}";
        }
    }
}
