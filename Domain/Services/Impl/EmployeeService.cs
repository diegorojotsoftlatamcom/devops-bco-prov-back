
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Repositories;

namespace Domain.Services.Impl
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public async Task<List<Employee>> FindAllAsync()
        {
            return await employeeRepository.FindAllAsync();
        }
    }
}