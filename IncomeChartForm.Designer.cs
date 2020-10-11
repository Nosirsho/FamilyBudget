namespace FamilyBudget
{
    partial class IncomeChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.btnLoad = new System.Windows.Forms.Button();
            this.incomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.incomeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(13, 13);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(775, 300);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(795, 253);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "button1";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // incomeBindingSource
            // 
            this.incomeBindingSource.DataSource = typeof(FamilyBudget.Models.Income);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.incomeIdDataGridViewTextBoxColumn,
            this.incDateDataGridViewTextBoxColumn,
            this.incSumDataGridViewTextBoxColumn,
            this.incCategoryDataGridViewTextBoxColumn,
            this.descrDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.incomeBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 319);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(776, 121);
            this.dataGridView.TabIndex = 3;
            // 
            // incomeIdDataGridViewTextBoxColumn
            // 
            this.incomeIdDataGridViewTextBoxColumn.DataPropertyName = "IncomeId";
            this.incomeIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.incomeIdDataGridViewTextBoxColumn.Name = "incomeIdDataGridViewTextBoxColumn";
            this.incomeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incDateDataGridViewTextBoxColumn
            // 
            this.incDateDataGridViewTextBoxColumn.DataPropertyName = "IncDate";
            this.incDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.incDateDataGridViewTextBoxColumn.Name = "incDateDataGridViewTextBoxColumn";
            this.incDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incSumDataGridViewTextBoxColumn
            // 
            this.incSumDataGridViewTextBoxColumn.DataPropertyName = "IncSum";
            this.incSumDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.incSumDataGridViewTextBoxColumn.Name = "incSumDataGridViewTextBoxColumn";
            this.incSumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incCategoryDataGridViewTextBoxColumn
            // 
            this.incCategoryDataGridViewTextBoxColumn.DataPropertyName = "IncCategory";
            this.incCategoryDataGridViewTextBoxColumn.HeaderText = "Категоория";
            this.incCategoryDataGridViewTextBoxColumn.Name = "incCategoryDataGridViewTextBoxColumn";
            this.incCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descrDataGridViewTextBoxColumn
            // 
            this.descrDataGridViewTextBoxColumn.DataPropertyName = "Descr";
            this.descrDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descrDataGridViewTextBoxColumn.Name = "descrDataGridViewTextBoxColumn";
            this.descrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IncomeChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 522);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cartesianChart1);
            this.Name = "IncomeChartForm";
            this.Text = "IncomeChartForm";
            this.Load += new System.EventHandler(this.IncomeChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.BindingSource incomeBindingSource;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrDataGridViewTextBoxColumn;
    }
}