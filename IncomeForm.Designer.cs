namespace FamilyBudget
{
    partial class IncomeForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.incomeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
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
            this.dataGridView.Location = new System.Drawing.Point(12, 45);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(624, 357);
            this.dataGridView.TabIndex = 0;
            // 
            // incomeIdDataGridViewTextBoxColumn
            // 
            this.incomeIdDataGridViewTextBoxColumn.DataPropertyName = "IncomeId";
            this.incomeIdDataGridViewTextBoxColumn.HeaderText = "Id";
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
            this.incCategoryDataGridViewTextBoxColumn.HeaderText = "Категоория";
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
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Minion", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 408);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Minion", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(233, 408);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(168, 38);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Minion", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(468, 408);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(168, 38);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Minion", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(547, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Категория";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Minion", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(12, 12);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(89, 27);
            this.btnMain.TabIndex = 5;
            this.btnMain.Text = "Главная";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 454);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "IncomeForm";
            this.Text = "Приход";
            this.Load += new System.EventHandler(this.IncomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource incomeBindingSource;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrDataGridViewTextBoxColumn;
    }
}