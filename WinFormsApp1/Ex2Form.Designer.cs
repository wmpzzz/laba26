namespace laba
{
    partial class Ex2Form
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
            FirstNumberTextBox = new TextBox();
            SecondNumberTextBox = new TextBox();
            FirstNumberLabel = new Label();
            SecondNumberLabel = new Label();
            AddRadioButton = new RadioButton();
            SubRadioButton = new RadioButton();
            MultiplyRadioButton = new RadioButton();
            DivineRadioButton = new RadioButton();
            CalculationButton = new Button();
            CalculateLabel = new Label();
            SuspendLayout();
            // 
            // FirstNumberTextBox
            // 
            FirstNumberTextBox.Location = new Point(133, 66);
            FirstNumberTextBox.Name = "FirstNumberTextBox";
            FirstNumberTextBox.Size = new Size(500, 23);
            FirstNumberTextBox.TabIndex = 0;
            // 
            // SecondNumberTextBox
            // 
            SecondNumberTextBox.Location = new Point(138, 208);
            SecondNumberTextBox.Name = "SecondNumberTextBox";
            SecondNumberTextBox.Size = new Size(495, 23);
            SecondNumberTextBox.TabIndex = 1;
            // 
            // FirstNumberLabel
            // 
            FirstNumberLabel.AutoSize = true;
            FirstNumberLabel.Location = new Point(145, 29);
            FirstNumberLabel.Name = "FirstNumberLabel";
            FirstNumberLabel.Size = new Size(85, 15);
            FirstNumberLabel.TabIndex = 2;
            FirstNumberLabel.Text = "Первое число";
            // 
            // SecondNumberLabel
            // 
            SecondNumberLabel.AutoSize = true;
            SecondNumberLabel.Location = new Point(151, 184);
            SecondNumberLabel.Name = "SecondNumberLabel";
            SecondNumberLabel.Size = new Size(83, 15);
            SecondNumberLabel.TabIndex = 3;
            SecondNumberLabel.Text = "Второе число";
            // 
            // AddRadioButton
            // 
            AddRadioButton.AutoSize = true;
            AddRadioButton.Location = new Point(136, 131);
            AddRadioButton.Name = "AddRadioButton";
            AddRadioButton.Size = new Size(33, 19);
            AddRadioButton.TabIndex = 4;
            AddRadioButton.TabStop = true;
            AddRadioButton.Text = "+";
            AddRadioButton.UseVisualStyleBackColor = true;
            AddRadioButton.CheckedChanged += AddRadioButton_CheckedChanged;
            // 
            // SubRadioButton
            // 
            SubRadioButton.AutoSize = true;
            SubRadioButton.Location = new Point(296, 131);
            SubRadioButton.Name = "SubRadioButton";
            SubRadioButton.Size = new Size(30, 19);
            SubRadioButton.TabIndex = 5;
            SubRadioButton.TabStop = true;
            SubRadioButton.Text = "-";
            SubRadioButton.UseVisualStyleBackColor = true;
            SubRadioButton.CheckedChanged += SubRadioButton_CheckedChanged;
            // 
            // MultiplyRadioButton
            // 
            MultiplyRadioButton.AutoSize = true;
            MultiplyRadioButton.Location = new Point(460, 131);
            MultiplyRadioButton.Name = "MultiplyRadioButton";
            MultiplyRadioButton.Size = new Size(30, 19);
            MultiplyRadioButton.TabIndex = 6;
            MultiplyRadioButton.TabStop = true;
            MultiplyRadioButton.Text = "*";
            MultiplyRadioButton.UseVisualStyleBackColor = true;
            MultiplyRadioButton.CheckedChanged += MultiplyRadioButton_CheckedChanged;
            // 
            // DivineRadioButton
            // 
            DivineRadioButton.AutoSize = true;
            DivineRadioButton.Location = new Point(616, 131);
            DivineRadioButton.Name = "DivineRadioButton";
            DivineRadioButton.Size = new Size(30, 19);
            DivineRadioButton.TabIndex = 7;
            DivineRadioButton.TabStop = true;
            DivineRadioButton.Text = "/";
            DivineRadioButton.UseVisualStyleBackColor = true;
            DivineRadioButton.CheckedChanged += DivineRadioButton_CheckedChanged;
            // 
            // CalculationButton
            // 
            CalculationButton.Location = new Point(487, 366);
            CalculationButton.Name = "CalculationButton";
            CalculationButton.Size = new Size(158, 50);
            CalculationButton.TabIndex = 8;
            CalculationButton.Text = "Вычислить";
            CalculationButton.UseVisualStyleBackColor = true;
            CalculationButton.Click += CalculationButton_Click;
            // 
            // CalculateLabel
            // 
            CalculateLabel.AutoSize = true;
            CalculateLabel.Location = new Point(138, 292);
            CalculateLabel.Name = "CalculateLabel";
            CalculateLabel.Size = new Size(63, 15);
            CalculateLabel.TabIndex = 9;
            CalculateLabel.Text = "Результат:";
            // 
            // Ex2Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CalculateLabel);
            Controls.Add(CalculationButton);
            Controls.Add(DivineRadioButton);
            Controls.Add(MultiplyRadioButton);
            Controls.Add(SubRadioButton);
            Controls.Add(AddRadioButton);
            Controls.Add(SecondNumberLabel);
            Controls.Add(FirstNumberLabel);
            Controls.Add(SecondNumberTextBox);
            Controls.Add(FirstNumberTextBox);
            Name = "Ex2Form";
            Text = "Задание 2";
            Load += Ex2Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FirstNumberTextBox;
        private TextBox SecondNumberTextBox;
        private Label FirstNumberLabel;
        private Label SecondNumberLabel;
        private RadioButton AddRadioButton;
        private RadioButton SubRadioButton;
        private RadioButton MultiplyRadioButton;
        private RadioButton DivineRadioButton;
        private Button CalculationButton;
        private Label CalculateLabel;
    }
}