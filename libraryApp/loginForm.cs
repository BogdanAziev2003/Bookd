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
    public partial class loginForm : Form
    {
        static public string login;
        public Font myFont;
        Font tbFont;
        Font btFont;

        public loginForm()
        {
            InitializeComponent();
            LoadFont();
            FormSets();
        }

        private void LoadFont() 
        {
            PrivateFontCollection custom_font = new PrivateFontCollection();
            custom_font.AddFontFile("font.ttf");

            myFont = new Font(custom_font.Families[0], 25);
            tbFont = new Font(custom_font.Families[0], 18);
            btFont = new Font(custom_font.Families[0], 15);

            authLabel.Font = myFont;
            logTextBox.Font = tbFont;
            passTextBox.Font = tbFont;
            enterButton.Font = btFont;
            registerLabelNav.Font = btFont;

        }

        private void FormSets() 
        {
            this.BackColor = Color.White;
            this.Width = 750;

            logTextBox.Size = new Size(450, 50);
            passTextBox.Size = new Size(450, 50);

            logTextBox.Left = 150;
            passTextBox.Left = 150;

            logTextBox.Text = "Логин";
            passTextBox.Text = "Пароль";
            logTextBox.ForeColor = Color.Gray;
            passTextBox.ForeColor = Color.Gray;

            enterButton.ForeColor = Color.White;
            enterButton.BackColor = Color.FromArgb(243, 165, 5);

            registerLabelNav.ForeColor = Color.FromArgb(243, 165, 5);

            enterButton.Top = this.Height - 160;
            registerLabelNav.Top = this.Height - 155;
            this.ShowIcon = false;

            authLabel.Location = new Point(30, 20);


        }

        private void logTextBox_Enter(object sender, EventArgs e)
        {
            if(logTextBox.Text == "Логин") 
            {
                logTextBox.Text = "";
                logTextBox.ForeColor = Color.Black;
            }
        }

        private void logTextBox_Leave(object sender, EventArgs e)
        {
            if (logTextBox.Text == "")
            {
                logTextBox.Text = "Логин";
                logTextBox.ForeColor = Color.Gray;
            }
        }

        private void passTextBox_Enter(object sender, EventArgs e)
        {
            if (passTextBox.Text == "Пароль")
            {
                passTextBox.Text = "";
                passTextBox.ForeColor = Color.Black;
            }
        }

        private void passTextBox_Leave(object sender, EventArgs e)
        {
            if (passTextBox.Text == "")
            {
                passTextBox.Text = "Пароль";
                passTextBox.ForeColor = Color.Gray;
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string loginUser = logTextBox.Text;
            string passowrdUser = passTextBox.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passowrdUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                login = logTextBox.Text;
                appForm form = new appForm();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("No");
            LoadFont();
        }

        private void registerLabelNav_Click(object sender, EventArgs e)
        {
            Form form = new regForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
