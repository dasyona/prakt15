using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt15
{
    public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }

        public Student(string lastName, string firstName, string phoneNumber, DateTime birthDate)
        {
            LastName = lastName;
            FirstName = firstName;
            PhoneNumber = phoneNumber;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }
    }
}
