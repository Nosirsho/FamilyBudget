using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [StringLength(255)]
        public string Descr { get; set; }
        public int? IncCategoryId { get; set; }

        public IncCategory IncCategory { get; set; }

    }
}
