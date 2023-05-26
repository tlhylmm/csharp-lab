using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _152120211114_Lab2
{
    internal class Student
    {
        public Student(string _username, string _password)
        {
            username = _username;
            password = _password;
        }
        public string username { get; set; }
        public string password { get; set; }

    }
}
