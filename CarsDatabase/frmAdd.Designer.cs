namespace CarsDatabase
{
    partial class frmAdd
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
            frmVehicleRegNumberLabel = new Label();
            frmMakeLabel = new Label();
            frmEngineSizeLabel = new Label();
            frmDateRegisteredLabel = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            checkBox1 = new CheckBox();
            btnClear = new Button();
            btnAdd = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // frmVehicleRegNumberLabel
            // 
            frmVehicleRegNumberLabel.AutoSize = true;
            frmVehicleRegNumberLabel.Location = new Point(94, 146);
            frmVehicleRegNumberLabel.Name = "frmVehicleRegNumberLabel";
            frmVehicleRegNumberLabel.Size = new Size(474, 48);
            frmVehicleRegNumberLabel.TabIndex = 0;
            frmVehicleRegNumberLabel.Text = "Vehicle Registration Number";
            // 
            // frmMakeLabel
            // 
            frmMakeLabel.AutoSize = true;
            frmMakeLabel.Location = new Point(94, 218);
            frmMakeLabel.Name = "frmMakeLabel";
            frmMakeLabel.Size = new Size(107, 48);
            frmMakeLabel.TabIndex = 1;
            frmMakeLabel.Text = "Make";
            // 
            // frmEngineSizeLabel
            // 
            frmEngineSizeLabel.AutoSize = true;
            frmEngineSizeLabel.Location = new Point(94, 289);
            frmEngineSizeLabel.Name = "frmEngineSizeLabel";
            frmEngineSizeLabel.Size = new Size(200, 48);
            frmEngineSizeLabel.TabIndex = 2;
            frmEngineSizeLabel.Text = "Engine Size";
            // 
            // frmDateRegisteredLabel
            // 
            frmDateRegisteredLabel.AutoSize = true;
            frmDateRegisteredLabel.Location = new Point(94, 358);
            frmDateRegisteredLabel.Name = "frmDateRegisteredLabel";
            frmDateRegisteredLabel.Size = new Size(273, 48);
            frmDateRegisteredLabel.TabIndex = 3;
            frmDateRegisteredLabel.Text = "Date Registered";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 434);
            label5.Name = "label5";
            label5.Size = new Size(250, 48);
            label5.TabIndex = 4;
            label5.Text = "Rental Per Day";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 506);
            label6.Name = "label6";
            label6.Size = new Size(162, 48);
            label6.TabIndex = 5;
            label6.Text = "Available";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(615, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 55);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(615, 218);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(458, 55);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(615, 289);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 55);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(615, 358);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(300, 55);
            textBox4.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(615, 434);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(360, 55);
            numericUpDown1.TabIndex = 10;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(615, 506);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(42, 41);
            checkBox1.TabIndex = 11;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(94, 630);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(225, 69);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(422, 630);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(225, 69);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(786, 630);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(225, 69);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // frmAdd
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 839);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(btnClear);
            Controls.Add(checkBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(frmDateRegisteredLabel);
            Controls.Add(frmEngineSizeLabel);
            Controls.Add(frmMakeLabel);
            Controls.Add(frmVehicleRegNumberLabel);
            Name = "frmAdd";
            ShowIcon = false;
            Text = "frmAdd";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label frmVehicleRegNumberLabel;
        private Label frmMakeLabel;
        private Label frmEngineSizeLabel;
        private Label frmDateRegisteredLabel;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox1;
        private Button btnClear;
        private Button btnAdd;
        private Button btnClose;
    }
}