using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget.Models
{
    public class Income
    {
        public int IncomeId { get; set; }
        public DateTime IncDate { get; set; }
        public decimal IncSum { get; set; }
        public string Descr { get; set; }
        public int? IncCategoryId { get; set; }

        public IncCategory IncCategory { get; set; }

    }
}
