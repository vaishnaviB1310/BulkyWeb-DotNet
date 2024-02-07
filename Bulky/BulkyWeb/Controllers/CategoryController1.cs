using BulkyWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers

{

    //private readonly ApplicationDbContext _db;

    public class CategoryController1 : Controller
    {

        public CategoryController1(ApplicationDbContext db)
        {
            //_db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SaveDataToCategory()
        {
            //var categoryObj;
            // adding changes
            return Ok();
        }
    }
}
