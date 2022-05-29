
namespace libraryApp
{
    partial class appForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.reservBtn = new System.Windows.Forms.Button();
            this.surNameTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.tookRadio = new System.Windows.Forms.RadioButton();
            this.reservRadio = new System.Windows.Forms.RadioButton();
            this.loginLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.topLabel = new System.Windows.Forms.Label();
            this.DG = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reservBtn);
            this.panel1.Controls.Add(this.surNameTextBox);
            this.panel1.Controls.Add(this.loginTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.tookRadio);
            this.panel1.Controls.Add(this.reservRadio);
            this.panel1.Controls.Add(this.loginLabel);
            this.panel1.Controls.Add(this.surnameLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.topLabel);
            this.panel1.Location = new System.Drawing.Point(560, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 451);
            this.panel1.TabIndex = 0;
            // 
            // reservBtn
            // 
            this.reservBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reservBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reservBtn.Location = new System.Drawing.Point(36, 395);
            this.reservBtn.Name = "reservBtn";
            this.reservBtn.Size = new System.Drawing.Size(177, 30);
            this.reservBtn.TabIndex = 11;
            this.reservBtn.Text = "Забронировать";
            this.reservBtn.UseVisualStyleBackColor = false;
            this.reservBtn.Click += new System.EventHandler(this.reservBtn_Click);
            // 
            // surNameTextBox
            // 
            this.surNameTextBox.Enabled = false;
            this.surNameTextBox.Location = new System.Drawing.Point(118, 94);
            this.surNameTextBox.Name = "surNameTextBox";
            this.surNameTextBox.Size = new System.Drawing.Size(110, 20);
            this.surNameTextBox.TabIndex = 10;
            this.surNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginTextBox
            // 
            this.loginTextBox.AcceptsReturn = true;
            this.loginTextBox.AcceptsTab = true;
            this.loginTextBox.AllowDrop = true;
            this.loginTextBox.Enabled = false;
            this.loginTextBox.HideSelection = false;
            this.loginTextBox.Location = new System.Drawing.Point(118, 124);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(110, 20);
            this.loginTextBox.TabIndex = 9;
            this.loginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(118, 65);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(110, 20);
            this.nameTextBox.TabIndex = 8;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tookRadio
            // 
            this.tookRadio.AllowDrop = true;
            this.tookRadio.AutoCheck = false;
            this.tookRadio.AutoSize = true;
            this.tookRadio.Location = new System.Drawing.Point(13, 227);
            this.tookRadio.Name = "tookRadio";
            this.tookRadio.Size = new System.Drawing.Size(50, 17);
            this.tookRadio.TabIndex = 7;
            this.tookRadio.Text = "Взял";
            this.tookRadio.UseVisualStyleBackColor = true;
            // 
            // reservRadio
            // 
            this.reservRadio.AllowDrop = true;
            this.reservRadio.AutoCheck = false;
            this.reservRadio.AutoSize = true;
            this.reservRadio.Location = new System.Drawing.Point(13, 203);
            this.reservRadio.Name = "reservRadio";
            this.reservRadio.Size = new System.Drawing.Size(98, 17);
            this.reservRadio.TabIndex = 6;
            this.reservRadio.Text = "Забронировал";
            this.reservRadio.UseVisualStyleBackColor = true;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(10, 124);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(38, 13);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Логин";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(7, 94);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(56, 13);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Фамилия";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 65);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Имя";
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Location = new System.Drawing.Point(50, 14);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(72, 13);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "Мой Аккаунт";
            // 
            // DG
            // 
            this.DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.DG.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.author,
            this.year,
            this.description});
            this.DG.Location = new System.Drawing.Point(2, 79);
            this.DG.Name = "DG";
            this.DG.Size = new System.Drawing.Size(559, 371);
            this.DG.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "№";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Название";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // author
            // 
            this.author.HeaderText = "Автор";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // year
            // 
            this.year.HeaderText = "Год написания";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            // 
            // description
            // 
            this.description.HeaderText = "Описание";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 78);
            this.panel2.TabIndex = 2;
            // 
            // appForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DG);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "appForm";
            this.ShowIcon = false;
            this.Text = "Библиотекарь";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox surNameTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.RadioButton reservRadio;
        private System.Windows.Forms.RadioButton tookRadio;
        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button reservBtn;
    }
}