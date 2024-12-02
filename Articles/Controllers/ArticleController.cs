using Articles.Models;
using Microsoft.AspNetCore.Mvc;

namespace Articles.Controllers
{
    public class ArticleController : Controller
    {

        private readonly AppDbContext _db;
        public ArticleController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<ArticleModel> articles = _db.Articles.ToList();
            return View(articles);
        }
    }
}
