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
                new Car { Id = 1,Oil="AI-100",Year="2023",ModelId=1},
                new Car { Id = 2,Oil="AI-100",Year="2023",ModelId=1},
                new Car { Id = 3,Oil="AI-95",Year="2022",ModelId=2},
                new Car { Id = 4,Oil="AI-95",Year="2022",ModelId=2},
                new Car { Id = 5,Oil="AI-92",Year="2020",ModelId=3},
                new Car { Id = 6,Oil="AI-92",Year="2020",ModelId=3},
                new Car { Id = 7,Oil="AI-92",Year="2018",ModelId=4},
                new Car { Id = 8,Oil="AI-92",Year="2018",ModelId=4},


            };

        }
        public IActionResult Index(int? id)
        {
            if (id == null) return BadRequest();    

            if(!_cars.Exists(c=>c.ModelId==id)) return NotFound();

            return View(_cars.FindAll(c => c.ModelId == id));
        }


        public IActionResult Detail(int? id)
        {
            if (id == null) return BadRequest();

            if (!_cars.Exists(c => c.Id == id)) return NotFound();

            return View(_cars.FindAll(c => c.Id == id));
        }
    }
}
