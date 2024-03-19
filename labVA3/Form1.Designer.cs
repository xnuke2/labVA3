namespace labVA3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataDivisionByHalf = new System.Windows.Forms.DataGridView();
            this.numericUpDownStart = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEnd = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.AlRezLabel = new System.Windows.Forms.Label();
            this.buttonDivisionByHalf = new System.Windows.Forms.Button();
            this.buttonNewton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDivisionByHalf = new System.Windows.Forms.Label();
            this.labelTimeNewton = new System.Windows.Forms.Label();
            this.ColumnNumOfIter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewNewton = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDivisionByHalf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "e^( –x) - 2,6x + 4,3 = 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Метод половинного деления";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Метод Ньютона";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelDivisionByHalf);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.buttonDivisionByHalf);
            this.panel1.Controls.Add(this.dataDivisionByHalf);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 345);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewNewton);
            this.panel2.Controls.Add(this.labelTimeNewton);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.buttonNewton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(406, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 345);
            this.panel2.TabIndex = 5;
            // 
            // dataDivisionByHalf
            // 
            this.dataDivisionByHalf.AllowUserToAddRows = false;
            this.dataDivisionByHalf.AllowUserToDeleteRows = false;
            this.dataDivisionByHalf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDivisionByHalf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumOfIter,
            this.ColumnValue});
            this.dataDivisionByHalf.Location = new System.Drawing.Point(3, 41);
            this.dataDivisionByHalf.Name = "dataDivisionByHalf";
            this.dataDivisionByHalf.ReadOnly = true;
            this.dataDivisionByHalf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataDivisionByHalf.Size = new System.Drawing.Size(382, 238);
            this.dataDivisionByHalf.TabIndex = 5;
            // 
            // numericUpDownStart
            // 
            this.numericUpDownStart.Location = new System.Drawing.Point(336, 27);
            this.numericUpDownStart.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownStart.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownStart.Name = "numericUpDownStart";
            this.numericUpDownStart.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownStart.TabIndex = 6;
            // 
            // numericUpDownEnd
            // 
            this.numericUpDownEnd.Location = new System.Drawing.Point(431, 27);
            this.numericUpDownEnd.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownEnd.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownEnd.Name = "numericUpDownEnd";
            this.numericUpDownEnd.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownEnd.TabIndex = 7;
            this.numericUpDownEnd.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Промежуток: от ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "до";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(278, 53);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(227, 29);
            this.buttonCheck.TabIndex = 10;
            this.buttonCheck.Text = "Проверить наличие корней";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // AlRezLabel
            // 
            this.AlRezLabel.AutoSize = true;
            this.AlRezLabel.Location = new System.Drawing.Point(511, 61);
            this.AlRezLabel.Name = "AlRezLabel";
            this.AlRezLabel.Size = new System.Drawing.Size(35, 13);
            this.AlRezLabel.TabIndex = 11;
            this.AlRezLabel.Text = "label6";
            // 
            // buttonDivisionByHalf
            // 
            this.buttonDivisionByHalf.Location = new System.Drawing.Point(134, 316);
            this.buttonDivisionByHalf.Name = "buttonDivisionByHalf";
            this.buttonDivisionByHalf.Size = new System.Drawing.Size(121, 26);
            this.buttonDivisionByHalf.TabIndex = 6;
            this.buttonDivisionByHalf.Text = "Уточнить корни";
            this.buttonDivisionByHalf.UseVisualStyleBackColor = true;
            this.buttonDivisionByHalf.Click += new System.EventHandler(this.buttonDivisionByHalf_Click);
            // 
            // buttonNewton
            // 
            this.buttonNewton.Location = new System.Drawing.Point(131, 316);
            this.buttonNewton.Name = "buttonNewton";
            this.buttonNewton.Size = new System.Drawing.Size(121, 26);
            this.buttonNewton.TabIndex = 7;
            this.buttonNewton.Text = "Уточнить корни";
            this.buttonNewton.UseVisualStyleBackColor = true;
            this.buttonNewton.Click += new System.EventHandler(this.buttonNewton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Затраченное время:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Затраченное время:";
            // 
            // labelDivisionByHalf
            // 
            this.labelDivisionByHalf.AutoSize = true;
            this.labelDivisionByHalf.Location = new System.Drawing.Point(206, 291);
            this.labelDivisionByHalf.Name = "labelDivisionByHalf";
            this.labelDivisionByHalf.Size = new System.Drawing.Size(35, 13);
            this.labelDivisionByHalf.TabIndex = 8;
            this.labelDivisionByHalf.Text = "label8";
            // 
            // labelTimeNewton
            // 
            this.labelTimeNewton.AutoSize = true;
            this.labelTimeNewton.Location = new System.Drawing.Point(217, 291);
            this.labelTimeNewton.Name = "labelTimeNewton";
            this.labelTimeNewton.Size = new System.Drawing.Size(35, 13);
            this.labelTimeNewton.TabIndex = 9;
            this.labelTimeNewton.Text = "label9";
            // 
            // ColumnNumOfIter
            // 
            this.ColumnNumOfIter.Frozen = true;
            this.ColumnNumOfIter.HeaderText = "Номер итерации";
            this.ColumnNumOfIter.Name = "ColumnNumOfIter";
            this.ColumnNumOfIter.ReadOnly = true;
            // 
            // ColumnValue
            // 
            this.ColumnValue.Frozen = true;
            this.ColumnValue.HeaderText = "Значения промежутка";
            this.ColumnValue.Name = "ColumnValue";
            this.ColumnValue.ReadOnly = true;
            this.ColumnValue.Width = 280;
            // 
            // dataGridViewNewton
            // 
            this.dataGridViewNewton.AllowUserToAddRows = false;
            this.dataGridViewNewton.AllowUserToDeleteRows = false;
            this.dataGridViewNewton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNewton.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewNewton.Location = new System.Drawing.Point(3, 41);
            this.dataGridViewNewton.Name = "dataGridViewNewton";
            this.dataGridViewNewton.ReadOnly = true;
            this.dataGridViewNewton.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewNewton.Size = new System.Drawing.Size(376, 238);
            this.dataGridViewNewton.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер итерации";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Значения промежутка";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 280;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AlRezLabel);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownEnd);
            this.Controls.Add(this.numericUpDownStart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "labVA3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDivisionByHalf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataDivisionByHalf;
        private System.Windows.Forms.NumericUpDown numericUpDownStart;
        private System.Windows.Forms.NumericUpDown numericUpDownEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label AlRezLabel;
        private System.Windows.Forms.Button buttonDivisionByHalf;
        private System.Windows.Forms.Button buttonNewton;
        private System.Windows.Forms.Label labelDivisionByHalf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTimeNewton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumOfIter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValue;
        private System.Windows.Forms.DataGridView dataGridViewNewton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

