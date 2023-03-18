using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS_MVC.Models
{
    public class Department
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required(ErrorMessage = "Please input a name")]
        public string Name { get; set; }
        public List<Employee>? Employees { get; set; }

        public Department()
        {

        }

        public Department(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
