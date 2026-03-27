using System;
using System.Collections.Generic;
using System.Linq;

namespace prakt15
{
    
    public class StudentGroup
    {
        private List<Student> students = new List<Student>();

        // Добавление одного студента
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        // Удаление студента по индексу
        public bool RemoveAt(int index)
        {
            if (index >= 0 && index < students.Count)
            {
                students.RemoveAt(index);
                return true;
            }
            return false;
        }

        // Поиск по фамилии
        public List<Student> FindByLastName(string lastName)
        {
            return students.Where(s => s.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // Поиск по дате рождения
        public List<Student> FindByBirthDate(DateTime birthDate)
        {
            return students.Where(s => s.BirthDate.Date == birthDate.Date).ToList();
        }

        // Сортировка по фамилии
        public List<Student> SortByLastName()
        {
            return students.OrderBy(s => s.LastName).ToList();
        }

        // Сортировка по дате рождения
        public List<Student> SortByBirthDate()
        {
            return students.OrderBy(s => s.BirthDate).ToList();
        }

        // Получить всех студентов
        public List<Student> GetAllStudents()
        {
            return students.ToList();
        }
    }
}
