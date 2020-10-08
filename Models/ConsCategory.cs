using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget.Models
{
    public class ConsCategory
    {
        public int ConsCategoryId { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<Consum> Consums { get; set; }
    }
}
