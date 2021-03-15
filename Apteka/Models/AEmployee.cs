using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Apteka.Models
{
    public class AEmployee
    {
        [Key]
        public int EmployeeId1 { get; set; }
        [Required] public string Name1 { get; set; }
        [Required] public string Login1 { get; set; }
        [Required] public string Password1 { get; set; }
        [Required] public string Position1 { get; set; }
        public ICollection<ASelling> ASellings1 { get; set; }
    }
}
