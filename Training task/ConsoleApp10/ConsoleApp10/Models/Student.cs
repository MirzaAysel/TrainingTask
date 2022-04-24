using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10.Models
{
    class Student
    {
        public int Id { get;}
        private static int _Id;
        public string fullname;
        public int point;
        public int Password { get; set; }
        private  int _password;

        public Student()
        {
            ++_Id;
            Id = _Id;

        }
        public Student(string fullname, int point)
        {
            this.fullname = fullname;
            this.point = point;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"Id {Id}, fullname {fullname}, point {point}");
        }
    }
}
