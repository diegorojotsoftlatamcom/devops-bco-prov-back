
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Repositories;

namespace Domain.Repositories.Impl
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Task<List<Employee>> FindAllAsync()
        {
            List<Employee> results = new List<Employee>();
            results.Add(new Employee(1234, 28695048, "Diego Rojo"));
            return Task.FromResult(results);
        }
    }
}