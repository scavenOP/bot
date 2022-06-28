using Bot.Models;
using Bot.ViewModels;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace Bot.Controllers
{
    public class LearnController : Controller
    {
        private ApplicationDbContext _context;

        public LearnController()
        {

            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var result = _context.Cars.Include(m => m.cartype).ToList();
            return View(result);
        }

        public ActionResult Niladri()
        {
            Car suv = new Car();
            suv.Name = "Scorpio";
            suv.Id = 1;
            suv.Color = "Pink";
            return View();
        }


        public ActionResult Display(int? id)
        {
            if (id != null)
            {
                ViewBag.Number = id;
            }
            else
            {
                ViewBag.Number = 10;
            }

            return View();

        }
        public ActionResult Add()
        {
            AddingCar addingCar = new AddingCar();

            addingCar.CarTypes = _context.CarTypes.ToList();

            return View(addingCar);
        }



        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
            return Content("Submitted");
        }
    }
}