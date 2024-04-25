using System.ComponentModel.DataAnnotations;

namespace MVC.CRUD.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "Employee Name")]
        [MaxLength(30, ErrorMessage = "Name cannot exceed 30 characters")]
        public string Name { get; set; }

        [Required]
        [Range(1, 100000, ErrorMessage = "Please enter a valid salary")]
        public Double Salary { get; set; }
        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1990-01-01", "9999-12-31", ErrorMessage = "Date of Birth must be after 1990")]
        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
