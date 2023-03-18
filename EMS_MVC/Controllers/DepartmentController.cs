using EMS_MVC.Repository;
using EMS_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EMS_MVC.Controllers
{
    public class DepartmentController : Controller
    {
        IEMSRepoDepartment _repo;

        public DepartmentController(IEMSRepoDepartment repo)
        {
            this._repo = repo;
        }

        public IActionResult ViewAllDepartments()
        {
            var DeptList = _repo.ViewAllDepartments();
            return View(DeptList);
        }

        public IActionResult ViewOneDepartment(int id)
        {
            var Dept = _repo.ViewOneDepartment(id);
            return View(Dept);
        }
        [HttpGet]
        public IActionResult AddDepartment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDepartment(Department NewDepartment)
        {
            if (ModelState.IsValid)
            {
                var NewDept = _repo.AddDepartment(NewDepartment);
                return RedirectToAction("ViewAllDepartments");
            }
            return View();
        }
        [HttpGet]
        public IActionResult UpdateDepartment(int id)
        {
            var OldDept = _repo.ViewOneDepartment(id);
            return View(OldDept);
        }
        [HttpPost]
        public IActionResult UpdateDepartment(Department NewDepartment)
        {
            if (ModelState.IsValid)
            {
                var NewDept = _repo.UpdateDepartment(NewDepartment);
                return RedirectToAction("ViewAllDepartments");
            }

            return View();
        }

        public IActionResult DeleteDepartment(int id)
        {
            _repo.DeleteDepartment(id);
            return RedirectToAction("ViewAllDepartments");
        }
    }
}
