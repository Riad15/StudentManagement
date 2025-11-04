using StudentManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DAL.Repository
{
    public class StudentRepository
    {
        private readonly StudentManagementDBContext _context;

        public StudentRepository(StudentManagementDBContext context)
        {
            _context = context;
        }


        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }
    }
}
