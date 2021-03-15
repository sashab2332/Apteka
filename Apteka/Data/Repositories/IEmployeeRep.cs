using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apteka.Models;


namespace Apteka.Data.Repositories
{
    public interface IEmployeeRep
    {
        Task<Employee> GetEmployee(int EmployeeId);


        Task<Employee> GetEmployee(string login);
        Task<List<Employee>> GetEmployees();

        Task<int> AddEmployee(Employee employee);
        Task UpdateEmployee(Employee employee);
        Task RemoveEmployee(Employee employee);
        Task<List<Employee>> GetEmployeesbyName(string name);
        Task<List<Employee>> GetEmployeesbyLogin(string login);


    }
}
