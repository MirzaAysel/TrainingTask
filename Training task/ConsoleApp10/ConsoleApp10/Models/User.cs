using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10.Models
{
    class User
    {
        public int Id { get; }
        private static int _Id;
        public string fullname;
        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        public string email;

        public User()
        {
            ++_Id;
            Id = _Id;

        }
        public User(string email, string password)
        {
            this.email = email;
            _password = password;
        }
        public  void ShowInfo()
        {
            Console.WriteLine($"Id {Id}, fullname {fullname}, email {email}");
        }
        public bool PasswordChecker(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            bool checkUpper = false;
            bool checkLower = false;
            bool checkNum = false;

            foreach (var item in password)
            {
                if (char.IsUpper(item))
                {
                    checkUpper = true;
                }
                if (char.IsLower(item))
                {
                    checkLower = true;
                }
                if (char.IsDigit(item))
                    checkNum = true;
            }
            if (checkNum && checkLower && checkUpper)
            {
                return true;
            }
            return false;

        }
    }
}
