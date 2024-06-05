using Microsoft.AspNetCore.Identity;
using WebApi.Data;
using WebApi.DTOs;
using WebApi.Entities;

namespace WebApi.Services
{
    public class SalaryService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<User> _userManager;

        private SalaryService(AppDbContext context, IHttpContextAccessor httpContextAccessor, UserManager<User> userManager)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        public async Task<SalaryRequest> IncomeCalculator(SalaryRequest request)
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            if (user == null)
            {
                throw new ArgumentException("User not found.");
            }

            var salary = new SalaryRequest
            {
                GrossSalaryAmount = request.GrossSalaryAmount,
                NetSalaryAmount = Salary.CalculateSalary(request.GrossSalaryAmount)
            };

            return salary;
        }
    }
}
