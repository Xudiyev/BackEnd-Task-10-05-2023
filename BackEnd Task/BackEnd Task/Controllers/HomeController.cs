using BackEnd_Task.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd_Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Marka> _markas;

        public HomeController()
        {
            _markas= new List<Marka>
            {
                new Marka { Id = 1, MarkaName="BMW"},
                new Marka { Id = 2, MarkaName="Mercedes"},
                new Marka { Id = 3, MarkaName="Audi"}

            };
        }
        public IActionResult Index()
        {
            return View(_markas);
        }
    }
}
