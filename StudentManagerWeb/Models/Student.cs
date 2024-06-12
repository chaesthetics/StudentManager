using System.ComponentModel.DataAnnotations;

namespace StudentManagerWeb.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]  
        public string Course { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
