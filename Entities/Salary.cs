namespace WebApi.Entities
{
    public class Salary
    {
        public int GrossSalaryAmount { get; set; }
        public int NetSalaryAmount { get; set; }
        public string? City { get; set; }
        public string? BirthDate { get; set; }

        public int CalculateSalary(int income)
        {
            return income * 12;
        }
    }
}
