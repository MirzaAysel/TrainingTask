using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10.Models
{
    class Group
    {
        private string _groupNo;
        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if (CheckGroupNo(value))
                    _groupNo = value;
            }
        } 
        public static bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length == 5)
            {
                if (char.IsLetter(groupNo[0]) && char.IsLetter(groupNo[1]))
                {
                    if (char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]))
                    { return true; }
                }
            }
            return false;
        }
        private int _studentLimit;
        public int StudentLimit
        {
            get
            {
                return _studentLimit;
            }
            set
            {
                if (value > 5 && value < 18)
                {
                    _studentLimit = value;
                }
            }
        }
        public Group(string groupNo, int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
        }
        private static Student[] students;
        public void AddStudent(Student student)
        {
            if (students.Length<StudentLimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[^1] = student;

            }
            else
            {
                Console.WriteLine("Siz tələbə limitinə çatdınız");
            }
        }
        public Student GetStudent(int id)
        {
            if (id != null && students.Length > 0)
            {
                foreach (var student in students)
                {
                    if (student.Id == id)
                        return student;
                }
            }

            return null;
        }
        public Student[] GetAllStudents()
        {
            return students;
        }
    }
}
