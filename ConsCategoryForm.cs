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
    public partial class ConsCategoryForm : Form
    {
        BudgetContext context;
        public ConsCategoryForm()
        {
            InitializeComponent();
            context = new BudgetContext();
            context.ConsCategoryList.Load();
            dataGridView.DataSource = context.ConsCategoryList.Local.ToBindingList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ConsCtForm ccaeForm = new ConsCtForm();
            DialogResult result = ccaeForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            ConsCategory conCat = new ConsCategory();
            conCat.Name = ccaeForm.txtName.Text;
            context.ConsCategoryList.Add(conCat);
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

                ConsCategory cCat = context.ConsCategoryList.Find(id);
                cCat.Consums.Clear();
                context.ConsCategoryList.Remove(cCat);
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

                ConsCategory cCat = context.ConsCategoryList.Find(id);

                ConsCtForm consCtForm = new ConsCtForm();
                consCtForm.txtName.Text = cCat.Name;


                DialogResult result = consCtForm.ShowDialog(this);
                if (result == DialogResult.Cancel)
                    return;

                cCat.Name = consCtForm.txtName.Text;


                context.Entry(cCat).State = EntityState.Modified;
                context.SaveChanges();
                MessageBox.Show("Категория обновлена");
            }
        }
    }
}
