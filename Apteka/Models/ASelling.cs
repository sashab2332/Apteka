using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Apteka.Models
{
    public class ASelling
    {
        [Key]
        public int SellingId1 { get; set; }
        public DateTime DateTime1 { get; set; }
        [Required] public double Price1 { get; set; }
        public int EmployeeId1 { get; set; }
        public AEmployee AEmployee1 { get; set; }
        public ICollection<ASellingContents> ASellingContents1 { get; set; }
        
    }
}
