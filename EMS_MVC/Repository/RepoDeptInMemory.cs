using EMS_MVC.Models;

namespace EMS_MVC.Repository
{
    public class RepoDeptInMemory : IRepoDeptInMemory
    {
        static List<Department> departments = new List<Department>();

        static RepoDeptInMemory()
        {
            departments.Add(new Department(1, "Administration"));
            departments.Add(new Department(2, "Security"));
            departments.Add(new Department(3, "Accounting"));
        }

        public List<Department> ViewAllDepartments()
        {
            return departments;
        }

        public Department ViewOneDepartment(int id)
        {
            return departments.FirstOrDefault(dept => dept.ID == id);
        }

        public Department AddDepartment (Department NewDepartment)
        {
            NewDepartment.ID = departments.Max(dept => dept.ID) + 1;
            departments.Add(NewDepartment);

            return NewDepartment;
        }

        public Department UpdateDepartment(int id, Department NewDepartment)
        {
            var OldDepartment = departments.FirstOrDefault(dept => dept.ID == id);
            if(OldDepartment != null)
            {
                departments.Remove(OldDepartment);
                departments.Add(NewDepartment);

                return NewDepartment;
            }

            return null;
        }

        public Department DeleteDepartment(int id)
        {
            var OldDepartment = departments.FirstOrDefault(dept => dept.ID == id);
            if (OldDepartment != null)
            {
                departments.Remove(OldDepartment);

                return OldDepartment;
            }

            return null;
        }
    }
}
