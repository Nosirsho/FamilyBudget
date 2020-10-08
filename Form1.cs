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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (BudgetContext context = new BudgetContext()) 
            {
                consCategoryBindingSource.DataSource = context.ConsCategoryList.ToList();
            }
            metroPanel1.Enabled = false;
            ConsCategory consCatObj = consCategoryBindingSource.Current as ConsCategory;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            metroPanel1.Enabled = true;
            consCategoryBindingSource.Add(new ConsCategory());
            consCategoryBindingSource.MoveLast();
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
            consCategoryBindingSource.ResetBindings(false);
            Form1_Load(sender, e);
        }

        private void GridConsCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ConsCategory consCatObj = consCategoryBindingSource.Current as ConsCategory;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Вы действительно хотите удалить эту запись?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (BudgetContext context = new BudgetContext()) {
                    ConsCategory consCatObj = consCategoryBindingSource.Current as ConsCategory;
                    if (consCatObj != null) {
                        if (context.Entry<ConsCategory>(consCatObj).State == EntityState.Detached) 
                            context.Set<ConsCategory>().Attach(consCatObj);
                        context.Entry<ConsCategory>(consCatObj).State = EntityState.Deleted;
                        context.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Запись успешно удален");
                        consCategoryBindingSource.RemoveCurrent();
                        metroPanel1.Enabled = false;

                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (BudgetContext context = new BudgetContext()) 
            {
                ConsCategory consCatObj = consCategoryBindingSource.Current as ConsCategory;
                if (consCatObj != null) 
                {
                    if (context.Entry<ConsCategory>(consCatObj).State == EntityState.Detached) {
                        context.Set<ConsCategory>().Attach(consCatObj);
                        if (consCatObj.ConsCategoryId == 0)
                            context.Entry<ConsCategory>(consCatObj).State = EntityState.Added;
                        else
                            context.Entry<ConsCategory>(consCatObj).State = EntityState.Modified;
                        context.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Запись успешно сохранен");
                        GridConsCategory.Refresh();
                        metroPanel1.Enabled = false;
                    }
                }
            }
        }
    }
}
