using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Apteka.Models
{
     public class Item
    {
        public int Id { get; set; }
        [Required] public string ItemName { get; set; }
        public int Cuantity { get; set; }
        [Required] public double Price { get; set; }
        public ICollection<SellingContents> SellingContents { get; set; }
    }
}
