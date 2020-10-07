using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget.Models
{
    public class IncCategory
    {
        public int IncCategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Income> Incomes { get; set; }
    }
}
