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
    public partial class ConsumForm : Form
    {
        BudgetContext context;
        public ConsumForm()
        {
            InitializeComponent();
            context = new BudgetContext();
            context.ConsList.Load();
            context.ConsCategoryList.Load();
            //
            dataGridView.DataSource = context.ConsList.Local.ToBindingList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ConsumAEForm caeForm = new ConsumAEForm();

            List<ConsCategory> consCategories = context.ConsCategoryList.ToList();

            caeForm.cbCategory.DataSource = consCategories;
            caeForm.cbCategory.ValueMember = "ConsCategoryId";
            caeForm.cbCategory.DisplayMember = "Name";

            DialogResult result = caeForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Consum consum = new Consum();
            consum.ConsDate = (DateTime)caeForm.dtDate.Value;
            consum.ConsSum = decimal.Parse(caeForm.txtIncSum.Text);
            consum.ConsCategory = (ConsCategory)caeForm.cbCategory.SelectedItem;
            consum.Descr = caeForm.txtDescr.Text;

            context.ConsList.Add(consum);
            context.SaveChanges();

            MessageBox.Show("Расход добавлен");
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

                Consum consum = context.ConsList.Find(id);

                ConsumAEForm caeForm = new ConsumAEForm();

                caeForm.dtDate.Value = consum.ConsDate;
                caeForm.txtIncSum.Text = consum.ConsSum.ToString();
                caeForm.cbCategory.SelectedItem = consum.ConsCategory;
                caeForm.txtDescr.Text = consum.Descr;

                List<ConsCategory> conCats = context.ConsCategoryList.ToList();
                caeForm.cbCategory.DataSource = conCats;
                caeForm.cbCategory.ValueMember = "ConsCategoryId";
                caeForm.cbCategory.DisplayMember = "Name";

                if (consum.ConsCategory != null)
                    caeForm.cbCategory.SelectedValue = consum.ConsCategory.ConsCategoryId;

                DialogResult result = caeForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                consum.ConsDate = (DateTime)caeForm.dtDate.Value;
                consum.ConsSum = decimal.Parse(caeForm.txtIncSum.Text);
                consum.ConsCategory = (ConsCategory)caeForm.cbCategory.SelectedItem;
                consum.Descr = caeForm.txtDescr.Text;



                context.Entry(consum).State = EntityState.Modified;
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

                Consum consum = context.ConsList.Find(id);
                context.ConsList.Remove(consum);
                context.SaveChanges();

                MessageBox.Show("Запись удален");
            }
        }

       
        private void btnConCat_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            ConsCategoryForm conCatForm = new ConsCategoryForm();
            conCatForm.Closed += (s, args) => this.Close();
            conCatForm.StartPosition = FormStartPosition.CenterScreen;
            conCatForm.Show();
            
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
        }
    }
}
