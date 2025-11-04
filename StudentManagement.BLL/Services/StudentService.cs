using StudentManagement.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.BLL.Services
{
    public class StudentService
    {

        private readonly StudentRepository _studentRepository;

        public StudentService(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }


        public IEnumerable<Model.Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();
        }
    }
}
