using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget.Models
{
    public class ConsCategory
    {
        public int ConsCategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Consum> Consums { get; set; }
    }
}
