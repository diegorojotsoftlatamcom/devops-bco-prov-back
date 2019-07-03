
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Repositories;
using Domain.Persistence;
using System.Linq;

namespace Domain.Repositories.Impl
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly Context context;

        public EmployeeRepository(Context context)
        {
            this.context = context;
        }

        public Task<List<Employee>> FindAllAsync()
        {
            return Task.FromResult(this.context.Employees.ToList());

            /*List<Employee> results = new List<Employee>();
            results.Add(new Employee(1234, 28695048, "Diego Rojo"));
            return Task.FromResult(results);*/
        }

    }
}