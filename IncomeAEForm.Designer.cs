namespace FamilyBudget
{
    partial class IncomeAEForm
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
            this.txtDescr = new MetroFramework.Controls.MetroTextBox();
            this.cbCategory = new MetroFramework.Controls.MetroComboBox();
            this.dtDate = new MetroFramework.Controls.MetroDateTime();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtIncSum = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDescr
            // 
            // 
            // 
            // 
            this.txtDescr.CustomButton.Image = null;
            this.txtDescr.CustomButton.Location = new System.Drawing.Point(82, 2);
            this.txtDescr.CustomButton.Name = "";
            this.txtDescr.CustomButton.Size = new System.Drawing.Size(115, 115);
            this.txtDescr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescr.CustomButton.TabIndex = 1;
            this.txtDescr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescr.CustomButton.UseSelectable = true;
            this.txtDescr.CustomButton.Visible = false;
            this.txtDescr.Lines = new string[0];
            this.txtDescr.Location = new System.Drawing.Point(97, 123);
            this.txtDescr.MaxLength = 32767;
            this.txtDescr.Multiline = true;
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.PasswordChar = '\0';
            this.txtDescr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescr.SelectedText = "";
            this.txtDescr.SelectionLength = 0;
            this.txtDescr.SelectionStart = 0;
            this.txtDescr.ShortcutsEnabled = true;
            this.txtDescr.Size = new System.Drawing.Size(200, 120);
            this.txtDescr.TabIndex = 1;
            this.txtDescr.UseSelectable = true;
            this.txtDescr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.ItemHeight = 23;
            this.cbCategory.Location = new System.Drawing.Point(97, 88);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(200, 29);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.UseSelectable = true;
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(97, 24);
            this.dtDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(200, 29);
            this.dtDate.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(18, 262);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(117, 33);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(180, 262);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 33);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtIncSum
            // 
            // 
            // 
            // 
            this.txtIncSum.CustomButton.Image = null;
            this.txtIncSum.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtIncSum.CustomButton.Name = "";
            this.txtIncSum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIncSum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIncSum.CustomButton.TabIndex = 1;
            this.txtIncSum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIncSum.CustomButton.UseSelectable = true;
            this.txtIncSum.CustomButton.Visible = false;
            this.txtIncSum.Lines = new string[0];
            this.txtIncSum.Location = new System.Drawing.Point(97, 59);
            this.txtIncSum.MaxLength = 32767;
            this.txtIncSum.Name = "txtIncSum";
            this.txtIncSum.PasswordChar = '\0';
            this.txtIncSum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIncSum.SelectedText = "";
            this.txtIncSum.SelectionLength = 0;
            this.txtIncSum.SelectionStart = 0;
            this.txtIncSum.ShortcutsEnabled = true;
            this.txtIncSum.Size = new System.Drawing.Size(200, 23);
            this.txtIncSum.TabIndex = 6;
            this.txtIncSum.UseSelectable = true;
            this.txtIncSum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIncSum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Сумма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Категория";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Описание";
            // 
            // IncomeAEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 315);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIncSum);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txtDescr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IncomeAEForm";
            this.Text = "Добавление дохода";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected internal MetroFramework.Controls.MetroTextBox txtDescr;
        protected internal MetroFramework.Controls.MetroComboBox cbCategory;
        protected internal MetroFramework.Controls.MetroDateTime dtDate;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        protected internal MetroFramework.Controls.MetroTextBox txtIncSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}