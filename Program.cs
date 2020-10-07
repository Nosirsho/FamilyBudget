using FamilyBudget.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyBudget
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            BudgetContext context = new BudgetContext();

            IncCategory incCategory = new IncCategory();
            incCategory.Name = "Зар.Плата";
       
            context.IncCategoryList.Add(incCategory);
            context.SaveChanges();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
