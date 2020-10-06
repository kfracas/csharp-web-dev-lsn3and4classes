using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Course
    {
        public string Name { get; set; }
        public int NumberOfCredits { get; set; }
        public Dictionary<string, int> EnrolledStudents { get; set; }

        public Course(string name, int numberOfCredits, Dictionary<string, int> enrolledStudents)
        {
            Name = name;
            NumberOfCredits = numberOfCredits;
            EnrolledStudents = enrolledStudents;
        }
    }
}
