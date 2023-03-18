using EMS_MVC.Data;
using EMS_MVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EMS_MVC.Repository
{
    public class EMSRepoEmployee : IEMSRepoEmployee
    {
        EMSContext _context;

        public EMSRepoEmployee(EMSContext context)
        {
            _context = context;
        }

        //view all
        public List<Employee> ViewAllEmployees()
        {
            return _context.Employees.Include(dept => dept.Department).ToList();
        }

        //view one
        public Employee ViewOneEmployee(int id)
        {
            return _context.Employees.Include(dept => dept.Department).AsNoTracking().FirstOrDefault(emp => emp.ID == id);
        }

        //add
        public Employee AddEmployee(Employee NewEmployee)
        {
            _context.Add(NewEmployee);
            _context.SaveChanges();

            return NewEmployee;
        }

        //update
        public Employee UpdateEmployee(Employee NewEmployee)
        {
            _context.Update(NewEmployee);
            _context.SaveChanges();

            return NewEmployee;
        }

        //delete
        public Employee DeleteEmployee(int id)
        {
            var OldEmployee = ViewOneEmployee(id);
            if (OldEmployee != null)
            {
                _context.Remove(OldEmployee);
                _context.SaveChanges();
                return OldEmployee;
            }

            return null;
        }

        public List<Department> FetchDepartmentList()
        {
            var departmentList = _context.Departments.ToList();

            return departmentList;
        }

    }
}
