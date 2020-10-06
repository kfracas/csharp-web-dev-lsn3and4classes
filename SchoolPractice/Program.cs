using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student studentOne = new Student("Kirby", 333456, 1, 4.0);
            Dictionary<string, int> studentIDs = new Dictionary<string, int>();
            studentIDs.Add(studentOne.Name, studentOne.StudentId);
            Course courseOne = new Course("Robotics", 20, studentIDs);
            Teacher teacherOne = new Teacher("Nala", "Bear", "Animal Science", 3);

            Console.WriteLine(studentOne.Name + " - ID: " + studentOne.StudentId + " Credits: " + studentOne.NumberOfCredits + " GPA: " + studentOne.Gpa);
            Console.WriteLine(courseOne.Name + " - Credits: " + courseOne.NumberOfCredits + " Enrolled Students: " + courseOne.EnrolledStudents.Keys + courseOne.EnrolledStudents.Values);
            Console.WriteLine(teacherOne.FirstName + teacherOne.LastName + " - Subject: " + teacherOne.Subject+ " Years Teaching: " + teacherOne.YearsTeaching);
        }
    }
}
