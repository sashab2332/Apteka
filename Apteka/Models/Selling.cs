using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Apteka.Models
{
    public class Selling
    {
        public int SellingId { get; set; }
        public DateTime DateTime { get; set; }
        [Required] public double Price { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public ICollection<SellingContents> SellingContents { get; set; }
        
    }
}
