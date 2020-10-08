using FamilyBudget.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyBudget {
    public partial class IncCatForm : MetroFramework.Forms.MetroForm {
        
        public IncCatForm()
        {
            InitializeComponent();
        }
        private void IncCatForm_Load(object sender, EventArgs e)
        {
            using (BudgetContext context = new BudgetContext())
            {
                incCategoryBindingSource.DataSource = context.IncCategoryList.ToList();
            }
            metroPanel1.Enabled = false;
            IncCategory incCatObj = incCategoryBindingSource.Current as IncCategory;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            metroPanel1.Enabled = true;
            incCategoryBindingSource.Add(new IncCategory());
            incCategoryBindingSource.MoveLast();
            txtName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            metroPanel1.Enabled = true;
            txtName.Focus();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            metroPanel1.Enabled = false;
            incCategoryBindingSource.ResetBindings(false);
            IncCatForm_Load(sender, e);
        }

        private void GridIncCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IncCategory incCatObj = incCategoryBindingSource.Current as IncCategory;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Вы действительно хотите удалить эту запись?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (BudgetContext context = new BudgetContext())
                {
                    IncCategory incCatObj = incCategoryBindingSource.Current as IncCategory;
                    if (incCatObj != null)
                    {
                        if (context.Entry<IncCategory>(incCatObj).State == EntityState.Detached)
                            context.Set<IncCategory>().Attach(incCatObj);
                        context.Entry<IncCategory>(incCatObj).State = EntityState.Deleted;
                        context.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Запись успешно удален");
                        incCategoryBindingSource.RemoveCurrent();
                        metroPanel1.Enabled = false;

                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (BudgetContext context = new BudgetContext())
            {
                IncCategory incCatObj = incCategoryBindingSource.Current as IncCategory;
                if (incCatObj != null)
                {
                    if (context.Entry<IncCategory>(incCatObj).State == EntityState.Detached)
                    {
                        context.Set<IncCategory>().Attach(incCatObj);
                        if (incCatObj.IncCategoryId == 0)
                            context.Entry<IncCategory>(incCatObj).State = EntityState.Added;
                        else
                            context.Entry<IncCategory>(incCatObj).State = EntityState.Modified;
                        context.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Запись успешно сохранен");
                        GridIncCategory.Refresh();
                        metroPanel1.Enabled = false;
                    }
                }
            }
        }

        
    }
}
