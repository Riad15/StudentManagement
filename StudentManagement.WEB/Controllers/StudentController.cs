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
               
                _studentService.AddStudent(student);

                return RedirectToAction("Index");
            }
            return View(student);
        }


        public IActionResult Edit(int id)
        {
            var student = _studentService.GetAllStudents().FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }


        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                
                _studentService.UpdateStudent(student);

                return RedirectToAction("Index");
            }
            return View(student);
        }


        public IActionResult Delete(int id)
        {
            var student = _studentService.GetAllStudents().FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _studentService.DeleteStudent(id);
            return RedirectToAction("Index");
        }


        public IActionResult Details(int id)
        {
            var student = _studentService.GetAllStudents().FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }





    }
}
