namespace Laba
{
    partial class Ex1Form
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
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            PasswordCheckBox = new CheckBox();
            AuthButton = new Button();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(159, 85);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(322, 23);
            LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(159, 176);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(322, 23);
            PasswordTextBox.TabIndex = 1;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(173, 55);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(41, 15);
            LoginLabel.TabIndex = 2;
            LoginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(175, 143);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(49, 15);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Пароль";
            // 
            // PasswordCheckBox
            // 
            PasswordCheckBox.AutoSize = true;
            PasswordCheckBox.Location = new Point(165, 230);
            PasswordCheckBox.Name = "PasswordCheckBox";
            PasswordCheckBox.Size = new Size(119, 19);
            PasswordCheckBox.TabIndex = 4;
            PasswordCheckBox.Text = "Показать пароль";
            PasswordCheckBox.UseVisualStyleBackColor = true;
            PasswordCheckBox.CheckedChanged += PasswordCheckBox_CheckedChanged;
            // 
            // AuthButton
            // 
            AuthButton.Location = new Point(394, 273);
            AuthButton.Name = "AuthButton";
            AuthButton.Size = new Size(117, 47);
            AuthButton.TabIndex = 5;
            AuthButton.Text = "Авторизоваться";
            AuthButton.UseVisualStyleBackColor = true;
            // 
            // Ex1Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 366);
            Controls.Add(AuthButton);
            Controls.Add(PasswordCheckBox);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Name = "Ex1Form";
            Text = "Задание 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Label LoginLabel;
        private Label PasswordLabel;
        private CheckBox PasswordCheckBox;
        private Button AuthButton;
    }
}