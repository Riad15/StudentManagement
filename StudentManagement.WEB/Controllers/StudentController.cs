using Microsoft.AspNetCore.Mvc;
using StudentManagement.BLL.Services;

namespace StudentManagement.WEB.Controllers
{
    public class StudentController : Controller
    {

        private readonly StudentService _studentService;

        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult Index()
        {

            var students = _studentService.GetAllStudents();
            return View(students);
        }
    }
}
