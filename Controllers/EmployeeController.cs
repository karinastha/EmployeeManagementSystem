using FirstApp.Models;
using FirstApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepo _repo;

        public EmployeeController(IEmployeeRepo repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }
        // HTTP GET VERSION
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update(int id)
        {
            Employee employee = _repo.Get(id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Update(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _repo.Update(employee);
                return RedirectToAction("Index");
            }
            else
                return View();
        }

        // HTTP POST VERSION  
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _repo.Create(employee);
                return View("Thanks", employee);
            }
            else
                return View();
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            var result = _repo.Get(id);
            _repo.Delete(result);
            return RedirectToAction("Index");
        }
    }
}
