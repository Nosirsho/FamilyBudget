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
    public partial class IncomeForm : Form
    {
        BudgetContext context;
        public IncomeForm()
        {
            InitializeComponent();
            context = new BudgetContext();
            context.IncList.Load();
            //
            dataGridView.DataSource = context.IncList.Local.ToBindingList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            IncomeAEForm iaeForm = new IncomeAEForm();

            List<IncCategory> incCategories = context.IncCategoryList.ToList();

            iaeForm.cbCategory.DataSource = incCategories;
            iaeForm.cbCategory.ValueMember = "IncCategoryId";
            iaeForm.cbCategory.DisplayMember = "Name";

            DialogResult result = iaeForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Income income = new Income();
            income.IncDate = (DateTime)iaeForm.dtDate.Value;
            income.IncSum = decimal.Parse( iaeForm.txtIncSum.Text);
            income.IncCategory = (IncCategory)iaeForm.cbCategory.SelectedItem;
            income.Descr = iaeForm.txtDescr.Text;

            context.IncList.Add(income);
            context.SaveChanges();

            MessageBox.Show("Доход добавлен");
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

                Income income = context.IncList.Find(id);

                IncomeAEForm iaeForm = new IncomeAEForm();

                iaeForm.dtDate.Value = income.IncDate;
                iaeForm.txtIncSum.Text = income.IncSum.ToString();
                iaeForm.cbCategory.SelectedItem = income.IncCategory;
                iaeForm.txtDescr.Text = income.Descr;

                List<IncCategory> incCats = context.IncCategoryList.ToList();
                iaeForm.cbCategory.DataSource = incCats;
                iaeForm.cbCategory.ValueMember = "IncCategoryId";
                iaeForm.cbCategory.DisplayMember = "Name";

                if (income.IncCategory != null)
                    iaeForm.cbCategory.SelectedValue = income.IncCategory.IncCategoryId;

                DialogResult result = iaeForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                income.IncDate = (DateTime)iaeForm.dtDate.Value;
                income.IncSum = decimal.Parse(iaeForm.txtIncSum.Text);
                income.IncCategory = (IncCategory)iaeForm.cbCategory.SelectedItem;
                income.Descr = iaeForm.txtDescr.Text;



                context.Entry(income).State = EntityState.Modified;
                context.SaveChanges();

                MessageBox.Show("Запись обновлен");
            }
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

                Income income = context.IncList.Find(id);
                context.IncList.Remove(income);
                context.SaveChanges();

                MessageBox.Show("Запись удален");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IncCategoryForm incCategory = new IncCategoryForm();
            incCategory.Show();
        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
