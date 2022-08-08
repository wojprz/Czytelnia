using Czytelnia.Data;
using Czytelnia.Models;
using Microsoft.AspNetCore.Mvc;

namespace Czytelnia.Controllers
{
    public class CzytelniaController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CzytelniaController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int page = 1)
        {
            IEnumerable<Book> objBookList = _db.Books.Skip((page - 1) * 10).Take(10).OrderBy(x => x.DateOfAddition);
            return View(objBookList);
        }
    }
}
