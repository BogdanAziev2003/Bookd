
namespace libraryApp
{
    partial class loginForm
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
            this.authLabel = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.registerLabelNav = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authLabel
            // 
            this.authLabel.Font = new System.Drawing.Font("Arial", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authLabel.Location = new System.Drawing.Point(28, 18);
            this.authLabel.Name = "authLabel";
            this.authLabel.Size = new System.Drawing.Size(281, 66);
            this.authLabel.TabIndex = 0;
            this.authLabel.Text = "Авторизация";
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logTextBox.Location = new System.Drawing.Point(162, 122);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(450, 50);
            this.logTextBox.TabIndex = 1;
            this.logTextBox.Enter += new System.EventHandler(this.logTextBox_Enter);
            this.logTextBox.Leave += new System.EventHandler(this.logTextBox_Leave);
            // 
            // passTextBox
            // 
            this.passTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passTextBox.Location = new System.Drawing.Point(162, 192);
            this.passTextBox.Multiline = true;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(442, 47);
            this.passTextBox.TabIndex = 2;
            this.passTextBox.Enter += new System.EventHandler(this.passTextBox_Enter);
            this.passTextBox.Leave += new System.EventHandler(this.passTextBox_Leave);
            // 
            // enterButton
            // 
            this.enterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Location = new System.Drawing.Point(225, 307);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(120, 40);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // registerLabelNav
            // 
            this.registerLabelNav.AutoSize = true;
            this.registerLabelNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerLabelNav.Location = new System.Drawing.Point(390, 307);
            this.registerLabelNav.Name = "registerLabelNav";
            this.registerLabelNav.Size = new System.Drawing.Size(72, 13);
            this.registerLabelNav.TabIndex = 4;
            this.registerLabelNav.Text = "Регистрация";
            this.registerLabelNav.Click += new System.EventHandler(this.registerLabelNav_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 426);
            this.Controls.Add(this.registerLabelNav);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.authLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.Text = "Библиотекарь";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label authLabel;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label registerLabelNav;
    }
}