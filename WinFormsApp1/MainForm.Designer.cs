namespace WinFormsApp1
{
    partial class MainForm
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
            ToFirstExButton = new Button();
            ToSecondExButton = new Button();
            SuspendLayout();
            // 
            // ToFirstExButton
            // 
            ToFirstExButton.Location = new Point(199, 112);
            ToFirstExButton.Name = "ToFirstExButton";
            ToFirstExButton.Size = new Size(169, 55);
            ToFirstExButton.TabIndex = 0;
            ToFirstExButton.Text = "Задание 1";
            ToFirstExButton.UseVisualStyleBackColor = true;
            ToFirstExButton.Click += ToFirstExButton_Click;
            // 
            // ToSecondExButton
            // 
            ToSecondExButton.Location = new Point(199, 186);
            ToSecondExButton.Name = "ToSecondExButton";
            ToSecondExButton.Size = new Size(169, 55);
            ToSecondExButton.TabIndex = 1;
            ToSecondExButton.Text = "Задание 2";
            ToSecondExButton.UseVisualStyleBackColor = true;
            ToSecondExButton.Click += ToSecondExButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 434);
            Controls.Add(ToSecondExButton);
            Controls.Add(ToFirstExButton);
            Name = "MainForm";
            Text = "Лабораторная работа";
            ResumeLayout(false);
        }

        #endregion

        private Button ToFirstExButton;
        private Button ToSecondExButton;
    }
}
