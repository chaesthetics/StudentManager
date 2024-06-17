using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using StudentManagerWeb.Data;
using StudentManagerWeb.Models;

namespace StudentManagerWeb.Controllers
{
    public class LoanTypeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public LoanTypeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<LoanType> objLoantypeList = _db.loanTypes;
            return View(objLoantypeList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(LoanType obj)
        {
            if (ModelState.IsValid)
            {
                _db.loanTypes.Add(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id==0)
            {
                return NotFound();
            }
            var typeFromDb = _db.loanTypes.Find(id);
            if (typeFromDb == null)
            {
                return NotFound();
            }
            return View(typeFromDb); 
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(LoanType obj) {
            if (ModelState.IsValid) {
                _db.loanTypes.Update(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Delete(int? id) { 
            var TypeFromDb = _db.loanTypes.Find(id);
            if (TypeFromDb == null) {
                return NotFound();
            }
            _db.loanTypes.Remove(TypeFromDb);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
