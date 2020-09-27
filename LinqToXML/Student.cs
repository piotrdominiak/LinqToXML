using System;
using System.Collections.Generic;
using System.Text;

namespace LinqToXML
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender  { get; set; }
        public int TotalMarks { get; set; }

        public static Student[] GetAllStudens()
        {
            Student[] students = new Student[4];

            students[0] = new Student { Id = 102, Name = "Mark", Gender = "Male", TotalMarks = 800 };
            students[1] = new Student { Id = 103, Name = "Rosy", Gender = "Female", TotalMarks = 850 };
            students[2] = new Student { Id = 102, Name = "Pam", Gender = "Male", TotalMarks = 900 };
            students[3] = new Student { Id = 102, Name = "John", Gender = "Female", TotalMarks = 950 };

            return students;
        }

    }
}
