using EmployeesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesApp.Contracts
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetEmployee(Guid id);
        void CreateEmployee(Employee employee);
    }
}
