using EMS_MVC.Models;

namespace EMS_MVC.Repository
{
    public interface IEMSRepoDepartment
    {
        public List<Department> ViewAllDepartments();

        public Department ViewOneDepartment(int id);

        public Department AddDepartment(Department NewDepartment);

        public Department UpdateDepartment(Department NewDepartment);

        public Department DeleteDepartment(int id);
    }
}
