using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apteka.Models;


namespace Apteka.Data.Repositories
{
    public interface IEmployeeRep1
    {
        Task<AEmployee> GetEmployee(int EmployeeId);


        Task<AEmployee> GetEmployee(string login);
        Task<List<AEmployee>> GetEmployees();

        Task<int> AddEmployee(AEmployee employee);
        Task UpdateEmployee(AEmployee employee);
        Task RemoveEmployee(AEmployee employee);
        Task<List<AEmployee>> GetEmployeesbyName(string name);


    }
}
