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
            this.consumIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnConCat = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
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
            this.consCategoryDataGridViewTextBoxColumn,
            this.descrDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.consumBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(16, 49);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(625, 357);
            this.dataGridView.TabIndex = 5;
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
            // consumBindingSource
            // 
            this.consumBindingSource.DataSource = typeof(FamilyBudget.Models.Consum);
            // 
            // btnConCat
            // 
            this.btnConCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConCat.Location = new System.Drawing.Point(543, 12);
            this.btnConCat.Name = "btnConCat";
            this.btnConCat.Size = new System.Drawing.Size(98, 31);
            this.btnConCat.TabIndex = 9;
            this.btnConCat.Text = "Категория";
            this.btnConCat.UseVisualStyleBackColor = true;
            this.btnConCat.Click += new System.EventHandler(this.btnConCat_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(488, 412);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 38);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(241, 412);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(154, 38);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(16, 412);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 38);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMain.Location = new System.Drawing.Point(16, 12);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 31);
            this.btnMain.TabIndex = 10;
            this.btnMain.Text = "Главная";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // ConsumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 461);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnConCat);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConsumForm";
            this.Text = "Расход";
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
        private System.Windows.Forms.BindingSource consumBindingSource;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrDataGridViewTextBoxColumn;
    }
}