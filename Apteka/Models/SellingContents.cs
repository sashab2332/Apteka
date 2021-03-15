using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Apteka.Models
{
    public class SellingContents
    {
        public int SellingContentsId { get; set; }
        [Required] public string SCName { get; set; }
        public int SellingId { get; set; }
        public Selling Selling { get; set; }
        public int ItemId { get; set; }
       // [Required] public string ItemName1 { get; set; }
        public Item Item { get; set; }
        [Required]public double Price { get; set; }
        public int ItemAmmaunt { get; set; }
        

    }
}
