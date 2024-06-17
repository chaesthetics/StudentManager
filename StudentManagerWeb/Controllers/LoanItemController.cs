using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentManagerWeb.Data;
using StudentManagerWeb.Models;

namespace StudentManagerWeb.Controllers
{
    public class LoanItemController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LoanItemController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<LoanItem> loanItemList = _db.LoanItems;
            return View(loanItemList);
        }
        public IActionResult create()
        {
            var typeList = _db.loanTypes.ToList();
            ViewBag.TypeList = typeList;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult create(LoanItem obj)
        {
            if (ModelState.IsValid) { 
                _db.LoanItems.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
