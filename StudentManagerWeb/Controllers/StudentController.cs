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
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var studentFromDb = _db.Students.Find(id);
            //var studentFromDb = _db.Students.FirstOrDefault(x => x.Id == id);
            //var studentFromDb = _db.Students.SingleOrDefault(x => x.Id == id);

            if (studentFromDb == null)
            {
                return NotFound();
            }
            return View(studentFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student obj)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Update(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Delete(int? id)
        {
            var studentFromDb = _db.Students.Find(id);
            if (studentFromDb == null) {
                return NotFound();
            }
            _db.Students.Remove(studentFromDb);
            _db.SaveChanges(); 

            return RedirectToAction("Index");
        }
    }
}
