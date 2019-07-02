
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Repositories
{
    public interface IEmployeeRepository
    {
         Task<List<Employee>> FindAllAsync();
    }
}