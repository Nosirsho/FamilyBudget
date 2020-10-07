namespace FamilyBudget.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BudgetContext : DbContext
    {
        
        public BudgetContext()
            : base("name=BudgetContext")
        {
        }

        public virtual DbSet<IncCategory> IncCategoryList { get; set; }
        public virtual DbSet<ConsCategory> ConsCategoryList { get; set; }
        public virtual DbSet<Income> IncList { get; set; }
        public virtual DbSet<Consum> ConsList { get; set; }
    }

    
}