using Microsoft.AspNetCore.Mvc;
using StudentManagement.BLL.Services;
using StudentManagement.Model;

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



        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]

        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                // Code to add the student to the database would go here
                _studentService.AddStudent(student);

                return RedirectToAction("Index");
            }
            return View(student);
        }


    }
}
