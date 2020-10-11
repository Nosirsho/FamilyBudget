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
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyBudget
{
    public partial class IncomeChartForm : Form
    {
        BudgetContext context;
        public IncomeChartForm()
        {
            
            InitializeComponent();
            context = new BudgetContext();
            context.IncList.Load();
            context.IncCategoryList.Load();
            
        }

        private void IncomeChartForm_Load(object sender, EventArgs e)
        {

            

            List<Income> incomes = context.IncList.ToList();
            
            incomeBindingSource.DataSource = context.IncList.ToList();
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Дата",
                Labels = new [] {"янв", "фев", "мар", "апр", "май", "июн", "июл", "авг", "сен", "окт", "ноя", "дек", }
            });
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Сумма",
                LabelFormatter = value => value.ToString("C")
            });
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            List<Income> incomes = context.IncList.ToList();
            List<Consum> consums = context.ConsList.ToList();

            var incDtSum = (from inc in incomes
                            group inc by inc.IncDate.Month into g
                            select new {gDate = g.Key, gSum=g.Sum(x=>x.IncSum) } );
            var consDtSum = (from inc in consums
                            group inc by inc.ConsDate.Month into g
                            select new { gDate = g.Key, gSum = g.Sum(x => x.ConsSum) });


            dataGridView.ColumnCount = 3;
            dataGridView.Columns[0].Name = "Месяц";
            dataGridView.Columns[1].Name = "Приход";
            dataGridView.Columns[2].Name = "Расход";
            dataGridView.Columns[0].Width = 50;
            dataGridView.Columns[1].Width = 70;
            dataGridView.Columns[2].Width = 70;
            this.dataGridView.Rows.Clear();

            List<decimal> incVal = new List<decimal>();
            List<decimal> consVal = new List<decimal>();
            for (int i = 1; i <= 12; i++) {
                decimal iVal = 0;
                decimal cVal = 0;
                foreach (var idt in incDtSum) {
                    if (idt.gDate == i)
                        iVal = idt.gSum;
                }
                incVal.Add(iVal);
                foreach (var cdt in consDtSum)
                {
                    if (cdt.gDate == i)
                        cVal = cdt.gSum;
                }
                consVal.Add(cVal);
                dataGridView.Rows.Add(System.Globalization.CultureInfo.CurrentUICulture.DateTimeFormat.AbbreviatedMonthNames[i-1], iVal.ToString(),cVal.ToString());
            }

            series.Add(new LineSeries { Title = "Приход", Values = new ChartValues<decimal>(incVal) });
            series.Add(new LineSeries { Title = "Расход", Values = new ChartValues<decimal>(consVal) });


            cartesianChart1.Series = series;

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "ПриходРасход";

            for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;

            }

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cells.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "СемБуджДоходРасход";
            saveFileDialog.DefaultExt = ".xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
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
