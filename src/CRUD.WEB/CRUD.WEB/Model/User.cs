using System.ComponentModel.DataAnnotations;

namespace CRUD.WEB.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Descriptions { get; set; }
    }
}
