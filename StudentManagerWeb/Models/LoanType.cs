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
        public decimal Rate { get; set; }
        [Required]
        public decimal MinLoan { get; set; }
        [Required]
        public decimal MaxLoan { get; set; }

    }
}
