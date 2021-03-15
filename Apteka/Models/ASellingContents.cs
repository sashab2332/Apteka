using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Apteka.Models
{
    public class ASellingContents
    {
        [Key]
        public int SellingContentsId1 { get; set; }
        [Required] public string SCName1 { get; set; }
        public int SellingId1 { get; set; }
        public ASelling ASelling1 { get; set; }
        public int ItemId1 { get; set; }
       // [Required] public string ItemName1 { get; set; }
        public AItem AItem1 { get; set; }
        [Required]public double Price1 { get; set; }
        public int ItemAmmaunt1 { get; set; }
        

    }
}
