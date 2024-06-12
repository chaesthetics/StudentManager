using Microsoft.AspNetCore.Mvc;
using StudentManagerWeb.Data;
using StudentManagerWeb.Models;

namespace StudentManagerWeb.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _db;

        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Student> objStudentList= _db.Students;
            return View(objStudentList);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student obj)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Add(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
