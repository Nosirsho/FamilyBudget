namespace FamilyBudget {
    partial class MainForm {
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
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnConsum = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIncChart = new System.Windows.Forms.Button();
            this.btnConsChart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIncome
            // 
            this.btnIncome.Location = new System.Drawing.Point(6, 19);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(182, 42);
            this.btnIncome.TabIndex = 0;
            this.btnIncome.Text = "Доход";
            this.btnIncome.UseVisualStyleBackColor = true;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnConsum
            // 
            this.btnConsum.Location = new System.Drawing.Point(6, 67);
            this.btnConsum.Name = "btnConsum";
            this.btnConsum.Size = new System.Drawing.Size(182, 42);
            this.btnConsum.TabIndex = 1;
            this.btnConsum.Text = "Расход";
            this.btnConsum.UseVisualStyleBackColor = true;
            this.btnConsum.Click += new System.EventHandler(this.btnConsum_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIncome);
            this.groupBox1.Controls.Add(this.btnConsum);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление расходов и доходов";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConsChart);
            this.groupBox2.Controls.Add(this.btnIncChart);
            this.groupBox2.Location = new System.Drawing.Point(18, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 167);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отчеты";
            // 
            // btnIncChart
            // 
            this.btnIncChart.Location = new System.Drawing.Point(22, 19);
            this.btnIncChart.Name = "btnIncChart";
            this.btnIncChart.Size = new System.Drawing.Size(182, 39);
            this.btnIncChart.TabIndex = 2;
            this.btnIncChart.Text = "Доходы по категориям";
            this.btnIncChart.UseVisualStyleBackColor = true;
            this.btnIncChart.Click += new System.EventHandler(this.btnIncChart_Click);
            // 
            // btnConsChart
            // 
            this.btnConsChart.Location = new System.Drawing.Point(22, 64);
            this.btnConsChart.Name = "btnConsChart";
            this.btnConsChart.Size = new System.Drawing.Size(182, 39);
            this.btnConsChart.TabIndex = 3;
            this.btnConsChart.Text = "Расходы по категориям";
            this.btnConsChart.UseVisualStyleBackColor = true;
            this.btnConsChart.Click += new System.EventHandler(this.btnConsChart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 335);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Button btnConsum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConsChart;
        private System.Windows.Forms.Button btnIncChart;
    }
}