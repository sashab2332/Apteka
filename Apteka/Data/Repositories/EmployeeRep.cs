using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apteka.Models;
using Microsoft.EntityFrameworkCore;




namespace Apteka.Data.Repositories
{
    public class EmployeeRep : IEmployeeRep
    {
        private readonly DataContext _context;

        public EmployeeRep(DataContext context)
        {
            _context = context;
        }

        public Task<Employee> GetEmployee(int EmployeeId) =>
            _context.Employees.FirstOrDefaultAsync(x => x.EmployeeId == EmployeeId);

        public Task<Employee> GetEmployee(string login) =>
            _context.Employees.FirstOrDefaultAsync(x => x.Login == login);

        public Task<List<Employee>> GetEmployees() =>
            _context.Employees.ToListAsync();
        public Task<List<Employee>> GetEmployeesbyLogin(string login) =>
            _context.Employees.Where(x => x.Login == login).ToListAsync();
        public async Task<int> AddEmployee(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
            return employee.EmployeeId;
        }
        public Task UpdateEmployee(Employee employee)
        {
            _context.Employees.Update(employee);
            return _context.SaveChangesAsync();
        }
        public Task RemoveEmployee(Employee employee)
        {
            _context.Employees.Remove(employee);
            return _context.SaveChangesAsync();
        }
        public Task<List<Employee>> GetEmployeesbyName(string name) =>
           _context.Employees.Where(x => x.Name == name).ToListAsync();

    }
}
