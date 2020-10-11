using FamilyBudget.Models;
using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class IncomeRoundChart : Form {
        BudgetContext context;
        public IncomeRoundChart()
        {
            InitializeComponent();
            context = new BudgetContext();
            context.IncList.Load();
            context.IncCategoryList.Load();
        }
        Func<ChartPoint, string> label = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Доход";
            
            for (int i = 1; i < dataGridView.Columns.Count + 1; i++) {
                worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;

            }

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++) {
                    worksheet.Cells.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "СемБуджДоход";
            saveFileDialog.DefaultExt = ".xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }

        private void IncomeRoundChart_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = context.IncList.ToList();
            pieChart1.LegendLocation = LegendLocation.Right;
            SeriesCollection series = new SeriesCollection();
            incomeBindingSource.DataSource = context.IncList.ToList();
            var catSum = (from s in incomeBindingSource.DataSource as List<Income>
                          group s by s.IncCategory into g
                          select new { gCat = g.Key, gSum = g.Sum(x => x.IncSum) });



            foreach (var obj in catSum)

                series.Add(new PieSeries() { Title = obj.gCat.ToString(), Values = new ChartValues<decimal> { obj.gSum }, DataLabels = true, LabelPoint = label });
            pieChart1.Series = series;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
        }
    }
}
