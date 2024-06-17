using System.ComponentModel.DataAnnotations;

namespace StudentManagerWeb.Models
{
    public class LoanItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Type { get; set; }
        [Required]
        public decimal Amount {  get; set; }
        [Required]
        public decimal ComputedRate { get; set; }
        [Required]
        public string Description {  get; set; }


    }
}
