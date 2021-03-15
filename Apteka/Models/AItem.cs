using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Apteka.Models
{
     public class AItem
    {
        [Key]
        public int Id1 { get; set; }
        [Required] public string ItemName1 { get; set; }
        public int Cuantity1 { get; set; }
        [Required] public double Price1 { get; set; }
        public ICollection<ASellingContents> ASellingContents1 { get; set; }
    }
}
