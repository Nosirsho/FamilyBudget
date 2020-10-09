using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget.Models
{
    public class IncCategory
    {
        public int IncCategoryId { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<Income> Incomes { get; set; }

        public IncCategory()
        {
            Incomes = new List<Income>();
        }
        public override string ToString()
        {
            return Name;
        }
    }
   
}
