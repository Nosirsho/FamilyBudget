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

namespace FamilyBudget
{
    public partial class IncForm : MetroFramework.Forms.MetroForm
    {
        public IncForm()
        {
            InitializeComponent();
        }

        private void IncForm_Load(object sender, EventArgs e)
        {
            using (BudgetContext context = new BudgetContext())
            {
                incomeBindingSource.DataSource = context.IncList.ToList();
                cbCategory.DataSource = context.IncCategoryList.ToList();
                
            }
            metroPanel1.Enabled = false;
            Income incObj = incomeBindingSource.Current as Income;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            metroPanel1.Enabled = true;
            incomeBindingSource.Add(new Income());
            incomeBindingSource.MoveLast();
            dtDate.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            metroPanel1.Enabled = true;
            dtDate.Focus();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            metroPanel1.Enabled = false;
            incomeBindingSource.ResetBindings(false);
            IncForm_Load(sender, e);
        }

        private void GridInc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Income incObj = incomeBindingSource.Current as Income;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Вы действительно хотите удалить эту запись?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (BudgetContext context = new BudgetContext())
                {
                    Income incObj = incomeBindingSource.Current as Income;
                    if (incObj != null)
                    {
                        if (context.Entry<Income>(incObj).State == EntityState.Detached)
                            context.Set<Income>().Attach(incObj);
                        context.Entry<Income>(incObj).State = EntityState.Deleted;
                        context.SaveChanges();
                        MessageBox.Show(this, "Запись успешно удален");
                        incomeBindingSource.RemoveCurrent();
                        metroPanel1.Enabled = false;

                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (BudgetContext context = new BudgetContext())
            {
                Income incObj = incomeBindingSource.Current as Income;
                if (incObj != null)
                {
                    if (context.Entry<Income>(incObj).State == EntityState.Detached)
                    {
                        context.Set<Income>().Attach(incObj);
                        if (incObj.IncomeId == 0)
                            context.Entry<Income>(incObj).State = EntityState.Added;
                        else
                            context.Entry<Income>(incObj).State = EntityState.Modified;
                        context.SaveChanges();
                        MessageBox.Show(this, "Запись успешно сохранен");
                        GridInc.Refresh();
                        metroPanel1.Enabled = false;
                    }
                }
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbCategory.SelectedValue.ToString());
        }
    }
}
