
namespace libraryApp
{
    partial class regForm
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
            this.regLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.regButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regLabel
            // 
            this.regLabel.Location = new System.Drawing.Point(58, 69);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(341, 58);
            this.regLabel.TabIndex = 0;
            this.regLabel.Text = "Регистрация";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(96, 119);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(450, 50);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Enter += new System.EventHandler(this.nameTextBox_Enter);
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(96, 186);
            this.surnameTextBox.Multiline = true;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(450, 50);
            this.surnameTextBox.TabIndex = 2;
            this.surnameTextBox.Enter += new System.EventHandler(this.surnameTextBox_Enter);
            this.surnameTextBox.Leave += new System.EventHandler(this.surnameTextBox_Leave);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(96, 252);
            this.loginTextBox.Multiline = true;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(450, 50);
            this.loginTextBox.TabIndex = 3;
            this.loginTextBox.Enter += new System.EventHandler(this.loginTextBox_Enter);
            this.loginTextBox.Leave += new System.EventHandler(this.loginTextBox_Leave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(96, 323);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(450, 50);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // regButton
            // 
            this.regButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regButton.Location = new System.Drawing.Point(195, 404);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(75, 23);
            this.regButton.TabIndex = 5;
            this.regButton.Text = "Зарегестрироваться";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // regForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 502);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.regLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "regForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Библиотекарь";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label regLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button regButton;
    }
}