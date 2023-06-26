using Microsoft.AspNetCore.Mvc;
namespace FirstApp.Controllers
{
        public class EmpPayrollController : Controller
        {
            [HttpGet]
            public IActionResult Index()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Submit(EmployeePayrollModel model)
            {
                if (ModelState.IsValid)
                {
                    // Process the submitted form data and save it to the database or perform any other desired operations

                    // Example: Saving the data to a database
                    // var employee = new Employee
                    // {
                    //     Name = model.Name,
                    //     Profile = model.Profile,
                    //     Gender = model.Gender,
                    //     Department = model.Department,
                    //     Salary = model.Salary,
                    //     StartDate = model.StartDate,
                    //     Notes = model.Notes
                    // };
                    // _dbContext.Employees.Add(employee);
                    // _dbContext.SaveChanges();

                    // Redirect to a success page or perform any other desired action
                    return RedirectToAction("Success");
                }

                // If the submitted form data is invalid, return to the form page to display validation errors
                return View("Index", model);
            }

            public IActionResult Success()
            {
                // Display a success message or any other desired content
                return View();
            }
        }
    }
