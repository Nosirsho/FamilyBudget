using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget.Models
{
    public class Consum
    {
        public int ConsumId { get; set; }
        public DateTime ConsDate { get; set; }
        
        public decimal ConsSum { get; set; }
        [StringLength(255)]
        public string Descr { get; set; }
        public int? ConsCategoryId { get; set; }

        public ConsCategory ConsCategory { get; set; }
    }

}
