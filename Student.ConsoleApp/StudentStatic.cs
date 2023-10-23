using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.ConsoleApp
{
    public static class StudentStatic
    {
        public static string FirstName { get; set; }
        public static string LastName { get; set; }

        public static string GetFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }
}
