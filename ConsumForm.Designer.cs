namespace FamilyBudget
{
    partial class ConsumForm
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
            this.btnConCat = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.consumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consumIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.descrDataGridViewTextBoxColumn,
            this.consCategoryDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.consumBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(776, 357);
            this.dataGridView.TabIndex = 5;
            // 
            // btnConCat
            // 
            this.btnConCat.Location = new System.Drawing.Point(663, 386);
            this.btnConCat.Name = "btnConCat";
            this.btnConCat.Size = new System.Drawing.Size(75, 23);
            this.btnConCat.TabIndex = 9;
            this.btnConCat.Text = "Категория";
            this.btnConCat.UseVisualStyleBackColor = true;
            this.btnConCat.Click += new System.EventHandler(this.btnConCat_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(407, 386);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 38);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(221, 386);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(154, 38);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(33, 386);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 38);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // consumBindingSource
            // 
            this.consumBindingSource.DataSource = typeof(FamilyBudget.Models.Consum);
            // 
            // consumIdDataGridViewTextBoxColumn
            // 
            this.consumIdDataGridViewTextBoxColumn.DataPropertyName = "ConsumId";
            this.consumIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.consumIdDataGridViewTextBoxColumn.Name = "consumIdDataGridViewTextBoxColumn";
            this.consumIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consDateDataGridViewTextBoxColumn
            // 
            this.consDateDataGridViewTextBoxColumn.DataPropertyName = "ConsDate";
            this.consDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.consDateDataGridViewTextBoxColumn.Name = "consDateDataGridViewTextBoxColumn";
            this.consDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consSumDataGridViewTextBoxColumn
            // 
            this.consSumDataGridViewTextBoxColumn.DataPropertyName = "ConsSum";
            this.consSumDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.consSumDataGridViewTextBoxColumn.Name = "consSumDataGridViewTextBoxColumn";
            this.consSumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descrDataGridViewTextBoxColumn
            // 
            this.descrDataGridViewTextBoxColumn.DataPropertyName = "Descr";
            this.descrDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descrDataGridViewTextBoxColumn.Name = "descrDataGridViewTextBoxColumn";
            this.descrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consCategoryDataGridViewTextBoxColumn
            // 
            this.consCategoryDataGridViewTextBoxColumn.DataPropertyName = "ConsCategory";
            this.consCategoryDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.consCategoryDataGridViewTextBoxColumn.Name = "consCategoryDataGridViewTextBoxColumn";
            this.consCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ConsumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnConCat);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "ConsumForm";
            this.Text = "ConsumForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnConCat;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource consumBindingSource;
    }
}