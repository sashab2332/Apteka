using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apteka.Models;
using Microsoft.EntityFrameworkCore;




namespace Apteka.Data.Repositories
{
    public class EmployeeRep1 : IEmployeeRep1
    {
        private readonly DataContext1 _context;

        public EmployeeRep1(DataContext1 context)
        {
            _context = context;
        }

        public Task<AEmployee> GetEmployee(int EmployeeId) =>
            _context.Employees1.FirstOrDefaultAsync(x => x.EmployeeId1 == EmployeeId);

        public Task<AEmployee> GetEmployee(string login) =>
            _context.Employees1.FirstOrDefaultAsync(x => x.Login1 == login);

        public Task<List<AEmployee>> GetEmployees() =>
            _context.Employees1.ToListAsync();
        public async Task<int> AddEmployee(AEmployee employee)
        {
            await _context.Employees1.AddAsync(employee);
            await _context.SaveChangesAsync();
            return employee.EmployeeId1;
        }
        public Task UpdateEmployee(AEmployee employee)
        {
            _context.Employees1.Update(employee);
            return _context.SaveChangesAsync();
        }
        public Task RemoveEmployee(AEmployee employee)
        {
            _context.Employees1.Remove(employee);
            return _context.SaveChangesAsync();
        }
        public Task<List<AEmployee>> GetEmployeesbyName(string name) =>
           _context.Employees1.Where(x => x.Name1 == name).ToListAsync();

    }
}
