using EMS_MVC.Data;
using EMS_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EMS_MVC.Repository
{
    public class EMSRepoDepartment : IEMSRepoDepartment
    {
        EMSContext _context;

        public EMSRepoDepartment(EMSContext context)
        {
            _context = context;
        }

        public List<Department> ViewAllDepartments()
        {
            return _context.Departments.ToList();
        }

        public Department ViewOneDepartment(int id)
        {
            return _context.Departments.AsNoTracking().FirstOrDefault(dept => dept.ID == id);
        }

        public Department AddDepartment(Department NewDepartment)
        {
            _context.Add(NewDepartment);
            _context.SaveChanges();

            return NewDepartment;
        }

        public Department UpdateDepartment(Department NewDepartment)
        {
            _context.Update(NewDepartment);
            _context.SaveChanges();

            return NewDepartment;
        }

        public Department DeleteDepartment(int id)
        {
            var OldDepartment = ViewOneDepartment(id);
            if(OldDepartment != null)
            {
                _context.Remove(OldDepartment);
                _context.SaveChanges();

                return OldDepartment;
            }

            return null;
        }
    }
}
