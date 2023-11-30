using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTI.Models;

namespace KTI.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private static List<Student> _students = new List<Student>
        {
            new Student { StudentId = 1, Name = "Radit", Email = "Radit@gmail.com", BirthDate = new DateOnly(2000,02,05)},
            new Student { StudentId = 2, Name = "John Lenon", Email = "John@gmail.com", BirthDate = new DateOnly(2002,01,06)},
            new Student { StudentId = 3, Name = "Muslim", Email = "Muslim@gmail.com", BirthDate = new DateOnly(1999,09,09)},
            new Student { StudentId = 4, Name = "Udin", Email = "Udin@gmail.com", BirthDate = new DateOnly(2001,01,10)},
            new Student { StudentId = 5, Name = "Jengki", Email = "Jengki@gmail.com", BirthDate = new DateOnly(1998,09,25)},
        };
        public IEnumerable<Student> GetAll()
        {
            return _students;
        }

        public Student GetById(int id)
        {
            return _students.First(s => s.StudentId == id);
        }
    }
}