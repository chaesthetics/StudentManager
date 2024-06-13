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
    }
}
