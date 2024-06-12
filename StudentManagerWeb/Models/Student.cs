using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentManagerWeb.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Student Fullname")]
        [Range(5,38, ErrorMessage ="Fullname ba yan?")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Student Course")]
        public string Course { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
