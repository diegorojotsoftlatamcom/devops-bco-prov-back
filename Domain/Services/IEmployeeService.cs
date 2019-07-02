using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Services
{
    public interface IEmployeeService
    {
         Task<List<Employee>> FindAllAsync();
    }
}