using BackEnd_Task.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace BackEnd_Task.Controllers
{
    public class ModelController : Controller
    {
        private readonly List<Model> _models;

        public ModelController()
        {
            _models = new List<Model>
            {
                new Model { Id = 1, ModelName="X5M", MarkaId=1},
                new Model { Id = 2, ModelName="X6M", MarkaId=1},
                new Model { Id = 3, ModelName="GT63-AMG", MarkaId=2},
                new Model { Id = 4, ModelName="RS7", MarkaId=3}

            };
        }
        public IActionResult Index(int? id)
        {
            if (id == null) return BadRequest();

            if(!_models.Exists(x=>x.MarkaId == id)) return NotFound();

            return View(_models.FindAll(m=>m.MarkaId==id));
        }

      
    }
}
