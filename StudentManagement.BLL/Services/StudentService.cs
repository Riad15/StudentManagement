using StudentManagement.DAL.Repository;
using StudentManagement.Model;
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


        public IEnumerable<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();
        }


        public void AddStudent(Student student)
        {
            _studentRepository.AddStudent(student);
        }


        public void UpdateStudent(Student student)
        {
            _studentRepository.UpdateStudent(student);
        }
    }
}
