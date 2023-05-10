namespace CarsDatabase
{
    partial class frmSearch
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
            frmFieldLabel = new Label();
            frmOperatorLabel = new Label();
            frmValueLabel = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnRun = new Button();
            btnClose = new Button();
            textBox1 = new TextBox();
            frmDataGrid = new DataGridView();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)frmDataGrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // frmFieldLabel
            // 
            frmFieldLabel.AutoSize = true;
            frmFieldLabel.Location = new Point(62, 75);
            frmFieldLabel.Name = "frmFieldLabel";
            frmFieldLabel.Size = new Size(96, 48);
            frmFieldLabel.TabIndex = 0;
            frmFieldLabel.Text = "Field";
            // 
            // frmOperatorLabel
            // 
            frmOperatorLabel.AutoSize = true;
            frmOperatorLabel.Location = new Point(449, 75);
            frmOperatorLabel.Name = "frmOperatorLabel";
            frmOperatorLabel.Size = new Size(164, 48);
            frmOperatorLabel.TabIndex = 1;
            frmOperatorLabel.Text = "Operator";
            // 
            // frmValueLabel
            // 
            frmValueLabel.AutoSize = true;
            frmValueLabel.Location = new Point(784, 165);
            frmValueLabel.Name = "frmValueLabel";
            frmValueLabel.Size = new Size(105, 48);
            frmValueLabel.TabIndex = 2;
            frmValueLabel.Text = "Value";
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRun.Location = new Point(1483, 92);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(225, 143);
            btnRun.TabIndex = 3;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(1483, 241);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(225, 151);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(784, 282);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(391, 55);
            textBox1.TabIndex = 5;
            // 
            // frmDataGrid
            // 
            frmDataGrid.BackgroundColor = SystemColors.AppWorkspace;
            frmDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            frmDataGrid.Location = new Point(63, 412);
            frmDataGrid.Name = "frmDataGrid";
            frmDataGrid.RowHeadersWidth = 123;
            frmDataGrid.RowTemplate.Height = 57;
            frmDataGrid.Size = new Size(1566, 450);
            frmDataGrid.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(frmFieldLabel);
            panel1.Controls.Add(frmOperatorLabel);
            panel1.Location = new Point(63, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(1399, 300);
            panel1.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(62, 189);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(327, 56);
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(449, 189);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(140, 56);
            comboBox2.TabIndex = 2;
            // 
            // frmSearch
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1845, 917);
            Controls.Add(frmDataGrid);
            Controls.Add(textBox1);
            Controls.Add(btnClose);
            Controls.Add(btnRun);
            Controls.Add(frmValueLabel);
            Controls.Add(panel1);
            Name = "frmSearch";
            ShowIcon = false;
            Text = "frmSearch";
            ((System.ComponentModel.ISupportInitialize)frmDataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label frmFieldLabel;
        private Label frmOperatorLabel;
        private Label frmValueLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnRun;
        private Button btnClose;
        private TextBox textBox1;
        private DataGridView frmDataGrid;
        private Panel panel1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}