using Articles.Models;
using Microsoft.AspNetCore.Mvc;

namespace Articles.Controllers
{
    public class DogController : Controller
    {
        private readonly AppDbContext _db;

        public DogController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Dog> dogs = _db.Dogs.ToList();
            return View(dogs);
        }
    }
}
