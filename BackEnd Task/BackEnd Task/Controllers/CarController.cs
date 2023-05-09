using BackEnd_Task.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd_Task.Controllers
{
    public class CarController : Controller
    {
        private readonly List<Car> _cars;

        public CarController()
        {
            _cars= new List<Car>
            {
                new Car { Id = 1,Oil="AI-92",Year="2020"},
                new Car { Id = 2,Oil="AI-95",Year="2022"}

            };

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
