
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Apteka.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Login { get; set; }
        [Required] public string Password { get; set; }
        [Required] public string Position { get; set; }
        public ICollection<Selling> Sellings { get; set; }
    }
}
