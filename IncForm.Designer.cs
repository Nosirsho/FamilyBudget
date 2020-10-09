namespace FamilyBudget
{
    partial class IncForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cbCategory = new MetroFramework.Controls.MetroComboBox();
            this.incomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtDescr = new MetroFramework.Controls.MetroTextBox();
            this.txtSum = new MetroFramework.Controls.MetroTextBox();
            this.txtIncId = new MetroFramework.Controls.MetroTextBox();
            this.GridInc = new MetroFramework.Controls.MetroGrid();
            this.incomeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incCategoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridInc)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.cbCategory);
            this.metroPanel1.Controls.Add(this.dtDate);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txtDescr);
            this.metroPanel1.Controls.Add(this.txtSum);
            this.metroPanel1.Controls.Add(this.txtIncId);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(381, 64);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(342, 349);
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cbCategory
            // 
            this.cbCategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incomeBindingSource, "IncCategoryId", true));
            this.cbCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.incCategoryBindingSource, "Name", true));
            this.cbCategory.DataSource = this.incCategoryBindingSource;
            this.cbCategory.DisplayMember = "Name";
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.ItemHeight = 23;
            this.cbCategory.Location = new System.Drawing.Point(95, 111);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(224, 29);
            this.cbCategory.TabIndex = 6;
            this.cbCategory.UseSelectable = true;
            this.cbCategory.ValueMember = "IncCategoryId";
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // incomeBindingSource
            // 
            this.incomeBindingSource.DataSource = typeof(FamilyBudget.Models.Income);
            // 
            // incCategoryBindingSource
            // 
            this.incCategoryBindingSource.DataSource = typeof(FamilyBudget.Models.IncCategory);
            // 
            // dtDate
            // 
            this.dtDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incomeBindingSource, "IncDate", true));
            this.dtDate.Location = new System.Drawing.Point(95, 47);
            this.dtDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(200, 29);
            this.dtDate.TabIndex = 5;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(17, 146);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(72, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Описание";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(18, 121);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Категория";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(52, 57);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(37, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Дата";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(40, 82);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Сумма";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(68, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "ID";
            // 
            // txtDescr
            // 
            // 
            // 
            // 
            this.txtDescr.CustomButton.Image = null;
            this.txtDescr.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtDescr.CustomButton.Name = "";
            this.txtDescr.CustomButton.Size = new System.Drawing.Size(71, 71);
            this.txtDescr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescr.CustomButton.TabIndex = 1;
            this.txtDescr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescr.CustomButton.UseSelectable = true;
            this.txtDescr.CustomButton.Visible = false;
            this.txtDescr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incomeBindingSource, "Descr", true));
            this.txtDescr.Lines = new string[0];
            this.txtDescr.Location = new System.Drawing.Point(95, 146);
            this.txtDescr.MaxLength = 32767;
            this.txtDescr.Multiline = true;
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.PasswordChar = '\0';
            this.txtDescr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescr.SelectedText = "";
            this.txtDescr.SelectionLength = 0;
            this.txtDescr.SelectionStart = 0;
            this.txtDescr.ShortcutsEnabled = true;
            this.txtDescr.Size = new System.Drawing.Size(224, 73);
            this.txtDescr.TabIndex = 3;
            this.txtDescr.UseSelectable = true;
            this.txtDescr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSum
            // 
            // 
            // 
            // 
            this.txtSum.CustomButton.Image = null;
            this.txtSum.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.txtSum.CustomButton.Name = "";
            this.txtSum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSum.CustomButton.TabIndex = 1;
            this.txtSum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSum.CustomButton.UseSelectable = true;
            this.txtSum.CustomButton.Visible = false;
            this.txtSum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incomeBindingSource, "IncSum", true));
            this.txtSum.Lines = new string[0];
            this.txtSum.Location = new System.Drawing.Point(95, 82);
            this.txtSum.MaxLength = 32767;
            this.txtSum.Name = "txtSum";
            this.txtSum.PasswordChar = '\0';
            this.txtSum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSum.SelectedText = "";
            this.txtSum.SelectionLength = 0;
            this.txtSum.SelectionStart = 0;
            this.txtSum.ShortcutsEnabled = true;
            this.txtSum.Size = new System.Drawing.Size(224, 23);
            this.txtSum.TabIndex = 3;
            this.txtSum.UseSelectable = true;
            this.txtSum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtIncId
            // 
            // 
            // 
            // 
            this.txtIncId.CustomButton.Image = null;
            this.txtIncId.CustomButton.Location = new System.Drawing.Point(34, 1);
            this.txtIncId.CustomButton.Name = "";
            this.txtIncId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIncId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIncId.CustomButton.TabIndex = 1;
            this.txtIncId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIncId.CustomButton.UseSelectable = true;
            this.txtIncId.CustomButton.Visible = false;
            this.txtIncId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incomeBindingSource, "IncomeId", true));
            this.txtIncId.Lines = new string[0];
            this.txtIncId.Location = new System.Drawing.Point(95, 18);
            this.txtIncId.MaxLength = 32767;
            this.txtIncId.Name = "txtIncId";
            this.txtIncId.PasswordChar = '\0';
            this.txtIncId.ReadOnly = true;
            this.txtIncId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIncId.SelectedText = "";
            this.txtIncId.SelectionLength = 0;
            this.txtIncId.SelectionStart = 0;
            this.txtIncId.ShortcutsEnabled = true;
            this.txtIncId.Size = new System.Drawing.Size(56, 23);
            this.txtIncId.TabIndex = 3;
            this.txtIncId.UseSelectable = true;
            this.txtIncId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIncId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // GridInc
            // 
            this.GridInc.AllowUserToResizeRows = false;
            this.GridInc.AutoGenerateColumns = false;
            this.GridInc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridInc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridInc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridInc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridInc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridInc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridInc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.incomeIdDataGridViewTextBoxColumn,
            this.incDateDataGridViewTextBoxColumn,
            this.incSumDataGridViewTextBoxColumn,
            this.descrDataGridViewTextBoxColumn,
            this.incCategoryIdDataGridViewTextBoxColumn,
            this.incCategoryDataGridViewTextBoxColumn});
            this.GridInc.DataSource = this.incomeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridInc.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridInc.EnableHeadersVisualStyles = false;
            this.GridInc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridInc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridInc.Location = new System.Drawing.Point(23, 63);
            this.GridInc.Name = "GridInc";
            this.GridInc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridInc.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridInc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridInc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridInc.Size = new System.Drawing.Size(352, 350);
            this.GridInc.TabIndex = 10;
            this.GridInc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridInc_CellClick);
            // 
            // incomeIdDataGridViewTextBoxColumn
            // 
            this.incomeIdDataGridViewTextBoxColumn.DataPropertyName = "IncomeId";
            this.incomeIdDataGridViewTextBoxColumn.HeaderText = "IncomeId";
            this.incomeIdDataGridViewTextBoxColumn.Name = "incomeIdDataGridViewTextBoxColumn";
            // 
            // incDateDataGridViewTextBoxColumn
            // 
            this.incDateDataGridViewTextBoxColumn.DataPropertyName = "IncDate";
            this.incDateDataGridViewTextBoxColumn.HeaderText = "IncDate";
            this.incDateDataGridViewTextBoxColumn.Name = "incDateDataGridViewTextBoxColumn";
            // 
            // incSumDataGridViewTextBoxColumn
            // 
            this.incSumDataGridViewTextBoxColumn.DataPropertyName = "IncSum";
            this.incSumDataGridViewTextBoxColumn.HeaderText = "IncSum";
            this.incSumDataGridViewTextBoxColumn.Name = "incSumDataGridViewTextBoxColumn";
            // 
            // descrDataGridViewTextBoxColumn
            // 
            this.descrDataGridViewTextBoxColumn.DataPropertyName = "Descr";
            this.descrDataGridViewTextBoxColumn.HeaderText = "Descr";
            this.descrDataGridViewTextBoxColumn.Name = "descrDataGridViewTextBoxColumn";
            // 
            // incCategoryIdDataGridViewTextBoxColumn
            // 
            this.incCategoryIdDataGridViewTextBoxColumn.DataPropertyName = "IncCategoryId";
            this.incCategoryIdDataGridViewTextBoxColumn.HeaderText = "IncCategoryId";
            this.incCategoryIdDataGridViewTextBoxColumn.Name = "incCategoryIdDataGridViewTextBoxColumn";
            // 
            // incCategoryDataGridViewTextBoxColumn
            // 
            this.incCategoryDataGridViewTextBoxColumn.DataPropertyName = "IncCategory";
            this.incCategoryDataGridViewTextBoxColumn.HeaderText = "IncCategory";
            this.incCategoryDataGridViewTextBoxColumn.Name = "incCategoryDataGridViewTextBoxColumn";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(650, 427);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(582, 427);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(514, 427);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(446, 427);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(62, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(381, 427);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // IncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 473);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.GridInc);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "IncForm";
            this.Text = "Доходы";
            this.Load += new System.EventHandler(this.IncForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridInc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroDateTime dtDate;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtDescr;
        private MetroFramework.Controls.MetroTextBox txtSum;
        private MetroFramework.Controls.MetroTextBox txtIncId;
        private MetroFramework.Controls.MetroGrid GridInc;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incCategoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource incomeBindingSource;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroComboBox cbCategory;
        private System.Windows.Forms.BindingSource incCategoryBindingSource;
    }
}