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
            string[] lbl;
            List<string> lblList =  new List<string>();
            foreach (Income date in incomes) {
                lblList.Add(date.IncDate.ToString());
            }
            lbl = lblList.ToArray();
            incomeBindingSource.DataSource = context.IncList.ToList();
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Дата",
                Labels = lbl
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
            
            Income[] incArr = incomes.ToArray();

            var cats = (from o in incomeBindingSource.DataSource as List<Income>
                        select new { iCat = o.IncCategory }).Distinct();
            var dates = (from o in incomeBindingSource.DataSource as List<Income>
                         select new { iDate = o.IncDate }).Distinct();


            foreach (var cat in cats)
            {
                List<double> values = new List<double>();

                foreach (var date in dates)
                {
                    decimal value = 0;
                    var data = from o in incomeBindingSource.DataSource as List<Income>
                               where o.IncCategory.Equals(cat.iCat) && o.IncDate.Equals(date.iDate)
                               orderby o.IncDate ascending
                               select new { o.IncSum, o.IncDate };
                    if (data.SingleOrDefault() != null)
                        value = data.SingleOrDefault().IncSum;
                    values.Add(decimal.ToDouble(value));
                }
                
                series.Add(new LineSeries { Title = cat.iCat.ToString(), Values = new ChartValues<double>(values) });
            }
            cartesianChart1.Series = series;

        }


    }
}
