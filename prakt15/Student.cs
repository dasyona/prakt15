using System;
using System.Collections.Generic;

namespace prakt15
{
    public class Student
    {

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }

        public Student(string lastName, string firstName, string phone, DateTime birthDate)
        {
            LastName = lastName;
            FirstName = firstName;
            Phone = phone;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName}, тел: {Phone}, дата рождения: {BirthDate.ToShortDateString()}";
        }
    }
}
