using System.ComponentModel.DataAnnotations;

namespace WebApi.DTOs
{
    public class SalaryRequest
    {
        [Required]
        public int GrossSalaryAmount { get; set; }
        [Required]
        public int NetSalaryAmount { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public string? BirthDate { get; set; }
    }
}
