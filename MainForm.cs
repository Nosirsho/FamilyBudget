using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyBudget {
    public partial class MainForm : Form {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            this.Hide();
            IncomeForm incomeForm = new IncomeForm();
            incomeForm.StartPosition = FormStartPosition.CenterScreen;
            incomeForm.Show();
        }

        private void btnConsum_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsumForm consumForm = new ConsumForm();
            consumForm.StartPosition = FormStartPosition.CenterScreen;
            consumForm.Show();
        }

        private void btnIncChart_Click(object sender, EventArgs e)
        {
            this.Hide();
            IncomeRoundChart incChart = new IncomeRoundChart();
            incChart.StartPosition = FormStartPosition.CenterScreen;
            incChart.Show();
        }

        private void btnConsChart_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsumRoundChart consChart = new ConsumRoundChart();
            consChart.StartPosition = FormStartPosition.CenterScreen;
            consChart.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            IncomeChartForm incChartForm = new IncomeChartForm();
            incChartForm.StartPosition = FormStartPosition.CenterScreen;
            incChartForm.Show();
        }
    }
}
