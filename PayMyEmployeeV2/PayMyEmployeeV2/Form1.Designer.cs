namespace PayMyEmployeeV2
{
    partial class Form1
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
            CalcButton = new Button();
            ClearButton = new Button();
            NameBox = new TextBox();
            Surname = new TextBox();
            EmpID = new TextBox();
            HoursWorked = new TextBox();
            HourlyRate = new TextBox();
            DisplayBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // CalcButton
            // 
            CalcButton.BackColor = SystemColors.ActiveCaption;
            CalcButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            CalcButton.Location = new Point(156, 301);
            CalcButton.Name = "CalcButton";
            CalcButton.Size = new Size(173, 42);
            CalcButton.TabIndex = 0;
            CalcButton.Text = "Calculate Pay";
            CalcButton.UseVisualStyleBackColor = false;
            CalcButton.Click += CalcButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = SystemColors.ActiveCaption;
            ClearButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            ClearButton.Location = new Point(383, 301);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(174, 42);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(156, 47);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(159, 23);
            NameBox.TabIndex = 2;
            // 
            // Surname
            // 
            Surname.Location = new Point(156, 89);
            Surname.Name = "Surname";
            Surname.Size = new Size(159, 23);
            Surname.TabIndex = 3;
            // 
            // EmpID
            // 
            EmpID.Location = new Point(156, 136);
            EmpID.Name = "EmpID";
            EmpID.Size = new Size(159, 23);
            EmpID.TabIndex = 4;
            // 
            // HoursWorked
            // 
            HoursWorked.Location = new Point(156, 183);
            HoursWorked.Name = "HoursWorked";
            HoursWorked.Size = new Size(159, 23);
            HoursWorked.TabIndex = 5;
            // 
            // HourlyRate
            // 
            HourlyRate.Location = new Point(156, 230);
            HourlyRate.Name = "HourlyRate";
            HourlyRate.Size = new Size(159, 23);
            HourlyRate.TabIndex = 6;
            // 
            // DisplayBox
            // 
            DisplayBox.Location = new Point(337, 47);
            DisplayBox.Multiline = true;
            DisplayBox.Name = "DisplayBox";
            DisplayBox.ReadOnly = true;
            DisplayBox.Size = new Size(220, 206);
            DisplayBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(97, 50);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 8;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(82, 92);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 9;
            label2.Text = "Surname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(63, 139);
            label3.Name = "label3";
            label3.Size = new Size(89, 19);
            label3.TabIndex = 10;
            label3.Text = "Employee ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(53, 186);
            label4.Name = "label4";
            label4.Size = new Size(100, 19);
            label4.TabIndex = 11;
            label4.Text = "Hours Worked:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = SystemColors.HighlightText;
            label5.Location = new Point(67, 233);
            label5.Name = "label5";
            label5.Size = new Size(84, 19);
            label5.TabIndex = 12;
            label5.Text = "Hourly Rate:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.NumBackground;
            ClientSize = new Size(632, 432);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DisplayBox);
            Controls.Add(HourlyRate);
            Controls.Add(HoursWorked);
            Controls.Add(EmpID);
            Controls.Add(Surname);
            Controls.Add(NameBox);
            Controls.Add(ClearButton);
            Controls.Add(CalcButton);
            Name = "Form1";
            Text = "PayMyEmployeeV2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CalcButton;
        private Button ClearButton;
        private TextBox NameBox;
        private TextBox Surname;
        private TextBox EmpID;
        private TextBox HoursWorked;
        private TextBox HourlyRate;
        private TextBox DisplayBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
