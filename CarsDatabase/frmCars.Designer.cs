namespace CarsDatabase
{
    partial class frmCars
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUpdate = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            btnFirst = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            btnLast = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            checkBox1 = new CheckBox();
            frmVehicleRegLabel = new TextBox();
            frmMake = new TextBox();
            frmEngineSize = new TextBox();
            frmDateRegistered = new TextBox();
            textBox5 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1499, 212);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(225, 69);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "&Update\r\n";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1499, 298);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(225, 69);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1499, 383);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(225, 69);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1499, 469);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(225, 69);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1499, 555);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(225, 69);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1499, 639);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(225, 69);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            btnFirst.Location = new Point(188, 718);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(225, 69);
            btnFirst.TabIndex = 6;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(419, 718);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(225, 69);
            btnPrevious.TabIndex = 7;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(913, 718);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(225, 69);
            btnNext.TabIndex = 8;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            btnLast.Location = new Point(1144, 718);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(225, 69);
            btnLast.TabIndex = 9;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 222);
            label1.Name = "label1";
            label1.Size = new Size(474, 48);
            label1.TabIndex = 10;
            label1.Text = "Vehicle Registration Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 285);
            label2.Name = "label2";
            label2.Size = new Size(107, 48);
            label2.TabIndex = 11;
            label2.Text = "Make";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 351);
            label3.Name = "label3";
            label3.Size = new Size(200, 48);
            label3.TabIndex = 12;
            label3.Text = "Engine Size";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(169, 411);
            label4.Name = "label4";
            label4.Size = new Size(273, 48);
            label4.TabIndex = 13;
            label4.Text = "Date Registered";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(169, 475);
            label5.Name = "label5";
            label5.Size = new Size(250, 48);
            label5.TabIndex = 14;
            label5.Text = "Rental Per Day";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(169, 541);
            label6.Name = "label6";
            label6.Size = new Size(162, 48);
            label6.TabIndex = 15;
            label6.Text = "Available";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(724, 167);
            label7.Name = "label7";
            label7.Size = new Size(551, 48);
            label7.TabIndex = 16;
            label7.Text = "You are currently editing a record";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Magneto", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(605, 58);
            label8.Name = "label8";
            label8.Size = new Size(662, 78);
            label8.TabIndex = 17;
            label8.Text = "Bowman Car Hire";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(706, 546);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(42, 41);
            checkBox1.TabIndex = 18;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmVehicleRegLabel
            // 
            frmVehicleRegLabel.Location = new Point(706, 226);
            frmVehicleRegLabel.Name = "frmVehicleRegLabel";
            frmVehicleRegLabel.Size = new Size(300, 55);
            frmVehicleRegLabel.TabIndex = 19;
            // 
            // frmMake
            // 
            frmMake.Location = new Point(706, 285);
            frmMake.Name = "frmMake";
            frmMake.Size = new Size(569, 55);
            frmMake.TabIndex = 20;
            // 
            // frmEngineSize
            // 
            frmEngineSize.Location = new Point(706, 351);
            frmEngineSize.Name = "frmEngineSize";
            frmEngineSize.Size = new Size(300, 55);
            frmEngineSize.TabIndex = 21;
            // 
            // frmDateRegistered
            // 
            frmDateRegistered.Location = new Point(706, 412);
            frmDateRegistered.Name = "frmDateRegistered";
            frmDateRegistered.Size = new Size(300, 55);
            frmDateRegistered.TabIndex = 22;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(650, 725);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(257, 55);
            textBox5.TabIndex = 23;
            textBox5.Text = "1 of 15";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(707, 477);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(360, 55);
            numericUpDown1.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(155, 160);
            panel1.Name = "panel1";
            panel1.Size = new Size(1149, 464);
            panel1.TabIndex = 25;
            // 
            // frmCars
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1814, 855);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox5);
            Controls.Add(frmDateRegistered);
            Controls.Add(frmEngineSize);
            Controls.Add(frmMake);
            Controls.Add(frmVehicleRegLabel);
            Controls.Add(checkBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnFirst);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(panel1);
            Name = "frmCars";
            ShowIcon = false;
            Text = "Task A";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnCancel;
        private Button btnExit;
        private Button btnFirst;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnLast;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private CheckBox checkBox1;
        private TextBox frmVehicleRegLabel;
        private TextBox frmMake;
        private TextBox frmEngineSize;
        private TextBox frmDateRegistered;
        private TextBox textBox5;
        private NumericUpDown numericUpDown1;
        private Panel panel1;
    }
}