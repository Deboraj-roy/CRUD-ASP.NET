using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models
{
    public class Employe
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Double Salary { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Department {  get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
