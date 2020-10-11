using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget.Models
{
    public class Consum
    {
        public int ConsumId { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime ConsDate { get; set; }
        
        public decimal ConsSum { get; set; }

        public string Descr { get; set; }
        public int? ConsCategoryId { get; set; }

        public ConsCategory ConsCategory { get; set; }
    }

}
