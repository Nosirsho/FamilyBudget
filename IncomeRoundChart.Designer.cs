namespace FamilyBudget {
    partial class IncomeRoundChart {
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.incomeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.pieChart1 = new LiveCharts.Wpf.PieChart();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView.Location = new System.Drawing.Point(12, 362);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(576, 121);
            this.dataGridView.TabIndex = 4;
            // 
            // incomeIdDataGridViewTextBoxColumn
            // 
            this.incomeIdDataGridViewTextBoxColumn.DataPropertyName = "IncomeId";
            this.incomeIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.incomeIdDataGridViewTextBoxColumn.Name = "incomeIdDataGridViewTextBoxColumn";
            this.incomeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.incomeIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // incDateDataGridViewTextBoxColumn
            // 
            this.incDateDataGridViewTextBoxColumn.DataPropertyName = "IncDate";
            this.incDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.incDateDataGridViewTextBoxColumn.Name = "incDateDataGridViewTextBoxColumn";
            this.incDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.incDateDataGridViewTextBoxColumn.Width = 80;
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
            this.incCategoryDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.incCategoryDataGridViewTextBoxColumn.Name = "incCategoryDataGridViewTextBoxColumn";
            this.incCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.incCategoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // descrDataGridViewTextBoxColumn
            // 
            this.descrDataGridViewTextBoxColumn.DataPropertyName = "Descr";
            this.descrDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descrDataGridViewTextBoxColumn.Name = "descrDataGridViewTextBoxColumn";
            this.descrDataGridViewTextBoxColumn.ReadOnly = true;
            this.descrDataGridViewTextBoxColumn.Width = 200;
            // 
            // incomeBindingSource
            // 
            this.incomeBindingSource.DataSource = typeof(FamilyBudget.Models.Income);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(16, 43);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(490, 317);
            this.elementHost1.TabIndex = 5;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.pieChart1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Minion", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(513, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Экспорт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(141, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Диаграмма доходов по категориям";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Minion", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(16, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Главная";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IncomeRoundChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 488);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IncomeRoundChart";
            this.Text = "Семейный бюджет - Доход";
            this.Load += new System.EventHandler(this.IncomeRoundChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource incomeBindingSource;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.PieChart pieChart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}