using EMS_MVC.Models;

namespace EMS_MVC.Repository
{
    public interface IRepoDeptInMemory
    {
        public List<Department> ViewAllDepartments();
        public Department ViewOneDepartment(int id);
        public Department AddDepartment(Department NewDepartment);
        public Department UpdateDepartment(int id, Department NewDepartment);
        public Department DeleteDepartment(int id);
    }
}
