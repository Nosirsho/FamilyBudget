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
    public partial class IncCategoryForm : Form
    {
        BudgetContext context;
        public IncCategoryForm()
        {
            InitializeComponent();
            context = new BudgetContext();
            context.IncCategoryList.Load();
            dataGridView.DataSource = context.IncCategoryList.Local.ToBindingList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            IncCtForm icaeForm = new IncCtForm();
            DialogResult result = icaeForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            IncCategory incCat = new IncCategory();
            incCat.Name = icaeForm.txtName.Text;
            context.IncCategoryList.Add(incCat);
            context.SaveChanges();
            MessageBox.Show("Новая категория добавлена");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int index = dataGridView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                IncCategory iCat = context.IncCategoryList.Find(id);
                iCat.Incomes.Clear();
                context.IncCategoryList.Remove(iCat);
                context.SaveChanges();

                MessageBox.Show("Категория удалена");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int index = dataGridView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                IncCategory iCat = context.IncCategoryList.Find(id);

                IncCtForm incCtForm = new IncCtForm();
                incCtForm.txtName.Text = iCat.Name;
                

                DialogResult result = incCtForm.ShowDialog(this);
                if (result == DialogResult.Cancel)
                    return;

                iCat.Name = incCtForm.txtName.Text;
                

                context.Entry(iCat).State = EntityState.Modified;
                context.SaveChanges();
                MessageBox.Show("Категория обновлена");
            }
        }
    }
}
