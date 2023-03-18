using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS_MVC.Models
{
    public class Employee
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required(ErrorMessage = "Please input a name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please input a date.")]
        public DateTime DateOfBirth { get; set; }
        [EmailAddress(ErrorMessage = "This is not a valid email address.")]
        public string Email { get; set; }
        [RegularExpression("(09)[0-9]{9}", ErrorMessage = "This is not a valid phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public int DepartmentID { get; set; }
        public Department? Department { get; set; }

        public Employee()
        {

        }

        public Employee(int iD, string name, DateTime dateOfBirth, string email, string phone, int departmentID)
        {
            ID = iD;
            Name = name;
            DateOfBirth = dateOfBirth;
            Email = email;
            Phone = phone;
            DepartmentID = departmentID;
        }
    }
}
