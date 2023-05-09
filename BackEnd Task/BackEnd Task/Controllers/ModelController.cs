using BackEnd_Task.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd_Task.Controllers
{
    public class ModelController : Controller
    {
        private readonly List<Model> _models;

        public ModelController()
        {
            _models = new List<Model>
            {
                new Model { Id = 1, ModelName="X5M"},
                new Model { Id = 2, ModelName="GT63-AMG"},
                new Model { Id = 3, ModelName="RS7"}

            };
        }
        public IActionResult Index(int? id)
        {
            if(id == null)
            {
                if(!_models.Exists(m=> m.Id == id))
                {
                    return BadRequest();
                }
                return View(_models.FindAll(m=>m.Id==id));
            }
            return View();
        }

        public IActionResult Detail(int? id)
        {
            if (id == null) return BadRequest();

            Model model = _models.Find(m=>m.Id==id);

            if (model == null) return NotFound();
         
            return View(model);
        }
    }
}
