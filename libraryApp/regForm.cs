using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryApp
{


    public partial class regForm : Form
    {
        Font myFont;
        Font tbFont;
        Font btFont;
        bool flag = true;
        public regForm()
        {
            InitializeComponent();
            FormSets();
            LoadFont();
        }

        public void FormSets() 
        {
            this.BackColor = Color.White;
            this.Width = 750;
            
            regLabel.Location = new Point(30, 20);

            nameTextBox.Left = 150;
            surnameTextBox.Left = 150;
            loginTextBox.Left = 150;
            passwordTextBox.Left = 150;
            nameTextBox.Text = "Имя";
            surnameTextBox.Text = "Фамилия";
            loginTextBox.Text = "Логин";
            passwordTextBox.Text = "Пароль";
            nameTextBox.ForeColor = Color.Gray;
            surnameTextBox.ForeColor = Color.Gray;
            loginTextBox.ForeColor = Color.Gray;
            passwordTextBox.ForeColor = Color.Gray;

        }

        public void LoadFont() 
        {

            PrivateFontCollection custom_font = new PrivateFontCollection();
            custom_font.AddFontFile("font.ttf");

            myFont = new Font(custom_font.Families[0], 25);
            tbFont = new Font(custom_font.Families[0], 18);
            btFont = new Font(custom_font.Families[0], 15);

            regLabel.Font = myFont;
            nameTextBox.Font = tbFont;
            surnameTextBox.Font = tbFont;
            loginTextBox.Font = tbFont;
            passwordTextBox.Font = tbFont;

            regButton.ForeColor = Color.White;
            regButton.BackColor = Color.FromArgb(243, 165, 5);
            regButton.Font = btFont;
            regButton.Size = new Size(250, 40);
            regButton.Top = this.Height - 125;
            regButton.Left = 250;
        }

        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "Имя" || nameTextBox.Text == "Введите имя")
            {
                nameTextBox.Text = "";
                nameTextBox.ForeColor = Color.Black;
            }
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                nameTextBox.Text = "Имя";
                nameTextBox.ForeColor = Color.Gray;
            }
        }

        private void surnameTextBox_Enter(object sender, EventArgs e)
        {
            if (surnameTextBox.Text == "Фамилия" || surnameTextBox.Text == "Введите фамилию")
            {
                surnameTextBox.Text = "";
                surnameTextBox.ForeColor = Color.Black;
            }
        }

        private void surnameTextBox_Leave(object sender, EventArgs e)
        {
            if (surnameTextBox.Text == "")
            {
                surnameTextBox.Text = "Фамилия";
                surnameTextBox.ForeColor = Color.Gray;
            }
        }

        private void loginTextBox_Enter(object sender, EventArgs e)
        {
            if (loginTextBox.Text == "Логин" || loginTextBox.Text == "Логин уже существует" || loginTextBox.Text == "Введите логин")
            {
                loginTextBox.Text = "";
                loginTextBox.ForeColor = Color.Black;
            }
        }

        private void loginTextBox_Leave(object sender, EventArgs e)
        {
            if (loginTextBox.Text == "")
            {
                loginTextBox.Text = "Логин";
                loginTextBox.ForeColor = Color.Gray;
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Пароль" || passwordTextBox.Text == "Введите пароль")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.Black;
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "Пароль";
                passwordTextBox.ForeColor = Color.Gray;
            }
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            flag = true;

            if (loginTextBox.Text == "Логин" || loginTextBox.Text == "Введите логин")
            {
                loginTextBox.Text = "Введите логин";
                loginTextBox.ForeColor = Color.Red;
                flag = false;
            }
            else if (isUserExists())
            {
                loginTextBox.Text = "Логин уже существует";
                loginTextBox.ForeColor = Color.Red;
                flag = false;
            }
            if (passwordTextBox.Text == "Пароль" || passwordTextBox.Text == "Введите пароль")
            {
                passwordTextBox.Text = "Введите пароль";
                passwordTextBox.ForeColor = Color.Red;
                flag = false;
            }
            if (nameTextBox.Text == "Имя" || nameTextBox.Text == "Введите имя")
            {
                nameTextBox.Text = "Введите имя";
                nameTextBox.ForeColor = Color.Red;
                flag = false;
            }
            if (surnameTextBox.Text == "Фамилия" || surnameTextBox.Text == "Введите фамилию")
            {
                surnameTextBox.Text = "Введите фамилию";
                surnameTextBox.ForeColor = Color.Red;
                flag = false;
            }
            if (flag)
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`login`, `password`, `name`, `surname`) VALUES (@login, @password, @name, @surname)", db.getConnection());
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginTextBox.Text;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordTextBox.Text;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameTextBox.Text;
                command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surnameTextBox.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("All good");
                }
                else
                {
                    MessageBox.Show("Error");

                }

                db.closeConnection();
            }
        }

        private bool isUserExists() 
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loginTextBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            return false;
        }

    }
}
