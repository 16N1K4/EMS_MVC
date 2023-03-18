using EMS_MVC.Models;
using EMS_MVC.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EMS_MVC.Controllers
{
    public class EmployeeController : Controller
    {

        IEMSRepoEmployee _repo;

        public EmployeeController(IEMSRepoEmployee repo)
        {
            this._repo = repo;
        }

        public IActionResult ViewAllEmployees()
        {
            var EmpList = _repo.ViewAllEmployees();
            return View(EmpList);
        }

        public IActionResult ViewOneEmployee(int id)
        {
            var Emp = _repo.ViewOneEmployee(id);
            return View(Emp);
        }
        [HttpGet]
        public IActionResult AddEmployee()
        {
            var deptList = _repo.FetchDepartmentList();
            ViewBag.Departments = deptList;

            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee NewEmployee)
        {
            if (ModelState.IsValid)
            {
                var NewEmp = _repo.AddEmployee(NewEmployee);
                return RedirectToAction("ViewAllEmployees");
            }
            return View();
        }
        [HttpGet]
        public IActionResult UpdateEmployee(int id)
        {
            var deptList = _repo.FetchDepartmentList();
            ViewBag.Departments = deptList;

            var OldEmp = _repo.ViewOneEmployee(id);
            return View(OldEmp);
        }
        [HttpPost]
        public IActionResult UpdateEmployee(Employee NewEmployee)
        {
            if (ModelState.IsValid)
            {
                var NewEmp = _repo.UpdateEmployee(NewEmployee);
                return RedirectToAction("ViewAllEmployees");
            }

            return View();
        }

        public IActionResult DeleteEmployee(int id)
        {
            _repo.DeleteEmployee(id);
            return RedirectToAction("ViewAllEmployees");
        }
    }
}
