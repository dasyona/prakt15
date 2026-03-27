using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt15
{
    class StudentGroup
    {
        private List<Student> students;

        public StudentGroup()
        {
            students = new List<Student>();
        }


        public int Count => students.Count;

     
        public void AddStudent(Student student)
        {
            if (student != null)
            {
                students.Add(student);
            }
        }

        public bool RemoveStudent(int index)
        {
            if (index >= 0 && index < students.Count)
            {
                students.RemoveAt(index);
                return true;
            }
            return false;
        }


        public bool RemoveStudent(Student student)
        {
            return students.Remove(student);
        }


        public List<Student> SearchByLastName(string lastName)
        {
            return students.Where(s => s.LastName.ToLower().Contains(lastName.ToLower())).ToList();
        }

   
        public List<Student> SearchByFirstName(string firstName)
        {
            return students.Where(s => s.FirstName.ToLower().Contains(firstName.ToLower())).ToList();
        }

        public List<Student> SearchByPhone(string phone)
        {
            return students.Where(s => s.PhoneNumber.Contains(phone)).ToList();
        }

        public List<Student> SearchByBirthDate(DateTime birthDate)
        {
            return students.Where(s => s.BirthDate.Date == birthDate.Date).ToList();
        }

   
        public void SortByLastName()
        {
            students = students.OrderBy(s => s.LastName).ThenBy(s => s.FirstName).ToList();
        }

  
        public void SortByFirstName()
        {
            students = students.OrderBy(s => s.FirstName).ThenBy(s => s.LastName).ToList();
        }

     
        public void SortByBirthDate()
        {
            students = students.OrderBy(s => s.BirthDate).ToList();
        }


        public void SortByPhone()
        {
            students = students.OrderBy(s => s.PhoneNumber).ToList();
        }

      
        public List<Student> GetAllStudents()
        {
            return new List<Student>(students);
        }


        public void Clear()
        {
            students.Clear();
        }
    }
}
