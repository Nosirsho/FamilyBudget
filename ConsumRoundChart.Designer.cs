namespace FamilyBudget {
    partial class ConsumRoundChart {
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.pieChart1 = new LiveCharts.Wpf.PieChart();
            this.consumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.consumIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.consumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(159, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Диаграмма расходов по категориям";
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Minion", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(564, 324);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 34);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Экспорт";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(12, 41);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(546, 317);
            this.elementHost1.TabIndex = 9;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.pieChart1;
            // 
            // consumBindingSource
            // 
            this.consumBindingSource.DataSource = typeof(FamilyBudget.Models.Consum);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.consumIdDataGridViewTextBoxColumn,
            this.consDateDataGridViewTextBoxColumn,
            this.consSumDataGridViewTextBoxColumn,
            this.consCategoryDataGridViewTextBoxColumn,
            this.descrDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.consumBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 364);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(627, 141);
            this.dataGridView.TabIndex = 12;
            // 
            // consumIdDataGridViewTextBoxColumn
            // 
            this.consumIdDataGridViewTextBoxColumn.DataPropertyName = "ConsumId";
            this.consumIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.consumIdDataGridViewTextBoxColumn.Name = "consumIdDataGridViewTextBoxColumn";
            this.consumIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.consumIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // consDateDataGridViewTextBoxColumn
            // 
            this.consDateDataGridViewTextBoxColumn.DataPropertyName = "ConsDate";
            this.consDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.consDateDataGridViewTextBoxColumn.Name = "consDateDataGridViewTextBoxColumn";
            this.consDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.consDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // consSumDataGridViewTextBoxColumn
            // 
            this.consSumDataGridViewTextBoxColumn.DataPropertyName = "ConsSum";
            this.consSumDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.consSumDataGridViewTextBoxColumn.Name = "consSumDataGridViewTextBoxColumn";
            this.consSumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consCategoryDataGridViewTextBoxColumn
            // 
            this.consCategoryDataGridViewTextBoxColumn.DataPropertyName = "ConsCategory";
            this.consCategoryDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.consCategoryDataGridViewTextBoxColumn.Name = "consCategoryDataGridViewTextBoxColumn";
            this.consCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.consCategoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // descrDataGridViewTextBoxColumn
            // 
            this.descrDataGridViewTextBoxColumn.DataPropertyName = "Descr";
            this.descrDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descrDataGridViewTextBoxColumn.Name = "descrDataGridViewTextBoxColumn";
            this.descrDataGridViewTextBoxColumn.ReadOnly = true;
            this.descrDataGridViewTextBoxColumn.Width = 200;
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Minion", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(12, 4);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(74, 31);
            this.btnMain.TabIndex = 10;
            this.btnMain.Text = "Главная";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // ConsumRoundChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 513);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.elementHost1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConsumRoundChart";
            this.Text = "Расходы по категориям";
            this.Load += new System.EventHandler(this.ConsumRoundChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.PieChart pieChart1;
        private System.Windows.Forms.BindingSource consumBindingSource;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrDataGridViewTextBoxColumn;
    }
}