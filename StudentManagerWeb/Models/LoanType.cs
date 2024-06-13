using System.ComponentModel.DataAnnotations;

namespace StudentManagerWeb.Models
{
    public class LoanType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public float Rate { get; set; }
        [Required]
        public float MinLoan { get; set; }
        [Required]
        public float MaxLoan { get; set; }

    }
}
